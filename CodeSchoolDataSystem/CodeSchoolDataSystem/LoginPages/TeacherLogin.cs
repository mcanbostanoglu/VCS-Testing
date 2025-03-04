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

namespace CodeSchoolDataSystem
{
    public partial class TeacherLogin : Form
    {
        public TeacherLogin()
        {
            InitializeComponent();
        }

        private void buttonTcMainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainPage = new Form1();
            mainPage.Show();
        }

        private void ButtonTcTryLogin_Click(object sender, EventArgs e)
        {
            string forControlTcName = textBoxTcUsername.Text;
            string forControlTcPass = textBoxTcPassword.Text;

            if (forControlTcName == "tcuser123" && forControlTcPass == "tcpass123")
            {
                MessageBox.Show("Login successful !");
                this.Hide();
                TeacherVerification tcVerify = new TeacherVerification();
                tcVerify.Show();
            }

            else
            {
                MessageBox.Show("Login failed !");
            }
        }


    }
}
