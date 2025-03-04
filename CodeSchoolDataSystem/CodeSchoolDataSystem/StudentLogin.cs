using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeSchoolDataSystem
{
    public partial class StudentLogin : Form
    {

        private void StudentLogin_Load(object sender, EventArgs e)
        {

        }
        public StudentLogin()
        {
            InitializeComponent();
        }

        private void buttonStMainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainPage = new Form1();
            mainPage.Show();
        }

        private void ButtonStTryLogin_Click(object sender, EventArgs e)
        {
            string forControlStName = textBoxStUsername.Text;
            string forControlStPass = textBoxStPassword.Text;

            if(forControlStName == "stuser123" && forControlStPass =="stpass123")
            {
                MessageBox.Show("Login successful !");
            }

            else
            {
                MessageBox.Show("Login failed !");
            }
        }
    }
}
