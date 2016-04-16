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
            this.ProgramState.Text = Program.Base.ConnectToDataBase(Login, Pwd);
            return;
        }
    }
}
