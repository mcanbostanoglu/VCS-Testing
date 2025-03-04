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
    public partial class TeacherVerification : Form
    {
        public TeacherVerification()
        {
            InitializeComponent();
        }

        public void TeacherVerification_Load(object sender, EventArgs e)
        {
            Random num = new Random();
            int num1 = num.Next(1, 100);
            int num2 = num.Next(1, 100);
            TcVerifyNum1.Text = num1.ToString();
            TcVerifyNum2.Text = num2.ToString();
        }

        private void ButtonTcClick_Click(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(TcVerifyNum2.Text) + Convert.ToInt32(TcVerifyNum1.Text);
            if (Convert.ToInt32(TcVerifyTrySum.Text) == sum)
            {
                MessageBox.Show("Verification successful !");
                this.Hide();
                TeacherDataSystem tcDataSys = new TeacherDataSystem();
                tcDataSys.Show();
            }

            else
            {
                MessageBox.Show("The result is incorrect, please try again !");
            }
        }

        private void buttonTcVerifyPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainPage = new Form1();
            mainPage.Show();
        }
    }
}
