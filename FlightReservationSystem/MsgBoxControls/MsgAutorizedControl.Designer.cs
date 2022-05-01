namespace FlightReservationSystem
{
    partial class MsgAuthorizedControl
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
            this.msgCloseBtn = new System.Windows.Forms.Button();
            this.msgBoxLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msgCloseBtn
            // 
            this.msgCloseBtn.BackColor = System.Drawing.SystemColors.Control;
            this.msgCloseBtn.FlatAppearance.BorderSize = 0;
            this.msgCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.msgCloseBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgCloseBtn.Location = new System.Drawing.Point(124, 86);
            this.msgCloseBtn.Margin = new System.Windows.Forms.Padding(0);
            this.msgCloseBtn.Name = "msgCloseBtn";
            this.msgCloseBtn.Size = new System.Drawing.Size(75, 23);
            this.msgCloseBtn.TabIndex = 1;
            this.msgCloseBtn.Text = "Close";
            this.msgCloseBtn.UseVisualStyleBackColor = false;
            this.msgCloseBtn.Click += new System.EventHandler(this.msgCloseBtn_Click);
            this.msgCloseBtn.MouseEnter += new System.EventHandler(this.msgCloseBtn_MouseEnter);
            this.msgCloseBtn.MouseLeave += new System.EventHandler(this.msgCloseBtn_MouseLeave);
            // 
            // msgBoxLbl
            // 
            this.msgBoxLbl.AutoSize = true;
            this.msgBoxLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBoxLbl.ForeColor = System.Drawing.Color.Coral;
            this.msgBoxLbl.Location = new System.Drawing.Point(107, 30);
            this.msgBoxLbl.Margin = new System.Windows.Forms.Padding(0);
            this.msgBoxLbl.Name = "msgBoxLbl";
            this.msgBoxLbl.Size = new System.Drawing.Size(153, 17);
            this.msgBoxLbl.TabIndex = 0;
            this.msgBoxLbl.Text = "You are not authorized!";
            this.msgBoxLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;            
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlightReservationSystem.Properties.Resources.icons8_erroranotr_32;
            this.pictureBox1.Location = new System.Drawing.Point(62, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MsgAuthorizedControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.msgCloseBtn);
            this.Controls.Add(this.msgBoxLbl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MsgAuthorizedControl";
            this.Size = new System.Drawing.Size(323, 131);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msgBoxLbl;
        private System.Windows.Forms.Button msgCloseBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
