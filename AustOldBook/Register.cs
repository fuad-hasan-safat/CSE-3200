using AustOldBook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start
{
    public partial class Register : Form
    {
        public static bool isEmailValid = false;
        public static bool isUserValid = true;
        public static bool isPhoneValid = false;
        public static bool isPassMatched = false;
        public Register()
        {
            InitializeComponent();
        }

      


       

        private void LoginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
            this.Hide();
        }

       

       

      

        private void submit_Click(object sender, EventArgs e)
        {
            if (checkTermsCondition.Checked)
            {
                var context = new AustOldBook.AustOldBookDBEntities4();

                if (isEmailValid && isPassMatched && isPhoneValid && isUserValid)
                {
                    if (passwordTextedit.Text.Trim() == retypePasswordTextedit.Text.Trim())
                    {
                        var user = new AustOldBook.UserInfo()
                        {
                            firstName = firstNameedit.Text.Trim(),
                            lastName = lastNameEdit.Text.Trim(),
                            userId = userIdTextedit.Text.Trim(),
                            email = emailTextedit.Text.Trim(),
                            phnNumber = phoneNumberTextedit.Text.Trim(),
                            ppassword = passwordTextedit.Text.Trim(),
                            aaddress = addressTexteditedit.Text.Trim()


                        };

                        context.UserInfoes.Add(user);
                        context.SaveChanges();

                        LogIn lg = new LogIn();
                        lg.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Try again");

                    }
                }
                else
                {
                    MessageBox.Show("Enter all field correctly");
                }
            }
            else
            {
                MessageBox.Show("Please accecpt Terms and condition");
            }
        }


       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Terms_Condition tr = new Terms_Condition();
            tr.Show();
            this.Hide();
        }

       

       

        private void retypePasswordTextedit_OnValueChanged(object sender, EventArgs e)
        {
            if (passwordTextedit.Text.Trim() == retypePasswordTextedit.Text.Trim())
            {
                passwordPictureBoxedit.Refresh();
                passwordValidLabeledit.ForeColor = System.Drawing.Color.Green;
                passwordValidLabeledit.Text = "Yes matched";
                isPassMatched = true;


                passwordPictureBoxedit.Image = new Bitmap(AustOldBook.Properties.Resources.check);
                passwordPictureBoxedit.Refresh();
            }
            else
            {
                passwordValidLabeledit.ForeColor = System.Drawing.Color.Red;
                passwordValidLabeledit.Text = "Not matched matched";
                isPassMatched = false;
                passwordPictureBoxedit.Image = new Bitmap(AustOldBook.Properties.Resources.close);
                passwordPictureBoxedit.Refresh();
            }
        }

        private void phoneNumberTextedit_OnValueChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^(?:\+?88|0088)?01[13-9]\d{8}$");
            if (!reg.IsMatch(phoneNumberTextedit.Text))
            {
                phnNumberValodLabeledit.ForeColor = Color.Red;
                phnNumberValodLabeledit.Text = "Please enter a valid number";
                isPhoneValid = false;
            }
            else
            {
                isPhoneValid = true;
                phnNumberValodLabeledit.ForeColor = Color.Green;
                phnNumberValodLabeledit.Text = "Supb! Valid Number";
            }

            AustOldBookDBEntities4 odb = new AustOldBookDBEntities4();

            foreach (var user in odb.UserInfoes)
            {
                if (phoneNumberTextedit.Text.Trim() == user.phnNumber)
                {
                    isPhoneValid = false;

                    phnNumberValodLabeledit.ForeColor = Color.Red;
                    phnNumberValodLabeledit.Text = "Already exixt";

                }
            }
        }

        private void emailTextedit_OnValueChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (!reg.IsMatch(emailTextedit.Text))
            {
                validEmailLabeledit.ForeColor = Color.Red;
                validEmailLabeledit.Text = "Please enter a valid email";
                isEmailValid = false;
            }
            else
            {
                isEmailValid = true;
                validEmailLabeledit.ForeColor = Color.Green;
                validEmailLabeledit.Text = "Supb! Valid email";
            }


            AustOldBookDBEntities4 odb = new AustOldBookDBEntities4();

            foreach (var user in odb.UserInfoes)
            {
                if (emailTextedit.Text.Trim() == user.email)
                {
                    validEmailLabeledit.ForeColor = Color.Red;
                    validEmailLabeledit.Text = "already exist";
                    isEmailValid = false;
                }
            }
        }

        private void userIdTextedit_OnValueChanged(object sender, EventArgs e)
        {
            AustOldBookDBEntities4 odb = new AustOldBookDBEntities4();

            foreach (var user in odb.UserInfoes)
            {


                if (userIdTextedit.Text.Trim() == user.userId.Trim())
                {
                    isUserValid = false;

                    userValidLabeledit.ForeColor = Color.Red;
                    userValidLabeledit.Text = "This user already exist";
                    break;

                }
                else if (userIdTextedit.Text.Trim() == "")
                {
                    isUserValid = false;

                    userValidLabeledit.ForeColor = Color.Red;
                    userValidLabeledit.Text = "space nit allowed";
                    break;
                }
                isUserValid = true;

            }

            if (isUserValid)
            {


                userValidLabeledit.ForeColor = Color.Green;
                userValidLabeledit.Text = "Supb! Unique";

            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
            this.Hide();
        }
    }
}
