using Start;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AustOldBook
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyUpload myup = new MyUpload();
            myup.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UploadBook upld = new UploadBook();
            upld.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register ep = new Register();
            ep.Show();
            this.Hide();
        }

        private void userName_Click(object sender, EventArgs e)
        {
            Profile pf = new Profile();
            pf.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogIn pf = new LogIn();
            pf.Show();
            this.Hide();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            profileNameLable.Text = LoginInformation.nameofUser;
            emailLabel.Text = LoginInformation.emailOfUser;
            phoneLable.Text = LoginInformation.contactOfUser;
            addressLabel.Text = LoginInformation.addressOfUser;

            bookListShow();


        }

        private void profileNameLable_Click(object sender, EventArgs e)
        {

        }

        private void editProfileButton_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile();
            ep.Show();
            this.Hide();
        }





        public void bookListShow()
        {
            ListIteams listIteams = new ListIteams();
            AustOldBookDBEntities4 odb = new AustOldBookDBEntities4();

            foreach (var book in odb.BookInfoes)
            {
                UserInfo usr = getUser(book);
                if (usr != null)
                {
                    listIteams = new ListIteams();
                    listIteams.BookNameofBook = "Book Name:" + book.bookName;
                    listIteams.AuthorNameofBook = "Author name:" + book.authorName;
                    listIteams.PriceofBook = "Price:" + book.price.ToString() + " taka";
                    listIteams.ImageOfBook = byteArrayToImage(book.bookImage);

                    listIteams.EmailOfBookuploder = "Email:" + usr.email;
                    listIteams.PhoneOfBookUploader = "Phone Number:" + usr.phnNumber;
                    listIteams.AddressOfBookUploader = "Address:" + usr.aaddress;



                    // Console.WriteLine(flowLayoutPanel1.Controls.Count);
                    flowLayoutPanel1.Controls.Add(listIteams);
                    //BookInfoInformation.bookinfo = book;
                }
            }

        }


        //convert bytearray to image
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }



        public UserInfo getUser(BookInfo book)
        {
            UserInfo user = null;
            AustOldBookDBEntities4 odb = new AustOldBookDBEntities4();

            foreach (var usr in odb.UserInfoes)
            {
                if (LoginInformation.loginUserId == book.userId) return usr;
            }
            return user;

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            LogIn lgin = new LogIn();
            lgin.Show();
            this.Hide();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            MyUpload pf = new MyUpload();
            pf.Show();
            this.Hide();
        }

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {
            MyUpload mup = new MyUpload();
            mup.Show();
            this.Hide();
        }
    }
}
