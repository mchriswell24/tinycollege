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
        private void CrossBtn_Click(object sender, EventArgs e)
        {
            Profes profesForm = new Profes();
            profesForm.Show();

            // Close the current RoomsInfo form
            this.Close();
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

        private void CourseBtn_Click(object sender, EventArgs e)
        {

        }

        private void BuildingBtn_Click(object sender, EventArgs e)
        {

        }

        private void DepartmentBtn_Click(object sender, EventArgs e)
        {

        }

        private void ProfessorBtn_Click(object sender, EventArgs e)
        {

        }

        private void SemesterBtn_Click(object sender, EventArgs e)
        {

        }

        private void RoomBtn_Click(object sender, EventArgs e)
        {

        }

        private void StudentBtn_Click(object sender, EventArgs e)
        {

        }

        private void ClassBtn_Click(object sender, EventArgs e)
        {

        }

        private void SchoolBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
