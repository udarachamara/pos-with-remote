using Pos.ui;
using Pos.ui.tasks.settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos.controllers
{
    class TaskView
    {
        public TaskView()
        {
           
        }
        public bool loadUserForm(Control panelFormDocker, EventArgs e)
        {
            FormUser userForm = new FormUser();
            List<Form> forms = panelFormDocker.Controls.OfType<Form>().ToList();
            foreach (Form form in forms)
            {
                panelFormDocker.Controls.Remove(form);
                form.Dispose();
            }
            userForm.TopLevel = false;
            userForm.AutoScroll = true;
            panelFormDocker.Controls.Add(userForm);
            userForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            userForm.Dock = DockStyle.Fill;
            userForm.Show();
            return true;
        }
    }
}
