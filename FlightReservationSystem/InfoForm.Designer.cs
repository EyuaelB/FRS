namespace FlightReservationSystem
{
    partial class InfoForm
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
            this.adminTopPnl = new System.Windows.Forms.Panel();
            this.minBtn = new System.Windows.Forms.Button();
            this.xCloseBtn = new System.Windows.Forms.Button();
            this.formLbl = new System.Windows.Forms.Label();
            this.detailFlightTypeTxtBx = new System.Windows.Forms.TextBox();
            this.detailFlightStatusTxtBx = new System.Windows.Forms.TextBox();
            this.detailFlightPlaneTxtBx = new System.Windows.Forms.TextBox();
            this.detailFlightPilotTxtBx = new System.Windows.Forms.TextBox();
            this.detailFlightDeptTxtBx = new System.Windows.Forms.TextBox();
            this.detailFlightDestTxtBx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.boookBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.detailFlightDtTmPicTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.seatOptComboBx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.seatPriceTxtBx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.totalFlightPrice = new System.Windows.Forms.TextBox();
            this.detailFlightPriceTxtBx = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.adminTopPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTopPnl
            // 
            this.adminTopPnl.BackColor = System.Drawing.SystemColors.Control;
            this.adminTopPnl.Controls.Add(this.minBtn);
            this.adminTopPnl.Controls.Add(this.xCloseBtn);
            this.adminTopPnl.Controls.Add(this.formLbl);
            this.adminTopPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminTopPnl.Location = new System.Drawing.Point(0, 0);
            this.adminTopPnl.Name = "adminTopPnl";
            this.adminTopPnl.Size = new System.Drawing.Size(689, 32);
            this.adminTopPnl.TabIndex = 2;
            this.adminTopPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.adminTopPnl_MouseDown);
            this.adminTopPnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.adminTopPnl_MouseMove);
            this.adminTopPnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.adminTopPnl_MouseUp);
            // 
            // minBtn
            // 
            this.minBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBtn.BackColor = System.Drawing.Color.Transparent;
            this.minBtn.FlatAppearance.BorderSize = 0;
            this.minBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBtn.Location = new System.Drawing.Point(603, 0);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(43, 27);
            this.minBtn.TabIndex = 1;
            this.minBtn.Text = "---";
            this.minBtn.UseVisualStyleBackColor = false;
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
            this.xCloseBtn.Location = new System.Drawing.Point(646, 0);
            this.xCloseBtn.Name = "xCloseBtn";
            this.xCloseBtn.Size = new System.Drawing.Size(43, 27);
            this.xCloseBtn.TabIndex = 1;
            this.xCloseBtn.Text = "X";
            this.xCloseBtn.UseVisualStyleBackColor = false;
            this.xCloseBtn.Click += new System.EventHandler(this.xCloseBtn_Click);
            this.xCloseBtn.MouseEnter += new System.EventHandler(this.xCloseBtn_MouseEnter);
            this.xCloseBtn.MouseLeave += new System.EventHandler(this.xCloseBtn_MouseLeave);
            this.xCloseBtn.MouseHover += new System.EventHandler(this.xCloseBtn_MouseEnter);
            // 
            // formLbl
            // 
            this.formLbl.AutoSize = true;
            this.formLbl.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLbl.Location = new System.Drawing.Point(8, 4);
            this.formLbl.Name = "formLbl";
            this.formLbl.Size = new System.Drawing.Size(121, 25);
            this.formLbl.TabIndex = 0;
            this.formLbl.Text = "Flight  Details";
            // 
            // detailFlightTypeTxtBx
            // 
            this.detailFlightTypeTxtBx.BackColor = System.Drawing.SystemColors.Control;
            this.detailFlightTypeTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailFlightTypeTxtBx.Location = new System.Drawing.Point(110, 115);
            this.detailFlightTypeTxtBx.Margin = new System.Windows.Forms.Padding(0);
            this.detailFlightTypeTxtBx.Multiline = true;
            this.detailFlightTypeTxtBx.Name = "detailFlightTypeTxtBx";
            this.detailFlightTypeTxtBx.ReadOnly = true;
            this.detailFlightTypeTxtBx.Size = new System.Drawing.Size(210, 33);
            this.detailFlightTypeTxtBx.TabIndex = 4;
            // 
            // detailFlightStatusTxtBx
            // 
            this.detailFlightStatusTxtBx.BackColor = System.Drawing.SystemColors.Control;
            this.detailFlightStatusTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailFlightStatusTxtBx.Location = new System.Drawing.Point(109, 355);
            this.detailFlightStatusTxtBx.Margin = new System.Windows.Forms.Padding(0);
            this.detailFlightStatusTxtBx.Multiline = true;
            this.detailFlightStatusTxtBx.Name = "detailFlightStatusTxtBx";
            this.detailFlightStatusTxtBx.ReadOnly = true;
            this.detailFlightStatusTxtBx.Size = new System.Drawing.Size(151, 33);
            this.detailFlightStatusTxtBx.TabIndex = 5;
            // 
            // detailFlightPlaneTxtBx
            // 
            this.detailFlightPlaneTxtBx.BackColor = System.Drawing.SystemColors.Control;
            this.detailFlightPlaneTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailFlightPlaneTxtBx.Location = new System.Drawing.Point(109, 163);
            this.detailFlightPlaneTxtBx.Margin = new System.Windows.Forms.Padding(0);
            this.detailFlightPlaneTxtBx.Multiline = true;
            this.detailFlightPlaneTxtBx.Name = "detailFlightPlaneTxtBx";
            this.detailFlightPlaneTxtBx.ReadOnly = true;
            this.detailFlightPlaneTxtBx.Size = new System.Drawing.Size(211, 33);
            this.detailFlightPlaneTxtBx.TabIndex = 6;
            // 
            // detailFlightPilotTxtBx
            // 
            this.detailFlightPilotTxtBx.BackColor = System.Drawing.SystemColors.Control;
            this.detailFlightPilotTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailFlightPilotTxtBx.Location = new System.Drawing.Point(109, 307);
            this.detailFlightPilotTxtBx.Margin = new System.Windows.Forms.Padding(0);
            this.detailFlightPilotTxtBx.Multiline = true;
            this.detailFlightPilotTxtBx.Name = "detailFlightPilotTxtBx";
            this.detailFlightPilotTxtBx.ReadOnly = true;
            this.detailFlightPilotTxtBx.Size = new System.Drawing.Size(270, 33);
            this.detailFlightPilotTxtBx.TabIndex = 7;
            // 
            // detailFlightDeptTxtBx
            // 
            this.detailFlightDeptTxtBx.BackColor = System.Drawing.SystemColors.Control;
            this.detailFlightDeptTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailFlightDeptTxtBx.Location = new System.Drawing.Point(109, 211);
            this.detailFlightDeptTxtBx.Margin = new System.Windows.Forms.Padding(0);
            this.detailFlightDeptTxtBx.Multiline = true;
            this.detailFlightDeptTxtBx.Name = "detailFlightDeptTxtBx";
            this.detailFlightDeptTxtBx.ReadOnly = true;
            this.detailFlightDeptTxtBx.Size = new System.Drawing.Size(270, 33);
            this.detailFlightDeptTxtBx.TabIndex = 8;
            // 
            // detailFlightDestTxtBx
            // 
            this.detailFlightDestTxtBx.BackColor = System.Drawing.SystemColors.Control;
            this.detailFlightDestTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailFlightDestTxtBx.Location = new System.Drawing.Point(109, 259);
            this.detailFlightDestTxtBx.Margin = new System.Windows.Forms.Padding(0);
            this.detailFlightDestTxtBx.Multiline = true;
            this.detailFlightDestTxtBx.Name = "detailFlightDestTxtBx";
            this.detailFlightDestTxtBx.ReadOnly = true;
            this.detailFlightDestTxtBx.Size = new System.Drawing.Size(270, 33);
            this.detailFlightDestTxtBx.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(32, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Departure";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(23, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Destination";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(69, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pilot";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(56, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Status";
            // 
            // boookBtn
            // 
            this.boookBtn.BackColor = System.Drawing.Color.IndianRed;
            this.boookBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.boookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boookBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boookBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.boookBtn.Image = global::FlightReservationSystem.Properties.Resources.icons8_reservation2_32;
            this.boookBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boookBtn.Location = new System.Drawing.Point(251, 397);
            this.boookBtn.Margin = new System.Windows.Forms.Padding(0);
            this.boookBtn.Name = "boookBtn";
            this.boookBtn.Size = new System.Drawing.Size(128, 38);
            this.boookBtn.TabIndex = 11;
            this.boookBtn.Text = "Book Flight";
            this.boookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.boookBtn.UseVisualStyleBackColor = false;
            this.boookBtn.Click += new System.EventHandler(this.boookBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 13);
            this.panel1.TabIndex = 3;
            // 
            // detailFlightDtTmPicTxtBx
            // 
            this.detailFlightDtTmPicTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailFlightDtTmPicTxtBx.Location = new System.Drawing.Point(110, 68);
            this.detailFlightDtTmPicTxtBx.Multiline = true;
            this.detailFlightDtTmPicTxtBx.Name = "detailFlightDtTmPicTxtBx";
            this.detailFlightDtTmPicTxtBx.ReadOnly = true;
            this.detailFlightDtTmPicTxtBx.Size = new System.Drawing.Size(270, 33);
            this.detailFlightDtTmPicTxtBx.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(66, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(67, 121);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(61, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Plane";
            // 
            // seatOptComboBx
            // 
            this.seatOptComboBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatOptComboBx.FormattingEnabled = true;
            this.seatOptComboBx.Items.AddRange(new object[] {
            "Economic",
            "PremiumEconomic",
            "Business",
            "FirstClass"});
            this.seatOptComboBx.Location = new System.Drawing.Point(457, 163);
            this.seatOptComboBx.Name = "seatOptComboBx";
            this.seatOptComboBx.Size = new System.Drawing.Size(157, 28);
            this.seatOptComboBx.TabIndex = 14;
            this.seatOptComboBx.SelectedIndexChanged += new System.EventHandler(this.seatOptComboBx_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(490, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Choose Seat";
            // 
            // seatPriceTxtBx
            // 
            this.seatPriceTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatPriceTxtBx.Location = new System.Drawing.Point(427, 211);
            this.seatPriceTxtBx.Multiline = true;
            this.seatPriceTxtBx.Name = "seatPriceTxtBx";
            this.seatPriceTxtBx.ReadOnly = true;
            this.seatPriceTxtBx.Size = new System.Drawing.Size(216, 33);
            this.seatPriceTxtBx.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(591, 211);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "#Seat Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(557, 303);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "#Total Flight Price";
            // 
            // totalFlightPrice
            // 
            this.totalFlightPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFlightPrice.Location = new System.Drawing.Point(427, 307);
            this.totalFlightPrice.Multiline = true;
            this.totalFlightPrice.Name = "totalFlightPrice";
            this.totalFlightPrice.ReadOnly = true;
            this.totalFlightPrice.Size = new System.Drawing.Size(216, 81);
            this.totalFlightPrice.TabIndex = 15;
            // 
            // detailFlightPriceTxtBx
            // 
            this.detailFlightPriceTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailFlightPriceTxtBx.Location = new System.Drawing.Point(427, 68);
            this.detailFlightPriceTxtBx.Multiline = true;
            this.detailFlightPriceTxtBx.Name = "detailFlightPriceTxtBx";
            this.detailFlightPriceTxtBx.ReadOnly = true;
            this.detailFlightPriceTxtBx.Size = new System.Drawing.Size(216, 33);
            this.detailFlightPriceTxtBx.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(585, 63);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "#Flight Price";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(689, 457);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.totalFlightPrice);
            this.Controls.Add(this.detailFlightPriceTxtBx);
            this.Controls.Add(this.seatPriceTxtBx);
            this.Controls.Add(this.seatOptComboBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.detailFlightDtTmPicTxtBx);
            this.Controls.Add(this.boookBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.detailFlightTypeTxtBx);
            this.Controls.Add(this.detailFlightStatusTxtBx);
            this.Controls.Add(this.detailFlightPlaneTxtBx);
            this.Controls.Add(this.detailFlightPilotTxtBx);
            this.Controls.Add(this.detailFlightDeptTxtBx);
            this.Controls.Add(this.detailFlightDestTxtBx);
            this.Controls.Add(this.adminTopPnl);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoForm";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoForm";
            this.adminTopPnl.ResumeLayout(false);
            this.adminTopPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel adminTopPnl;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Button xCloseBtn;
        private System.Windows.Forms.Label formLbl;
        public System.Windows.Forms.TextBox detailFlightTypeTxtBx;
        public System.Windows.Forms.TextBox detailFlightStatusTxtBx;
        public System.Windows.Forms.TextBox detailFlightPlaneTxtBx;
        public System.Windows.Forms.TextBox detailFlightPilotTxtBx;
        public System.Windows.Forms.TextBox detailFlightDeptTxtBx;
        public System.Windows.Forms.TextBox detailFlightDestTxtBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button boookBtn;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox detailFlightDtTmPicTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox seatOptComboBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox seatPriceTxtBx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox totalFlightPrice;
        public System.Windows.Forms.TextBox detailFlightPriceTxtBx;
        private System.Windows.Forms.Label label12;
    }
}