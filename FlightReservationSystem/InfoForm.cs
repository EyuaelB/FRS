using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FlightReservationSystem
{
    public partial class InfoForm : Form
    {
        Reservation newRes = new Reservation();
        const string BirrFormat = "{0:###,###} .00 ETB";
        public static string SelectedSeatP { get; set; }


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

        public InfoForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }





        // form buttons

        private void xCloseBtn_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
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
                mouseX = MousePosition.X - 250;
                mouseY = MousePosition.Y - 20;
                SetDesktopLocation(mouseX, mouseY);
            }

        }

        private void adminTopPnl_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        private void boookBtn_Click(object sender, EventArgs e)
        {
            if (seatOptComboBx.SelectedItem !=null)
            {

                using (FrsEntities Db = new FrsEntities())
                {
                    User usr = Db.Users.FirstOrDefault(u => u.u_name == LoginControl.UsrName && u.pwd == LoginControl.UsrPwd);

                    int xtractFID = Convert.ToInt32(this.detailFlightPlaneTxtBx.Text);
                    Flight flight = Db.Flights.FirstOrDefault(f => f.f_id == xtractFID);

                    string xtractSID = this.seatOptComboBx.SelectedItem.ToString();
                    Seat seat = Db.Seats.FirstOrDefault(s => s.seatType == xtractSID);


                    newRes.BookFlight(usr, flight, seat);

                    Db.Reservations.Add(newRes);
                    Db.SaveChanges();
                    MessageBox.Show("Flight Has Been Booked");

                }
            }
            else 
            {
                MessageBox.Show("Please Choose A Seat"); 
            }
          
            }

        private void seatOptComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (seatOptComboBx.SelectedItem.ToString())
            {
                case "Economic":
                    seatPriceTxtBx.Text = "20000";
                    break;

                case "PremiumEconomic":
                    seatPriceTxtBx.Text = "30000";
                    break;

                case "Business":
                    seatPriceTxtBx.Text = "40000";
                    break;

                case "FirstClass":
                    seatPriceTxtBx.Text = "60000";
                    break;

                default:
                    seatPriceTxtBx.Text = "";
                    break;
                    
            }

            SelectedSeatP = seatPriceTxtBx.Text;
           seatPriceTxtBx.Text = string.Format(BirrFormat, SelectedSeatP).ToString();

            if (seatOptComboBx.SelectedItem!=null)
            {
                totalFlightPrice.Text = Convert.ToString(Convert.ToInt32(SelectedSeatP) + Convert.ToInt32(PassFlightsControl.SelectedFlightP));
                    
            }
        }
    }
}

