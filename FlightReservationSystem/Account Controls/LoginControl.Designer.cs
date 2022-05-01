 namespace FlightReservationSystem
{
    partial class LoginControl
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.loginNameTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginPwdTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.BackColor = System.Drawing.Color.Lavender;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox3.Location = new System.Drawing.Point(39, 21);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 30);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Full name here.....";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.BackColor = System.Drawing.Color.Lavender;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox4.Location = new System.Drawing.Point(41, 70);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(154, 30);
            this.textBox4.TabIndex = 4;
            this.textBox4.Tag = "";
            this.textBox4.Text = "Password";
            // 
            // loginNameTxt
            // 
            this.loginNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginNameTxt.BackColor = System.Drawing.Color.Lavender;
            this.loginNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginNameTxt.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginNameTxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.loginNameTxt.Location = new System.Drawing.Point(39, 29);
            this.loginNameTxt.Margin = new System.Windows.Forms.Padding(0);
            this.loginNameTxt.Multiline = true;
            this.loginNameTxt.Name = "loginNameTxt";
            this.loginNameTxt.Size = new System.Drawing.Size(158, 30);
            this.loginNameTxt.TabIndex = 2;
            this.loginNameTxt.Text = "Full name here.....";
            this.loginNameTxt.Enter += new System.EventHandler(this.Placeholder_Enter);
            this.loginNameTxt.Leave += new System.EventHandler(this.Placeholder_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.loginNameTxt);
            this.panel1.Controls.Add(this.loginPwdTxt);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Location = new System.Drawing.Point(0, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 188);
            this.panel1.TabIndex = 4;
            // 
            // loginPwdTxt
            // 
            this.loginPwdTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPwdTxt.BackColor = System.Drawing.Color.Lavender;
            this.loginPwdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginPwdTxt.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPwdTxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.loginPwdTxt.Location = new System.Drawing.Point(41, 80);
            this.loginPwdTxt.Margin = new System.Windows.Forms.Padding(0);
            this.loginPwdTxt.Multiline = true;
            this.loginPwdTxt.Name = "loginPwdTxt";
            this.loginPwdTxt.PasswordChar = '#';
            this.loginPwdTxt.Size = new System.Drawing.Size(154, 30);
            this.loginPwdTxt.TabIndex = 2;
            this.loginPwdTxt.Tag = "";
            this.loginPwdTxt.Text = "Password";
            this.loginPwdTxt.Enter += new System.EventHandler(this.Placeholder_Enter);
            this.loginPwdTxt.Leave += new System.EventHandler(this.Placeholder_Leave);
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(67, 131);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(0);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(103, 28);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLbl.Location = new System.Drawing.Point(82, 78);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(73, 29);
            this.loginLbl.TabIndex = 5;
            this.loginLbl.Text = "Login";
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.panel1);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(237, 505);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
       
      
        private System.Windows.Forms.TextBox loginNameTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox loginPwdTxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label loginLbl;

    }
}
