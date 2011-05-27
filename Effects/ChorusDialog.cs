using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ASynt.Effects.Effect;
using Un4seen.Bass;

namespace ASynt.Effects
{
    class ChorusDialog : AbstractDialog
    {
        private System.Windows.Forms.Label labelHowDep;
        private System.Windows.Forms.TrackBar trackBarDep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHowDelay;
        private System.Windows.Forms.TrackBar trackBarDelay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelHowFeed;
        private System.Windows.Forms.TrackBar trackBarFeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelHowWetDryFx;
        private System.Windows.Forms.TrackBar trackBarWetDryFx;
        private System.Windows.Forms.ComboBox comboBoxWaveform;
        private System.Windows.Forms.Label labelHowFreq;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBarFreq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPhase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    
        protected override string ProportiesName
        {
            get { return "Właściwości chóru"; }
        }

        protected override string EffectName
        {
            get { return "chór"; }
        }

        public ChorusDialog(Chorus chorus)
            : base()
        {
            this.effect = chorus;
            InitializeComponent();

            comboBoxPhase.SelectedIndex = 2; //domyślnie mamy zerową fazę
            comboBoxWaveform.SelectedIndex = 0; //domyślnie trójkąt

            Init();

            Text = "Chór";
        }

        protected override void UpdateControls()
        {
            List<BASS_DX8_CHORUS> chorus = ((Chorus)effect).List;
            int wet = (int)chorus[page - 1].fWetDryMix;
            int feed = (int)chorus[page - 1].fFeedback;
            int delay = (int)chorus[page - 1].fDelay;
            int depth = (int)chorus[page - 1].fDepth;
            int freq = (int)chorus[page - 1].fFrequency;
            int phase = (int)chorus[page - 1].lPhase;
            int wave = (int)chorus[page - 1].lWaveform;

            int ph = 0;
            switch ((BASSFXPhase)phase)
            {
                case BASSFXPhase.BASS_FX_PHASE_NEG_180:
                    ph = 0;
                    break;
                case BASSFXPhase.BASS_FX_PHASE_NEG_90:
                    ph = 1;
                    break;
                case BASSFXPhase.BASS_FX_PHASE_ZERO:
                    ph = 2;
                    break;
                case BASSFXPhase.BASS_FX_PHASE_90:
                    ph = 3;
                    break;
                case BASSFXPhase.BASS_FX_PHASE_180:
                    ph = 4;
                    break;
                default:
                    throw new Exception("Błąd");
            }

            trackBarWetDryFx.Value = wet;
            trackBarFeed.Value = feed;
            trackBarDelay.Value = delay;
            trackBarDep.Value = depth;
            trackBarFreq.Value = freq;
            comboBoxPhase.SelectedIndex = ph;
            comboBoxWaveform.SelectedIndex = wave;
        }

        protected override void EditEffect()
        {
            BASSFXPhase ph = BASSFXPhase.BASS_FX_PHASE_ZERO;

            switch (comboBoxPhase.SelectedIndex)
            {
                case 0:
                    ph = BASSFXPhase.BASS_FX_PHASE_NEG_180;
                    break;
                case 1:
                    ph = BASSFXPhase.BASS_FX_PHASE_NEG_90;
                    break;
                case 2:
                    ph = BASSFXPhase.BASS_FX_PHASE_ZERO;
                    break;
                case 3:
                    ph = BASSFXPhase.BASS_FX_PHASE_90;
                    break;
                case 4:
                    ph = BASSFXPhase.BASS_FX_PHASE_180;
                    break;
                default:
                    throw new Exception("Błąd");
            }

            Dictionary<string, float> d = new Dictionary<string, float>() {
                    {"which", page - 1},
	                {"wetDryMix", trackBarWetDryFx.Value},
	                {"feedback", trackBarFeed.Value},
	                {"delay", trackBarDelay.Value},
                    {"depth", trackBarDep.Value}, 
                    {"frequency", trackBarFreq.Value},
                    {"phase", (float)ph},
                    {"waveform", comboBoxWaveform.SelectedIndex} 
                };

            effect.Edit(d);
        }

        protected override void AddEffect()
        {
            BASSFXPhase ph = BASSFXPhase.BASS_FX_PHASE_ZERO;
           
            switch (comboBoxPhase.SelectedIndex)
            {
                case 0:
                    ph = BASSFXPhase.BASS_FX_PHASE_NEG_180;
                    break;
                case 1:
                    ph = BASSFXPhase.BASS_FX_PHASE_NEG_90;
                    break;
                case 2:
                    ph = BASSFXPhase.BASS_FX_PHASE_ZERO;
                    break;
                case 3:
                    ph = BASSFXPhase.BASS_FX_PHASE_90;
                    break;
                case 4:
                    ph = BASSFXPhase.BASS_FX_PHASE_180;
                    break;
            }

            Dictionary<string, float> d = new Dictionary<string, float>() {
	                {"wetDryMix", trackBarWetDryFx.Value},
	                {"feedback", trackBarFeed.Value},
	                {"delay", trackBarDelay.Value},
                    {"depth", trackBarDep.Value}, 
                    {"frequency", trackBarFreq.Value},
                    {"phase", (float)ph},
                    {"waveform", comboBoxWaveform.SelectedIndex} 
                };

            effect.Add(d);
        }

