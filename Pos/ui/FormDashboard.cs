using Pos.controllers;
using Pos.ui.tasks;
using Pos.ui.tasks.settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos.ui
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            FormHome home = new FormHome();
            home.TopLevel = false;
            home.AutoScroll = true;
            panelFormDocker.Controls.Add(home);
            home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            home.Dock = DockStyle.Fill;
            home.Show();
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

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskView tw = new TaskView();
            tw.loadUserForm(this.panelFormDocker, null);
        }
    }
}
