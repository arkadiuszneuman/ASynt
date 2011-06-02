using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASynt
{
    /// <summary>
    /// Struktura przetrzymująca informację o pojedyńczym sygnale dodawanym do generowanego dźwięku.
    /// </summary>
    public struct SyntWave
    {
        public int signal;
        public int from;
        public int to;

        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="Signal">Typ sygnału.</param>
        /// <param name="From">Początek sygnału (jako numer próbki).</param>
        /// <param name="To">Koniec sygnału (jako numer próbki).</param>
        public SyntWave(int Signal, int From, int To)
        {
            signal = Signal;
            from = From;
            to = To;            
        }
    }
}
