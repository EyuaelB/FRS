namespace FlightReservationSystem
{
    partial class PassFlightsControl
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
            this.passFlightsGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pDgvFlightTimeTxtBx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDgvFlightPIDTxtBx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDgvFlightTypeTxtBx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDgvFlightDeptTxtBx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDgvFlightDestTxtBx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDgvFlightPriceTxtBx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDgvFlightPilotTxtBx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDgvFlightStatusTxtBx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.passFlightsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // passFlightsGridView
            // 
            this.passFlightsGridView.AllowUserToAddRows = false;
            this.passFlightsGridView.AllowUserToDeleteRows = false;
            this.passFlightsGridView.AllowUserToResizeRows = false;
            this.passFlightsGridView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passFlightsGridView.AutoGenerateColumns = false;
            this.passFlightsGridView.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.passFlightsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passFlightsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.passFlightsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.passFlightsGridView.ColumnHeadersHeight = 50;
            this.passFlightsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.passFlightsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pDgvFlightTimeTxtBx,
            this.pDgvFlightPIDTxtBx,
            this.pDgvFlightTypeTxtBx,
            this.pDgvFlightDeptTxtBx,
            this.pDgvFlightDestTxtBx,
            this.pDgvFlightPriceTxtBx,
            this.pDgvFlightPilotTxtBx,
            this.pDgvFlightStatusTxtBx});
            this.passFlightsGridView.DataSource = this.flightBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.passFlightsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.passFlightsGridView.GridColor = System.Drawing.SystemColors.Control;
            this.passFlightsGridView.Location = new System.Drawing.Point(17, 116);
            this.passFlightsGridView.Margin = new System.Windows.Forms.Padding(0);
            this.passFlightsGridView.MultiSelect = false;
            this.passFlightsGridView.Name = "passFlightsGridView";
            this.passFlightsGridView.RowHeadersVisible = false;
            this.passFlightsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(180)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.passFlightsGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.passFlightsGridView.RowTemplate.Height = 45;
            this.passFlightsGridView.RowTemplate.ReadOnly = true;
            this.passFlightsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.passFlightsGridView.Size = new System.Drawing.Size(799, 533);
            this.passFlightsGridView.TabIndex = 1;
            this.passFlightsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.passFlightsGridView_CellDoubleClick);
            this.passFlightsGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.passFlightsGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Plane";
            this.dataGridViewTextBoxColumn1.HeaderText = "Plane";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // flightBindingSource
            // 
            this.flightBindingSource.DataSource = typeof(FlightReservationSystem.Flight);
            // 
            // pDgvFlightTimeTxtBx
            // 
            this.pDgvFlightTimeTxtBx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pDgvFlightTimeTxtBx.DataPropertyName = "flightTime";
            this.pDgvFlightTimeTxtBx.HeaderText = "Time";
            this.pDgvFlightTimeTxtBx.Name = "pDgvFlightTimeTxtBx";
            this.pDgvFlightTimeTxtBx.ReadOnly = true;
            // 
            // pDgvFlightPIDTxtBx
            // 
            this.pDgvFlightPIDTxtBx.DataPropertyName = "plane_id";
            this.pDgvFlightPIDTxtBx.HeaderText = "PID";
            this.pDgvFlightPIDTxtBx.Name = "pDgvFlightPIDTxtBx";
            this.pDgvFlightPIDTxtBx.Visible = false;
            // 
            // pDgvFlightTypeTxtBx
            // 
            this.pDgvFlightTypeTxtBx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pDgvFlightTypeTxtBx.DataPropertyName = "flightType";
            this.pDgvFlightTypeTxtBx.HeaderText = "Type";
            this.pDgvFlightTypeTxtBx.Name = "pDgvFlightTypeTxtBx";
            this.pDgvFlightTypeTxtBx.ReadOnly = true;
            this.pDgvFlightTypeTxtBx.Width = 78;
            // 
            // pDgvFlightDeptTxtBx
            // 
            this.pDgvFlightDeptTxtBx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pDgvFlightDeptTxtBx.DataPropertyName = "departure";
            this.pDgvFlightDeptTxtBx.HeaderText = "Departure";
            this.pDgvFlightDeptTxtBx.Name = "pDgvFlightDeptTxtBx";
            this.pDgvFlightDeptTxtBx.ReadOnly = true;
            // 
            // pDgvFlightDestTxtBx
            // 
            this.pDgvFlightDestTxtBx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pDgvFlightDestTxtBx.DataPropertyName = "destination";
            this.pDgvFlightDestTxtBx.HeaderText = "Destination";
            this.pDgvFlightDestTxtBx.Name = "pDgvFlightDestTxtBx";
            this.pDgvFlightDestTxtBx.ReadOnly = true;
            // 
            // pDgvFlightPriceTxtBx
            // 
            this.pDgvFlightPriceTxtBx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pDgvFlightPriceTxtBx.DataPropertyName = "flightPrice";
            this.pDgvFlightPriceTxtBx.HeaderText = "Price";
            this.pDgvFlightPriceTxtBx.Name = "pDgvFlightPriceTxtBx";
            this.pDgvFlightPriceTxtBx.Width = 79;
            // 
            // pDgvFlightPilotTxtBx
            // 
            this.pDgvFlightPilotTxtBx.DataPropertyName = "flightPilot";
            this.pDgvFlightPilotTxtBx.HeaderText = "Pilot";
            this.pDgvFlightPilotTxtBx.Name = "pDgvFlightPilotTxtBx";
            this.pDgvFlightPilotTxtBx.ReadOnly = true;
            // 
            // pDgvFlightStatusTxtBx
            // 
            this.pDgvFlightStatusTxtBx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pDgvFlightStatusTxtBx.DataPropertyName = "flightStatus";
            this.pDgvFlightStatusTxtBx.HeaderText = "Status";
            this.pDgvFlightStatusTxtBx.Name = "pDgvFlightStatusTxtBx";
            this.pDgvFlightStatusTxtBx.ReadOnly = true;
            this.pDgvFlightStatusTxtBx.Width = 90;
            // 
            // PassFlightsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.passFlightsGridView);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PassFlightsControl";
            this.Size = new System.Drawing.Size(1021, 649);
            this.Load += new System.EventHandler(this.PassFlightsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passFlightsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView passFlightsGridView;
        private System.Windows.Forms.BindingSource flightBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDgvFlightTimeTxtBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDgvFlightPIDTxtBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDgvFlightTypeTxtBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDgvFlightDeptTxtBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDgvFlightDestTxtBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDgvFlightPriceTxtBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDgvFlightPilotTxtBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDgvFlightStatusTxtBx;

    }
}
