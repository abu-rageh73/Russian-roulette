using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Russian_roulette
{
    public partial class formmenu : Form
    {
        public formmenu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnrules_Click(object sender, EventArgs e)
        {
            formrule f2 = new formrule();
            f2.Show();
            this.Hide();
        }

        private void Btnplay_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure about playing?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                formplay fa = new formplay();
                fa.Show();
                this.Hide();

            }
            if (result == DialogResult.No)
            {
                SoundPlayer player = new SoundPlayer(@"C:\Users\DELL\Desktop\rageh pro\Russian roulette\Russian roulette\bin\Debug\img\chicken.wav");
                player.Play();
                MessageBox.Show("YOU ARE A COWARD");
                this.Hide();
               
            }
        }
    }
}
