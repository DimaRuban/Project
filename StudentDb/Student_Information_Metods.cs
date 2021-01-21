using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentDb
{
    public partial class Student_Information : Form
    {
        private bool isValid()
        {
            if (FirstName.Text == string.Empty)
            {
                MessageBox.Show("First name is required", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ResetForm()
        {
            StudentId = 0;
            FirstName.Clear();
            LastName.Clear();
            Group.Clear();
            Address.Clear();
            PhoneNumber.Clear();
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
    }
}
