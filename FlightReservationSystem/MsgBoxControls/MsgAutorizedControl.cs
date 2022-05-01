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
    public partial class MsgAuthorizedControl : UserControl
    {
        public MsgAuthorizedControl()
        {
            InitializeComponent();
        }

        private void msgCloseBtn_MouseEnter(object sender, EventArgs e)
        {
            msgCloseBtn.BackColor = System.Drawing.Color.Coral;
        }

        private void msgCloseBtn_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void msgCloseBtn_MouseLeave(object sender, EventArgs e)
        {
            msgCloseBtn.BackColor = System.Drawing.SystemColors.Control;
        }

       

      

   
    }
}
