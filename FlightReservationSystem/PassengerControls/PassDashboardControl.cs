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
    public partial class PassDashboardControl : UserControl
    {
        public PassDashboardControl()
        {
            InitializeComponent();
        }




        private void CountersOn()
        {
            if (!DesignMode)
            {
                using (FrsEntities Db = new FrsEntities())
                {
                    List<Reservation> revs = Db.Reservations.Where(r=> r.user_id == LoginControl.UsrId).ToList<Reservation>();
                    reservationCountLbl.Text = revs.Count().ToString();

                }

            }

        }

        private void PassDashboardControl_Load(object sender, EventArgs e)
        {
            CountersOn();
        }
    }
}
