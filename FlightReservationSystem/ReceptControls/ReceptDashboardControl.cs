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
    public partial class ReceptDashboardControl : UserControl
    {
        public ReceptDashboardControl()
        {
            InitializeComponent();
        }

        private void CountersOn()
        {
            if (!DesignMode)
            {
                using (FrsEntities Db = new FrsEntities())
                {
                    List<Reservation> revs = Db.Reservations.ToList<Reservation>();
                    totReservationCountLbl.Text = revs.Count().ToString();

                    List<User> usrs = Db.Users.ToList<User>();
                    totUsrCountlbl.Text = usrs.Count().ToString();

                    List<Flight> flights = Db.Flights.ToList<Flight>();
                    totFlightCountLbl.Text = flights.Count().ToString();



                }

            }

        }

        private void ReceptDashboardControl_Load(object sender, EventArgs e)
        {
            CountersOn();
        }

       
  


    }
}
