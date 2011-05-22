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

        public MainForm()
        {
            InitializeComponent();
            //key = new Key(new System.Drawing.Point(0, 0), 1000);
            keyboard = new Keyboard.Keyboard(this, new Point(50, 150));
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            Sound sound = new Sound("piano");

            if (e.KeyCode == Keys.A)
            {
                sound.ChangeFrequency(440);
                //player.Play(sound);
            }
            else if (e.KeyCode == Keys.S)
            {
                sound.ChangeFrequency(440);
                //player.Play(sound);
            }
            else if (e.KeyCode == Keys.D)
            {
                sound.ChangeFrequency(440);
                //player.Play(sound);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            // create the sample
            int sample = Bass.BASS_SampleCreate(44100, 44100, 2, 1, BASSFlag.BASS_SAMPLE_LOOP | BASSFlag.BASS_SAMPLE_OVER_POS);
            // the data buffer (5000 byte = 128 Int16)
            short[] data = new short[22050];
            // create the sine wave
            for (int a = 0; a < 22050; a++)
                data[a] = (short)((0.25 * short.MaxValue) * Math.Sin(Math.Sin((2 * Math.PI * a * 440) / 44100)) + (0.25 * short.MaxValue) * Math.Abs(Math.Tan(2*Math.PI*a*440/44100))); //32767
            // set the sample's data 
            Bass.BASS_SampleSetData(sample, data);
            // get a sample channel
            int channel = Bass.BASS_SampleGetChannel(sample, false);
            // play it
           Bass.BASS_ChannelPlay(channel, false);
           Bass.BASS_ChannelSlideAttribute(channel, BASSAttribute.BASS_ATTRIB_VOL, 0, 1000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            // create the sample
            int sample = Bass.BASS_SampleCreate(44100, 44100, 2, 1, BASSFlag.BASS_SAMPLE_LOOP | BASSFlag.BASS_SAMPLE_OVER_POS);
            // the data buffer (5000 byte = 128 Int16)
            short[] data = new short[22050];
            // create the sine wave
            for (int a = 0; a < 22050; a++)
                data[a] = (short)((0.25 * short.MaxValue) * Math.Sin(Math.Sin((2 * Math.PI * a * 880) / 44100)) + (0.25 * short.MaxValue) * Math.Abs(Math.Tan(2 * Math.PI * a * 880 / 44100))); //32767
            // set the sample's data 
            Bass.BASS_SampleSetData(sample, data);
            // get a sample channel
            int channel = Bass.BASS_SampleGetChannel(sample, false);
            // play it
            Bass.BASS_ChannelPlay(channel, false);
            Bass.BASS_ChannelSlideAttribute(channel, BASSAttribute.BASS_ATTRIB_VOL, 0, 1000);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            // create the sample
            int sample = Bass.BASS_SampleCreate(44100, 44100, 2, 1, BASSFlag.BASS_SAMPLE_LOOP | BASSFlag.BASS_SAMPLE_OVER_POS);
            // the data buffer (5000 byte = 128 Int16)
            short[] data = new short[22050];
            // create the sine wave
            for (int a = 0; a < 22050; a++)
                data[a] = (short)((0.25 * short.MaxValue) * Math.Sin(Math.Sin((2 * Math.PI * a * 1300) / 44100)) * (0.25 * short.MaxValue) * Math.Abs(Math.Tan(2 * Math.PI * a * 1300 / 44100))); //32767
            // set the sample's data 
            Bass.BASS_SampleSetData(sample, data);
            // get a sample channel
            int channel = Bass.BASS_SampleGetChannel(sample, false);
            // play it
            Bass.BASS_ChannelPlay(channel, false);
            Bass.BASS_ChannelSlideAttribute(channel, BASSAttribute.BASS_ATTRIB_VOL, 0, 1000);
        }
    }
}
