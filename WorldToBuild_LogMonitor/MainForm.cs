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

namespace WorldToBuild_LogMonitor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            MonitorFile();

            consoleBox.SelectedIndexChanged += ConsoleBox_SelectedIndexChanged;
        }

        private void ConsoleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (logEntries.Count > consoleBox.SelectedIndex)
            {
                LogEntry entry = logEntries[consoleBox.SelectedIndex];
                moreInfoBox.Text = entry.StartLine + "\r\n" + entry.StackTrace + "\r\n" + entry.LastLine;
            }
        }

        // LocalApplicationData points to C:\Users\Username\AppData\Local
        public static string logPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"Low\happyninjagames\WorldToBuild\output_log.txt";

        static List<LogEntry> oldLogEntries = null;
        static List<LogEntry> logEntries = new List<LogEntry>();


        public void AddEntryToConsole(LogEntry _entry)
        {
            /*TableLayoutPanel dynamicTableLayoutPanel = new TableLayoutPanel();
            dynamicTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            dynamicTableLayoutPanel.Size = new System.Drawing.Size(consoleBox.Size.Width-4, 64);

            dynamicTableLayoutPanel.ColumnCount = 3;
            dynamicTableLayoutPanel.RowCount = 1;
            dynamicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64f));
            dynamicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 0));
            dynamicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32f));
            //dynamicTableLayoutPanel.Dock = DockStyle.Fill;



            PictureBox imageControl = new PictureBox();
            imageControl.Image = Properties.Resources.commentBubbleIcon;
            imageControl.Size = new Size(64, 64);
            imageControl.Dock = DockStyle.Fill;


            Label logLabel = new Label();
            logLabel.Size = new Size(32, 32);
            logLabel.Text = _entry.StartLine;
            logLabel.Dock = DockStyle.Fill;

            // todo: loop through (n) lines and add those to the text of that label

            _entry.occuranceLabel = new Label();
            _entry.occuranceLabel.Text = _entry.occurances.ToString();
            _entry.occuranceLabel.Dock = DockStyle.Fill;*/

            //dynamicTableLayoutPanel.Controls.Add(imageControl, 0, 0);
            //dynamicTableLayoutPanel.Controls.Add(logLabel, 1, 0);
            //dynamicTableLayoutPanel.Controls.Add(_entry.occuranceLabel, 2, 0);

            consoleBox.Items.Add(_entry.StartLine);
            //consoleBox.ItemHeight = 30;
            //consoleBox.TopIndex = consoleBox.Items.Count - 1;

            //consoleBox.Items.Add(dynamicTableLayoutPanel);
        }

        #region Refresh

        static int ConvertTimeToInt(string input)
        {
            var date = DateTime.ParseExact(input, "hh:mm tt", System.Globalization.CultureInfo.InvariantCulture);
            TimeSpan span = date.TimeOfDay;
            Console.WriteLine("{0:dd/MM/yyyy hh:mm tt}", date);
            return (int)span.Ticks;
        }


        public void RefreshUIFromList()
        {
            if (consoleBox.Items == null || logEntries == null)
            {
                consoleBox.Items.Clear();
            }
            
            int i = 0;
            foreach (LogEntry entry in logEntries)
            {
                if (oldLogEntries == null || oldLogEntries.Count == 0 || i >= oldLogEntries.Count)
                {
                    AddEntryToConsole(entry);

                }
                i++;
            }
            
            if (consoleBox.Items.Count > 0 && scrollStayBox.Checked)
            {
                consoleBox.TopIndex = consoleBox.Items.Count - 1;
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
            Regex linenumRegex = new Regex(@"\(Filename: \w:\\.+ Line: ([0-9]+)\)");
            
            
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

                        LogEntry entry = new LogEntry(entryStartLine, entryStackTrace.ToString(), line);

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
    }
}
