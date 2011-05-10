using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ASynt.Player;

namespace ASynt
{
    public partial class MainForm : Form
    {
        SoundPlayer player = new SoundPlayer();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            Sound sound = new Sound("piano");
            
            if (e.KeyCode == Keys.A)
            {
                sound.ChangeFrequency(60000);
                player.Play(sound);
            }
            else if (e.KeyCode == Keys.S)
            {
                sound.ChangeFrequency(80000);
                player.Play(sound);
            }
            else if (e.KeyCode == Keys.D)
            {
                sound.ChangeFrequency(100000);
                player.Play(sound);
            }
        }
    }
}
