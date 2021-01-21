using System;
using System.Configuration;
using System.Data.SqlClient;
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

        public int StudentId { get; set; }

        //jod_with_datagrid
        private void StudentGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentId = Convert.ToInt32(StudentGridView1.SelectedRows[0].Cells[0].Value);
            FirstName.Text = StudentGridView1.SelectedRows[0].Cells[1].Value.ToString();
            LastName.Text = StudentGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Group.Text = StudentGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Address.Text = StudentGridView1.SelectedRows[0].Cells[4].Value.ToString();
            PhoneNumber.Text = StudentGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        //Metod_insert
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
                   
                    GetStudentsRecord();
                    ResetForm();
                }
            } 
        }

        //Metod_update
        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                if (StudentId>0)
                {
                    connection.Open();
                    string updateQuery = "update  [StudentDb] set FirstName = @FirstName, LastName = @LastName, [Group] = @Group, Addres = @Addres, PhoneNumber = @PhoneNumber where Id = @Id";
                    SqlCommand sqlCommand = new SqlCommand(updateQuery, connection);


                    sqlCommand.Parameters.AddWithValue("@FirstName", FirstName.Text);
                    sqlCommand.Parameters.AddWithValue("@LastName", LastName.Text);
                    sqlCommand.Parameters.AddWithValue("@Group", Group.Text);
                    sqlCommand.Parameters.AddWithValue("@Addres", Address.Text);
                    sqlCommand.Parameters.AddWithValue("@PhoneNumber", PhoneNumber.Text);
                    sqlCommand.Parameters.AddWithValue("@Id", this.StudentId);

                    sqlCommand.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Student information is successfully update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetStudentsRecord();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Please, choose student", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Metod_delete
        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                if (StudentId > 0)
                {
                    connection.Open();
                    string deleteQuery = "delete from [StudentDb] where Id = @Id";
                    SqlCommand sqlCommand = new SqlCommand(deleteQuery, connection);

                    sqlCommand.Parameters.AddWithValue("@Id", this.StudentId);

                    sqlCommand.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Student information is successfully delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetStudentsRecord();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Please, choose student", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
