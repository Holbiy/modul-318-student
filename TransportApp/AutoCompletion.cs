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
		private static Transport _transport = new Transport();

		//Methoden
		public static void AddSugesstions(ComboBox comboBox)
		{
			if (comboBox.Text.Length >= 0)
			{
				string text = comboBox.Text;
				List<string> temp = new List<string>();
				foreach (var station in _transport.GetStations(comboBox.Text).StationList)
				{
					temp.Add(station.Name);
				}
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

	
}
