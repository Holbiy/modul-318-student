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
			textBoxDeparture.AutoCompleteMode = AutoCompleteMode.Suggest;
			textBoxDeparture.AutoCompleteSource = AutoCompleteSource.CustomSource;
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


		private void dataGridViewConnections_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

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
			string temp = textBoxArrival.Text;
			textBoxArrival.Text = textBoxDeparture.Text;
			textBoxDeparture.Text = temp;
		}

		private void groupBoxInput_Enter(object sender, EventArgs e)
		{

		}

		private void dateTimePickerDepartureTime_ValueChanged(object sender, EventArgs e)
		{

		}

		private void labelDepartureTime_Click(object sender, EventArgs e)
		{

		}

		private void labelArrival_Click(object sender, EventArgs e)
		{

		}

		private void labelDeparture_Click(object sender, EventArgs e)
		{

		}

		private void textBoxArrival_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBoxDeparture_TextChanged(object sender, EventArgs e)
		{
			if (textBoxDeparture.Text.Length >= 1)
			{
				List<string> temp = new List<string>();
				foreach (var station in _transport.GetStations(textBoxDeparture.Text).StationList)
				{
					temp.Add(station.Name);
				}
				var autoComplete = new AutoCompleteStringCollection();
				autoComplete.AddRange(temp.ToArray());
				textBoxDeparture.AutoCompleteCustomSource = autoComplete;
			}
		}

		private void panelTitle_Paint(object sender, PaintEventArgs e)
		{

		}

		private void labelTitle_Click(object sender, EventArgs e)
		{

		}

		private void panelButtons_Paint(object sender, PaintEventArgs e)
		{

		}

		private void textBoxDeparture_KeyPress(object sender, KeyPressEventArgs e)
		{

		}
	}
}
