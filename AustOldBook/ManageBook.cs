using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AustOldBook
{
    public partial class ManageBook : Form
    {
        BookInfo model;
        bool isNewImageUploaded = false;
        public ManageBook()
        {
            InitializeComponent();
           
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Profile pf = new Profile();
            pf.Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Profile pf = new Profile();
            pf.Show();
            this.Hide();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            isNewImageUploaded = true;
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    //pictureBox1.BackgroundImage = new Bitmap(imageLocation);
                    pictureBox1Manage.Image = Image.FromFile(imageLocation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void ComboboxIteamAdd()
        {
            profileNameLebel.Text = LoginInformation.nameofUser;
            //------------------------------------------------

            dep_namemanage.Items.Add(new KeyValuePair<string, string>("Select dep name", "0"));
            dep_namemanage.Items.Add(new KeyValuePair<string, string>("CSE", "1"));
            dep_namemanage.Items.Add(new KeyValuePair<string, string>("EEE", "2"));
            dep_namemanage.Items.Add(new KeyValuePair<string, string>("CE", "3"));
            dep_namemanage.Items.Add(new KeyValuePair<string, string>("IPE", "4"));
            dep_namemanage.DisplayMember = "key";
            dep_namemanage.ValueMember = "value";


            semestermanage.Items.Add(new KeyValuePair<string, string>("Select semester", "0"));
            semestermanage.Items.Add(new KeyValuePair<string, string>("1.1", "1"));
            semestermanage.Items.Add(new KeyValuePair<string, string>("1.2", "2"));
            semestermanage.Items.Add(new KeyValuePair<string, string>("2.1", "3"));
            semestermanage.Items.Add(new KeyValuePair<string, string>("2.2", "4"));
            semestermanage.Items.Add(new KeyValuePair<string, string>("3.1", "1"));
            semestermanage.Items.Add(new KeyValuePair<string, string>("3.2", "2"));
            semestermanage.Items.Add(new KeyValuePair<string, string>("4.1", "3"));
            semestermanage.Items.Add(new KeyValuePair<string, string>("4.2", "4"));

            semestermanage.DisplayMember = "key";
            semestermanage.ValueMember = "value";
        }

        private void UploadBook_Load(object sender, EventArgs e)
        {
            model = new BookInfo();
            ComboboxIteamAdd();
            reloadBookInfo();

            isNewImageUploaded = false;


            updateButton.Enabled = true;
            deleteButton.Enabled = true;


        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you really want to update record?", "Ef CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                byte[] img;
                if (isNewImageUploaded)
                {
                    img = ImageToByteArray(pictureBox1Manage.Image);
                }
                else
                {
                    img = BookInfoInformation.bookinfo.bookImage;
                }

                var context = new AustOldBook.AustOldBookDBEntities4();

                BookInfo books = new AustOldBook.BookInfo()
                {
                    userId = BookInfoInformation.bookinfo.userId,
                    bookId = BookInfoInformation.bookinfo.bookId,
                    bookImage = img,
                    bookName = bookNameFieldmanage.Text,
                    authorName = authorNameFieldmanage.Text,
                    price = Int32.Parse(priceFieldmanage.Text),
                    isLock = 0,
                    semester = semestermanage.SelectedIndex.ToString(),
                    depertment = dep_namemanage.SelectedIndex.ToString()
                };

                context.Entry(books).State = EntityState.Modified;
                context.SaveChanges();

                BookInfoInformation.bookinfo = books;

                Profile pf = new Profile();
                pf.Show();
                this.Hide();
            }
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
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


        public void reloadBookInfo()
        {
            bookNameFieldmanage.Text = BookInfoInformation.bookinfo.bookName;
            authorNameFieldmanage.Text = BookInfoInformation.bookinfo.authorName;
            Image img = byteArrayToImage(BookInfoInformation.bookinfo.bookImage);
            pictureBox1Manage.Image = img;
            semestermanage.Text = retriveSemester(BookInfoInformation.bookinfo.semester);
            dep_namemanage.Text = retriveDepertment(BookInfoInformation.bookinfo.depertment);
            priceFieldmanage.Text = BookInfoInformation.bookinfo.price.ToString();
        }

        public void ClearedBookInfo()
        {
            bookNameFieldmanage.Text = "";
            authorNameFieldmanage.Text = "";
            //Image img = byteArrayToImage(BookInfoInformation.bookinfo.bookImage);
            pictureBox1Manage.Image = null;
            semestermanage.Text ="";
            dep_namemanage.Text = "";
            priceFieldmanage.Text = "";
        }



        public string retriveSemester(string index)
        {
            string semester = "";

            if (index == "1") semester = "1.1";
            if (index == "2") semester = "1.2";
            if (index == "3") semester = "2.1";
            if (index == "4") semester = "2.2";
            if (index == "5") semester = "3.1";
            if (index == "6") semester = "3.2";
            if (index == "7") semester = "4.1";
            if (index == "8") semester = "4.2";


            return semester;
        }

        public string retriveDepertment(string index)
        {
            string dep = "";

            if (index == "1") dep = "CSE";
            if (index == "2") dep = "EEE";
            if (index == "3") dep = "CE";
            if (index == "4") dep = "IPE";



            return dep;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you really want to delete record?", "Ef CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AustOldBookDBEntities4 odb = new AustOldBookDBEntities4();

                foreach(var book in odb.BookInfoes)
                {
                    if(BookInfoInformation.bookinfo.bookId == book.bookId)
                    {
                        model = book;
                        break;
                    }
                }

                odb.BookInfoes.Remove(model);
                odb.SaveChanges();
                ClearedBookInfo();
                updateButton.Enabled = false;
                deleteButton.Enabled = false;

                MessageBox.Show("Delete Successfuly occured");


            }
        }
    }
}
