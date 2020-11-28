using SwissTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportApp
{
	class AutoCompletion
	{
		//Membervariabeln
		private Transport _transport = new Transport();

		//Methoden
		public void AddSugesstions(ComboBox comboBox)
		{
			List<string> temp = new List<string>();
			foreach (var station in _transport.GetStations(comboBox.Text).StationList)
			{
				temp.Add(station.Name);
			}
			if (temp != null)
				comboBox.Items.AddRange(temp.ToArray());
		}

	}
}
