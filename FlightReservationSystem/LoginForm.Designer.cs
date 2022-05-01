namespace FlightReservationSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.xCloseBtn = new System.Windows.Forms.Button();
            this.minBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.uPassLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginLinkLbl = new System.Windows.Forms.LinkLabel();
            this.regLinkLbl = new System.Windows.Forms.LinkLabel();
            this.createAccountControl = new FlightReservationSystem.CreateAccountControl();
            this.loginControl = new FlightReservationSystem.LoginControl();
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // xCloseBtn
            // 
            this.xCloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.xCloseBtn.FlatAppearance.BorderSize = 0;
            this.xCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xCloseBtn.Location = new System.Drawing.Point(430, 0);
            this.xCloseBtn.Name = "xCloseBtn";
            this.xCloseBtn.Size = new System.Drawing.Size(43, 27);
            this.xCloseBtn.TabIndex = 1;
            this.xCloseBtn.Text = "X";
            this.xCloseBtn.UseVisualStyleBackColor = false;
            this.xCloseBtn.Click += new System.EventHandler(this.xCloseBtn_Click);
            this.xCloseBtn.MouseEnter += new System.EventHandler(this.xCloseBtn_MouseEnter);
            this.xCloseBtn.MouseLeave += new System.EventHandler(this.xCloseBtn_MouseLeave);
            // 
            // minBtn
            // 
            this.minBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBtn.BackColor = System.Drawing.Color.Transparent;
            this.minBtn.FlatAppearance.BorderSize = 0;
            this.minBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBtn.Location = new System.Drawing.Point(387, 0);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(43, 27);
            this.minBtn.TabIndex = 1;
            this.minBtn.Text = "---";
            this.minBtn.UseVisualStyleBackColor = false;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            this.minBtn.MouseEnter += new System.EventHandler(this.minBtn_MouseEnter);
            this.minBtn.MouseLeave += new System.EventHandler(this.minBtn_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.uPassLbl);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.userNameLbl);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(172, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 237);
            this.panel1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // uPassLbl
            // 
            this.uPassLbl.AutoSize = true;
            this.uPassLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uPassLbl.Location = new System.Drawing.Point(5, 118);
            this.uPassLbl.Name = "uPassLbl";
            this.uPassLbl.Size = new System.Drawing.Size(78, 20);
            this.uPassLbl.TabIndex = 1;
            this.uPassLbl.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.Location = new System.Drawing.Point(32, 71);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(51, 20);
            this.userNameLbl.TabIndex = 1;
            this.userNameLbl.Text = "Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(81, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(475, 27);
            this.panel4.TabIndex = 5;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pane4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pane4_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pane4_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-41, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-41, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "---";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 560);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 17);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.BackgroundImage = global::FlightReservationSystem.Properties.Resources.airplane_take_off_off1080px__2_;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.loginLinkLbl);
            this.panel2.Controls.Add(this.regLinkLbl);
            this.panel2.Controls.Add(this.createAccountControl);
            this.panel2.Controls.Add(this.loginControl);
            this.panel2.Location = new System.Drawing.Point(172, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 505);
            this.panel2.TabIndex = 3;
            // 
            // loginLinkLbl
            // 
            this.loginLinkLbl.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.loginLinkLbl.AutoSize = true;
            this.loginLinkLbl.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLinkLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.loginLinkLbl.LinkColor = System.Drawing.Color.DarkBlue;
            this.loginLinkLbl.Location = new System.Drawing.Point(99, 483);
            this.loginLinkLbl.Margin = new System.Windows.Forms.Padding(0);
            this.loginLinkLbl.Name = "loginLinkLbl";
            this.loginLinkLbl.Size = new System.Drawing.Size(44, 17);
            this.loginLinkLbl.TabIndex = 5;
            this.loginLinkLbl.TabStop = true;
            this.loginLinkLbl.Text = "Login?";
            this.loginLinkLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginLinkLbl.Visible = false;
            this.loginLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLinkLbl_LinkClicked);
            // 
            // regLinkLbl
            // 
            this.regLinkLbl.ActiveLinkColor = System.Drawing.Color.CornflowerBlue;
            this.regLinkLbl.AutoSize = true;
            this.regLinkLbl.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLinkLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.regLinkLbl.LinkColor = System.Drawing.Color.DarkBlue;
            this.regLinkLbl.Location = new System.Drawing.Point(48, 483);
            this.regLinkLbl.Margin = new System.Windows.Forms.Padding(0);
            this.regLinkLbl.Name = "regLinkLbl";
            this.regLinkLbl.Size = new System.Drawing.Size(156, 17);
            this.regLinkLbl.TabIndex = 4;
            this.regLinkLbl.TabStop = true;
            this.regLinkLbl.Text = "You dont have an account?";
            this.regLinkLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.regLinkLbl_LinkClicked);
            // 
            // createAccountControl
            // 
            this.createAccountControl.BackColor = System.Drawing.Color.Transparent;
            this.createAccountControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createAccountControl.Location = new System.Drawing.Point(0, 0);
            this.createAccountControl.Name = "createAccountControl";
            this.createAccountControl.Size = new System.Drawing.Size(237, 505);
            this.createAccountControl.TabIndex = 2;
            this.createAccountControl.Visible = false;
            // 
            // loginControl
            // 
            this.loginControl.BackColor = System.Drawing.Color.Transparent;
            this.loginControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginControl.Location = new System.Drawing.Point(0, 0);
            this.loginControl.Name = "loginControl";
            this.loginControl.Size = new System.Drawing.Size(237, 505);
            this.loginControl.TabIndex = 0;
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginPictureBox.ErrorImage = null;
            this.loginPictureBox.Image = global::FlightReservationSystem.Properties.Resources.airplane_take_off_1080px;
            this.loginPictureBox.InitialImage = null;
            this.loginPictureBox.Location = new System.Drawing.Point(0, 0);
            this.loginPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(475, 577);
            this.loginPictureBox.TabIndex = 4;
            this.loginPictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 577);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.minBtn);
            this.Controls.Add(this.xCloseBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.loginPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button xCloseBtn;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label uPassLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private LoginControl loginControl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox loginPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private CreateAccountControl createAccountControl;
        private System.Windows.Forms.LinkLabel regLinkLbl;
        private System.Windows.Forms.LinkLabel loginLinkLbl;
    }
}