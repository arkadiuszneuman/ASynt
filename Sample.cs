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
    enum Signals
    {
        Sinus,
        AbsSinus,
        Cosinus,
        AbsCosinus,
        Tangens,
        AbsTangens,
        Square,
        WhiteNoise
    };

    public class Sample
    {
        public int sampleHandle { get; private set; }
        private short[] data = new short[44000]; // Sample rate = 44100; 44100 bajtów = 22050 INT16
        private int freq;
        private int ampl;
        
        public Sample(int Ampl, int Freq)
	    {
            ampl = Ampl;
            freq = Freq;
            sampleHandle = Bass.BASS_SampleCreate(88000, 44100, 2, 1, BASSFlag.BASS_SAMPLE_OVER_POS);
            AddWave((int)Signals.Sinus, 0, 44000);
	    }

        public void CreateSound(List<SyntWave> signalsList)
        {
            foreach (SyntWave sw in signalsList)
            {
                AddWave(sw.signal, sw.from, sw.to);
            }
            Bass.BASS_SampleSetData(sampleHandle, data);
        }

        public void AddWave(int signal, int from, int to)
        {
            int samplesCount = to - from;
            short[] buffer = new short[samplesCount];
            double amplitude = ampl / 100.0;

            if (signal == (int)Signals.Sinus)
            {                
                buffer = SyntMath.Sinus(amplitude, freq, samplesCount);
            }

            if (signal == (int)Signals.AbsSinus)
            {
                buffer = SyntMath.AbsSinus(amplitude, freq, samplesCount);
            }

            if (signal == (int)Signals.Cosinus)
            {
                buffer = SyntMath.Cosinus(amplitude, freq, samplesCount);
            }

            if (signal == (int)Signals.AbsCosinus)
            {
                buffer = SyntMath.AbsCosinus(amplitude, freq, samplesCount);
            }

            if (signal == (int)Signals.Tangens)
            {
                buffer = SyntMath.Tangens(amplitude, freq, samplesCount);
            }

            if (signal == (int)Signals.AbsTangens)
            {
                buffer = SyntMath.AbsTangens(amplitude, freq, samplesCount);
            }

            if (signal == (int)Signals.Square)
            {
                buffer = SyntMath.Square(amplitude, freq, samplesCount);
            }

            if (signal == (int)Signals.WhiteNoise)
            {
                buffer = SyntMath.WhiteNoise(amplitude, freq, samplesCount);
            }

            for (int i = from; i < to; ++i)
            {
                data[i] += buffer[i - from];
            }
        }

        public void SetData()
        {
            Bass.BASS_SampleSetData(sampleHandle, data);
        }
    }
}