using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CityAirport
{
   
    
    public partial class FormAirlines : Form
    {

        DataBase dataBase = new DataBase();

        int selectedRow;
        public FormAirlines()
        {
            InitializeComponent();
        }

        
        private void airlinesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.airlinesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityAirportDataSet);
            
        }

        private void FormAirlines_Load(object sender, EventArgs e)
        {
            
            this.airlinesTableAdapter.Fill(this.cityAirportDataSet.Airlines);
            
        }

        private void airlinesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = airlinesDataGridView.Rows[selectedRow];
                textBox_name.Text = row.Cells[1].Value.ToString();
                textBox_address.Text = row.Cells[2].Value.ToString();
                textBox_phone.Text = row.Cells[3].Value.ToString();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAirlinesAdd addform = new FormAirlinesAdd();
            addform.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            airlinesTableAdapter.Fill(cityAirportDataSet.Airlines);

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string delete = $"delete from airlines where airline_id =  {Convert.ToInt32(airlinesDataGridView.Rows[selectedRow].Cells[0].Value)}";
            dataBase.openConnection();
            SqlCommand cmd = new SqlCommand(delete, dataBase.GetConnection());
            cmd.ExecuteNonQuery();
            dataBase.closeConnection();

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string edit = $"update airlines set airline_name = '{textBox_name.Text}', airline_address = '{textBox_address.Text}', airline_phone = '{textBox_phone.Text}' where " +
                $"airline_id =  {Convert.ToInt32(airlinesDataGridView.Rows[selectedRow].Cells[0].Value)}";
            dataBase.openConnection();
            SqlCommand cmd = new SqlCommand(edit, dataBase.GetConnection());
            cmd.ExecuteNonQuery();
            dataBase.closeConnection();
        }
    }
}
