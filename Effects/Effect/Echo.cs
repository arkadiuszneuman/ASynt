using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Un4seen.Bass;
using ASynt.Keyboard;

namespace ASynt.Effects.Effect
{
    class Echo : Effect
    {
        private List<BASS_DX8_ECHO> echo = new List<BASS_DX8_ECHO>();
        private List<int> handles = new List<int>();
        public List<BASS_DX8_ECHO> List { get { return echo; } }

        /// <summary>
        /// Konstrukor klasy Echo.
        /// </summary>
        /// <param name="keyboard">Obiekt klawiatury Keyboard.</param>
        public Echo(Keyboard.Keyboard keyboard)
            : base(keyboard)
        {
        }

        /// <summary>
        /// Usunięcie efektu Echo z kanału.
        /// </summary>
        /// <param name="which">Numer efektu do usunięcia.</param>
        public override void Delete(int which)
        {
            for (int i = 0; i < keys.Length; ++i)
            {
                Bass.BASS_ChannelRemoveFX(keys[i].KeySound.Stream, handles[i + which * 12]);
            }

            echo.RemoveAt(which);
            handles.RemoveRange(which * 12, 11);
        }

        /// <summary>
        /// Zwraca liczbę nałożonych efektów Echo.
        /// </summary>
        public override int EffectsCount
        {
            get { return echo.Count; }
        }

        /// <summary>
        /// Dodaje kolejne Echo do słownika.
        /// </summary>
        /// <param name="d">Obiekt słownika.</param>
        public override void Add(Dictionary<string, float> d)
        {
            if (!d.ContainsKey("wetDryMix") || !d.ContainsKey("feedback") || !d.ContainsKey("leftDelay") 
                || !d.ContainsKey("rightDelay") || !d.ContainsKey("panDelay"))
            {
                throw new ArgumentException("Brak wymaganych parametrów w dictionary");
            }

            echo.Add(new BASS_DX8_ECHO(d["wetDryMix"], d["feedback"], d["leftDelay"], d["rightDelay"], Convert.ToBoolean(d["panDelay"])));
            foreach (Key key in keys)
            {
                handles.Add(Bass.BASS_ChannelSetFX(key.KeySound.Stream, BASSFXType.BASS_FX_DX8_ECHO, 1));
                if (handles.Last() == 0)
                {
                    throw new Exception("Błąd ustawienia echa: " + Bass.BASS_ErrorGetCode());
                }

                Bass.BASS_FXSetParameters(handles.Last(), echo.Last());
            }
        }

        /// <summary>
        /// Edytuje echo w słowniku.
        /// </summary>
        /// <param name="d">Obiekt słownika.</param>
        public override void Edit(Dictionary<string, float> d)
        {
            if (!d.ContainsKey("wetDryMix") || !d.ContainsKey("feedback") || !d.ContainsKey("leftDelay")
                || !d.ContainsKey("rightDelay") || !d.ContainsKey("panDelay") || !d.ContainsKey("which"))
            {
                throw new ArgumentException("Brak wymaganych parametrów w dictionary");
            }

            int which = (int)d["which"];

            echo[which].fWetDryMix = d["wetDryMix"];
            echo[which].fFeedback = d["feedback"];
            echo[which].fLeftDelay = d["leftDelay"];
            echo[which].fRightDelay = d["rightDelay"];
            echo[which].lPanDelay = Convert.ToBoolean(d["panDelay"]);

            for (int i = which * 12; i < which * 12 + 12; ++i)
                Bass.BASS_FXSetParameters(handles[i], echo[which]);
        }
    }
}
