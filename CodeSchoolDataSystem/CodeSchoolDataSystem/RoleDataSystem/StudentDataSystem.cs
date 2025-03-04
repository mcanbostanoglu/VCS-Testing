using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeSchoolDataSystem.RoleDataSystem
{
    public partial class StudentDataSystem : Form
    {
        public StudentDataSystem()
        {
            InitializeComponent();
        }

        private void buttonStMainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainPage = new Form1();
            mainPage.Show();
        }

        private void StudentDataSystem_Load(object sender, EventArgs e)
        {
            string[,] LessonGradeList = {{ "History", "85" },{ "Math", "77" },{ "Computer Sci.", "100" },{ "Geometry", "88" }};
            for (int i=0; i<4; i++)
            {
                string getLesson = LessonGradeList[i, 0];
                string getGrade = LessonGradeList[i, 1];
                ListViewItem newListValue = new ListViewItem(getLesson);
                newListValue.SubItems.Add(getGrade);
                listViewStGrades.Items.Add(newListValue);
            }
        }
    }
}
