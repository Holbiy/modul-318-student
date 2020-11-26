
namespace TransportApp
{
	partial class Home
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
			this.components = new System.ComponentModel.Container();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.labelTitle = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.buttonSearchConnections = new System.Windows.Forms.Button();
			this.buttonNearMe = new System.Windows.Forms.Button();
			this.buttonTakeMeHome = new System.Windows.Forms.Button();
			this.buttonDepartureBoard = new System.Windows.Forms.Button();
			this.panelTitle.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTitle
			// 
			this.panelTitle.BackColor = System.Drawing.SystemColors.Highlight;
			this.panelTitle.Controls.Add(this.labelTitle);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitle.Location = new System.Drawing.Point(0, 0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(984, 111);
			this.panelTitle.TabIndex = 0;
			// 
			// labelTitle
			// 
			this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(0, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(984, 111);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Was wollen Sie tun?";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// buttonSearchConnections
			// 
			this.buttonSearchConnections.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.buttonSearchConnections.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonSearchConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSearchConnections.Location = new System.Drawing.Point(153, 139);
			this.buttonSearchConnections.Name = "buttonSearchConnections";
			this.buttonSearchConnections.Size = new System.Drawing.Size(716, 75);
			this.buttonSearchConnections.TabIndex = 1;
			this.buttonSearchConnections.Text = "Verbindungen suchen";
			this.buttonSearchConnections.UseVisualStyleBackColor = false;
			this.buttonSearchConnections.Click += new System.EventHandler(this.buttonSearchConnections_Click);
			// 
			// buttonNearMe
			// 
			this.buttonNearMe.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.buttonNearMe.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonNearMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNearMe.Location = new System.Drawing.Point(153, 220);
			this.buttonNearMe.Name = "buttonNearMe";
			this.buttonNearMe.Size = new System.Drawing.Size(716, 75);
			this.buttonNearMe.TabIndex = 2;
			this.buttonNearMe.Text = "Stationen in meiner Umgebung";
			this.buttonNearMe.UseVisualStyleBackColor = false;
			// 
			// buttonTakeMeHome
			// 
			this.buttonTakeMeHome.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.buttonTakeMeHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonTakeMeHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonTakeMeHome.Location = new System.Drawing.Point(153, 301);
			this.buttonTakeMeHome.Name = "buttonTakeMeHome";
			this.buttonTakeMeHome.Size = new System.Drawing.Size(716, 75);
			this.buttonTakeMeHome.TabIndex = 3;
			this.buttonTakeMeHome.Text = "Take me Home";
			this.buttonTakeMeHome.UseVisualStyleBackColor = false;
			// 
			// buttonDepartureBoard
			// 
			this.buttonDepartureBoard.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.buttonDepartureBoard.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonDepartureBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDepartureBoard.Location = new System.Drawing.Point(153, 382);
			this.buttonDepartureBoard.Name = "buttonDepartureBoard";
			this.buttonDepartureBoard.Size = new System.Drawing.Size(716, 75);
			this.buttonDepartureBoard.TabIndex = 4;
			this.buttonDepartureBoard.Text = "Abfahrtstafel";
			this.buttonDepartureBoard.UseVisualStyleBackColor = false;
			this.buttonDepartureBoard.Click += new System.EventHandler(this.buttonDepartureBoard_Click);
			// 
			// Home
			// 
			this.AcceptButton = this.buttonSearchConnections;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(984, 461);
			this.Controls.Add(this.buttonDepartureBoard);
			this.Controls.Add(this.buttonTakeMeHome);
			this.Controls.Add(this.buttonNearMe);
			this.Controls.Add(this.buttonSearchConnections);
			this.Controls.Add(this.panelTitle);
			this.MinimumSize = new System.Drawing.Size(1000, 500);
			this.Name = "Home";
			this.Text = "Home";
			this.panelTitle.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button buttonSearchConnections;
		private System.Windows.Forms.Button buttonNearMe;
		private System.Windows.Forms.Button buttonTakeMeHome;
		private System.Windows.Forms.Button buttonDepartureBoard;
	}
}

