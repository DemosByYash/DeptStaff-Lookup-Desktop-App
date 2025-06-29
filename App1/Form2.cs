using System.Data.SqlClient;
using System.Data;


namespace App1
{
    public partial class EmpLookUp : Form
    {
        public EmpLookUp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;


        public void LoadData()
        {
            if (con == null || con.State != ConnectionState.Open)
            {
                con = new SqlConnection("Data Source=Asus_y\\MSSQLSERVER01;Database=CSDB;Integrated Security=SSPI");
                cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
            }

            cmd.CommandText = "Select Eno, Ename, Job, Salary, Photo, Status From CSDB.dbo.Employee Order By Eno";
            dr = cmd.ExecuteReader();
            ShowData();
        }

        public void ShowData()
        {
            if (dr.Read())
            {
                textBox1.Text = dr["Eno"].ToString();
                textBox2.Text = dr["Ename"].ToString();
                textBox3.Text = dr["Job"].ToString();
                textBox4.Text = dr["Salary"].ToString();
                checkBox1.Checked = (bool)dr["Status"];
            }
            else
            {
                MessageBox.Show("No more records found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EmpLookUp_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    tb.Clear();
                }
            }
            dr.Close();
            cmd.CommandText = "Select IsNull(Max(Eno), 1000) + 1 From Employee";
            textBox1.Text = cmd.ExecuteScalar().ToString();
            checkBox1.Enabled = Insert.Enabled = true;
            textBox2.Focus();

        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (dr == null || dr.IsClosed)
            {
                LoadData();
            }
            else
            {
                ShowData();
            }
            if (checkBox1.Enabled || Insert.Enabled)
            {
                checkBox1.Enabled = Insert.Enabled = false;
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            cmd.CommandText = $"Insert into Employee(Eno, Ename, Job, Salary, Status)Values({textBox1.Text},'{textBox2.Text}','{textBox3.Text}',{textBox4.Text},{Convert.ToInt32(checkBox1.Checked)})";
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show($"Insert Operation is Successful; {rows} rows affeced", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                checkBox1.Enabled = Insert.Enabled = false;
            }
            else
            {
                MessageBox.Show("Insert Operation Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            dr.Close();
            cmd.CommandText = $"Update Employee Set Ename = '{textBox2.Text}', Job = '{textBox3.Text}', Salary = {textBox4.Text} Where Eno={textBox1.Text}";
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Update Operation is Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please retry, Update Operation Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }



        private void EmpLookUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            con.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (!dr.IsClosed)
            {
                dr.Close();
            }
            cmd.CommandText = $"Delete from Employee where Eno = {textBox1.Text}";
            if(cmd.ExecuteNonQuery()>0)
            {
                MessageBox.Show("Delete Operation is Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Retry, Delete Operation Failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
