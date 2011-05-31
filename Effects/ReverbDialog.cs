using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ASynt.Effects.Effect;
using Un4seen.Bass;

namespace ASynt.Effects
{
    class ReverbDialog : AbstractDialog
    {
        private System.Windows.Forms.Label labelHowReverbTime;
        private System.Windows.Forms.TrackBar trackBarReverbTime;
        private System.Windows.Forms.Label labelReverbTime;
        private System.Windows.Forms.Label labelHowReverbMix;
        private System.Windows.Forms.TrackBar trackBarReverbMix;
        private System.Windows.Forms.Label labelReverbMix;
        private System.Windows.Forms.Label labelHowInGain;
        private System.Windows.Forms.TrackBar trackBarInGain;
        private System.Windows.Forms.Label labelInGain;
        private System.Windows.Forms.Label labelHowHighFreqRTRatio;
        private System.Windows.Forms.TrackBar trackBarHighFreqRTRatio;
        private System.Windows.Forms.Label labelfHighFreqRTRatio;
    
        protected override string ProportiesName
        {
            get { return "Właściwości pogłosu"; }
        }

        protected override string EffectName
        {
            get { return "Pogłos"; }
        }

        protected override string Description
        {
            get
            {
                return "Pogłos (rewerberacja) – zjawisko stopniowego zanikania energii dźwięku po ucichnięciu źródła, " +
                    " związane z występowaniem dużej liczby fal odbitych od powierzchni pomieszczenia. " +
                    "Ucho ludzkie odczuwa pogłos jako przedłużenie dźwięku.";
            }
        }

        public ReverbDialog(Effect.Effect effect)
            : base()
        {
            this.effect = effect;
            InitializeComponent();
            Init();
        }

        protected override void UpdateControls()
        {
            List<BASS_DX8_REVERB> echo = ((Reverb)effect).List;
            int freq = (int)echo[page - 1].fHighFreqRTRatio * 1000;
            int gain = (int)echo[page - 1].fInGain;
            int mix = (int)echo[page - 1].fReverbMix;
            int time = (int)echo[page - 1].fReverbTime;

            if (freq == 0)
                freq = 1;

            trackBarHighFreqRTRatio.Value = freq;
            trackBarInGain.Value = gain;
            trackBarReverbMix.Value = mix;
            trackBarReverbTime.Value = time;
        }

        protected override void EditEffect()
        {
            Dictionary<string, float> d = new Dictionary<string, float>() {
                    {"which", page - 1},
	                {"ratio", (float)(trackBarHighFreqRTRatio.Value * 1.0 / 1000)},
	                {"gain", trackBarInGain.Value},
                    {"mix", trackBarReverbMix.Value},
                    {"time", trackBarReverbTime.Value}
                };

            effect.Edit(d);
        }

        protected override void AddEffect()
        {
            Dictionary<string, float> d = new Dictionary<string, float>() {
	                {"ratio", trackBarHighFreqRTRatio.Value/1000},
	                {"gain", trackBarInGain.Value},
                    {"mix", trackBarReverbMix.Value},
                    {"time", trackBarReverbTime.Value}
                };

            effect.Add(d);
        }

        protected override void ResetControls()
        {
            trackBarHighFreqRTRatio.Value = 1;
            trackBarInGain.Value = 0;
            trackBarReverbMix.Value = 0;
            trackBarReverbTime.Value = 1;
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            trackBarValueChanged(sender, e);
        }

        private void trackBarHighFreqRTRatio_ValueChanged(object sender, EventArgs e)
        {
            labelHowHighFreqRTRatio.Text = ((float)(trackBarHighFreqRTRatio.Value * 1.0 / 1000)).ToString();

            if (page - 1 < effect.EffectsCount) //zeby nie wywalał błędu przy wchodzeniu tutaj po naciśnięciu przycisku następny
            {
                EditEffect();
            }
        }

