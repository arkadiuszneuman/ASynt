using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Un4seen.Bass;
using ASynt.Keyboard;

namespace ASynt.Effects.Effect
{
    class Reverb : Effect
    {
        private List<BASS_DX8_REVERB> reverbs = new List<BASS_DX8_REVERB>();
        private List<int> handles = new List<int>();
        public List<BASS_DX8_REVERB> List { get { return reverbs; } }

        /// <summary>
        /// Konstruktor klasy Reverb.
        /// </summary>
        /// <param name="keyboard">Obiekt klawiatury Keyboard.</param>
        public Reverb(Keyboard.Keyboard keyboard)
            : base(keyboard)
        {
        }

        /// <summary>
        /// Zwraca liczbę nałożonych efektów Reverb.
        /// </summary>
        public override int EffectsCount
        {
            get { return reverbs.Count; }
        }

        /// <summary>
        /// Edycja efektu Reverb w słowniku.
        /// </summary>
        /// <param name="chor">Obiekt BASS_DX8_REVERB.</param>
        /// <param name="d">Obiekt słownika.</param>
        private void EditReverb(BASS_DX8_REVERB reverb, Dictionary<string, float> d)
        {
            if (!d.ContainsKey("ratio") || !d.ContainsKey("gain") || !d.ContainsKey("mix") || !d.ContainsKey("time"))
            {
                throw new ArgumentException("Brak wymaganych parametrów w dictionary");
            }

            reverb.fHighFreqRTRatio = d["ratio"];
            reverb.fInGain = d["gain"];
            reverb.fReverbMix = d["mix"];
            reverb.fReverbTime = d["time"];
        }

        /// <summary>
        /// Dodanie efektu Reverb do słownika.
        /// </summary>
        /// <param name="d">Obiekt słownika.</param>
        public override void Add(Dictionary<string, float> d)
        {
            reverbs.Add(new BASS_DX8_REVERB());
            EditReverb(reverbs.Last(), d);

            foreach (Key key in keys)
            {
                handles.Add(Bass.BASS_ChannelSetFX(key.KeySound.Stream, BASSFXType.BASS_FX_DX8_REVERB, 1));
                if (handles.Last() == 0)
                {
                    throw new Exception("Błąd ustawienia gargle: " + Bass.BASS_ErrorGetCode());
                }

                Bass.BASS_FXSetParameters(handles.Last(), reverbs.Last());
            }
        }

        /// <summary>
        /// Edycja efektu Reverb.
        /// </summary>
        /// <param name="d">Obiekt słownika.</param>
        public override void Edit(Dictionary<string, float> d)
        {
            if (!d.ContainsKey("which"))
            {
                throw new ArgumentException("Brak wymaganych parametrów w dictionary");
            }

            int which = (int)d["which"];

            EditReverb(reverbs[which], d);

            for (int i = which * 12; i < which * 12 + 12; ++i)
                Bass.BASS_FXSetParameters(handles[i], reverbs[which]);
        }

        /// <summary>
        /// Usunięcie efektu Reverb z kanału.
        /// </summary>
        /// <param name="which">Numer efektu do usunięcia.</param>
        public override void Delete(int which)
        {
            for (int i = 0; i < keys.Length; ++i)
            {
                Bass.BASS_ChannelRemoveFX(keys[i].KeySound.Stream, handles[i + which * 12]);
            }

            reverbs.RemoveAt(which);
            handles.RemoveRange(which * 12, 12);
        }
    }
}
