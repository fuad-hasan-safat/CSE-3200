using AustOldBook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bool flag = true;
            AustOldBookDBEntities4 odb = new AustOldBookDBEntities4();
            /*foreach(var _lg in odb.LogInChecks)
            {
                if (_lg.isLogIn.Equals("on"))
                {
                    LoginInformation.loginUserId = _lg.userId;
                    flag = false;

                    Home hm = new Home();
                    hm.Show();
                    this.Hide();
                    break;

                }
            }*/

            /* if(flag)
             {*/
            LogIn lg = new LogIn();
                lg.Show();
                this.Hide();
           /* }*/
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            this.Hide();
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panal.Width += 20;
            if (panal.Width >= 890)
            {
                timer1.Stop();
                LogIn lg = new LogIn();
                lg.Show();
                this.Hide();
            }
        }
    }
}
