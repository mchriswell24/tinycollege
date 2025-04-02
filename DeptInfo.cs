using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tinycollege
{
    public partial class DeptInfo : Form
    {
        MySQLConnector mmm = new MySQLConnector();

        public DeptInfo()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public void DeptInfo_Load(object sender, EventArgs e)
        {
            dataGridView6.DataSource = mmm.Fetchdepartment();

        }

        private void EdateBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ScBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void deptnameBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {

        }

        private void RoomBtn_Click(object sender, EventArgs e)
        {
            RoomsInfo roomsInfoForm = new RoomsInfo();
            roomsInfoForm.Show();
            this.Hide();
        }

        private void ProfessorBtn_Click(object sender, EventArgs e)
        {
            TeachersInfo Form = new TeachersInfo();
            Form.Show();
            this.Hide();
        }

        private void SemesterBtn_Click(object sender, EventArgs e)
        {
            Semesters Form = new Semesters();
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

        private void CourseBtn_Click(object sender, EventArgs e)
        {
            CoursesInfo Form = new CoursesInfo();
            Form.Show();
            this.Hide();
        }

        private void StudentBtn_Click(object sender, EventArgs e)
        {

            StudentsInfo Form = new StudentsInfo();
            Form.Show();
            this.Hide();
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

        private void BtnEnrollment_Click(object sender, EventArgs e)
        {
            Profes profesForm = new Profes();
            profesForm.Show();
            this.Hide();
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
