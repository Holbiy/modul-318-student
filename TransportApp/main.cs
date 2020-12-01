using System;
using System.Windows.Forms;
using SwissTransport;
using System.Device.Location;
using System.Diagnostics;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Net.Mail;
using System.Net;








//Probleme:
//
//Kein Netzwerk
//Eingabe von Firmen
//
//


namespace TransportApp
{
	public partial class main : Form
	{
		Transport _transport = new Transport();

		public main()
		{
			InitializeComponent();
			NavigationButton(ButtonNavigateConnections);
			watcher.Start();
		}


		/*------------------------------------------*/
		//					General					//
		/*------------------------------------------*/

		//
		//Events
		//

		//Navigation
		private void ButtonNavigate_Click(object sender, EventArgs e)
		{
			var button = (Button) sender;
			NavigationButton(button);
		}

		//Autocomplete
		private void comboBoxAutocomplete_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up && e.KeyCode != Keys.Enter && e.KeyCode != Keys.Escape)
			{
				var combobox = (ComboBox)sender;
				AutoCompletion.AddSugesstions(combobox);
			}
		}

		//
		//Methods
		//

		private void NavigationButton(Button button)
		{
			foreach (Panel panel in panelContent.Controls)
			{
				panel.Enabled = false;
			}
			labelTitle.BackColor = button.BackColor;
			labelTitle.Text = button.Text;
			if (button.Name == "ButtonNavigateConnections")
			{
				panelConnections.Enabled = true;
				panelConnections.BringToFront();
			}
			else if (button.Name == "buttonNavigateDepartureBoard")
			{
				panelDepartureBoard.Enabled = true;
				panelDepartureBoard.BringToFront();
			}
			else if (button.Name == "buttonNavigationNearMe")
			{
				panelNearMe.Enabled = true;
				panelNearMe.BringToFront();
			}
			else if (button.Name == "buttonNavigationMaps")
			{
				panelMaps.Enabled = true;
				panelMaps.BringToFront();

			}
		}

		/*------------------------------------------*/
		//				 Connections				//
		/*------------------------------------------*/

		//
		//Events
		//

		//Key Pressdown

		private void comboBoxEnterConnections_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				buttonConnections_Click(this, null);
		}

		private void textBoxEnterMail_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				buttonMail_Click(this, null);
		}


		//Buttons

		private void buttonSwitch_Click(object sender, EventArgs e)
		{
			string temp = comboBoxConnectionsArrival.Text;
			comboBoxConnectionsArrival.Text = comboBoxConnectionsDeparture.Text;
			comboBoxConnectionsDeparture.Text = temp;
		}

		private void buttonConnections_Click(object sender, EventArgs e)
		{
			Connections connections = new Connections();
			StationHandler stationHandler = new StationHandler();
			if (stationHandler.StationExists(comboBoxConnectionsDeparture.Text))
			{
				if (stationHandler.StationExists(comboBoxConnectionsArrival.Text))
				{
					string date = dateTimePickerDepartureDate.Value.ToString("yyyy-MM-dd");
					string time = dateTimePickerDepartureTime.Value.ToString("HH:mm");
					connections = _transport.GetConnections(comboBoxConnectionsDeparture.Text, comboBoxConnectionsArrival.Text, date, time );
					if (connections.ConnectionList.Count != 0)
					{
						DataGridViewFiller dataGridViewFiller = new DataGridViewFiller();
						dataGridViewFiller.FillDataGridConnections(connections, dataGridViewConnections);
					}
					else
					{
						MessageBox.Show("Keine Verbindungen gefunden.");
					}
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

		private void buttonMail_Click(object sender, EventArgs e)
		{
			if (textBoxMail.Text != string.Empty)
			{
				if (dataGridViewConnections.SelectedRows.Count != 0)
				{
					string message = "Verbindungen:%0D%0A";
					int i = 1;
					foreach (DataGridViewRow rows in dataGridViewConnections.SelectedRows)
					{
						message += "Verbindung " + i++ + ": ";
						foreach (DataGridViewCell cell in rows.Cells)
						{
							message += cell.OwningColumn.HeaderText + " = " + cell.Value;
							if (cell.ColumnIndex + 1 != rows.Cells.Count)
								message += ", ";
						}
						message += "%0D%0A";
					}
					Process.Start("mailto:" + textBoxMail.Text + "?subject=Verbindungen&body=" + message);
				}
				else
				{
					MessageBox.Show("Keine Verbindungen wurden markiert.");
				}
			}
			else
			{
				MessageBox.Show("Keine E-Mail wurde angegeben.");
			}
			/*
				SmtpClient client = new SmtpClient("smtp.gmail.com");
				client.Port = 587;
				client.EnableSsl = true;
				client.DeliveryMethod = SmtpDeliveryMethod.Network;
				client.Credentials = new NetworkCredential("transportapplikation@gmail.com", "transport123");

				var mail = new MailMessage("transportapplikation@gmail.com", "dario.hollbach@outlook.com");
				mail.Subject = "Nachricht";
				mail.Body = mailBody;
				mail.IsBodyHtml = true;
				DataGridViewCell dataGridViewCell = new DataGridViewButtonCell();
				dataGridViewCell.*/
		}




		/*------------------------------------------*/
		//				Abfahrtstafel				//
		/*------------------------------------------*/

		//
		//Events
		//

		//Key Pressdown
		private void comboBoxEnterDepartureTable_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				buttonShowDepartureBoard_Click(this, null);
		}

		//Buttons

		private void buttonShowDepartureBoard_Click(object sender, EventArgs e)
		{
			StationHandler stationHandler = new StationHandler();
			if (stationHandler.StationExists(comboBoxDepartureBoardDeparture.Text))
			{
				StationBoardRoot stationBoardRoot = new StationBoardRoot();
				stationBoardRoot = _transport.GetStationBoard(comboBoxDepartureBoardDeparture.Text, "");
				DataGridViewFiller dataGridViewFiller = new DataGridViewFiller();
				dataGridViewFiller.FillDataGridDepartureBoard(stationBoardRoot, dataGridViewDepartureBoard);
			}
		}

		/*------------------------------------------*/
		//					Maps					//
		/*------------------------------------------*/

		//
		//Events
		//

		private void comboBoxEnterMaps_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				buttonShowMap_Click(this, null);
		}

		private void buttonShowMap_Click(object sender, EventArgs e)
		{
			StationHandler stationHandler = new StationHandler();
			if (stationHandler.StationExists(comboBoxMapsStation.Text))
			{
				gMapControlStation.MapProvider = GMapProviders.GoogleMap;
				gMapControlStation.DragButton = MouseButtons.Left;
				gMapControlStation.Visible = true;

				Stations stations = new Stations();
				stations = _transport.GetStations(comboBoxMapsStation.Text);
				double x = stations.StationList[0].Coordinate.XCoordinate;
				double y = stations.StationList[0].Coordinate.YCoordinate;

				PointLatLng point = new PointLatLng(x, y);

				gMapControlStation.Position = point;

				//Marker

				GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);
				GMapOverlay markers = new GMapOverlay("makers");
				markers.Markers.Add(marker);
				gMapControlStation.Overlays.Clear();
				gMapControlStation.Overlays.Add(markers);
			}
			
		}

		/*------------------------------------------*/
		//					Near Me					//
		/*------------------------------------------*/

		//
		//Variablen
		//

		GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

		//
		//Events
		//

		private void buttonShowNearMe_Click(object sender, EventArgs e)
		{
			if (watcher.Position.Location.IsUnknown)
			{
				MessageBox.Show("Aktueller Standord nicht verfügbar");
			}
			else
			{
				string x = watcher.Position.Location.Latitude.ToString();
				string y = watcher.Position.Location.Longitude.ToString();
				Stations stations = new Stations();
				stations = _transport.GetStations(x, y);
				DataGridViewFiller dataGridViewFiller = new DataGridViewFiller();
				dataGridViewFiller.FillDataGridNearMe(stations, dataGridViewNearMe);
			}
			watcher.Stop();
		}
	}
}
