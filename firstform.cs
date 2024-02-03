using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class firstform : Form
    {
        public firstform()
        {
            InitializeComponent();
        }

        private void startlbl_Click(object sender, EventArgs e)
        {
            Form moreForm = new Form1();
            moreForm.Show();
        }

        private void exitlbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
