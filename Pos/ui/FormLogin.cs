using Pos.controllers;
using Pos.ui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            lblStatusSuccess.Hide();
            lblStatusSuccess.Text = "";
            lblStatusError.Hide();
            lblStatusError.Text = "";
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
            {
                if (checkInputsValue())
                {
                    login();
                }
            }
                   
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (checkInputsValue())
                {
                    login();
                }
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checkInputsValue())
            {
                login();
            }
        }

        private bool checkInputsValue()
        {
            lblStatusSuccess.Hide();
            lblStatusSuccess.Text = "";
            lblStatusError.Hide();
            lblStatusError.Text = "";

            if (txtUsername.Text == "")
            {
                txtUsername.Focus();
                return false;
            }else if(txtPassword.Text == "")
            {
                txtPassword.Focus();
                return false;
            }

            btnLogin.Focus();
            return true;
        }

        private bool login()
        {
            Encryption encryption = new Encryption();
            string userName = txtUsername.Text;
            string password = encryption.CreateMD5(txtPassword.Text.ToString());

            Login login = new Login();
            //if(login.UserAuthenticate(userName , password)){
            //    lblStatusSuccess.Show();
            //    LoadDashboard();
            //    lblStatusSuccess.Text = "Login Success..!";
            //    return true;
            //}else
            //{
            //    lblStatusError.Show();
            //    lblStatusError.Text = "Login Faield..! \n\n Check Your User Name & Password";
            //    return false;
            //}
            return true;
        }

        private void LoadDashboard()
        {
            FormDashboard dashboard = new FormDashboard();
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }

       
    }
}
