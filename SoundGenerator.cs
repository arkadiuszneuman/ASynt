using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Un4seen.Bass;

namespace ASynt
{
    public partial class SoundGenerator : Form
    {
        private ASynt.Keyboard.Keyboard keyboard;
        private Sample bufferSample;
        private List<SyntWave> signalsList;
        private int checkedSignal;
        private int ampl;
        private int currentSignalInfo = 0;

        /// <summary>
        /// Konstruktor klasy SoundGenerator.
        /// </summary>
        /// <param name="_sampleSounds">Kontener na 12 wygenerowanych dźwięków.</param>
        public SoundGenerator(ASynt.Keyboard.Keyboard _keyboard)
        {
            InitializeComponent();
            this.keyboard = _keyboard;

            checkedSignal = -1;
            signalsList = new List<SyntWave>();
            bufferSample = new Sample(25, 440); //2500 30
            ampl = 25;
            UpdateControls();
        }

        /// <summary>
        /// Reakcja na wybranie sygnału poprzez RadioButtony.
        /// </summary>
        private void SignalChanged(object sender, EventArgs e)
        {
            checkedSignal = int.Parse(((RadioButton)sender).Tag.ToString());
            addB.Enabled = true;
        }

        /// <summary>
        /// Dodanie sygnału do listy oraz sampla buforowego.
        /// </summary>
        private void AddSignal(object sender, EventArgs e)
        {
            if (checkedSignal != -1)
            {
                int to = (int)toTB.Value;
                int from = (int)fromTB.Value;

                to *= 44;
                from *= 44;
                signalsList.Add(new SyntWave(checkedSignal, from, to));
                bufferSample.AddWave(checkedSignal, from, to);
                ShowSignalInfo(signalsList.Count - 1);
            }
        }

        /// <summary>
        /// Zatwierdza zmianę wzmocnienia.
        /// </summary>
        private void ApplyGain(object sender, EventArgs e)
        {
            int oldAmpl = ampl;
            ampl = int.Parse(amplUD.Value.ToString());
            applyAmplB.Enabled = false;
            bufferSample.ChangeAmpl(oldAmpl, ampl);
        }

        /// <summary>
        /// Umożliwia zatwierdzenie zmiany wzmocnienia.
        /// </summary>
        private void AmplValueChanged(object sender, EventArgs e)
        {
            applyAmplB.Enabled = true;
        }

        /// <summary>
        /// Generuje dźwięki i przypisuje je do odpowiednich klawiszy.
        /// </summary>        
        private void CreateSound(object sender, EventArgs e)
        {
            keyboard.smallKeys[0].KeySound = new ASynt.Player.Sound(ampl, (int)sKeyFreq1.Value, signalsList);
            keyboard.smallKeys[1].KeySound = new ASynt.Player.Sound(ampl, (int)sKeyFreq2.Value, signalsList);
            keyboard.smallKeys[2].KeySound = new ASynt.Player.Sound(ampl, (int)sKeyFreq3.Value, signalsList);
            keyboard.smallKeys[3].KeySound = new ASynt.Player.Sound(ampl, (int)sKeyFreq4.Value, signalsList);
            keyboard.smallKeys[4].KeySound = new ASynt.Player.Sound(ampl, (int)sKeyFreq5.Value, signalsList);

            keyboard.keys[0].KeySound = new ASynt.Player.Sound(ampl, (int)bKeyFreq1.Value, signalsList);
            keyboard.keys[1].KeySound = new ASynt.Player.Sound(ampl, (int)bKeyFreq2.Value, signalsList);
            keyboard.keys[2].KeySound = new ASynt.Player.Sound(ampl, (int)bKeyFreq3.Value, signalsList);
            keyboard.keys[3].KeySound = new ASynt.Player.Sound(ampl, (int)bKeyFreq4.Value, signalsList);
            keyboard.keys[4].KeySound = new ASynt.Player.Sound(ampl, (int)bKeyFreq5.Value, signalsList);
            keyboard.keys[5].KeySound = new ASynt.Player.Sound(ampl, (int)bKeyFreq6.Value, signalsList);
            keyboard.keys[6].KeySound = new ASynt.Player.Sound(ampl, (int)bKeyFreq7.Value, signalsList);

            this.Dispose();
        }

        /// <summary>
        /// Odtawrza stworzony dźwięk.
        /// </summary>
        private void TestSound(object sender, EventArgs e)
        {
            bufferSample.SetData();
            int channel = Bass.BASS_SampleGetChannel(bufferSample.sampleHandle, false);
            Bass.BASS_ChannelPlay(channel, false);
        }

