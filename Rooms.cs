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
    public partial class RoomsInfo : Form
    {
        public RoomsInfo()
        {
            InitializeComponent();
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

        private void RoomcodeBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomtypeBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuildingcodeBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            Profes profesForm = new Profes();
            profesForm.Show();

            // Close the current RoomsInfo form
            this.Close();
        }

        private void RoomsInfo_Load(object sender, EventArgs e)
        {

        }

        private void RoomsInfo_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void SchoolBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
