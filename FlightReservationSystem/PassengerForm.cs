using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.Entity;

namespace FlightReservationSystem
{
    public partial class PassengerForm : Form
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


        public PassengerForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        



        //Dashboard Buttons

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            searchTxtBox.Hide();
            searchBtn.Hide();

            usrFormLbl.Text = "Dashboard";
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(138, 180, 248);
          

            this.passDashboardControl.Show();
            this.passFlightsControl.Hide();
            this.passReservationsControl.Hide();
            this.profileControl.Hide();



        }
        private void btnDashboard_Leave(object sender, EventArgs e)
        {

            btnDashboard.BackColor = System.Drawing.SystemColors.ControlLight;
            searchTxtBox.Show();
            searchBtn.Show();
         
           
           
        }

        private void btnFlights_Click(object sender, EventArgs e)
        {
            this.passFlightsControl.Show();
            this.passReservationsControl.Hide();           
            this.passDashboardControl.Hide();
            this.profileControl.Hide();
        
            this.usrFormLbl.Text = "Flights";
            pnlNav.Height = btnFlights.Height;
            pnlNav.Top = btnFlights.Top;
            btnFlights.BackColor = Color.FromArgb(138, 180, 248);
        }

        private void btnFlights_Leave(object sender, EventArgs e)
        {
            btnFlights.BackColor = System.Drawing.SystemColors.ControlLight;
        
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            this.passReservationsControl.Show();
           this.passFlightsControl.Hide();          
           this.passDashboardControl.Hide();
           this.profileControl.Hide();

            usrFormLbl.Text = "Reservations";
            pnlNav.Height = btnReservations.Height;
            pnlNav.Top = btnReservations.Top;
            btnReservations.BackColor = Color.FromArgb(138, 180, 248);
        }

        private void btnReservations_Leave(object sender, EventArgs e)
        {
            btnReservations.BackColor = System.Drawing.SystemColors.ControlLight;
          

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
            minBtn.BackColor = System.Drawing.Color.Black;
            minBtn.ForeColor = System.Drawing.Color.White;

        }

        private void minBtn_MouseLeave(object sender, EventArgs e)
        {

           minBtn.BackColor = System.Drawing.Color.Transparent;
           minBtn.ForeColor = System.Drawing.SystemColors.ControlText;
        }





        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 450;
                mouseY = MousePosition.Y - 20;
                SetDesktopLocation(mouseX, mouseY);
            }

        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

             private void dropSession_Click(object sender, EventArgs e)
        {
            sessionPnl.Visible = true;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {

            LoginForm logF = new LoginForm();
            logF.Show();
            this.Close();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {

            this.Controls.Clear();
            this.InitializeComponent();

        }

        private void PassengerForm_Load(object sender, EventArgs e)
        {
            if (LoginControl.UsrName != null)
            {
                int a = LoginControl.UsrName.IndexOf(" ");
                if (a > -1)
                {
                    usrFormLbl.Text = "Welcome, " + LoginControl.UsrName.Remove(a);
                }
                else
                {
                    usrFormLbl.Text = "Welcome, " + LoginControl.UsrName;

                }
                
            }
        }



            
    }
}
