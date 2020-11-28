
namespace TransportApp
{
	partial class DepartureBoardcs
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonHome = new System.Windows.Forms.Button();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.labelTitle = new System.Windows.Forms.Label();
			this.dataGridViewDepartureBoard = new System.Windows.Forms.DataGridView();
			this.columnDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnTransport = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanelLayout = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBoxInput = new System.Windows.Forms.GroupBox();
			this.buttonShowDepartureBoard = new System.Windows.Forms.Button();
			this.labelDeparture = new System.Windows.Forms.Label();
			this.comboBoxDeparture = new System.Windows.Forms.ComboBox();
			this.panelTitle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartureBoard)).BeginInit();
			this.tableLayoutPanelLayout.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBoxInput.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonHome
			// 
			this.buttonHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonHome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonHome.Location = new System.Drawing.Point(513, 19);
			this.buttonHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonHome.Name = "buttonHome";
			this.buttonHome.Size = new System.Drawing.Size(74, 26);
			this.buttonHome.TabIndex = 1;
			this.buttonHome.Text = "Home";
			this.buttonHome.UseVisualStyleBackColor = false;
			this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
			// 
			// panelTitle
			// 
			this.panelTitle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.panelTitle.Controls.Add(this.labelTitle);
			this.panelTitle.Controls.Add(this.buttonHome);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelTitle.Location = new System.Drawing.Point(0, 0);
			this.panelTitle.Margin = new System.Windows.Forms.Padding(0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(600, 56);
			this.panelTitle.TabIndex = 3;
			// 
			// labelTitle
			// 
			this.labelTitle.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(0, 0);
			this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(352, 56);
			this.labelTitle.TabIndex = 2;
			this.labelTitle.Text = "Abfahrtstafel";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridViewDepartureBoard
			// 
			this.dataGridViewDepartureBoard.AllowUserToAddRows = false;
			this.dataGridViewDepartureBoard.AllowUserToDeleteRows = false;
			this.dataGridViewDepartureBoard.AllowUserToResizeColumns = false;
			this.dataGridViewDepartureBoard.AllowUserToResizeRows = false;
			this.dataGridViewDepartureBoard.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewDepartureBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDepartureBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDeparture,
            this.columnArrival,
            this.columnTransport});
			this.dataGridViewDepartureBoard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewDepartureBoard.Location = new System.Drawing.Point(4, 190);
			this.dataGridViewDepartureBoard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridViewDepartureBoard.Name = "dataGridViewDepartureBoard";
			this.dataGridViewDepartureBoard.ReadOnly = true;
			this.dataGridViewDepartureBoard.RowTemplate.Height = 24;
			this.dataGridViewDepartureBoard.Size = new System.Drawing.Size(592, 172);
			this.dataGridViewDepartureBoard.TabIndex = 2;
			// 
			// columnDeparture
			// 
			this.columnDeparture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.columnDeparture.HeaderText = "Abfahrtsort";
			this.columnDeparture.Name = "columnDeparture";
			this.columnDeparture.ReadOnly = true;
			// 
			// columnArrival
			// 
			this.columnArrival.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.columnArrival.HeaderText = "Ankunftsort";
			this.columnArrival.Name = "columnArrival";
			this.columnArrival.ReadOnly = true;
			// 
			// columnTransport
			// 
			this.columnTransport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.columnTransport.HeaderText = "Verkehrsmittel";
			this.columnTransport.Name = "columnTransport";
			this.columnTransport.ReadOnly = true;
			// 
			// tableLayoutPanelLayout
			// 
			this.tableLayoutPanelLayout.ColumnCount = 1;
			this.tableLayoutPanelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelLayout.Controls.Add(this.tableLayoutPanel1, 0, 1);
			this.tableLayoutPanelLayout.Controls.Add(this.dataGridViewDepartureBoard, 0, 2);
			this.tableLayoutPanelLayout.Controls.Add(this.panelTitle, 0, 0);
			this.tableLayoutPanelLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelLayout.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelLayout.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanelLayout.Name = "tableLayoutPanelLayout";
			this.tableLayoutPanelLayout.RowCount = 3;
			this.tableLayoutPanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.55977F));
			this.tableLayoutPanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.67363F));
			this.tableLayoutPanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.7666F));
			this.tableLayoutPanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
			this.tableLayoutPanelLayout.Size = new System.Drawing.Size(600, 366);
			this.tableLayoutPanelLayout.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.tableLayoutPanel1.Controls.Add(this.groupBoxInput, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 58);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 126);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// groupBoxInput
			// 
			this.groupBoxInput.Controls.Add(this.comboBoxDeparture);
			this.groupBoxInput.Controls.Add(this.buttonShowDepartureBoard);
			this.groupBoxInput.Controls.Add(this.labelDeparture);
			this.groupBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxInput.Location = new System.Drawing.Point(11, 12);
			this.groupBoxInput.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
			this.groupBoxInput.Name = "groupBoxInput";
			this.groupBoxInput.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBoxInput.Size = new System.Drawing.Size(574, 102);
			this.groupBoxInput.TabIndex = 0;
			this.groupBoxInput.TabStop = false;
			this.groupBoxInput.Text = "Eingabe";
			// 
			// buttonShowDepartureBoard
			// 
			this.buttonShowDepartureBoard.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonShowDepartureBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonShowDepartureBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonShowDepartureBoard.Location = new System.Drawing.Point(7, 69);
			this.buttonShowDepartureBoard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonShowDepartureBoard.Name = "buttonShowDepartureBoard";
			this.buttonShowDepartureBoard.Size = new System.Drawing.Size(151, 34);
			this.buttonShowDepartureBoard.TabIndex = 3;
			this.buttonShowDepartureBoard.Text = "Tafel Anzeigen";
			this.buttonShowDepartureBoard.UseVisualStyleBackColor = false;
			this.buttonShowDepartureBoard.Click += new System.EventHandler(this.buttonShowDepartureBoard_Click);
			// 
			// labelDeparture
			// 
			this.labelDeparture.AutoSize = true;
			this.labelDeparture.Location = new System.Drawing.Point(4, 24);
			this.labelDeparture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelDeparture.Name = "labelDeparture";
			this.labelDeparture.Size = new System.Drawing.Size(58, 13);
			this.labelDeparture.TabIndex = 2;
			this.labelDeparture.Text = "Abfahrtsort";
			// 
			// comboBoxDeparture
			// 
			this.comboBoxDeparture.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.comboBoxDeparture.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBoxDeparture.FormattingEnabled = true;
			this.comboBoxDeparture.Location = new System.Drawing.Point(7, 41);
			this.comboBoxDeparture.Name = "comboBoxDeparture";
			this.comboBoxDeparture.Size = new System.Drawing.Size(150, 21);
			this.comboBoxDeparture.TabIndex = 4;
			this.comboBoxDeparture.TextChanged += new System.EventHandler(this.comboBoxDeparture_TextChanged);
			// 
			// DepartureBoardcs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 366);
			this.Controls.Add(this.tableLayoutPanelLayout);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "DepartureBoardcs";
			this.Text = "DepartureBoardcs";
			this.panelTitle.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartureBoard)).EndInit();
			this.tableLayoutPanelLayout.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBoxInput.ResumeLayout(false);
			this.groupBoxInput.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonHome;
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.DataGridView dataGridViewDepartureBoard;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLayout;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBoxInput;
		private System.Windows.Forms.Button buttonShowDepartureBoard;
		private System.Windows.Forms.Label labelDeparture;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnDeparture;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnArrival;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnTransport;
		private System.Windows.Forms.ComboBox comboBoxDeparture;
	}
}