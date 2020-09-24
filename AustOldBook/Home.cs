using AustOldBook;
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
    public partial class Home : Form
    {
       
        public Home()
        {
            InitializeComponent();
        }

       

        private void Home_Load(object sender, EventArgs e)
        {

            //------------------------------------------
            // database checking
            AustOldBookDBEntities4 odb = new AustOldBookDBEntities4();
            foreach (var user in odb.UserInfoes)
            {
                if (user.userId == LoginInformation.loginUserId)
                {
                    LoginInformation.setUser(user.userId, user.firstName + " " + user.lastName, user.email, user.aaddress, user.phnNumber);

                    label5.Text = LoginInformation.nameofUser;
                }
            }
            //------------------------------------------
            comboBoxLoad();

            //---------------- 
            bookListShow();

        }

      

        //convert bytearray to image
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }

        // book info --------
        public void bookListShow()
        {
            ListIteams listIteams = new ListIteams();
            AustOldBookDBEntities4 odb = new AustOldBookDBEntities4();

            foreach (var book in odb.BookInfoes)
            {
               

                listIteams = new ListIteams();
                listIteams.BookNameofBook = "Book Name:"+book.bookName;
                listIteams.AuthorNameofBook = "Author name:" + book.authorName;
                listIteams.PriceofBook = "Price:" + book.price.ToString()+" taka";
                listIteams.ImageOfBook = byteArrayToImage(book.bookImage);
                UserInfo usr = getUser(book);
                if(usr != null)
                {
                    listIteams.EmailOfBookuploder = "Email:" + usr.email;
                    listIteams.PhoneOfBookUploader = "Phone Number:" + usr.phnNumber;
                    listIteams.AddressOfBookUploader = "Address:" + usr.aaddress;
                }
                

                // Console.WriteLine(flowLayoutPanel1.Controls.Count);
                flowLayoutPanel1.Controls.Add(listIteams);
                //BookInfoInformation.bookinfo = book;
            }

        }

        public UserInfo getUser(BookInfo book)
        {
            UserInfo user = null;
            AustOldBookDBEntities4 odb = new AustOldBookDBEntities4();

            foreach (var usr in odb.UserInfoes)
            {
                if (usr.userId == book.userId) return usr;
            }
                return user;

        }
    

        public void comboBoxLoad()
        {

            dep_name.Items.Add(new KeyValuePair<string, string>("Select dep name", "0"));
            dep_name.Items.Add(new KeyValuePair<string, string>("CSE", "1"));
            dep_name.Items.Add(new KeyValuePair<string, string>("EEE", "2"));
            dep_name.Items.Add(new KeyValuePair<string, string>("CE", "3"));
            dep_name.Items.Add(new KeyValuePair<string, string>("IPE", "4"));
            dep_name.DisplayMember = "key";
            dep_name.ValueMember = "value";


            semester.Items.Add(new KeyValuePair<string, string>("Select semester", "0"));
            semester.Items.Add(new KeyValuePair<string, string>("1.1", "1"));
            semester.Items.Add(new KeyValuePair<string, string>("1.2", "2"));
            semester.Items.Add(new KeyValuePair<string, string>("2.1", "3"));
            semester.Items.Add(new KeyValuePair<string, string>("2.2", "4"));
            semester.Items.Add(new KeyValuePair<string, string>("3.1", "5"));
            semester.Items.Add(new KeyValuePair<string, string>("3.2", "6"));
            semester.Items.Add(new KeyValuePair<string, string>("4.1", "7"));
            semester.Items.Add(new KeyValuePair<string, string>("4.2", "8"));

            semester.DisplayMember = "key";
            semester.ValueMember = "value";
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
            Profile pf = new Profile();
            pf.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            Profile pf = new Profile();
            pf.Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            //LoginInformation.logInCheckDisable();
            LogIn lgin = new LogIn();
            lgin.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            UploadBook upb = new UploadBook();
            upb.Show();
            this.Hide();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ListIteams listIteams = new ListIteams();
            AustOldBookDBEntities4 odb = new AustOldBookDBEntities4();

            foreach (var book in odb.BookInfoes)
            {
               

                if (book.semester == semester.SelectedIndex.ToString().Trim() &&
                    book.depertment == dep_name.SelectedIndex.ToString().Trim())
                {
                    UserInfo usr = getUser(book);

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
 
    }
}
