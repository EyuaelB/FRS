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
    public partial class AdminForm : Form
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
       
        public AdminForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            //for entering directly with program.cs
            if (LoginControl.UsrName != null)
            {
                int a = LoginControl.UsrName.IndexOf(" ");
                if (a >-1)
               {
                frmLbl.Text = "Welcome, " + LoginControl.UsrName.Remove(a);                    
               }
                else
                {
                    frmLbl.Text = "Welcome, " + LoginControl.UsrName;

                }
            }
        }


        //Dashboard Buttons

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            searchTxtBox.Hide();
            searchBtn.Hide();

            frmLbl.Text = "Dashboard";
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(138, 180, 248);

           
            this.adminDashboardControl.Show();
            this.adminReservationsControl.Hide();
            this.adminFlightsControl.Hide();
            this.profileControl.Hide();
            this.adminUsersControl.Hide();
            this.planesControl.Hide();
           
            
        }
        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            
            btnDashboard.BackColor = System.Drawing.SystemColors.ControlLight;
            searchTxtBox.Show();
            searchBtn.Show();
          //  this.adminDashboardControl.Hide();
        }

        private void btnFlights_Click(object sender, EventArgs e)
        {
          

            
            this.adminFlightsControl.Show();
            this.adminDashboardControl.Hide();
            this.adminReservationsControl.Hide();
            this.profileControl.Hide();
            this.adminUsersControl.Hide();
            this.planesControl.Hide();
          
           


            frmLbl.Text = "Flights";
            pnlNav.Height = btnFlights.Height;
            pnlNav.Top = btnFlights.Top;
            btnFlights.BackColor = Color.FromArgb(138, 180, 248);
        }

        private void btnFlights_Leave(object sender, EventArgs e)
        {
            btnFlights.BackColor = System.Drawing.SystemColors.ControlLight;
           // this.adminFlightsControl.Hide();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {

            this.adminReservationsControl.Show();
            this.adminDashboardControl.Hide();
            this.adminFlightsControl.Hide();
            this.profileControl.Hide();
            this.adminUsersControl.Hide();
            this.planesControl.Hide();

            

            frmLbl.Text = "Reservations";
            pnlNav.Height = btnReservations.Height;
            pnlNav.Top = btnReservations.Top;
            btnReservations.BackColor = Color.FromArgb(138, 180, 248);
        }

        private void btnReservations_Leave(object sender, EventArgs e)
        {
            btnReservations.BackColor = System.Drawing.SystemColors.ControlLight;
          //  this.adminReservationsControl.Hide();

        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            this.planesControl.Visible = true;
            this.adminReservationsControl.Hide();           
            this.adminDashboardControl.Hide();
            this.adminFlightsControl.Hide();
            this.profileControl.Hide();
            this.adminUsersControl.Hide();

            frmLbl.Text = "Planes";
            pnlNav.Height = btnPlanes.Height;
            pnlNav.Top = btnPlanes.Top;
            btnPlanes.BackColor = Color.FromArgb(138, 180, 248);

        }

        private void btnPlanes_Leave(object sender, EventArgs e)
        {
            btnPlanes.BackColor = System.Drawing.SystemColors.ControlLight;

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmLbl.Text = "Users";
            pnlNav.Height = btnUsers.Height;
            pnlNav.Top = btnUsers.Top;
            btnUsers.BackColor = Color.FromArgb(138, 180, 248);

            this.adminUsersControl.Show();
            this.adminReservationsControl.Hide();
            this.adminDashboardControl.Hide();
            this.adminFlightsControl.Hide();
            this.profileControl.Hide();

        }
        private void btnUsers_Leave(object sender, EventArgs e)
        {
            btnUsers.BackColor = System.Drawing.SystemColors.ControlLight;

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

        private void adminTopPnl_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void adminTopPnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X-450;
                mouseY = MousePosition.Y-20;
                SetDesktopLocation(mouseX, mouseY);
            }

        }

        private void adminTopPnl_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }






        private void adminFlightsForm_Load(object sender, EventArgs e)
        {

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

      

        private void sessionPnl_MouseLeave(object sender, EventArgs e)
        {
            this.sessionPnl.Visible = false;
        }

        private void sessionPnl_MouseEnter(object sender, EventArgs e)
        {
            this.sessionPnl.Visible = true;
        }

        private void dropSession_MouseEnter(object sender, EventArgs e)
        {
            this.sessionPnl.Show();
        }

        private void sessionPnl_MouseHover(object sender, EventArgs e)
        {
            this.sessionPnl.Show();

        }

        private void adminReservationsControl_Load(object sender, EventArgs e)
        {
            this.adminReservationsControl.Hide();
        }

  

     



      


      


       









    }
}
