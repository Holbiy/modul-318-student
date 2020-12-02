using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SwissTransport
{
    public class Transport : ITransport
    {
	    public Stations GetStations(string x, string y)
	    {
		    x = x.Replace(",", ".");
		    y = y.Replace(",", ".");
			WebRequest request = null;
		    WebResponse response = null;
		    Stream responseStream = null;
			try
            {
	            request = CreateWebRequest("http://transport.opendata.ch/v1/locations?x=" + x + "&y=" + y + "&type=station");
                response = request.GetResponse();
	            responseStream = response.GetResponseStream();
            }
		    catch
		    {
				MessageBox.Show("Stationen wegen Netzwerkfehler nicht aufrufbar.");
				Stations stations = new Stations();
				stations.StationList = new List<Station>();
				return stations;
			}
			if (responseStream != null)
			{
				var message = new StreamReader(responseStream).ReadToEnd();
				var stations = JsonConvert.DeserializeObject<Stations>(message
					, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
				return stations;
			}
			return null;
        }


        public Stations GetStations(string query)
        {
	        WebRequest request = null;
	        WebResponse response = null;
	        Stream responseStream = null;
	        query = System.Uri.EscapeDataString(query);
			try
	        {
		        request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query + "");
		        response = request.GetResponse();
		        responseStream = response.GetResponseStream();
	        }
	        catch
            {
	            MessageBox.Show("Stationen wegen Netzwerkfehler nicht aufrufbar.");
	            Stations stations = new Stations();
				stations.StationList = new List<Station>();
	            return stations;
            }
			if (responseStream != null)
			{
				var message = new StreamReader(responseStream).ReadToEnd();
				var stations = JsonConvert.DeserializeObject<Stations>(message
					, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
				return stations;
			}
			return null;
        }

        public StationBoardRoot GetStationBoard(string station, string id)
        {
	        station = System.Uri.EscapeDataString(station);
	        id = System.Uri.EscapeDataString(id);
			WebRequest request = null;
	        WebResponse response = null;
	        Stream responseStream = null;
			try
	        {
		        request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?station=" + station + "&id=" + id);
		        response = request.GetResponse();
		        responseStream = response.GetResponseStream();
	        }
	        catch
	        {
		        MessageBox.Show("Abfahrtstafel wegen Netzwerkfehler nicht aufrufbar.");
				StationBoardRoot stationBoardRoot = new StationBoardRoot();
				return stationBoardRoot;
	        }
			if (responseStream != null)
			{
				var readToEnd = new StreamReader(responseStream).ReadToEnd();
				var stationboard =
					JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
				return stationboard;
			}
			return null;
        }

		public Connections GetConnections(string fromStation, string toStation, string date, string time)
        {
	        toStation = Uri.EscapeDataString(toStation);
	        date = Uri.EscapeDataString(date);
	        time = Uri.EscapeDataString(time);
	        fromStation = Uri.EscapeDataString(fromStation);
			WebRequest request = null;
			WebResponse response = null;
			Stream responseStream = null;
			try
	        {
		        request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStation + "&date=" + date + "&time=" + time + "&limit=10");
		        response = request.GetResponse();
		        responseStream = response.GetResponseStream();
	        }
			catch
			{
				MessageBox.Show("Verbindungen wegen Netzwerkfehler nicht aufrufbar.");
				Connections connections = new Connections();
				connections.ConnectionList = new List<Connection>();
				return connections;
			}
			if (responseStream != null)
			{
				var readToEnd = new StreamReader(responseStream).ReadToEnd();
				var connections =
					JsonConvert.DeserializeObject<Connections>(readToEnd);
				return connections;
			}
			return null;
		}

       

		private static WebRequest CreateWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;
            
            return request;
        }
    }
}
