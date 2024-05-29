using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyMp3Player
{
    public partial class Form1 : Form
    {
        private Mp3Player mp3Player = new Mp3Player();
        private List<string> playlist = new List<string>();
        private int currentIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files|*.mp3";
                ofd.Multiselect = true;  // Allow multiple files to be selected
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    playlist.AddRange(ofd.FileNames);
                    if (playlist.Count > 0)
                    {
                        currentIndex = 0;
                        mp3Player.open(playlist[currentIndex]);
                        mp3Player.play();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentIndex != -1)
            {
                mp3Player.play();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mp3Player.stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mp3Player.close();
            Application.Exit();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                mp3Player.open(playlist[currentIndex]);
                mp3Player.play();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < playlist.Count - 1)
            {
                currentIndex++;
                mp3Player.open(playlist[currentIndex]);
                mp3Player.play();
            }
        }
    }
}
