using SwissTransport;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TransportApp
{
	class AutoCompletion
	{
		//
		//Membervariabeln
		//
		private static Transport _transport = new Transport();

		//
		//Methoden
		//
		public static void AddSuggestions(ComboBox comboBox)
		{
			//Liste erstellen
			List<string> temp = new List<string>();
			foreach (var station in _transport.GetStations(comboBox.Text).StationList)
			{
				temp.Add(station.Name);
			}
			//combobox bearbeiten
			if (temp.Count != 0 && temp.First() != null)
			{
				comboBox.Items.Clear();
				comboBox.Items.Add(comboBox.Text);
				comboBox.Items.AddRange(temp.ToArray());
				if (comboBox.DroppedDown == false)
				{
					comboBox.DroppedDown = true;
				}
				comboBox.SelectionStart = comboBox.Text.Length;
			}
			else
			{
				comboBox.DroppedDown = false;
			}
		}
	}

	
}
