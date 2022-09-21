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
    public partial class AdminReservationsControl : UserControl
    {
        public AdminReservationsControl()
        {
            InitializeComponent();
        }

        void FillDataGrid()
        {
            //    using(FrsEntities Db = new FrsEntities())
            //    {	
            //        adminResGridView.DataSource = Db.Reservations.ToList<Reservation>();
            //    }           
        }



    private void AdminReservationsControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                FillDataGrid();                
            }       
        }

        private void adminResGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           /* 
            if (e.Value != null)
            {
                usrId = (int)adminResGridView.Rows[e.RowIndex].Cells["admResDgvUserIdTxtBx"].Value;

            }
            */

        }


    }
}
