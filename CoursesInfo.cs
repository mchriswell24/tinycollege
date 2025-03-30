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
    public partial class CoursesInfo : Form
    {
        public CoursesInfo()
        {
            InitializeComponent();
        }

        private void PNBtn_TextChanged(object sender, EventArgs e)
        {

        }

        public void CoursesInfo_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewBtn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {

        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void CreditsBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void CoursedescBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void CoursetitleBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void deptcodeBtn_TextChanged(object sender, EventArgs e)
        {

        }
        private void BuildingBtn_Click(object sender, EventArgs e)
        {
            Buildings Form = new Buildings();
            Form.Show();
            this.Hide();
        }

        private void DepartmentBtn_Click(object sender, EventArgs e)
        {
            DeptInfo Form = new DeptInfo();
            Form.Show();
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

        private void RoomBtn_Click(object sender, EventArgs e)
        {
            RoomsInfo roomsInfoForm = new RoomsInfo();
            roomsInfoForm.Show();
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
    }
}
