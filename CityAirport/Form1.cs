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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void бронированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuy form = new FormBuy();
            form.Show();
        }

        private void авиакомпанииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAirlines form = new FormAirlines();
            form.Show();
        }

        private void самолетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAirplanes form = new FormAirplanes();
            form.Show();
        }

        private void пассажирыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPassengers form = new FormPassengers();
            form.Show();
        }

        private void местаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSeats form = new FormSeats();
            form.Show();
        }

        private void рейсыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFlights form = new FormFlights();
            form.Show();
        }

        
    }
}
