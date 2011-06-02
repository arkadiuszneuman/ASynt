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
            this.buttonReverb = new System.Windows.Forms.Button();
            this.buttonGargle = new System.Windows.Forms.Button();
            this.buttonChorus = new System.Windows.Forms.Button();
            this.buttonEcho = new System.Windows.Forms.Button();
            this.soundTypeGB = new System.Windows.Forms.GroupBox();
            this.readFileB = new System.Windows.Forms.Button();
            this.pianoB = new System.Windows.Forms.Button();
            this.soundGeneratorB = new System.Windows.Forms.Button();
            this.saveSequenceB = new System.Windows.Forms.Button();
            this.readSequenceB = new System.Windows.Forms.Button();
            this.playSequenceB = new System.Windows.Forms.Button();
            this.checkBoxRecord = new System.Windows.Forms.CheckBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.effectsGB.SuspendLayout();
            this.soundTypeGB.SuspendLayout();
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
            this.soundTypeGB.Controls.Add(this.readFileB);
            this.soundTypeGB.Controls.Add(this.pianoB);
            this.soundTypeGB.Controls.Add(this.soundGeneratorB);
            this.soundTypeGB.Location = new System.Drawing.Point(369, 132);
            this.soundTypeGB.Name = "soundTypeGB";
            this.soundTypeGB.Size = new System.Drawing.Size(200, 111);
            this.soundTypeGB.TabIndex = 2;
            this.soundTypeGB.TabStop = false;
            this.soundTypeGB.Text = "Rodzaj dźwięku";
            // 
            // readFileB
            // 
            this.readFileB.Location = new System.Drawing.Point(12, 48);
            this.readFileB.Name = "readFileB";
            this.readFileB.Size = new System.Drawing.Size(180, 23);
            this.readFileB.TabIndex = 2;
            this.readFileB.Text = "Wczytaj plik ...";
            this.readFileB.UseVisualStyleBackColor = true;
            this.readFileB.Click += new System.EventHandler(this.ReadFile);
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
            this.soundGeneratorB.Location = new System.Drawing.Point(12, 77);
            this.soundGeneratorB.Name = "soundGeneratorB";
            this.soundGeneratorB.Size = new System.Drawing.Size(180, 23);
            this.soundGeneratorB.TabIndex = 0;
            this.soundGeneratorB.Text = "Generuj";
            this.soundGeneratorB.UseVisualStyleBackColor = true;
            this.soundGeneratorB.Click += new System.EventHandler(this.soundGenerator);
            // 
            // saveSequenceB
            // 
            this.saveSequenceB.Location = new System.Drawing.Point(1, 249);
            this.saveSequenceB.Name = "saveSequenceB";
            this.saveSequenceB.Size = new System.Drawing.Size(116, 23);
            this.saveSequenceB.TabIndex = 3;
            this.saveSequenceB.Text = "Zapisz sekwencję";
            this.saveSequenceB.UseVisualStyleBackColor = true;
            this.saveSequenceB.Click += new System.EventHandler(this.SaveSequence);
            // 
            // readSequenceB
            // 
            this.readSequenceB.Location = new System.Drawing.Point(123, 249);
            this.readSequenceB.Name = "readSequenceB";
            this.readSequenceB.Size = new System.Drawing.Size(116, 23);
            this.readSequenceB.TabIndex = 4;
            this.readSequenceB.Text = "Wczytaj sekwencję";
            this.readSequenceB.UseVisualStyleBackColor = true;
            this.readSequenceB.Click += new System.EventHandler(this.ReadSequence);
            // 
            // playSequenceB
            // 
            this.playSequenceB.Location = new System.Drawing.Point(245, 249);
            this.playSequenceB.Name = "playSequenceB";
            this.playSequenceB.Size = new System.Drawing.Size(116, 23);
            this.playSequenceB.TabIndex = 5;
            this.playSequenceB.Text = "Odtwórz sekwencję";
            this.playSequenceB.UseVisualStyleBackColor = true;
            this.playSequenceB.Click += new System.EventHandler(this.PlaySequence);
            // 
            // checkBoxRecord
            // 
            this.checkBoxRecord.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxRecord.AutoSize = true;
            this.checkBoxRecord.Location = new System.Drawing.Point(367, 249);
            this.checkBoxRecord.Name = "checkBoxRecord";
            this.checkBoxRecord.Size = new System.Drawing.Size(25, 23);
            this.checkBoxRecord.TabIndex = 6;
            this.checkBoxRecord.Text = "O";
            this.checkBoxRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxRecord.UseVisualStyleBackColor = true;
            this.checkBoxRecord.CheckedChanged += new System.EventHandler(this.checkBoxRecord_CheckedChanged);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(398, 249);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(43, 23);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(579, 275);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.checkBoxRecord);
            this.Controls.Add(this.playSequenceB);
            this.Controls.Add(this.readSequenceB);
            this.Controls.Add(this.saveSequenceB);
            this.Controls.Add(this.soundTypeGB);
            this.Controls.Add(this.effectsGB);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "ASynt - Awesome Syntezator";
            this.effectsGB.ResumeLayout(false);
            this.soundTypeGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox effectsGB;
        private System.Windows.Forms.GroupBox soundTypeGB;
        private System.Windows.Forms.Button soundGeneratorB;
        private System.Windows.Forms.Button buttonEcho;
        private System.Windows.Forms.Button buttonChorus;
        private System.Windows.Forms.Button buttonGargle;
        private System.Windows.Forms.Button pianoB;
        private System.Windows.Forms.Button buttonReverb;
        private System.Windows.Forms.Button readFileB;
        private System.Windows.Forms.Button saveSequenceB;
        private System.Windows.Forms.Button readSequenceB;
        private System.Windows.Forms.Button playSequenceB;
        private System.Windows.Forms.CheckBox checkBoxRecord;
        private System.Windows.Forms.Button buttonStop;
    }
}

