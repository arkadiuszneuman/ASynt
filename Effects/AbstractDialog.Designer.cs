﻿namespace ASynt.Effects
{
    partial class AbstractDialog
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
            this.groupBoxProporties = new System.Windows.Forms.GroupBox();
            this.panelProporties = new System.Windows.Forms.Panel();
            this.panelNoEffect = new System.Windows.Forms.Panel();
            this.buttonAddEcho = new System.Windows.Forms.Button();
            this.buttonDeleteEcho = new System.Windows.Forms.Button();
            this.groupBoxProporties.SuspendLayout();
            this.panelNoEffect.SuspendLayout();
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
            // groupBoxProporties
            // 
            this.groupBoxProporties.Controls.Add(this.panelNoEffect);
            this.groupBoxProporties.Controls.Add(this.panelProporties);
            this.groupBoxProporties.Location = new System.Drawing.Point(12, 41);
            this.groupBoxProporties.Name = "groupBoxProporties";
            this.groupBoxProporties.Size = new System.Drawing.Size(361, 389);
            this.groupBoxProporties.TabIndex = 2;
            this.groupBoxProporties.TabStop = false;
            this.groupBoxProporties.Text = "Właściwości echa 0/0";
            // 
            // panelProporties
            // 
            this.panelProporties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProporties.Location = new System.Drawing.Point(3, 16);
            this.panelProporties.Name = "panelProporties";
            this.panelProporties.Size = new System.Drawing.Size(355, 370);
            this.panelProporties.TabIndex = 0;
            // 
            // panelNoEffect
            // 
            this.panelNoEffect.Controls.Add(this.buttonAddEcho);
            this.panelNoEffect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoEffect.Location = new System.Drawing.Point(3, 16);
            this.panelNoEffect.Name = "panelNoEffect";
            this.panelNoEffect.Size = new System.Drawing.Size(355, 370);
            this.panelNoEffect.TabIndex = 13;
            // 
            // buttonAddEcho
            // 
            this.buttonAddEcho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddEcho.Location = new System.Drawing.Point(111, 160);
            this.buttonAddEcho.Name = "buttonAddEcho";
            this.buttonAddEcho.Size = new System.Drawing.Size(132, 50);
            this.buttonAddEcho.TabIndex = 0;
            this.buttonAddEcho.Text = "Dodaj Echo";
            this.buttonAddEcho.UseVisualStyleBackColor = true;
            this.buttonAddEcho.Click += new System.EventHandler(this.buttonAddEffect_Click);
            // 
            // buttonDeleteEcho
            // 
            this.buttonDeleteEcho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteEcho.Location = new System.Drawing.Point(147, 12);
            this.buttonDeleteEcho.Name = "buttonDeleteEcho";
            this.buttonDeleteEcho.Size = new System.Drawing.Size(90, 23);
            this.buttonDeleteEcho.TabIndex = 3;
            this.buttonDeleteEcho.Text = "Usuń ten efekt";
            this.buttonDeleteEcho.UseVisualStyleBackColor = true;
            this.buttonDeleteEcho.Click += new System.EventHandler(this.buttonDeleteEcho_Click);
            // 
            // AbstractDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 442);
            this.Controls.Add(this.buttonDeleteEcho);
            this.Controls.Add(this.groupBoxProporties);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AbstractDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Echo";
            this.groupBoxProporties.ResumeLayout(false);
            this.panelNoEffect.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.GroupBox groupBoxProporties;
        protected System.Windows.Forms.Panel panelProporties;
        private System.Windows.Forms.Button buttonDeleteEcho;
        private System.Windows.Forms.Panel panelNoEffect;
        private System.Windows.Forms.Button buttonAddEcho;
    }
}