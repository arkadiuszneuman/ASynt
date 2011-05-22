using System;
using Un4seen.Bass;
using System.Windows.Forms;

namespace ASynt.Player
{
    public class Sound
    {
        public int Stream {get; private set;}

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
    }
}
