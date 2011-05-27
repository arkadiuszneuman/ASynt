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
        private List<int> echoHandles = new List<int>();
        public List<BASS_DX8_ECHO> EchoList { get { return echo; } }

        public Echo(Keyboard.Keyboard keyboard)
            : base(keyboard)
        {
        }

        public override void Delete(int which)
        {
            for (int i = 0; i < keys.Length; ++i)
            {
                Bass.BASS_ChannelRemoveFX(keys[i].KeySound.Stream, echoHandles[i + which * 12]);
            }

            echo.RemoveAt(which);
            echoHandles.RemoveRange(which * 12, 11);
        }

        public override int EffectsCount
        {
            get { return echo.Count; }
        }

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
                echoHandles.Add(Bass.BASS_ChannelSetFX(key.KeySound.Stream, BASSFXType.BASS_FX_DX8_ECHO, 1));
                if (echoHandles.Last() == 0)
                {
                    throw new Exception("Błąd ustawienia echa: " + Bass.BASS_ErrorGetCode());
                }

                Bass.BASS_FXSetParameters(echoHandles.Last(), echo.Last());
            }
        }

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
                Bass.BASS_FXSetParameters(echoHandles[i], echo[which]);
        }
    }
}
