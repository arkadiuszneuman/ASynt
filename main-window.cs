using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ASynt.Player;
using System.Drawing;
using ASynt.Keyboard;
using ASynt.Effects;
using ASynt.Effects.Effect;

namespace ASynt
{
    public partial class MainForm : Form
    {
        Keyboard.Keyboard keyboard;

        //efekty muszą być zapamiętane - dlatego są tworzone w mainie, bo bez tego po zamknięciu okienka dialogowego by się wszystkie usunęły.
        Echo echo;
        Chorus chorus;
        Gargle gargle;
        Reverb reverb;

        public MainForm()
        {
            InitializeComponent();
            keyboard = new Keyboard.Keyboard(this, new Point(20, 20));
            echo = new Echo(keyboard);
            chorus = new Chorus(keyboard);
            gargle = new Gargle(keyboard);
            reverb = new Reverb(keyboard);

            List<int> l = new List<int>();
            for (int i = 0; i < 360; ++i)
                l.Add((int)(Math.Sin(Math.PI * i / 180.0) * 10000));

            new ChartDialog(l.ToArray()).Show();
        }

        private void soundGenerator(object sender, EventArgs e)
        {
            SoundGenerator sg = new SoundGenerator(keyboard);
            sg.ShowDialog();
        }

        
        private void buttonEcho_Click(object sender, EventArgs e)
        {
            new EchoDialog(echo).Show();
        }

        private void buttonChorus_Click(object sender, EventArgs e)
        {
            new ChorusDialog(chorus).Show();
        }

        private void buttonGargle_Click(object sender, EventArgs e)
        {
            new GargleDialog(gargle).Show();
        }

        private void buttonReverb_Click(object sender, EventArgs e)
        {
            new ReverbDialog(reverb).Show();
        }

        private void pianoSound(object sender, EventArgs e)
        {
            for (int i = 0; i < keyboard.keys.Length; ++i)
            {
                int l = i; //dodawanie do literki
                if ('c' + l > 'g')
                    l -= 7;
                keyboard.keys[i].KeySound = new ASynt.Player.Sound(@"piano3\" + (char)('c' + l));
            }

            keyboard.smallKeys[0].KeySound = new ASynt.Player.Sound(@"piano3\c#");
            keyboard.smallKeys[1].KeySound = new ASynt.Player.Sound(@"piano3\d#");
            keyboard.smallKeys[2].KeySound = new ASynt.Player.Sound(@"piano3\f#");
            keyboard.smallKeys[3].KeySound = new ASynt.Player.Sound(@"piano3\g#");
            keyboard.smallKeys[4].KeySound = new ASynt.Player.Sound(@"piano3\a#");
        }
    }
}
