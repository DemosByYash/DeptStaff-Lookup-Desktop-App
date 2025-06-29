using System.Diagnostics;

namespace App1
{
    public partial class WorkForce : Form
    {
        public WorkForce()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/DemosByYash",
                UseShellExecute = true
            });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeptForm DepartmentForm = new DeptForm();
            DepartmentForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmpLookUp EmployeeForm = new EmpLookUp();
            EmployeeForm.ShowDialog();

        }
    }
}
