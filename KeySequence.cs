using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASynt
{
    /// <summary>
    /// Struktura przetrzymująca czas oraz wciśnięty klawisz.
    /// </summary>
    public struct KeySequence
    {
        public long time;
        public byte key;

        public KeySequence(long Time, byte Key)
        {
            time = Time;
            key = Key;
        }

        public override String ToString()
        {
            return time.ToString() + ";" + key.ToString();
        }
    }
}
