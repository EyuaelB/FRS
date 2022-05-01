using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlightReservationSystem.InfoControls
{
    public partial class FlightDetailControl : UserControl
    {
        //readonly Properties

        public string DetailTime { set { detailFlightDtTmPic.Text = value; }}
        public string DetailDept { set {detailFlightDeptTxtBx.Text = value;}}
        public string DetailDest { set {detailFlightDestTxtBx.Text = value;}}
        public string DetailStatus { set { detailFlightStatusTxtBx.Text = value;}}
        public string DetailPlane { set { detailFlightPlaneTxtBx.Text = value;}}
        public string DetailPilot { set { detailFlightPilotTxtBx.Text = value;}}


        public FlightDetailControl()
        {
            InitializeComponent();
        }

    }
}
