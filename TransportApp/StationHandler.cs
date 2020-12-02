using System.Linq;
using SwissTransport;

namespace TransportApp
{
	class StationHandler
	{
		//
		//Methods
		//
		public bool StationExists(string StationName)
		{
			Transport transport = new Transport();
			Stations stations = new Stations();
			stations = transport.GetStations(StationName);
			if (stations.StationList.Count != 0)
			{
				return (stations.StationList.First().Name == StationName);
			}

			return false;
		}
	}
}
