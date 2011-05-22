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
            this.button1 = new System.Windows.Forms.Button();
            this.effectsGB = new System.Windows.Forms.GroupBox();
            this.soundTypeGB = new System.Windows.Forms.GroupBox();
            this.globalMuteCB = new System.Windows.Forms.CheckBox();
            this.globalVolumeSlider = new System.Windows.Forms.TrackBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.globalVolumeSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // effectsGB
            // 
            this.effectsGB.Location = new System.Drawing.Point(12, 12);
            this.effectsGB.Name = "effectsGB";
            this.effectsGB.Size = new System.Drawing.Size(200, 100);
            this.effectsGB.TabIndex = 1;
            this.effectsGB.TabStop = false;
            this.effectsGB.Text = "Efekty";
            // 
            // soundTypeGB
            // 
            this.soundTypeGB.Location = new System.Drawing.Point(649, 12);
            this.soundTypeGB.Name = "soundTypeGB";
            this.soundTypeGB.Size = new System.Drawing.Size(200, 100);
            this.soundTypeGB.TabIndex = 2;
            this.soundTypeGB.TabStop = false;
            this.soundTypeGB.Text = "Rodzaj dźwięku";
            // 
            // globalMuteCB
            // 
            this.globalMuteCB.AutoSize = true;
            this.globalMuteCB.Location = new System.Drawing.Point(374, 65);
            this.globalMuteCB.Name = "globalMuteCB";
            this.globalMuteCB.Size = new System.Drawing.Size(60, 17);
            this.globalMuteCB.TabIndex = 3;
            this.globalMuteCB.Text = "Wycisz";
            this.globalMuteCB.UseVisualStyleBackColor = true;
            // 
            // globalVolumeSlider
            // 
            this.globalVolumeSlider.Location = new System.Drawing.Point(275, 12);
            this.globalVolumeSlider.Name = "globalVolumeSlider";
            this.globalVolumeSlider.Size = new System.Drawing.Size(283, 45);
            this.globalVolumeSlider.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(566, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(471, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(861, 359);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.globalVolumeSlider);
            this.Controls.Add(this.globalMuteCB);
            this.Controls.Add(this.soundTypeGB);
            this.Controls.Add(this.effectsGB);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "ASynt - Awesome Syntezator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.globalVolumeSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox effectsGB;
        private System.Windows.Forms.GroupBox soundTypeGB;
        private System.Windows.Forms.CheckBox globalMuteCB;
        private System.Windows.Forms.TrackBar globalVolumeSlider;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

