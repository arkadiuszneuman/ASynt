using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASynt
{
    /// <summary>
    /// Struktura przetrzymująca czas oraz wciśnięty klawisz.
    /// </summary>
    public struct KeySequence
    {
        private TimeSpan time;
        private Keys key;

        public KeySequence(TimeSpan Time, Keys Key)
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
