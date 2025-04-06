using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Enrollmentsystem
{
    internal class Updatemethod
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tinycollege;";

        public void UpdateBuilding(string buildingCode, string buildingName, string buildingLocation)
        {
            string query = "UPDATE building SET BLDG_NAME = @buildingName, BLDG_LOCATION = @buildingLocation WHERE BLDG_CODE = @buildingCode";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@buildingCode", buildingCode);
                    cmd.Parameters.AddWithValue("@buildingName", buildingName);
                    cmd.Parameters.AddWithValue("@buildingLocation", buildingLocation);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateRoom(string roomCode, string roomType, string buildingCode)
        {
            string query = "UPDATE room SET ROOM_TYPE = @roomType, BLDG_CODE = @buildingCode WHERE ROOM_CODE = @roomCode";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@roomCode", roomCode);
                    cmd.Parameters.AddWithValue("@roomType", roomType);
                    cmd.Parameters.AddWithValue("@buildingCode", buildingCode);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateStudent(int studentNumber, string deptCode, string lastName, string firstName, string initial, string email, int profNumber)
        {
            string query = "UPDATE student SET DEPT_CODE = @deptCode, STU_LNAME = @lastName, STU_FNAME = @firstName, STU_INITIAL = @initial, STU_EMAIL = @email, PROF_NUM = @profNumber WHERE STU_NUM = @studentNumber";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentNumber", studentNumber);
                    cmd.Parameters.AddWithValue("@deptCode", deptCode);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@initial", initial);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@profNumber", profNumber);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProfessor(int professorNumber, string deptCode, string specialty, string rank, string lastName, string firstName, string initial, string email)
        {
            string query = "UPDATE professor SET DEPT_CODE = @deptCode, PROF_SPECIALTY = @specialty, PROF_RANK = @rank, PROF_LNAME = @lastName, PROF_FNAME = @firstName, PROF_INITIAL = @initial, PROF_EMAIL = @email WHERE PROF_NUM = @professorNumber";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@professorNumber", professorNumber);
                    cmd.Parameters.AddWithValue("@deptCode", deptCode);
                    cmd.Parameters.AddWithValue("@specialty", specialty);
                    cmd.Parameters.AddWithValue("@rank", rank);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@initial", initial);
                    cmd.Parameters.AddWithValue("@email", email);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateClass(string classCode, string classSection, string classTime, string courseCode, int profNumber, string roomCode, string semesterCode)
        {
            string query = "UPDATE CLASS SET CLASS_SECTION = @classSection, CLASS_TIME = @classTime, CRS_CODE = @courseCode, PROF_NUM = @profNumber, ROOM_CODE = @roomCode, SEMESTER_CODE = @semesterCode WHERE CLASS_CODE = @classCode";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@classCode", classCode);
                    cmd.Parameters.AddWithValue("@classSection", classSection);
                    cmd.Parameters.AddWithValue("@classTime", classTime);
                    cmd.Parameters.AddWithValue("@courseCode", courseCode);
                    cmd.Parameters.AddWithValue("@profNumber", profNumber);
                    cmd.Parameters.AddWithValue("@roomCode", roomCode);
                    cmd.Parameters.AddWithValue("@semesterCode", semesterCode);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateCourse(string courseCode, string deptCode, string courseTitle, string courseDescription, int? courseCredit)
        {
            string query = "UPDATE COURSE SET DEPT_CODE = @deptCode, CRS_TITLE = @courseTitle, CRS_DESCRIPTION = @courseDescription, CRS_CREDIT = @courseCredit WHERE CRS_CODE = @courseCode";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@courseCode", courseCode);
                    cmd.Parameters.AddWithValue("@deptCode", deptCode);
                    cmd.Parameters.AddWithValue("@courseTitle", courseTitle);
                    cmd.Parameters.AddWithValue("@courseDescription", courseDescription);
                    cmd.Parameters.AddWithValue("@courseCredit", courseCredit.Value);


                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateEnrollment(string classCode, int studentNumber, DateTime enrollDate, string enrollGrade)
        {
            string query = "UPDATE ENROLLMENT SET ENROLL_DATE = @enrollDate, ENROLL_GRADE = @enrollGrade WHERE CLASS_CODE = @classCode AND STU_NUM = @studentNumber";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@classCode", classCode);
                    cmd.Parameters.AddWithValue("@studentNumber", studentNumber);
                    cmd.Parameters.AddWithValue("@enrollDate", enrollDate);
                    cmd.Parameters.AddWithValue("@enrollGrade", enrollGrade);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateDepartment(string deptCode, string deptName, string schoolCode, int profNumber)
        {
            string query = "UPDATE DEPARTMENT SET DEPT_NAME = @deptName, SCHOOL_CODE = @schoolCode, PROF_NUM = @profNumber WHERE DEPT_CODE = @deptCode";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@deptCode", deptCode);
                    cmd.Parameters.AddWithValue("@deptName", deptName);
                    cmd.Parameters.AddWithValue("@schoolCode", schoolCode);
                    cmd.Parameters.AddWithValue("@profNumber", profNumber);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateSchool(string schoolCode, string schoolName, int profNumber)
        {
            string query = "UPDATE SCHOOL SET SCHOOL_NAME = @schoolName, PROF_NUM = @profNumber WHERE SCHOOL_CODE = @schoolCode";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@schoolCode", schoolCode);
                    cmd.Parameters.AddWithValue("@schoolName", schoolName);
                    cmd.Parameters.AddWithValue("@profNumber", profNumber);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateSemester(string semesterCode, int? semesterYear, string semesterTerm, DateTime? semesterStartDate, DateTime? semesterEndDate)
        {
            string query = "UPDATE SEMESTER SET SEMESTER_YEAR = @semesterYear, SEMESTER_TERM = @semesterTerm, SEMESTER_START_DATE = @semesterStartDate, SEMESTER_END_DATE = @semesterEndDate WHERE SEMESTER_CODE = @semesterCode";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@semesterCode", semesterCode);
                    cmd.Parameters.AddWithValue("@semesterYear", semesterYear);
                    cmd.Parameters.AddWithValue("@semesterTerm", semesterTerm);
                    cmd.Parameters.AddWithValue("@semesterStartDate", semesterStartDate);
                    cmd.Parameters.AddWithValue("@semesterEndDate", semesterEndDate);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}