using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib; 
using System.Media;  //L'utilisation du bibliothéque Media

namespace Jeu_DIGIPIANO
{   
    //Form Welcome 
    public partial class Welcome_to_DP : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer(); 
        public Welcome_to_DP()
        {

            InitializeComponent();

            //Chemin Media Item , musique arriére plan 
            player.URL = "MyMusicPiano.mp3"; 
        }

        //Button Play
        private void playBut_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            var piano = new MyDigiPiano();
            piano.Show();
            this.Hide();
        }

        //Button Exit
        private void exitBut_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Voulez vous vraiment quitter DigiPiano", "Exit", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Control du media player 
        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }
    }
}
