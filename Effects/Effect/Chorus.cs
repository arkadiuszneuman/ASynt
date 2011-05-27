using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Un4seen.Bass;

namespace ASynt.Effects.Effect
{
    class Chorus : Effect
    {
        private List<BASS_DX8_CHORUS> chorus = new List<BASS_DX8_CHORUS>();
        private List<int> echoHandles = new List<int>();
        public List<BASS_DX8_CHORUS> EchoList { get { return chorus; } }

        public Chorus(Keyboard.Keyboard keyboard)
            : base(keyboard)
        {
        }

        public override int EffectsCount
        {
            get { return chorus.Count; }
        }

        public override void Add(Dictionary<string, float> d)
        {
            if (!d.ContainsKey("wetDryMix") || !d.ContainsKey("feedback") || !d.ContainsKey("leftDelay")
                || !d.ContainsKey("rightDelay") || !d.ContainsKey("panDelay"))
            {
                throw new ArgumentException("Brak wymaganych parametrów w dictionary");
            }

            chorus.Add(new BASS_DX8_ECHO(d["wetDryMix"], d["feedback"], d["leftDelay"], d["rightDelay"], Convert.ToBoolean(d["panDelay"])));
            foreach (Key key in keys)
            {
                echoHandles.Add(Bass.BASS_ChannelSetFX(key.KeySound.Stream, BASSFXType.BASS_FX_DX8_ECHO, 1));
                if (echoHandles.Last() == 0)
                {
                    throw new Exception("Błąd ustawienia echa: " + Bass.BASS_ErrorGetCode());
                }

                Bass.BASS_FXSetParameters(echoHandles.Last(), chorus.Last());
            }
        }

        public override void Edit(Dictionary<string, float> d)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int which)
        {
            throw new NotImplementedException();
        }
    }
}
