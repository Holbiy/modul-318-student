using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  SwissTransport;

namespace TransportApp
{
	public partial class SearchConnection : Form
	{
		private Stations _stations = new Stations();
		private Transport _transport = new Transport();
		private Connections _connections = new Connections();
		public SearchConnection()
		{
			InitializeComponent();

			
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void tableLayoutPanelLayout_Paint(object sender, PaintEventArgs e)
		{

		}

		private void buttonSearchConnections_Click(object sender, EventArgs e)
		{
			
			
			if (StationExists(textBoxDeparture.Text))
			{
				if (StationExists(textBoxArrival.Text))
				{
					_connections = _transport.GetConnections(textBoxDeparture.Text, textBoxArrival.Text);
					FillDataGrid(_connections);
				}
				else
				{
					MessageBox.Show("Ankunftsort nicht gefunden");
				}
			}
			else
			{
				MessageBox.Show("Abfahrtsort nicht gefunden.");
			}
		}

		private bool StationExists(string StationName)
		{
			_stations = _transport.GetStations(StationName);
			foreach (Station station in _stations.StationList)
			{
				if (station.Name == StationName)
				{
					return true;
				}
			}
			return false;
		}

		private void FillDataGrid(Connections connections)
		{
			dataGridViewConnections.Rows.Clear();
			foreach (Connection connection in connections.ConnectionList)
			{
				dataGridViewConnections.Rows.Add(
					connection.From.Station.Name,
					connection.To.Station.Name,
					connection.From.Platform,
					connection.From.Departure.Substring(0,10),
					connection.From.Departure.Substring(11, 8),
					connection.To.Arrival.Substring(11, 8),
					connection.Duration
				);
			}
			
		}

		private void buttonDepartureBoard_Click(object sender, EventArgs e)
		{
			
		}

		private void dataGridViewConnections_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void buttonHome_Click(object sender, EventArgs e)
		{
			new Home().Show();
			this.Hide();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{

		}
	}
}
