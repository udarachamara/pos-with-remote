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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.TopLevel = false;
            formDashboard.AutoScroll = true;
            panelFormDocker.Controls.Add(formDashboard);
            formDashboard.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formDashboard.Dock = DockStyle.Fill;
            formDashboard.Show();
            
        }

        

    }
}
