using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestLibrary
{
    public class DoWork
    {
        public int processCount { get; set; }
        public string  processText { get; set; }

        public void countTo100()
        {
            processCount = 0;

            while (processCount < 100)
            {
                processText += $"Counting {processCount} of 100\r\n";
                processCount++;
                System.Threading.Thread.Sleep(500);
            }
        }
        public string getProcessTest()
        {
            return processText;
        }
    }
}
