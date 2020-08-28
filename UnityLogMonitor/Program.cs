using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnityLogMonitor
{
    public class LogEntry
    {
        public LogEntry(string _start, string _trace, string _end)
        {

            StartLine = _start;
            StackTrace = _trace;
            LastLine = _end;
        }

        // how many times it has shown up
        public int occurances = 1;

        public Label occuranceLabel = null;

        // the actual print
        public string StartLine = "";

        // the stack trace of the print
        public string StackTrace = "";

        // (Filename: C:\blah\blah: 43)
        public string LastLine = "";

        public bool Equals(LogEntry other)
        {
            if (this.StartLine != other.StartLine) return false;
            if (this.StackTrace != other.StackTrace) return false;
            if (this.LastLine != other.LastLine) return false;
            return true;
        }
    }

    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

    }
}
