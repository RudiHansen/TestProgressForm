using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLibrary;

namespace TestProgressForm
{
    public partial class Form1 : Form
    {
        DoWork doWork = new DoWork();
        Task task;

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            timer1.Start();
            startButton.Enabled = false;
            progressBar1.Maximum = 100;
            task = new Task(new Action(doWork.countTo100));
            task.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (task.IsCompleted)
            {
                timer1.Stop();
                messageTextBox.AppendText("Work done!");
                progressBar1.Value = progressBar1.Maximum;
                startButton.Enabled = true;
            }
            {
                string processText = doWork.processText;
                doWork.processText = "";
                messageTextBox.AppendText(processText);
                progressBar1.Value = doWork.processCount;
            }
        }
    }
}
