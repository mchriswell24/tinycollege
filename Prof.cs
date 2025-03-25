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
    public partial class Prof : Form
    {
        public Prof()
        {
            InitializeComponent();
            PopulateComboBoxes();
        }

        private void Prof_Load(object sender, EventArgs e)
        {

        }
        private void PopulateComboBoxes()
        {
            string[] columnNames = {
                "PROF ID",
                "Dept Code",
                "PROF Speciality",
                "PROF Rank",
                "PROF LName",
                "PROF FName",
                "PROF Initial",
                "PROF Email"
            };

            ReadBtn.Items.AddRange(columnNames);
            CreateBtn.Items.AddRange(columnNames);
            UpdateBtn.Items.AddRange(columnNames);
            DeleteBtn.Items.AddRange(columnNames);
        }

        private void dataGridViewBtn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"Cell clicked: Row {e.RowIndex}, Column {e.ColumnIndex}");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
