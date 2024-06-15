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
    public partial class FormAddBuy : Form
    {
        private SqlConnection sqlConnection = null;
        public FormAddBuy()
        {
            InitializeComponent();
        }

        private void FormAddBuy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityAirportDataSet.Seats' table. You can move, or remove it, as needed.
            this.seatsTableAdapter.Fill(this.cityAirportDataSet.Seats);
            
            sqlConnection = new SqlConnection("Data Source=DESKTOP-6JH1KPO\\SQLEXPRESS;Initial Catalog=CityAirport;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Seats.*, Airplanes.airplane_name FROM Seats JOIN Airplanes ON Seats.airplane_id = Airplanes.airplane_id", sqlConnection);
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView1.DataSource = db.Tables[0];

            

            // Открыть соединение с базой данных
            

            // Запрос к базе данных для получения данных, которые нужно добавить в ComboBox
            string query = "SELECT seat_number FROM Seats";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            // Выполнить запрос и получить результаты
            SqlDataReader reader = cmd.ExecuteReader();

            // Заполнить ComboBox данными, используя метод Add()
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["seat_number"].ToString());
            }

            // Закрыть соединение с базой данных
            sqlConnection.Close();
        }

        
    }
}
