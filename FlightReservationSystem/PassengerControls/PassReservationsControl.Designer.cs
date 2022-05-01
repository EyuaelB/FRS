namespace FlightReservationSystem
{
    partial class PassReservationsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.passResDataGridView = new System.Windows.Forms.DataGridView();
            this.ridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flight_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rStatusUpdateCmBx = new System.Windows.Forms.ComboBox();
            this.saveFlightBtn = new System.Windows.Forms.Button();
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.passResDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // passResDataGridView
            // 
            this.passResDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.passResDataGridView.AllowUserToAddRows = false;
            this.passResDataGridView.AllowUserToDeleteRows = false;
            this.passResDataGridView.AllowUserToResizeColumns = false;
            this.passResDataGridView.AllowUserToResizeRows = false;
            this.passResDataGridView.AutoGenerateColumns = false;
            this.passResDataGridView.BackgroundColor = System.Drawing.Color.Lavender;
            this.passResDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passResDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.passResDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.passResDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.passResDataGridView.ColumnHeadersHeight = 50;
            this.passResDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.passResDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ridDataGridViewTextBoxColumn,
            this.flight_id,
            this.user_id,
            this.rStatus});
            this.passResDataGridView.DataSource = this.reservationBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.passResDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.passResDataGridView.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.passResDataGridView.Location = new System.Drawing.Point(17, 115);
            this.passResDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.passResDataGridView.Name = "passResDataGridView";
            this.passResDataGridView.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.passResDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.passResDataGridView.RowHeadersVisible = false;
            this.passResDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.passResDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.passResDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(180)))), ((int)(((byte)(248)))));
            this.passResDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.passResDataGridView.RowTemplate.Height = 45;
            this.passResDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.passResDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.passResDataGridView.Size = new System.Drawing.Size(799, 578);
            this.passResDataGridView.TabIndex = 1;
            this.passResDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.passResDataGridView_CellContentClick);
            this.passResDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.passResDataGridView_CellDoubleClick);
            // 
            // ridDataGridViewTextBoxColumn
            // 
            this.ridDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ridDataGridViewTextBoxColumn.DataPropertyName = "r_id";
            this.ridDataGridViewTextBoxColumn.HeaderText = "RID";
            this.ridDataGridViewTextBoxColumn.Name = "ridDataGridViewTextBoxColumn";
            this.ridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flight_id
            // 
            this.flight_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.flight_id.DataPropertyName = "flight_id";
            this.flight_id.HeaderText = "FID";
            this.flight_id.Name = "flight_id";
            this.flight_id.ReadOnly = true;
            // 
            // user_id
            // 
            this.user_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "UID";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            // 
            // rStatus
            // 
            this.rStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rStatus.DataPropertyName = "rStatus";
            this.rStatus.HeaderText = "Status";
            this.rStatus.Name = "rStatus";
            this.rStatus.ReadOnly = true;
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(FlightReservationSystem.Reservation);
            // 
            // rStatusUpdateCmBx
            // 
            this.rStatusUpdateCmBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rStatusUpdateCmBx.FormattingEnabled = true;
            this.rStatusUpdateCmBx.Items.AddRange(new object[] {
            "Active",
            "Canceled"});
            this.rStatusUpdateCmBx.Location = new System.Drawing.Point(298, 19);
            this.rStatusUpdateCmBx.Margin = new System.Windows.Forms.Padding(0);
            this.rStatusUpdateCmBx.Name = "rStatusUpdateCmBx";
            this.rStatusUpdateCmBx.Size = new System.Drawing.Size(237, 37);
            this.rStatusUpdateCmBx.TabIndex = 2;
            this.rStatusUpdateCmBx.SelectedIndexChanged += new System.EventHandler(this.rStatusUpdateCmBx_SelectedIndexChanged);
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
            this.saveFlightBtn.TabIndex = 3;
            this.saveFlightBtn.Text = "Update Status";
            this.saveFlightBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveFlightBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.saveFlightBtn.UseVisualStyleBackColor = false;
            this.saveFlightBtn.Click += new System.EventHandler(this.saveFlightBtn_Click);
            // 
            // flightBindingSource
            // 
            this.flightBindingSource.DataSource = typeof(FlightReservationSystem.Flight);
            // 
            // PassReservationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.saveFlightBtn);
            this.Controls.Add(this.rStatusUpdateCmBx);
            this.Controls.Add(this.passResDataGridView);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PassReservationsControl";
            this.Size = new System.Drawing.Size(1021, 649);
            this.Load += new System.EventHandler(this.PassReservationsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passResDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView passResDataGridView;
        private System.Windows.Forms.BindingSource flightBindingSource;
       // private System.Windows.Forms.DataGridViewTextBoxColumn seatidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flight_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn rStatus;
        private System.Windows.Forms.ComboBox rStatusUpdateCmBx;
        private System.Windows.Forms.Button saveFlightBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

    }
}
