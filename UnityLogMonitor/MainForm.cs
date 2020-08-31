using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnityLogMonitor
{
    public partial class MainForm : Form
    {
        // when we clear 31 rows we'll still have logEntires[30], but now the first row will have index 1, we need to remember 31, so we'll keep track of how many rows we've cleared
        int clearanceOFfset = 0;

        public MainForm()
        {
            InitializeComponent();

            MonitorFile();

            consoleBoxDGV.CellClick += ConsoleBoxDGV_CellClick;
            
        }

        private void ConsoleBoxDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (consoleBoxDGV.SelectedRows.Count > 0)
            {
                LogEntry entry = logEntries[consoleBoxDGV.SelectedRows[0].Index + clearanceOFfset];
                moreInfoBox.Text = entry.StartLine + "\r\n" + entry.StackTrace + "\r\n" + entry.LastLine;
            }
        }



        // LocalApplicationData points to C:\Users\Username\AppData\Local
        public static string logPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"Low\happyninjagames\WorldToBuild\output_log.txt";

        static List<LogEntry> oldLogEntries = null;
        static List<LogEntry> logEntries = new List<LogEntry>();

        bool everyOther = false;
        public void AddEntryToConsole(LogEntry _entry)
        {
            DataGridViewRow dgvRow = (DataGridViewRow)consoleBoxDGV.RowTemplate.Clone();
            dgvRow.Height = 48;

            everyOther = !everyOther;
            if (everyOther)
            {
                dgvRow.DefaultCellStyle.BackColor = Color.FromArgb(90, 90, 90);
            }

            

            dgvRow.CreateCells(consoleBoxDGV, GetIcon(_entry), _entry.StartLine + "\r\n" + _entry.LastLine, _entry.occurances.ToString());
            consoleBoxDGV.Rows.Add(dgvRow);

            
            
        }

        #region Refresh


        Regex luaPrintRegex = new Regex("Luaprint: ");
        Regex luaErrorRegex = new Regex("Lua Error: ");
        Regex scriptCallRegex = new Regex(@"at MoonSharp\.Interpreter\.Script\.Call \(");

        public Bitmap GetIcon(LogEntry _entry)
        {
            Bitmap icon = Properties.Resources.commentIcon;
            
            if (luaPrintRegex.IsMatch(_entry.StartLine))
            {
                return Properties.Resources.luaicon;
            }
            else if (luaErrorRegex.IsMatch(_entry.StartLine))
            {
                return Properties.Resources.luaicon;
            }

            if (scriptCallRegex.IsMatch(_entry.StackTrace))
            {
                return Properties.Resources.luaicon;
            }

            return icon;
        }

        public void RefreshUIFromList()
        {
            if (consoleBoxDGV.Rows.Count<1 || logEntries == null)
            {
                consoleBoxDGV.Rows.Clear();
                consoleBoxDGV.Refresh();
            }

            bool addedEntries = false;

            int i = 0;
            foreach (LogEntry entry in logEntries)
            {
                if (oldLogEntries == null || oldLogEntries.Count == 0 || i >= oldLogEntries.Count)
                {
                    AddEntryToConsole(entry);
                    addedEntries = true;
                }
                i++;
            }

            if (addedEntries)
            {

                if (consoleBoxDGV.Rows.Count > 0 && scrollStayBox.Checked)
                {
                    consoleBoxDGV.FirstDisplayedScrollingRowIndex = consoleBoxDGV.RowCount - 1;
                }
            }
            
            fileCheckTimer.Enabled = true;

        }

        void RefreshListFromFile()
        {
            fileCheckTimer.Enabled = false;

            oldLogEntries = logEntries;
            logEntries = new List<LogEntry>();

            // once we fill up both of these we can throw it into a LogEntry
            string entryStartLine = "";
            StringBuilder entryStackTrace = new StringBuilder();

            // true if we've passed the first little section of the log file
            bool pastUnloadTime = false;

            int counter = 0;

            List<string> file = new List<string>();

            using (FileStream stream = File.Open(logPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = reader.ReadLine()) != null)
                    {
                        file.Add(line);
                    }
                }
            }
           

            Regex unloadRegex = new Regex(@"UnloadTime:.+ms");
            Regex linenumRegex = new Regex(@"\(Filename: .+Line: .+\)");
            
            
            foreach (var line in file.ToArray())
            {

                if (line == "" && line == "\n")
                {
                    continue;
                }

                // if we don't have a startline written down, this is the startline
                if (entryStartLine == "")
                {
                    entryStackTrace.Clear();
                    entryStartLine = line;
                }
                // if the startline isn't open, this is part of the stack trace, unless it's the last line which we need to detect
                else
                {
                    Regex lastLineTestRegex = unloadRegex;

                    if (pastUnloadTime)
                    {
                        lastLineTestRegex = linenumRegex;
                    }

                    if (lastLineTestRegex.Match(line).Success)
                    {
                        // if we're not past the info block at the beginning, we are now
                        if (!pastUnloadTime) pastUnloadTime = true;

                        LogEntry entry = new LogEntry(entryStartLine, entryStackTrace.ToString(), line, logEntries.Count);

                        // if the last entry is the same as this one, just increase its occurances
                        int count = logEntries.Count;
                        if (count > 0 && logEntries[count - 1].StartLine == entry.StartLine)
                        {
                            logEntries[count - 1].occurances += 1;
                        }
                        else
                        {
                            logEntries.Add(entry);
                        }

                        entryStartLine = "";
                    }
                    else
                    {
                        entryStackTrace.Append("\r\n" + line);
                    }

                }

                counter++;
            }
                
            RefreshUIFromList();


        }

        #endregion

        #region File-Watcher

        void MonitorFile()
        {
            fileCheckTimer.Tick += FileCheckTimer_Tick;
        }

        private void FileCheckTimer_Tick(object sender, EventArgs e)
        {
            if (refreshCheckBox.Checked)
            {
                RefreshListFromFile();
            }
        }


        #endregion

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshListFromFile();
        }

        private void alwaysOnTopCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = alwaysOnTopCheckbox.Checked;
        }

        private void clearConsoleButton_Click(object sender, EventArgs e)
        {
            clearanceOFfset += consoleBoxDGV.RowCount;
            consoleBoxDGV.Rows.Clear();
            consoleBoxDGV.Refresh();
        }
    }
}
