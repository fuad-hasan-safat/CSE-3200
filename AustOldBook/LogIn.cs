using Start;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AustOldBook
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            AustOldBookDBEntities4 odb = new AustOldBookDBEntities4();
            bool flag = false;

            foreach (var user in odb.UserInfoes)
            {
                if (user.userId == userIdfield.Text && user.ppassword == passwordField.Text)
                {
                    LoginInformation.loginUserId = user.userId;
                    flag = true;

                    // logInCheckEnable(user);

                    Home hm = new Home();
                    hm.Show();
                    this.Hide();
                }

            }
            if (!flag)
            {
                MessageBox.Show("Wrong user id or pass Try again");
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            this.Hide();
        }
    }
}
