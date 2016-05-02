namespace ProjectDataBase
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.T_Login = new System.Windows.Forms.TextBox();
            this.T_Password1 = new System.Windows.Forms.TextBox();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.L_Login = new System.Windows.Forms.Label();
            this.L_Password1 = new System.Windows.Forms.Label();
            this.B_Ok = new System.Windows.Forms.Button();
            this.T_Password2 = new System.Windows.Forms.TextBox();
            this.T_Surname = new System.Windows.Forms.TextBox();
            this.T_Name = new System.Windows.Forms.TextBox();
            this.T_SecondName = new System.Windows.Forms.TextBox();
            this.T_Email = new System.Windows.Forms.TextBox();
            this.L_Password2 = new System.Windows.Forms.Label();
            this.L_Surname = new System.Windows.Forms.Label();
            this.L_Name = new System.Windows.Forms.Label();
            this.L_SecondName = new System.Windows.Forms.Label();
            this.L_Email = new System.Windows.Forms.Label();
            this.L_Password_State = new System.Windows.Forms.Label();
            this.L_Location = new System.Windows.Forms.Label();
            this.T_Location = new System.Windows.Forms.TextBox();
            this.L_Check_Login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // T_Login
            // 
            this.T_Login.Location = new System.Drawing.Point(120, 6);
            this.T_Login.Name = "T_Login";
            this.T_Login.Size = new System.Drawing.Size(163, 20);
            this.T_Login.TabIndex = 0;
            this.T_Login.Leave += new System.EventHandler(this.T_Login_Leave);
            // 
            // T_Password1
            // 
            this.T_Password1.Location = new System.Drawing.Point(120, 53);
            this.T_Password1.Name = "T_Password1";
            this.T_Password1.Size = new System.Drawing.Size(163, 20);
            this.T_Password1.TabIndex = 1;
            this.T_Password1.TextChanged += new System.EventHandler(this.T_Password1_TextChanged);
            // 
            // B_Cancel
            // 
            this.B_Cancel.Location = new System.Drawing.Point(167, 276);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(75, 23);
            this.B_Cancel.TabIndex = 2;
            this.B_Cancel.Text = "Отменить";
            this.B_Cancel.UseVisualStyleBackColor = true;
            this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
            // 
            // L_Login
            // 
            this.L_Login.AutoSize = true;
            this.L_Login.Location = new System.Drawing.Point(12, 9);
            this.L_Login.Name = "L_Login";
            this.L_Login.Size = new System.Drawing.Size(38, 13);
            this.L_Login.TabIndex = 3;
            this.L_Login.Text = "Логин";
            // 
            // L_Password1
            // 
            this.L_Password1.AutoSize = true;
            this.L_Password1.Location = new System.Drawing.Point(12, 56);
            this.L_Password1.Name = "L_Password1";
            this.L_Password1.Size = new System.Drawing.Size(45, 13);
            this.L_Password1.TabIndex = 4;
            this.L_Password1.Text = "Пароль";
            // 
            // B_Ok
            // 
            this.B_Ok.Location = new System.Drawing.Point(48, 276);
            this.B_Ok.Name = "B_Ok";
            this.B_Ok.Size = new System.Drawing.Size(75, 23);
            this.B_Ok.TabIndex = 5;
            this.B_Ok.Text = "Принять";
            this.B_Ok.UseVisualStyleBackColor = true;
            this.B_Ok.Click += new System.EventHandler(this.B_Ok_Click);
            // 
            // T_Password2
            // 
            this.T_Password2.Location = new System.Drawing.Point(120, 79);
            this.T_Password2.Name = "T_Password2";
            this.T_Password2.Size = new System.Drawing.Size(163, 20);
            this.T_Password2.TabIndex = 6;
            this.T_Password2.TextChanged += new System.EventHandler(this.T_Password2_TextChanged);
            // 
            // T_Surname
            // 
            this.T_Surname.Location = new System.Drawing.Point(120, 122);
            this.T_Surname.Name = "T_Surname";
            this.T_Surname.Size = new System.Drawing.Size(163, 20);
            this.T_Surname.TabIndex = 7;
            // 
            // T_Name
            // 
            this.T_Name.Location = new System.Drawing.Point(120, 148);
            this.T_Name.Name = "T_Name";
            this.T_Name.Size = new System.Drawing.Size(163, 20);
            this.T_Name.TabIndex = 8;
            // 
            // T_SecondName
            // 
            this.T_SecondName.Location = new System.Drawing.Point(120, 174);
            this.T_SecondName.Name = "T_SecondName";
            this.T_SecondName.Size = new System.Drawing.Size(163, 20);
            this.T_SecondName.TabIndex = 9;
            // 
            // T_Email
            // 
            this.T_Email.Location = new System.Drawing.Point(120, 200);
            this.T_Email.Name = "T_Email";
            this.T_Email.Size = new System.Drawing.Size(163, 20);
            this.T_Email.TabIndex = 10;
            // 
            // L_Password2
            // 
            this.L_Password2.AutoSize = true;
            this.L_Password2.Location = new System.Drawing.Point(12, 82);
            this.L_Password2.Name = "L_Password2";
            this.L_Password2.Size = new System.Drawing.Size(100, 13);
            this.L_Password2.TabIndex = 11;
            this.L_Password2.Text = "Повторите пароль";
            // 
            // L_Surname
            // 
            this.L_Surname.AutoSize = true;
            this.L_Surname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.L_Surname.Location = new System.Drawing.Point(12, 125);
            this.L_Surname.Name = "L_Surname";
            this.L_Surname.Size = new System.Drawing.Size(56, 13);
            this.L_Surname.TabIndex = 12;
            this.L_Surname.Text = "Фамилия";
            // 
            // L_Name
            // 
            this.L_Name.AutoSize = true;
            this.L_Name.Location = new System.Drawing.Point(12, 151);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(29, 13);
            this.L_Name.TabIndex = 13;
            this.L_Name.Text = "Имя";
            // 
            // L_SecondName
            // 
            this.L_SecondName.AutoSize = true;
            this.L_SecondName.Location = new System.Drawing.Point(12, 177);
            this.L_SecondName.Name = "L_SecondName";
            this.L_SecondName.Size = new System.Drawing.Size(54, 13);
            this.L_SecondName.TabIndex = 14;
            this.L_SecondName.Text = "Отчество";
            // 
            // L_Email
            // 
            this.L_Email.AutoSize = true;
            this.L_Email.Location = new System.Drawing.Point(12, 203);
            this.L_Email.Name = "L_Email";
            this.L_Email.Size = new System.Drawing.Size(37, 13);
            this.L_Email.TabIndex = 15;
            this.L_Email.Text = "Почта";
            // 
            // L_Password_State
            // 
            this.L_Password_State.AutoSize = true;
            this.L_Password_State.Location = new System.Drawing.Point(117, 106);
            this.L_Password_State.Name = "L_Password_State";
            this.L_Password_State.Size = new System.Drawing.Size(0, 13);
            this.L_Password_State.TabIndex = 16;
            // 
            // L_Location
            // 
            this.L_Location.AutoSize = true;
            this.L_Location.Location = new System.Drawing.Point(12, 229);
            this.L_Location.Name = "L_Location";
            this.L_Location.Size = new System.Drawing.Size(38, 13);
            this.L_Location.TabIndex = 17;
            this.L_Location.Text = "Адрес";
            // 
            // T_Location
            // 
            this.T_Location.Location = new System.Drawing.Point(120, 226);
            this.T_Location.Name = "T_Location";
            this.T_Location.Size = new System.Drawing.Size(163, 20);
            this.T_Location.TabIndex = 18;
            // 
            // L_Check_Login
            // 
            this.L_Check_Login.AutoSize = true;
            this.L_Check_Login.Location = new System.Drawing.Point(123, 32);
            this.L_Check_Login.Name = "L_Check_Login";
            this.L_Check_Login.Size = new System.Drawing.Size(0, 13);
            this.L_Check_Login.TabIndex = 19;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 311);
            this.Controls.Add(this.L_Check_Login);
            this.Controls.Add(this.T_Location);
            this.Controls.Add(this.L_Location);
            this.Controls.Add(this.L_Password_State);
            this.Controls.Add(this.L_Email);
            this.Controls.Add(this.L_SecondName);
            this.Controls.Add(this.L_Name);
            this.Controls.Add(this.L_Surname);
            this.Controls.Add(this.L_Password2);
            this.Controls.Add(this.T_Email);
            this.Controls.Add(this.T_SecondName);
            this.Controls.Add(this.T_Name);
            this.Controls.Add(this.T_Surname);
            this.Controls.Add(this.T_Password2);
            this.Controls.Add(this.B_Ok);
            this.Controls.Add(this.L_Password1);
            this.Controls.Add(this.L_Login);
            this.Controls.Add(this.B_Cancel);
            this.Controls.Add(this.T_Password1);
            this.Controls.Add(this.T_Login);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox T_Login;
        private System.Windows.Forms.TextBox T_Password1;
        private System.Windows.Forms.Button B_Cancel;
        private System.Windows.Forms.Label L_Login;
        private System.Windows.Forms.Label L_Password1;
        private System.Windows.Forms.Button B_Ok;
        private System.Windows.Forms.TextBox T_Password2;
        private System.Windows.Forms.TextBox T_Surname;
        private System.Windows.Forms.TextBox T_Name;
        private System.Windows.Forms.TextBox T_SecondName;
        private System.Windows.Forms.TextBox T_Email;
        private System.Windows.Forms.Label L_Password2;
        private System.Windows.Forms.Label L_Surname;
        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.Label L_SecondName;
        private System.Windows.Forms.Label L_Email;
        private System.Windows.Forms.Label L_Password_State;
        private System.Windows.Forms.Label L_Location;
        private System.Windows.Forms.TextBox T_Location;
        private System.Windows.Forms.Label L_Check_Login;
    }
}