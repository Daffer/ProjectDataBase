namespace ProjectDataBase
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbox_AuthorizationField = new System.Windows.Forms.GroupBox();
            this.Lab_Password = new System.Windows.Forms.Label();
            this.Lab_Login = new System.Windows.Forms.Label();
            this.EditPassword = new System.Windows.Forms.TextBox();
            this.Edit_Login = new System.Windows.Forms.TextBox();
            this.But_EnterInDB = new System.Windows.Forms.Button();
            this.grbox_AuthorizationField.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbox_AuthorizationField
            // 
            this.grbox_AuthorizationField.Controls.Add(this.Lab_Password);
            this.grbox_AuthorizationField.Controls.Add(this.Lab_Login);
            this.grbox_AuthorizationField.Controls.Add(this.EditPassword);
            this.grbox_AuthorizationField.Controls.Add(this.Edit_Login);
            this.grbox_AuthorizationField.Controls.Add(this.But_EnterInDB);
            this.grbox_AuthorizationField.Location = new System.Drawing.Point(12, 12);
            this.grbox_AuthorizationField.Name = "grbox_AuthorizationField";
            this.grbox_AuthorizationField.Size = new System.Drawing.Size(596, 57);
            this.grbox_AuthorizationField.TabIndex = 2;
            this.grbox_AuthorizationField.TabStop = false;
            this.grbox_AuthorizationField.Text = "Авторизация";
            // 
            // Lab_Password
            // 
            this.Lab_Password.AutoSize = true;
            this.Lab_Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.Lab_Password.Location = new System.Drawing.Point(216, 19);
            this.Lab_Password.Name = "Lab_Password";
            this.Lab_Password.Size = new System.Drawing.Size(52, 15);
            this.Lab_Password.TabIndex = 9;
            this.Lab_Password.Text = "Пароль:";
            // 
            // Lab_Login
            // 
            this.Lab_Login.AutoSize = true;
            this.Lab_Login.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.Lab_Login.Location = new System.Drawing.Point(21, 19);
            this.Lab_Login.Name = "Lab_Login";
            this.Lab_Login.Size = new System.Drawing.Size(45, 15);
            this.Lab_Login.TabIndex = 8;
            this.Lab_Login.Text = "Логин:";
            // 
            // EditPassword
            // 
            this.EditPassword.Location = new System.Drawing.Point(274, 17);
            this.EditPassword.Name = "EditPassword";
            this.EditPassword.PasswordChar = 'П';
            this.EditPassword.Size = new System.Drawing.Size(135, 20);
            this.EditPassword.TabIndex = 7;
            this.EditPassword.UseSystemPasswordChar = true;
            // 
            // Edit_Login
            // 
            this.Edit_Login.Location = new System.Drawing.Point(72, 17);
            this.Edit_Login.Name = "Edit_Login";
            this.Edit_Login.Size = new System.Drawing.Size(138, 20);
            this.Edit_Login.TabIndex = 6;
            // 
            // But_EnterInDB
            // 
            this.But_EnterInDB.Location = new System.Drawing.Point(415, 15);
            this.But_EnterInDB.Name = "But_EnterInDB";
            this.But_EnterInDB.Size = new System.Drawing.Size(75, 23);
            this.But_EnterInDB.TabIndex = 5;
            this.But_EnterInDB.Text = "button1";
            this.But_EnterInDB.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(706, 335);
            this.Controls.Add(this.grbox_AuthorizationField);
            this.Name = "MainWindow";
            this.grbox_AuthorizationField.ResumeLayout(false);
            this.grbox_AuthorizationField.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ProgrammState;
        private System.Windows.Forms.GroupBox grbox_AuthorizationField;
        private System.Windows.Forms.Label Lab_Password;
        private System.Windows.Forms.Label Lab_Login;
        private System.Windows.Forms.TextBox EditPassword;
        private System.Windows.Forms.TextBox Edit_Login;
        private System.Windows.Forms.Button But_EnterInDB;
    }
}

