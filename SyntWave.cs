using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASynt
{
    public struct SyntWave
    {
        public int signal;
        public int from;
        public int to;

        public SyntWave(int Signal, int From, int To)
        {
            this.signal = Signal;
            this.from = From;
            this.to = To;            
        }
    }
}
