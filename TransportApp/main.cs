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
		//					Navigation				//
		/*------------------------------------------*/

		//
		//Events
		//

		private void ButtonNavigateSearch_Click(object sender, EventArgs e)
		{
			NavigationButton(ButtonNavigateConnections);
		}

		private void buttonNavigateDepartureBoard_Click(object sender, EventArgs e)
		{
			NavigationButton(buttonNavigateDepartureBoard);
		}

		private void buttonNavigationMaps_Click(object sender, EventArgs e)
		{
			NavigationButton(buttonNavigationMaps);
		}

		private void buttonNavigationNearMe_Click(object sender, EventArgs e)
		{
			NavigationButton(buttonNavigationNearMe);
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


		private void dateTimePickerDepartureDate_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				buttonSearchConnections_Click(this, null);
		}

		private void dateTimePickerDepartureTime_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				buttonSearchConnections_Click(this, null);
		}

		private void comboBoxSearchArrival_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				buttonSearchConnections_Click(this, null);
		}

		//Buttons

		private void buttonSearchChange_Click(object sender, EventArgs e)
		{
			string temp = comboBoxConnectionsArrival.Text;
			comboBoxConnectionsArrival.Text = comboBoxConnectionsDeparture.Text;
			comboBoxConnectionsDeparture.Text = temp;
		}

		private void buttonSearchConnections_Click(object sender, EventArgs e)
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
					DataGridViewFiller dataGridViewFiller = new DataGridViewFiller();
					dataGridViewFiller.FillDataGridConnections(connections, dataGridViewConnections);
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
			
			if (dataGridViewConnections.SelectedRows.Count != 0)
			{
				string message = "Verbindungen:%0D%0A";
				int i = 1;
				foreach (DataGridViewRow rows in dataGridViewConnections.SelectedRows)
				{
					message += "Verbindung " + i++ + ": ";
					foreach (DataGridViewCell cell in rows.Cells)
					{
						message += cell.OwningColumn.HeaderText + " = " + cell.Value + ", ";
					}

					message += "; %0D%0A";
				}

				Process.Start("mailto:username@domainname?subject=Verbindungen&body=" + message);

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

			
		}

		//Autocomplete

		private void comboBoxConnectionsDeparture_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up && e.KeyCode != Keys.Enter && e.KeyCode != Keys.Escape)
			{
				AutoCompletion autoCompletion = new AutoCompletion();
				var combobox = (ComboBox)sender;
				AutoCompletion.AddSugesstions(combobox);
			}
		}


		/*------------------------------------------*/
		//				Abfahrtstafel				//
		/*------------------------------------------*/

		//
		//Events
		//

		//Key Pressdown

		private void comboBoxDepartureBoardDeparture_KeyDown(object sender, KeyEventArgs e)
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

		//Autocomplete

		private void comboBoxDepartureBoardDeparture_TextChanged(object sender, EventArgs e)
		{
			AutoCompletion autoCompletion = new AutoCompletion();
			AutoCompletion.AddSugesstions(comboBoxDepartureBoardDeparture);
		}

		/*------------------------------------------*/
		//					Maps					//
		/*------------------------------------------*/

		//
		//Events
		//

		private void buttonShowMap_Click(object sender, EventArgs e)
		{
			StationHandler stationHandler = new StationHandler();
			if (stationHandler.StationExists(comboBoxMapsStation.Text))
			{
				gMapControlStation.MapProvider = GMapProviders.GoogleMap;
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

		//
		//Methoden
		//

		private void comboBoxMapsStation_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up && e.KeyCode != Keys.Enter && e.KeyCode != Keys.Escape)
			{
				AutoCompletion autoCompletion = new AutoCompletion();
				var combobox = (ComboBox)sender;
				AutoCompletion.AddSugesstions(combobox);
			}
		}


		private void comboBoxMapsStation_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				buttonShowMap_Click(this, null);
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
