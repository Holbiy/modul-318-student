
using System.Windows.Forms;

namespace TransportApp
{
	partial class main
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
			this.tableLayoutPanelConnections = new System.Windows.Forms.TableLayoutPanel();
			this.panelNavigation = new System.Windows.Forms.Panel();
			this.buttonNavigationMaps = new System.Windows.Forms.Button();
			this.buttonNavigationNearMe = new System.Windows.Forms.Button();
			this.buttonNavigateDepartureBoard = new System.Windows.Forms.Button();
			this.ButtonNavigateConnections = new System.Windows.Forms.Button();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.labelTitle = new System.Windows.Forms.Label();
			this.panelContent = new System.Windows.Forms.Panel();
			this.panelMaps = new System.Windows.Forms.Panel();
			this.tableLayoutPanelMaps = new System.Windows.Forms.TableLayoutPanel();
			this.groupBoxMapsInput = new System.Windows.Forms.GroupBox();
			this.comboBoxMapsStation = new System.Windows.Forms.ComboBox();
			this.buttonShowMap = new System.Windows.Forms.Button();
			this.labelStation = new System.Windows.Forms.Label();
			this.gMapControlStation = new GMap.NET.WindowsForms.GMapControl();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelNearMe = new System.Windows.Forms.Panel();
			this.tableLayoutPanelNearMe = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridViewNearMe = new System.Windows.Forms.DataGridView();
			this.ColumnStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonShowNearMe = new System.Windows.Forms.Button();
			this.panelDepartureBoard = new System.Windows.Forms.Panel();
			this.tableLayoutPanelDepartureboard = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBoxDepartureBoardInput = new System.Windows.Forms.GroupBox();
			this.comboBoxDepartureBoardDeparture = new System.Windows.Forms.ComboBox();
			this.buttonShowDepartureBoard = new System.Windows.Forms.Button();
			this.labelDepartureBoardDeparture = new System.Windows.Forms.Label();
			this.dataGridViewDepartureBoard = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnTransport = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelConnections = new System.Windows.Forms.Panel();
			this.tableLayoutPanelConnect = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanelConnection = new System.Windows.Forms.TableLayoutPanel();
			this.groupBoxConnections = new System.Windows.Forms.GroupBox();
			this.dateTimePickerDepartureTime = new System.Windows.Forms.DateTimePicker();
			this.buttonShowConnections = new System.Windows.Forms.Button();
			this.comboBoxConnectionsDeparture = new System.Windows.Forms.ComboBox();
			this.comboBoxConnectionsArrival = new System.Windows.Forms.ComboBox();
			this.buttonSwitch = new System.Windows.Forms.Button();
			this.dateTimePickerDepartureDate = new System.Windows.Forms.DateTimePicker();
			this.labelDepartureTime = new System.Windows.Forms.Label();
			this.labelArrival = new System.Windows.Forms.Label();
			this.labelDeparture = new System.Windows.Forms.Label();
			this.dataGridViewConnections = new System.Windows.Forms.DataGridView();
			this.columnDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnDeparturTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelMail = new System.Windows.Forms.Panel();
			this.labelMail = new System.Windows.Forms.Label();
			this.textBoxMail = new System.Windows.Forms.TextBox();
			this.buttonMail = new System.Windows.Forms.Button();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.panelLogoMargin = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanelConnections.SuspendLayout();
			this.panelNavigation.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.panelContent.SuspendLayout();
			this.panelMaps.SuspendLayout();
			this.tableLayoutPanelMaps.SuspendLayout();
			this.groupBoxMapsInput.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.panelNearMe.SuspendLayout();
			this.tableLayoutPanelNearMe.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewNearMe)).BeginInit();
			this.panelDepartureBoard.SuspendLayout();
			this.tableLayoutPanelDepartureboard.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.groupBoxDepartureBoardInput.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartureBoard)).BeginInit();
			this.panelConnections.SuspendLayout();
			this.tableLayoutPanelConnect.SuspendLayout();
			this.tableLayoutPanelConnection.SuspendLayout();
			this.groupBoxConnections.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnections)).BeginInit();
			this.panelMail.SuspendLayout();
			this.panelLogo.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanelConnections
			// 
			this.tableLayoutPanelConnections.ColumnCount = 2;
			this.tableLayoutPanelConnections.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelConnections.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.tableLayoutPanelConnections.Controls.Add(this.panelNavigation, 0, 1);
			this.tableLayoutPanelConnections.Controls.Add(this.panelTitle, 1, 0);
			this.tableLayoutPanelConnections.Controls.Add(this.panelContent, 1, 1);
			this.tableLayoutPanelConnections.Controls.Add(this.panelLogo, 0, 0);
			this.tableLayoutPanelConnections.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelConnections.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelConnections.Name = "tableLayoutPanelConnections";
			this.tableLayoutPanelConnections.RowCount = 2;
			this.tableLayoutPanelConnections.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.22222F));
			this.tableLayoutPanelConnections.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.77778F));
			this.tableLayoutPanelConnections.Size = new System.Drawing.Size(784, 553);
			this.tableLayoutPanelConnections.TabIndex = 0;
			// 
			// panelNavigation
			// 
			this.panelNavigation.BackColor = System.Drawing.Color.Gray;
			this.panelNavigation.Controls.Add(this.buttonNavigationMaps);
			this.panelNavigation.Controls.Add(this.buttonNavigationNearMe);
			this.panelNavigation.Controls.Add(this.buttonNavigateDepartureBoard);
			this.panelNavigation.Controls.Add(this.ButtonNavigateConnections);
			this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelNavigation.Location = new System.Drawing.Point(0, 100);
			this.panelNavigation.Margin = new System.Windows.Forms.Padding(0);
			this.panelNavigation.Name = "panelNavigation";
			this.panelNavigation.Size = new System.Drawing.Size(196, 453);
			this.panelNavigation.TabIndex = 0;
			// 
			// buttonNavigationMaps
			// 
			this.buttonNavigationMaps.BackColor = System.Drawing.Color.IndianRed;
			this.buttonNavigationMaps.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonNavigationMaps.FlatAppearance.BorderSize = 0;
			this.buttonNavigationMaps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonNavigationMaps.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNavigationMaps.Image = global::TransportApp.Properties.Resources.map;
			this.buttonNavigationMaps.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonNavigationMaps.Location = new System.Drawing.Point(0, 180);
			this.buttonNavigationMaps.Name = "buttonNavigationMaps";
			this.buttonNavigationMaps.Size = new System.Drawing.Size(196, 60);
			this.buttonNavigationMaps.TabIndex = 10;
			this.buttonNavigationMaps.Text = "Station auf Karte";
			this.buttonNavigationMaps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonNavigationMaps.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonNavigationMaps.UseVisualStyleBackColor = false;
			this.buttonNavigationMaps.Click += new System.EventHandler(this.ButtonNavigate_Click);
			// 
			// buttonNavigationNearMe
			// 
			this.buttonNavigationNearMe.BackColor = System.Drawing.Color.Coral;
			this.buttonNavigationNearMe.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonNavigationNearMe.FlatAppearance.BorderSize = 0;
			this.buttonNavigationNearMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonNavigationNearMe.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNavigationNearMe.Image = global::TransportApp.Properties.Resources.nearby;
			this.buttonNavigationNearMe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonNavigationNearMe.Location = new System.Drawing.Point(0, 120);
			this.buttonNavigationNearMe.Name = "buttonNavigationNearMe";
			this.buttonNavigationNearMe.Size = new System.Drawing.Size(196, 60);
			this.buttonNavigationNearMe.TabIndex = 9;
			this.buttonNavigationNearMe.Text = "Stationen in der Nähe";
			this.buttonNavigationNearMe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonNavigationNearMe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonNavigationNearMe.UseVisualStyleBackColor = false;
			this.buttonNavigationNearMe.Click += new System.EventHandler(this.ButtonNavigate_Click);
			// 
			// buttonNavigateDepartureBoard
			// 
			this.buttonNavigateDepartureBoard.BackColor = System.Drawing.Color.RoyalBlue;
			this.buttonNavigateDepartureBoard.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonNavigateDepartureBoard.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.buttonNavigateDepartureBoard.FlatAppearance.BorderSize = 0;
			this.buttonNavigateDepartureBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonNavigateDepartureBoard.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNavigateDepartureBoard.Image = global::TransportApp.Properties.Resources.table;
			this.buttonNavigateDepartureBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonNavigateDepartureBoard.Location = new System.Drawing.Point(0, 60);
			this.buttonNavigateDepartureBoard.Name = "buttonNavigateDepartureBoard";
			this.buttonNavigateDepartureBoard.Size = new System.Drawing.Size(196, 60);
			this.buttonNavigateDepartureBoard.TabIndex = 8;
			this.buttonNavigateDepartureBoard.Text = "Abfahrtstafel";
			this.buttonNavigateDepartureBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonNavigateDepartureBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonNavigateDepartureBoard.UseVisualStyleBackColor = false;
			this.buttonNavigateDepartureBoard.Click += new System.EventHandler(this.ButtonNavigate_Click);
			// 
			// ButtonNavigateConnections
			// 
			this.ButtonNavigateConnections.BackColor = System.Drawing.Color.OliveDrab;
			this.ButtonNavigateConnections.Dock = System.Windows.Forms.DockStyle.Top;
			this.ButtonNavigateConnections.FlatAppearance.BorderSize = 0;
			this.ButtonNavigateConnections.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonNavigateConnections.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonNavigateConnections.Image = global::TransportApp.Properties.Resources.train;
			this.ButtonNavigateConnections.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonNavigateConnections.Location = new System.Drawing.Point(0, 0);
			this.ButtonNavigateConnections.Name = "ButtonNavigateConnections";
			this.ButtonNavigateConnections.Size = new System.Drawing.Size(196, 60);
			this.ButtonNavigateConnections.TabIndex = 7;
			this.ButtonNavigateConnections.Text = "Verbindungen suchen";
			this.ButtonNavigateConnections.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonNavigateConnections.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ButtonNavigateConnections.UseVisualStyleBackColor = false;
			this.ButtonNavigateConnections.Click += new System.EventHandler(this.ButtonNavigate_Click);
			// 
			// panelTitle
			// 
			this.panelTitle.BackColor = System.Drawing.Color.OliveDrab;
			this.panelTitle.Controls.Add(this.labelTitle);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelTitle.Location = new System.Drawing.Point(196, 0);
			this.panelTitle.Margin = new System.Windows.Forms.Padding(0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(588, 100);
			this.panelTitle.TabIndex = 1;
			// 
			// labelTitle
			// 
			this.labelTitle.BackColor = System.Drawing.Color.Aqua;
			this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTitle.Font = new System.Drawing.Font("Gadugi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(0, 0);
			this.labelTitle.Margin = new System.Windows.Forms.Padding(0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(588, 100);
			this.labelTitle.TabIndex = 2;
			this.labelTitle.Text = "Titel";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelContent
			// 
			this.panelContent.Controls.Add(this.panelDepartureBoard);
			this.panelContent.Controls.Add(this.panelConnections);
			this.panelContent.Controls.Add(this.panelMaps);
			this.panelContent.Controls.Add(this.panelNearMe);
			
			
			this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContent.Location = new System.Drawing.Point(199, 103);
			this.panelContent.Name = "panelContent";
			this.panelContent.Size = new System.Drawing.Size(582, 447);
			this.panelContent.TabIndex = 2;
			// 
			// panelMaps
			// 
			this.panelMaps.Controls.Add(this.tableLayoutPanelMaps);
			this.panelMaps.Controls.Add(this.dataGridView2);
			this.panelMaps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMaps.Location = new System.Drawing.Point(0, 0);
			this.panelMaps.Name = "panelMaps";
			this.panelMaps.Size = new System.Drawing.Size(582, 447);
			this.panelMaps.TabIndex = 0;
			// 
			// tableLayoutPanelMaps
			// 
			this.tableLayoutPanelMaps.ColumnCount = 1;
			this.tableLayoutPanelMaps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelMaps.Controls.Add(this.groupBoxMapsInput, 0, 0);
			this.tableLayoutPanelMaps.Controls.Add(this.gMapControlStation, 0, 1);
			this.tableLayoutPanelMaps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMaps.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelMaps.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanelMaps.Name = "tableLayoutPanelMaps";
			this.tableLayoutPanelMaps.RowCount = 2;
			this.tableLayoutPanelMaps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.78076F));
			this.tableLayoutPanelMaps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.21924F));
			this.tableLayoutPanelMaps.Size = new System.Drawing.Size(582, 447);
			this.tableLayoutPanelMaps.TabIndex = 3;
			// 
			// groupBoxMapsInput
			// 
			this.groupBoxMapsInput.Controls.Add(this.comboBoxMapsStation);
			this.groupBoxMapsInput.Controls.Add(this.buttonShowMap);
			this.groupBoxMapsInput.Controls.Add(this.labelStation);
			this.groupBoxMapsInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxMapsInput.Location = new System.Drawing.Point(11, 13);
			this.groupBoxMapsInput.Margin = new System.Windows.Forms.Padding(11, 13, 11, 13);
			this.groupBoxMapsInput.Name = "groupBoxMapsInput";
			this.groupBoxMapsInput.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxMapsInput.Size = new System.Drawing.Size(560, 125);
			this.groupBoxMapsInput.TabIndex = 0;
			this.groupBoxMapsInput.TabStop = false;
			this.groupBoxMapsInput.Text = "Eingabe";
			// 
			// comboBoxMapsStation
			// 
			this.comboBoxMapsStation.FormattingEnabled = true;
			this.comboBoxMapsStation.Location = new System.Drawing.Point(8, 46);
			this.comboBoxMapsStation.Name = "comboBoxMapsStation";
			this.comboBoxMapsStation.Size = new System.Drawing.Size(150, 22);
			this.comboBoxMapsStation.TabIndex = 0;
			this.comboBoxMapsStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxEnterMaps_KeyDown);
			this.comboBoxMapsStation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxAutocomplete_KeyUp);
			// 
			// buttonShowMap
			// 
			this.buttonShowMap.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonShowMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonShowMap.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonShowMap.Location = new System.Drawing.Point(7, 74);
			this.buttonShowMap.Margin = new System.Windows.Forms.Padding(4);
			this.buttonShowMap.Name = "buttonShowMap";
			this.buttonShowMap.Size = new System.Drawing.Size(151, 37);
			this.buttonShowMap.TabIndex = 1;
			this.buttonShowMap.Text = "Karte anzeigen";
			this.buttonShowMap.UseVisualStyleBackColor = false;
			this.buttonShowMap.Click += new System.EventHandler(this.buttonShowMap_Click);
			// 
			// labelStation
			// 
			this.labelStation.AutoSize = true;
			this.labelStation.Location = new System.Drawing.Point(4, 26);
			this.labelStation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelStation.Name = "labelStation";
			this.labelStation.Size = new System.Drawing.Size(44, 14);
			this.labelStation.TabIndex = 2;
			this.labelStation.Text = "Station";
			// 
			// gMapControlStation
			// 
			this.gMapControlStation.Bearing = 0F;
			this.gMapControlStation.CanDragMap = true;
			this.gMapControlStation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gMapControlStation.EmptyTileColor = System.Drawing.Color.Navy;
			this.gMapControlStation.GrayScaleMode = false;
			this.gMapControlStation.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
			this.gMapControlStation.LevelsKeepInMemmory = 5;
			this.gMapControlStation.Location = new System.Drawing.Point(3, 154);
			this.gMapControlStation.MarkersEnabled = true;
			this.gMapControlStation.MaxZoom = 17;
			this.gMapControlStation.MinZoom = 15;
			this.gMapControlStation.MouseWheelZoomEnabled = true;
			this.gMapControlStation.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
			this.gMapControlStation.Name = "gMapControlStation";
			this.gMapControlStation.NegativeMode = false;
			this.gMapControlStation.PolygonsEnabled = true;
			this.gMapControlStation.RetryLoadTile = 0;
			this.gMapControlStation.RoutesEnabled = true;
			this.gMapControlStation.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
			this.gMapControlStation.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
			this.gMapControlStation.ShowTileGridLines = false;
			this.gMapControlStation.Size = new System.Drawing.Size(576, 290);
			this.gMapControlStation.TabIndex = 1;
			this.gMapControlStation.Visible = false;
			this.gMapControlStation.Zoom = 16D;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AllowUserToResizeColumns = false;
			this.dataGridView2.AllowUserToResizeRows = false;
			this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(0, 0);
			this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 24;
			this.dataGridView2.Size = new System.Drawing.Size(582, 447);
			this.dataGridView2.TabIndex = 4;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.HeaderText = "Abfahrtsort";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.HeaderText = "Ankunftsort";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn5.HeaderText = "Verkehrsmittel";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// panelNearMe
			// 
			this.panelNearMe.Controls.Add(this.tableLayoutPanelNearMe);
			this.panelNearMe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelNearMe.Location = new System.Drawing.Point(0, 0);
			this.panelNearMe.Name = "panelNearMe";
			this.panelNearMe.Size = new System.Drawing.Size(582, 447);
			this.panelNearMe.TabIndex = 0;
			// 
			// tableLayoutPanelNearMe
			// 
			this.tableLayoutPanelNearMe.ColumnCount = 1;
			this.tableLayoutPanelNearMe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelNearMe.Controls.Add(this.dataGridViewNearMe, 0, 1);
			this.tableLayoutPanelNearMe.Controls.Add(this.buttonShowNearMe, 0, 0);
			this.tableLayoutPanelNearMe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelNearMe.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelNearMe.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanelNearMe.Name = "tableLayoutPanelNearMe";
			this.tableLayoutPanelNearMe.RowCount = 2;
			this.tableLayoutPanelNearMe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanelNearMe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
			this.tableLayoutPanelNearMe.Size = new System.Drawing.Size(582, 447);
			this.tableLayoutPanelNearMe.TabIndex = 2;
			// 
			// dataGridViewNearMe
			// 
			this.dataGridViewNearMe.AllowUserToAddRows = false;
			this.dataGridViewNearMe.AllowUserToDeleteRows = false;
			this.dataGridViewNearMe.AllowUserToResizeColumns = false;
			this.dataGridViewNearMe.AllowUserToResizeRows = false;
			this.dataGridViewNearMe.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewNearMe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewNearMe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnStation,
            this.ColumnDistance});
			this.dataGridViewNearMe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewNearMe.Location = new System.Drawing.Point(4, 48);
			this.dataGridViewNearMe.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewNearMe.Name = "dataGridViewNearMe";
			this.dataGridViewNearMe.ReadOnly = true;
			this.dataGridViewNearMe.RowHeadersWidth = 51;
			this.dataGridViewNearMe.RowTemplate.Height = 24;
			this.dataGridViewNearMe.Size = new System.Drawing.Size(574, 395);
			this.dataGridViewNearMe.TabIndex = 2;
			// 
			// ColumnStation
			// 
			this.ColumnStation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ColumnStation.HeaderText = "Station";
			this.ColumnStation.MinimumWidth = 6;
			this.ColumnStation.Name = "ColumnStation";
			this.ColumnStation.ReadOnly = true;
			// 
			// ColumnDistance
			// 
			this.ColumnDistance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ColumnDistance.HeaderText = "Entfernung";
			this.ColumnDistance.MinimumWidth = 6;
			this.ColumnDistance.Name = "ColumnDistance";
			this.ColumnDistance.ReadOnly = true;
			// 
			// buttonShowNearMe
			// 
			this.buttonShowNearMe.Location = new System.Drawing.Point(3, 3);
			this.buttonShowNearMe.Name = "buttonShowNearMe";
			this.buttonShowNearMe.Size = new System.Drawing.Size(190, 33);
			this.buttonShowNearMe.TabIndex = 0;
			this.buttonShowNearMe.Text = "Stationen in der Nähe anzeigen";
			this.buttonShowNearMe.UseVisualStyleBackColor = true;
			this.buttonShowNearMe.Click += new System.EventHandler(this.buttonShowNearMe_Click);
			// 
			// panelDepartureBoard
			// 
			this.panelDepartureBoard.Controls.Add(this.tableLayoutPanelDepartureboard);
			this.panelDepartureBoard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDepartureBoard.Location = new System.Drawing.Point(0, 0);
			this.panelDepartureBoard.Name = "panelDepartureBoard";
			this.panelDepartureBoard.Size = new System.Drawing.Size(582, 447);
			this.panelDepartureBoard.TabIndex = 2;
			// 
			// tableLayoutPanelDepartureboard
			// 
			this.tableLayoutPanelDepartureboard.ColumnCount = 1;
			this.tableLayoutPanelDepartureboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelDepartureboard.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.tableLayoutPanelDepartureboard.Controls.Add(this.dataGridViewDepartureBoard, 0, 1);
			this.tableLayoutPanelDepartureboard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelDepartureboard.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelDepartureboard.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanelDepartureboard.Name = "tableLayoutPanelDepartureboard";
			this.tableLayoutPanelDepartureboard.RowCount = 2;
			this.tableLayoutPanelDepartureboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.2472F));
			this.tableLayoutPanelDepartureboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.7528F));
			this.tableLayoutPanelDepartureboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
			this.tableLayoutPanelDepartureboard.Size = new System.Drawing.Size(582, 447);
			this.tableLayoutPanelDepartureboard.TabIndex = 2;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.tableLayoutPanel3.Controls.Add(this.groupBoxDepartureBoardInput, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(578, 184);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// groupBoxDepartureBoardInput
			// 
			this.groupBoxDepartureBoardInput.Controls.Add(this.comboBoxDepartureBoardDeparture);
			this.groupBoxDepartureBoardInput.Controls.Add(this.buttonShowDepartureBoard);
			this.groupBoxDepartureBoardInput.Controls.Add(this.labelDepartureBoardDeparture);
			this.groupBoxDepartureBoardInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxDepartureBoardInput.Location = new System.Drawing.Point(11, 13);
			this.groupBoxDepartureBoardInput.Margin = new System.Windows.Forms.Padding(11, 13, 11, 13);
			this.groupBoxDepartureBoardInput.Name = "groupBoxDepartureBoardInput";
			this.groupBoxDepartureBoardInput.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxDepartureBoardInput.Size = new System.Drawing.Size(556, 158);
			this.groupBoxDepartureBoardInput.TabIndex = 0;
			this.groupBoxDepartureBoardInput.TabStop = false;
			this.groupBoxDepartureBoardInput.Text = "Eingabe";
			// 
			// comboBoxDepartureBoardDeparture
			// 
			this.comboBoxDepartureBoardDeparture.FormattingEnabled = true;
			this.comboBoxDepartureBoardDeparture.Location = new System.Drawing.Point(7, 44);
			this.comboBoxDepartureBoardDeparture.Name = "comboBoxDepartureBoardDeparture";
			this.comboBoxDepartureBoardDeparture.Size = new System.Drawing.Size(150, 22);
			this.comboBoxDepartureBoardDeparture.TabIndex = 0;
			this.comboBoxDepartureBoardDeparture.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxEnterDepartureTable_KeyDown);
			this.comboBoxDepartureBoardDeparture.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxAutocomplete_KeyUp);
			// 
			// buttonShowDepartureBoard
			// 
			this.buttonShowDepartureBoard.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonShowDepartureBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonShowDepartureBoard.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonShowDepartureBoard.Location = new System.Drawing.Point(7, 74);
			this.buttonShowDepartureBoard.Margin = new System.Windows.Forms.Padding(4);
			this.buttonShowDepartureBoard.Name = "buttonShowDepartureBoard";
			this.buttonShowDepartureBoard.Size = new System.Drawing.Size(151, 37);
			this.buttonShowDepartureBoard.TabIndex = 1;
			this.buttonShowDepartureBoard.Text = "Tafel Anzeigen";
			this.buttonShowDepartureBoard.UseVisualStyleBackColor = false;
			this.buttonShowDepartureBoard.Click += new System.EventHandler(this.buttonShowDepartureBoard_Click);
			// 
			// labelDepartureBoardDeparture
			// 
			this.labelDepartureBoardDeparture.AutoSize = true;
			this.labelDepartureBoardDeparture.Location = new System.Drawing.Point(4, 26);
			this.labelDepartureBoardDeparture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelDepartureBoardDeparture.Name = "labelDepartureBoardDeparture";
			this.labelDepartureBoardDeparture.Size = new System.Drawing.Size(66, 14);
			this.labelDepartureBoardDeparture.TabIndex = 2;
			this.labelDepartureBoardDeparture.Text = "Abfahrtsort";
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
            this.dataGridViewTextBoxColumn2,
            this.columnTransport});
			this.dataGridViewDepartureBoard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewDepartureBoard.Location = new System.Drawing.Point(4, 192);
			this.dataGridViewDepartureBoard.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewDepartureBoard.Name = "dataGridViewDepartureBoard";
			this.dataGridViewDepartureBoard.ReadOnly = true;
			this.dataGridViewDepartureBoard.RowHeadersWidth = 51;
			this.dataGridViewDepartureBoard.RowTemplate.Height = 24;
			this.dataGridViewDepartureBoard.Size = new System.Drawing.Size(574, 251);
			this.dataGridViewDepartureBoard.TabIndex = 2;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.HeaderText = "Ankunftsort";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// columnTransport
			// 
			this.columnTransport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.columnTransport.HeaderText = "Verkehrsmittel";
			this.columnTransport.MinimumWidth = 6;
			this.columnTransport.Name = "columnTransport";
			this.columnTransport.ReadOnly = true;
			// 
			// panelConnections
			// 
			this.panelConnections.Controls.Add(this.tableLayoutPanelConnect);
			this.panelConnections.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelConnections.Location = new System.Drawing.Point(0, 0);
			this.panelConnections.Name = "panelConnections";
			this.panelConnections.Size = new System.Drawing.Size(582, 447);
			this.panelConnections.TabIndex = 1;
			// 
			// tableLayoutPanelConnect
			// 
			this.tableLayoutPanelConnect.ColumnCount = 1;
			this.tableLayoutPanelConnect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelConnect.Controls.Add(this.tableLayoutPanelConnection, 0, 0);
			this.tableLayoutPanelConnect.Controls.Add(this.dataGridViewConnections, 0, 1);
			this.tableLayoutPanelConnect.Controls.Add(this.panelMail, 0, 2);
			this.tableLayoutPanelConnect.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelConnect.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelConnect.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanelConnect.Name = "tableLayoutPanelConnect";
			this.tableLayoutPanelConnect.RowCount = 3;
			this.tableLayoutPanelConnect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.06545F));
			this.tableLayoutPanelConnect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.66924F));
			this.tableLayoutPanelConnect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.26531F));
			this.tableLayoutPanelConnect.Size = new System.Drawing.Size(582, 447);
			this.tableLayoutPanelConnect.TabIndex = 1;
			// 
			// tableLayoutPanelConnection
			// 
			this.tableLayoutPanelConnection.ColumnCount = 1;
			this.tableLayoutPanelConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelConnection.Controls.Add(this.groupBoxConnections, 0, 0);
			this.tableLayoutPanelConnection.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelConnection.Location = new System.Drawing.Point(2, 2);
			this.tableLayoutPanelConnection.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanelConnection.Name = "tableLayoutPanelConnection";
			this.tableLayoutPanelConnection.RowCount = 1;
			this.tableLayoutPanelConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelConnection.Size = new System.Drawing.Size(578, 161);
			this.tableLayoutPanelConnection.TabIndex = 1;
			// 
			// groupBoxConnections
			// 
			this.groupBoxConnections.Controls.Add(this.dateTimePickerDepartureTime);
			this.groupBoxConnections.Controls.Add(this.buttonShowConnections);
			this.groupBoxConnections.Controls.Add(this.comboBoxConnectionsDeparture);
			this.groupBoxConnections.Controls.Add(this.comboBoxConnectionsArrival);
			this.groupBoxConnections.Controls.Add(this.buttonSwitch);
			this.groupBoxConnections.Controls.Add(this.dateTimePickerDepartureDate);
			this.groupBoxConnections.Controls.Add(this.labelDepartureTime);
			this.groupBoxConnections.Controls.Add(this.labelArrival);
			this.groupBoxConnections.Controls.Add(this.labelDeparture);
			this.groupBoxConnections.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxConnections.Location = new System.Drawing.Point(11, 13);
			this.groupBoxConnections.Margin = new System.Windows.Forms.Padding(11, 13, 11, 13);
			this.groupBoxConnections.Name = "groupBoxConnections";
			this.groupBoxConnections.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxConnections.Size = new System.Drawing.Size(556, 135);
			this.groupBoxConnections.TabIndex = 0;
			this.groupBoxConnections.TabStop = false;
			this.groupBoxConnections.Text = "Eingabe";
			// 
			// dateTimePickerDepartureTime
			// 
			this.dateTimePickerDepartureTime.CustomFormat = "HH:mm";
			this.dateTimePickerDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerDepartureTime.Location = new System.Drawing.Point(199, 87);
			this.dateTimePickerDepartureTime.Margin = new System.Windows.Forms.Padding(2);
			this.dateTimePickerDepartureTime.Name = "dateTimePickerDepartureTime";
			this.dateTimePickerDepartureTime.ShowUpDown = true;
			this.dateTimePickerDepartureTime.Size = new System.Drawing.Size(54, 22);
			this.dateTimePickerDepartureTime.TabIndex = 3;
			this.dateTimePickerDepartureTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxEnterConnections_KeyDown);
			// 
			// buttonShowConnections
			// 
			this.buttonShowConnections.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.buttonShowConnections.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonShowConnections.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonShowConnections.Location = new System.Drawing.Point(361, 85);
			this.buttonShowConnections.Margin = new System.Windows.Forms.Padding(4);
			this.buttonShowConnections.Name = "buttonShowConnections";
			this.buttonShowConnections.Size = new System.Drawing.Size(190, 37);
			this.buttonShowConnections.TabIndex = 5;
			this.buttonShowConnections.Text = "Verbindungen suchen";
			this.buttonShowConnections.UseVisualStyleBackColor = false;
			this.buttonShowConnections.Click += new System.EventHandler(this.buttonConnections_Click);
			// 
			// comboBoxConnectionsDeparture
			// 
			this.comboBoxConnectionsDeparture.FormattingEnabled = true;
			this.comboBoxConnectionsDeparture.Location = new System.Drawing.Point(5, 44);
			this.comboBoxConnectionsDeparture.MaxDropDownItems = 10;
			this.comboBoxConnectionsDeparture.Name = "comboBoxConnectionsDeparture";
			this.comboBoxConnectionsDeparture.Size = new System.Drawing.Size(190, 22);
			this.comboBoxConnectionsDeparture.TabIndex = 0;
			this.comboBoxConnectionsDeparture.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxEnterConnections_KeyDown);
			this.comboBoxConnectionsDeparture.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxAutocomplete_KeyUp);
			// 
			// comboBoxConnectionsArrival
			// 
			this.comboBoxConnectionsArrival.FormattingEnabled = true;
			this.comboBoxConnectionsArrival.Location = new System.Drawing.Point(361, 44);
			this.comboBoxConnectionsArrival.MaxDropDownItems = 100;
			this.comboBoxConnectionsArrival.Name = "comboBoxConnectionsArrival";
			this.comboBoxConnectionsArrival.Size = new System.Drawing.Size(190, 22);
			this.comboBoxConnectionsArrival.TabIndex = 1;
			this.comboBoxConnectionsArrival.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxEnterConnections_KeyDown);
			this.comboBoxConnectionsArrival.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxAutocomplete_KeyUp);
			// 
			// buttonSwitch
			// 
			this.buttonSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonSwitch.Image = global::TransportApp.Properties.Resources.arrows4;
			this.buttonSwitch.Location = new System.Drawing.Point(237, 36);
			this.buttonSwitch.Margin = new System.Windows.Forms.Padding(2);
			this.buttonSwitch.Name = "buttonSwitch";
			this.buttonSwitch.Size = new System.Drawing.Size(87, 37);
			this.buttonSwitch.TabIndex = 4;
			this.buttonSwitch.UseVisualStyleBackColor = true;
			this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
			// 
			// dateTimePickerDepartureDate
			// 
			this.dateTimePickerDepartureDate.Location = new System.Drawing.Point(5, 87);
			this.dateTimePickerDepartureDate.Margin = new System.Windows.Forms.Padding(2);
			this.dateTimePickerDepartureDate.Name = "dateTimePickerDepartureDate";
			this.dateTimePickerDepartureDate.Size = new System.Drawing.Size(190, 22);
			this.dateTimePickerDepartureDate.TabIndex = 2;
			this.dateTimePickerDepartureDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxEnterConnections_KeyDown);
			// 
			// labelDepartureTime
			// 
			this.labelDepartureTime.AutoSize = true;
			this.labelDepartureTime.Location = new System.Drawing.Point(4, 71);
			this.labelDepartureTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelDepartureTime.Name = "labelDepartureTime";
			this.labelDepartureTime.Size = new System.Drawing.Size(69, 14);
			this.labelDepartureTime.TabIndex = 4;
			this.labelDepartureTime.Text = "Abfahrtszeit";
			// 
			// labelArrival
			// 
			this.labelArrival.AutoSize = true;
			this.labelArrival.Location = new System.Drawing.Point(358, 24);
			this.labelArrival.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelArrival.Name = "labelArrival";
			this.labelArrival.Size = new System.Drawing.Size(69, 14);
			this.labelArrival.TabIndex = 3;
			this.labelArrival.Text = "Ankunftsort";
			// 
			// labelDeparture
			// 
			this.labelDeparture.AutoSize = true;
			this.labelDeparture.Location = new System.Drawing.Point(4, 26);
			this.labelDeparture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelDeparture.Name = "labelDeparture";
			this.labelDeparture.Size = new System.Drawing.Size(66, 14);
			this.labelDeparture.TabIndex = 2;
			this.labelDeparture.Text = "Abfahrtsort";
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
			this.dataGridViewConnections.Location = new System.Drawing.Point(4, 169);
			this.dataGridViewConnections.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewConnections.Name = "dataGridViewConnections";
			this.dataGridViewConnections.ReadOnly = true;
			this.dataGridViewConnections.RowHeadersWidth = 51;
			this.dataGridViewConnections.RowTemplate.Height = 24;
			this.dataGridViewConnections.Size = new System.Drawing.Size(574, 218);
			this.dataGridViewConnections.TabIndex = 2;
			// 
			// columnDeparture
			// 
			this.columnDeparture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.columnDeparture.HeaderText = "Abfahrtsort";
			this.columnDeparture.MinimumWidth = 6;
			this.columnDeparture.Name = "columnDeparture";
			this.columnDeparture.ReadOnly = true;
			this.columnDeparture.Width = 91;
			// 
			// columnArrival
			// 
			this.columnArrival.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.columnArrival.HeaderText = "Ankunftsort";
			this.columnArrival.MinimumWidth = 6;
			this.columnArrival.Name = "columnArrival";
			this.columnArrival.ReadOnly = true;
			this.columnArrival.Width = 94;
			// 
			// columnPlatform
			// 
			this.columnPlatform.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.columnPlatform.HeaderText = "Gleis";
			this.columnPlatform.MinimumWidth = 6;
			this.columnPlatform.Name = "columnPlatform";
			this.columnPlatform.ReadOnly = true;
			this.columnPlatform.Width = 57;
			// 
			// columnDatum
			// 
			this.columnDatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.columnDatum.HeaderText = "Datum";
			this.columnDatum.MinimumWidth = 6;
			this.columnDatum.Name = "columnDatum";
			this.columnDatum.ReadOnly = true;
			this.columnDatum.Width = 66;
			// 
			// columnDeparturTime
			// 
			this.columnDeparturTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.columnDeparturTime.HeaderText = "Abfahrtszeit";
			this.columnDeparturTime.MinimumWidth = 6;
			this.columnDeparturTime.Name = "columnDeparturTime";
			this.columnDeparturTime.ReadOnly = true;
			// 
			// columnArrivalTime
			// 
			this.columnArrivalTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.columnArrivalTime.HeaderText = "Ankunftszeit";
			this.columnArrivalTime.MinimumWidth = 6;
			this.columnArrivalTime.Name = "columnArrivalTime";
			this.columnArrivalTime.ReadOnly = true;
			// 
			// columnDuration
			// 
			this.columnDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.columnDuration.HeaderText = "Dauer";
			this.columnDuration.MinimumWidth = 6;
			this.columnDuration.Name = "columnDuration";
			this.columnDuration.ReadOnly = true;
			// 
			// panelMail
			// 
			this.panelMail.Controls.Add(this.labelMail);
			this.panelMail.Controls.Add(this.textBoxMail);
			this.panelMail.Controls.Add(this.buttonMail);
			this.panelMail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMail.Location = new System.Drawing.Point(3, 394);
			this.panelMail.Name = "panelMail";
			this.panelMail.Size = new System.Drawing.Size(576, 50);
			this.panelMail.TabIndex = 3;
			// 
			// labelMail
			// 
			this.labelMail.AutoSize = true;
			this.labelMail.Location = new System.Drawing.Point(12, 5);
			this.labelMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelMail.Name = "labelMail";
			this.labelMail.Size = new System.Drawing.Size(39, 14);
			this.labelMail.TabIndex = 9;
			this.labelMail.Text = "E-Mail";
			// 
			// textBoxMail
			// 
			this.textBoxMail.Location = new System.Drawing.Point(15, 22);
			this.textBoxMail.Name = "textBoxMail";
			this.textBoxMail.Size = new System.Drawing.Size(259, 22);
			this.textBoxMail.TabIndex = 7;
			this.textBoxMail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEnterMail_KeyDown);
			// 
			// buttonMail
			// 
			this.buttonMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMail.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMail.Location = new System.Drawing.Point(280, 22);
			this.buttonMail.Name = "buttonMail";
			this.buttonMail.Size = new System.Drawing.Size(293, 22);
			this.buttonMail.TabIndex = 8;
			this.buttonMail.Text = "Markierte Verbindungen als Mail verschiken";
			this.buttonMail.UseVisualStyleBackColor = true;
			this.buttonMail.Click += new System.EventHandler(this.buttonMail_Click);
			// 
			// panelLogo
			// 
			this.panelLogo.BackColor = System.Drawing.Color.Gray;
			this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panelLogo.Controls.Add(this.panelLogoMargin);
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Margin = new System.Windows.Forms.Padding(0);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
			this.panelLogo.Size = new System.Drawing.Size(196, 100);
			this.panelLogo.TabIndex = 3;
			// 
			// panelLogoMargin
			// 
			this.panelLogoMargin.BackgroundImage = global::TransportApp.Properties.Resources.logo;
			this.panelLogoMargin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panelLogoMargin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelLogoMargin.Location = new System.Drawing.Point(10, 11);
			this.panelLogoMargin.Name = "panelLogoMargin";
			this.panelLogoMargin.Size = new System.Drawing.Size(176, 78);
			this.panelLogoMargin.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(381, 552);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(8, 8);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 553);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tableLayoutPanelConnections);
			this.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "main";
			this.Text = "main";
			this.tableLayoutPanelConnections.ResumeLayout(false);
			this.panelNavigation.ResumeLayout(false);
			this.panelTitle.ResumeLayout(false);
			this.panelContent.ResumeLayout(false);
			this.panelMaps.ResumeLayout(false);
			this.tableLayoutPanelMaps.ResumeLayout(false);
			this.groupBoxMapsInput.ResumeLayout(false);
			this.groupBoxMapsInput.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.panelNearMe.ResumeLayout(false);
			this.tableLayoutPanelNearMe.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewNearMe)).EndInit();
			this.panelDepartureBoard.ResumeLayout(false);
			this.tableLayoutPanelDepartureboard.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.groupBoxDepartureBoardInput.ResumeLayout(false);
			this.groupBoxDepartureBoardInput.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartureBoard)).EndInit();
			this.panelConnections.ResumeLayout(false);
			this.tableLayoutPanelConnect.ResumeLayout(false);
			this.tableLayoutPanelConnection.ResumeLayout(false);
			this.groupBoxConnections.ResumeLayout(false);
			this.groupBoxConnections.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnections)).EndInit();
			this.panelMail.ResumeLayout(false);
			this.panelMail.PerformLayout();
			this.panelLogo.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelConnections;
		private System.Windows.Forms.Panel panelNavigation;
		private System.Windows.Forms.Button buttonNavigationNearMe;
		private System.Windows.Forms.Button buttonNavigateDepartureBoard;
		private System.Windows.Forms.Button ButtonNavigateConnections;
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Panel panelContent;
		private System.Windows.Forms.Panel panelConnections;
		private System.Windows.Forms.Panel panelDepartureBoard;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelConnect;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelConnection;
		private System.Windows.Forms.GroupBox groupBoxConnections;
		private System.Windows.Forms.ComboBox comboBoxConnectionsDeparture;
		private System.Windows.Forms.ComboBox comboBoxConnectionsArrival;
		private System.Windows.Forms.Button buttonSwitch;
		private System.Windows.Forms.DateTimePicker dateTimePickerDepartureDate;
		private System.Windows.Forms.Label labelDepartureTime;
		private System.Windows.Forms.Label labelArrival;
		private System.Windows.Forms.Label labelDeparture;
		private System.Windows.Forms.DataGridView dataGridViewConnections;
		private System.Windows.Forms.Panel panelNearMe;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDepartureboard;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.GroupBox groupBoxDepartureBoardInput;
		private System.Windows.Forms.ComboBox comboBoxDepartureBoardDeparture;
		private System.Windows.Forms.Button buttonShowDepartureBoard;
		private System.Windows.Forms.Label labelDepartureBoardDeparture;
		private System.Windows.Forms.DataGridView dataGridViewDepartureBoard;
		private System.Windows.Forms.DateTimePicker dateTimePickerDepartureTime;
		private System.Windows.Forms.Button buttonShowConnections;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNearMe;
		private System.Windows.Forms.DataGridView dataGridViewNearMe;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStation;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDistance;
		private System.Windows.Forms.Button buttonNavigationMaps;
		private System.Windows.Forms.Panel panelMaps;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMaps;
		private System.Windows.Forms.GroupBox groupBoxMapsInput;
		private System.Windows.Forms.ComboBox comboBoxMapsStation;
		private System.Windows.Forms.Button buttonShowMap;
		private System.Windows.Forms.Label labelStation;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Panel panelLogoMargin;
		private System.Windows.Forms.Button buttonShowNearMe;
		private GMap.NET.WindowsForms.GMapControl gMapControlStation;
		private Button button1;
		private DataGridViewTextBoxColumn columnDeparture;
		private DataGridViewTextBoxColumn columnArrival;
		private DataGridViewTextBoxColumn columnPlatform;
		private DataGridViewTextBoxColumn columnDatum;
		private DataGridViewTextBoxColumn columnDeparturTime;
		private DataGridViewTextBoxColumn columnArrivalTime;
		private DataGridViewTextBoxColumn columnDuration;
		private Panel panelMail;
		private Label labelMail;
		private TextBox textBoxMail;
		private Button buttonMail;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn columnTransport;
	}
}