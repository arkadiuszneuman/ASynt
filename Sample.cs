using System;
using Un4seen.Bass;

namespace ASynt 
{
    public class Sample
    {
        public int sampleHandle;
        private short[] data = new short[44100]; // Sample rate = 44100; 44100 bajtów = 22050 INT16
        
        public Sample()
	    {
            sampleHandle = Bass.BASS_SampleCreate(88200, 44100, 2, 1, BASSFlag.BASS_SAMPLE_OVER_POS);
	    }

        public void CreateSound(int freq)
        {
            data = SyntMath.Sinus(0.25, freq);

            Bass.BASS_SampleSetData(sampleHandle, data);
        }
    }
}