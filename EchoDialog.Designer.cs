namespace ASynt
{
    partial class EchoDialog
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
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.groupBoxEchoProporties = new System.Windows.Forms.GroupBox();
            this.panelEchoProporties = new System.Windows.Forms.Panel();
            this.checkBoxPanDelay = new System.Windows.Forms.CheckBox();
            this.labelHowRightDelay = new System.Windows.Forms.Label();
            this.trackBarRightDelay = new System.Windows.Forms.TrackBar();
            this.labelRightDelay = new System.Windows.Forms.Label();
            this.labelHowLeftDelay = new System.Windows.Forms.Label();
            this.trackBarLeftDelay = new System.Windows.Forms.TrackBar();
            this.labelLeftDelay = new System.Windows.Forms.Label();
            this.labelHowFeedback = new System.Windows.Forms.Label();
            this.trackBarFeedback = new System.Windows.Forms.TrackBar();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.labelHowWet = new System.Windows.Forms.Label();
            this.trackBarWet = new System.Windows.Forms.TrackBar();
            this.labelWet = new System.Windows.Forms.Label();
            this.panelNoEcho = new System.Windows.Forms.Panel();
            this.buttonAddEcho = new System.Windows.Forms.Button();
            this.buttonDeleteEcho = new System.Windows.Forms.Button();
            this.groupBoxEchoProporties.SuspendLayout();
            this.panelEchoProporties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRightDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeftDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFeedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWet)).BeginInit();
            this.panelNoEcho.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Location = new System.Drawing.Point(289, 12);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(84, 23);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = "Następne ->";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Enabled = false;
            this.buttonPrevious.Location = new System.Drawing.Point(12, 12);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(84, 23);
            this.buttonPrevious.TabIndex = 1;
            this.buttonPrevious.Text = "<- Poprzednie";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // groupBoxEchoProporties
            // 
            this.groupBoxEchoProporties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEchoProporties.Controls.Add(this.panelEchoProporties);
            this.groupBoxEchoProporties.Location = new System.Drawing.Point(12, 41);
            this.groupBoxEchoProporties.Name = "groupBoxEchoProporties";
            this.groupBoxEchoProporties.Size = new System.Drawing.Size(361, 220);
            this.groupBoxEchoProporties.TabIndex = 2;
            this.groupBoxEchoProporties.TabStop = false;
            this.groupBoxEchoProporties.Text = "Właściwości echa 0/0";
            // 
            // panelEchoProporties
            // 
            this.panelEchoProporties.Controls.Add(this.panelNoEcho);
            this.panelEchoProporties.Controls.Add(this.checkBoxPanDelay);
            this.panelEchoProporties.Controls.Add(this.labelHowRightDelay);
            this.panelEchoProporties.Controls.Add(this.trackBarRightDelay);
            this.panelEchoProporties.Controls.Add(this.labelRightDelay);
            this.panelEchoProporties.Controls.Add(this.labelHowLeftDelay);
            this.panelEchoProporties.Controls.Add(this.trackBarLeftDelay);
            this.panelEchoProporties.Controls.Add(this.labelLeftDelay);
            this.panelEchoProporties.Controls.Add(this.labelHowFeedback);
            this.panelEchoProporties.Controls.Add(this.trackBarFeedback);
            this.panelEchoProporties.Controls.Add(this.labelFeedback);
            this.panelEchoProporties.Controls.Add(this.labelHowWet);
            this.panelEchoProporties.Controls.Add(this.trackBarWet);
            this.panelEchoProporties.Controls.Add(this.labelWet);
            this.panelEchoProporties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEchoProporties.Location = new System.Drawing.Point(3, 16);
            this.panelEchoProporties.Name = "panelEchoProporties";
            this.panelEchoProporties.Size = new System.Drawing.Size(355, 201);
            this.panelEchoProporties.TabIndex = 0;
            // 
            // checkBoxPanDelay
            // 
            this.checkBoxPanDelay.AutoSize = true;
            this.checkBoxPanDelay.Location = new System.Drawing.Point(137, 172);
            this.checkBoxPanDelay.Name = "checkBoxPanDelay";
            this.checkBoxPanDelay.Size = new System.Drawing.Size(72, 17);
            this.checkBoxPanDelay.TabIndex = 12;
            this.checkBoxPanDelay.Text = "PanDelay";
            this.checkBoxPanDelay.UseVisualStyleBackColor = true;
            this.checkBoxPanDelay.CheckedChanged += new System.EventHandler(this.trackBarValueChanged);
            // 
            // labelHowRightDelay
            // 
            this.labelHowRightDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHowRightDelay.AutoSize = true;
            this.labelHowRightDelay.Location = new System.Drawing.Point(317, 130);
            this.labelHowRightDelay.Name = "labelHowRightDelay";
            this.labelHowRightDelay.Size = new System.Drawing.Size(13, 13);
            this.labelHowRightDelay.TabIndex = 11;
            this.labelHowRightDelay.Text = "1";
            // 
            // trackBarRightDelay
            // 
            this.trackBarRightDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarRightDelay.LargeChange = 10;
            this.trackBarRightDelay.Location = new System.Drawing.Point(153, 121);
            this.trackBarRightDelay.Maximum = 2000;
            this.trackBarRightDelay.Minimum = 1;
            this.trackBarRightDelay.Name = "trackBarRightDelay";
            this.trackBarRightDelay.Size = new System.Drawing.Size(158, 45);
            this.trackBarRightDelay.SmallChange = 5;
            this.trackBarRightDelay.TabIndex = 10;
            this.trackBarRightDelay.TickFrequency = 100;
            this.trackBarRightDelay.Value = 1;
            this.trackBarRightDelay.ValueChanged += new System.EventHandler(this.trackBarValueChanged);
            // 
            // labelRightDelay
            // 
            this.labelRightDelay.AutoSize = true;
            this.labelRightDelay.Location = new System.Drawing.Point(3, 130);
            this.labelRightDelay.Name = "labelRightDelay";
            this.labelRightDelay.Size = new System.Drawing.Size(144, 13);
            this.labelRightDelay.TabIndex = 9;
            this.labelRightDelay.Text = "Opóźnienie prawego kanału:";
            // 
            // labelHowLeftDelay
            // 
            this.labelHowLeftDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHowLeftDelay.AutoSize = true;
            this.labelHowLeftDelay.Location = new System.Drawing.Point(317, 92);
            this.labelHowLeftDelay.Name = "labelHowLeftDelay";
            this.labelHowLeftDelay.Size = new System.Drawing.Size(13, 13);
            this.labelHowLeftDelay.TabIndex = 8;
            this.labelHowLeftDelay.Text = "1";
            // 
            // trackBarLeftDelay
            // 
            this.trackBarLeftDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarLeftDelay.LargeChange = 10;
            this.trackBarLeftDelay.Location = new System.Drawing.Point(153, 83);
            this.trackBarLeftDelay.Maximum = 2000;
            this.trackBarLeftDelay.Minimum = 1;
            this.trackBarLeftDelay.Name = "trackBarLeftDelay";
            this.trackBarLeftDelay.Size = new System.Drawing.Size(158, 45);
            this.trackBarLeftDelay.SmallChange = 5;
            this.trackBarLeftDelay.TabIndex = 7;
            this.trackBarLeftDelay.TickFrequency = 100;
            this.trackBarLeftDelay.Value = 1;
            this.trackBarLeftDelay.ValueChanged += new System.EventHandler(this.trackBarValueChanged);
            // 
            // labelLeftDelay
            // 
            this.labelLeftDelay.AutoSize = true;
            this.labelLeftDelay.Location = new System.Drawing.Point(3, 92);
            this.labelLeftDelay.Name = "labelLeftDelay";
            this.labelLeftDelay.Size = new System.Drawing.Size(137, 13);
            this.labelLeftDelay.TabIndex = 6;
            this.labelLeftDelay.Text = "Opóźnienie lewego kanału:";
            // 
            // labelHowFeedback
            // 
            this.labelHowFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHowFeedback.AutoSize = true;
            this.labelHowFeedback.Location = new System.Drawing.Point(317, 51);
            this.labelHowFeedback.Name = "labelHowFeedback";
            this.labelHowFeedback.Size = new System.Drawing.Size(13, 13);
            this.labelHowFeedback.TabIndex = 5;
            this.labelHowFeedback.Text = "0";
            // 
            // trackBarFeedback
            // 
            this.trackBarFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarFeedback.LargeChange = 10;
            this.trackBarFeedback.Location = new System.Drawing.Point(153, 42);
            this.trackBarFeedback.Maximum = 100;
            this.trackBarFeedback.Name = "trackBarFeedback";
            this.trackBarFeedback.Size = new System.Drawing.Size(158, 45);
            this.trackBarFeedback.SmallChange = 5;
            this.trackBarFeedback.TabIndex = 4;
            this.trackBarFeedback.TickFrequency = 5;
            this.trackBarFeedback.ValueChanged += new System.EventHandler(this.trackBarValueChanged);
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Location = new System.Drawing.Point(3, 51);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(55, 13);
            this.labelFeedback.TabIndex = 3;
            this.labelFeedback.Text = "Feedback";
            // 
            // labelHowWet
            // 
            this.labelHowWet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHowWet.AutoSize = true;
            this.labelHowWet.Location = new System.Drawing.Point(317, 12);
            this.labelHowWet.Name = "labelHowWet";
            this.labelHowWet.Size = new System.Drawing.Size(13, 13);
            this.labelHowWet.TabIndex = 2;
            this.labelHowWet.Text = "0";
            // 
            // trackBarWet
            // 
            this.trackBarWet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarWet.LargeChange = 10;
            this.trackBarWet.Location = new System.Drawing.Point(153, 3);
            this.trackBarWet.Maximum = 100;
            this.trackBarWet.Name = "trackBarWet";
            this.trackBarWet.Size = new System.Drawing.Size(158, 45);
            this.trackBarWet.SmallChange = 5;
            this.trackBarWet.TabIndex = 1;
            this.trackBarWet.TickFrequency = 5;
            this.trackBarWet.ValueChanged += new System.EventHandler(this.trackBarValueChanged);
            // 
            // labelWet
            // 
            this.labelWet.AutoSize = true;
            this.labelWet.Location = new System.Drawing.Point(3, 12);
            this.labelWet.Name = "labelWet";
            this.labelWet.Size = new System.Drawing.Size(51, 13);
            this.labelWet.TabIndex = 0;
            this.labelWet.Text = "wetDryFx";
            // 
            // panelNoEcho
            // 
            this.panelNoEcho.Controls.Add(this.buttonAddEcho);
            this.panelNoEcho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoEcho.Location = new System.Drawing.Point(0, 0);
            this.panelNoEcho.Name = "panelNoEcho";
            this.panelNoEcho.Size = new System.Drawing.Size(355, 201);
            this.panelNoEcho.TabIndex = 13;
            // 
            // buttonAddEcho
            // 
            this.buttonAddEcho.Location = new System.Drawing.Point(111, 75);
            this.buttonAddEcho.Name = "buttonAddEcho";
            this.buttonAddEcho.Size = new System.Drawing.Size(132, 50);
            this.buttonAddEcho.TabIndex = 0;
            this.buttonAddEcho.Text = "Dodaj Echo";
            this.buttonAddEcho.UseVisualStyleBackColor = true;
            this.buttonAddEcho.Click += new System.EventHandler(this.buttonAddEcho_Click);
            // 
            // buttonDeleteEcho
            // 
            this.buttonDeleteEcho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteEcho.Location = new System.Drawing.Point(150, 12);
            this.buttonDeleteEcho.Name = "buttonDeleteEcho";
            this.buttonDeleteEcho.Size = new System.Drawing.Size(84, 23);
            this.buttonDeleteEcho.TabIndex = 3;
            this.buttonDeleteEcho.Text = "Usuń to echo";
            this.buttonDeleteEcho.UseVisualStyleBackColor = true;
            this.buttonDeleteEcho.Click += new System.EventHandler(this.buttonDeleteEcho_Click);
            // 
            // EchoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 273);
            this.Controls.Add(this.buttonDeleteEcho);
            this.Controls.Add(this.groupBoxEchoProporties);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EchoDialog";
            this.ShowIcon = false;
            this.Text = "Echo";
            this.groupBoxEchoProporties.ResumeLayout(false);
            this.panelEchoProporties.ResumeLayout(false);
            this.panelEchoProporties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRightDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeftDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFeedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWet)).EndInit();
            this.panelNoEcho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.GroupBox groupBoxEchoProporties;
        private System.Windows.Forms.Panel panelEchoProporties;
        private System.Windows.Forms.Label labelWet;
        private System.Windows.Forms.TrackBar trackBarWet;
        private System.Windows.Forms.CheckBox checkBoxPanDelay;
        private System.Windows.Forms.Label labelHowRightDelay;
        private System.Windows.Forms.TrackBar trackBarRightDelay;
        private System.Windows.Forms.Label labelRightDelay;
        private System.Windows.Forms.Label labelHowLeftDelay;
        private System.Windows.Forms.TrackBar trackBarLeftDelay;
        private System.Windows.Forms.Label labelLeftDelay;
        private System.Windows.Forms.Label labelHowFeedback;
        private System.Windows.Forms.TrackBar trackBarFeedback;
        private System.Windows.Forms.Label labelFeedback;
        private System.Windows.Forms.Label labelHowWet;
        private System.Windows.Forms.Button buttonDeleteEcho;
        private System.Windows.Forms.Panel panelNoEcho;
        private System.Windows.Forms.Button buttonAddEcho;
    }
}