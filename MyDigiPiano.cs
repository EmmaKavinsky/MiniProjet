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


namespace Jeu_DIGIPIANO
{   
    //
    public partial class MyDigiPiano : Form
    {
        //Buttons de notes musiquales du piano
        public MyDigiPiano()
        {
            InitializeComponent();
        }
        Random rand = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.do1);
            player.Load();
            player.PlaySync();
        }
       

        private void button22_Click_1(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.do_1);
            player.Load();
            player.PlaySync();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.re1);
            player.Load();
            player.PlaySync();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.re_1);
            player.Load();
            player.PlaySync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.mi1);
            player.Load();
            player.PlaySync();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.fa1);
            player.Load();
            player.PlaySync();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.fa_1);
            player.Load();
            player.PlaySync();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.sol1);
            player.Load();
            player.PlaySync();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.sol_1);
            player.Load();
            player.PlaySync();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.la1);
            player.Load();
            player.PlaySync();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.la_1);
            player.Load();
            player.PlaySync();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.si1);
            player.Load();
            player.PlaySync();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.do2);
            player.Load();
            player.PlaySync();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.do_2);
            player.Load();
            player.PlaySync();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.re2);
            player.Load();
            player.PlaySync();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.re_2);
            player.Load();
            player.PlaySync();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.mi2);
            player.Load();
            player.PlaySync();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.fa2);
            player.Load();
            player.PlaySync();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.fa_2);
            player.Load();
            player.PlaySync();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.sol2);
            player.Load();
            player.PlaySync();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.sol_2);
            player.Load();
            player.PlaySync();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.la2);
            player.Load();
            player.PlaySync();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.la_2);
            player.Load();
            player.PlaySync();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.si2);
            player.Load();
            player.PlaySync();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.do3);
            player.Load();
            player.PlaySync();
          
            
        }

        //Controle des samples rythmiques par axWindowsMediaPlayer 
        private void designButton1_Click(object sender, EventArgs e)
        {

            axWindowsMediaPlayer2.Ctlcontrols.pause();
            axWindowsMediaPlayer3.Ctlcontrols.pause();
            axWindowsMediaPlayer1.URL = "orientDrum.wav";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.settings.setMode("loop", true);



        }

        private void designButton2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            axWindowsMediaPlayer3.Ctlcontrols.pause();
            axWindowsMediaPlayer2.URL = "Guitar_percussion.wav";
            axWindowsMediaPlayer2.Ctlcontrols.play();
            axWindowsMediaPlayer2.settings.setMode("loop", true);
           
        }

        private void designButton3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            axWindowsMediaPlayer2.Ctlcontrols.pause();
            axWindowsMediaPlayer3.URL = "FunkyBreak.wav";
            axWindowsMediaPlayer3.Ctlcontrols.play();
            axWindowsMediaPlayer3.settings.setMode("loop", true);
        }

        private void MyDigiPiano_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        //Controle label clignotant
        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.ForeColor= Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }


        private void designButton4_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez vous vraiment quitter DigiPiano", "Exit", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
