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
    public partial class ProfileControl : UserControl
    {
        public ProfileControl()
        {
            InitializeComponent();
        }

        private void ProfileControl_Load(object sender, EventArgs e)
        {
            profileUserNameTxtBx.Text = LoginControl.UsrName;   
            profileUserEmailTxtBx.Text = LoginControl.UsrEmail;
            profileUserTelTxtBx.Text = LoginControl.UsrTel;
            profileUserPassIDTxtBx.Text = LoginControl.UsrPassID;
            profileUserRoleTxtBx.Text = LoginControl.UsrRole;
            profileUserRoleTxtBx.Hide();
            roleLbl.Hide();

            if (!DesignMode)
            {
                if (LoginControl.UsrRole == "Admin" || LoginControl.UsrRole == "Recept")
                {
                    profileUserRoleTxtBx.Show();
                    roleLbl.Show();

                }
          
                
            }
           


        }
    }
}
