using System;
using Un4seen.Bass;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ASynt.Player
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

    public class Sound
    {
        public int Stream {get; private set;}

        public int sampleHandle { get; private set; }
        public int channelHandle { get; private set; }
        private short[] data = new short[44000]; // Sample rate = 44100; 44100 bajtów = 22050 INT16
        private int freq;
        private int ampl;

        /// <summary>
        /// Konstruktor dźwięku
        /// </summary>
        /// <param name="name">Nazwa pliku z dźwiękiem (z lub bez rozszerzenia)</param>
        public Sound(string name)
        {
            if (name.Substring(name.Length - 4).ToLower() == ".wav")
            {
                name = name.Substring(0, name.Length - 4);
            }

            String plik = Environment.CurrentDirectory + @"\samples\" + name + ".wav";
            Stream = Bass.BASS_StreamCreateFile(plik, 0, 0, BASSFlag.BASS_DEFAULT);

            if (Stream == 0)
            {
                throw new Exception("Nie można znaleźć pliku: " + plik);
            }
        }

        public Sound(int Ampl, int Freq, List<SyntWave> signalsList)
        {
            ampl = Ampl;
            freq = Freq;
            sampleHandle = Bass.BASS_SampleCreate(88000, 44100, 2, 1, BASSFlag.BASS_SAMPLE_OVER_POS);
            AddWave((int)Signals.Sinus, 0, 44000);
            CreateSound(signalsList);
        }

        /// <summary>
        /// Destruktor dźwięku
        /// </summary>
        ~Sound()
        {
            Bass.BASS_StreamFree(Stream);
        }

        /// <summary>
        /// Zmiana częstotliwości dźwięku
        /// </summary>
        /// <param name="frequency">częstotliwość od 100 do 100000</param>
        public void ChangeFrequency(int frequency)
        {
            if (!Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_FREQ, frequency))
            {
                throw new ArgumentException("Nie można ustawić takiej częstotliwości. Czy częstotliwość mieści się w zakresie od 100 do 100000?");
            }
        }

        public void CreateSound(List<SyntWave> signalsList)
        {
            foreach (SyntWave sw in signalsList)
            {
                AddWave(sw.signal, sw.from, sw.to);
            }
            Bass.BASS_SampleSetData(sampleHandle, data);
            Stream = Bass.BASS_SampleGetChannel(sampleHandle, false);
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

        public void ChangeAmpl(int oldAmpl, int newAmpl)
        {
            ampl = newAmpl;

            double bOldAmpl = oldAmpl / 100.0;
            double bNewAmpl = newAmpl / 100.0;

            for (int i = 0; i < 44000; ++i)
            {
                data[i] = (short)((bNewAmpl * data[i]) / bOldAmpl);
            }
        }
    }

    public class Sample
    {
        public int sampleHandle { get; private set; }
        public int channelHandle { get; private set; }
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

        public Sample(int Ampl, int Freq, List<SyntWave> signalsList)
        {
            ampl = Ampl;
            freq = Freq;
            sampleHandle = Bass.BASS_SampleCreate(88000, 44100, 2, 1, BASSFlag.BASS_SAMPLE_OVER_POS);
            AddWave((int)Signals.Sinus, 0, 44000);
            CreateSound(signalsList);
        }

        public void CreateSound(List<SyntWave> signalsList)
        {
            foreach (SyntWave sw in signalsList)
            {
                AddWave(sw.signal, sw.from, sw.to);
            }
            Bass.BASS_SampleSetData(sampleHandle, data);
            channelHandle = Bass.BASS_SampleGetChannel(sampleHandle, false);
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

        public void ChangeAmpl(int oldAmpl, int newAmpl)
        {
            ampl = newAmpl;

            double bOldAmpl = oldAmpl / 100.0;
            double bNewAmpl = newAmpl / 100.0;

            for (int i = 0; i < 44000; ++i)
            {
                data[i] = (short)((bNewAmpl * data[i]) / bOldAmpl);
            }
        }
    }
}
