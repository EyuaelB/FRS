namespace FlightReservationSystem
{
    partial class AdminFlightsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.adminFlightsDataGridView = new System.Windows.Forms.DataGridView();
            this.dgvFlightTimeTxtBx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFlightIDTxtBx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFlightTypeTxtBx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDepartTxtBx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDestTxtBx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFlightPriceTxtBx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFlightPilotTxtBx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFlightStatusTxtBx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flightTypeComBx = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.flightDtTmPic = new System.Windows.Forms.DateTimePicker();
            this.IDplnComBx = new System.Windows.Forms.ComboBox();
            this.statusComBx = new System.Windows.Forms.ComboBox();
            this.flightPriceTxtBx = new System.Windows.Forms.TextBox();
            this.pilotTxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.destComBx = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.departureComBx = new System.Windows.Forms.ComboBox();
            this.saveFlightBtn = new System.Windows.Forms.Button();
            this.delFlightBtn = new System.Windows.Forms.Button();
            this.cancelSaveFlightBtn = new System.Windows.Forms.Button();
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.adminFlightsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adminFlightsDataGridView
            // 
            this.adminFlightsDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.adminFlightsDataGridView.AllowUserToAddRows = false;
            this.adminFlightsDataGridView.AllowUserToDeleteRows = false;
            this.adminFlightsDataGridView.AllowUserToResizeColumns = false;
            this.adminFlightsDataGridView.AllowUserToResizeRows = false;
            this.adminFlightsDataGridView.AutoGenerateColumns = false;
            this.adminFlightsDataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.adminFlightsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminFlightsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.adminFlightsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminFlightsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.adminFlightsDataGridView.ColumnHeadersHeight = 50;
            this.adminFlightsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.adminFlightsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFlightTimeTxtBx,
            this.dgvFlightIDTxtBx,
            this.dgvFlightTypeTxtBx,
            this.dgvDepartTxtBx,
            this.dgvDestTxtBx,
            this.dgvFlightPriceTxtBx,
            this.dgvFlightPilotTxtBx,
            this.dgvFlightStatusTxtBx});
            this.adminFlightsDataGridView.DataSource = this.flightBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adminFlightsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.adminFlightsDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adminFlightsDataGridView.Location = new System.Drawing.Point(17, 353);
            this.adminFlightsDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.adminFlightsDataGridView.Name = "adminFlightsDataGridView";
            this.adminFlightsDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminFlightsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.adminFlightsDataGridView.RowHeadersVisible = false;
            this.adminFlightsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.adminFlightsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.adminFlightsDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Menu;
            this.adminFlightsDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(180)))), ((int)(((byte)(248)))));
            this.adminFlightsDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.adminFlightsDataGridView.RowTemplate.Height = 45;
            this.adminFlightsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.adminFlightsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adminFlightsDataGridView.Size = new System.Drawing.Size(799, 295);
            this.adminFlightsDataGridView.TabIndex = 0;
            this.adminFlightsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminFlightsDataGridView_CellDoubleClick);
            this.adminFlightsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.adminFlightsDataGridView_CellFormatting);
            // 
            // dgvFlightTimeTxtBx
            // 
            this.dgvFlightTimeTxtBx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvFlightTimeTxtBx.DataPropertyName = "flightTime";
            this.dgvFlightTimeTxtBx.HeaderText = "Time";
            this.dgvFlightTimeTxtBx.Name = "dgvFlightTimeTxtBx";
            this.dgvFlightTimeTxtBx.ReadOnly = true;
            // 
            // dgvFlightIDTxtBx
            // 
            this.dgvFlightIDTxtBx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvFlightIDTxtBx.DataPropertyName = "f_id";
            this.dgvFlightIDTxtBx.HeaderText = "FID";
            this.dgvFlightIDTxtBx.Name = "dgvFlightIDTxtBx";
            this.dgvFlightIDTxtBx.ReadOnly = true;
            this.dgvFlightIDTxtBx.Visible = false;
            this.dgvFlightIDTxtBx.Width = 66;
            // 
            // dgvFlightTypeTxtBx
            // 
            this.dgvFlightTypeTxtBx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvFlightTypeTxtBx.DataPropertyName = "flightType";
            this.dgvFlightTypeTxtBx.HeaderText = "Type";
            this.dgvFlightTypeTxtBx.Name = "dgvFlightTypeTxtBx";
            this.dgvFlightTypeTxtBx.ReadOnly = true;
            // 
            // dgvDepartTxtBx
            // 
            this.dgvDepartTxtBx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDepartTxtBx.DataPropertyName = "departure";
            this.dgvDepartTxtBx.HeaderText = "Departure";
            this.dgvDepartTxtBx.Name = "dgvDepartTxtBx";
            this.dgvDepartTxtBx.ReadOnly = true;
            // 
            // dgvDestTxtBx
            // 
            this.dgvDestTxtBx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDestTxtBx.DataPropertyName = "destination";
            this.dgvDestTxtBx.HeaderText = "Destination";
            this.dgvDestTxtBx.Name = "dgvDestTxtBx";
            this.dgvDestTxtBx.ReadOnly = true;
            // 
            // dgvFlightPriceTxtBx
            // 
            this.dgvFlightPriceTxtBx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvFlightPriceTxtBx.DataPropertyName = "flightPrice";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvFlightPriceTxtBx.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFlightPriceTxtBx.HeaderText = "Price";
            this.dgvFlightPriceTxtBx.Name = "dgvFlightPriceTxtBx";
            this.dgvFlightPriceTxtBx.ReadOnly = true;
            this.dgvFlightPriceTxtBx.Width = 79;
            // 
            // dgvFlightPilotTxtBx
            // 
            this.dgvFlightPilotTxtBx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvFlightPilotTxtBx.DataPropertyName = "flightPilot";
            this.dgvFlightPilotTxtBx.HeaderText = "Pilot";
            this.dgvFlightPilotTxtBx.Name = "dgvFlightPilotTxtBx";
            this.dgvFlightPilotTxtBx.ReadOnly = true;
            // 
            // dgvFlightStatusTxtBx
            // 
            this.dgvFlightStatusTxtBx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvFlightStatusTxtBx.DataPropertyName = "flightStatus";
            this.dgvFlightStatusTxtBx.HeaderText = "Status";
            this.dgvFlightStatusTxtBx.Name = "dgvFlightStatusTxtBx";
            this.dgvFlightStatusTxtBx.ReadOnly = true;
            this.dgvFlightStatusTxtBx.Width = 90;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.flightTypeComBx);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.flightDtTmPic);
            this.panel1.Controls.Add(this.IDplnComBx);
            this.panel1.Controls.Add(this.statusComBx);
            this.panel1.Controls.Add(this.flightPriceTxtBx);
            this.panel1.Controls.Add(this.pilotTxtBx);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.destComBx);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.departureComBx);
            this.panel1.Location = new System.Drawing.Point(17, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 324);
            this.panel1.TabIndex = 15;
            // 
            // flightTypeComBx
            // 
            this.flightTypeComBx.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flightTypeComBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.flightTypeComBx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flightTypeComBx.FormattingEnabled = true;
            this.flightTypeComBx.Items.AddRange(new object[] {
            "DomesticOneWay",
            "DomesticRoundWay",
            "InternationalOneWay",
            "InternationalRoundWay"});
            this.flightTypeComBx.Location = new System.Drawing.Point(168, 113);
            this.flightTypeComBx.Margin = new System.Windows.Forms.Padding(0);
            this.flightTypeComBx.Name = "flightTypeComBx";
            this.flightTypeComBx.Size = new System.Drawing.Size(181, 37);
            this.flightTypeComBx.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MistyRose;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(445, 176);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "Pilot";
            // 
            // flightDtTmPic
            // 
            this.flightDtTmPic.CalendarFont = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightDtTmPic.CustomFormat = "ddd,MMMMdd, yyyy | h:mm tt";
            this.flightDtTmPic.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightDtTmPic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.flightDtTmPic.Location = new System.Drawing.Point(168, 7);
            this.flightDtTmPic.Margin = new System.Windows.Forms.Padding(0);
            this.flightDtTmPic.MinimumSize = new System.Drawing.Size(4, 32);
            this.flightDtTmPic.Name = "flightDtTmPic";
            this.flightDtTmPic.Size = new System.Drawing.Size(327, 32);
            this.flightDtTmPic.TabIndex = 17;
            // 
            // IDplnComBx
            // 
            this.IDplnComBx.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IDplnComBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.IDplnComBx.FormattingEnabled = true;
            this.IDplnComBx.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.IDplnComBx.Location = new System.Drawing.Point(168, 60);
            this.IDplnComBx.Margin = new System.Windows.Forms.Padding(0);
            this.IDplnComBx.Name = "IDplnComBx";
            this.IDplnComBx.Size = new System.Drawing.Size(181, 37);
            this.IDplnComBx.TabIndex = 11;
            // 
            // statusComBx
            // 
            this.statusComBx.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusComBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.statusComBx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statusComBx.FormattingEnabled = true;
            this.statusComBx.Items.AddRange(new object[] {
            "Active ",
            "Suspended"});
            this.statusComBx.Location = new System.Drawing.Point(168, 166);
            this.statusComBx.Margin = new System.Windows.Forms.Padding(0);
            this.statusComBx.Name = "statusComBx";
            this.statusComBx.Size = new System.Drawing.Size(181, 37);
            this.statusComBx.TabIndex = 11;
            // 
            // flightPriceTxtBx
            // 
            this.flightPriceTxtBx.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flightPriceTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.flightPriceTxtBx.Location = new System.Drawing.Point(168, 223);
            this.flightPriceTxtBx.Margin = new System.Windows.Forms.Padding(0);
            this.flightPriceTxtBx.Name = "flightPriceTxtBx";
            this.flightPriceTxtBx.Size = new System.Drawing.Size(181, 34);
            this.flightPriceTxtBx.TabIndex = 12;
            // 
            // pilotTxtBx
            // 
            this.pilotTxtBx.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pilotTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.pilotTxtBx.Location = new System.Drawing.Point(504, 171);
            this.pilotTxtBx.Margin = new System.Windows.Forms.Padding(0);
            this.pilotTxtBx.Name = "pilotTxtBx";
            this.pilotTxtBx.Size = new System.Drawing.Size(237, 34);
            this.pilotTxtBx.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SeaShell;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(56, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Flight Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.RosyBrown;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic);
            this.label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label9.Location = new System.Drawing.Point(95, 174);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic);
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(384, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Destination";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(396, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Departure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OldLace;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(109, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(76, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plane ID";
            // 
            // destComBx
            // 
            this.destComBx.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.destComBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.destComBx.FormattingEnabled = true;
            this.destComBx.Items.AddRange(new object[] {
            "Addis Ababa, ET",
            "New York, US",
            "Jimma, ET",
            "Mekele, ET",
            "Seoul, SKorea",
            "Washington DC, US",
            "Tokyo, Japan",
            "Bejing, China",
            "Mosscow, Russia",
            "BahrDar, ET",
            "Gondar, ET",
            "Axum, ET"});
            this.destComBx.Location = new System.Drawing.Point(504, 116);
            this.destComBx.Margin = new System.Windows.Forms.Padding(0);
            this.destComBx.Name = "destComBx";
            this.destComBx.Size = new System.Drawing.Size(237, 37);
            this.destComBx.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(108, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Time";
            // 
            // departureComBx
            // 
            this.departureComBx.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.departureComBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureComBx.FormattingEnabled = true;
            this.departureComBx.Items.AddRange(new object[] {
            "Addis Ababa, ET",
            "New York, US",
            "Jimma, ET",
            "Mekele, ET",
            "Seoul, SKorea",
            "Washington DC, US",
            "Tokyo, Japan",
            "Bejing, China",
            "Mosscow, Russia",
            "BahrDar, ET",
            "Gondar, ET",
            "Axum, ET"});
            this.departureComBx.Location = new System.Drawing.Point(504, 60);
            this.departureComBx.Margin = new System.Windows.Forms.Padding(0);
            this.departureComBx.Name = "departureComBx";
            this.departureComBx.Size = new System.Drawing.Size(237, 37);
            this.departureComBx.TabIndex = 11;
            // 
            // saveFlightBtn
            // 
            this.saveFlightBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.saveFlightBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.saveFlightBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFlightBtn.ForeColor = System.Drawing.Color.Purple;
            this.saveFlightBtn.Image = global::FlightReservationSystem.Properties.Resources.icons8_save_32;
            this.saveFlightBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveFlightBtn.Location = new System.Drawing.Point(179, 302);
            this.saveFlightBtn.Margin = new System.Windows.Forms.Padding(0);
            this.saveFlightBtn.Name = "saveFlightBtn";
            this.saveFlightBtn.Size = new System.Drawing.Size(144, 44);
            this.saveFlightBtn.TabIndex = 1;
            this.saveFlightBtn.Text = "Save Flight";
            this.saveFlightBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveFlightBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.saveFlightBtn.UseVisualStyleBackColor = false;
            this.saveFlightBtn.Click += new System.EventHandler(this.saveFlightBtn_Click);
            // 
            // delFlightBtn
            // 
            this.delFlightBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.delFlightBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.delFlightBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delFlightBtn.ForeColor = System.Drawing.Color.Purple;
            this.delFlightBtn.Image = global::FlightReservationSystem.Properties.Resources.icons8_deletec_16;
            this.delFlightBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delFlightBtn.Location = new System.Drawing.Point(509, 303);
            this.delFlightBtn.Margin = new System.Windows.Forms.Padding(4);
            this.delFlightBtn.Name = "delFlightBtn";
            this.delFlightBtn.Size = new System.Drawing.Size(144, 42);
            this.delFlightBtn.TabIndex = 1;
            this.delFlightBtn.Text = "Delete Flight";
            this.delFlightBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delFlightBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.delFlightBtn.UseVisualStyleBackColor = false;
            this.delFlightBtn.Click += new System.EventHandler(this.saveFlightBtn_Click);
            // 
            // cancelSaveFlightBtn
            // 
            this.cancelSaveFlightBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cancelSaveFlightBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cancelSaveFlightBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelSaveFlightBtn.ForeColor = System.Drawing.Color.Purple;
            this.cancelSaveFlightBtn.Image = global::FlightReservationSystem.Properties.Resources.icons8_delete_sign_16;
            this.cancelSaveFlightBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelSaveFlightBtn.Location = new System.Drawing.Point(344, 304);
            this.cancelSaveFlightBtn.Margin = new System.Windows.Forms.Padding(0);
            this.cancelSaveFlightBtn.Name = "cancelSaveFlightBtn";
            this.cancelSaveFlightBtn.Size = new System.Drawing.Size(144, 39);
            this.cancelSaveFlightBtn.TabIndex = 1;
            this.cancelSaveFlightBtn.Text = "Cancel";
            this.cancelSaveFlightBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelSaveFlightBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cancelSaveFlightBtn.UseVisualStyleBackColor = false;
            this.cancelSaveFlightBtn.Click += new System.EventHandler(this.cancelSaveFlightBtn_Click);
            // 
            // flightBindingSource
            // 
            this.flightBindingSource.DataSource = typeof(FlightReservationSystem.Flight);
            // 
            // AdminFlightsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.adminFlightsDataGridView);
            this.Controls.Add(this.saveFlightBtn);
            this.Controls.Add(this.delFlightBtn);
            this.Controls.Add(this.cancelSaveFlightBtn);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AdminFlightsControl";
            this.Size = new System.Drawing.Size(1021, 649);
            this.Load += new System.EventHandler(this.AdminFlightsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminFlightsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView adminFlightsDataGridView;      
        //private System.Windows.Forms.DataGridViewTextBoxColumn f_idTxtBox;
        //private System.Windows.Forms.DataGridViewTextBoxColumn flightTimeTxtBox;
       // private System.Windows.Forms.DataGridViewTextBoxColumn flightStatusTxtBox;
      //  private System.Windows.Forms.DataGridViewTextBoxColumn flightPilotTxtBox;
    //    private System.Windows.Forms.DataGridViewTextBoxColumn plane_idTxtBox;
        private System.Windows.Forms.Button saveFlightBtn;
        private System.Windows.Forms.Button delFlightBtn;
        private System.Windows.Forms.Button cancelSaveFlightBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox statusComBx;
        private System.Windows.Forms.TextBox pilotTxtBx;
        private System.Windows.Forms.ComboBox IDplnComBx;
        private System.Windows.Forms.ComboBox flightTypeComBx;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dgvFlightIDTxtBx;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dgvFlightPIDTxtBx;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dgvFlightTimeTxtBx;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dgvFlightTypeTxtBx;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dgvFlightPilotTxtBx;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dgvFlightStatusTxtBx;
        private System.Windows.Forms.ComboBox departureComBx;
        private System.Windows.Forms.ComboBox destComBx;
        private System.Windows.Forms.DateTimePicker flightDtTmPic;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox flightPriceTxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFlightTimeTxtBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFlightIDTxtBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFlightTypeTxtBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDepartTxtBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDestTxtBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFlightPriceTxtBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFlightPilotTxtBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFlightStatusTxtBx;
        private System.Windows.Forms.BindingSource flightBindingSource;
      //  private System.Windows.Forms.BindingSource flightBindingSource;
        //private flightRsysDataSet flightRsysDataSet;
       // private flightRsysDataSetTableAdapters.FlightTableAdapter flightTableAdapter;

    }
}
