using System;
using Un4seen.Bass;

namespace ASynt.Player
{
    public class SoundPlayer
    {
        /// <summary>
        /// Konstruktor klasy SoundPlayer. Inicjalizuje bibliotekę Bass.dll.net
        /// </summary>
        public SoundPlayer()
        {
            if (!Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero))
            {
                throw new InvalidOperationException("Nie można zainicjalizować bilioteki bass.dll");
            }
        }

        /// <summary>
        /// Destruktor klasy SoundPlayer. Zwalnia zasoby zajęte przez Bass.dll.net
        /// </summary>
        ~SoundPlayer()
        {
            Bass.BASS_Free();
        }

        /// <summary>
        /// Odtwarza wybrany dźwięk
        /// </summary>
        /// <param name="sound">Dźwięk, który ma być odtworzony</param>
        public void Play(Sound sound)
        {
            if (sound != null)
            {
                if (sound.Stream != 0)
                {
                    //odtwarza wybrany kanał
                    Bass.BASS_ChannelPlay(sound.Stream, false);
                }
                else
                {
                    throw new ArgumentException("Stream pliku sound jest pusty - czy ścieżka do pliku jest prawidłowa?");
                }
            }
            else
            {
                throw new NullReferenceException("Dźwięk jest pusty");
            }
        }
    }
}
