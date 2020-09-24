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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home mup = new Home();
            mup.Show();
            this.Hide();
        }

        private void Update_Load(object sender, EventArgs e)
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
            semester.Items.Add(new KeyValuePair<string, string>("3.1", "1"));
            semester.Items.Add(new KeyValuePair<string, string>("3.2", "2"));
            semester.Items.Add(new KeyValuePair<string, string>("4.1", "3"));
            semester.Items.Add(new KeyValuePair<string, string>("4.2", "4"));

            semester.DisplayMember = "key";
            semester.ValueMember = "value";
        }

        private void userName_Click(object sender, EventArgs e)
        {
            Profile pf = new Profile();
            pf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
