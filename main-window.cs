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

namespace ASynt
{
    public partial class MainForm : Form
    {
        //SoundPlayer player = new SoundPlayer();
        Keyboard.Keyboard keyboard;
        private GCHandle _hGCFile;


        public MainForm()
        {
            InitializeComponent();
            //key = new Key(new System.Drawing.Point(0, 0), 1000);
            keyboard = new Keyboard.Keyboard(this, new Point(20, 20));
        }

        private void soundGenerator(object sender, EventArgs e)
        {
            SoundGenerator sg = new SoundGenerator(keyboard);
            sg.ShowDialog();
        }

        private void buttonEcho_Click(object sender, EventArgs e)
        {
            new EchoDialog(keyboard).Show();
        }
    }
}
