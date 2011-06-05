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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.effectsGB = new System.Windows.Forms.GroupBox();
            this.buttonReverb = new System.Windows.Forms.Button();
            this.buttonGargle = new System.Windows.Forms.Button();
            this.buttonChorus = new System.Windows.Forms.Button();
            this.buttonEcho = new System.Windows.Forms.Button();
            this.soundTypeGB = new System.Windows.Forms.GroupBox();
            this.readFileB = new System.Windows.Forms.Button();
            this.pianoB = new System.Windows.Forms.Button();
            this.soundGeneratorB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.effectsGB.SuspendLayout();
            this.soundTypeGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // effectsGB
            // 
            this.effectsGB.Controls.Add(this.buttonReverb);
            this.effectsGB.Controls.Add(this.buttonGargle);
            this.effectsGB.Controls.Add(this.buttonChorus);
            this.effectsGB.Controls.Add(this.buttonEcho);
            this.effectsGB.Location = new System.Drawing.Point(313, 146);
            this.effectsGB.Name = "effectsGB";
            this.effectsGB.Size = new System.Drawing.Size(254, 84);
            this.effectsGB.TabIndex = 1;
            this.effectsGB.TabStop = false;
            this.effectsGB.Text = "Efekty";
            // 
            // buttonReverb
            // 
            this.buttonReverb.Location = new System.Drawing.Point(132, 51);
            this.buttonReverb.Name = "buttonReverb";
            this.buttonReverb.Size = new System.Drawing.Size(116, 23);
            this.buttonReverb.TabIndex = 3;
            this.buttonReverb.Text = "Pogłos";
            this.buttonReverb.UseVisualStyleBackColor = true;
            this.buttonReverb.Click += new System.EventHandler(this.buttonReverb_Click);
            // 
            // buttonGargle
            // 
            this.buttonGargle.Location = new System.Drawing.Point(132, 22);
            this.buttonGargle.Name = "buttonGargle";
            this.buttonGargle.Size = new System.Drawing.Size(116, 23);
            this.buttonGargle.TabIndex = 2;
            this.buttonGargle.Text = "Gargle";
            this.buttonGargle.UseVisualStyleBackColor = true;
            this.buttonGargle.Click += new System.EventHandler(this.buttonGargle_Click);
            // 
            // buttonChorus
            // 
            this.buttonChorus.Location = new System.Drawing.Point(6, 51);
            this.buttonChorus.Name = "buttonChorus";
            this.buttonChorus.Size = new System.Drawing.Size(116, 23);
            this.buttonChorus.TabIndex = 1;
            this.buttonChorus.Text = "Chorus";
            this.buttonChorus.UseVisualStyleBackColor = true;
            this.buttonChorus.Click += new System.EventHandler(this.buttonChorus_Click);
            // 
            // buttonEcho
            // 
            this.buttonEcho.Location = new System.Drawing.Point(6, 22);
            this.buttonEcho.Name = "buttonEcho";
            this.buttonEcho.Size = new System.Drawing.Size(116, 23);
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
            this.soundTypeGB.Location = new System.Drawing.Point(12, 236);
            this.soundTypeGB.Name = "soundTypeGB";
            this.soundTypeGB.Size = new System.Drawing.Size(555, 49);
            this.soundTypeGB.TabIndex = 2;
            this.soundTypeGB.TabStop = false;
            this.soundTypeGB.Text = "Rodzaj dźwięku";
            // 
            // readFileB
            // 
            this.readFileB.Location = new System.Drawing.Point(190, 19);
            this.readFileB.Name = "readFileB";
            this.readFileB.Size = new System.Drawing.Size(181, 23);
            this.readFileB.TabIndex = 2;
            this.readFileB.Text = "Wczytaj plik ...";
            this.readFileB.UseVisualStyleBackColor = true;
            this.readFileB.Click += new System.EventHandler(this.ReadFile);
            // 
            // pianoB
            // 
            this.pianoB.Location = new System.Drawing.Point(12, 19);
            this.pianoB.Name = "pianoB";
            this.pianoB.Size = new System.Drawing.Size(172, 23);
            this.pianoB.TabIndex = 1;
            this.pianoB.Text = "Pianino";
            this.pianoB.UseVisualStyleBackColor = true;
            this.pianoB.Click += new System.EventHandler(this.pianoSound);
            // 
            // soundGeneratorB
            // 
            this.soundGeneratorB.Location = new System.Drawing.Point(377, 19);
            this.soundGeneratorB.Name = "soundGeneratorB";
            this.soundGeneratorB.Size = new System.Drawing.Size(172, 23);
            this.soundGeneratorB.TabIndex = 0;
            this.soundGeneratorB.Text = "Generuj";
            this.soundGeneratorB.UseVisualStyleBackColor = true;
            this.soundGeneratorB.Click += new System.EventHandler(this.soundGenerator);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(313, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 117);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(579, 290);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.soundTypeGB);
            this.Controls.Add(this.effectsGB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(595, 328);
            this.MinimumSize = new System.Drawing.Size(595, 328);
            this.Name = "MainForm";
            this.Text = "ASynt - Awesome Syntezator";
            this.effectsGB.ResumeLayout(false);
            this.soundTypeGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

