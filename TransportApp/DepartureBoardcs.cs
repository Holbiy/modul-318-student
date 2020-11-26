using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportApp
{
	public partial class DepartureBoardcs : Form
	{
		private Transport _transport = new Transport();

		public DepartureBoardcs()
		{
			InitializeComponent();
			textBoxDeparture.AutoCompleteMode = AutoCompleteMode.Suggest;
			textBoxDeparture.AutoCompleteSource = AutoCompleteSource.CustomSource;
			AutoCompleteStringCollection col = new AutoCompleteStringCollection();
			col.Add("Foo");
			col.Add("Bar");
			textBoxDeparture.AutoCompleteCustomSource = col;
		}

		private void buttonShowDepartureBoard_Click(object sender, EventArgs e)
		{
			StationHandler stationHandler = new StationHandler();
			if (stationHandler.StationExists(textBoxDeparture.Text))
			{
				StationBoardRoot stationBoardRoot = new StationBoardRoot();
				stationBoardRoot = _transport.GetStationBoard(textBoxDeparture.Text, "");
				FillDataGrid(stationBoardRoot);
			}
		}



		private void FillDataGrid(StationBoardRoot stationBoardRoot)
		{
			dataGridViewDepartureBoard.Rows.Clear();
			foreach (StationBoard stationBoard in stationBoardRoot.Entries)
			{
				dataGridViewDepartureBoard.Rows.Add(
					textBoxDeparture.Text,
					stationBoard.To,
					stationBoard.Name
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
	}
}