        private void InitializeComponent()
        {
            this.labelHowReverbTime = new System.Windows.Forms.Label();
            this.trackBarReverbTime = new System.Windows.Forms.TrackBar();
            this.labelReverbTime = new System.Windows.Forms.Label();
            this.labelHowReverbMix = new System.Windows.Forms.Label();
            this.trackBarReverbMix = new System.Windows.Forms.TrackBar();
            this.labelReverbMix = new System.Windows.Forms.Label();
            this.labelHowInGain = new System.Windows.Forms.Label();
            this.trackBarInGain = new System.Windows.Forms.TrackBar();
            this.labelInGain = new System.Windows.Forms.Label();
            this.labelHowHighFreqRTRatio = new System.Windows.Forms.Label();
            this.trackBarHighFreqRTRatio = new System.Windows.Forms.TrackBar();
            this.labelfHighFreqRTRatio = new System.Windows.Forms.Label();
            this.panelProporties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarReverbTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarReverbMix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHighFreqRTRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProporties
            // 
            this.panelProporties.Controls.Add(this.labelHowReverbTime);
            this.panelProporties.Controls.Add(this.trackBarReverbTime);
            this.panelProporties.Controls.Add(this.labelReverbTime);
            this.panelProporties.Controls.Add(this.labelHowReverbMix);
            this.panelProporties.Controls.Add(this.trackBarReverbMix);
            this.panelProporties.Controls.Add(this.labelReverbMix);
            this.panelProporties.Controls.Add(this.labelHowInGain);
            this.panelProporties.Controls.Add(this.trackBarInGain);
            this.panelProporties.Controls.Add(this.labelInGain);
            this.panelProporties.Controls.Add(this.labelHowHighFreqRTRatio);
            this.panelProporties.Controls.Add(this.trackBarHighFreqRTRatio);
            this.panelProporties.Controls.Add(this.labelfHighFreqRTRatio);
            // 
            // labelHowReverbTime
            // 
            this.labelHowReverbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHowReverbTime.AutoSize = true;
            this.labelHowReverbTime.Location = new System.Drawing.Point(332, 135);
            this.labelHowReverbTime.Name = "labelHowReverbTime";
            this.labelHowReverbTime.Size = new System.Drawing.Size(13, 13);
            this.labelHowReverbTime.TabIndex = 36;
            this.labelHowReverbTime.Text = "1";
            // 
            // trackBarReverbTime
            // 
            this.trackBarReverbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarReverbTime.LargeChange = 10;
            this.trackBarReverbTime.Location = new System.Drawing.Point(168, 126);
            this.trackBarReverbTime.Maximum = 3000;
            this.trackBarReverbTime.Minimum = 1;
            this.trackBarReverbTime.Name = "trackBarReverbTime";
            this.trackBarReverbTime.Size = new System.Drawing.Size(158, 45);
            this.trackBarReverbTime.SmallChange = 5;
            this.trackBarReverbTime.TabIndex = 35;
            this.trackBarReverbTime.TickFrequency = 100;
            this.trackBarReverbTime.Value = 1;
            this.trackBarReverbTime.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // labelReverbTime
            // 
            this.labelReverbTime.AutoSize = true;
            this.labelReverbTime.Location = new System.Drawing.Point(69, 135);
            this.labelReverbTime.Name = "labelReverbTime";
            this.labelReverbTime.Size = new System.Drawing.Size(93, 13);
            this.labelReverbTime.TabIndex = 34;
            this.labelReverbTime.Text = "fReverbTime [ms]:";
            // 
            // labelHowReverbMix
            // 
            this.labelHowReverbMix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHowReverbMix.AutoSize = true;
            this.labelHowReverbMix.Location = new System.Drawing.Point(332, 97);
            this.labelHowReverbMix.Name = "labelHowReverbMix";
            this.labelHowReverbMix.Size = new System.Drawing.Size(13, 13);
            this.labelHowReverbMix.TabIndex = 33;
            this.labelHowReverbMix.Text = "0";
            // 
            // trackBarReverbMix
            // 
            this.trackBarReverbMix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarReverbMix.LargeChange = 10;
            this.trackBarReverbMix.Location = new System.Drawing.Point(168, 88);
            this.trackBarReverbMix.Maximum = 0;
            this.trackBarReverbMix.Minimum = -96;
            this.trackBarReverbMix.Name = "trackBarReverbMix";
            this.trackBarReverbMix.Size = new System.Drawing.Size(158, 45);
            this.trackBarReverbMix.SmallChange = 5;
            this.trackBarReverbMix.TabIndex = 32;
            this.trackBarReverbMix.TickFrequency = 10;
            this.trackBarReverbMix.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // labelReverbMix
            // 
            this.labelReverbMix.AutoSize = true;
            this.labelReverbMix.Location = new System.Drawing.Point(76, 97);
            this.labelReverbMix.Name = "labelReverbMix";
            this.labelReverbMix.Size = new System.Drawing.Size(86, 13);
            this.labelReverbMix.TabIndex = 31;
            this.labelReverbMix.Text = "fReverbMix [dB]:";
            // 
            // labelHowInGain
            // 
            this.labelHowInGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHowInGain.AutoSize = true;
            this.labelHowInGain.Location = new System.Drawing.Point(332, 56);
            this.labelHowInGain.Name = "labelHowInGain";
            this.labelHowInGain.Size = new System.Drawing.Size(13, 13);
            this.labelHowInGain.TabIndex = 30;
            this.labelHowInGain.Text = "0";
            // 
            // trackBarInGain
            // 
            this.trackBarInGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarInGain.LargeChange = 10;
            this.trackBarInGain.Location = new System.Drawing.Point(168, 47);
            this.trackBarInGain.Maximum = 0;
            this.trackBarInGain.Minimum = -96;
            this.trackBarInGain.Name = "trackBarInGain";
            this.trackBarInGain.Size = new System.Drawing.Size(158, 45);
            this.trackBarInGain.SmallChange = 5;
            this.trackBarInGain.TabIndex = 29;
            this.trackBarInGain.TickFrequency = 10;
            this.trackBarInGain.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // labelInGain
            // 
            this.labelInGain.AutoSize = true;
            this.labelInGain.Location = new System.Drawing.Point(96, 56);
            this.labelInGain.Name = "labelInGain";
            this.labelInGain.Size = new System.Drawing.Size(66, 13);
            this.labelInGain.TabIndex = 28;
            this.labelInGain.Text = "fInGain [dB]:";
            // 
            // labelHowHighFreqRTRatio
            // 
            this.labelHowHighFreqRTRatio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHowHighFreqRTRatio.AutoSize = true;
            this.labelHowHighFreqRTRatio.Location = new System.Drawing.Point(317, 17);
            this.labelHowHighFreqRTRatio.Name = "labelHowHighFreqRTRatio";
            this.labelHowHighFreqRTRatio.Size = new System.Drawing.Size(34, 13);
            this.labelHowHighFreqRTRatio.TabIndex = 27;
            this.labelHowHighFreqRTRatio.Text = "0.001";
            // 
            // trackBarHighFreqRTRatio
            // 
            this.trackBarHighFreqRTRatio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarHighFreqRTRatio.LargeChange = 10;
            this.trackBarHighFreqRTRatio.Location = new System.Drawing.Point(168, 8);
            this.trackBarHighFreqRTRatio.Maximum = 999;
            this.trackBarHighFreqRTRatio.Minimum = 1;
            this.trackBarHighFreqRTRatio.Name = "trackBarHighFreqRTRatio";
            this.trackBarHighFreqRTRatio.Size = new System.Drawing.Size(158, 45);
            this.trackBarHighFreqRTRatio.SmallChange = 5;
            this.trackBarHighFreqRTRatio.TabIndex = 26;
            this.trackBarHighFreqRTRatio.TickFrequency = 100;
            this.trackBarHighFreqRTRatio.Value = 1;
            this.trackBarHighFreqRTRatio.ValueChanged += new System.EventHandler(this.trackBarHighFreqRTRatio_ValueChanged);
            // 
            // labelfHighFreqRTRatio
            // 
            this.labelfHighFreqRTRatio.AutoSize = true;
            this.labelfHighFreqRTRatio.Location = new System.Drawing.Point(66, 17);
            this.labelfHighFreqRTRatio.Name = "labelfHighFreqRTRatio";
            this.labelfHighFreqRTRatio.Size = new System.Drawing.Size(96, 13);
            this.labelfHighFreqRTRatio.TabIndex = 25;
            this.labelfHighFreqRTRatio.Text = "fHighFreqRTRatio:";
            // 
            // ReverbDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(384, 283);
            this.Name = "ReverbDialog";
            this.panelProporties.ResumeLayout(false);
            this.panelProporties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarReverbTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarReverbMix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHighFreqRTRatio)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
