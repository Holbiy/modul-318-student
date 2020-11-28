using System;
using System.CodeDom.Compiler;
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

		private void buttonSearchConnections_Click(object sender, EventArgs e)
		{

			StationHandler stationHandler = new StationHandler();
			if (stationHandler.StationExists(comboBoxDeparture.Text))
			{
				if (stationHandler.StationExists(comboBoxArrival.Text))
				{
					_connections = _transport.GetConnections(comboBoxDeparture.Text, comboBoxArrival.Text, DateTime.Now.ToString("YYYY-MM-DD"), DateTime.Now.ToString("hh:mm"));
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



		private void buttonHome_Click(object sender, EventArgs e)
		{
			this.Hide();
			Home sistema = new Home();
			sistema.ShowDialog();
			this.Close();
		}

		private void buttonChange_Click(object sender, EventArgs e)
		{
			string temp = comboBoxArrival.Text;
			comboBoxArrival.Text = comboBoxDeparture.Text;
			comboBoxDeparture.Text = temp;
			panelButtons.BringToFront();
		}

		private void comboBoxDeparture_TextChanged(object sender, EventArgs e)
		{
			AutoCompletion autoCompletion = new AutoCompletion();
			autoCompletion.AddSugesstions(comboBoxDeparture);
		}

		private void comboBoxArrival_TextChanged(object sender, EventArgs e)
		{
			AutoCompletion autoCompletion = new AutoCompletion();
			autoCompletion.AddSugesstions(comboBoxArrival);
		}
	}
}
