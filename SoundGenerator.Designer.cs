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
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.gainL = new System.Windows.Forms.Label();
            this.infoL = new System.Windows.Forms.Label();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.applyGainB = new System.Windows.Forms.Button();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.signalsGB = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.sinWave = new System.Windows.Forms.RadioButton();
            this.addB = new System.Windows.Forms.Button();
            this.previewB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.signalsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(280, 43);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(85, 17);
            this.radioButton8.TabIndex = 8;
            this.radioButton8.TabStop = true;
            this.radioButton8.Tag = "7";
            this.radioButton8.Text = "radioButton8";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.SignalChanged);
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
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(280, 20);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(85, 17);
            this.radioButton7.TabIndex = 7;
            this.radioButton7.TabStop = true;
            this.radioButton7.Tag = "6";
            this.radioButton7.Text = "radioButton7";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.SignalChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(189, 43);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(85, 17);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.TabStop = true;
            this.radioButton6.Tag = "5";
            this.radioButton6.Text = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.SignalChanged);
            // 
            // applyGainB
            // 
            this.applyGainB.Location = new System.Drawing.Point(345, 134);
            this.applyGainB.Name = "applyGainB";
            this.applyGainB.Size = new System.Drawing.Size(75, 20);
            this.applyGainB.TabIndex = 17;
            this.applyGainB.Text = "Zmień";
            this.applyGainB.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(189, 20);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Tag = "4";
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.SignalChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(98, 43);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "3";
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.SignalChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(276, 134);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(98, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "2";
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.SignalChanged);
            // 
            // signalsGB
            // 
            this.signalsGB.Controls.Add(this.radioButton8);
            this.signalsGB.Controls.Add(this.radioButton7);
            this.signalsGB.Controls.Add(this.radioButton6);
            this.signalsGB.Controls.Add(this.radioButton5);
            this.signalsGB.Controls.Add(this.radioButton4);
            this.signalsGB.Controls.Add(this.radioButton3);
            this.signalsGB.Controls.Add(this.radioButton2);
            this.signalsGB.Controls.Add(this.sinWave);
            this.signalsGB.Controls.Add(this.addB);
            this.signalsGB.Location = new System.Drawing.Point(15, 52);
            this.signalsGB.Name = "signalsGB";
            this.signalsGB.Size = new System.Drawing.Size(566, 76);
            this.signalsGB.TabIndex = 14;
            this.signalsGB.TabStop = false;
            this.signalsGB.Text = "Sygnały";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "1";
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.SignalChanged);
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
            // 
            // SoundGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 411);
            this.Controls.Add(this.gainL);
            this.Controls.Add(this.infoL);
            this.Controls.Add(this.applyGainB);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.signalsGB);
            this.Controls.Add(this.previewB);
            this.Name = "SoundGenerator";
            this.Text = "SoundGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.signalsGB.ResumeLayout(false);
            this.signalsGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Label gainL;
        private System.Windows.Forms.Label infoL;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Button applyGainB;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox signalsGB;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton sinWave;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Button previewB;
    }
}