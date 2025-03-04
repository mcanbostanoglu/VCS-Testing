namespace CodeSchoolDataSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonStudentLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLogin stLogPage = new StudentLogin();
            stLogPage.Show();
            MessageBox.Show("For login information, please read the Readme file on GitHub.");
        }

        private void ButtonTeacherLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherLogin tcLogPage = new TeacherLogin();
            tcLogPage.Show();
            MessageBox.Show("For login information, please read the Readme file on GitHub.");
        }
    }
}
