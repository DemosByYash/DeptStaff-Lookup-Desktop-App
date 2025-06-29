using System.Data.SqlClient;
using System.Data;
using Microsoft.VisualBasic;
using System.Drawing;

namespace App1
{
    public partial class DeptForm : Form
    {
        public DeptForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;


        private void ShowData()
        {
            if (dr.Read())
            {
                textBox1.Text = dr.GetValue(0).ToString();
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr["Location"].ToString();

            }
            else
            {
                MessageBox.Show("No more records found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void DeptForm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=Asus_y\\MSSQLSERVER01;Database=CSDB;Integrated Security=SSPI;");
            cmd = new SqlCommand("Select DeptNo, DName, Location from Dept Order by DeptNo", con);
            if (con.State != ConnectionState.Open) 
            {
                con.Open();
                ConStatus.Text = "Connected to Database";
                ConStatusProgress.Value = 100;
            }
            else if (con.State == ConnectionState.Connecting)
            {
                ConStatus.Text = "Connecting to Database...";
                ConStatusProgress.Value = 75;
            }
            else if (con.State == ConnectionState.Closed)
            {
                MessageBox.Show("Connection is closed, please check your connection settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                ConStatus.Text = "Connection already open";
                ConStatusProgress.Value = 50;
            }


                dr = cmd.ExecuteReader();

            label1.Text = dr.GetName(0);
            label2.Text = dr.GetName(1);
            label3.Text = dr.GetName(2);

            ShowData();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private async void Close_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(con.State == ConnectionState.Open | con.State == ConnectionState.Connecting)
                {
                    ConStatus.Text = "Closing connection...";
                    ConStatusProgress.Style = ProgressBarStyle.Marquee;
                    await Task.Delay(5000);
                    dr.Close();
                    con.Close();
                    ConStatus.Text = "Connection closed";
                }
                
                
                this.Close();
            }
        }
    }
}
