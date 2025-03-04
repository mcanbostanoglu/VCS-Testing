using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeSchoolDataSystem.LoginPages;
using CodeSchoolDataSystem.RoleDataSystem;

namespace CodeSchoolDataSystem.RoleDataSystem
{
    public partial class TeacherDataSystem : Form
    {
        public TeacherDataSystem()
        {
            InitializeComponent();
        }

        private void ButtonTeacherSave_Click(object sender, EventArgs e)
        {
            string getName = textBoxTcName.Text;
            string getGrade = textBoxTcGrade.Text;
            ListViewItem newListValue = new ListViewItem(getName);
            newListValue.SubItems.Add(getGrade);

            ListViewNoteTable.Items.Add(newListValue);
        }

        private void buttonTcVerifyPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherVerification tcVerify = new TeacherVerification();
            tcVerify.Show();
        }
    }
}
