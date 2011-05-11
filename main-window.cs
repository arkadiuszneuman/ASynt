using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using ASynt.Player;
using System.Drawing;
using ASynt.Keyboard;

namespace ASynt
{
    public partial class MainForm : Form
    {
        //SoundPlayer player = new SoundPlayer();
        Keyboard.Keyboard keyboard;

        public MainForm()
        {
            InitializeComponent();
            //key = new Key(new System.Drawing.Point(0, 0), 1000);
            keyboard = new Keyboard.Keyboard(this, new Point(0, 0));
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            Sound sound = new Sound("piano");

            if (e.KeyCode == Keys.A)
            {
                sound.ChangeFrequency(60000);
                //player.Play(sound);
            }
            else if (e.KeyCode == Keys.S)
            {
                sound.ChangeFrequency(80000);
                //player.Play(sound);
            }
            else if (e.KeyCode == Keys.D)
            {
                sound.ChangeFrequency(100000);
                //player.Play(sound);
            }
        }
    }
}
