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
			SearchConnection searchConnection = new SearchConnection();
			searchConnection.Show();
			this.Hide();
		}

		private void buttonNearMe_Click(object sender, EventArgs e)
		{

		}
	}
}
