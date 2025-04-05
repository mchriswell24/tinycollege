using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

public class SQLSearch
{
    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tinycollege";

    public void Searchprofessor(string searchTerm, DataGridView dataGridView)
    {
        string query = @"SELECT * FROM PROFESSOR WHERE 
        PROF_NUM LIKE @SearchTerm OR DEPT_CODE LIKE @SearchTerm OR PROF_SPECIALTY LIKE @SearchTerm OR 
        PROF_RANK LIKE @SearchTerm OR PROF_LNAME LIKE @SearchTerm OR PROF_FNAME LIKE @SearchTerm OR 
        PROF_INITIAL LIKE @SearchTerm OR PROF_EMAIL LIKE @SearchTerm";

        ExecuteSearch(query, searchTerm, dataGridView);
    }

    public void Searchschool(string searchTerm, DataGridView dataGridView)
    {
        string query = @"SELECT * FROM SCHOOL WHERE 
        SCHOOL_CODE LIKE @SearchTerm OR SCHOOL_NAME LIKE @SearchTerm OR PROF_NUM LIKE @SearchTerm";

        ExecuteSearch(query, searchTerm, dataGridView);
    }

    public void Searchdepartment(string searchTerm, DataGridView dataGridView)
    {
        string query = @"SELECT * FROM DEPARTMENT WHERE 
        DEPT_CODE LIKE @SearchTerm OR DEPT_NAME LIKE @SearchTerm OR SCHOOL_CODE LIKE @SearchTerm OR 
        PROF_NUM LIKE @SearchTerm";

        ExecuteSearch(query, searchTerm, dataGridView);
    }

    public void Searchstudent(string searchTerm, DataGridView dataGridView)
    {
        string query = @"SELECT * FROM STUDENT WHERE 
        STU_NUM LIKE @SearchTerm OR DEPT_CODE LIKE @SearchTerm OR STU_LNAME LIKE @SearchTerm OR 
        STU_FNAME LIKE @SearchTerm OR STU_INITIAL LIKE @SearchTerm OR STU_EMAIL LIKE @SearchTerm OR 
        PROF_NUM LIKE @SearchTerm";

        ExecuteSearch(query, searchTerm, dataGridView);
    }

    public void Searchcourse(string searchTerm, DataGridView dataGridView)
    {
        string query = @"SELECT * FROM COURSE WHERE 
        CRS_CODE LIKE @SearchTerm OR DEPT_CODE LIKE @SearchTerm OR CRS_TITLE LIKE @SearchTerm OR 
        CRS_DESCRIPTION LIKE @SearchTerm OR CRS_CREDIT LIKE @SearchTerm";

        ExecuteSearch(query, searchTerm, dataGridView);
    }

    public void Searchclass(string searchTerm, DataGridView dataGridView)
    {
        string query = @"SELECT * FROM CLASS WHERE 
        CLASS_CODE LIKE @SearchTerm OR CLASS_SECTION LIKE @SearchTerm OR CLASS_TIME LIKE @SearchTerm OR 
        CRS_CODE LIKE @SearchTerm OR PROF_NUM LIKE @SearchTerm OR ROOM_CODE LIKE @SearchTerm OR 
        SEMESTER_CODE LIKE @SearchTerm";

        ExecuteSearch(query, searchTerm, dataGridView);
    }

    public void Searchroom(string searchTerm, DataGridView dataGridView)
    {
        string query = @"SELECT * FROM ROOM WHERE 
        ROOM_CODE LIKE @SearchTerm OR ROOM_TYPE LIKE @SearchTerm OR BLDG_CODE LIKE @SearchTerm";

        ExecuteSearch(query, searchTerm, dataGridView);
    }

    public void Searchbuilding(string searchTerm, DataGridView dataGridView)
    {
        string query = @"SELECT * FROM BUILDING WHERE 
        BLDG_CODE LIKE @SearchTerm OR BLDG_NAME LIKE @SearchTerm OR BLDG_LOCATION LIKE @SearchTerm";

        ExecuteSearch(query, searchTerm, dataGridView);
    }

    public void Searchsemesters(string searchTerm, DataGridView dataGridView)
    {
        string query = @"SELECT * FROM SEMESTER WHERE 
        SEMESTER_CODE LIKE @SearchTerm OR SEMESTER_YEAR LIKE @SearchTerm OR SEMESTER_TERM LIKE @SearchTerm OR 
        SEMESTER_START_DATE LIKE @SearchTerm OR SEMESTER_END_DATE LIKE @SearchTerm";

        ExecuteSearch(query, searchTerm, dataGridView);
    }

    public void Searchenroll(string searchTerm, DataGridView dataGridView)
    {
        string query = @"SELECT * FROM ENROLL WHERE 
        CLASS_CODE LIKE @SearchTerm OR STU_NUM LIKE @SearchTerm OR 
        ENROLL_DATE LIKE @SearchTerm OR ENROLL_GRADE LIKE @SearchTerm";

        ExecuteSearch(query, searchTerm, dataGridView);
    }

    private void ExecuteSearch(string query, string searchTerm, DataGridView dataGridView)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable result = new DataTable();
                        adapter.Fill(result);
                        dataGridView.DataSource = result;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }
}
