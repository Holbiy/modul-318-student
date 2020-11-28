
namespace TransportApp
{
	partial class SearchConnection
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
			this.tableLayoutPanelLayout = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBoxInput = new System.Windows.Forms.GroupBox();
			this.comboBoxDeparture = new System.Windows.Forms.ComboBox();
			this.comboBoxArrival = new System.Windows.Forms.ComboBox();
			this.buttonChange = new System.Windows.Forms.Button();
			this.dateTimePickerDepartureTime = new System.Windows.Forms.DateTimePicker();
			this.labelDepartureTime = new System.Windows.Forms.Label();
			this.labelArrival = new System.Windows.Forms.Label();
			this.labelDeparture = new System.Windows.Forms.Label();
			this.panelButtons = new System.Windows.Forms.Panel();
			this.buttonSearchConnections = new System.Windows.Forms.Button();
			this.dataGridViewConnections = new System.Windows.Forms.DataGridView();
			this.columnDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnDeparturTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.labelTitle = new System.Windows.Forms.Label();
			this.buttonHome = new System.Windows.Forms.Button();
			this.tableLayoutPanelLayout.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBoxInput.SuspendLayout();
			this.panelButtons.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnections)).BeginInit();
			this.panelTitle.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanelLayout
			// 
			this.tableLayoutPanelLayout.ColumnCount = 1;
			this.tableLayoutPanelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelLayout.Controls.Add(this.tableLayoutPanel1, 0, 1);
			this.tableLayoutPanelLayout.Controls.Add(this.dataGridViewConnections, 0, 2);
			this.tableLayoutPanelLayout.Controls.Add(this.panelTitle, 0, 0);
			this.tableLayoutPanelLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelLayout.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelLayout.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanelLayout.Name = "tableLayoutPanelLayout";
			this.tableLayoutPanelLayout.RowCount = 3;
			this.tableLayoutPanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.55977F));
			this.tableLayoutPanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.67363F));
			this.tableLayoutPanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.7666F));
			this.tableLayoutPanelLayout.Size = new System.Drawing.Size(739, 428);
			this.tableLayoutPanelLayout.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.17978F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.82022F));
			this.tableLayoutPanel1.Controls.Add(this.groupBoxInput, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panelButtons, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 68);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(735, 148);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// groupBoxInput
			// 
			this.groupBoxInput.Controls.Add(this.comboBoxDeparture);
			this.groupBoxInput.Controls.Add(this.comboBoxArrival);
			this.groupBoxInput.Controls.Add(this.buttonChange);
			this.groupBoxInput.Controls.Add(this.dateTimePickerDepartureTime);
			this.groupBoxInput.Controls.Add(this.labelDepartureTime);
			this.groupBoxInput.Controls.Add(this.labelArrival);
			this.groupBoxInput.Controls.Add(this.labelDeparture);
			this.groupBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxInput.Location = new System.Drawing.Point(11, 12);
			this.groupBoxInput.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
			this.groupBoxInput.Name = "groupBoxInput";
			this.groupBoxInput.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxInput.Size = new System.Drawing.Size(390, 124);
			this.groupBoxInput.TabIndex = 0;
			this.groupBoxInput.TabStop = false;
			this.groupBoxInput.Text = "Eingabe";
			// 
			// comboBoxDeparture
			// 
			this.comboBoxDeparture.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.comboBoxDeparture.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBoxDeparture.FormattingEnabled = true;
			this.comboBoxDeparture.Location = new System.Drawing.Point(5, 40);
			this.comboBoxDeparture.MaxDropDownItems = 100;
			this.comboBoxDeparture.Name = "comboBoxDeparture";
			this.comboBoxDeparture.Size = new System.Drawing.Size(153, 21);
			this.comboBoxDeparture.TabIndex = 8;
			this.comboBoxDeparture.TextChanged += new System.EventHandler(this.comboBoxDeparture_TextChanged);
			// 
			// comboBoxArrival
			// 
			this.comboBoxArrival.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.comboBoxArrival.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBoxArrival.FormattingEnabled = true;
			this.comboBoxArrival.Location = new System.Drawing.Point(243, 40);
			this.comboBoxArrival.MaxDropDownItems = 100;
			this.comboBoxArrival.Name = "comboBoxArrival";
			this.comboBoxArrival.Size = new System.Drawing.Size(134, 21);
			this.comboBoxArrival.TabIndex = 7;
			this.comboBoxArrival.TextChanged += new System.EventHandler(this.comboBoxArrival_TextChanged);
			// 
			// buttonChange
			// 
			this.buttonChange.Image = global::TransportApp.Properties.Resources.arrows2;
			this.buttonChange.Location = new System.Drawing.Point(182, 32);
			this.buttonChange.Margin = new System.Windows.Forms.Padding(2);
			this.buttonChange.Name = "buttonChange";
			this.buttonChange.Size = new System.Drawing.Size(36, 34);
			this.buttonChange.TabIndex = 6;
			this.buttonChange.UseVisualStyleBackColor = true;
			this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
			// 
			// dateTimePickerDepartureTime
			// 
			this.dateTimePickerDepartureTime.Location = new System.Drawing.Point(7, 81);
			this.dateTimePickerDepartureTime.Margin = new System.Windows.Forms.Padding(2);
			this.dateTimePickerDepartureTime.Name = "dateTimePickerDepartureTime";
			this.dateTimePickerDepartureTime.Size = new System.Drawing.Size(151, 20);
			this.dateTimePickerDepartureTime.TabIndex = 5;
			// 
			// labelDepartureTime
			// 
			this.labelDepartureTime.AutoSize = true;
			this.labelDepartureTime.Location = new System.Drawing.Point(4, 66);
			this.labelDepartureTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelDepartureTime.Name = "labelDepartureTime";
			this.labelDepartureTime.Size = new System.Drawing.Size(62, 13);
			this.labelDepartureTime.TabIndex = 4;
			this.labelDepartureTime.Text = "Abfahrtszeit";
			// 
			// labelArrival
			// 
			this.labelArrival.AutoSize = true;
			this.labelArrival.Location = new System.Drawing.Point(240, 24);
			this.labelArrival.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelArrival.Name = "labelArrival";
			this.labelArrival.Size = new System.Drawing.Size(61, 13);
			this.labelArrival.TabIndex = 3;
			this.labelArrival.Text = "Ankunftsort";
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
			// panelButtons
			// 
			this.panelButtons.Controls.Add(this.buttonSearchConnections);
			this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelButtons.Location = new System.Drawing.Point(423, 12);
			this.panelButtons.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Size = new System.Drawing.Size(301, 124);
			this.panelButtons.TabIndex = 1;
			// 
			// buttonSearchConnections
			// 
			this.buttonSearchConnections.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonSearchConnections.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonSearchConnections.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonSearchConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSearchConnections.Location = new System.Drawing.Point(0, 90);
			this.buttonSearchConnections.Margin = new System.Windows.Forms.Padding(4);
			this.buttonSearchConnections.Name = "buttonSearchConnections";
			this.buttonSearchConnections.Size = new System.Drawing.Size(301, 34);
			this.buttonSearchConnections.TabIndex = 2;
			this.buttonSearchConnections.Text = "Verbindungen suchen";
			this.buttonSearchConnections.UseVisualStyleBackColor = false;
			this.buttonSearchConnections.Click += new System.EventHandler(this.buttonSearchConnections_Click);
			// 
			// dataGridViewConnections
			// 
			this.dataGridViewConnections.AllowUserToAddRows = false;
			this.dataGridViewConnections.AllowUserToDeleteRows = false;
			this.dataGridViewConnections.AllowUserToResizeColumns = false;
			this.dataGridViewConnections.AllowUserToResizeRows = false;
			this.dataGridViewConnections.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDeparture,
            this.columnArrival,
            this.columnPlatform,
            this.columnDatum,
            this.columnDeparturTime,
            this.columnArrivalTime,
            this.columnDuration});
			this.dataGridViewConnections.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewConnections.Location = new System.Drawing.Point(4, 222);
			this.dataGridViewConnections.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewConnections.Name = "dataGridViewConnections";
			this.dataGridViewConnections.ReadOnly = true;
			this.dataGridViewConnections.RowTemplate.Height = 24;
			this.dataGridViewConnections.Size = new System.Drawing.Size(731, 202);
			this.dataGridViewConnections.TabIndex = 2;
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
			// columnPlatform
			// 
			this.columnPlatform.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.columnPlatform.HeaderText = "Gleis";
			this.columnPlatform.Name = "columnPlatform";
			this.columnPlatform.ReadOnly = true;
			// 
			// columnDatum
			// 
			this.columnDatum.HeaderText = "Datum";
			this.columnDatum.Name = "columnDatum";
			this.columnDatum.ReadOnly = true;
			// 
			// columnDeparturTime
			// 
			this.columnDeparturTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.columnDeparturTime.HeaderText = "Abfahrtszeit";
			this.columnDeparturTime.Name = "columnDeparturTime";
			this.columnDeparturTime.ReadOnly = true;
			// 
			// columnArrivalTime
			// 
			this.columnArrivalTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.columnArrivalTime.HeaderText = "Ankunftszeit";
			this.columnArrivalTime.Name = "columnArrivalTime";
			this.columnArrivalTime.ReadOnly = true;
			// 
			// columnDuration
			// 
			this.columnDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.columnDuration.HeaderText = "Dauer";
			this.columnDuration.Name = "columnDuration";
			this.columnDuration.ReadOnly = true;
			// 
			// panelTitle
			// 
			this.panelTitle.BackColor = System.Drawing.SystemColors.Info;
			this.panelTitle.Controls.Add(this.labelTitle);
			this.panelTitle.Controls.Add(this.buttonHome);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelTitle.Location = new System.Drawing.Point(0, 0);
			this.panelTitle.Margin = new System.Windows.Forms.Padding(0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(739, 66);
			this.panelTitle.TabIndex = 3;
			// 
			// labelTitle
			// 
			this.labelTitle.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(0, 0);
			this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(352, 66);
			this.labelTitle.TabIndex = 2;
			this.labelTitle.Text = "Wo soll es hingehen?";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonHome
			// 
			this.buttonHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonHome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonHome.Location = new System.Drawing.Point(652, 19);
			this.buttonHome.Margin = new System.Windows.Forms.Padding(4);
			this.buttonHome.Name = "buttonHome";
			this.buttonHome.Size = new System.Drawing.Size(74, 26);
			this.buttonHome.TabIndex = 1;
			this.buttonHome.Text = "Home";
			this.buttonHome.UseVisualStyleBackColor = false;
			this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
			// 
			// SearchConnection
			// 
			this.AcceptButton = this.buttonSearchConnections;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(739, 428);
			this.Controls.Add(this.tableLayoutPanelLayout);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MinimumSize = new System.Drawing.Size(754, 414);
			this.Name = "SearchConnection";
			this.Text = "SearchConnection";
			this.tableLayoutPanelLayout.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBoxInput.ResumeLayout(false);
			this.groupBoxInput.PerformLayout();
			this.panelButtons.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnections)).EndInit();
			this.panelTitle.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLayout;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBoxInput;
		private System.Windows.Forms.DateTimePicker dateTimePickerDepartureTime;
		private System.Windows.Forms.Label labelDepartureTime;
		private System.Windows.Forms.Label labelArrival;
		private System.Windows.Forms.Label labelDeparture;
		private System.Windows.Forms.Panel panelButtons;
		private System.Windows.Forms.Button buttonSearchConnections;
		private System.Windows.Forms.DataGridView dataGridViewConnections;
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Button buttonHome;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnDeparture;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnArrival;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnPlatform;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnDatum;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnDeparturTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnArrivalTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnDuration;
		private System.Windows.Forms.Button buttonChange;
		private System.Windows.Forms.ComboBox comboBoxArrival;
		private System.Windows.Forms.ComboBox comboBoxDeparture;
	}
}