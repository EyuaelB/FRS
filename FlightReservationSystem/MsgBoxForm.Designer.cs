namespace FlightReservationSystem
{
    partial class MsgBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBoxForm));
            this.msgxCloseBtn = new System.Windows.Forms.Button();
            this.msgBoxMinBtn = new System.Windows.Forms.Button();
            this.msgBoxTopPanel = new System.Windows.Forms.Panel();
            this.msgBoxBtmPnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.msgAutorizedControl = new FlightReservationSystem.MsgAuthorizedControl();
            this.msgBoxPicBox = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msgBoxPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // msgxCloseBtn
            // 
            this.msgxCloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.msgxCloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.msgxCloseBtn.FlatAppearance.BorderSize = 0;
            this.msgxCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.msgxCloseBtn.Location = new System.Drawing.Point(302, 0);
            this.msgxCloseBtn.Margin = new System.Windows.Forms.Padding(0);
            this.msgxCloseBtn.Name = "msgxCloseBtn";
            this.msgxCloseBtn.Size = new System.Drawing.Size(43, 27);
            this.msgxCloseBtn.TabIndex = 1;
            this.msgxCloseBtn.Text = "X";
            this.msgxCloseBtn.UseVisualStyleBackColor = false;
            this.msgxCloseBtn.Click += new System.EventHandler(this.msgxCloseBtn_Click);
            this.msgxCloseBtn.MouseEnter += new System.EventHandler(this.msgxCloseBtn_MouseEnter);
            this.msgxCloseBtn.MouseLeave += new System.EventHandler(this.msgxCloseBtn_MouseLeave);
            // 
            // msgBoxMinBtn
            // 
            this.msgBoxMinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.msgBoxMinBtn.BackColor = System.Drawing.Color.Transparent;
            this.msgBoxMinBtn.FlatAppearance.BorderSize = 0;
            this.msgBoxMinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.msgBoxMinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBoxMinBtn.Location = new System.Drawing.Point(259, 0);
            this.msgBoxMinBtn.Margin = new System.Windows.Forms.Padding(0);
            this.msgBoxMinBtn.Name = "msgBoxMinBtn";
            this.msgBoxMinBtn.Size = new System.Drawing.Size(43, 27);
            this.msgBoxMinBtn.TabIndex = 1;
            this.msgBoxMinBtn.Text = "---";
            this.msgBoxMinBtn.UseVisualStyleBackColor = false;
            this.msgBoxMinBtn.Click += new System.EventHandler(this.msgBoxMinBtn_Click);
            this.msgBoxMinBtn.MouseEnter += new System.EventHandler(this.msgBoxMinBtn_MouseEnter);
            this.msgBoxMinBtn.MouseLeave += new System.EventHandler(this.msgBoxMinBtn_MouseLeave);
            // 
            // msgBoxTopPanel
            // 
            this.msgBoxTopPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.msgBoxTopPanel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.msgBoxTopPanel.Location = new System.Drawing.Point(0, 0);
            this.msgBoxTopPanel.Name = "msgBoxTopPanel";
            this.msgBoxTopPanel.Size = new System.Drawing.Size(347, 27);
            this.msgBoxTopPanel.TabIndex = 5;
            this.msgBoxTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pane4_MouseDown);
            this.msgBoxTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pane4_MouseMove);
            this.msgBoxTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pane4_MouseUp);
            // 
            // msgBoxBtmPnl
            // 
            this.msgBoxBtmPnl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.msgBoxBtmPnl.BackColor = System.Drawing.Color.AntiqueWhite;
            this.msgBoxBtmPnl.Location = new System.Drawing.Point(0, 215);
            this.msgBoxBtmPnl.Name = "msgBoxBtmPnl";
            this.msgBoxBtmPnl.Size = new System.Drawing.Size(347, 17);
            this.msgBoxBtmPnl.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.BackgroundImage = global::FlightReservationSystem.Properties.Resources.airplane_take_off_off1080px__2_;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(-69, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 161);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.msgAutorizedControl);
            this.panel1.Location = new System.Drawing.Point(81, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 131);
            this.panel1.TabIndex = 0;
            // 
            // msgAutorizedControl
            // 
            this.msgAutorizedControl.BackColor = System.Drawing.Color.AntiqueWhite;
            this.msgAutorizedControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgAutorizedControl.Location = new System.Drawing.Point(0, 0);
            this.msgAutorizedControl.Margin = new System.Windows.Forms.Padding(0);
            this.msgAutorizedControl.Name = "msgAutorizedControl";
            this.msgAutorizedControl.Size = new System.Drawing.Size(323, 131);
            this.msgAutorizedControl.TabIndex = 0;
            // 
            // msgBoxPicBox
            // 
            this.msgBoxPicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msgBoxPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.msgBoxPicBox.ErrorImage = null;
            this.msgBoxPicBox.Image = global::FlightReservationSystem.Properties.Resources.airplane_take_off_1080px;
            this.msgBoxPicBox.InitialImage = null;
            this.msgBoxPicBox.Location = new System.Drawing.Point(0, 0);
            this.msgBoxPicBox.Margin = new System.Windows.Forms.Padding(0);
            this.msgBoxPicBox.Name = "msgBoxPicBox";
            this.msgBoxPicBox.Size = new System.Drawing.Size(347, 232);
            this.msgBoxPicBox.TabIndex = 4;
            this.msgBoxPicBox.TabStop = false;
            // 
            // MsgBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(347, 232);
            this.Controls.Add(this.msgxCloseBtn);
            this.Controls.Add(this.msgBoxMinBtn);
            this.Controls.Add(this.msgBoxBtmPnl);
            this.Controls.Add(this.msgBoxTopPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.msgBoxPicBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MsgBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msgBoxPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button msgxCloseBtn;
        private System.Windows.Forms.Button msgBoxMinBtn;
        private System.Windows.Forms.Panel msgBoxTopPanel;
        private System.Windows.Forms.PictureBox msgBoxPicBox;
        private System.Windows.Forms.Panel msgBoxBtmPnl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private MsgAuthorizedControl msgAutorizedControl;
    }
}