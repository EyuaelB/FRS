using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace FlightReservationSystem
{
    public partial class PassReservationsControl : UserControl
    {
        Reservation newRes = new Reservation();
        public PassReservationsControl()
        {
            InitializeComponent();
        }

        void FillDataGridView()
        {
            //using (FrsEntities Db = new FrsEntities())
            //{
            //    User usr = Db.Users.FirstOrDefault(u => u.u_name == LoginControl.UsrName && u.pwd == LoginControl.UsrPwd);
            //    passResDataGridView.DataSource = Db.Reservations.Where(r => r.user_id == usr.u_id).ToList<Reservation>();
            //}
        }

        private void PassReservationsControl_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                FillDataGridView();
            }
        }

        private void passResDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void passResDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = Convert.ToInt32(passResDataGridView.CurrentRow.Cells["ridDataGridViewTextBoxColumn"].Value);
                using (FrsEntities Db = new FrsEntities())
                {
                    //newRes = Db.Reservatiions.Where(x => x.f_id == rowID).FirstOrDefault();
                    this.newRes = Db.Reservations.Where(x => x.r_id== rowID).FirstOrDefault();
                    rStatusUpdateCmBx.Text = newRes.rStatus.ToString();
                    //flightDtTmPic.Value = (DateTime)newFlight.flightTime;
                    //flightTypeComBx.Text = newFlight.flightType;
                    //statusComBx.Text = newFlight.flightStatus;
                    //IDplnComBx.Text = newFlight.plane_id.ToString();
                    //pilotTxtBx.Text = newFlight.flightPilot;
                    //departureComBx.Text = newFlight.departure;
                    //destComBx.Text = newFlight.destination;
                    //flightPriceTxtBx.Text = newFlight.flightPrice.ToString();

                    //flightPriceTxtBx.Text = string.Format(BirrFormat,newFlight.flightPrice.ToString());
                }
        }

        private void saveFlightBtn_Click(object sender, EventArgs e)
        { 
            if (rStatusUpdateCmBx.Text != null)
            {
                using (FrsEntities Db = new FrsEntities())
            {
                    this.newRes.rStatus = rStatusUpdateCmBx.Text; 
                    Db.Entry(newRes).State = EntityState.Modified;
                    Db.SaveChanges();
                    rStatusUpdateCmBx.Text = null; 
                    MessageBox.Show("Reservation Has Been Updated");
                  
               
 
            } 

	}
            

        }

        private void rStatusUpdateCmBx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

