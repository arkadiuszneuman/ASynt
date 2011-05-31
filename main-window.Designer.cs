namespace ASynt
{
    partial class MainForm
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
            this.effectsGB = new System.Windows.Forms.GroupBox();
            this.buttonGargle = new System.Windows.Forms.Button();
            this.buttonChorus = new System.Windows.Forms.Button();
            this.buttonEcho = new System.Windows.Forms.Button();
            this.soundTypeGB = new System.Windows.Forms.GroupBox();
            this.pianoB = new System.Windows.Forms.Button();
            this.soundGeneratorB = new System.Windows.Forms.Button();
            this.globalMuteCB = new System.Windows.Forms.CheckBox();
            this.globalVolumeSlider = new System.Windows.Forms.TrackBar();
            this.buttonReverb = new System.Windows.Forms.Button();
            this.effectsGB.SuspendLayout();
            this.soundTypeGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.globalVolumeSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // effectsGB
            // 
            this.effectsGB.Controls.Add(this.buttonReverb);
            this.effectsGB.Controls.Add(this.buttonGargle);
            this.effectsGB.Controls.Add(this.buttonChorus);
            this.effectsGB.Controls.Add(this.buttonEcho);
            this.effectsGB.Location = new System.Drawing.Point(369, 12);
            this.effectsGB.Name = "effectsGB";
            this.effectsGB.Size = new System.Drawing.Size(198, 84);
            this.effectsGB.TabIndex = 1;
            this.effectsGB.TabStop = false;
            this.effectsGB.Text = "Efekty";
            // 
            // buttonGargle
            // 
            this.buttonGargle.Location = new System.Drawing.Point(102, 22);
            this.buttonGargle.Name = "buttonGargle";
            this.buttonGargle.Size = new System.Drawing.Size(90, 23);
            this.buttonGargle.TabIndex = 2;
            this.buttonGargle.Text = "Gargle";
            this.buttonGargle.UseVisualStyleBackColor = true;
            this.buttonGargle.Click += new System.EventHandler(this.buttonGargle_Click);
            // 
            // buttonChorus
            // 
            this.buttonChorus.Location = new System.Drawing.Point(6, 51);
            this.buttonChorus.Name = "buttonChorus";
            this.buttonChorus.Size = new System.Drawing.Size(90, 23);
            this.buttonChorus.TabIndex = 1;
            this.buttonChorus.Text = "Chorus";
            this.buttonChorus.UseVisualStyleBackColor = true;
            this.buttonChorus.Click += new System.EventHandler(this.buttonChorus_Click);
            // 
            // buttonEcho
            // 
            this.buttonEcho.Location = new System.Drawing.Point(6, 22);
            this.buttonEcho.Name = "buttonEcho";
            this.buttonEcho.Size = new System.Drawing.Size(90, 23);
            this.buttonEcho.TabIndex = 0;
            this.buttonEcho.Text = "Echo";
            this.buttonEcho.UseVisualStyleBackColor = true;
            this.buttonEcho.Click += new System.EventHandler(this.buttonEcho_Click);
            // 
            // soundTypeGB
            // 
            this.soundTypeGB.Controls.Add(this.pianoB);
            this.soundTypeGB.Controls.Add(this.soundGeneratorB);
            this.soundTypeGB.Location = new System.Drawing.Point(369, 132);
            this.soundTypeGB.Name = "soundTypeGB";
            this.soundTypeGB.Size = new System.Drawing.Size(200, 100);
            this.soundTypeGB.TabIndex = 2;
            this.soundTypeGB.TabStop = false;
            this.soundTypeGB.Text = "Rodzaj dźwięku";
            // 
            // pianoB
            // 
            this.pianoB.Location = new System.Drawing.Point(12, 19);
            this.pianoB.Name = "pianoB";
            this.pianoB.Size = new System.Drawing.Size(180, 23);
            this.pianoB.TabIndex = 1;
            this.pianoB.Text = "Pianino";
            this.pianoB.UseVisualStyleBackColor = true;
            this.pianoB.Click += new System.EventHandler(this.pianoSound);
            // 
            // soundGeneratorB
            // 
            this.soundGeneratorB.Location = new System.Drawing.Point(12, 48);
            this.soundGeneratorB.Name = "soundGeneratorB";
            this.soundGeneratorB.Size = new System.Drawing.Size(180, 23);
            this.soundGeneratorB.TabIndex = 0;
            this.soundGeneratorB.Text = "Generuj";
            this.soundGeneratorB.UseVisualStyleBackColor = true;
            this.soundGeneratorB.Click += new System.EventHandler(this.soundGenerator);
            // 
            // globalMuteCB
            // 
            this.globalMuteCB.AutoSize = true;
            this.globalMuteCB.Location = new System.Drawing.Point(442, 267);
            this.globalMuteCB.Name = "globalMuteCB";
            this.globalMuteCB.Size = new System.Drawing.Size(60, 17);
            this.globalMuteCB.TabIndex = 3;
            this.globalMuteCB.Text = "Wycisz";
            this.globalMuteCB.UseVisualStyleBackColor = true;
            // 
            // globalVolumeSlider
            // 
            this.globalVolumeSlider.Location = new System.Drawing.Point(369, 239);
            this.globalVolumeSlider.Name = "globalVolumeSlider";
            this.globalVolumeSlider.Size = new System.Drawing.Size(198, 45);
            this.globalVolumeSlider.TabIndex = 4;
            // 
            // buttonReverb
            // 
            this.buttonReverb.Location = new System.Drawing.Point(102, 51);
            this.buttonReverb.Name = "buttonReverb";
            this.buttonReverb.Size = new System.Drawing.Size(90, 23);
            this.buttonReverb.TabIndex = 3;
            this.buttonReverb.Text = "Pogłos";
            this.buttonReverb.UseVisualStyleBackColor = true;
            this.buttonReverb.Click += new System.EventHandler(this.buttonReverb_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(579, 275);
            this.Controls.Add(this.globalVolumeSlider);
            this.Controls.Add(this.globalMuteCB);
            this.Controls.Add(this.soundTypeGB);
            this.Controls.Add(this.effectsGB);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "ASynt - Awesome Syntezator";
            this.effectsGB.ResumeLayout(false);
            this.soundTypeGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.globalVolumeSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox effectsGB;
        private System.Windows.Forms.GroupBox soundTypeGB;
        private System.Windows.Forms.CheckBox globalMuteCB;
        private System.Windows.Forms.TrackBar globalVolumeSlider;
        private System.Windows.Forms.Button soundGeneratorB;
        private System.Windows.Forms.Button buttonEcho;
        private System.Windows.Forms.Button buttonChorus;
        private System.Windows.Forms.Button buttonGargle;
        private System.Windows.Forms.Button pianoB;
        private System.Windows.Forms.Button buttonReverb;
    }
}

