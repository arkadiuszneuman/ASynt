using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ASynt.Effects.Effect;
using Un4seen.Bass;
using System.Windows.Forms;

namespace ASynt.Effects
{
    class EchoDialog : AbstractDialog
    {
        private System.Windows.Forms.CheckBox checkBoxPan;
        private System.Windows.Forms.Label labelHowDelayR;
        private System.Windows.Forms.TrackBar trackBarDelayR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHowDelayL;
        private System.Windows.Forms.TrackBar trackBarDelayL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelHowFeed;
        private System.Windows.Forms.TrackBar trackBarFeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelHowWetDryFx;
        private System.Windows.Forms.TrackBar trackBarWetDryFx;
        private System.Windows.Forms.Label label8;
        /// <summary>
        /// Konstruktor potrzebny tylko do Designera w VS
        /// </summary>
        private EchoDialog() 
            : base()
        {
        }

        public EchoDialog(Effect.Effect effect)
            : base()
        {
            this.effect = effect;
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Nazwa właściwości.
        /// </summary>
        protected override string ProportiesName
        {
            get { return "Właściwości echa"; }
        }

        /// <summary>
        /// Nazwa efektu.
        /// </summary>
        protected override string EffectName
        {
            get { return "Echo"; }
        }

        /// <summary>
        /// Opis efektu.
        /// </summary>
        protected override string Description
        {
            get
            {
                return "Echo – fala akustyczna odbita od przeszkody i powracająca do obserwatora po zaniku wrażenia słuchowego. " +
                    "Wrażenie echa pojawia się, gdy opóźnienie pomiędzy falą bezpośrednią a falą odbitą jest dłuższe niż 100 ms.";
            }
        }

        private void InitializeComponent()
        {
            this.checkBoxPan = new System.Windows.Forms.CheckBox();
            this.labelHowDelayR = new System.Windows.Forms.Label();
            this.trackBarDelayR = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHowDelayL = new System.Windows.Forms.Label();
            this.trackBarDelayL = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.labelHowFeed = new System.Windows.Forms.Label();
            this.trackBarFeed = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.labelHowWetDryFx = new System.Windows.Forms.Label();
            this.trackBarWetDryFx = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.panelProporties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDelayR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDelayL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWetDryFx)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProporties
            // 
            this.panelProporties.Controls.Add(this.checkBoxPan);
            this.panelProporties.Controls.Add(this.labelHowDelayR);
            this.panelProporties.Controls.Add(this.trackBarDelayR);
            this.panelProporties.Controls.Add(this.label2);
            this.panelProporties.Controls.Add(this.labelHowDelayL);
            this.panelProporties.Controls.Add(this.trackBarDelayL);
            this.panelProporties.Controls.Add(this.label4);
            this.panelProporties.Controls.Add(this.labelHowFeed);
            this.panelProporties.Controls.Add(this.trackBarFeed);
            this.panelProporties.Controls.Add(this.label6);
            this.panelProporties.Controls.Add(this.labelHowWetDryFx);
            this.panelProporties.Controls.Add(this.trackBarWetDryFx);
            this.panelProporties.Controls.Add(this.label8);
            // 
            // checkBoxPan
            // 
            this.checkBoxPan.AutoSize = true;
            this.checkBoxPan.Location = new System.Drawing.Point(141, 172);
            this.checkBoxPan.Name = "checkBoxPan";
            this.checkBoxPan.Size = new System.Drawing.Size(72, 17);
            this.checkBoxPan.TabIndex = 25;
            this.checkBoxPan.Text = "PanDelay";
            this.checkBoxPan.UseVisualStyleBackColor = true;
            this.checkBoxPan.CheckedChanged += new System.EventHandler(this.checkBoxPan_CheckedChanged);
            // 
            // labelHowDelayR
            // 
            this.labelHowDelayR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHowDelayR.AutoSize = true;
            this.labelHowDelayR.Location = new System.Drawing.Point(321, 130);
            this.labelHowDelayR.Name = "labelHowDelayR";
            this.labelHowDelayR.Size = new System.Drawing.Size(13, 13);
            this.labelHowDelayR.TabIndex = 24;
            this.labelHowDelayR.Text = "1";
            // 
            // trackBarDelayR
            // 
            this.trackBarDelayR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarDelayR.LargeChange = 10;
            this.trackBarDelayR.Location = new System.Drawing.Point(157, 121);
            this.trackBarDelayR.Maximum = 2000;
            this.trackBarDelayR.Minimum = 1;
            this.trackBarDelayR.Name = "trackBarDelayR";
            this.trackBarDelayR.Size = new System.Drawing.Size(158, 45);
            this.trackBarDelayR.SmallChange = 5;
            this.trackBarDelayR.TabIndex = 23;
            this.trackBarDelayR.TickFrequency = 100;
            this.trackBarDelayR.Value = 1;
            this.trackBarDelayR.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Opóźnienie prawego kanału:";
            // 
            // labelHowDelayL
            // 
            this.labelHowDelayL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHowDelayL.AutoSize = true;
            this.labelHowDelayL.Location = new System.Drawing.Point(321, 92);
            this.labelHowDelayL.Name = "labelHowDelayL";
            this.labelHowDelayL.Size = new System.Drawing.Size(13, 13);
            this.labelHowDelayL.TabIndex = 21;
            this.labelHowDelayL.Text = "1";
            // 
            // trackBarDelayL
            // 
            this.trackBarDelayL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarDelayL.LargeChange = 10;
            this.trackBarDelayL.Location = new System.Drawing.Point(157, 83);
            this.trackBarDelayL.Maximum = 2000;
            this.trackBarDelayL.Minimum = 1;
            this.trackBarDelayL.Name = "trackBarDelayL";
            this.trackBarDelayL.Size = new System.Drawing.Size(158, 45);
            this.trackBarDelayL.SmallChange = 5;
            this.trackBarDelayL.TabIndex = 20;
            this.trackBarDelayL.TickFrequency = 100;
            this.trackBarDelayL.Value = 1;
            this.trackBarDelayL.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Opóźnienie lewego kanału:";
            // 
            // labelHowFeed
            // 
            this.labelHowFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHowFeed.AutoSize = true;
            this.labelHowFeed.Location = new System.Drawing.Point(321, 51);
            this.labelHowFeed.Name = "labelHowFeed";
            this.labelHowFeed.Size = new System.Drawing.Size(13, 13);
            this.labelHowFeed.TabIndex = 18;
            this.labelHowFeed.Text = "0";
            // 
            // trackBarFeed
            // 
            this.trackBarFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarFeed.LargeChange = 10;
            this.trackBarFeed.Location = new System.Drawing.Point(157, 42);
            this.trackBarFeed.Maximum = 100;
            this.trackBarFeed.Name = "trackBarFeed";
            this.trackBarFeed.Size = new System.Drawing.Size(158, 45);
            this.trackBarFeed.SmallChange = 5;
            this.trackBarFeed.TabIndex = 17;
            this.trackBarFeed.TickFrequency = 5;
            this.trackBarFeed.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sprzężenie zwrotne [%]:";
            // 
            // labelHowWetDryFx
            // 
            this.labelHowWetDryFx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHowWetDryFx.AutoSize = true;
            this.labelHowWetDryFx.Location = new System.Drawing.Point(321, 12);
            this.labelHowWetDryFx.Name = "labelHowWetDryFx";
            this.labelHowWetDryFx.Size = new System.Drawing.Size(13, 13);
            this.labelHowWetDryFx.TabIndex = 15;
            this.labelHowWetDryFx.Text = "0";
            // 
            // trackBarWetDryFx
            // 
            this.trackBarWetDryFx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarWetDryFx.LargeChange = 10;
            this.trackBarWetDryFx.Location = new System.Drawing.Point(157, 3);
            this.trackBarWetDryFx.Maximum = 100;
            this.trackBarWetDryFx.Name = "trackBarWetDryFx";
            this.trackBarWetDryFx.Size = new System.Drawing.Size(158, 45);
            this.trackBarWetDryFx.SmallChange = 5;
            this.trackBarWetDryFx.TabIndex = 14;
            this.trackBarWetDryFx.TickFrequency = 5;
            this.trackBarWetDryFx.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "wetDryFx:";
            // 
            // EchoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(384, 316);
            this.Name = "EchoDialog";
            this.panelProporties.ResumeLayout(false);
            this.panelProporties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDelayR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDelayL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWetDryFx)).EndInit();
            this.ResumeLayout(false);

        }

        /// <summary>
        /// Edycja efektu.
        /// </summary>
        protected override void EditEffect()
        {
            Dictionary<string, float> d = new Dictionary<string, float>() {
                    {"which", page - 1},
	                {"wetDryMix", trackBarWetDryFx.Value},
	                {"feedback", trackBarFeed.Value},
	                {"leftDelay", trackBarDelayL.Value},
                    {"rightDelay", trackBarDelayR.Value}, 
                    {"panDelay", (float)Convert.ToDouble(checkBoxPan.Checked)} 
                };

            effect.Edit(d);
        }

        /// <summary>
        /// Dodanie efektu.
        /// </summary>
        protected override void  AddEffect()
        {
            Dictionary<string, float> d = new Dictionary<string, float>() {
	                {"wetDryMix", trackBarWetDryFx.Value},
	                {"feedback", trackBarFeed.Value},
	                {"leftDelay", trackBarDelayL.Value},
                    {"rightDelay", trackBarDelayR.Value}, 
                    {"panDelay", (float)Convert.ToDouble(checkBoxPan.Checked)} 
                };

            effect.Add(d);
        }
        
        /// <summary>
        /// Aktualizacja kontrolek.
        /// </summary>
        protected override void UpdateControls()
        {
            List<BASS_DX8_ECHO> echo = ((Echo)effect).List;
            int wet = (int)echo[page - 1].fWetDryMix;
            int feed = (int)echo[page - 1].fFeedback;
            int left = (int)echo[page - 1].fLeftDelay;
            int right = (int)echo[page - 1].fRightDelay;
            bool check = echo[page - 1].lPanDelay;
            trackBarWetDryFx.Value = wet;
            trackBarFeed.Value = feed;
            trackBarDelayL.Value = left;
            trackBarDelayR.Value = right;
            checkBoxPan.Checked = check;
        }

        /// <summary>
        /// Zresetowanie wartości kontrolek.
        /// </summary>
        protected override void ResetControls()
        {
            trackBarWetDryFx.Value = 0;
            trackBarFeed.Value = 0;
            trackBarDelayL.Value = 1;
            trackBarDelayR.Value = 1;
            checkBoxPan.Checked = false;
        }

        /// <summary>
        /// Reakcja na zmianę wartości suwaka trackBar.
        /// </summary>
        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            trackBarValueChanged(sender, e);
        }

        /// <summary>
        /// Reakcja na zmianę zaznaczenia checkBoxPan.
        /// </summary>
        private void checkBoxPan_CheckedChanged(object sender, EventArgs e)
        {
            EditEffect();
        }

        
    }
}
