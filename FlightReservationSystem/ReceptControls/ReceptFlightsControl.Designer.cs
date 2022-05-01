namespace FlightReservationSystem
{
    partial class ReceptFlightsControl
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

        #region Component Designer generated code

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
            this.ReceptFlghtsGridView = new System.Windows.Forms.DataGridView();
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightPilotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ReceptFlghtsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReceptFlghtsGridView
            // 
            this.ReceptFlghtsGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.ReceptFlghtsGridView.AllowUserToOrderColumns = true;
            this.ReceptFlghtsGridView.AutoGenerateColumns = false;
            this.ReceptFlghtsGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.ReceptFlghtsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReceptFlghtsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReceptFlghtsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ReceptFlghtsGridView.ColumnHeadersHeight = 50;
            this.ReceptFlghtsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ReceptFlghtsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fidDataGridViewTextBoxColumn,
            this.flightTimeDataGridViewTextBoxColumn,
            this.flightPilotDataGridViewTextBoxColumn,
            this.flightTypeDataGridViewTextBoxColumn,
            this.planeidDataGridViewTextBoxColumn,
            this.departureDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.flightPriceDataGridViewTextBoxColumn,
            this.flightStatusDataGridViewTextBoxColumn});
            this.ReceptFlghtsGridView.DataSource = this.flightBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReceptFlghtsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ReceptFlghtsGridView.GridColor = System.Drawing.SystemColors.Control;
            this.ReceptFlghtsGridView.Location = new System.Drawing.Point(17, 115);
            this.ReceptFlghtsGridView.Margin = new System.Windows.Forms.Padding(0);
            this.ReceptFlghtsGridView.Name = "ReceptFlghtsGridView";
            this.ReceptFlghtsGridView.RowHeadersVisible = false;
            this.ReceptFlghtsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.ReceptFlghtsGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ReceptFlghtsGridView.RowTemplate.Height = 40;
            this.ReceptFlghtsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReceptFlghtsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReceptFlghtsGridView.Size = new System.Drawing.Size(799, 578);
            this.ReceptFlghtsGridView.TabIndex = 6;
            // 
            // flightBindingSource
            // 
            this.flightBindingSource.DataSource = typeof(FlightReservationSystem.Flight);
            // 
            // fidDataGridViewTextBoxColumn
            // 
            this.fidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.fidDataGridViewTextBoxColumn.DataPropertyName = "f_id";
            this.fidDataGridViewTextBoxColumn.HeaderText = "FID";
            this.fidDataGridViewTextBoxColumn.Name = "fidDataGridViewTextBoxColumn";
            this.fidDataGridViewTextBoxColumn.Width = 66;
            // 
            // flightTimeDataGridViewTextBoxColumn
            // 
            this.flightTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.flightTimeDataGridViewTextBoxColumn.DataPropertyName = "flightTime";
            this.flightTimeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.flightTimeDataGridViewTextBoxColumn.Name = "flightTimeDataGridViewTextBoxColumn";
            // 
            // flightPilotDataGridViewTextBoxColumn
            // 
            this.flightPilotDataGridViewTextBoxColumn.DataPropertyName = "flightPilot";
            this.flightPilotDataGridViewTextBoxColumn.HeaderText = "flightPilot";
            this.flightPilotDataGridViewTextBoxColumn.Name = "flightPilotDataGridViewTextBoxColumn";
            this.flightPilotDataGridViewTextBoxColumn.Visible = false;
            // 
            // flightTypeDataGridViewTextBoxColumn
            // 
            this.flightTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.flightTypeDataGridViewTextBoxColumn.DataPropertyName = "flightType";
            this.flightTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.flightTypeDataGridViewTextBoxColumn.Name = "flightTypeDataGridViewTextBoxColumn";
            this.flightTypeDataGridViewTextBoxColumn.Width = 78;
            // 
            // planeidDataGridViewTextBoxColumn
            // 
            this.planeidDataGridViewTextBoxColumn.DataPropertyName = "plane_id";
            this.planeidDataGridViewTextBoxColumn.HeaderText = "plane_id";
            this.planeidDataGridViewTextBoxColumn.Name = "planeidDataGridViewTextBoxColumn";
            this.planeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // departureDataGridViewTextBoxColumn
            // 
            this.departureDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departureDataGridViewTextBoxColumn.DataPropertyName = "departure";
            this.departureDataGridViewTextBoxColumn.HeaderText = "Departure";
            this.departureDataGridViewTextBoxColumn.Name = "departureDataGridViewTextBoxColumn";
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            // 
            // flightPriceDataGridViewTextBoxColumn
            // 
            this.flightPriceDataGridViewTextBoxColumn.DataPropertyName = "flightPrice";
            this.flightPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.flightPriceDataGridViewTextBoxColumn.Name = "flightPriceDataGridViewTextBoxColumn";
            // 
            // flightStatusDataGridViewTextBoxColumn
            // 
            this.flightStatusDataGridViewTextBoxColumn.DataPropertyName = "flightStatus";
            this.flightStatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.flightStatusDataGridViewTextBoxColumn.Name = "flightStatusDataGridViewTextBoxColumn";
            // 
            // ReceptFlightsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.ReceptFlghtsGridView);
            this.Name = "ReceptFlightsControl";
            this.Size = new System.Drawing.Size(1021, 649);
            this.Load += new System.EventHandler(this.ReceptFlightsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReceptFlghtsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ReceptFlghtsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn fidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightPilotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource flightBindingSource;
    }
}
