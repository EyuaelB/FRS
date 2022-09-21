using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlightReservationSystem
{
    
   
    public partial class PassFlightsControl : UserControl
    {
        //const string BirrFormat = "{0}.00 ETB";
        public static string SelectedFlightP { get; set; }
        private static string CurrentFlightPlaneName { get; set; }

             

        public PassFlightsControl()
        {
            InitializeComponent();
        }

        private void PassFlightsControl_Load(object sender, EventArgs e)
        {
            //if (!this.DesignMode)
            //{
            //    FillDataGridView();

            //}
        }

        void FillDataGridView()
        {            
            //using (FrsEntities Db = new FrsEntities())
            //{
            //     passFlightsGridView.DataSource = Db.Flights.ToList<Flight>();                
               
            //}    
        }

     

        private void passFlightsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {         

            if(passFlightsGridView.CurrentRow!=null || passFlightsGridView.CurrentCell!=null)
            {
                InfoForm info = new InfoForm();
                info.Show();

                info.detailFlightDeptTxtBx.Text = passFlightsGridView.Rows[e.RowIndex].Cells["pDgvFlightDeptTxtBx"].Value.ToString();           
                info.detailFlightDestTxtBx.Text= passFlightsGridView.Rows[e.RowIndex].Cells["pDgvFlightDestTxtBx"].Value.ToString();
                info.detailFlightDtTmPicTxtBx.Text = passFlightsGridView.Rows[e.RowIndex].Cells["pDgvFlightTimeTxtBx"].Value.ToString();
                info.detailFlightPilotTxtBx.Text = passFlightsGridView.Rows[e.RowIndex].Cells["pDgvFlightPilotTxtBx"].Value.ToString();
                
               
                info.detailFlightPlaneTxtBx.Text = passFlightsGridView.Rows[e.RowIndex].Cells["pDgvFlightPIDTxtBx"].Value.ToString();        
                
                info.detailFlightStatusTxtBx.Text =passFlightsGridView.Rows[e.RowIndex].Cells["pDgvFlightStatusTxtBx"].Value.ToString();
                info.detailFlightTypeTxtBx.Text =passFlightsGridView.Rows[e.RowIndex].Cells["pDgvFlightTypeTxtBx"].Value.ToString(); 
                
                SelectedFlightP = passFlightsGridView.Rows[e.RowIndex].Cells["pDgvFlightPriceTxtBx"].Value.ToString();
               
              //  info.detailFlightPriceTxtBx.Text = string.Format(BirrFormat,SelectedFlightP).ToString();

                if (passFlightsGridView.Rows[e.RowIndex].Cells["pDgvFlightStatusTxtBx"].Value.ToString()=="Suspened")
                {
                    info.boookBtn.Enabled = false;
                }
            }         
        }

       
        private void passFlightsGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
              //  if ( e.Value.ToString() =="Active")
              //  {
              //      e.CellStyle.BackColor = Color.LightGreen;
              //  }

               // else if ( e.Value.ToString() =="Suspended")
                //{
                 //   e.CellStyle.BackColor = Color.Salmon;
                //} 
                     
        }
    }
}
