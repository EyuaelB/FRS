using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;


namespace FlightReservationSystem
{
    public partial class AdminFlightsControl : UserControl
    {
        Flight newFlight = new Flight();
        //const string BirrFormat = "{000,000}.00 ETB";
      
        public AdminFlightsControl()
        {
            InitializeComponent();
            ClearEntry();        

        }

        public void ClearEntry()
        {
            pilotTxtBx.Text = "";
            flightTypeComBx.Text = "";
            statusComBx.Text = "";
            flightDtTmPic.Value = DateTime.Now;
            IDplnComBx.Text = "";
            destComBx.Text = "";
            departureComBx.Text = "";
            flightPriceTxtBx.Text = "";          

            saveFlightBtn.Text = "Save Flight";
            delFlightBtn.Enabled = false;
        }

        private void saveFlightBtn_Click(object sender, EventArgs e)
        { 
            using (FrsEntities db = new FrsEntities())
            {
                newFlight.flightStatus = statusComBx.Text;
                newFlight.flightTime = flightDtTmPic.Value;
                newFlight.flightPilot = pilotTxtBx.Text;
                newFlight.plane_id = Convert.ToInt32(IDplnComBx.Text);

                newFlight.flightType = flightTypeComBx.Text;
                //newFlight.SetFlightType(a);

                newFlight.destination = destComBx.Text;
                newFlight.departure = departureComBx.Text;
                newFlight.flightPrice = Convert.ToDecimal(flightPriceTxtBx.Text);

                if (newFlight.f_id==0)//Insert(Save)
                {
                    db.Flights.Add(newFlight);  
                }
                else//Update(Update)
                {
                    db.Entry(newFlight).State = EntityState.Modified;
                }                
                db.SaveChanges();
                ClearEntry();
                //FillDataGridView();
                MessageBox.Show("Flight Has Been Added");
            }
        }

        private void cancelSaveFlightBtn_Click(object sender, EventArgs e)
        {
            ClearEntry();
        }

         void FillDataGridView()
        {       
           //using (FrsEntities db = new FrsEntities())
           //{
              
           //    adminFlightsDataGridView.DataSource = db.Flights.ToList<Flight>();

           //}
        
        }


        private void adminFlightsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // InfoForm info = new InfoForm();
            //info.ShowDialog(); 

            if (adminFlightsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                //adminFlightsDataGridView.CurrentRow.Selected = true;
               int rowID = Convert.ToInt32(adminFlightsDataGridView.CurrentRow.Cells["dgvFlightIDTxtBx"].Value);
                using (FrsEntities db = new FrsEntities())
                {
                    newFlight = db.Flights.Where(x => x.f_id == rowID).FirstOrDefault();
                    flightDtTmPic.Value = (DateTime)newFlight.flightTime;
                    flightTypeComBx.Text = newFlight.flightType;
                    statusComBx.Text = newFlight.flightStatus;
                    IDplnComBx.Text = newFlight.plane_id.ToString();
                    pilotTxtBx.Text = newFlight.flightPilot;
                    departureComBx.Text = newFlight.departure;
                    destComBx.Text = newFlight.destination;
                    flightPriceTxtBx.Text = newFlight.flightPrice.ToString();

                    //flightPriceTxtBx.Text = string.Format(BirrFormat,newFlight.flightPrice.ToString());
                }
            }
            saveFlightBtn.Text = "Update";
            this.saveFlightBtn.Image = global::FlightReservationSystem.Properties.Resources.icons8_downloading_updates02_32;
            delFlightBtn.Enabled = true;
        }

        private void AdminFlightsControl_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode) 
            {
                FillDataGridView();
 
            }
        }

        private void adminFlightsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {   /* 
            switch (e.Value.ToString())
            {
                case "Active":
                    e.CellStyle.BackColor = Color.LightGreen;
                    break;

                case "Suspended":
                    e.CellStyle.BackColor = Color.Salmon;
                    break;
            }
              */

            //if (e.Value.ToString()=="Active")
            //{
            //    e.CellStyle.BackColor = Color.LightGreen;

            //}
      
            //if (e.Value.ToString() == "Suspended")
            //{
            //    e.CellStyle.BackColor  = Color.Salmon;
            //}
        }



    }
}
