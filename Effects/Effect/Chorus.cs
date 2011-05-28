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

        public Chorus(Keyboard.Keyboard keyboard)
            : base(keyboard)
        {
        }

        public override int EffectsCount
        {
            get { return chorus.Count; }
        }

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
