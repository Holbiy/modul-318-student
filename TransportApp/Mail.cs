using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportApp
{
	class Mail
	{
		public string SelectedRowsToString(DataGridView dataGridView)
		{
			string message = "Verbindungen:%0D%0A";
			int i = 1;
			foreach (DataGridViewRow rows in dataGridView.SelectedRows)
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
			return message;
		}
	}
}
