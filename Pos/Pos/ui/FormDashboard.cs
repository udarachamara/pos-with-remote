using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.ui
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            RunTimer();
        }

        public void RunTimer()
        {
            Task task = Task.Run(() => {
                setLabelClockTimeSafe();
                System.Threading.Thread.Sleep(1000);
                RunTimer();
            });
            
        }

        private void setLabelClockTimeSafe()
        {
            String time = DateTime.Now.ToString("ddd, dd MMM yyy hh:mm:ss tt");
            if (lblClock.InvokeRequired)
                lblClock.Invoke(new Action(() => lblClock.Text = time));
            else
                lblClock.Text = time;
        }
    }
}
