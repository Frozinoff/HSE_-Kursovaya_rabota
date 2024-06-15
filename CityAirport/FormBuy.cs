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

    public partial class FormBuy : Form
    {
        DataBase dataBase = new DataBase();
        private SqlConnection sqlConnection = null;
        public FormBuy()
        {
            InitializeComponent();
        }

        private void FormBuy_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("flight_id", "номер");
            // TODO: This line of code loads data into the 'cityAirportDataSet1.FlightEdit' table. You can move, or remove it, as needed.
            this.flightEditTableAdapter.Fill(this.cityAirportDataSet1.FlightEdit);
            sqlConnection = new SqlConnection("Data Source=DESKTOP-6JH1KPO\\SQLEXPRESS;Initial Catalog=CityAirport;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM FlightEdit", sqlConnection);
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView1.DataSource = db.Tables[0];

            SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT Seats.*, Airplanes.airplane_name FROM Seats JOIN Airplanes ON Seats.airplane_id = Airplanes.airplane_id", sqlConnection);
            DataSet db1 = new DataSet();
            dataAdapter1.Fill(db1);
            dataGridView2.DataSource = db1.Tables[0];
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //2023.09.01
            DateTime dateStart = DateTime.Parse(textBox1.Text);
            DateTime dateEnd = DateTime.Parse(textBox2.Text);
            if (textBox3.Text != String.Empty && textBox4.Text != String.Empty)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("flight_origin LIKE '{0}' AND flight_destination LIKE '{1}' AND flight_date >= #{2}# AND flight_date <= #{3}#",
                    textBox3.Text, textBox4.Text, dateStart.ToString("yyyy-MM-dd"), dateEnd.ToString("yyyy-MM-dd"));
            }
            else if (textBox3.Text == "" && textBox4.Text != String.Empty)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("flight_destination LIKE '{0}' AND flight_date >= #{1}# AND flight_date <= #{2}#",
                    textBox4.Text, dateStart.ToString("yyyy-MM-dd"), dateEnd.ToString("yyyy-MM-dd"));
            }
            else if (textBox3.Text != String.Empty && textBox4.Text == "")
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("flight_origin LIKE '{0}' AND flight_date >= #{1}# AND flight_date <= #{2}#",
                    textBox3.Text, dateStart.ToString("yyyy-MM-dd"), dateEnd.ToString("yyyy-MM-dd"));
            }
            else
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
            }
        }

        private void buttonAddBuy_Click(object sender, EventArgs e)
        {
            FormAddBuy form = new FormAddBuy();
            form.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var Fname = textBox5.Text;
            var Lname = textBox6.Text;
            var adres = textBox7.Text;
            var phone = textBox8.Text;
            var Nfl = textBox9.Text;
            var Nseat = textBox10.Text;

            /*var addQuery = String.Format("insert into flights (airline_name, airline_address, airline_phone) values ('{0}', '{1}', '{2}')",
                Fname, Lname, phone);
            var command = new SqlCommand(addQuery, dataBase.GetConnection());
            command.ExecuteNonQuery();
            dataBase.closeConnection();*/
        }
    }
}
