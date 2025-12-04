using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_roulette
{
    public partial class formrule : Form
    {
        public formrule()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btnback_Click(object sender, EventArgs e)
        {
            formmenu f1 = new formmenu();
            f1.Show();
            this.Hide();
        }
    }
}
