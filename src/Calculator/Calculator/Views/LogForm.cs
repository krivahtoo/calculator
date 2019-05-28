using System;
using System.IO;
using System.Windows.Forms;
using Calculator.Sources;

namespace Calculator.Views
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }
        public static void Log(string txt)
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                Logger lg = new Logger();
                lg.Log(logMessage: txt, w: w);
            }
        }
        private void LogForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("log.txt"))
                {
                    // Read the steam to a string, and write the string to the text box.
                    String line = sr.ReadToEnd();
                    textBoxLog.Text = line;
                }
            }
            catch (IOException er)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(er.Message);
            }
        }

        private void textBoxLog_TextChanged(object sender, EventArgs e)
        {
            VScrollBar vScrollBar = new VScrollBar();
            vScrollBar.Dock = DockStyle.Right;
            vScrollBar.Name = "vScrollBar1";
            this.Controls.Add(vScrollBar);

        }
    }
}
