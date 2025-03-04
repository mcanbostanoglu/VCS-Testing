namespace CodeSchoolDataSystem.RoleDataSystem
{
    partial class StudentDataSystem
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
            labelStYourGrades = new Label();
            listViewStGrades = new ListView();
            columnStLesson = new ColumnHeader();
            columnStGrade = new ColumnHeader();
            buttonStMainPage = new Button();
            SuspendLayout();
            // 
            // labelStYourGrades
            // 
            labelStYourGrades.AutoSize = true;
            labelStYourGrades.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelStYourGrades.ForeColor = Color.Firebrick;
            labelStYourGrades.Location = new Point(252, 9);
            labelStYourGrades.Name = "labelStYourGrades";
            labelStYourGrades.Size = new Size(300, 65);
            labelStYourGrades.TabIndex = 13;
            labelStYourGrades.Text = "Your Grades";
            // 
            // listViewStGrades
            // 
            listViewStGrades.Columns.AddRange(new ColumnHeader[] { columnStLesson, columnStGrade });
            listViewStGrades.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listViewStGrades.Location = new Point(243, 86);
            listViewStGrades.Name = "listViewStGrades";
            listViewStGrades.Size = new Size(319, 306);
            listViewStGrades.TabIndex = 14;
            listViewStGrades.UseCompatibleStateImageBehavior = false;
            listViewStGrades.View = View.Details;
            // 
            // columnStLesson
            // 
            columnStLesson.Text = "Lesson";
            // 
            // columnStGrade
            // 
            columnStGrade.Text = "Grade";
            // 
            // buttonStMainPage
            // 
            buttonStMainPage.BackColor = SystemColors.ButtonShadow;
            buttonStMainPage.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonStMainPage.Location = new Point(658, 362);
            buttonStMainPage.Name = "buttonStMainPage";
            buttonStMainPage.Size = new Size(130, 76);
            buttonStMainPage.TabIndex = 15;
            buttonStMainPage.Text = "Back";
            buttonStMainPage.UseVisualStyleBackColor = false;
            buttonStMainPage.Click += buttonStMainPage_Click;
            // 
            // StudentDataSystem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStMainPage);
            Controls.Add(listViewStGrades);
            Controls.Add(labelStYourGrades);
            Name = "StudentDataSystem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentDataSystem";
            Load += StudentDataSystem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelStYourGrades;
        private ListView listViewStGrades;
        private ColumnHeader columnStLesson;
        private ColumnHeader columnStGrade;
        private Button buttonStMainPage;
    }
}