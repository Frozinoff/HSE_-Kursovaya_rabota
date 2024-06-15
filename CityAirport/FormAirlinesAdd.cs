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
using System.Configuration;

namespace CityAirport
{
    public partial class FormAirlinesAdd : Form
    {
        DataBase dataBase = new DataBase();
        public FormAirlinesAdd()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var name = textBox1.Text;
            var address = textBox2.Text;
            var phone = textBox3.Text;

            var addQuery = String.Format("insert into Airlines (airline_name, airline_address, airline_phone) values ('{0}', '{1}', '{2}')", name, address, phone);
            var command = new SqlCommand(addQuery, dataBase.GetConnection());
            command.ExecuteNonQuery();
            dataBase.closeConnection();
        }
    }
}
