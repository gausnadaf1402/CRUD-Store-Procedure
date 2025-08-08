using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDStoreProcedure
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CL5CL6H\\SQLEXPRESS;Initial Catalog=TestSP_DB;Integrated Security=True;TrustServerCertificate=True");

        private int selectedEmployeeId = -1; // Variable to hold the selected employee ID
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false; // Hide row headers
            dataGridView1.AllowUserToAddRows = false; // Disable adding new rows
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }
        private void btninsert_Click(object sender, EventArgs e)
        {
            // Insert Employee
            int empid = Convert.ToInt32(txtempid.Text);
            string empname = txtempname.Text;
            string city = comboBoxempcity.Text;
            double age = Convert.ToDouble(txtempage.Text);
            string sex = "";
            if (radioButtonsexmale.Checked == true)
            {
                sex = "Male";
            }
            else
            {
                sex = "Female";
            }
            DateTime joindate = Convert.ToDateTime(dateTimePicker1.Text);
            string contact = txtempcontact.Text;

            con.Open();
            SqlCommand cmd = new SqlCommand("InsertEmp_SP ",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Emp_ID", empid);
            cmd.Parameters.AddWithValue("@Emp_Name", empname);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@Age", age);
            cmd.Parameters.AddWithValue("@Sex", sex);
            cmd.Parameters.AddWithValue("@JoiningDate", joindate);
            cmd.Parameters.AddWithValue("@Contact", contact);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Inserted Successfully");

            GetEmpList();

        }

        void GetEmpList()
        {
            // Fetch Employee List
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=TestSP_DB;Integrated Security=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("ListEmp_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            GetEmpList();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            // Update Employee
            int empid = int.Parse(txtempid.Text);
            string empname = txtempname.Text;
            string city = comboBoxempcity.Text;
            double age = Convert.ToDouble(txtempage.Text);
            string sex = "";
            if (radioButtonsexmale.Checked == true)
            {
                sex = "Male";
            }
            else
            {
                sex = "Female";
            }
            DateTime joindate = DateTime.Parse(dateTimePicker1.Text);
            string contact = txtempcontact.Text;

            con.Open();
            SqlCommand cmd = new SqlCommand("UpdateEmp_SP ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Emp_ID", empid);
            cmd.Parameters.AddWithValue("@Emp_Name", empname);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@Age", age);
            cmd.Parameters.AddWithValue("@Sex", sex);
            cmd.Parameters.AddWithValue("@JoiningDate", joindate);
            cmd.Parameters.AddWithValue("@Contact", contact);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Updated Successfully");

            GetEmpList();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            var row = dataGridView1.SelectedRows[0];
            if (row.Cells["Emp_ID"].Value == null)
                return;

            selectedEmployeeId = Convert.ToInt32(row.Cells["Emp_ID"].Value);
            txtempname.Text = row.Cells["Emp_Name"].Value?.ToString() ?? "";
            comboBoxempcity.Text = row.Cells["City"].Value?.ToString() ?? "";
            txtempage.Text = row.Cells["Age"].Value?.ToString() ?? "";
            string sex = row.Cells["Sex"].Value?.ToString() ?? "";
            if (sex == "Male")
                radioButtonsexmale.Checked = true;
            else if (sex == "Female")
                radioButtonsexfemale.Checked = true;
            else
            {
                radioButtonsexmale.Checked = false;
                radioButtonsexfemale.Checked = false;
            }

            dateTimePicker1.Text = row.Cells["JoiningDate"].Value?.ToString() ?? "";

            txtempcontact.Text = row.Cells["Contact"].Value?.ToString() ?? "";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            // Delete Employee
            int empid = int.Parse(txtempid.Text);
            con.Open();
            SqlCommand cmd = new SqlCommand("DeleteEmp_SP ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Emp_ID", empid);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Deleted Successfully");

            GetEmpList();
        }
    }
}
