using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using System.Device.Location;
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
		//					Main					//
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
		//			Search Connections				//
		/*------------------------------------------*/

		//
		//Events
		//

		//Key Pressdown

		private void comboBoxSearchDeparture_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				buttonSearchConnections_Click(this, null);
		}

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
			if (dataGridViewConnections.SelectedRows != null)
			{

				string mailBody = "<table width='100%' style='border:Solid 1px Black;'>";

				foreach (DataGridViewColumn column in dataGridViewConnections.Columns)
				{
					mailBody += "<th>";
					mailBody += column.HeaderText;
					mailBody += "<\th>";
				}

				foreach (DataGridViewRow rows in dataGridViewConnections.SelectedRows)
				{
					mailBody += "<tr>";
					foreach (DataGridViewCell cell in rows.Cells)
					{
						mailBody += "<td>";
						
						mailBody += cell.Value.ToString();
						mailBody += "<\td>";
					}
					mailBody += "<\tr>";
				}

				SmtpClient client = new SmtpClient("smtp.gmail.com");
				client.Port = 587;
				client.EnableSsl = true;
				client.DeliveryMethod = SmtpDeliveryMethod.Network;
				client.Credentials = new NetworkCredential("transportapplikation@gmail.com", "transport123");

				var mail = new MailMessage();
				mail.From = new MailAddress("transportapplikation@gmail.com");
				mail.To.Add("dario.hollbach@outlook.com");
				mail.Subject = "Nachricht";
				mail.Body = mailBody;
				mail.IsBodyHtml = true;
				client.Send(mail);
			}

			
		}

		//Autocomplete

		private void comboBoxSearchDeparture_TextChanged(object sender, EventArgs e)
		{
			AutoCompletion autoCompletion = new AutoCompletion();
			autoCompletion.AddSugesstions(comboBoxConnectionsDeparture);
		}

		private void comboBoxSearchArrival_TextChanged(object sender, EventArgs e)
		{
			AutoCompletion autoCompletion = new AutoCompletion();
			autoCompletion.AddSugesstions(comboBoxConnectionsArrival);
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

		


		private void comboBoxDepartureBoardDeparture_TextChanged(object sender, EventArgs e)
		{
			AutoCompletion autoCompletion = new AutoCompletion();
			autoCompletion.AddSugesstions(comboBoxDepartureBoardDeparture);
		}
		//
		//Karte Anzeigen
		//


		//Variabeln

		//Controls
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
				GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);

				//Overlay erzeugen
				GMapOverlay markers = new GMapOverlay("makers");

				//Alle markes zum Overlay hinzufügen
				
				markers.Markers.Add(marker);

				//Overlay covern
				gMapControlStation.Overlays.Clear();
				gMapControlStation.Overlays.Add(markers);
			}
			
		}

		//Methoden
		private void comboBoxMapsStation_TextChanged(object sender, EventArgs e)
		{
			AutoCompletion autoCompletion = new AutoCompletion();
			autoCompletion.AddSugesstions(comboBoxMapsStation);

		}


		private void comboBoxMapsStation_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				buttonShowMap_Click(this, null);
		}



		//
		//Near Me
		//

		//Controlls
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

		private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
		{

		}

		//Variablen
		GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

		











		//Methoden

	}
}
