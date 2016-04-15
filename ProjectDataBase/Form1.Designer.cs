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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditPassword = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.But_EnterInDB = new System.Windows.Forms.Button();
            this.grbox_AuthorizationField.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbox_AuthorizationField
            // 
            this.grbox_AuthorizationField.Controls.Add(this.label2);
            this.grbox_AuthorizationField.Controls.Add(this.label1);
            this.grbox_AuthorizationField.Controls.Add(this.EditPassword);
            this.grbox_AuthorizationField.Controls.Add(this.textBox1);
            this.grbox_AuthorizationField.Controls.Add(this.But_EnterInDB);
            this.grbox_AuthorizationField.Location = new System.Drawing.Point(12, 12);
            this.grbox_AuthorizationField.Name = "grbox_AuthorizationField";
            this.grbox_AuthorizationField.Size = new System.Drawing.Size(596, 57);
            this.grbox_AuthorizationField.TabIndex = 2;
            this.grbox_AuthorizationField.TabStop = false;
            this.grbox_AuthorizationField.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // EditPassword
            // 
            this.EditPassword.Location = new System.Drawing.Point(361, 18);
            this.EditPassword.Name = "EditPassword";
            this.EditPassword.PasswordChar = 'П';
            this.EditPassword.Size = new System.Drawing.Size(135, 20);
            this.EditPassword.TabIndex = 7;
            this.EditPassword.Text = "Пароль";
            this.EditPassword.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // But_EnterInDB
            // 
            this.But_EnterInDB.Location = new System.Drawing.Point(502, 16);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EditPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button But_EnterInDB;
    }
}

