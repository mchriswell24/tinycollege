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
    public partial class TeachersInfo : Form
    {
        public TeachersInfo()
        {
            InitializeComponent();
        }

        public void TeachersInfo_Load(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LnBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void PNBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fntn_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void Depttn_TextChanged(object sender, EventArgs e)
        {

        }

        private void SpecialityBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {

        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }
        private void CrossBtn_Click_1(object sender, EventArgs e)
        {

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
    }
}
