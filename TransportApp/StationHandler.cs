using SwissTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
	class StationHandler
	{
		public bool StationExists(string StationName)
		{
			Transport transport = new Transport();
			Stations stations = new Stations();
			stations= transport.GetStations(StationName);
			foreach (Station station in stations.StationList)
			{
				if (station.Name == StationName)
				{
					return true;
				}
			}
			return false;
		}
	}
}
