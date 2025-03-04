namespace CodeSchoolDataSystem
{
    partial class StudentLogin
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
            buttonStMainPage = new Button();
            labelStRole = new Label();
            textBoxStPassword = new TextBox();
            labelStPassword = new Label();
            textBoxStUsername = new TextBox();
            labelStUsername = new Label();
            ButtonStTryLogin = new Button();
            SuspendLayout();
            // 
            // buttonStMainPage
            // 
            buttonStMainPage.BackColor = SystemColors.ButtonShadow;
            buttonStMainPage.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonStMainPage.Location = new Point(658, 364);
            buttonStMainPage.Name = "buttonStMainPage";
            buttonStMainPage.Size = new Size(130, 76);
            buttonStMainPage.TabIndex = 13;
            buttonStMainPage.Text = "Back";
            buttonStMainPage.UseVisualStyleBackColor = false;
            buttonStMainPage.Click += buttonStMainPage_Click;
            // 
            // labelStRole
            // 
            labelStRole.AutoSize = true;
            labelStRole.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelStRole.ForeColor = Color.Firebrick;
            labelStRole.Location = new Point(12, 11);
            labelStRole.Name = "labelStRole";
            labelStRole.Size = new Size(200, 65);
            labelStRole.TabIndex = 12;
            labelStRole.Text = "Student";
            // 
            // textBoxStPassword
            // 
            textBoxStPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxStPassword.Location = new Point(352, 194);
            textBoxStPassword.Name = "textBoxStPassword";
            textBoxStPassword.PasswordChar = '*';
            textBoxStPassword.PlaceholderText = "enter your password";
            textBoxStPassword.Size = new Size(334, 55);
            textBoxStPassword.TabIndex = 11;
            // 
            // labelStPassword
            // 
            labelStPassword.AutoSize = true;
            labelStPassword.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelStPassword.Location = new Point(105, 195);
            labelStPassword.Name = "labelStPassword";
            labelStPassword.Size = new Size(224, 54);
            labelStPassword.TabIndex = 10;
            labelStPassword.Text = "Password :";
            // 
            // textBoxStUsername
            // 
            textBoxStUsername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxStUsername.Location = new Point(352, 108);
            textBoxStUsername.Name = "textBoxStUsername";
            textBoxStUsername.PlaceholderText = "enter your username";
            textBoxStUsername.Size = new Size(334, 55);
            textBoxStUsername.TabIndex = 9;
            // 
            // labelStUsername
            // 
            labelStUsername.AutoSize = true;
            labelStUsername.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelStUsername.Location = new Point(105, 108);
            labelStUsername.Name = "labelStUsername";
            labelStUsername.Size = new Size(235, 54);
            labelStUsername.TabIndex = 8;
            labelStUsername.Text = "Username :";
            // 
            // ButtonStTryLogin
            // 
            ButtonStTryLogin.BackColor = Color.SpringGreen;
            ButtonStTryLogin.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ButtonStTryLogin.Location = new Point(105, 287);
            ButtonStTryLogin.Name = "ButtonStTryLogin";
            ButtonStTryLogin.Size = new Size(408, 101);
            ButtonStTryLogin.TabIndex = 7;
            ButtonStTryLogin.Text = "Log in !";
            ButtonStTryLogin.UseVisualStyleBackColor = false;
            ButtonStTryLogin.Click += ButtonStTryLogin_Click;
            // 
            // StudentLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStMainPage);
            Controls.Add(labelStRole);
            Controls.Add(textBoxStPassword);
            Controls.Add(labelStPassword);
            Controls.Add(textBoxStUsername);
            Controls.Add(labelStUsername);
            Controls.Add(ButtonStTryLogin);
            Name = "StudentLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStMainPage;
        private Label labelStRole;
        private TextBox textBoxStPassword;
        private Label labelStPassword;
        private TextBox textBoxStUsername;
        private Label labelStUsername;
        private Button ButtonStTryLogin;
    }
}