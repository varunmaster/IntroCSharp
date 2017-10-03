using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace multithread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTimeConsumingWork_Click(object sender, EventArgs e)
        {
            btnTimeConsumingWork.Enabled = false;
            btnPrintNumbers.Enabled = false;

            ///<summary>
            ///1. if we comment out the next two lines and uncomment out the DoTimeConsumingWork(); then what will happen is that when we click on the button 
            ///"Do Time Consuming Work" the process/thread will be occupied by one of the process, which is the DoTimeConsumingWork method, and the rest of the
            ///application will be unresponsive. In order to still use the application while it is doing some sort of time consuming work, we should give the
            ///time consuming work to some other thread so the application is still usable. In order to give it to another thread, we first call another thread
            ///called the workerThread and then assign it some time consuming work so there is no delay/the application doesn't become unresponsive.
            ///</summary>
            Thread workerThread = new Thread(DoTimeConsumingWork);
            workerThread.Start();
            //DoTimeConsumingWork();

            btnTimeConsumingWork.Enabled = true;
            btnPrintNumbers.Enabled = true;
        }

        private void DoTimeConsumingWork()
        {
            Thread.Sleep(5000);
        }

        private void btnPrintNumbers_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 10; i++)
            {
                listBoxNumbers.Items.Add(i);
            }
        }

        private void listBoxNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
