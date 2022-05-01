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
    public partial class ReceptFlightsControl : UserControl
    {
        public ReceptFlightsControl()
        {
            InitializeComponent();
        }

        void FillDataGrid()
        {
            using (FrsEntities Db = new FrsEntities())
            {
                ReceptFlghtsGridView.DataSource = Db.Flights.ToList<Flight>();
            }
        }


            

        private void ReceptFlightsControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                FillDataGrid();
            }
        }
           
        


    }
}
