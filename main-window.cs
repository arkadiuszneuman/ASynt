using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using ASynt.Player;
using System.Drawing;
using ASynt.Keyboard;
using Un4seen.Bass;

namespace ASynt
{
    public partial class MainForm : Form
    {
        //SoundPlayer player = new SoundPlayer();
        Keyboard.Keyboard keyboard;
        SampleSounds sampleSounds;

        public MainForm()
        {
            InitializeComponent();
            //key = new Key(new System.Drawing.Point(0, 0), 1000);
            keyboard = new Keyboard.Keyboard(this, new Point(20, 20));
            sampleSounds = new SampleSounds();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int channel = sampleSounds.GetChannelHandle(0);
            Bass.BASS_ChannelPlay(channel, false);
            Bass.BASS_ChannelSlideAttribute(channel, BASSAttribute.BASS_ATTRIB_VOL, 0, 10000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int channel = sampleSounds.GetChannelHandle(1);
            Bass.BASS_ChannelPlay(channel, false);
            Bass.BASS_ChannelSlideAttribute(channel, BASSAttribute.BASS_ATTRIB_VOL, 0, 10000);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int channel = sampleSounds.GetChannelHandle(2);
            Bass.BASS_ChannelPlay(channel, false);
            Bass.BASS_ChannelSlideAttribute(channel, BASSAttribute.BASS_ATTRIB_VOL, 0, 1000);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int channel = sampleSounds.GetChannelHandle(3);
            Bass.BASS_ChannelPlay(channel, false);
            Bass.BASS_ChannelSlideAttribute(channel, BASSAttribute.BASS_ATTRIB_VOL, 0, 1000);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int channel = sampleSounds.GetChannelHandle(4);
            Bass.BASS_ChannelPlay(channel, false);
            Bass.BASS_ChannelSlideAttribute(channel, BASSAttribute.BASS_ATTRIB_VOL, 0, 1000);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int channel = sampleSounds.GetChannelHandle(5);
            Bass.BASS_ChannelPlay(channel, false);
            Bass.BASS_ChannelSlideAttribute(channel, BASSAttribute.BASS_ATTRIB_VOL, 0, 1000);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int channel = sampleSounds.GetChannelHandle(6);
            Bass.BASS_ChannelPlay(channel, false);
            Bass.BASS_ChannelSlideAttribute(channel, BASSAttribute.BASS_ATTRIB_VOL, 0, 1000);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int channel = sampleSounds.GetChannelHandle(7);
            Bass.BASS_ChannelPlay(channel, false);
            Bass.BASS_ChannelSlideAttribute(channel, BASSAttribute.BASS_ATTRIB_VOL, 0, 1000);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int channel = sampleSounds.GetChannelHandle(8);
            Bass.BASS_ChannelPlay(channel, false);
            Bass.BASS_ChannelSlideAttribute(channel, BASSAttribute.BASS_ATTRIB_VOL, 0, 1000);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int channel = sampleSounds.GetChannelHandle(9);
            Bass.BASS_ChannelPlay(channel, false);
            Bass.BASS_ChannelSlideAttribute(channel, BASSAttribute.BASS_ATTRIB_VOL, 0, 1000);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int channel = sampleSounds.GetChannelHandle(10);
            Bass.BASS_ChannelPlay(channel, false);
            Bass.BASS_ChannelSlideAttribute(channel, BASSAttribute.BASS_ATTRIB_VOL, 0, 1000);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int channel = sampleSounds.GetChannelHandle(11);
            Bass.BASS_ChannelPlay(channel, false);
            Bass.BASS_ChannelSlideAttribute(channel, BASSAttribute.BASS_ATTRIB_VOL, 0, 1000);
        }

        private void soundGenerator(object sender, EventArgs e)
        {
            SoundGenerator sg = new SoundGenerator(sampleSounds);
            sg.ShowDialog();
        }

        private void buttonEcho_Click(object sender, EventArgs e)
        {
            new EchoDialog(keyboard).Show();
        }
    }
}
