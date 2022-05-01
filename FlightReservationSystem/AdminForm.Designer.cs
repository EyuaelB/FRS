namespace FlightReservationSystem
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnPlanes = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnFlights = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sessionPnl = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.dropSession = new System.Windows.Forms.Button();
            this.usrNLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.planesControl = new FlightReservationSystem.PlanesControl();
            this.adminUsersControl = new FlightReservationSystem.AdminUsersControl();
            this.adminFlightsControl = new FlightReservationSystem.AdminFlightsControl();
            this.profileControl = new FlightReservationSystem.ProfileControl();
            this.adminReservationsControl = new FlightReservationSystem.AdminReservationsControl();
            this.adminDashboardControl = new FlightReservationSystem.AdminDashboardControl();
            this.passTOpPnl = new System.Windows.Forms.Panel();
            this.minBtn = new System.Windows.Forms.Button();
            this.xCloseBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.frmLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sessionPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.passTOpPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnPlanes);
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
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.Black;
            this.btnUsers.Image = global::FlightReservationSystem.Properties.Resources.groups_480px1;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 581);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(245, 101);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            this.btnUsers.Leave += new System.EventHandler(this.btnUsers_Leave);
            // 
            // btnPlanes
            // 
            this.btnPlanes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlanes.FlatAppearance.BorderSize = 0;
            this.btnPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanes.ForeColor = System.Drawing.Color.Black;
            this.btnPlanes.Image = global::FlightReservationSystem.Properties.Resources.airport_32px2;
            this.btnPlanes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanes.Location = new System.Drawing.Point(0, 480);
            this.btnPlanes.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(245, 101);
            this.btnPlanes.TabIndex = 1;
            this.btnPlanes.Text = "Planes";
            this.btnPlanes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlanes.UseVisualStyleBackColor = true;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            this.btnPlanes.Leave += new System.EventHandler(this.btnPlanes_Leave);
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
            this.btnFlights.Image = global::FlightReservationSystem.Properties.Resources.airport_64px;
            this.btnFlights.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlights.Location = new System.Drawing.Point(0, 278);
            this.btnFlights.Margin = new System.Windows.Forms.Padding(0);
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
            this.panel2.Controls.Add(this.usrNLbl);
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
            this.sessionPnl.MouseEnter += new System.EventHandler(this.sessionPnl_MouseEnter);
            this.sessionPnl.MouseLeave += new System.EventHandler(this.sessionPnl_MouseLeave);
            this.sessionPnl.MouseHover += new System.EventHandler(this.sessionPnl_MouseHover);
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
            this.dropSession.MouseEnter += new System.EventHandler(this.dropSession_MouseEnter);
            // 
            // usrNLbl
            // 
            this.usrNLbl.AutoSize = true;
            this.usrNLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrNLbl.ForeColor = System.Drawing.Color.Black;
            this.usrNLbl.Location = new System.Drawing.Point(67, 139);
            this.usrNLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usrNLbl.Name = "usrNLbl";
            this.usrNLbl.Size = new System.Drawing.Size(103, 20);
            this.usrNLbl.TabIndex = 1;
            this.usrNLbl.Text = "User Name";
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
            this.searchTxtBox.BackColor = System.Drawing.SystemColors.Menu;
            this.searchTxtBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchTxtBox.Location = new System.Drawing.Point(719, 16);
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
            this.searchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchBtn.Location = new System.Drawing.Point(965, 17);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(100, 28);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainPanel.Controls.Add(this.planesControl);
            this.mainPanel.Controls.Add(this.adminUsersControl);
            this.mainPanel.Controls.Add(this.adminFlightsControl);
            this.mainPanel.Controls.Add(this.profileControl);
            this.mainPanel.Controls.Add(this.adminReservationsControl);
            this.mainPanel.Controls.Add(this.adminDashboardControl);
            this.mainPanel.Controls.Add(this.passTOpPnl);
            this.mainPanel.Location = new System.Drawing.Point(247, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1021, 710);
            this.mainPanel.TabIndex = 5;
            // 
            // planesControl
            // 
            this.planesControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.planesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.planesControl.Location = new System.Drawing.Point(1021, 2009);
            this.planesControl.Margin = new System.Windows.Forms.Padding(4);
            this.planesControl.Name = "planesControl";
            this.planesControl.Size = new System.Drawing.Size(0, 0);
            this.planesControl.TabIndex = 12;
            // 
            // adminUsersControl
            // 
            this.adminUsersControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminUsersControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminUsersControl.Location = new System.Drawing.Point(1021, 1360);
            this.adminUsersControl.Margin = new System.Windows.Forms.Padding(5);
            this.adminUsersControl.Name = "adminUsersControl";
            this.adminUsersControl.Size = new System.Drawing.Size(0, 649);
            this.adminUsersControl.TabIndex = 11;
            // 
            // adminFlightsControl
            // 
            this.adminFlightsControl.BackColor = System.Drawing.Color.Transparent;
            this.adminFlightsControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminFlightsControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.adminFlightsControl.ForeColor = System.Drawing.Color.Transparent;
            this.adminFlightsControl.Location = new System.Drawing.Point(0, 1360);
            this.adminFlightsControl.Margin = new System.Windows.Forms.Padding(0);
            this.adminFlightsControl.Name = "adminFlightsControl";
            this.adminFlightsControl.Size = new System.Drawing.Size(1021, 0);
            this.adminFlightsControl.TabIndex = 7;
            // 
            // profileControl
            // 
            this.profileControl.BackColor = System.Drawing.SystemColors.Window;
            this.profileControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.profileControl.Location = new System.Drawing.Point(0, 711);
            this.profileControl.Margin = new System.Windows.Forms.Padding(0);
            this.profileControl.Name = "profileControl";
            this.profileControl.Size = new System.Drawing.Size(1021, 649);
            this.profileControl.TabIndex = 10;
            // 
            // adminReservationsControl
            // 
            this.adminReservationsControl.BackColor = System.Drawing.Color.Transparent;
            this.adminReservationsControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminReservationsControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminReservationsControl.Location = new System.Drawing.Point(0, 62);
            this.adminReservationsControl.Margin = new System.Windows.Forms.Padding(0);
            this.adminReservationsControl.Name = "adminReservationsControl";
            this.adminReservationsControl.Size = new System.Drawing.Size(1021, 649);
            this.adminReservationsControl.TabIndex = 9;
            this.adminReservationsControl.Load += new System.EventHandler(this.adminReservationsControl_Load);
            // 
            // adminDashboardControl
            // 
            this.adminDashboardControl.BackColor = System.Drawing.Color.White;
            this.adminDashboardControl.Location = new System.Drawing.Point(0, 62);
            this.adminDashboardControl.Margin = new System.Windows.Forms.Padding(0);
            this.adminDashboardControl.Name = "adminDashboardControl";
            this.adminDashboardControl.Size = new System.Drawing.Size(1021, 649);
            this.adminDashboardControl.TabIndex = 8;
            // 
            // passTOpPnl
            // 
            this.passTOpPnl.BackColor = System.Drawing.SystemColors.Control;
            this.passTOpPnl.Controls.Add(this.minBtn);
            this.passTOpPnl.Controls.Add(this.xCloseBtn);
            this.passTOpPnl.Controls.Add(this.label3);
            this.passTOpPnl.Controls.Add(this.frmLbl);
            this.passTOpPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.passTOpPnl.Location = new System.Drawing.Point(0, 0);
            this.passTOpPnl.Margin = new System.Windows.Forms.Padding(0);
            this.passTOpPnl.Name = "passTOpPnl";
            this.passTOpPnl.Size = new System.Drawing.Size(1021, 62);
            this.passTOpPnl.TabIndex = 6;
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
            this.minBtn.MouseHover += new System.EventHandler(this.minBtn_MouseEnter);
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
            this.xCloseBtn.MouseHover += new System.EventHandler(this.xCloseBtn_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-55, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "---";
            // 
            // frmLbl
            // 
            this.frmLbl.AutoSize = true;
            this.frmLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLbl.Location = new System.Drawing.Point(11, 14);
            this.frmLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.frmLbl.Name = "frmLbl";
            this.frmLbl.Size = new System.Drawing.Size(239, 36);
            this.frmLbl.TabIndex = 0;
            this.frmLbl.Text = "Welcome, Admin";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 710);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.sessionPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.passTOpPnl.ResumeLayout(false);
            this.passTOpPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label usrNLbl;
        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Button btnFlights;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel pnlNav;
      //  private AdminDashboardControl adminDashboardForm;
      //  private AdminFlightsControl adminFlightsForm;
        // private AdminReservationsControl adminReservationsForm;
        private System.Windows.Forms.Button dropSession;
        private System.Windows.Forms.Panel sessionPnl;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Panel passTOpPnl;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Button xCloseBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label frmLbl;
        private AdminReservationsControl adminReservationsControl;
        private AdminDashboardControl adminDashboardControl;
        private AdminFlightsControl adminFlightsControl;
        private ProfileControl profileControl;
        private AdminUsersControl adminUsersControl;
        private PlanesControl planesControl;
    }
}