using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FlightReservationSystem.ReceptControls
{
    public partial class ReceptReportControl : UserControl
    {
        public ReceptReportControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(FrsEntities Db = new FrsEntities())
            {
                int flightsCnt =  Db.Flights.Count();
                int reservationsCnt = Db.Reservations.Count();
                List<Reservation> res = Db.Reservations.Where(r=>r.rStatus == "Confirmed").ToList();
                

                 string defaultPath = @"C:\Reports";
            

            if(!Directory.Exists(defaultPath))
            {
                 Directory.CreateDirectory(defaultPath);
            }
            string dN = DateTime.Now.ToString();
            dN = dN.Replace("/", "");
            dN = dN.Replace(":", "");
            dN = dN.Replace(" ", "");

            string reportFilePath = @"C:\Reports\"+dN+"Report.txt";
           
            StreamWriter sw = new StreamWriter(reportFilePath);
            sw.WriteLine("********************Database Report***************\n\n", ContentAlignment.TopCenter);
            sw.WriteLine(DateTime.Now.ToString()+"\n",ContentAlignment.TopCenter);
            sw.WriteLine("Currently There are "+flightsCnt+" Active Flights \n");
            sw.WriteLine("Currently There are "+reservationsCnt+" Active Reservations \n\n");         
            sw.WriteLine("Currently there are "+res.Count()+" confirmed Reservations\n\n\n");          

            sw.WriteLine(""+LoginControl.UsrName+"," + LoginControl.UsrRole+".");

             
               // sw.WriteLine()



            sw.Close();

                
            SaveFileDialog svDlg = new SaveFileDialog();

            svDlg.AddExtension = true;
            svDlg.InitialDirectory = defaultPath;
            svDlg.DefaultExt = "txt";
            svDlg.OverwritePrompt = true;
            svDlg.ShowDialog();








            }


          


        }


       
    }
}
