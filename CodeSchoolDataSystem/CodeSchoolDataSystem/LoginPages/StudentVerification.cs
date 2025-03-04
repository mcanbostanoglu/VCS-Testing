using CodeSchoolDataSystem.RoleDataSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeSchoolDataSystem.LoginPages
{
    public partial class StudentVerification : Form
    {
        public StudentVerification()
        {
            InitializeComponent();
        }

        private void StudentVerification_Load(object sender, EventArgs e)
        {
            Random num = new Random();
            int num1 = num.Next(1, 100);
            int num2 = num.Next(1, 100);
            StVerifyNum1.Text = num1.ToString();
            StVerifyNum2.Text = num2.ToString();
        }

        private void buttonTcVerifyPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainPage = new Form1();
            mainPage.Show();
        }

        private void ButtonStClick_Click(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(StVerifyNum2.Text) + Convert.ToInt32(StVerifyNum1.Text);
            if (Convert.ToInt32(StVerifyTrySum.Text) == sum)
            {
                MessageBox.Show("Verification successful !");
                this.Hide();
                StudentDataSystem stDataSys = new StudentDataSystem();
                stDataSys.Show();
            }

            else
            {
                MessageBox.Show("The result is incorrect, please try again !");
            }
        }

    }
}
