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
        }

        private void soundGenerator(object sender, EventArgs e)
        {
            echo = new Echo(keyboard);
            chorus = new Chorus(keyboard);
            gargle = new Gargle(keyboard);
            reverb = new Reverb(keyboard);

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
            echo = new Echo(keyboard);
            chorus = new Chorus(keyboard);
            gargle = new Gargle(keyboard);
            reverb = new Reverb(keyboard);

            for (int i = 0; i < keyboard.keys.Length; ++i)
            {
                int l = i; //dodawanie do literki
                if ('c' + l > 'g')
                    l -= 7;
                keyboard.keys[i].KeySound = new ASynt.Player.Sound(@"Piano\" + (char)('c' + l), false);
            }

            keyboard.smallKeys[0].KeySound = new ASynt.Player.Sound(@"Piano\c#", false);
            keyboard.smallKeys[1].KeySound = new ASynt.Player.Sound(@"Piano\d#", false);
            keyboard.smallKeys[2].KeySound = new ASynt.Player.Sound(@"Piano\f#", false);
            keyboard.smallKeys[3].KeySound = new ASynt.Player.Sound(@"Piano\g#", false);
            keyboard.smallKeys[4].KeySound = new ASynt.Player.Sound(@"Piano\a#", false);
        }

        private void ReadFile(object sender, EventArgs e)
        {
            echo = new Echo(keyboard);
            chorus = new Chorus(keyboard);
            gargle = new Gargle(keyboard);
            reverb = new Reverb(keyboard);

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "WAV files (*.wav)|*.wav";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < keyboard.AllKeys.Length; ++i)
                {
                    keyboard.AllKeys[i].KeySound = new ASynt.Player.Sound(fileDialog.FileName, true);
                }

                keyboard.keys[0].SetFrequency = (44100 * 261) / 440;
                keyboard.keys[1].SetFrequency = (44100 * 293) / 440;
                keyboard.keys[2].SetFrequency = (44100 * 329) / 440;
                keyboard.keys[3].SetFrequency = (44100 * 349) / 440;
                keyboard.keys[4].SetFrequency = (44100 * 391) / 440;
                keyboard.keys[5].SetFrequency = (44100 * 440) / 440;
                keyboard.keys[6].SetFrequency = (44100 * 493) / 440;

                keyboard.smallKeys[0].SetFrequency = (44100 * 277) / 440;
                keyboard.smallKeys[1].SetFrequency = (44100 * 311) / 440;
                keyboard.smallKeys[2].SetFrequency = (44100 * 369) / 440;
                keyboard.smallKeys[3].SetFrequency = (44100 * 415) / 440;
                keyboard.smallKeys[4].SetFrequency = (44100 * 466) / 440;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            keyboard.SaveSequence();
        }
    }
}
