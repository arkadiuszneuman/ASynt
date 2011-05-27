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
            this.buttonEcho = new System.Windows.Forms.Button();
            this.soundTypeGB = new System.Windows.Forms.GroupBox();
            this.soundGeneratorB = new System.Windows.Forms.Button();
            this.globalMuteCB = new System.Windows.Forms.CheckBox();
            this.globalVolumeSlider = new System.Windows.Forms.TrackBar();
            this.effectsGB.SuspendLayout();
            this.soundTypeGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.globalVolumeSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // effectsGB
            // 
            this.effectsGB.Controls.Add(this.buttonEcho);
            this.effectsGB.Location = new System.Drawing.Point(369, 12);
            this.effectsGB.Name = "effectsGB";
            this.effectsGB.Size = new System.Drawing.Size(198, 114);
            this.effectsGB.TabIndex = 1;
            this.effectsGB.TabStop = false;
            this.effectsGB.Text = "Efekty";
            // 
            // buttonEcho
            // 
            this.buttonEcho.Location = new System.Drawing.Point(6, 22);
            this.buttonEcho.Name = "buttonEcho";
            this.buttonEcho.Size = new System.Drawing.Size(102, 23);
            this.buttonEcho.TabIndex = 0;
            this.buttonEcho.Text = "Edytuj echo";
            this.buttonEcho.UseVisualStyleBackColor = true;
            this.buttonEcho.Click += new System.EventHandler(this.buttonEcho_Click);
            // 
            // soundTypeGB
            // 
            this.soundTypeGB.Controls.Add(this.soundGeneratorB);
            this.soundTypeGB.Location = new System.Drawing.Point(369, 132);
            this.soundTypeGB.Name = "soundTypeGB";
            this.soundTypeGB.Size = new System.Drawing.Size(200, 100);
            this.soundTypeGB.TabIndex = 2;
            this.soundTypeGB.TabStop = false;
            this.soundTypeGB.Text = "Rodzaj dźwięku";
            // 
            // soundGeneratorB
            // 
            this.soundGeneratorB.Location = new System.Drawing.Point(6, 71);
            this.soundGeneratorB.Name = "soundGeneratorB";
            this.soundGeneratorB.Size = new System.Drawing.Size(188, 23);
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
    }
}

