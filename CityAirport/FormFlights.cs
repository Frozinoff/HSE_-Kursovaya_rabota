 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityAirport
{
    public partial class FormFlights : Form
    {
        int selectedRow;
        public FormFlights()
        {
            InitializeComponent();
        }

        private void flightsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.flightsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityAirportDataSet);

        }

        private void FormFlights_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityAirportDataSet1.FlightEdit' table. You can move, or remove it, as needed.
            this.flightEditTableAdapter.Fill(this.cityAirportDataSet1.FlightEdit);
            // TODO: This line of code loads data into the 'cityAirportDataSet.Flights' table. You can move, or remove it, as needed.
            this.flightsTableAdapter.Fill(this.cityAirportDataSet.Flights);

        }

        private void flightsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = flightsDataGridView.Rows[selectedRow];
                textBox_name.Text = row.Cells[1].Value.ToString();
                textBox_address.Text = row.Cells[2].Value.ToString();
                textBox_phone.Text = row.Cells[3].Value.ToString();
                textBox1.Text = row.Cells[4].Value.ToString();
                textBox2.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
