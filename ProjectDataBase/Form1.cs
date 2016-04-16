﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
namespace ProjectDataBase
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Program.Base.GetException().ErrorMsg += HandleEventCurrentState;
        }
        
        private void EditPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Pwd.AppendChar(e.KeyChar);
        }
        SecureString Pwd = new SecureString();

        private void But_Authorization_Click(object sender, EventArgs e)
        {
            string Login = Edit_Login.Text;
            Pwd.MakeReadOnly();
            bool Connection = false;
            Connection = Program.Base.ConnectToDataBase(Login, Pwd);
            if (Connection == true)
            {
                this.grbox_AuthorizationField.Visible = false;
            }
            else
            {
                Pwd.Dispose();
                Pwd = new SecureString();
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Registr = new Registration();
            Registr.Show();
        }
        
        void HandleEventCurrentState(object sender, string msg)
        {
            ProgramState.Text = msg;
        }
        
    }
}
