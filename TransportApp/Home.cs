using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportApp
{
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}

		private void labelTitle_Click(object sender, EventArgs e)
		{

		}

		private void buttonSearchConnections_Click(object sender, EventArgs e)
		{
			this.Hide();
			SearchConnection sistema = new SearchConnection();
			sistema.ShowDialog();
			this.Close();
		}

		private void buttonNearMe_Click(object sender, EventArgs e)
		{

		}

		private void buttonDepartureBoard_Click(object sender, EventArgs e)
		{
			this.Hide();
			DepartureBoardcs sistema = new DepartureBoardcs();
			sistema.ShowDialog();
			this.Close();
		}
	}
}
