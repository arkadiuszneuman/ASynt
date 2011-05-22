using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASynt
{
    public class SyntMath
    {
        public static short[] Sinus(double ampl, int freq, int samplesCount)
        {
            short[] data = new short[samplesCount];
            for (int i = 0; i < samplesCount; ++i)
            {
                data[i] = (short)((ampl * short.MaxValue) * Math.Sin((2 * Math.PI * i * freq) / 44100));
            }
            return data;
        }

        public static short[] AbsSinus(double ampl, int freq, int samplesCount)
        {
            short[] data = new short[samplesCount];
            for (int i = 0; i < samplesCount; ++i)
            {
                data[i] = (short)((ampl * short.MaxValue) * Math.Abs(Math.Sin((2 * Math.PI * i * freq) / 44100)));
            }
            return data;
        }

        public static short[] Cosinus(double ampl, int freq, int samplesCount)
        {
            short[] data = new short[samplesCount];
            for (int i = 0; i < samplesCount; ++i)
            {
                data[i] = (short)((ampl * short.MaxValue) * Math.Cos((2 * Math.PI * i * freq) / 44100));
            }
            return data;
        }

        public static short[] AbsCosinus(double ampl, int freq, int samplesCount)
        {
            short[] data = new short[samplesCount];
            for (int i = 0; i < samplesCount; ++i)
            {
                data[i] = (short)((ampl * short.MaxValue) * Math.Abs(Math.Cos((2 * Math.PI * i * freq) / 44100)));
            }
            return data;
        }

        public static short[] Tangens(double ampl, int freq, int samplesCount)
        {
            short[] data = new short[samplesCount];
            for (int i = 0; i < samplesCount; ++i)
            {
                data[i] = (short)((ampl * short.MaxValue) * Math.Tan((2 * Math.PI * i * freq) / 44100));
            }
            return data;
        }

        public static short[] AbsTangens(double ampl, int freq, int samplesCount)
        {
            short[] data = new short[samplesCount];
            for (int i = 0; i < samplesCount; ++i)
            {
                data[i] = (short)((ampl * short.MaxValue) * Math.Abs(Math.Tan((2 * Math.PI * i * freq) / 44100)));
            }
            return data;
        }

        public static short[] Square(double ampl, int freq, int samplesCount)
        {
            short[] data = new short[samplesCount];
            for (int i = 0; i < samplesCount; ++i)
            {
                data[i] = (short)((ampl * short.MaxValue) * Math.Sign(Math.Sin((2 * Math.PI * i * freq) / 44100)));
            }
            return data;
        }

        public static short[] WhiteNoise(double ampl, int freq, int samplesCount)
        {
            Random random = new Random();
            short[] data = new short[samplesCount];
            for (int i = 0; i < samplesCount; ++i)
            {
                data[i] = (short)((ampl * short.MaxValue) * (2 * random.Next(short.MaxValue) / short.MinValue - 1));
            }
            return data;
        }
    }
}
