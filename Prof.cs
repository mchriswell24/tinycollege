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
    public partial class Profes : Form
    {
        public Profes()
        {
            InitializeComponent();
        }

        public void Prof_Load(object sender, EventArgs e)
        {

        }
        private void dataGridViewBtn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CrossBtn_Click(object sender, EventArgs e)
        {

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {

        }
        private void RoomBtn_Click_1(object sender, EventArgs e)
        {
            RoomsInfo roomsInfoForm = new RoomsInfo();
            roomsInfoForm.Show();
            this.Hide();
        }

        private void SchoolBtn_Click_1(object sender, EventArgs e)
        {

            SchoolInfo Form = new SchoolInfo();
            Form.Show();
            this.Hide();
        }

        private void ClassBtn_Click(object sender, EventArgs e)
        {

        }

        private void ProfessorBtn_Click(object sender, EventArgs e)
        {

        }

        private void StudentBtn_Click(object sender, EventArgs e)
        {

        }

        private void CourseBtn_Click(object sender, EventArgs e)
        {

        }

        private void DepartmentBtn_Click(object sender, EventArgs e)
        {

        }

        private void BuildingBtn_Click(object sender, EventArgs e)
        {

        }

        private void SemesterBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
