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
            this.But_Registration = new System.Windows.Forms.Button();
            this.Lab_Password = new System.Windows.Forms.Label();
            this.Lab_Login = new System.Windows.Forms.Label();
            this.Edit_Password = new System.Windows.Forms.TextBox();
            this.Edit_Login = new System.Windows.Forms.TextBox();
            this.But_Authorization = new System.Windows.Forms.Button();
            this.ProgramState = new System.Windows.Forms.TextBox();
            this.Categories = new System.Windows.Forms.GroupBox();
            this.P_Configuration = new System.Windows.Forms.Panel();
            this.P_Computer = new System.Windows.Forms.Panel();
            this.P_GraphicsController = new System.Windows.Forms.Panel();
            this.P_Disks = new System.Windows.Forms.Panel();
            this.P_MotherBoard = new System.Windows.Forms.Panel();
            this.P_Processor = new System.Windows.Forms.Panel();
            this.GB_DataSet = new System.Windows.Forms.GroupBox();
            this.grbox_AuthorizationField.SuspendLayout();
            this.Categories.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbox_AuthorizationField
            // 
            this.grbox_AuthorizationField.Controls.Add(this.But_Registration);
            this.grbox_AuthorizationField.Controls.Add(this.Lab_Password);
            this.grbox_AuthorizationField.Controls.Add(this.Lab_Login);
            this.grbox_AuthorizationField.Controls.Add(this.Edit_Password);
            this.grbox_AuthorizationField.Controls.Add(this.Edit_Login);
            this.grbox_AuthorizationField.Controls.Add(this.But_Authorization);
            this.grbox_AuthorizationField.Location = new System.Drawing.Point(5, 5);
            this.grbox_AuthorizationField.Name = "grbox_AuthorizationField";
            this.grbox_AuthorizationField.Size = new System.Drawing.Size(595, 47);
            this.grbox_AuthorizationField.TabIndex = 2;
            this.grbox_AuthorizationField.TabStop = false;
            this.grbox_AuthorizationField.Text = "Авторизация";
            // 
            // But_Registration
            // 
            this.But_Registration.Location = new System.Drawing.Point(496, 15);
            this.But_Registration.Name = "But_Registration";
            this.But_Registration.Size = new System.Drawing.Size(89, 23);
            this.But_Registration.TabIndex = 10;
            this.But_Registration.Text = "Регистрация";
            this.But_Registration.UseVisualStyleBackColor = true;
            this.But_Registration.Click += new System.EventHandler(this.button1_Click);
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
            // Edit_Password
            // 
            this.Edit_Password.Location = new System.Drawing.Point(274, 17);
            this.Edit_Password.Name = "Edit_Password";
            this.Edit_Password.Size = new System.Drawing.Size(135, 20);
            this.Edit_Password.TabIndex = 7;
            this.Edit_Password.UseSystemPasswordChar = true;
            this.Edit_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditPassword_KeyPress);
            // 
            // Edit_Login
            // 
            this.Edit_Login.Location = new System.Drawing.Point(72, 17);
            this.Edit_Login.Name = "Edit_Login";
            this.Edit_Login.Size = new System.Drawing.Size(138, 20);
            this.Edit_Login.TabIndex = 6;
            // 
            // But_Authorization
            // 
            this.But_Authorization.Location = new System.Drawing.Point(415, 15);
            this.But_Authorization.Name = "But_Authorization";
            this.But_Authorization.Size = new System.Drawing.Size(75, 23);
            this.But_Authorization.TabIndex = 5;
            this.But_Authorization.Text = "Войти";
            this.But_Authorization.UseVisualStyleBackColor = true;
            this.But_Authorization.Click += new System.EventHandler(this.But_Authorization_Click);
            // 
            // ProgramState
            // 
            this.ProgramState.Location = new System.Drawing.Point(5, 293);
            this.ProgramState.Name = "ProgramState";
            this.ProgramState.Size = new System.Drawing.Size(595, 20);
            this.ProgramState.TabIndex = 3;
            // 
            // Categories
            // 
            this.Categories.Controls.Add(this.P_Configuration);
            this.Categories.Controls.Add(this.P_Computer);
            this.Categories.Controls.Add(this.P_GraphicsController);
            this.Categories.Controls.Add(this.P_Disks);
            this.Categories.Controls.Add(this.P_MotherBoard);
            this.Categories.Controls.Add(this.P_Processor);
            this.Categories.Location = new System.Drawing.Point(5, 58);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(463, 229);
            this.Categories.TabIndex = 4;
            this.Categories.TabStop = false;
            this.Categories.Text = "Меню";
            // 
            // P_Configuration
            // 
            this.P_Configuration.BackColor = System.Drawing.SystemColors.Control;
            this.P_Configuration.BackgroundImage = global::ProjectDataBase.Properties.Resources.Configuration;
            this.P_Configuration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.P_Configuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_Configuration.Location = new System.Drawing.Point(328, 123);
            this.P_Configuration.Name = "P_Configuration";
            this.P_Configuration.Size = new System.Drawing.Size(91, 100);
            this.P_Configuration.TabIndex = 5;
            // 
            // P_Computer
            // 
            this.P_Computer.BackColor = System.Drawing.SystemColors.Control;
            this.P_Computer.BackgroundImage = global::ProjectDataBase.Properties.Resources.computer;
            this.P_Computer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.P_Computer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_Computer.Location = new System.Drawing.Point(231, 123);
            this.P_Computer.Name = "P_Computer";
            this.P_Computer.Size = new System.Drawing.Size(91, 100);
            this.P_Computer.TabIndex = 3;
            // 
            // P_GraphicsController
            // 
            this.P_GraphicsController.BackColor = System.Drawing.SystemColors.Control;
            this.P_GraphicsController.BackgroundImage = global::ProjectDataBase.Properties.Resources.GraphicsController;
            this.P_GraphicsController.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.P_GraphicsController.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_GraphicsController.Location = new System.Drawing.Point(328, 17);
            this.P_GraphicsController.Name = "P_GraphicsController";
            this.P_GraphicsController.Size = new System.Drawing.Size(91, 100);
            this.P_GraphicsController.TabIndex = 4;
            this.P_GraphicsController.Click += new System.EventHandler(this.P_GraphicsController_Click);
            // 
            // P_Disks
            // 
            this.P_Disks.BackColor = System.Drawing.SystemColors.Control;
            this.P_Disks.BackgroundImage = global::ProjectDataBase.Properties.Resources.hdd;
            this.P_Disks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.P_Disks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_Disks.Location = new System.Drawing.Point(134, 123);
            this.P_Disks.Name = "P_Disks";
            this.P_Disks.Size = new System.Drawing.Size(91, 100);
            this.P_Disks.TabIndex = 2;
            // 
            // P_MotherBoard
            // 
            this.P_MotherBoard.BackColor = System.Drawing.SystemColors.Control;
            this.P_MotherBoard.BackgroundImage = global::ProjectDataBase.Properties.Resources.MotherBoard;
            this.P_MotherBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.P_MotherBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_MotherBoard.Location = new System.Drawing.Point(231, 17);
            this.P_MotherBoard.Name = "P_MotherBoard";
            this.P_MotherBoard.Size = new System.Drawing.Size(91, 100);
            this.P_MotherBoard.TabIndex = 1;
            // 
            // P_Processor
            // 
            this.P_Processor.BackColor = System.Drawing.SystemColors.Control;
            this.P_Processor.BackgroundImage = global::ProjectDataBase.Properties.Resources.processor;
            this.P_Processor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.P_Processor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_Processor.Location = new System.Drawing.Point(134, 17);
            this.P_Processor.Name = "P_Processor";
            this.P_Processor.Size = new System.Drawing.Size(91, 100);
            this.P_Processor.TabIndex = 0;
            this.P_Processor.Click += new System.EventHandler(this.P_Processor_Click);
            // 
            // GB_DataSet
            // 
            this.GB_DataSet.Location = new System.Drawing.Point(623, 20);
            this.GB_DataSet.Name = "GB_DataSet";
            this.GB_DataSet.Size = new System.Drawing.Size(437, 229);
            this.GB_DataSet.TabIndex = 5;
            this.GB_DataSet.TabStop = false;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(992, 321);
            this.Controls.Add(this.GB_DataSet);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.ProgramState);
            this.Controls.Add(this.grbox_AuthorizationField);
            this.Name = "MainWindow";
            this.grbox_AuthorizationField.ResumeLayout(false);
            this.grbox_AuthorizationField.PerformLayout();
            this.Categories.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbox_AuthorizationField;
        private System.Windows.Forms.Label Lab_Password;
        private System.Windows.Forms.Label Lab_Login;
        private System.Windows.Forms.TextBox Edit_Password;
        private System.Windows.Forms.TextBox Edit_Login;
        private System.Windows.Forms.Button But_Authorization;
        private System.Windows.Forms.Button But_Registration;
        private System.Windows.Forms.TextBox ProgramState;
        private System.Windows.Forms.GroupBox Categories;
        private System.Windows.Forms.Panel P_Configuration;
        private System.Windows.Forms.Panel P_Computer;
        private System.Windows.Forms.Panel P_GraphicsController;
        private System.Windows.Forms.Panel P_Disks;
        private System.Windows.Forms.Panel P_MotherBoard;
        private System.Windows.Forms.Panel P_Processor;
        private System.Windows.Forms.GroupBox GB_DataSet;
    }
}

