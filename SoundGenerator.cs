using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASynt
{
    enum Signals
    {
        Sinus
    };

    public partial class SoundGenerator : Form
    {
        private Sample bufferSample;
        private List<int> signalsList;
        private int checkedSignal;

        public SoundGenerator()
        {
            InitializeComponent();
            checkedSignal = -1;
            signalsList = new List<int>();
            bufferSample = new Sample();
        }

        private void SignalChanged(object sender, EventArgs e)
        {
            checkedSignal = int.Parse(((RadioButton)sender).Tag.ToString());
        }

        private void addSignal(object sender, EventArgs e)
        {
            if (checkedSignal != -1)
            {
                signalsList.Add(checkedSignal);
            }
        }
    }
}
