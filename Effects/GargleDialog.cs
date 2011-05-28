using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ASynt.Effects.Effect;
using Un4seen.Bass;

namespace ASynt.Effects
{
    class GargleDialog : AbstractDialog
    {
        private System.Windows.Forms.ComboBox comboBoxWaveShape;
        private System.Windows.Forms.Label labelHowRate;
        private System.Windows.Forms.TrackBar trackBarRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    
        protected override string ProportiesName
        {
            get { return "Właściwości gargle"; }
        }

        protected override string EffectName
        {
            get { return "Gargle"; }
        }

        protected override string Description
        {
            get { return "Powoduje przemnożenie sygnału z podanym kształtem.\nW efekcie dźwięk jest naprzemiennie zciszany i zgłaśniany o daną szybkość modulacji."; }
        }

        public GargleDialog(Gargle gargle)
            : base()
        {
            this.effect = gargle;
            InitializeComponent();

            comboBoxWaveShape.SelectedIndex = 1; //domyślnie kwadrat

            Init();
        }

        protected override void UpdateControls()
        {
            List<BASS_DX8_GARGLE> chorus = ((Gargle)effect).List;
            int rate = (int)chorus[page - 1].dwRateHz;
            int wave = (int)chorus[page - 1].dwWaveShape;

            trackBarRate.Value = rate;
            comboBoxWaveShape.SelectedIndex = wave;
        }

        protected override void EditEffect()
        {
            Dictionary<string, float> d = new Dictionary<string, float>() {
                    {"which", page - 1},
	                {"rateHz", trackBarRate.Value},
	                {"waveShape", comboBoxWaveShape.SelectedIndex},
                };

            effect.Edit(d);
        }

        protected override void AddEffect()
        {
            Dictionary<string, float> d = new Dictionary<string, float>() {
	                {"rateHz", trackBarRate.Value},
	                {"waveShape", comboBoxWaveShape.SelectedIndex},
                };

            effect.Add(d);
        }

        protected override void ResetControls()
        {
            trackBarRate.Value = 1;
            comboBoxWaveShape.SelectedIndex = 1; //domyślnie kwadrat
        }

        private void InitializeComponent()
        {
            this.comboBoxWaveShape = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelHowRate = new System.Windows.Forms.Label();
            this.trackBarRate = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.panelProporties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProporties
            // 
            this.panelProporties.Controls.Add(this.labelHowRate);
            this.panelProporties.Controls.Add(this.trackBarRate);
            this.panelProporties.Controls.Add(this.label8);
            this.panelProporties.Controls.Add(this.comboBoxWaveShape);
            this.panelProporties.Controls.Add(this.label7);
            // 
            // comboBoxWaveShape
            // 
            this.comboBoxWaveShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWaveShape.FormattingEnabled = true;
            this.comboBoxWaveShape.Items.AddRange(new object[] {
            "Trójkąt",
            "Kwadrat"});
            this.comboBoxWaveShape.Location = new System.Drawing.Point(162, 52);
            this.comboBoxWaveShape.Name = "comboBoxWaveShape";
            this.comboBoxWaveShape.Size = new System.Drawing.Size(177, 21);
            this.comboBoxWaveShape.TabIndex = 44;
            this.comboBoxWaveShape.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Forma przebiegu modulującego:";
            // 
            // labelHowRate
            // 
            this.labelHowRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHowRate.AutoSize = true;
            this.labelHowRate.Location = new System.Drawing.Point(326, 15);
            this.labelHowRate.Name = "labelHowRate";
            this.labelHowRate.Size = new System.Drawing.Size(13, 13);
            this.labelHowRate.TabIndex = 48;
            this.labelHowRate.Text = "1";
            // 
            // trackBarRate
            // 
            this.trackBarRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarRate.LargeChange = 10;
            this.trackBarRate.Location = new System.Drawing.Point(162, 3);
            this.trackBarRate.Maximum = 1000;
            this.trackBarRate.Minimum = 1;
            this.trackBarRate.Name = "trackBarRate";
            this.trackBarRate.Size = new System.Drawing.Size(158, 45);
            this.trackBarRate.SmallChange = 5;
            this.trackBarRate.TabIndex = 47;
            this.trackBarRate.TickFrequency = 100;
            this.trackBarRate.Value = 1;
            this.trackBarRate.ValueChanged += new System.EventHandler(this.trackBarRate_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Szybkość modulacji [Hz]:";
            // 
            // GargleDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(384, 204);
            this.Name = "GargleDialog";
            this.panelProporties.ResumeLayout(false);
            this.panelProporties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRate)).EndInit();
            this.ResumeLayout(false);

        }

        private void trackBarRate_ValueChanged(object sender, EventArgs e)
        {
            trackBarValueChanged(sender, e);
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (page != 0) //zapobiega błędowi przy włączeniu okienka
                EditEffect();
        }
    }
}
