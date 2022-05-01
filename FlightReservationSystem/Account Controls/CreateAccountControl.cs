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
    public partial class CreateAccountControl : UserControl
    {
        //Thread th;
        public CreateAccountControl()
        {
            InitializeComponent();
        }


        private void Placeholder_Enter(object sender, EventArgs e)
        {
            //loginNameTxt.Text = "";
            var box = sender as TextBox;
            string a = box.Text;

            if (box.Text == a)
            {
                box.Text = "";
            }
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            if (this.Controls != null)
            {
                using (var f = new FrsEntities())
                {
                    User newUsr = new User

                    {
                        u_name = createName.Text,
                        email = createEmail.Text,
                        tel = createTel.Text,
                        role = "Pass",
                        pass_id = createPassId.Text,
                        pwd = createPwd.Text
                    };

                    f.Users.Add(newUsr);
                    f.SaveChanges();
                    // th = new Thread(() => Application.Run(new LoginForm()));
                    //th.SetApartmentState(ApartmentState.STA);
                    //th.Start();
                    MessageBox.Show("Registered Successfuly");
                    this.Controls.Clear();
                    // this.ParentForm.Close();
                    this.Hide();


                }
            }
            else {
                MessageBox.Show("Please Enter A Valid Info");

            }
        }
    }
}
    

