using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Un4seen.Bass;

namespace ASynt
{
    public class SampleSounds
    {
        private Sample[] samples;
        public List<SyntWave> signalsList { get; set; }
        public int ampl { get; set; }

        public SampleSounds()
        {
            samples = new Sample[12];
        }

        public void CreateSamples()
        {
            for (int i = 0; i < 12; ++i)
            {
                samples[i] = new Sample(ampl, (i + 1) * 100);
                samples[i].CreateSound(signalsList);
            }
        }

        public int GetChannelHandle(int id) 
        {
            return Bass.BASS_SampleGetChannel(samples[id].sampleHandle, false);
        }
    }
}
