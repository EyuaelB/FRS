using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FlightReservationSystem
{
    public partial class MsgBoxForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nwidthEllipse,
            int nHeightEllipse

    );
        public MsgBoxForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            
        }

      

        // form buttons

        private void msgxCloseBtn_Click(object sender, EventArgs e)
        {
          this.Close();
        }  

        private void msgxCloseBtn_MouseEnter(object sender, EventArgs e)
        {
            msgxCloseBtn.BackColor = System.Drawing.Color.Red;
            msgxCloseBtn.ForeColor = System.Drawing.Color.White;
        }

        private void msgxCloseBtn_MouseLeave(object sender, EventArgs e)
        {
            msgxCloseBtn.BackColor = System.Drawing.Color.Transparent;
            msgxCloseBtn.ForeColor = System.Drawing.SystemColors.ControlText;
        }



        private void msgBoxMinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void msgBoxMinBtn_MouseEnter(object sender, EventArgs e)
        {
            msgBoxMinBtn.BackColor = System.Drawing.Color.White;
            msgBoxMinBtn.ForeColor = System.Drawing.Color.Black;

        }

        private void msgBoxMinBtn_MouseLeave(object sender, EventArgs e)
        {

            msgBoxMinBtn.BackColor = System.Drawing.Color.Transparent;
            msgBoxMinBtn.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void pane4_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void pane4_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 450;
                mouseY = MousePosition.Y - 20;
                SetDesktopLocation(mouseX, mouseY);
            }

        }

        private void pane4_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

     

      

    
       


    }
}
