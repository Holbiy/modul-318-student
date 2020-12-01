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
		}

		private void buttonShowDepartureBoard_Click(object sender, EventArgs e)
		{
			StationHandler stationHandler = new StationHandler();
			if (stationHandler.StationExists(comboBoxDeparture.Text))
			{
				StationBoardRoot stationBoardRoot = new StationBoardRoot();
				stationBoardRoot = _transport.GetStationBoard(comboBoxDeparture.Text, "");
				FillDataGrid(stationBoardRoot);
			}
		}

		private void FillDataGrid(StationBoardRoot stationBoardRoot)
		{
			dataGridViewDepartureBoard.Rows.Clear();
			foreach (StationBoard stationBoard in stationBoardRoot.Entries)
			{
				dataGridViewDepartureBoard.Rows.Add(
					comboBoxDeparture.Text,
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

		private void comboBoxDeparture_TextChanged(object sender, EventArgs e)
		{
			AutoCompletion autoCompletion = new AutoCompletion();
			AutoCompletion.AddSugesstions(comboBoxDeparture);
		}
	}
}
