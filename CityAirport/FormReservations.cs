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
    public partial class FormReservations : Form
    {
        int selectedRow;
        public FormReservations()
        {
            InitializeComponent();
        }

        private void FormReservations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityAirportDataSet.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.cityAirportDataSet.Reservations);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                textBox_name.Text = row.Cells[1].Value.ToString();
                textBox_address.Text = row.Cells[2].Value.ToString();
                textBox_phone.Text = row.Cells[3].Value.ToString();
                textBox1.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
