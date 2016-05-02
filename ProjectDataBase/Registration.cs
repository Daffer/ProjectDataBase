using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDataBase
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void T_Login_Leave(object sender, EventArgs e)
        {
            string Login = this.T_Login.Text;
            LoginState = Program.Base.CheckLogin(Login);
            if (LoginState == true)
            {
                this.L_Check_Login.ForeColor = Color.Green;
                this.L_Check_Login.Text = "Логин свободен";
            }
            else
            {
                this.L_Check_Login.ForeColor = Color.Red;
                this.L_Check_Login.Text = "Логин занят";
            }
            return;
        }

        private void B_Ok_Click(object sender, EventArgs e)
        {
            if (PasswordState == true && LoginState == true)
            {
                string Login = this.T_Login.Text;
                string Password = this.T_Password1.Text;
                string Surname = this.T_Surname.Text;
                string Name = this.T_Name.Text;
                string Secondname = this.T_SecondName.Text;
                string Email = this.T_Email.Text;
                string Location = this.T_Location.Text;
                bool State = false;
                State = Program.Base.Registration(Login, Password, Surname, Name, Secondname, Email, Location, "Users");
                if (State == true)
                {
                    this.Dispose();
                }
            }
            else
            {
                if (PasswordState == false)
                    this.T_Password1.Focus();
                else
                    this.T_Login.Focus();
            }
        }

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void T_Password2_TextChanged(object sender, EventArgs e)
        {
            if (this.T_Password1.Text != this.T_Password2.Text)
            {
                this.L_Password_State.ForeColor = Color.Red;
                this.L_Password_State.Text = "Пароли не совпадают!";
                this.PasswordState = false;
            }
            else
            {
                this.L_Password_State.ForeColor = Color.Green;
                this.L_Password_State.Text = "Пароли совпадают";
                this.PasswordState = true;
            }
        }
        private bool PasswordState = false;
        private bool LoginState = false;

        private void T_Password1_TextChanged(object sender, EventArgs e)
        {
            if (this.T_Password1.Text != this.T_Password2.Text)
            {
                this.L_Password_State.ForeColor = Color.Red;
                this.L_Password_State.Text = "Пароли не совпадают!";
                this.PasswordState = false;
            }
            else
            {
                this.L_Password_State.ForeColor = Color.Green;
                this.L_Password_State.Text = "Пароли совпадают";
                this.PasswordState = true;
            }

        }
    }
}
