namespace FlightReservationSystem
{
    partial class AdminReservationsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.adminResGridView = new System.Windows.Forms.DataGridView();
            this.r_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admResDgvUsrNameTxtBx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admResDgvDepartureTxtBx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admResDgvDestinationTxtBx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admResDgvSeatTypeTxtBx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.adminResGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminResGridView
            // 
            this.adminResGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.adminResGridView.AllowUserToOrderColumns = true;
            this.adminResGridView.AutoGenerateColumns = false;
            this.adminResGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.adminResGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminResGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminResGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.adminResGridView.ColumnHeadersHeight = 50;
            this.adminResGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.adminResGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.r_id,
            this.flightidDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.seat_id,
            this.admResDgvUsrNameTxtBx,
            this.admResDgvDepartureTxtBx,
            this.admResDgvDestinationTxtBx,
            this.admResDgvSeatTypeTxtBx,
            this.dataGridViewTextBoxColumn1,
            this.seatNoDataGridViewTextBoxColumn});
            this.adminResGridView.DataSource = this.reservationBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adminResGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.adminResGridView.GridColor = System.Drawing.SystemColors.Control;
            this.adminResGridView.Location = new System.Drawing.Point(17, 115);
            this.adminResGridView.Margin = new System.Windows.Forms.Padding(0);
            this.adminResGridView.Name = "adminResGridView";
            this.adminResGridView.RowHeadersVisible = false;
            this.adminResGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.adminResGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.adminResGridView.RowTemplate.Height = 40;
            this.adminResGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.adminResGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adminResGridView.Size = new System.Drawing.Size(799, 578);
            this.adminResGridView.TabIndex = 5;
            this.adminResGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.adminResGridView_CellFormatting);
            // 
            // r_id
            // 
            this.r_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.r_id.DataPropertyName = "r_id";
            this.r_id.HeaderText = "RID";
            this.r_id.Name = "r_id";
            this.r_id.Width = 68;
            // 
            // flightidDataGridViewTextBoxColumn
            // 
            this.flightidDataGridViewTextBoxColumn.DataPropertyName = "flight_id";
            this.flightidDataGridViewTextBoxColumn.HeaderText = "FID";
            this.flightidDataGridViewTextBoxColumn.Name = "flightidDataGridViewTextBoxColumn";
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "UID";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            // 
            // seat_id
            // 
            this.seat_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.seat_id.DataPropertyName = "seat_id";
            this.seat_id.HeaderText = "Seat ID";
            this.seat_id.Name = "seat_id";
            // 
            // admResDgvUsrNameTxtBx
            // 
            this.admResDgvUsrNameTxtBx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.admResDgvUsrNameTxtBx.HeaderText = "User Name";
            this.admResDgvUsrNameTxtBx.Name = "admResDgvUsrNameTxtBx";
            this.admResDgvUsrNameTxtBx.Visible = false;
            // 
            // admResDgvDepartureTxtBx
            // 
            this.admResDgvDepartureTxtBx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.admResDgvDepartureTxtBx.HeaderText = "Departure";
            this.admResDgvDepartureTxtBx.Name = "admResDgvDepartureTxtBx";
            this.admResDgvDepartureTxtBx.Visible = false;
            // 
            // admResDgvDestinationTxtBx
            // 
            this.admResDgvDestinationTxtBx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.admResDgvDestinationTxtBx.HeaderText = "Destination";
            this.admResDgvDestinationTxtBx.Name = "admResDgvDestinationTxtBx";
            this.admResDgvDestinationTxtBx.Visible = false;
            // 
            // admResDgvSeatTypeTxtBx
            // 
            this.admResDgvSeatTypeTxtBx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.admResDgvSeatTypeTxtBx.HeaderText = "Seat Type";
            this.admResDgvSeatTypeTxtBx.Name = "admResDgvSeatTypeTxtBx";
            this.admResDgvSeatTypeTxtBx.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "rStatus";
            this.dataGridViewTextBoxColumn1.HeaderText = "Status";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // seatNoDataGridViewTextBoxColumn
            // 
            this.seatNoDataGridViewTextBoxColumn.DataPropertyName = "seatNo";
            this.seatNoDataGridViewTextBoxColumn.HeaderText = "seatNo";
            this.seatNoDataGridViewTextBoxColumn.Name = "seatNoDataGridViewTextBoxColumn";
            this.seatNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // reservationBindingSource2
            // 
            this.reservationBindingSource2.DataSource = typeof(FlightReservationSystem.Reservation);
            // 
            // AdminReservationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.adminResGridView);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AdminReservationsControl";
            this.Size = new System.Drawing.Size(1021, 649);
            this.Load += new System.EventHandler(this.AdminReservationsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminResGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView adminResGridView;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn admResDgvUserIdTxtBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn flight_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn rStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reservationBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn r_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn admResDgvUsrNameTxtBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn admResDgvDepartureTxtBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn admResDgvDestinationTxtBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn admResDgvSeatTypeTxtBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reservationBindingSource2;
       
      
    }
}
