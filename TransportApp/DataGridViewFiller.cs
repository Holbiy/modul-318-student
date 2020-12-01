using SwissTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportApp
{
	class DataGridViewFiller
	{
		public void FillDataGridNearMe(Stations stations, DataGridView dataGridView)
		{
			dataGridView.Rows.Clear();
			foreach (Station station in stations.StationList)
			{
				dataGridView.Rows.Add(
					station.Name,
					station.Distance + "m"
				);
			}
		}


		public void FillDataGridConnections(Connections connections, DataGridView dataGridView)
		{
			dataGridView.Rows.Clear();
			foreach (Connection connection in connections.ConnectionList)
			{
				dataGridView.Rows.Add(
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

		public void FillDataGridDepartureBoard(StationBoardRoot stationBoardRoot, DataGridView dataGridView)
		{
			dataGridView.Rows.Clear();
			foreach (StationBoard stationBoard in stationBoardRoot.Entries)
			{
				dataGridView.Rows.Add(
					stationBoard.Category,
					stationBoard.To,
					stationBoard.Name
				);
			}

		}
	}



}
