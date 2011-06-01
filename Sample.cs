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

    /// <summary>
    /// Klasa tworząca próbkę dźwięku SAMPLE. Użyta jest jedynie w SoundGenerator - reszta jest oparta o STREAMy.
    /// Powodem użycia jest szybkość tworzenia - nie trzeba tworzyć nagłowka WAV oraz przeliczać tablicy INT16 na BYTE.
    /// </summary>
    public class Sample
    {
        public int sampleHandle { get; private set; }
        public int channelHandle { get; private set; }
        public short[] data = new short[176000]; 
        private int freq;
        private int ampl;

        /// <summary>
        /// Konstruktor klasy SAMPLE. Tworzy uchwyt do odtwarzania.
        /// </summary>
        /// <param name="Ampl">Wzmocnienie tworzonego sygnału.</param>
        /// <param name="Freq">Częstotliwość sygnału.</param>
        public Sample(int Ampl, int Freq)
        {
            ampl = Ampl;
            freq = Freq;
            sampleHandle = Bass.BASS_SampleCreate(352000, 44000, 2, 1, BASSFlag.BASS_SAMPLE_OVER_POS);
            AddWave((int)Signals.Sinus, 0, 176000);
        }

        /// <summary>
        /// Dodaje do tablicy kolejną falę dźwiękową.
        /// </summary>
        /// <param name="signal">Typ fali dźwiękowej.</param>
        /// <param name="from">Początek (w tablicy z danymi) nowej fali dźwiękowej.</param>
        /// <param name="to">Koniec fali dźwiękowej.</param>
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

        /// <summary>
        /// Wpycha dane do uchwytu. ???Niepotrzebne???
        /// </summary>
        public void SetData()
        {
            Bass.BASS_SampleSetData(sampleHandle, data);
        }

        /// <summary>
        /// Zmienia amplitudę wygenerowanego sygnału.
        /// </summary>
        /// <param name="oldAmpl">Stara wartość amplitudy.</param>
        /// <param name="newAmpl">Nowa wartość amplitudy.</param>
        public void ChangeAmpl(int oldAmpl, int newAmpl)
        {
            ampl = newAmpl;

            double bOldAmpl = oldAmpl / 100.0;
            double bNewAmpl = newAmpl / 100.0;

            for (int i = 0; i < 176000; ++i)
            {
                data[i] = (short)((bNewAmpl * data[i]) / bOldAmpl);
            }
        }
    }
}