        protected override void ResetControls()
        {
            trackBarWetDryFx.Value = 0;
            trackBarFeed.Value = 0;
            trackBarDelay.Value = 0;
            trackBarDep.Value = 0;
            trackBarFreq.Value = 0;
            comboBoxPhase.SelectedIndex = 2; //domyślnie mamy zerową fazę
            comboBoxWaveform.SelectedIndex = 0; //domyślnie trójkąt
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            trackBarValueChanged(sender, e);
        }

        private void InitializeComponent()
        {
            this.labelHowDep = new System.Windows.Forms.Label();
            this.trackBarDep = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHowDelay = new System.Windows.Forms.Label();
            this.trackBarDelay = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.labelHowFeed = new System.Windows.Forms.Label();
            this.trackBarFeed = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.labelHowWetDryFx = new System.Windows.Forms.Label();
            this.trackBarWetDryFx = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.labelHowFreq = new System.Windows.Forms.Label();
            this.trackBarFreq = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPhase = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxWaveform = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelProporties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWetDryFx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProporties
            // 
            this.panelProporties.Controls.Add(this.comboBoxWaveform);
            this.panelProporties.Controls.Add(this.labelHowFreq);
            this.panelProporties.Controls.Add(this.label7);
            this.panelProporties.Controls.Add(this.trackBarFreq);
            this.panelProporties.Controls.Add(this.label3);
            this.panelProporties.Controls.Add(this.labelHowDep);
            this.panelProporties.Controls.Add(this.trackBarDep);
            this.panelProporties.Controls.Add(this.label2);
            this.panelProporties.Controls.Add(this.comboBoxPhase);
            this.panelProporties.Controls.Add(this.labelHowDelay);
            this.panelProporties.Controls.Add(this.label5);
            this.panelProporties.Controls.Add(this.trackBarDelay);
            this.panelProporties.Controls.Add(this.label4);
            this.panelProporties.Controls.Add(this.labelHowFeed);
            this.panelProporties.Controls.Add(this.trackBarFeed);
            this.panelProporties.Controls.Add(this.label6);
            this.panelProporties.Controls.Add(this.labelHowWetDryFx);
            this.panelProporties.Controls.Add(this.trackBarWetDryFx);
            this.panelProporties.Controls.Add(this.label8);
            this.panelProporties.Size = new System.Drawing.Size(355, 364);
            // 
            // labelHowDep
            // 
            this.labelHowDep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHowDep.AutoSize = true;
            this.labelHowDep.Location = new System.Drawing.Point(328, 134);
            this.labelHowDep.Name = "labelHowDep";
            this.labelHowDep.Size = new System.Drawing.Size(13, 13);
            this.labelHowDep.TabIndex = 37;
            this.labelHowDep.Text = "0";
            // 
            // trackBarDep
            // 
            this.trackBarDep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarDep.LargeChange = 10;
            this.trackBarDep.Location = new System.Drawing.Point(164, 125);
            this.trackBarDep.Maximum = 100;
            this.trackBarDep.Name = "trackBarDep";
            this.trackBarDep.Size = new System.Drawing.Size(158, 45);
            this.trackBarDep.SmallChange = 5;
            this.trackBarDep.TabIndex = 36;
            this.trackBarDep.TickFrequency = 5;
            this.trackBarDep.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Głębia [%]:";
            // 
            // labelHowDelay
            // 
            this.labelHowDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHowDelay.AutoSize = true;
            this.labelHowDelay.Location = new System.Drawing.Point(328, 96);
            this.labelHowDelay.Name = "labelHowDelay";
            this.labelHowDelay.Size = new System.Drawing.Size(13, 13);
            this.labelHowDelay.TabIndex = 34;
            this.labelHowDelay.Text = "0";
            // 
            // trackBarDelay
            // 
            this.trackBarDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarDelay.LargeChange = 10;
            this.trackBarDelay.Location = new System.Drawing.Point(164, 87);
            this.trackBarDelay.Maximum = 20;
            this.trackBarDelay.Name = "trackBarDelay";
            this.trackBarDelay.Size = new System.Drawing.Size(158, 45);
            this.trackBarDelay.SmallChange = 5;
            this.trackBarDelay.TabIndex = 33;
            this.trackBarDelay.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Opóźnienie [ms]:";
            // 
            // labelHowFeed
            // 
            this.labelHowFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHowFeed.AutoSize = true;
            this.labelHowFeed.Location = new System.Drawing.Point(328, 55);
            this.labelHowFeed.Name = "labelHowFeed";
            this.labelHowFeed.Size = new System.Drawing.Size(13, 13);
            this.labelHowFeed.TabIndex = 31;
            this.labelHowFeed.Text = "0";
            // 
            // trackBarFeed
            // 
            this.trackBarFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarFeed.LargeChange = 10;
            this.trackBarFeed.Location = new System.Drawing.Point(164, 46);
            this.trackBarFeed.Maximum = 99;
            this.trackBarFeed.Minimum = -99;
            this.trackBarFeed.Name = "trackBarFeed";
            this.trackBarFeed.Size = new System.Drawing.Size(158, 45);
            this.trackBarFeed.SmallChange = 5;
            this.trackBarFeed.TabIndex = 30;
            this.trackBarFeed.TickFrequency = 10;
            this.trackBarFeed.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Feedback:";
            // 
            // labelHowWetDryFx
            // 
            this.labelHowWetDryFx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHowWetDryFx.AutoSize = true;
            this.labelHowWetDryFx.Location = new System.Drawing.Point(328, 16);
            this.labelHowWetDryFx.Name = "labelHowWetDryFx";
            this.labelHowWetDryFx.Size = new System.Drawing.Size(13, 13);
            this.labelHowWetDryFx.TabIndex = 28;
            this.labelHowWetDryFx.Text = "0";
            // 
            // trackBarWetDryFx
            // 
            this.trackBarWetDryFx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarWetDryFx.LargeChange = 10;
            this.trackBarWetDryFx.Location = new System.Drawing.Point(164, 7);
            this.trackBarWetDryFx.Maximum = 100;
            this.trackBarWetDryFx.Name = "trackBarWetDryFx";
            this.trackBarWetDryFx.Size = new System.Drawing.Size(158, 45);
            this.trackBarWetDryFx.SmallChange = 5;
            this.trackBarWetDryFx.TabIndex = 27;
            this.trackBarWetDryFx.TickFrequency = 5;
            this.trackBarWetDryFx.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "wetDryFx:";
            // 
            // labelHowFreq
            // 
            this.labelHowFreq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHowFreq.AutoSize = true;
            this.labelHowFreq.Location = new System.Drawing.Point(328, 173);
            this.labelHowFreq.Name = "labelHowFreq";
            this.labelHowFreq.Size = new System.Drawing.Size(13, 13);
            this.labelHowFreq.TabIndex = 40;
            this.labelHowFreq.Text = "0";
            // 
            // trackBarFreq
            // 
            this.trackBarFreq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarFreq.LargeChange = 10;
            this.trackBarFreq.Location = new System.Drawing.Point(164, 164);
            this.trackBarFreq.Name = "trackBarFreq";
            this.trackBarFreq.Size = new System.Drawing.Size(158, 45);
            this.trackBarFreq.SmallChange = 5;
            this.trackBarFreq.TabIndex = 39;
            this.trackBarFreq.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Częstotliwość LFO:";
            // 
            // comboBoxPhase
            // 
            this.comboBoxPhase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPhase.FormattingEnabled = true;
            this.comboBoxPhase.Items.AddRange(new object[] {
            "-180",
            "-90",
            "0",
            "90",
            "180"});
            this.comboBoxPhase.Location = new System.Drawing.Point(164, 210);
            this.comboBoxPhase.Name = "comboBoxPhase";
            this.comboBoxPhase.Size = new System.Drawing.Size(177, 21);
            this.comboBoxPhase.TabIndex = 4;
            this.comboBoxPhase.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Faza:";
            // 
            // comboBoxWaveform
            // 
            this.comboBoxWaveform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWaveform.FormattingEnabled = true;
            this.comboBoxWaveform.Items.AddRange(new object[] {
            "Trójkąt",
            "Sinusoida"});
            this.comboBoxWaveform.Location = new System.Drawing.Point(164, 237);
            this.comboBoxWaveform.Name = "comboBoxWaveform";
            this.comboBoxWaveform.Size = new System.Drawing.Size(177, 21);
            this.comboBoxWaveform.TabIndex = 42;
            this.comboBoxWaveform.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Forma przebiegu:";
            // 
            // ChorusDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(384, 331);
            this.Name = "ChorusDialog";
            this.panelProporties.ResumeLayout(false);
            this.panelProporties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWetDryFx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).EndInit();
            this.ResumeLayout(false);

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (page != 0) //zapobiega błędowi przy włączeniu okienka
                EditEffect();
        }
    }
}
