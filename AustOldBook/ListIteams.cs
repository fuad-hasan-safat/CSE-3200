using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AustOldBook;

namespace AustOldBook
{
    public partial class ListIteams : UserControl
    {
        public ListIteams()
        {
            InitializeComponent();
        }


        #region Proporties
        private string _bookName;
        private string _authorName;
        private string _price;

        private string _emailOfBookUploader;
        private string _phnNoofBookUploder;
        private string _addressOfBookUploder;
/*        private string _aboutOfBook;
*/
        private Image _imageOfBook;

        [Category("Custom Props")]
        public string BookNameofBook
        {
            get{ return _bookName; }
            set{ _bookName = value; bookNameListener.Text = value; }
        }


        [Category("Custom Props")]
        public string AuthorNameofBook
        {
            get { return _authorName; }
            set { _authorName = value; bookAuthorListener.Text = value; }
        }

        [Category("Custom Props")]
        public string PriceofBook
        {
            get { return _price; }
            set { _price = value; bookPriceListener.Text = value; }
        }

        [Category("Custom Props")]
        public Image ImageOfBook
        {
            get { return _imageOfBook; }
            set { _imageOfBook = value; pictureBox1.Image = value; }
        }

        [Category("Custom Props")]
        public string EmailOfBookuploder
        {
            get { return _emailOfBookUploader; }
            set { _emailOfBookUploader = value; emailLabel.Text = value; }
        }

        [Category("Custom Props")]
        public string PhoneOfBookUploader
        {
            get { return _phnNoofBookUploder; }
            set { _phnNoofBookUploder = value; phnLabel.Text = value; }
        }

        [Category("Custom Props")]
        public string AddressOfBookUploader
        {
            get { return _addressOfBookUploder; }
            set { _addressOfBookUploder = value; addressLabel.Text = value; }
        }

        #endregion

        private void ListIteams_Load(object sender, EventArgs e)
        {

        }

        private void aboutlabel_Click(object sender, EventArgs e)
        {

        }
    }

    
}
