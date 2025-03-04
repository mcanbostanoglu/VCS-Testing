namespace CodeSchoolDataSystem.LoginPages
{
    partial class StudentVerification
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
            buttonStVerifyPage = new Button();
            StVerifyEquals = new Label();
            StVerifyTrySum = new TextBox();
            StVerifyNum2 = new Label();
            StVerifySum = new Label();
            StVerifyNum1 = new Label();
            LabelVerifyInfo = new Label();
            ButtonStClick = new Button();
            SuspendLayout();
            // 
            // buttonStVerifyPage
            // 
            buttonStVerifyPage.BackColor = SystemColors.ButtonShadow;
            buttonStVerifyPage.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonStVerifyPage.Location = new Point(638, 362);
            buttonStVerifyPage.Name = "buttonStVerifyPage";
            buttonStVerifyPage.Size = new Size(130, 76);
            buttonStVerifyPage.TabIndex = 26;
            buttonStVerifyPage.Text = "Back";
            buttonStVerifyPage.UseVisualStyleBackColor = false;
            buttonStVerifyPage.Click += buttonTcVerifyPage_Click;
            // 
            // StVerifyEquals
            // 
            StVerifyEquals.AutoSize = true;
            StVerifyEquals.Font = new Font("Segoe UI", 14F);
            StVerifyEquals.Location = new Point(388, 120);
            StVerifyEquals.Name = "StVerifyEquals";
            StVerifyEquals.Size = new Size(36, 38);
            StVerifyEquals.TabIndex = 25;
            StVerifyEquals.Text = "=";
            // 
            // StVerifyTrySum
            // 
            StVerifyTrySum.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 162);
            StVerifyTrySum.Location = new Point(430, 109);
            StVerifyTrySum.MaxLength = 3;
            StVerifyTrySum.Name = "StVerifyTrySum";
            StVerifyTrySum.PlaceholderText = "???";
            StVerifyTrySum.Size = new Size(72, 66);
            StVerifyTrySum.TabIndex = 24;
            // 
            // StVerifyNum2
            // 
            StVerifyNum2.AutoSize = true;
            StVerifyNum2.Font = new Font("Segoe UI", 14F);
            StVerifyNum2.Location = new Point(336, 120);
            StVerifyNum2.Name = "StVerifyNum2";
            StVerifyNum2.Size = new Size(0, 38);
            StVerifyNum2.TabIndex = 23;
            // 
            // StVerifySum
            // 
            StVerifySum.AutoSize = true;
            StVerifySum.Font = new Font("Segoe UI", 14F);
            StVerifySum.Location = new Point(281, 120);
            StVerifySum.Name = "StVerifySum";
            StVerifySum.Size = new Size(36, 38);
            StVerifySum.TabIndex = 22;
            StVerifySum.Text = "+";
            // 
            // StVerifyNum1
            // 
            StVerifyNum1.AutoSize = true;
            StVerifyNum1.Font = new Font("Segoe UI", 14F);
            StVerifyNum1.Location = new Point(241, 120);
            StVerifyNum1.Name = "StVerifyNum1";
            StVerifyNum1.Size = new Size(0, 38);
            StVerifyNum1.TabIndex = 21;
            // 
            // LabelVerifyInfo
            // 
            LabelVerifyInfo.AutoSize = true;
            LabelVerifyInfo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            LabelVerifyInfo.Location = new Point(33, 12);
            LabelVerifyInfo.Name = "LabelVerifyInfo";
            LabelVerifyInfo.Size = new Size(716, 48);
            LabelVerifyInfo.TabIndex = 20;
            LabelVerifyInfo.Text = "Solve the verification question and proceed.";
            // 
            // ButtonStClick
            // 
            ButtonStClick.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ButtonStClick.Location = new Point(103, 208);
            ButtonStClick.Name = "ButtonStClick";
            ButtonStClick.Size = new Size(557, 137);
            ButtonStClick.TabIndex = 19;
            ButtonStClick.Text = "Verify and Continue";
            ButtonStClick.UseVisualStyleBackColor = true;
            ButtonStClick.Click += ButtonStClick_Click;
            // 
            // StudentVerification
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStVerifyPage);
            Controls.Add(StVerifyEquals);
            Controls.Add(StVerifyTrySum);
            Controls.Add(StVerifyNum2);
            Controls.Add(StVerifySum);
            Controls.Add(StVerifyNum1);
            Controls.Add(LabelVerifyInfo);
            Controls.Add(ButtonStClick);
            Name = "StudentVerification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentVerification";
            Load += StudentVerification_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStVerifyPage;
        private Label StVerifyEquals;
        private TextBox StVerifyTrySum;
        private Label StVerifyNum2;
        private Label StVerifySum;
        private Label StVerifyNum1;
        private Label LabelVerifyInfo;
        private Button ButtonStClick;
    }
}