using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace FlightReservationSystem
{

    public partial class LoginControl : UserControl
    {
        public static string UsrName { get; set; }
        public static string UsrPwd { get; set; }
        public static string UsrPassID { get; set; }
        public static string UsrEmail{ get; set; }
        public static string UsrTel { get; set; }
        public static string UsrRole { get; set; }
        public static int UsrId { get; set; }

    public LoginControl()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            //Uncomment these individually to explore UI


            //1)
                var adm = new AdminForm();
                adm.Show();
                this.FindForm().Hide();

            //2)
            //var pass = new PassengerForm();
            //pass.Show();
            //this.FindForm().Hide();

            
            //3)
            //var pass = new ReceptForm();
            //pass.Show();
            //this.FindForm().Hide();

            //4)
            //MsgBoxForm msg = new MsgBoxForm();
            //msg.Show();





            //if (loginNameTxt.Text != null || loginPwdTxt.Text != null)
            //{
            //    UsrName = loginNameTxt.Text;
            //    UsrPwd = loginPwdTxt.Text;

            //}

            //using (FrsEntities f = new FrsEntities())
            //{

            //    User user = f.Users.FirstOrDefault(u => u.u_name == loginNameTxt.Text && u.pwd == loginPwdTxt.Text );
            //    UsrPassID = user.pass_id;
            //    UsrEmail = user.email;
            //    UsrTel = user.tel;
            //    UsrRole = user.role;
            //    UsrId = user.u_id;
            //    if (user != null)                  
            //    {
            //        if (user.u_name == loginNameTxt.Text)
            //        {
            //            if (user.pwd == loginPwdTxt.Text)
            //            {

            //                if (user.role == "Admin")
            //                {
            //                    var adm = new AdminForm();
            //                    adm.Show();
            //                    this.FindForm().Hide();

            //                }
            //                else if (user.role == "Pass")
            //                {

            //                    var pass = new PassengerForm();
            //                    pass.Show();
            //                    this.FindForm().Hide();
            //                }
            //                else if (user.role == "Recept")
            //                {
            //                    var pass = new ReceptForm();
            //                    pass.Show();
            //                    this.FindForm().Hide();
            //                }

            //            }
            //        }
            //        else 
            //        {
            //            MsgBoxForm msg = new MsgBoxForm();
            //            msg.Show();

            //        }
            //    }

            //    else
            //    {
            //        MsgBoxForm msg = new MsgBoxForm();
            //        msg.Show();
            //    }

            //}
        }
        private void Placeholder_Enter(object sender, EventArgs e)
        {
            //loginNameTxt.Text = "";
            var box = sender as TextBox;
            box.Text = "";
            
        }
        private void Placeholder_Leave(object sender, EventArgs e)
        {
            var box = sender as TextBox;
            string a = box.Text;

            if (box.Text == "")
            {
                box.Text = a;
            }
        }


    }
}
