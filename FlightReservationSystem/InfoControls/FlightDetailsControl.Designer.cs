namespace FlightReservationSystem.InfoControls
{
    partial class FlightDetailsControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.IDplnComBx = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pilotTxtBx = new System.Windows.Forms.TextBox();
            this.cancelSaveFlightBtn = new System.Windows.Forms.Button();
            this.saveFlightBtn = new System.Windows.Forms.Button();
            this.delFlightBtn = new System.Windows.Forms.Button();
            this.flightTypeComBx = new System.Windows.Forms.ComboBox();
            this.statusComBx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flightDtTmPic = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(22, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Plane ID";
            // 
            // IDplnComBx
            // 
            this.IDplnComBx.BackColor = System.Drawing.SystemColors.Control;
            this.IDplnComBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.IDplnComBx.FormattingEnabled = true;
            this.IDplnComBx.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.IDplnComBx.Location = new System.Drawing.Point(79, 159);
            this.IDplnComBx.Name = "IDplnComBx";
            this.IDplnComBx.Size = new System.Drawing.Size(142, 60);
            this.IDplnComBx.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(22, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(22, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Pilot";
            // 
            // pilotTxtBx
            // 
            this.pilotTxtBx.BackColor = System.Drawing.SystemColors.Control;
            this.pilotTxtBx.Location = new System.Drawing.Point(79, 222);
            this.pilotTxtBx.Multiline = true;
            this.pilotTxtBx.Name = "pilotTxtBx";
            this.pilotTxtBx.Size = new System.Drawing.Size(142, 31);
            this.pilotTxtBx.TabIndex = 12;
            // 
            // cancelSaveFlightBtn
            // 
            this.cancelSaveFlightBtn.BackColor = System.Drawing.Color.Ivory;
            this.cancelSaveFlightBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cancelSaveFlightBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelSaveFlightBtn.ForeColor = System.Drawing.Color.Purple;
            this.cancelSaveFlightBtn.Image = global::FlightReservationSystem.Properties.Resources.icons8_delete_sign_16;
            this.cancelSaveFlightBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelSaveFlightBtn.Location = new System.Drawing.Point(109, 258);
            this.cancelSaveFlightBtn.Margin = new System.Windows.Forms.Padding(0);
            this.cancelSaveFlightBtn.Name = "cancelSaveFlightBtn";
            this.cancelSaveFlightBtn.Size = new System.Drawing.Size(87, 27);
            this.cancelSaveFlightBtn.TabIndex = 18;
            this.cancelSaveFlightBtn.Text = "Cancel";
            this.cancelSaveFlightBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelSaveFlightBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cancelSaveFlightBtn.UseVisualStyleBackColor = false;
            // 
            // saveFlightBtn
            // 
            this.saveFlightBtn.BackColor = System.Drawing.Color.Ivory;
            this.saveFlightBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.saveFlightBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFlightBtn.ForeColor = System.Drawing.Color.Purple;
            this.saveFlightBtn.Image = global::FlightReservationSystem.Properties.Resources.icons8_save_16;
            this.saveFlightBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveFlightBtn.Location = new System.Drawing.Point(22, 258);
            this.saveFlightBtn.Margin = new System.Windows.Forms.Padding(0);
            this.saveFlightBtn.Name = "saveFlightBtn";
            this.saveFlightBtn.Size = new System.Drawing.Size(87, 27);
            this.saveFlightBtn.TabIndex = 16;
            this.saveFlightBtn.Text = "Save Flight";
            this.saveFlightBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveFlightBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.saveFlightBtn.UseVisualStyleBackColor = false;
            // 
            // delFlightBtn
            // 
            this.delFlightBtn.BackColor = System.Drawing.Color.Ivory;
            this.delFlightBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.delFlightBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delFlightBtn.ForeColor = System.Drawing.Color.Purple;
            this.delFlightBtn.Image = global::FlightReservationSystem.Properties.Resources.icons8_deletec_16;
            this.delFlightBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.delFlightBtn.Location = new System.Drawing.Point(196, 258);
            this.delFlightBtn.Margin = new System.Windows.Forms.Padding(0);
            this.delFlightBtn.Name = "delFlightBtn";
            this.delFlightBtn.Size = new System.Drawing.Size(87, 27);
            this.delFlightBtn.TabIndex = 17;
            this.delFlightBtn.Text = "Delete Flight";
            this.delFlightBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.delFlightBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.delFlightBtn.UseVisualStyleBackColor = false;
            // 
            // flightTypeComBx
            // 
            this.flightTypeComBx.BackColor = System.Drawing.SystemColors.Control;
            this.flightTypeComBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.flightTypeComBx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flightTypeComBx.FormattingEnabled = true;
            this.flightTypeComBx.Items.AddRange(new object[] {
            "Domestic",
            "International"});
            this.flightTypeComBx.Location = new System.Drawing.Point(79, 96);
            this.flightTypeComBx.Margin = new System.Windows.Forms.Padding(0);
            this.flightTypeComBx.Name = "flightTypeComBx";
            this.flightTypeComBx.Size = new System.Drawing.Size(142, 60);
            this.flightTypeComBx.TabIndex = 11;
            // 
            // statusComBx
            // 
            this.statusComBx.BackColor = System.Drawing.SystemColors.Control;
            this.statusComBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.statusComBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusComBx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statusComBx.FormattingEnabled = true;
            this.statusComBx.Items.AddRange(new object[] {
            "Active ",
            "Suspened"});
            this.statusComBx.Location = new System.Drawing.Point(79, 33);
            this.statusComBx.Margin = new System.Windows.Forms.Padding(0);
            this.statusComBx.Name = "statusComBx";
            this.statusComBx.Size = new System.Drawing.Size(142, 60);
            this.statusComBx.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(22, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(22, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Time";
            // 
            // flightDtTmPic
            // 
            this.flightDtTmPic.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.flightDtTmPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightDtTmPic.Location = new System.Drawing.Point(79, 7);
            this.flightDtTmPic.Margin = new System.Windows.Forms.Padding(0);
            this.flightDtTmPic.Name = "flightDtTmPic";
            this.flightDtTmPic.Size = new System.Drawing.Size(204, 20);
            this.flightDtTmPic.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.flightDtTmPic);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.statusComBx);
            this.panel1.Controls.Add(this.flightTypeComBx);
            this.panel1.Controls.Add(this.delFlightBtn);
            this.panel1.Controls.Add(this.saveFlightBtn);
            this.panel1.Controls.Add(this.cancelSaveFlightBtn);
            this.panel1.Controls.Add(this.pilotTxtBx);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.IDplnComBx);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 295);
            this.panel1.TabIndex = 19;
            // 
            // FlightDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "FlightDetailsControl";
            this.Size = new System.Drawing.Size(326, 325);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox IDplnComBx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pilotTxtBx;
        private System.Windows.Forms.Button cancelSaveFlightBtn;
        private System.Windows.Forms.Button saveFlightBtn;
        private System.Windows.Forms.Button delFlightBtn;
        private System.Windows.Forms.ComboBox flightTypeComBx;
        private System.Windows.Forms.ComboBox statusComBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker flightDtTmPic;
        private System.Windows.Forms.Panel panel1;

    }
}
