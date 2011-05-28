using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ASynt.Player;
using System.Drawing;
using ASynt.Keyboard;
using Un4seen.Bass;
using System.Runtime.InteropServices;
using ASynt.Effects;
using ASynt.Effects.Effect;

namespace ASynt
{
    public partial class MainForm : Form
    {
        Keyboard.Keyboard keyboard;
        private GCHandle _hGCFile;


        //efekty muszą być zapamiętane - dlatego są tworzone w mainie, bo bez tego po zamknięciu okienka dialogowego by się wszystkie usunęły.
        Echo echo;
        Chorus chorus;
        Gargle gargle;

        public MainForm()
        {
            InitializeComponent();
            keyboard = new Keyboard.Keyboard(this, new Point(20, 20));
            echo = new Echo(keyboard);
            chorus = new Chorus(keyboard);
            gargle = new Gargle(keyboard);
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
    }
}
