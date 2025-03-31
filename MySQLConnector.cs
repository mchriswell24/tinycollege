
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Drawing;


namespace tinycollege
{
    
    public class MySQLConnector
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tinycollege;";
        public DataTable Fetchenroll()
        {
            var result = new DataTable();
            // Select all
            string query = "SELECT * FROM professor";
            try
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                            {
                                adapter.Fill(result);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
        public DataTable Fetchstudent()
        {
            var result = new DataTable();
            // Select all
            string query = "SELECT * FROM student";
            try
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                            {
                                adapter.Fill(result);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
        public DataTable Fetchcourse()
        {

            var result = new DataTable();
            // Select all
            string query = "SELECT * FROM course";
            try
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                            {
                                adapter.Fill(result);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        public DataTable Fetchdepartment()
        {

            var result = new DataTable();
            // Select all
            string query = "SELECT * FROM department";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(result);
                    }
                }
            }
            return result;
        }

public DataTable FetchSchool()
        {

            var result = new DataTable();
            // Select all
            string query = "SELECT * FROM school";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(result);
                    }
                }
            }
            return result;
        }
        public DataTable Fetchprofessor()
        {

            var result = new DataTable();
            // Select all
            string query = "SELECT * FROM professor";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(result);
                    }
                }
            }
            return result;
        }
        public DataTable FetchSemester()
        {

            var result = new DataTable();
            // Select all
            string query = "SELECT * FROM semester";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(result);
                    }
                }
            }
            return result;
        }

        public DataTable FetchClass()
        {

            var result = new DataTable();
            // Select all
            string query = "SELECT * FROM class";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(result);
                    }
                }
            }
            return result;
        }
        public DataTable FetchRoom()
        {

            var result = new DataTable();
            // Select all
            string query = "SELECT * FROM room";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(result);
                    }
                }
            }
            return result;
        }
        public DataTable FetchCourse()
        {

            var result = new DataTable();
            // Select all
            string query = "SELECT * FROM course";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(result);
                    }
                }
            }
            return result;
        }

        public DataTable FetchBuilding()
        {

            var result = new DataTable();
            // Select all
            string query = "SELECT * FROM building";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(result);
                    }
                }
            }
            return result;
        }

        public DataTable FetchMembersEnroll()
        {

            var result = new DataTable();
            // Select all
            string query = "SELECT * FROM enroll";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(result);
                    }
                }
            }
            return result;
        }





















        public void InsertUser(string firstName, string lastName, string address)
        {
            string query = "INSERT INTO user (first_name, last_name,address) VALUES (@firstName, @lastName,@address)";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@lastName", lastName);
                        command.Parameters.AddWithValue("@address", address);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
