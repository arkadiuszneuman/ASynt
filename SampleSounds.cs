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

        public SampleSounds()
        {
            samples = new Sample[12];
            CreateSamples();
        }

        private void CreateSamples()
        {
            for (int i = 0; i < 12; ++i)
            {
                samples[i] = new Sample();
                samples[i].CreateSound((i + 1) * 100);
            }
        }

        public int GetChannelHandle(int id) 
        {
            return Bass.BASS_SampleGetChannel(samples[id].sampleHandle, false);
        }
    }
}
