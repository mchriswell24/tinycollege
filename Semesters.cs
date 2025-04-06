using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tinycollege
{
    public partial class Semesters : Form
    {
        MySQLConnector mmm = new MySQLConnector();
        SQLSearch search = new SQLSearch(); 


        public Semesters()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void Semesters_Load(object sender, EventArgs e)
        {
            dataGridView0.DataSource = mmm.Fetchsemester();

        }

        private void dataGridViewBtn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SemTermBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void SemCodeBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void SemyearBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2Btn_ValueChanged(object sender, EventArgs e)
        {

        }
        private void ClassBtn_Click(object sender, EventArgs e)
        {
            ClassesInfo Form = new ClassesInfo();
            Form.Show();
            this.Hide();
        }

        private void SchoolBtn_Click(object sender, EventArgs e)
        {
            SchoolInfo Form = new SchoolInfo();
            Form.Show();
            this.Hide();
        }

        private void StudentBtn_Click(object sender, EventArgs e)
        {
            StudentsInfo Form = new StudentsInfo();
            Form.Show();
            this.Hide();
        }

        private void CourseBtn_Click(object sender, EventArgs e)
        {

            CoursesInfo Form = new CoursesInfo();
            Form.Show();
            this.Hide();
        }

        private void DepartmentBtn_Click(object sender, EventArgs e)
        {
            DeptInfo Form = new DeptInfo();
            Form.Show();
            this.Hide();
        }

        private void BuildingBtn_Click(object sender, EventArgs e)
        {
            Buildings Form = new Buildings();
            Form.Show();
            this.Hide();
        }

        private void ProfessorBtn_Click(object sender, EventArgs e)
        {
            TeachersInfo Form = new TeachersInfo();
            Form.Show();
            this.Hide();
        }

        private void RoomBtn_Click(object sender, EventArgs e)
        {
            RoomsInfo roomsInfoForm = new RoomsInfo();
            roomsInfoForm.Show();
            this.Hide();
        }

        private void BtnEnrollment_Click(object sender, EventArgs e)
        {
            Profes profesForm = new Profes();
            profesForm.Show();
            this.Hide();
        }

        private void dataGridView0_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
