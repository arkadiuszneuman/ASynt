using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Un4seen.Bass;
using ASynt.Keyboard;

namespace ASynt.Effects.Effect
{
    class Gargle : Effect
    {
        private List<BASS_DX8_GARGLE> gargle = new List<BASS_DX8_GARGLE>();
        private List<int> handles = new List<int>();
        public List<BASS_DX8_GARGLE> List { get { return gargle; } }

        public Gargle(Keyboard.Keyboard keyboard)
            : base(keyboard)
        {
        }

        public override int EffectsCount
        {
            get { return gargle.Count; }
        }

        private void EditGargle(BASS_DX8_GARGLE chor, Dictionary<string, float> d)
        {
            if (!d.ContainsKey("rateHz") || !d.ContainsKey("waveShape"))
            {
                throw new ArgumentException("Brak wymaganych parametrów w dictionary");
            }

            chor.dwRateHz = (int)d["rateHz"];
            chor.dwWaveShape = (int)d["waveShape"];
        }

        public override void Add(Dictionary<string, float> d)
        {
            gargle.Add(new BASS_DX8_GARGLE());
            EditGargle(gargle.Last(), d);

            foreach (Key key in keys)
            {
                handles.Add(Bass.BASS_ChannelSetFX(key.KeySound.Stream, BASSFXType.BASS_FX_DX8_GARGLE, 1));
                if (handles.Last() == 0)
                {
                    throw new Exception("Błąd ustawienia gargle: " + Bass.BASS_ErrorGetCode());
                }

                Bass.BASS_FXSetParameters(handles.Last(), gargle.Last());
            }
        }

        public override void Edit(Dictionary<string, float> d)
        {
            if (!d.ContainsKey("which"))
            {
                throw new ArgumentException("Brak wymaganych parametrów w dictionary");
            }

            int which = (int)d["which"];

            EditGargle(gargle[which], d);

            for (int i = which * 12; i < which * 12 + 12; ++i)
                Bass.BASS_FXSetParameters(handles[i], gargle[which]);
        }

        public override void Delete(int which)
        {
            for (int i = 0; i < keys.Length; ++i)
            {
                Bass.BASS_ChannelRemoveFX(keys[i].KeySound.Stream, handles[i + which * 12]);
            }

            gargle.RemoveAt(which);
            handles.RemoveRange(which * 12, 12);
        }
    }
}
