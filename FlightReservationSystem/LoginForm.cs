using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace FlightReservationSystem
{
    public partial class LoginForm : Form
    {
        

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nwidthEllipse,
            int nHeightEllipse

    );
        public LoginForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            
        }

      

        // form buttons

        private void xCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void xCloseBtn_MouseEnter(object sender, EventArgs e)
        {
            xCloseBtn.BackColor = System.Drawing.Color.Red;
            xCloseBtn.ForeColor = System.Drawing.Color.White;
        }

        private void xCloseBtn_MouseLeave(object sender, EventArgs e)
        {
            xCloseBtn.BackColor = System.Drawing.Color.Transparent;
            xCloseBtn.ForeColor = System.Drawing.SystemColors.ControlText;
        }



        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void minBtn_MouseEnter(object sender, EventArgs e)
        {
            minBtn.BackColor = System.Drawing.Color.White;
            minBtn.ForeColor = System.Drawing.Color.Black;

        }

        private void minBtn_MouseLeave(object sender, EventArgs e)
        {

            minBtn.BackColor = System.Drawing.Color.Transparent;
            minBtn.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void pane4_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void pane4_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 450;
                mouseY = MousePosition.Y - 20;
                SetDesktopLocation(mouseX, mouseY);
            }

        }

        private void pane4_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void regLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            createAccountControl.Visible=true;
            regLinkLbl.Visible = false;
            loginControl.Visible=false;
            loginLinkLbl.Visible = true;        
        }

        private void loginLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            loginControl.Visible=true;
            regLinkLbl.Visible = true;
            createAccountControl.Visible = false;
            loginLinkLbl.Visible = false;
            
        }


      
    
       


    }
}
