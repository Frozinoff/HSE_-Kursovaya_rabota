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
    public partial class FormAirplanes : Form
    {
        int selectedRow;
        public FormAirplanes()
        {
            InitializeComponent();
        }

        private void airplanesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.airplanesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityAirportDataSet);

        }

        private void FormAirplanes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityAirportDataSet.Airplanes' table. You can move, or remove it, as needed.
            this.airplanesTableAdapter.Fill(this.cityAirportDataSet.Airplanes);

        }

        private void airplanesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = airplanesDataGridView.Rows[selectedRow];
                textBox_name.Text = row.Cells[1].Value.ToString();
                textBox_address.Text = row.Cells[2].Value.ToString();
                
            }
        }
    }
}
