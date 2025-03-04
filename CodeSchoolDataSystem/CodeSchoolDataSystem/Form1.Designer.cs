namespace CodeSchoolDataSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ButtonStudentLogin = new Button();
            ButtonTeacherLogin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ButtonStudentLogin
            // 
            ButtonStudentLogin.Font = new Font("Segoe UI", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            ButtonStudentLogin.Location = new Point(71, 179);
            ButtonStudentLogin.Name = "ButtonStudentLogin";
            ButtonStudentLogin.Size = new Size(320, 135);
            ButtonStudentLogin.TabIndex = 0;
            ButtonStudentLogin.Text = "STUDENT";
            ButtonStudentLogin.UseVisualStyleBackColor = true;
            ButtonStudentLogin.Click += ButtonStudentLogin_Click;
            // 
            // ButtonTeacherLogin
            // 
            ButtonTeacherLogin.Font = new Font("Segoe UI", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            ButtonTeacherLogin.Location = new Point(409, 179);
            ButtonTeacherLogin.Name = "ButtonTeacherLogin";
            ButtonTeacherLogin.Size = new Size(320, 135);
            ButtonTeacherLogin.TabIndex = 1;
            ButtonTeacherLogin.Text = "TEACHER";
            ButtonTeacherLogin.UseVisualStyleBackColor = true;
            ButtonTeacherLogin.Click += ButtonTeacherLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(125, 69);
            label1.Name = "label1";
            label1.Size = new Size(562, 70);
            label1.TabIndex = 2;
            label1.Text = "Please select your role :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ButtonTeacherLogin);
            Controls.Add(ButtonStudentLogin);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonStudentLogin;
        private Button ButtonTeacherLogin;
        private Label label1;
    }
}
