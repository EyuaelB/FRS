namespace FlightReservationSystem
{
    partial class ReceptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnFlights = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sessionPnl = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.dropSession = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.profileControl = new FlightReservationSystem.ProfileControl();
            this.receptReservationsControl = new FlightReservationSystem.ReceptReservationsControl();
            this.receptFlightsControl = new FlightReservationSystem.ReceptFlightsControl();
            this.receptDashboardControl = new FlightReservationSystem.ReceptDashboardControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.minBtn = new System.Windows.Forms.Button();
            this.xCloseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.usrFormLbl = new System.Windows.Forms.Label();
            this.receptReportControl = new FlightReservationSystem.ReceptControls.ReceptReportControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sessionPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnReservations);
            this.panel1.Controls.Add(this.btnFlights);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 710);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlNav.Location = new System.Drawing.Point(0, 238);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(4, 123);
            this.pnlNav.TabIndex = 2;
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.Black;
            this.btnReport.Image = global::FlightReservationSystem.Properties.Resources.icons8_file_641;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 480);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(245, 101);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Report";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            this.btnReport.Leave += new System.EventHandler(this.btnReport_Leave);
            // 
            // btnReservations
            // 
            this.btnReservations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservations.FlatAppearance.BorderSize = 0;
            this.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservations.ForeColor = System.Drawing.Color.Black;
            this.btnReservations.Image = global::FlightReservationSystem.Properties.Resources.check_in_desk_40px;
            this.btnReservations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservations.Location = new System.Drawing.Point(0, 379);
            this.btnReservations.Margin = new System.Windows.Forms.Padding(0);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(245, 101);
            this.btnReservations.TabIndex = 1;
            this.btnReservations.Text = "Reservations";
            this.btnReservations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservations.UseVisualStyleBackColor = true;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            this.btnReservations.Leave += new System.EventHandler(this.btnReservations_Leave);
            // 
            // btnFlights
            // 
            this.btnFlights.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFlights.FlatAppearance.BorderSize = 0;
            this.btnFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlights.ForeColor = System.Drawing.Color.Black;
            this.btnFlights.Image = global::FlightReservationSystem.Properties.Resources.airport_64px2;
            this.btnFlights.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlights.Location = new System.Drawing.Point(0, 278);
            this.btnFlights.Margin = new System.Windows.Forms.Padding(4);
            this.btnFlights.Name = "btnFlights";
            this.btnFlights.Size = new System.Drawing.Size(245, 101);
            this.btnFlights.TabIndex = 1;
            this.btnFlights.Text = "Flights";
            this.btnFlights.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFlights.UseVisualStyleBackColor = true;
            this.btnFlights.Click += new System.EventHandler(this.btnFlights_Click);
            this.btnFlights.Leave += new System.EventHandler(this.btnFlights_Leave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.Image = global::FlightReservationSystem.Properties.Resources.home_480px1;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 177);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(245, 101);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sessionPnl);
            this.panel2.Controls.Add(this.dropSession);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 177);
            this.panel2.TabIndex = 0;
            // 
            // sessionPnl
            // 
            this.sessionPnl.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sessionPnl.Controls.Add(this.logoutBtn);
            this.sessionPnl.Controls.Add(this.profileBtn);
            this.sessionPnl.Location = new System.Drawing.Point(16, 42);
            this.sessionPnl.Margin = new System.Windows.Forms.Padding(4);
            this.sessionPnl.Name = "sessionPnl";
            this.sessionPnl.Size = new System.Drawing.Size(120, 81);
            this.sessionPnl.TabIndex = 3;
            this.sessionPnl.Visible = false;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.Black;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(0, 41);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(120, 41);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.profileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.profileBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.profileBtn.FlatAppearance.BorderSize = 0;
            this.profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.Color.Black;
            this.profileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.Location = new System.Drawing.Point(0, 0);
            this.profileBtn.Margin = new System.Windows.Forms.Padding(4);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(120, 41);
            this.profileBtn.TabIndex = 2;
            this.profileBtn.Text = "Profile";
            this.profileBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // dropSession
            // 
            this.dropSession.Image = global::FlightReservationSystem.Properties.Resources.down_squared_16px;
            this.dropSession.Location = new System.Drawing.Point(9, 10);
            this.dropSession.Margin = new System.Windows.Forms.Padding(4);
            this.dropSession.Name = "dropSession";
            this.dropSession.Size = new System.Drawing.Size(27, 25);
            this.dropSession.TabIndex = 2;
            this.dropSession.UseVisualStyleBackColor = true;
            this.dropSession.Click += new System.EventHandler(this.dropSession_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(65, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlightReservationSystem.Properties.Resources.user_512px;
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.BackColor = System.Drawing.Color.LightGray;
            this.searchTxtBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.searchTxtBox.Location = new System.Drawing.Point(781, 16);
            this.searchTxtBox.Margin = new System.Windows.Forms.Padding(0);
            this.searchTxtBox.Multiline = true;
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(232, 30);
            this.searchTxtBox.TabIndex = 2;
            this.searchTxtBox.Text = "Search Anything";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchBtn.Location = new System.Drawing.Point(1025, 17);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(100, 28);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainPanel.Controls.Add(this.profileControl);
            this.mainPanel.Controls.Add(this.receptReservationsControl);
            this.mainPanel.Controls.Add(this.receptFlightsControl);
            this.mainPanel.Controls.Add(this.receptDashboardControl);
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Controls.Add(this.receptReportControl);
            this.mainPanel.Location = new System.Drawing.Point(247, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1021, 710);
            this.mainPanel.TabIndex = 5;
            // 
            // profileControl
            // 
            this.profileControl.BackColor = System.Drawing.SystemColors.Window;
            this.profileControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileControl.Location = new System.Drawing.Point(0, 62);
            this.profileControl.Margin = new System.Windows.Forms.Padding(0);
            this.profileControl.Name = "profileControl";
            this.profileControl.Size = new System.Drawing.Size(1021, 648);
            this.profileControl.TabIndex = 4;
            this.profileControl.Load += new System.EventHandler(this.profileControl_Load);
            // 
            // receptReservationsControl
            // 
            this.receptReservationsControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.receptReservationsControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.receptReservationsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receptReservationsControl.Location = new System.Drawing.Point(0, 62);
            this.receptReservationsControl.Margin = new System.Windows.Forms.Padding(0);
            this.receptReservationsControl.Name = "receptReservationsControl";
            this.receptReservationsControl.rId = 0;
            this.receptReservationsControl.Size = new System.Drawing.Size(1021, 648);
            this.receptReservationsControl.TabIndex = 6;
            // 
            // receptFlightsControl
            // 
            this.receptFlightsControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.receptFlightsControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.receptFlightsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receptFlightsControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.receptFlightsControl.Location = new System.Drawing.Point(0, 62);
            this.receptFlightsControl.Margin = new System.Windows.Forms.Padding(0);
            this.receptFlightsControl.Name = "receptFlightsControl";
            this.receptFlightsControl.Size = new System.Drawing.Size(1021, 648);
            this.receptFlightsControl.TabIndex = 5;
            // 
            // receptDashboardControl
            // 
            this.receptDashboardControl.BackColor = System.Drawing.Color.White;
            this.receptDashboardControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receptDashboardControl.Location = new System.Drawing.Point(0, 62);
            this.receptDashboardControl.Margin = new System.Windows.Forms.Padding(0);
            this.receptDashboardControl.Name = "receptDashboardControl";
            this.receptDashboardControl.Size = new System.Drawing.Size(1021, 648);
            this.receptDashboardControl.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.minBtn);
            this.panel3.Controls.Add(this.xCloseBtn);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.usrFormLbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1021, 62);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // minBtn
            // 
            this.minBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBtn.BackColor = System.Drawing.Color.Transparent;
            this.minBtn.FlatAppearance.BorderSize = 0;
            this.minBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBtn.Location = new System.Drawing.Point(907, 0);
            this.minBtn.Margin = new System.Windows.Forms.Padding(4);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(57, 33);
            this.minBtn.TabIndex = 1;
            this.minBtn.Text = "---";
            this.minBtn.UseVisualStyleBackColor = false;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            this.minBtn.MouseEnter += new System.EventHandler(this.minBtn_MouseEnter);
            this.minBtn.MouseLeave += new System.EventHandler(this.minBtn_MouseLeave);
            // 
            // xCloseBtn
            // 
            this.xCloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xCloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.xCloseBtn.FlatAppearance.BorderSize = 0;
            this.xCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xCloseBtn.Location = new System.Drawing.Point(964, 0);
            this.xCloseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.xCloseBtn.Name = "xCloseBtn";
            this.xCloseBtn.Size = new System.Drawing.Size(57, 33);
            this.xCloseBtn.TabIndex = 1;
            this.xCloseBtn.Text = "X";
            this.xCloseBtn.UseVisualStyleBackColor = false;
            this.xCloseBtn.Click += new System.EventHandler(this.xCloseBtn_Click);
            this.xCloseBtn.MouseEnter += new System.EventHandler(this.xCloseBtn_MouseEnter);
            this.xCloseBtn.MouseLeave += new System.EventHandler(this.xCloseBtn_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-55, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "---";
            // 
            // usrFormLbl
            // 
            this.usrFormLbl.AutoSize = true;
            this.usrFormLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrFormLbl.Location = new System.Drawing.Point(11, 14);
            this.usrFormLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usrFormLbl.Name = "usrFormLbl";
            this.usrFormLbl.Size = new System.Drawing.Size(319, 36);
            this.usrFormLbl.TabIndex = 0;
            this.usrFormLbl.Text = "Welcome, Receptionist";
            // 
            // receptReportControl
            // 
            this.receptReportControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.receptReportControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receptReportControl.Location = new System.Drawing.Point(0, 0);
            this.receptReportControl.Margin = new System.Windows.Forms.Padding(0);
            this.receptReportControl.Name = "receptReportControl";
            this.receptReportControl.Size = new System.Drawing.Size(1021, 710);
            this.receptReportControl.TabIndex = 3;
            // 
            // ReceptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1268, 710);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReceptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passsenger ";
            this.Load += new System.EventHandler(this.ReceptForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.sessionPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Button btnFlights;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label usrFormLbl;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button xCloseBtn;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Label label2;     
        private System.Windows.Forms.Button dropSession;
        private System.Windows.Forms.Panel sessionPnl;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button profileBtn;
        private ReceptDashboardControl receptDashboardControl;
        private ReceptControls.ReceptReportControl receptReportControl;
        private ProfileControl profileControl;
        private ReceptReservationsControl receptReservationsControl;
        private ReceptFlightsControl receptFlightsControl;       
       
    }
}
