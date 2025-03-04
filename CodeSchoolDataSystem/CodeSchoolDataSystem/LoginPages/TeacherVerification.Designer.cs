namespace CodeSchoolDataSystem.LoginPages
{
    partial class TeacherVerification
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
            LabelVerifyInfo = new Label();
            ButtonTcClick = new Button();
            TcVerifyNum1 = new Label();
            TcVerifySum = new Label();
            TcVerifyNum2 = new Label();
            TcVerifyTrySum = new TextBox();
            TcVerifyEquals = new Label();
            buttonTcVerifyPage = new Button();
            SuspendLayout();
            // 
            // LabelVerifyInfo
            // 
            LabelVerifyInfo.AutoSize = true;
            LabelVerifyInfo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            LabelVerifyInfo.Location = new Point(53, 12);
            LabelVerifyInfo.Name = "LabelVerifyInfo";
            LabelVerifyInfo.Size = new Size(716, 48);
            LabelVerifyInfo.TabIndex = 3;
            LabelVerifyInfo.Text = "Solve the verification question and proceed.";
            // 
            // ButtonTcClick
            // 
            ButtonTcClick.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ButtonTcClick.Location = new Point(123, 208);
            ButtonTcClick.Name = "ButtonTcClick";
            ButtonTcClick.Size = new Size(557, 137);
            ButtonTcClick.TabIndex = 2;
            ButtonTcClick.Text = "Verify and Continue";
            ButtonTcClick.UseVisualStyleBackColor = true;
            ButtonTcClick.Click += ButtonTcClick_Click;
            // 
            // TcVerifyNum1
            // 
            TcVerifyNum1.AutoSize = true;
            TcVerifyNum1.Font = new Font("Segoe UI", 14F);
            TcVerifyNum1.Location = new Point(261, 120);
            TcVerifyNum1.Name = "TcVerifyNum1";
            TcVerifyNum1.Size = new Size(0, 38);
            TcVerifyNum1.TabIndex = 4;
            // 
            // TcVerifySum
            // 
            TcVerifySum.AutoSize = true;
            TcVerifySum.Font = new Font("Segoe UI", 14F);
            TcVerifySum.Location = new Point(301, 120);
            TcVerifySum.Name = "TcVerifySum";
            TcVerifySum.Size = new Size(36, 38);
            TcVerifySum.TabIndex = 5;
            TcVerifySum.Text = "+";
            // 
            // TcVerifyNum2
            // 
            TcVerifyNum2.AutoSize = true;
            TcVerifyNum2.Font = new Font("Segoe UI", 14F);
            TcVerifyNum2.Location = new Point(356, 120);
            TcVerifyNum2.Name = "TcVerifyNum2";
            TcVerifyNum2.Size = new Size(0, 38);
            TcVerifyNum2.TabIndex = 6;
            // 
            // TcVerifyTrySum
            // 
            TcVerifyTrySum.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TcVerifyTrySum.Location = new Point(450, 109);
            TcVerifyTrySum.MaxLength = 3;
            TcVerifyTrySum.Name = "TcVerifyTrySum";
            TcVerifyTrySum.PlaceholderText = "???";
            TcVerifyTrySum.Size = new Size(72, 66);
            TcVerifyTrySum.TabIndex = 7;
            // 
            // TcVerifyEquals
            // 
            TcVerifyEquals.AutoSize = true;
            TcVerifyEquals.Font = new Font("Segoe UI", 14F);
            TcVerifyEquals.Location = new Point(408, 120);
            TcVerifyEquals.Name = "TcVerifyEquals";
            TcVerifyEquals.Size = new Size(36, 38);
            TcVerifyEquals.TabIndex = 8;
            TcVerifyEquals.Text = "=";
            // 
            // buttonTcVerifyPage
            // 
            buttonTcVerifyPage.BackColor = SystemColors.ButtonShadow;
            buttonTcVerifyPage.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonTcVerifyPage.Location = new Point(658, 362);
            buttonTcVerifyPage.Name = "buttonTcVerifyPage";
            buttonTcVerifyPage.Size = new Size(130, 76);
            buttonTcVerifyPage.TabIndex = 18;
            buttonTcVerifyPage.Text = "Back";
            buttonTcVerifyPage.UseVisualStyleBackColor = false;
            buttonTcVerifyPage.Click += buttonTcVerifyPage_Click;
            // 
            // TeacherVerification
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonTcVerifyPage);
            Controls.Add(TcVerifyEquals);
            Controls.Add(TcVerifyTrySum);
            Controls.Add(TcVerifyNum2);
            Controls.Add(TcVerifySum);
            Controls.Add(TcVerifyNum1);
            Controls.Add(LabelVerifyInfo);
            Controls.Add(ButtonTcClick);
            Name = "TeacherVerification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherVerification";
            Load += TeacherVerification_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelVerifyInfo;
        private Button ButtonTcClick;
        private Label TcVerifyNum1;
        private Label TcVerifySum;
        private Label TcVerifyNum2;
        private TextBox TcVerifyTrySum;
        private Label TcVerifyEquals;
        private Button buttonTcVerifyPage;
    }
}