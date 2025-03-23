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

            ReadcomboBoxBtn.Items.AddRange(columnNames);
            CreatecomboBoxBtn.Items.AddRange(columnNames);
            UpdatecomboBoxBtn.Items.AddRange(columnNames);
            DeletecomboBoxBtn.Items.AddRange(columnNames);
        }

        private void ReadcomboBoxBtn_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"You selected: {ReadcomboBoxBtn.SelectedItem}");
        }

        private void UpdatecomboBoxBtn_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"You selected: {UpdatecomboBoxBtn.SelectedItem}");
        }

        private void CreatecomboBoxBtn_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"You selected: {CreatecomboBoxBtn.SelectedItem}");
        }

        private void DeletecomboBoxBtn_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"You selected: {DeletecomboBoxBtn.SelectedItem}");
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
    }
}
