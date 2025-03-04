namespace CodeSchoolDataSystem.RoleDataSystem
{
    partial class TeacherDataSystem
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
            ListViewNoteTable = new ListView();
            TcStudentName = new ColumnHeader();
            TcStudentScore = new ColumnHeader();
            LabelTcInformation = new Label();
            textBoxTcGrade = new TextBox();
            labelTcGrade = new Label();
            textBoxTcName = new TextBox();
            labelTcName = new Label();
            ButtonTeacherSave = new Button();
            buttonTcVerifyPage = new Button();
            SuspendLayout();
            // 
            // ListViewNoteTable
            // 
            ListViewNoteTable.Columns.AddRange(new ColumnHeader[] { TcStudentName, TcStudentScore });
            ListViewNoteTable.Location = new Point(547, 81);
            ListViewNoteTable.Name = "ListViewNoteTable";
            ListViewNoteTable.Size = new Size(204, 258);
            ListViewNoteTable.TabIndex = 0;
            ListViewNoteTable.UseCompatibleStateImageBehavior = false;
            ListViewNoteTable.View = View.Details;
            // 
            // TcStudentName
            // 
            TcStudentName.Text = "Name";
            // 
            // TcStudentScore
            // 
            TcStudentScore.Text = "Score";
            // 
            // LabelTcInformation
            // 
            LabelTcInformation.AutoSize = true;
            LabelTcInformation.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 162);
            LabelTcInformation.Location = new Point(63, 55);
            LabelTcInformation.Name = "LabelTcInformation";
            LabelTcInformation.Size = new Size(397, 90);
            LabelTcInformation.TabIndex = 1;
            LabelTcInformation.Text = "Please enter the\r\nstudent's name and grade.";
            LabelTcInformation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxTcGrade
            // 
            textBoxTcGrade.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxTcGrade.Location = new Point(225, 258);
            textBoxTcGrade.Name = "textBoxTcGrade";
            textBoxTcGrade.PlaceholderText = "grade";
            textBoxTcGrade.Size = new Size(211, 55);
            textBoxTcGrade.TabIndex = 15;
            // 
            // labelTcGrade
            // 
            labelTcGrade.AutoSize = true;
            labelTcGrade.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTcGrade.Location = new Point(82, 264);
            labelTcGrade.Name = "labelTcGrade";
            labelTcGrade.Size = new Size(128, 45);
            labelTcGrade.TabIndex = 14;
            labelTcGrade.Text = "Grade :";
            // 
            // textBoxTcName
            // 
            textBoxTcName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxTcName.Location = new Point(225, 172);
            textBoxTcName.Name = "textBoxTcName";
            textBoxTcName.PlaceholderText = "name";
            textBoxTcName.Size = new Size(211, 55);
            textBoxTcName.TabIndex = 13;
            // 
            // labelTcName
            // 
            labelTcName.AutoSize = true;
            labelTcName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTcName.Location = new Point(84, 172);
            labelTcName.Name = "labelTcName";
            labelTcName.Size = new Size(126, 45);
            labelTcName.TabIndex = 12;
            labelTcName.Text = "Name :";
            // 
            // ButtonTeacherSave
            // 
            ButtonTeacherSave.BackColor = Color.Yellow;
            ButtonTeacherSave.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ButtonTeacherSave.Location = new Point(156, 337);
            ButtonTeacherSave.Name = "ButtonTeacherSave";
            ButtonTeacherSave.Size = new Size(209, 63);
            ButtonTeacherSave.TabIndex = 16;
            ButtonTeacherSave.Text = "Save";
            ButtonTeacherSave.UseVisualStyleBackColor = false;
            ButtonTeacherSave.Click += ButtonTeacherSave_Click;
            // 
            // buttonTcVerifyPage
            // 
            buttonTcVerifyPage.BackColor = SystemColors.ButtonShadow;
            buttonTcVerifyPage.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonTcVerifyPage.Location = new Point(658, 362);
            buttonTcVerifyPage.Name = "buttonTcVerifyPage";
            buttonTcVerifyPage.Size = new Size(130, 76);
            buttonTcVerifyPage.TabIndex = 17;
            buttonTcVerifyPage.Text = "Back";
            buttonTcVerifyPage.UseVisualStyleBackColor = false;
            buttonTcVerifyPage.Click += buttonTcVerifyPage_Click;
            // 
            // TeacherDataSystem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonTcVerifyPage);
            Controls.Add(ButtonTeacherSave);
            Controls.Add(textBoxTcGrade);
            Controls.Add(labelTcGrade);
            Controls.Add(textBoxTcName);
            Controls.Add(labelTcName);
            Controls.Add(LabelTcInformation);
            Controls.Add(ListViewNoteTable);
            Name = "TeacherDataSystem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherDataSystem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ListViewNoteTable;
        private ColumnHeader TcStudentName;
        private ColumnHeader TcStudentScore;
        private Label LabelTcInformation;
        private TextBox textBoxTcGrade;
        private Label labelTcGrade;
        private TextBox textBoxTcName;
        private Label labelTcName;
        private Button ButtonTeacherSave;
        private Button buttonTcVerifyPage;
    }
}