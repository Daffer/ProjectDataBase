using System;
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
            this.ProgramState.Text = Program.Base.ConnectToDataBase(Login, Pwd,ref Connection);
            if ( Connection == true)
                this.grbox_AuthorizationField.Visible = false;
            Pwd = new SecureString();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Registr = new Registration();
            Registr.Show();
        }

        public void ProgramCurrentState(string Message)
        {
            this.ProgramState.Text = Message;
        }
    }
}
