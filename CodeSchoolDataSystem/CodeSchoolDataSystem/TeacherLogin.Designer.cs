namespace CodeSchoolDataSystem
{
    partial class TeacherLogin
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
            ButtonTcTryLogin = new Button();
            labelTcUsername = new Label();
            textBoxTcUsername = new TextBox();
            textBoxTcPassword = new TextBox();
            labelTcPassword = new Label();
            labelTcRole = new Label();
            buttonTcMainPage = new Button();
            SuspendLayout();
            // 
            // ButtonTcTryLogin
            // 
            ButtonTcTryLogin.BackColor = Color.SpringGreen;
            ButtonTcTryLogin.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ButtonTcTryLogin.Location = new Point(105, 285);
            ButtonTcTryLogin.Name = "ButtonTcTryLogin";
            ButtonTcTryLogin.Size = new Size(408, 101);
            ButtonTcTryLogin.TabIndex = 0;
            ButtonTcTryLogin.Text = "Log in !";
            ButtonTcTryLogin.UseVisualStyleBackColor = false;
            ButtonTcTryLogin.Click += ButtonTcTryLogin_Click;
            // 
            // labelTcUsername
            // 
            labelTcUsername.AutoSize = true;
            labelTcUsername.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelTcUsername.Location = new Point(105, 106);
            labelTcUsername.Name = "labelTcUsername";
            labelTcUsername.Size = new Size(235, 54);
            labelTcUsername.TabIndex = 1;
            labelTcUsername.Text = "Username :";
            // 
            // textBoxTcUsername
            // 
            textBoxTcUsername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxTcUsername.Location = new Point(352, 106);
            textBoxTcUsername.Name = "textBoxTcUsername";
            textBoxTcUsername.PlaceholderText = "enter your username";
            textBoxTcUsername.Size = new Size(334, 55);
            textBoxTcUsername.TabIndex = 2;
            // 
            // textBoxTcPassword
            // 
            textBoxTcPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxTcPassword.Location = new Point(352, 192);
            textBoxTcPassword.Name = "textBoxTcPassword";
            textBoxTcPassword.PasswordChar = '*';
            textBoxTcPassword.PlaceholderText = "enter your password";
            textBoxTcPassword.Size = new Size(334, 55);
            textBoxTcPassword.TabIndex = 4;
            // 
            // labelTcPassword
            // 
            labelTcPassword.AutoSize = true;
            labelTcPassword.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelTcPassword.Location = new Point(105, 193);
            labelTcPassword.Name = "labelTcPassword";
            labelTcPassword.Size = new Size(224, 54);
            labelTcPassword.TabIndex = 3;
            labelTcPassword.Text = "Password :";
            // 
            // labelTcRole
            // 
            labelTcRole.AutoSize = true;
            labelTcRole.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelTcRole.ForeColor = Color.Firebrick;
            labelTcRole.Location = new Point(12, 9);
            labelTcRole.Name = "labelTcRole";
            labelTcRole.Size = new Size(198, 65);
            labelTcRole.TabIndex = 5;
            labelTcRole.Text = "Teacher";
            // 
            // buttonTcMainPage
            // 
            buttonTcMainPage.BackColor = SystemColors.ButtonShadow;
            buttonTcMainPage.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonTcMainPage.Location = new Point(658, 362);
            buttonTcMainPage.Name = "buttonTcMainPage";
            buttonTcMainPage.Size = new Size(130, 76);
            buttonTcMainPage.TabIndex = 6;
            buttonTcMainPage.Text = "Back";
            buttonTcMainPage.UseVisualStyleBackColor = false;
            buttonTcMainPage.Click += buttonTcMainPage_Click;
            // 
            // TeacherLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonTcMainPage);
            Controls.Add(labelTcRole);
            Controls.Add(textBoxTcPassword);
            Controls.Add(labelTcPassword);
            Controls.Add(textBoxTcUsername);
            Controls.Add(labelTcUsername);
            Controls.Add(ButtonTcTryLogin);
            Name = "TeacherLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherLogin";
            Load += TeacherLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonTcTryLogin;
        private Label labelTcUsername;
        private TextBox textBoxTcUsername;
        private TextBox textBoxTcPassword;
        private Label labelTcPassword;
        private Label labelTcRole;
        private Button buttonTcMainPage;
    }
}