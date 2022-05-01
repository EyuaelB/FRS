namespace FlightReservationSystem
{
    partial class CreateAccountControl
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
            this.createName = new System.Windows.Forms.TextBox();
            this.regBtn = new System.Windows.Forms.Button();
            this.createPwd = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.createTel = new System.Windows.Forms.TextBox();
            this.createEmail = new System.Windows.Forms.TextBox();
            this.createPassId = new System.Windows.Forms.TextBox();
            this.loginLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // createName
            // 
            this.createName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createName.BackColor = System.Drawing.Color.Lavender;
            this.createName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createName.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.createName.Location = new System.Drawing.Point(41, 28);
            this.createName.Margin = new System.Windows.Forms.Padding(0);
            this.createName.Multiline = true;
            this.createName.Name = "createName";
            this.createName.Size = new System.Drawing.Size(154, 30);
            this.createName.TabIndex = 2;
            this.createName.Text = "Full name here.....";
            this.createName.Enter += new System.EventHandler(this.Placeholder_Enter);
            // 
            // regBtn
            // 
            this.regBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.regBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.regBtn.FlatAppearance.BorderSize = 0;
            this.regBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.Location = new System.Drawing.Point(69, 283);
            this.regBtn.Margin = new System.Windows.Forms.Padding(0);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(103, 28);
            this.regBtn.TabIndex = 0;
            this.regBtn.Text = "Register";
            this.regBtn.UseVisualStyleBackColor = false;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // createPwd
            // 
            this.createPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createPwd.BackColor = System.Drawing.Color.Lavender;
            this.createPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createPwd.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPwd.ForeColor = System.Drawing.SystemColors.GrayText;
            this.createPwd.Location = new System.Drawing.Point(41, 79);
            this.createPwd.Margin = new System.Windows.Forms.Padding(0);
            this.createPwd.Multiline = true;
            this.createPwd.Name = "createPwd";
            this.createPwd.Size = new System.Drawing.Size(154, 30);
            this.createPwd.TabIndex = 2;
            this.createPwd.Tag = "";
            this.createPwd.Text = "Password";
            this.createPwd.Enter += new System.EventHandler(this.Placeholder_Enter);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.createName);
            this.panel1.Controls.Add(this.createTel);
            this.panel1.Controls.Add(this.createEmail);
            this.panel1.Controls.Add(this.createPassId);
            this.panel1.Controls.Add(this.createPwd);
            this.panel1.Controls.Add(this.regBtn);
            this.panel1.Location = new System.Drawing.Point(0, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 338);
            this.panel1.TabIndex = 3;
            // 
            // createTel
            // 
            this.createTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createTel.BackColor = System.Drawing.Color.Lavender;
            this.createTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createTel.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.createTel.Location = new System.Drawing.Point(41, 232);
            this.createTel.Margin = new System.Windows.Forms.Padding(0);
            this.createTel.Multiline = true;
            this.createTel.Name = "createTel";
            this.createTel.Size = new System.Drawing.Size(154, 30);
            this.createTel.TabIndex = 2;
            this.createTel.Tag = "";
            this.createTel.Text = "Tel";
            this.createTel.Enter += new System.EventHandler(this.Placeholder_Enter);
            // 
            // createEmail
            // 
            this.createEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createEmail.BackColor = System.Drawing.Color.Lavender;
            this.createEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createEmail.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.createEmail.Location = new System.Drawing.Point(41, 181);
            this.createEmail.Margin = new System.Windows.Forms.Padding(0);
            this.createEmail.Multiline = true;
            this.createEmail.Name = "createEmail";
            this.createEmail.Size = new System.Drawing.Size(154, 30);
            this.createEmail.TabIndex = 2;
            this.createEmail.Tag = "";
            this.createEmail.Text = "Email";
            this.createEmail.Enter += new System.EventHandler(this.Placeholder_Enter);
            // 
            // createPassId
            // 
            this.createPassId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createPassId.BackColor = System.Drawing.Color.Lavender;
            this.createPassId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createPassId.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPassId.ForeColor = System.Drawing.SystemColors.GrayText;
            this.createPassId.Location = new System.Drawing.Point(41, 130);
            this.createPassId.Margin = new System.Windows.Forms.Padding(0);
            this.createPassId.Multiline = true;
            this.createPassId.Name = "createPassId";
            this.createPassId.Size = new System.Drawing.Size(154, 30);
            this.createPassId.TabIndex = 2;
            this.createPassId.Tag = "";
            this.createPassId.Text = "Passport Id";
            this.createPassId.Enter += new System.EventHandler(this.Placeholder_Enter);
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLbl.Location = new System.Drawing.Point(30, 78);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(176, 29);
            this.loginLbl.TabIndex = 6;
            this.loginLbl.Text = "Create Account";
            // 
            // CreateAccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.panel1);
            this.Name = "CreateAccountControl";
            this.Size = new System.Drawing.Size(237, 505);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox createName;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.TextBox createPwd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox createTel;
        private System.Windows.Forms.TextBox createEmail;
        private System.Windows.Forms.TextBox createPassId;
        private System.Windows.Forms.Label loginLbl;
    }
}
