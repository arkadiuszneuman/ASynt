namespace ASynt
{
    partial class SoundGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.whiteNoiseWave = new System.Windows.Forms.RadioButton();
            this.gainL = new System.Windows.Forms.Label();
            this.infoL = new System.Windows.Forms.Label();
            this.squareWave = new System.Windows.Forms.RadioButton();
            this.absTanWave = new System.Windows.Forms.RadioButton();
            this.applyAmplB = new System.Windows.Forms.Button();
            this.tanWave = new System.Windows.Forms.RadioButton();
            this.absCosWave = new System.Windows.Forms.RadioButton();
            this.amplUD = new System.Windows.Forms.NumericUpDown();
            this.cosWave = new System.Windows.Forms.RadioButton();
            this.signalsGB = new System.Windows.Forms.GroupBox();
            this.absSinWave = new System.Windows.Forms.RadioButton();
            this.sinWave = new System.Windows.Forms.RadioButton();
            this.addB = new System.Windows.Forms.Button();
            this.previewB = new System.Windows.Forms.Button();
            this.createSoundB = new System.Windows.Forms.Button();
            this.fromTB = new System.Windows.Forms.TextBox();
            this.toTB = new System.Windows.Forms.TextBox();
            this.fromL = new System.Windows.Forms.Label();
            this.toL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amplUD)).BeginInit();
            this.signalsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // whiteNoiseWave
            // 
            this.whiteNoiseWave.AutoSize = true;
            this.whiteNoiseWave.Location = new System.Drawing.Point(280, 43);
            this.whiteNoiseWave.Name = "whiteNoiseWave";
            this.whiteNoiseWave.Size = new System.Drawing.Size(81, 17);
            this.whiteNoiseWave.TabIndex = 8;
            this.whiteNoiseWave.TabStop = true;
            this.whiteNoiseWave.Tag = "7";
            this.whiteNoiseWave.Text = "White noise";
            this.whiteNoiseWave.UseVisualStyleBackColor = true;
            this.whiteNoiseWave.CheckedChanged += new System.EventHandler(this.SignalChanged);
            // 
            // gainL
            // 
            this.gainL.Location = new System.Drawing.Point(12, 131);
            this.gainL.Name = "gainL";
            this.gainL.Size = new System.Drawing.Size(258, 23);
            this.gainL.TabIndex = 16;
            this.gainL.Text = "Wzmocnienie (0 - cisza, 100 - maksymalna amplituda)";
            this.gainL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoL
            // 
            this.infoL.Location = new System.Drawing.Point(12, 9);
            this.infoL.Name = "infoL";
            this.infoL.Size = new System.Drawing.Size(569, 40);
            this.infoL.TabIndex = 13;
            // 
            // squareWave
            // 
            this.squareWave.AutoSize = true;
            this.squareWave.Location = new System.Drawing.Point(280, 20);
            this.squareWave.Name = "squareWave";
            this.squareWave.Size = new System.Drawing.Size(64, 17);
            this.squareWave.TabIndex = 7;
            this.squareWave.TabStop = true;
            this.squareWave.Tag = "6";
            this.squareWave.Text = "Kwadrat";
            this.squareWave.UseVisualStyleBackColor = true;
            this.squareWave.CheckedChanged += new System.EventHandler(this.SignalChanged);
            // 
            // absTanWave
            // 
            this.absTanWave.AutoSize = true;
            this.absTanWave.Location = new System.Drawing.Point(189, 43);
            this.absTanWave.Name = "absTanWave";
            this.absTanWave.Size = new System.Drawing.Size(71, 17);
            this.absTanWave.TabIndex = 6;
            this.absTanWave.TabStop = true;
            this.absTanWave.Tag = "5";
            this.absTanWave.Text = "|Tangens|";
            this.absTanWave.UseVisualStyleBackColor = true;
            this.absTanWave.CheckedChanged += new System.EventHandler(this.SignalChanged);
            // 
            // applyAmplB
            // 
            this.applyAmplB.Enabled = false;
            this.applyAmplB.Location = new System.Drawing.Point(345, 134);
            this.applyAmplB.Name = "applyAmplB";
            this.applyAmplB.Size = new System.Drawing.Size(75, 20);
            this.applyAmplB.TabIndex = 17;
            this.applyAmplB.Text = "Zmień";
            this.applyAmplB.UseVisualStyleBackColor = true;
            this.applyAmplB.Click += new System.EventHandler(this.applyGain);
            // 
            // tanWave
            // 
            this.tanWave.AutoSize = true;
            this.tanWave.Location = new System.Drawing.Point(189, 20);
            this.tanWave.Name = "tanWave";
            this.tanWave.Size = new System.Drawing.Size(67, 17);
            this.tanWave.TabIndex = 5;
            this.tanWave.TabStop = true;
            this.tanWave.Tag = "4";
            this.tanWave.Text = "Tangens";
            this.tanWave.UseVisualStyleBackColor = true;
            this.tanWave.CheckedChanged += new System.EventHandler(this.SignalChanged);
            // 
            // absCosWave
            // 
            this.absCosWave.AutoSize = true;
            this.absCosWave.Location = new System.Drawing.Point(98, 43);
            this.absCosWave.Name = "absCosWave";
            this.absCosWave.Size = new System.Drawing.Size(66, 17);
            this.absCosWave.TabIndex = 4;
            this.absCosWave.TabStop = true;
            this.absCosWave.Tag = "3";
            this.absCosWave.Text = "|Cosinus|";
            this.absCosWave.UseVisualStyleBackColor = true;
            this.absCosWave.CheckedChanged += new System.EventHandler(this.SignalChanged);
            // 
            // amplUD
            // 
            this.amplUD.Location = new System.Drawing.Point(276, 134);
            this.amplUD.Name = "amplUD";
            this.amplUD.Size = new System.Drawing.Size(63, 20);
            this.amplUD.TabIndex = 15;
            this.amplUD.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.amplUD.ValueChanged += new System.EventHandler(this.amplValueChanged);
            // 
            // cosWave
            // 
            this.cosWave.AutoSize = true;
            this.cosWave.Location = new System.Drawing.Point(98, 19);
            this.cosWave.Name = "cosWave";
            this.cosWave.Size = new System.Drawing.Size(62, 17);
            this.cosWave.TabIndex = 3;
            this.cosWave.TabStop = true;
            this.cosWave.Tag = "2";
            this.cosWave.Text = "Cosinus";
            this.cosWave.UseVisualStyleBackColor = true;
            this.cosWave.CheckedChanged += new System.EventHandler(this.SignalChanged);
            // 
            // signalsGB
            // 
            this.signalsGB.Controls.Add(this.toL);
            this.signalsGB.Controls.Add(this.fromL);
            this.signalsGB.Controls.Add(this.toTB);
            this.signalsGB.Controls.Add(this.fromTB);
            this.signalsGB.Controls.Add(this.whiteNoiseWave);
            this.signalsGB.Controls.Add(this.squareWave);
            this.signalsGB.Controls.Add(this.absTanWave);
            this.signalsGB.Controls.Add(this.tanWave);
            this.signalsGB.Controls.Add(this.absCosWave);
            this.signalsGB.Controls.Add(this.cosWave);
            this.signalsGB.Controls.Add(this.absSinWave);
            this.signalsGB.Controls.Add(this.sinWave);
            this.signalsGB.Controls.Add(this.addB);
            this.signalsGB.Location = new System.Drawing.Point(15, 52);
            this.signalsGB.Name = "signalsGB";
            this.signalsGB.Size = new System.Drawing.Size(566, 76);
            this.signalsGB.TabIndex = 14;
            this.signalsGB.TabStop = false;
            this.signalsGB.Text = "Sygnały";
            // 
            // absSinWave
            // 
            this.absSinWave.AutoSize = true;
            this.absSinWave.Location = new System.Drawing.Point(7, 43);
            this.absSinWave.Name = "absSinWave";
            this.absSinWave.Size = new System.Drawing.Size(55, 17);
            this.absSinWave.TabIndex = 2;
            this.absSinWave.TabStop = true;
            this.absSinWave.Tag = "1";
            this.absSinWave.Text = "|Sinus|";
            this.absSinWave.UseVisualStyleBackColor = true;
            this.absSinWave.CheckedChanged += new System.EventHandler(this.SignalChanged);
            // 
            // sinWave
            // 
            this.sinWave.AutoSize = true;
            this.sinWave.Location = new System.Drawing.Point(7, 20);
            this.sinWave.Name = "sinWave";
            this.sinWave.Size = new System.Drawing.Size(51, 17);
            this.sinWave.TabIndex = 1;
            this.sinWave.TabStop = true;
            this.sinWave.Tag = "0";
            this.sinWave.Text = "Sinus";
            this.sinWave.UseVisualStyleBackColor = true;
            this.sinWave.CheckedChanged += new System.EventHandler(this.SignalChanged);
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(511, 10);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(49, 60);
            this.addB.TabIndex = 0;
            this.addB.Text = "Dodaj";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addSignal);
            // 
            // previewB
            // 
            this.previewB.Location = new System.Drawing.Point(506, 134);
            this.previewB.Name = "previewB";
            this.previewB.Size = new System.Drawing.Size(75, 20);
            this.previewB.TabIndex = 18;
            this.previewB.Text = "Testuj!";
            this.previewB.UseVisualStyleBackColor = true;
            this.previewB.Click += new System.EventHandler(this.testSound);
            // 
            // createSoundB
            // 
            this.createSoundB.Location = new System.Drawing.Point(509, 376);
            this.createSoundB.Name = "createSoundB";
            this.createSoundB.Size = new System.Drawing.Size(75, 23);
            this.createSoundB.TabIndex = 19;
            this.createSoundB.Text = "Generuj!";
            this.createSoundB.UseVisualStyleBackColor = true;
            this.createSoundB.Click += new System.EventHandler(this.createSound);
            // 
            // fromTB
            // 
            this.fromTB.Location = new System.Drawing.Point(432, 19);
            this.fromTB.Name = "fromTB";
            this.fromTB.Size = new System.Drawing.Size(73, 20);
            this.fromTB.TabIndex = 9;
            this.fromTB.Text = "0";
            // 
            // toTB
            // 
            this.toTB.Location = new System.Drawing.Point(432, 45);
            this.toTB.Name = "toTB";
            this.toTB.Size = new System.Drawing.Size(73, 20);
            this.toTB.TabIndex = 10;
            this.toTB.Text = "2000";
            // 
            // fromL
            // 
            this.fromL.AutoSize = true;
            this.fromL.Location = new System.Drawing.Point(380, 23);
            this.fromL.Name = "fromL";
            this.fromL.Size = new System.Drawing.Size(46, 13);
            this.fromL.TabIndex = 11;
            this.fromL.Text = "Od (ms):";
            // 
            // toL
            // 
            this.toL.AutoSize = true;
            this.toL.Location = new System.Drawing.Point(380, 48);
            this.toL.Name = "toL";
            this.toL.Size = new System.Drawing.Size(46, 13);
            this.toL.TabIndex = 12;
            this.toL.Text = "Do (ms):";
            // 
            // SoundGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 411);
            this.Controls.Add(this.createSoundB);
            this.Controls.Add(this.gainL);
            this.Controls.Add(this.infoL);
            this.Controls.Add(this.applyAmplB);
            this.Controls.Add(this.amplUD);
            this.Controls.Add(this.signalsGB);
            this.Controls.Add(this.previewB);
            this.Name = "SoundGenerator";
            this.Text = "SoundGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.amplUD)).EndInit();
            this.signalsGB.ResumeLayout(false);
            this.signalsGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton whiteNoiseWave;
        private System.Windows.Forms.Label gainL;
        private System.Windows.Forms.Label infoL;
        private System.Windows.Forms.RadioButton squareWave;
        private System.Windows.Forms.RadioButton absTanWave;
        private System.Windows.Forms.Button applyAmplB;
        private System.Windows.Forms.RadioButton tanWave;
        private System.Windows.Forms.RadioButton absCosWave;
        private System.Windows.Forms.NumericUpDown amplUD;
        private System.Windows.Forms.RadioButton cosWave;
        private System.Windows.Forms.GroupBox signalsGB;
        private System.Windows.Forms.RadioButton absSinWave;
        private System.Windows.Forms.RadioButton sinWave;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Button previewB;
        private System.Windows.Forms.Button createSoundB;
        private System.Windows.Forms.Label toL;
        private System.Windows.Forms.Label fromL;
        private System.Windows.Forms.TextBox toTB;
        private System.Windows.Forms.TextBox fromTB;
    }
}