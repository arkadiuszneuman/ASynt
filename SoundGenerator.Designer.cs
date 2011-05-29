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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundGenerator));
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
            this.toTB = new System.Windows.Forms.NumericUpDown();
            this.fromTB = new System.Windows.Forms.NumericUpDown();
            this.toL = new System.Windows.Forms.Label();
            this.fromL = new System.Windows.Forms.Label();
            this.absSinWave = new System.Windows.Forms.RadioButton();
            this.sinWave = new System.Windows.Forms.RadioButton();
            this.addB = new System.Windows.Forms.Button();
            this.previewB = new System.Windows.Forms.Button();
            this.createSoundB = new System.Windows.Forms.Button();
            this.signalPrevGB = new System.Windows.Forms.GroupBox();
            this.signalDeleteB = new System.Windows.Forms.Button();
            this.signalPreviewB = new System.Windows.Forms.Button();
            this.infoAL3 = new System.Windows.Forms.Label();
            this.infoL3 = new System.Windows.Forms.Label();
            this.infoAL2 = new System.Windows.Forms.Label();
            this.infoL2 = new System.Windows.Forms.Label();
            this.infoAL1 = new System.Windows.Forms.Label();
            this.infoL1 = new System.Windows.Forms.Label();
            this.deleteAllSignalsB = new System.Windows.Forms.Button();
            this.nextPageB = new System.Windows.Forms.Button();
            this.prevPageB = new System.Windows.Forms.Button();
            this.lastPageB = new System.Windows.Forms.Button();
            this.firstPageB = new System.Windows.Forms.Button();
            this.soundGraphB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amplUD)).BeginInit();
            this.signalsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromTB)).BeginInit();
            this.signalPrevGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // whiteNoiseWave
            // 
            this.whiteNoiseWave.AutoSize = true;
            this.whiteNoiseWave.Location = new System.Drawing.Point(280, 43);
            this.whiteNoiseWave.Name = "whiteNoiseWave";
            this.whiteNoiseWave.Size = new System.Drawing.Size(76, 17);
            this.whiteNoiseWave.TabIndex = 8;
            this.whiteNoiseWave.TabStop = true;
            this.whiteNoiseWave.Tag = "7";
            this.whiteNoiseWave.Text = "Biały szum";
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
            this.infoL.Text = resources.GetString("infoL.Text");
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
            this.applyAmplB.Click += new System.EventHandler(this.ApplyGain);
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
            this.amplUD.ValueChanged += new System.EventHandler(this.AmplValueChanged);
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
            this.signalsGB.Controls.Add(this.toTB);
            this.signalsGB.Controls.Add(this.fromTB);
            this.signalsGB.Controls.Add(this.toL);
            this.signalsGB.Controls.Add(this.fromL);
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
            // toTB
            // 
            this.toTB.Location = new System.Drawing.Point(432, 46);
            this.toTB.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.toTB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.toTB.Name = "toTB";
            this.toTB.Size = new System.Drawing.Size(73, 20);
            this.toTB.TabIndex = 30;
            this.toTB.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.toTB.ValueChanged += new System.EventHandler(this.toTimeChanged);
            // 
            // fromTB
            // 
            this.fromTB.Location = new System.Drawing.Point(432, 21);
            this.fromTB.Maximum = new decimal(new int[] {
            3999,
            0,
            0,
            0});
            this.fromTB.Name = "fromTB";
            this.fromTB.Size = new System.Drawing.Size(73, 20);
            this.fromTB.TabIndex = 29;
            this.fromTB.ValueChanged += new System.EventHandler(this.fromTimeChanged);
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
            // fromL
            // 
            this.fromL.AutoSize = true;
            this.fromL.Location = new System.Drawing.Point(380, 23);
            this.fromL.Name = "fromL";
            this.fromL.Size = new System.Drawing.Size(46, 13);
            this.fromL.TabIndex = 11;
            this.fromL.Text = "Od (ms):";
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
            this.addB.Enabled = false;
            this.addB.Location = new System.Drawing.Point(511, 10);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(49, 60);
            this.addB.TabIndex = 0;
            this.addB.Text = "Dodaj";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.AddSignal);
            // 
            // previewB
            // 
            this.previewB.Location = new System.Drawing.Point(506, 131);
            this.previewB.Name = "previewB";
            this.previewB.Size = new System.Drawing.Size(75, 23);
            this.previewB.TabIndex = 18;
            this.previewB.Text = "Testuj!";
            this.previewB.UseVisualStyleBackColor = true;
            this.previewB.Click += new System.EventHandler(this.TestSound);
            // 
            // createSoundB
            // 
            this.createSoundB.Location = new System.Drawing.Point(509, 315);
            this.createSoundB.Name = "createSoundB";
            this.createSoundB.Size = new System.Drawing.Size(75, 23);
            this.createSoundB.TabIndex = 19;
            this.createSoundB.Text = "Generuj!";
            this.createSoundB.UseVisualStyleBackColor = true;
            this.createSoundB.Click += new System.EventHandler(this.CreateSound);
            // 
            // signalPrevGB
            // 
            this.signalPrevGB.Controls.Add(this.signalDeleteB);
            this.signalPrevGB.Controls.Add(this.signalPreviewB);
            this.signalPrevGB.Controls.Add(this.infoAL3);
            this.signalPrevGB.Controls.Add(this.infoL3);
            this.signalPrevGB.Controls.Add(this.infoAL2);
            this.signalPrevGB.Controls.Add(this.infoL2);
            this.signalPrevGB.Controls.Add(this.infoAL1);
            this.signalPrevGB.Controls.Add(this.infoL1);
            this.signalPrevGB.Location = new System.Drawing.Point(15, 190);
            this.signalPrevGB.Name = "signalPrevGB";
            this.signalPrevGB.Size = new System.Drawing.Size(569, 71);
            this.signalPrevGB.TabIndex = 21;
            this.signalPrevGB.TabStop = false;
            this.signalPrevGB.Text = "Poszczególne sygnały";
            // 
            // signalDeleteB
            // 
            this.signalDeleteB.Location = new System.Drawing.Point(293, 42);
            this.signalDeleteB.Name = "signalDeleteB";
            this.signalDeleteB.Size = new System.Drawing.Size(75, 23);
            this.signalDeleteB.TabIndex = 7;
            this.signalDeleteB.Text = "Usuń";
            this.signalDeleteB.UseVisualStyleBackColor = true;
            this.signalDeleteB.Click += new System.EventHandler(this.DeleteSignalFromList);
            // 
            // signalPreviewB
            // 
            this.signalPreviewB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.signalPreviewB.Location = new System.Drawing.Point(212, 42);
            this.signalPreviewB.Name = "signalPreviewB";
            this.signalPreviewB.Size = new System.Drawing.Size(75, 23);
            this.signalPreviewB.TabIndex = 6;
            this.signalPreviewB.Text = "Podgląd";
            this.signalPreviewB.UseVisualStyleBackColor = true;
            // 
            // infoAL3
            // 
            this.infoAL3.AutoSize = true;
            this.infoAL3.Location = new System.Drawing.Point(488, 16);
            this.infoAL3.Name = "infoAL3";
            this.infoAL3.Size = new System.Drawing.Size(0, 13);
            this.infoAL3.TabIndex = 5;
            // 
            // infoL3
            // 
            this.infoL3.AutoSize = true;
            this.infoL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoL3.Location = new System.Drawing.Point(405, 16);
            this.infoL3.Name = "infoL3";
            this.infoL3.Size = new System.Drawing.Size(77, 13);
            this.infoL3.TabIndex = 4;
            this.infoL3.Text = "Koniec (ms):";
            // 
            // infoAL2
            // 
            this.infoAL2.AutoSize = true;
            this.infoAL2.Location = new System.Drawing.Point(300, 16);
            this.infoAL2.Name = "infoAL2";
            this.infoAL2.Size = new System.Drawing.Size(0, 13);
            this.infoAL2.TabIndex = 3;
            // 
            // infoL2
            // 
            this.infoL2.AutoSize = true;
            this.infoL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoL2.Location = new System.Drawing.Point(209, 16);
            this.infoL2.Name = "infoL2";
            this.infoL2.Size = new System.Drawing.Size(91, 13);
            this.infoL2.TabIndex = 2;
            this.infoL2.Text = "Początek (ms):";
            // 
            // infoAL1
            // 
            this.infoAL1.AutoSize = true;
            this.infoAL1.Location = new System.Drawing.Point(88, 16);
            this.infoAL1.Name = "infoAL1";
            this.infoAL1.Size = new System.Drawing.Size(0, 13);
            this.infoAL1.TabIndex = 1;
            // 
            // infoL1
            // 
            this.infoL1.AutoSize = true;
            this.infoL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoL1.Location = new System.Drawing.Point(6, 16);
            this.infoL1.Name = "infoL1";
            this.infoL1.Size = new System.Drawing.Size(85, 13);
            this.infoL1.TabIndex = 0;
            this.infoL1.Text = "Typ sygnału: ";
            // 
            // deleteAllSignalsB
            // 
            this.deleteAllSignalsB.Location = new System.Drawing.Point(204, 267);
            this.deleteAllSignalsB.Name = "deleteAllSignalsB";
            this.deleteAllSignalsB.Size = new System.Drawing.Size(192, 23);
            this.deleteAllSignalsB.TabIndex = 22;
            this.deleteAllSignalsB.Text = "Wyczyść wygenerowane sygnały";
            this.deleteAllSignalsB.UseVisualStyleBackColor = true;
            this.deleteAllSignalsB.Click += new System.EventHandler(this.DeleteAllSignals);
            // 
            // nextPageB
            // 
            this.nextPageB.Location = new System.Drawing.Point(308, 161);
            this.nextPageB.Name = "nextPageB";
            this.nextPageB.Size = new System.Drawing.Size(33, 23);
            this.nextPageB.TabIndex = 23;
            this.nextPageB.Text = ">";
            this.nextPageB.UseVisualStyleBackColor = true;
            this.nextPageB.Click += new System.EventHandler(this.NextPage);
            // 
            // prevPageB
            // 
            this.prevPageB.Location = new System.Drawing.Point(266, 161);
            this.prevPageB.Name = "prevPageB";
            this.prevPageB.Size = new System.Drawing.Size(33, 23);
            this.prevPageB.TabIndex = 25;
            this.prevPageB.Text = "<";
            this.prevPageB.UseVisualStyleBackColor = true;
            this.prevPageB.Click += new System.EventHandler(this.PrevPage);
            // 
            // lastPageB
            // 
            this.lastPageB.Location = new System.Drawing.Point(347, 161);
            this.lastPageB.Name = "lastPageB";
            this.lastPageB.Size = new System.Drawing.Size(33, 23);
            this.lastPageB.TabIndex = 26;
            this.lastPageB.Text = ">>";
            this.lastPageB.UseVisualStyleBackColor = true;
            this.lastPageB.Click += new System.EventHandler(this.LastPage);
            // 
            // firstPageB
            // 
            this.firstPageB.Location = new System.Drawing.Point(227, 161);
            this.firstPageB.Name = "firstPageB";
            this.firstPageB.Size = new System.Drawing.Size(33, 23);
            this.firstPageB.TabIndex = 27;
            this.firstPageB.Text = "<<";
            this.firstPageB.UseVisualStyleBackColor = true;
            this.firstPageB.Click += new System.EventHandler(this.FirstPage);
            // 
            // soundGraphB
            // 
            this.soundGraphB.Location = new System.Drawing.Point(12, 315);
            this.soundGraphB.Name = "soundGraphB";
            this.soundGraphB.Size = new System.Drawing.Size(107, 23);
            this.soundGraphB.TabIndex = 28;
            this.soundGraphB.Text = "Podgląd dźwięku";
            this.soundGraphB.UseVisualStyleBackColor = true;
            // 
            // SoundGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 343);
            this.Controls.Add(this.soundGraphB);
            this.Controls.Add(this.firstPageB);
            this.Controls.Add(this.lastPageB);
            this.Controls.Add(this.prevPageB);
            this.Controls.Add(this.nextPageB);
            this.Controls.Add(this.deleteAllSignalsB);
            this.Controls.Add(this.signalPrevGB);
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
            ((System.ComponentModel.ISupportInitialize)(this.toTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromTB)).EndInit();
            this.signalPrevGB.ResumeLayout(false);
            this.signalPrevGB.PerformLayout();
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
        private System.Windows.Forms.GroupBox signalPrevGB;
        private System.Windows.Forms.Button deleteAllSignalsB;
        private System.Windows.Forms.Button nextPageB;
        private System.Windows.Forms.Button prevPageB;
        private System.Windows.Forms.Button lastPageB;
        private System.Windows.Forms.Button firstPageB;
        private System.Windows.Forms.Button signalDeleteB;
        private System.Windows.Forms.Button signalPreviewB;
        private System.Windows.Forms.Label infoAL3;
        private System.Windows.Forms.Label infoL3;
        private System.Windows.Forms.Label infoAL2;
        private System.Windows.Forms.Label infoL2;
        private System.Windows.Forms.Label infoAL1;
        private System.Windows.Forms.Label infoL1;
        private System.Windows.Forms.Button soundGraphB;
        private System.Windows.Forms.NumericUpDown toTB;
        private System.Windows.Forms.NumericUpDown fromTB;
    }
}