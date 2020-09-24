using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AustOldBook
{
    public partial class EditProfile : Form
    {

        public static bool isEmailValid = false;
        public static bool isUserValid = true;
        public static bool isPhoneValid = false;
        public static bool isPassMatched = false;
        public EditProfile()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Profile pf = new Profile();
            pf.Show();
            this.Hide();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Home pf = new Home();
            pf.Show();
            this.Hide();
        }

        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you really want to update record?", "Ef CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (isPhoneValid && isPassMatched && isEmailValid && isUserValid)
                {
                    var context = new AustOldBook.AustOldBookDBEntities4();


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

                    context.Entry(user).State = EntityState.Modified;
                    context.SaveChanges();

                    LoginInformation.setUser(user.userId,user.firstName+" "+ user.lastName,user.email, user.aaddress, user.phnNumber);

                    Profile pf = new Profile();
                    pf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter field with valid data");
                }
            }
        }



        public void loadUser()
        {
            UserInfo user = new UserInfo();
            AustOldBookDBEntities4 odb = new AustOldBookDBEntities4();
            foreach (var userObject in odb.UserInfoes)
            {

                if (LoginInformation.loginUserId == userObject.userId)
                {
                    user = userObject;

                    break;
                }
            }

            firstNameedit.Text = user.firstName;
            lastNameEdit.Text = user.lastName;
            userIdTextedit.Text = user.userId;
            emailTextedit.Text = user.email;
            phoneNumberTextedit.Text = user.phnNumber;
            addressTexteditedit.Text = user.aaddress;
            passwordTextedit.Text = user.ppassword;
            retypePasswordTextedit.Text = user.ppassword;

        }

        private void userIdTextedit_OnValueChanged(object sender, EventArgs e)
        {
            AustOldBookDBEntities4 odb = new AustOldBookDBEntities4();

            foreach (var user in odb.UserInfoes)
            {


                if (userIdTextedit.Text.Trim() == user.userId.Trim() && user.userId != LoginInformation.loginUserId)
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
                if (emailTextedit.Text.Trim() == user.email && user.email != LoginInformation.emailOfUser)
                {
                    validEmailLabeledit.ForeColor = Color.Red;
                    validEmailLabeledit.Text = "already exist";
                    isEmailValid = false;
                }
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
                if (phoneNumberTextedit.Text.Trim() == user.phnNumber && user.phnNumber != LoginInformation.contactOfUser)
                {
                    isPhoneValid = false;

                    phnNumberValodLabeledit.ForeColor = Color.Red;
                    phnNumberValodLabeledit.Text = "Already exixt";

                }
            }

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

        private void EditProfile_Load(object sender, EventArgs e)
        {
            loadUser();
            profileNameLable.Text = LoginInformation.nameofUser;
        }
    }
}