        /// <summary>
        /// Uaktualnia stan kontrolek.
        /// </summary>
        private void UpdateControls()
        {
            if (signalsList.Count > 1)
            {
                if (currentSignalInfo > 0 && currentSignalInfo < signalsList.Count - 1)
                {
                    firstPageB.Enabled = true;
                    prevPageB.Enabled = true;
                    nextPageB.Enabled = true;
                    lastPageB.Enabled = true;
                }

                if (currentSignalInfo == 0)
                {
                    firstPageB.Enabled = false;
                    prevPageB.Enabled = false;
                    nextPageB.Enabled = true;
                    lastPageB.Enabled = true;
                }

                if (currentSignalInfo == signalsList.Count - 1)
                {
                    firstPageB.Enabled = true;
                    prevPageB.Enabled = true;
                    nextPageB.Enabled = false;
                    lastPageB.Enabled = false;
                }
            }
            else
            {
                if (signalsList.Count == 0)
                {
                    firstPageB.Enabled = false;
                    prevPageB.Enabled = false;
                    nextPageB.Enabled = false;
                    lastPageB.Enabled = false;
                    deleteAllSignalsB.Enabled = false;
                    signalPreviewB.Enabled = false;
                    signalDeleteB.Enabled = false;
                }

                firstPageB.Enabled = false;
                prevPageB.Enabled = false;
                nextPageB.Enabled = false;
                lastPageB.Enabled = false;
            }

            if (signalsList.Count != 0)
            {
                deleteAllSignalsB.Enabled = true;
                signalPreviewB.Enabled = true;
                signalDeleteB.Enabled = true;
            }
        }

        /// <summary>
        /// Pokazuje dane o wybranym sygnale z listy.
        /// </summary>
        private void ShowSignalInfo(int signalNumber)
        {
            infoAL1.Text = ((Signals)(signalsList[signalNumber].signal)).ToString();
            infoAL2.Text = (signalsList[signalNumber].from/44).ToString();                                
            infoAL3.Text = (signalsList[signalNumber].to/44).ToString();
            currentSignalInfo = signalNumber;
            UpdateControls();
        }

        /// <summary>
        /// Pokazuje pierwszy sygnał na liście.
        /// </summary>
        private void FirstPage(object sender, EventArgs e)
        {
            ShowSignalInfo(0);
        }

        /// <summary>
        /// Pokazuje ostatni sygnał na liście.
        /// </summary>
        private void LastPage(object sender, EventArgs e)
        {
            ShowSignalInfo(signalsList.Count - 1);
        }

        /// <summary>
        /// Pokazuje poprzedni sygnał z listy.
        /// </summary>
        private void PrevPage(object sender, EventArgs e)
        {
            ShowSignalInfo(currentSignalInfo - 1);
        }

        /// <summary>
        /// Pokazuje następny sygnał na liście.
        /// </summary>
        private void NextPage(object sender, EventArgs e)
        {
            ShowSignalInfo(currentSignalInfo + 1);
        }

        /// <summary>
        /// Usuwa wszystkie sygnały z listy.
        /// </summary>
        private void DeleteAllSignals(object sender, EventArgs e)
        {
            signalsList.Clear();
            infoAL1.Text = "-";
            infoAL2.Text = "-";
            infoAL3.Text = "-";
            UpdateControls();
            bufferSample = new Sample(ampl, 440);
        }

        /// <summary>
        /// Usuwa wybrany sygnał z listy.
        /// </summary>
        private void DeleteSignalFromList(object sender, EventArgs e)
        {
            signalsList.RemoveAt(currentSignalInfo);
            if (signalsList.Count == 0)
            {
                infoAL1.Text = "-";
                infoAL2.Text = "-";
                infoAL3.Text = "-";
            }
            else
            {
                if (currentSignalInfo == 0)
                {
                    ShowSignalInfo(0);
                }
                else
                {
                    ShowSignalInfo(--currentSignalInfo);
                }
            }
            UpdateControls();
        }

        /// <summary>
        /// Rekacja na zmianę czasu początkowego i sprawdzenie czy nie jest większy od końcowego.
        /// </summary>
        private void fromTimeChanged(object sender, EventArgs e)
        {
            if (fromTB.Value > toTB.Value)
            {
                toTB.Value = fromTB.Value + 1;
            }
        }

        /// <summary>
        /// Reakcja na zmianę czasu końcowego i sprawdzenie czy nie jest mniejszy od początkowego.
        /// </summary>
        private void toTimeChanged(object sender, EventArgs e)
        {
            if (toTB.Value < fromTB.Value)
            {
               fromTB.Value = toTB.Value - 1;
            }
        }

        private void soundGraphB_Click(object sender, EventArgs e)
        {
            int[] tab = new int[bufferSample.data.Length];
            for(int i = 0; i < tab.Length; ++i)
            {
                tab[i] = bufferSample.data[i];
            }
            new ChartDialog(tab).ShowDialog();
        }
    }
}
