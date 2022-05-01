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
    public partial class ReceptReservationsControl : UserControl
    {
        Reservation newRes = new Reservation();
        public int rId { get; set; }

        public ReceptReservationsControl()
        {
            InitializeComponent();
        }



        void FillDataGridView()
        {
            using (FrsEntities db = new FrsEntities())
            {
                receptReservationDataGridView.DataSource = db.Reservations.ToList<Reservation>();

            }

        }

        private void ReceptReservationsControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                FillDataGridView();

                
            }
        }
        
        private void receptReservationDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = Convert.ToInt32(receptReservationDataGridView.CurrentRow.Cells["ridDataGridViewTextBoxColumn"].Value);
            using (FrsEntities Db = new FrsEntities())
            {
                this.newRes = Db.Reservations.Where(x => x.r_id == rowID).FirstOrDefault();
                rStatusUpdateCmBx.Text = newRes.rStatus.ToString();
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
                    MessageBox.Show("Reservation Has Been Confirmed");

                }
            }
        }
         
    }

}
