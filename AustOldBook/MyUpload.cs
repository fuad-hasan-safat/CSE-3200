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
    public partial class MyUpload : Form
    {

        public MyUpload()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MyUpload_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'austOldBookDBDataSet1.BookInfo' table. You can move, or remove it, as needed.
            this.bookInfoTableAdapter.Fill(this.austOldBookDBDataSet1.BookInfo);

            //populateDataGridView();

            profileNameLebel.Text = LoginInformation.nameofUser;

        }




        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Profile pf = new Profile();
            pf.Show();
            this.Hide();
        }

        void populateDataGridView()
        {


            //BookModelView book = new BookModelView();
            // bunifuDataGridView1.DataSource = book.ListOfMybook();

          /*using(AustOldBookDBEntities4 db = new AustOldBookDBEntities4())
            {
                bunifuDataGridView1.DataSource = db.BookInfoes.ToList();
            }
           */
        }

    

        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {
            Profile pf = new Profile();
            pf.Show();
            this.Hide();
        }

        private void bunifuDataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(bunifuDataGridView1.CurrentRow.Index != -1)
            {
                int rowindex = bunifuDataGridView1.CurrentCell.RowIndex;
                int columnindex = bunifuDataGridView1.CurrentCell.ColumnIndex;
                string seletecBookid =  bunifuDataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString();
                MessageBox.Show("Book id = " + seletecBookid);

                AustOldBookDBEntities4 odb = new AustOldBookDBEntities4();

                foreach(var bookInfoObject in odb.BookInfoes)
                {
                    
                    if (seletecBookid == bookInfoObject.bookId)
                    {
                        BookInfoInformation.bookinfo = bookInfoObject;
                        break;
                    }
                }
            }

            ManageBook mg = new ManageBook();
            mg.Show();
            this.Hide();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void bunifuImageButton4_Click_1(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            Profile pf = new Profile();
            pf.Show();
            this.Hide();
        }
    }
}
