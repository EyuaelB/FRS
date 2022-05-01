namespace FlightReservationSystem
{
    partial class ReceptReservationsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.receptReservationDataGridView = new System.Windows.Forms.DataGridView();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFlightBtn = new System.Windows.Forms.Button();
            this.rStatusUpdateCmBx = new System.Windows.Forms.ComboBox();
            this.ridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.receptReservationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // receptReservationDataGridView
            // 
            this.receptReservationDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.receptReservationDataGridView.AllowUserToDeleteRows = false;
            this.receptReservationDataGridView.AllowUserToResizeColumns = false;
            this.receptReservationDataGridView.AllowUserToResizeRows = false;
            this.receptReservationDataGridView.AutoGenerateColumns = false;
            this.receptReservationDataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.receptReservationDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receptReservationDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.receptReservationDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.receptReservationDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.receptReservationDataGridView.ColumnHeadersHeight = 50;
            this.receptReservationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.receptReservationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ridDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.flightidDataGridViewTextBoxColumn,
            this.seatidDataGridViewTextBoxColumn,
            this.seatNoDataGridViewTextBoxColumn,
            this.rStatusDataGridViewTextBoxColumn});
            this.receptReservationDataGridView.DataSource = this.reservationBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.receptReservationDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.receptReservationDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.receptReservationDataGridView.Location = new System.Drawing.Point(17, 115);
            this.receptReservationDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.receptReservationDataGridView.Name = "receptReservationDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.receptReservationDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.receptReservationDataGridView.RowHeadersVisible = false;
            this.receptReservationDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.receptReservationDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.receptReservationDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Menu;
            this.receptReservationDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(180)))), ((int)(((byte)(248)))));
            this.receptReservationDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.receptReservationDataGridView.RowTemplate.Height = 45;
            this.receptReservationDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.receptReservationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.receptReservationDataGridView.Size = new System.Drawing.Size(799, 578);
            this.receptReservationDataGridView.TabIndex = 1;
            this.receptReservationDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.receptReservationDataGridView_CellDoubleClick);
            // 
            // saveFlightBtn
            // 
            this.saveFlightBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.saveFlightBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.saveFlightBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFlightBtn.ForeColor = System.Drawing.Color.Purple;
            this.saveFlightBtn.Image = global::FlightReservationSystem.Properties.Resources.icons8_save_32;
            this.saveFlightBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveFlightBtn.Location = new System.Drawing.Point(345, 63);
            this.saveFlightBtn.Margin = new System.Windows.Forms.Padding(0);
            this.saveFlightBtn.Name = "saveFlightBtn";
            this.saveFlightBtn.Size = new System.Drawing.Size(143, 44);
            this.saveFlightBtn.TabIndex = 5;
            this.saveFlightBtn.Text = "Update Status";
            this.saveFlightBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveFlightBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.saveFlightBtn.UseVisualStyleBackColor = false;
            this.saveFlightBtn.Click += new System.EventHandler(this.saveFlightBtn_Click);
            // 
            // rStatusUpdateCmBx
            // 
            this.rStatusUpdateCmBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rStatusUpdateCmBx.FormattingEnabled = true;
            this.rStatusUpdateCmBx.Items.AddRange(new object[] {
            "Confimed"});
            this.rStatusUpdateCmBx.Location = new System.Drawing.Point(298, 19);
            this.rStatusUpdateCmBx.Margin = new System.Windows.Forms.Padding(0);
            this.rStatusUpdateCmBx.Name = "rStatusUpdateCmBx";
            this.rStatusUpdateCmBx.Size = new System.Drawing.Size(237, 37);
            this.rStatusUpdateCmBx.TabIndex = 4;
            // 
            // ridDataGridViewTextBoxColumn
            // 
            this.ridDataGridViewTextBoxColumn.DataPropertyName = "r_id";
            this.ridDataGridViewTextBoxColumn.HeaderText = "RID";
            this.ridDataGridViewTextBoxColumn.Name = "ridDataGridViewTextBoxColumn";
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "UID";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            // 
            // flightidDataGridViewTextBoxColumn
            // 
            this.flightidDataGridViewTextBoxColumn.DataPropertyName = "flight_id";
            this.flightidDataGridViewTextBoxColumn.HeaderText = "FID";
            this.flightidDataGridViewTextBoxColumn.Name = "flightidDataGridViewTextBoxColumn";
            // 
            // seatidDataGridViewTextBoxColumn
            // 
            this.seatidDataGridViewTextBoxColumn.DataPropertyName = "seat_id";
            this.seatidDataGridViewTextBoxColumn.HeaderText = "seat_id";
            this.seatidDataGridViewTextBoxColumn.Name = "seatidDataGridViewTextBoxColumn";
            this.seatidDataGridViewTextBoxColumn.Visible = false;
            // 
            // seatNoDataGridViewTextBoxColumn
            // 
            this.seatNoDataGridViewTextBoxColumn.DataPropertyName = "seatNo";
            this.seatNoDataGridViewTextBoxColumn.HeaderText = "seatNo";
            this.seatNoDataGridViewTextBoxColumn.Name = "seatNoDataGridViewTextBoxColumn";
            this.seatNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // rStatusDataGridViewTextBoxColumn
            // 
            this.rStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rStatusDataGridViewTextBoxColumn.DataPropertyName = "rStatus";
            this.rStatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.rStatusDataGridViewTextBoxColumn.Name = "rStatusDataGridViewTextBoxColumn";
            // 
            // reservationBindingSource1
            // 
            this.reservationBindingSource1.DataSource = typeof(FlightReservationSystem.Reservation);
            // 
            // ReceptReservationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.saveFlightBtn);
            this.Controls.Add(this.rStatusUpdateCmBx);
            this.Controls.Add(this.receptReservationDataGridView);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ReceptReservationsControl";
            this.Size = new System.Drawing.Size(1021, 649);
            this.Load += new System.EventHandler(this.ReceptReservationsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.receptReservationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView receptReservationDataGridView;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private System.Windows.Forms.Button saveFlightBtn;
        private System.Windows.Forms.ComboBox rStatusUpdateCmBx;
        private System.Windows.Forms.BindingSource reservationBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rStatusDataGridViewTextBoxColumn;

    }
}
