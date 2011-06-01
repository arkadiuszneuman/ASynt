using System;
using Un4seen.Bass;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;

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

        // Handle for sound array
        private GCHandle soundHandle;
        // DATA size in bytes for sound data + 44 for WAV header
        private byte[] soundData = new byte[352044];
        // Only sound - need to modify amplitude
        private short[] soundBuffer = new short[176000];
        private int freq;
        private int ampl;
        private List<SyntWave> signalsList;
        
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

        /// <summary>
        /// Konstruktor dźwięku wygenerowanego przez użytkownika
        /// </summary>
        /// <param name="Ampl">Wzmocnienie dźwieku</param>
        /// <param name="Freq">Częstotliwość dźwięku</param>
        /// <param name="_signalsList">Lista sygnałów do dodania</param>
        public Sound(int Ampl, int Freq, List<SyntWave> _signalsList)
        {
            ampl = Ampl;
            freq = Freq;
            signalsList = _signalsList;

            CreateSound();
            WavHeader().CopyTo(soundData, 0);
            for (int i = 0; i < 176000; ++i)
            {
                BitConverter.GetBytes(soundBuffer[i]).CopyTo(soundData, 44 + (i * 2));
            }
            soundHandle = GCHandle.Alloc(soundData, GCHandleType.Pinned);
            Stream = Bass.BASS_StreamCreateFile(soundHandle.AddrOfPinnedObject(), 0L, soundData.Length, BASSFlag.BASS_DEFAULT);
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

        /// <summary>
        /// Generuje dźwięk na podstawie listy sygnałów.
        /// </summary>
        public void CreateSound()
        {
            AddWave((int)Signals.Sinus, 0, 176000);

            foreach (SyntWave sw in signalsList)
            {
                AddWave(sw.signal, sw.from, sw.to);
            }
        }

        /// <summary>
        /// Dodaje do tablicy kolejną falę dźwiękową.
        /// </summary>
        /// <param name="signal">Typ fali dźwiękowej.</param>
        /// <param name="from">Początek (w tablicy z danymi) nowej fali dźwiękowej (jako numer próbki).</param>
        /// <param name="to">Koniec fali dźwiękowej (jako numer próbki).</param>
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
                soundBuffer[i] += buffer[i - from];
            }
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
                soundBuffer[i] = (short)((bNewAmpl * soundBuffer[i]) / bOldAmpl);
            }
        }

        /// <summary>
        /// Tworzy nagłówek pliku WAV - umożliwia to granie wygenerowanego dźwięku jako STREAM.
        /// </summary>
        /// <returns>Zwraca tablicę byte[] z nagłowkiem WAV.</returns>
        private static byte[] WavHeader()
        {
            short headerSize = 44;
            int _chunkID = 0x46464952;
            int rSize = 352036; // 20;
            int _format = 0x45564157;
            int _SubChunkID = 0x20746d66;
            int _subChunk1Size = 16;
            short audioFormat = 1;
            short nOfChannels = 2;
            int sampleRate = 44000;
            short bitsPerSample = 16;
            int ByteRate = (sampleRate * nOfChannels * (bitsPerSample / 8));
            short blockAlign = (short)(sampleRate * nOfChannels * (bitsPerSample / 8));
            int _SubChunk2ID = 0x61746164;
            int _subChunk2Size = 352000;

            byte[] header = new byte[headerSize];

            BitConverter.GetBytes(_chunkID).CopyTo(header, 0);
            BitConverter.GetBytes(rSize).CopyTo(header, 4);
            BitConverter.GetBytes(_format).CopyTo(header, 8);
            BitConverter.GetBytes(_SubChunkID).CopyTo(header, 12);
            BitConverter.GetBytes(_subChunk1Size).CopyTo(header, 16);
            BitConverter.GetBytes(audioFormat).CopyTo(header, 20);
            BitConverter.GetBytes(nOfChannels).CopyTo(header, 22);
            BitConverter.GetBytes(sampleRate).CopyTo(header, 24);
            BitConverter.GetBytes(ByteRate).CopyTo(header, 28);
            BitConverter.GetBytes(blockAlign).CopyTo(header, 32);
            BitConverter.GetBytes(bitsPerSample).CopyTo(header, 34);
            BitConverter.GetBytes(_SubChunk2ID).CopyTo(header, 36);
            BitConverter.GetBytes(_subChunk2Size).CopyTo(header, 40);

            return header;
        }
    }
}
