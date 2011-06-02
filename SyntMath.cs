using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASynt
{
    enum Signals
    {
        Sinus,
        AbsSinus,
        Cosinus,
        AbsCosinus,
        Tangens,
        AbsTangens,
        Square,
        WhiteNoise
    };

    /// <summary>
    /// Klasa statyczna, zwracająca różne typy sygnałów. Każda funkcja przyjmuje wzmocnienie sygnału,
    /// częstotliwość oraz liczbę próbek do wygenerowania.
    /// </summary>
    public class SyntMath
    {
        /// <summary>
        /// Statyczna funkcja generująca odpowiedni sygnał.
        /// </summary>
        /// <param name="signal">Jaki sygnał.</param>
        /// <param name="amplitude">Wzmocnienie sygnału.</param>
        /// <param name="freq">Częstotliwość sygnału.</param>
        /// <param name="samplesCount">Liczba próbek.</param>
        /// <returns>Tablicę typu short z wygenerowanym sygnałem.</returns>
        public static short[] Wave(int signal, double amplitude, int freq, int samplesCount)
        {
            if (signal == (int)Signals.Sinus)
            {
                return Sinus(amplitude, freq, samplesCount);
            }
            else if (signal == (int)Signals.AbsSinus)
            {
                return AbsSinus(amplitude, freq, samplesCount);
            }
            else if (signal == (int)Signals.Cosinus)
            {
                return Cosinus(amplitude, freq, samplesCount);
            }
            else if (signal == (int)Signals.AbsCosinus)
            {
                return AbsCosinus(amplitude, freq, samplesCount);
            }
            else if (signal == (int)Signals.Tangens)
            {
                return Tangens(amplitude, freq, samplesCount);
            }
            else if (signal == (int)Signals.AbsTangens)
            {
                return AbsTangens(amplitude, freq, samplesCount);
            }
            else if (signal == (int)Signals.Square)
            {
                return Square(amplitude, freq, samplesCount);
            }
            else if (signal == (int)Signals.WhiteNoise)
            {
                return WhiteNoise(amplitude, freq, samplesCount);
            }
            else
            {
                return Sinus(amplitude, freq, samplesCount);
            }
        }

        private static short[] Sinus(double ampl, int freq, int samplesCount)
        {
            short[] data = new short[samplesCount];
            for (int i = 0; i < samplesCount; ++i)
            {
                data[i] = (short)((ampl * short.MaxValue) * Math.Sin((2 * Math.PI * i * freq) / 44000));
            }
            return data;
        }

        private static short[] AbsSinus(double ampl, int freq, int samplesCount)
        {
            short[] data = new short[samplesCount];
            for (int i = 0; i < samplesCount; ++i)
            {
                data[i] = (short)((ampl * short.MaxValue) * Math.Abs(Math.Sin((2 * Math.PI * i * freq) / 44000)));
            }
            return data;
        }

        private static short[] Cosinus(double ampl, int freq, int samplesCount)
        {
            short[] data = new short[samplesCount];
            for (int i = 0; i < samplesCount; ++i)
            {
                data[i] = (short)((ampl * short.MaxValue) * Math.Cos((2 * Math.PI * i * freq) / 44000));
            }
            return data;
        }

        private static short[] AbsCosinus(double ampl, int freq, int samplesCount)
        {
            short[] data = new short[samplesCount];
            for (int i = 0; i < samplesCount; ++i)
            {
                data[i] = (short)((ampl * short.MaxValue) * Math.Abs(Math.Cos((2 * Math.PI * i * freq) / 44000)));
            }
            return data;
        }

        private static short[] Tangens(double ampl, int freq, int samplesCount)
        {
            short[] data = new short[samplesCount];
            for (int i = 0; i < samplesCount; ++i)
            {
                data[i] = (short)((ampl * short.MaxValue) * Math.Tan((2 * Math.PI * i * freq) / 44000));
            }
            return data;
        }

        private static short[] AbsTangens(double ampl, int freq, int samplesCount)
        {
            short[] data = new short[samplesCount];
            for (int i = 0; i < samplesCount; ++i)
            {
                data[i] = (short)((ampl * short.MaxValue) * Math.Abs(Math.Tan((2 * Math.PI * i * freq) / 44000)));
            }
            return data;
        }

        private static short[] Square(double ampl, int freq, int samplesCount)
        {
            short[] data = new short[samplesCount];
            for (int i = 0; i < samplesCount; ++i)
            {
                data[i] = (short)((ampl * short.MaxValue) * Math.Sign(Math.Sin((2 * Math.PI * i * freq) / 44000)));
            }
            return data;
        }

        private static short[] WhiteNoise(double ampl, int freq, int samplesCount)
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
