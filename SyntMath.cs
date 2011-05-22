using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASynt
{
    public class SyntMath
    {
        public static short[] Sinus(double ampl, int freq)
        {
            short[] data = new short[44100];
            for (int i = 0; i < 44100; ++i)
            {
                data[i] = (short)((ampl * short.MaxValue) * Math.Sin((2 * Math.PI * i * freq) / 44100));
            }
            return data;
        }
    }
}
