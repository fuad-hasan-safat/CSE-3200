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
    public partial class Terms_Condition : Form
    {
        public Terms_Condition()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            this.Hide();
        }
    }
}
