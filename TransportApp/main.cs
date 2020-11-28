using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace TransportApp
{
	public partial class main : Form
	{
		Transport _transport = new Transport();
		public main()
		{
			InitializeComponent();
		}


		//
		//Main
		//
		private void ButtonNavigateSearch_Click(object sender, EventArgs e)
		{
			panelSearch.BringToFront();
			ButtonNavigateSearch.BackColor = Color.PaleVioletRed;
			buttonNavigateDepartureBoard.BackColor = Color.AliceBlue;
			labelTitle.Text = "Verbindung suchen";
			dateTimePickerDepartureTime.Value = DateTime.Now;
			dateTimePickerDepartureDate.Value = DateTime.Now;
		}

		private void buttonNavigateDepartureBoard_Click(object sender, EventArgs e)
		{
			panelDepartureBoard.BringToFront();
			ButtonNavigateSearch.BackColor = Color.AliceBlue;
			buttonNavigateDepartureBoard.BackColor = Color.PaleVioletRed;
			labelTitle.Text = "Abfahrtstafel";
		}


		//
		//Search Connections
		//

		//Variabeln

		//Controls
		private void buttonSearchChange_Click(object sender, EventArgs e)
		{
			string temp = comboBoxSearchArrival.Text;
			comboBoxSearchArrival.Text = comboBoxSearchDeparture.Text;
			comboBoxSearchDeparture.Text = temp;
		}

		private void buttonSearchConnections_Click(object sender, EventArgs e)
		{
			Connections connections = new Connections();
			StationHandler stationHandler = new StationHandler();
			if (stationHandler.StationExists(comboBoxSearchDeparture.Text))
			{
				if (stationHandler.StationExists(comboBoxSearchArrival.Text))
				{
					string date = dateTimePickerDepartureDate.Value.ToString("yyyy-MM-dd");
					string time = dateTimePickerDepartureTime.Value.ToString("HH:mm");
					connections = _transport.GetConnections(comboBoxSearchDeparture.Text, comboBoxSearchArrival.Text, date, time );
					FillDataGrid(connections);
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

		private void comboBoxSearchDeparture_TextChanged(object sender, EventArgs e)
		{
			AutoCompletion autoCompletion = new AutoCompletion();
			autoCompletion.AddSugesstions(comboBoxSearchDeparture);
		}

		private void comboBoxSearchArrival_TextChanged(object sender, EventArgs e)
		{
			AutoCompletion autoCompletion = new AutoCompletion();
			autoCompletion.AddSugesstions(comboBoxSearchArrival);
		}

		//Methoden

		private void FillDataGrid(Connections connections)
		{
			dataGridViewSearchConnections.Rows.Clear();
			foreach (Connection connection in connections.ConnectionList)
			{
				dataGridViewSearchConnections.Rows.Add(
					connection.From.Station.Name,
					connection.To.Station.Name,
					connection.From.Platform,
					connection.From.Departure.Substring(0, 10),
					connection.From.Departure.Substring(11, 8),
					connection.To.Arrival.Substring(11, 8),
					connection.Duration
				);
			}

		}

		//
		//Abfahrtstafel
		//

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void buttonShowDepartureBoard_Click(object sender, EventArgs e)
		{
			StationHandler stationHandler = new StationHandler();
			if (stationHandler.StationExists(comboBoxDepartureBoardDeparture.Text))
			{
				StationBoardRoot stationBoardRoot = new StationBoardRoot();
				stationBoardRoot = _transport.GetStationBoard(comboBoxDepartureBoardDeparture.Text, "");
				FillDataGrid(stationBoardRoot);
			}
		}

		private void FillDataGrid(StationBoardRoot stationBoardRoot)
		{
			dataGridViewDepartureBoard.Rows.Clear();
			foreach (StationBoard stationBoard in stationBoardRoot.Entries)
			{
				dataGridViewDepartureBoard.Rows.Add(
					comboBoxDepartureBoardDeparture.Text,
					stationBoard.To,
					stationBoard.Name
				);
			}

		}


		private void comboBoxDepartureBoardDeparture_TextChanged(object sender, EventArgs e)
		{
			AutoCompletion autoCompletion = new AutoCompletion();
			autoCompletion.AddSugesstions(comboBoxDepartureBoardDeparture);
		}
	}
}
