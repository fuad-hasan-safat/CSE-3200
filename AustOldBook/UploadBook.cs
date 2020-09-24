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
    public partial class UploadBook : Form
    {
        public UploadBook()
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
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    //pictureBox1.BackgroundImage = new Bitmap(imageLocation);
                    pictureBox1.Image = Image.FromFile(imageLocation);
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
            semester.Items.Add(new KeyValuePair<string, string>("3.1", "1"));
            semester.Items.Add(new KeyValuePair<string, string>("3.2", "2"));
            semester.Items.Add(new KeyValuePair<string, string>("4.1", "3"));
            semester.Items.Add(new KeyValuePair<string, string>("4.2", "4"));

            semester.DisplayMember = "key";
            semester.ValueMember = "value";
        }

        private void UploadBook_Load(object sender, EventArgs e)
        {
            ComboboxIteamAdd();
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            var context = new AustOldBook.AustOldBookDBEntities4();

            BookInfo books = new AustOldBook.BookInfo()
            {
                userId = LoginInformation.loginUserId,
                bookId = LoginInformation.loginUserId + bookNameField.Text + authorNameField.Text + dep_name.SelectedIndex.ToString() + semester.SelectedIndex.ToString(),
                bookImage = ImageToByteArray(pictureBox1.Image),
                bookName = bookNameField.Text,
                authorName = authorNameField.Text,
                price = Int32.Parse(priceField.Text),
                isLock = 0,
                semester = semester.SelectedIndex.ToString(),
                depertment = dep_name.SelectedIndex.ToString()
            };

            context.BookInfoes.Add(books);
            context.SaveChanges();

            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }


    }
}
