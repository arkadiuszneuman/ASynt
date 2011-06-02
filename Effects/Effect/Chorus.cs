using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Un4seen.Bass;
using ASynt.Keyboard;

namespace ASynt.Effects.Effect
{
    class Chorus : Effect
    {
        private List<BASS_DX8_CHORUS> chorus = new List<BASS_DX8_CHORUS>();
        private List<int> handles = new List<int>();
        public List<BASS_DX8_CHORUS> List { get { return chorus; } }

        /// <summary>
        /// Konstruktor klasy Chorus.
        /// </summary>
        /// <param name="keyboard">Obiekt klawiatury Keyboard.</param>
        public Chorus(Keyboard.Keyboard keyboard)
            : base(keyboard)
        {
        }

        /// <summary>
        /// Zwraca liczbę nałożonych efektów Chorus.
        /// </summary>
        public override int EffectsCount
        {
            get { return chorus.Count; }
        }

        /// <summary>
        /// Edycja efektu Chorus w słowniku.
        /// </summary>
        /// <param name="chor">Obiekt BASS_DX8_CHORUS.</param>
        /// <param name="d">Obiekt słownika.</param>
        private void EditChorus(BASS_DX8_CHORUS chor, Dictionary<string, float> d)
        {
            if (!d.ContainsKey("wetDryMix") || !d.ContainsKey("feedback") || !d.ContainsKey("delay")
                || !d.ContainsKey("depth") || !d.ContainsKey("frequency") || !d.ContainsKey("phase")
                || !d.ContainsKey("waveform"))
            {
                throw new ArgumentException("Brak wymaganych parametrów w dictionary");
            }

            chor.fWetDryMix = d["wetDryMix"];
            chor.fFeedback = d["feedback"];
            chor.fDelay = d["delay"];
            chor.fDepth = d["depth"];
            chor.fFrequency = d["frequency"];
            chor.lPhase = (BASSFXPhase)d["phase"];
            chor.lWaveform = (int)d["waveform"];
        }

        /// <summary>
        /// Dodanie efektu Chorus do słownika.
        /// </summary>
        /// <param name="d">Obiekt słownika.</param>
        public override void Add(Dictionary<string, float> d)
        {
            chorus.Add(new BASS_DX8_CHORUS());
            EditChorus(chorus.Last(), d);

            foreach (Key key in keys)
            {
                handles.Add(Bass.BASS_ChannelSetFX(key.KeySound.Stream, BASSFXType.BASS_FX_DX8_CHORUS, 1));
                if (handles.Last() == 0)
                {
                    throw new Exception("Błąd ustawienia chóru: " + Bass.BASS_ErrorGetCode());
                }

                Bass.BASS_FXSetParameters(handles.Last(), chorus.Last());
            }
        }

        /// <summary>
        /// Edycja efektu Chorus.
        /// </summary>
        /// <param name="d">Obiekt słownika.</param>
        public override void Edit(Dictionary<string, float> d)
        {
            if (!d.ContainsKey("which"))
            {
                throw new ArgumentException("Brak wymaganych parametrów w dictionary");
            }

            int which = (int)d["which"];

            EditChorus(chorus[which], d);

            for (int i = which * 12; i < which * 12 + 12; ++i)
                Bass.BASS_FXSetParameters(handles[i], chorus[which]);
        }

        /// <summary>
        /// Usunięcie efektu Chorus z kanału.
        /// </summary>
        /// <param name="which">Numer efektu do usunięcia.</param>
        public override void Delete(int which)
        {
            for (int i = 0; i < keys.Length; ++i)
            {
                Bass.BASS_ChannelRemoveFX(keys[i].KeySound.Stream, handles[i + which * 12]);
            }

            chorus.RemoveAt(which);
            handles.RemoveRange(which * 12, 11);
        }
    }
}
