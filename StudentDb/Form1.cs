using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDb
{
    public partial class Student_Information : Form
    {
        public Student_Information()
        {
            InitializeComponent();
        }

        string conectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private void Student_Information_Load(object sender, EventArgs e)
        {
            GetStudentsRecord();
        }

        private void GetStudentsRecord()
        {
            
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                string selectQuery = "select * from [StudentDb]";
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                DataTable dataTable = new DataTable();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                dataTable.Load(sqlDataReader);
                StudentGridView1.DataSource = dataTable;
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                using (SqlConnection connection = new SqlConnection(conectionString))
                {
                    connection.Open();
                    string insertQuery = "insert into [StudentDb] values (@FirstName, @LastName, @Group, @Addres, @PhoneNumber)";
                    SqlCommand sqlCommand = new SqlCommand(insertQuery,connection);
                    
                    sqlCommand.Parameters.AddWithValue("@FirstName", FirstName.Text);
                    sqlCommand.Parameters.AddWithValue("@LastName", LastName.Text);
                    sqlCommand.Parameters.AddWithValue("@Group", Group.Text);
                    sqlCommand.Parameters.AddWithValue("@Addres", Address.Text);
                    sqlCommand.Parameters.AddWithValue("@PhoneNumber", PhoneNumber.Text);

                    sqlCommand.ExecuteNonQuery();
                    
                    connection.Close();

                    MessageBox.Show("New student is successfully saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
        }

        private bool isValid()
        {
            if (FirstName.Text == string.Empty)
            {
                MessageBox.Show("First name is required", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return false;
            }
            return true;
        }
    }
}
