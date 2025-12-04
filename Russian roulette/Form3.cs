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
    public partial class formplay : Form

    {
        private int revolver;
        private Random rand = new Random();
        private bool performshutdown = true;

      
        public formplay()
        {
            InitializeComponent();
            initializegame();
        }
        private void initializegame()
        {
            revolver = rand.Next(1, 7);
            lblstatus.Text = "prass 'try your luck' to play";
        }

        private void formplay_Load(object sender, EventArgs e)
        {

        }

        private void Btntry_Click(object sender, EventArgs e)
        {
            int attempt = rand.Next(1, 7);
            if (attempt == revolver)
            {
                SoundPlayer player = new SoundPlayer(@"C:\Users\DELL\Desktop\rageh pro\Russian roulette\Russian roulette\bin\Debug\img\laughing.wav");
                player.Play();
                lblstatus.Text = " bad luck loser bye";


                if (performshutdown)
                {
                    System.Diagnostics.Process.Start("shutdown", "/s /t 4");
                }
                else
                {
                    MessageBox.Show("error");




                }
                initializegame();
            }
            else
            {
                lblstatus.Text = "LUCKY!try again. ";
            }
        }

        private void lblstatus_Click(object sender, EventArgs e)
        {

        }
    }
}
