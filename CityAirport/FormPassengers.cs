using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CityAirport
{
    public partial class FormPassengers : Form
    {
        int selectedRow;
        public FormPassengers()
        {
            InitializeComponent();
        }

        private void passengersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.passengersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityAirportDataSet);

        }

        private void FormPassengers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityAirportDataSet.Passengers' table. You can move, or remove it, as needed.
            this.passengersTableAdapter.Fill(this.cityAirportDataSet.Passengers);

        }

        private void passengersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = passengersDataGridView.Rows[selectedRow];
                textBox_name.Text = row.Cells[1].Value.ToString();
                textBox_address.Text = row.Cells[2].Value.ToString();
                textBox_phone.Text = row.Cells[3].Value.ToString();
                textBox1.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
