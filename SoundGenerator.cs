using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Un4seen.Bass;

namespace ASynt
{
    public partial class SoundGenerator : Form
    {
        private SampleSounds sampleSounds;
        private Sample bufferSample;
        private List<SyntWave> signalsList;
        private int checkedSignal;
        private int ampl;

        public SoundGenerator(SampleSounds _sampleSounds)
        {
            InitializeComponent();
            this.sampleSounds = _sampleSounds;
            checkedSignal = -1;
            signalsList = new List<SyntWave>();
            bufferSample = new Sample(25, 440);
            ampl = 25;
        }

        private void SignalChanged(object sender, EventArgs e)
        {
            checkedSignal = int.Parse(((RadioButton)sender).Tag.ToString());
        }

        private void addSignal(object sender, EventArgs e)
        {
            if (checkedSignal != -1)
            {
                int to = int.Parse(toTB.Text.ToString());
                int from = int.Parse(fromTB.Text.ToString());
                
                if (from < 0)
                {
                    from = 0;
                }

                if (to > 2000)
                {
                    to = 2000;
                }

                to *= 22;
                from *= 22;
                signalsList.Add(new SyntWave(checkedSignal, from, to));
                bufferSample.AddWave(checkedSignal, from, to);
            }
        }

        private void applyGain(object sender, EventArgs e)
        {
            ampl = int.Parse(amplUD.Value.ToString());
            applyAmplB.Enabled = false;
        }

        private void amplValueChanged(object sender, EventArgs e)
        {
            applyAmplB.Enabled = true;
        }

        private void createSound(object sender, EventArgs e)
        {
            sampleSounds.ampl = ampl;
            sampleSounds.signalsList = signalsList;
            sampleSounds.CreateSamples();
            this.Dispose();
        }

        private void testSound(object sender, EventArgs e)
        {
            bufferSample.SetData();
            int channel = Bass.BASS_SampleGetChannel(bufferSample.sampleHandle, false);
            Bass.BASS_ChannelPlay(channel, false);
        }
    }
}
