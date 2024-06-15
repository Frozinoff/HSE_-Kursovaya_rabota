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
    public partial class FormSeats : Form
    {
        int selectedRow;
        public FormSeats()
        {
            InitializeComponent();
        }

        private void seatsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.seatsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityAirportDataSet);

        }

        private void FormSeats_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityAirportDataSet.Seats' table. You can move, or remove it, as needed.
            this.seatsTableAdapter.Fill(this.cityAirportDataSet.Seats);

        }

        private void seatsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = seatsDataGridView.Rows[selectedRow];
                textBox_name.Text = row.Cells[1].Value.ToString();
                textBox_address.Text = row.Cells[2].Value.ToString();
                textBox_phone.Text = row.Cells[3].Value.ToString();
                
            }
        }
    }
}
