namespace ASynt
{
    partial class ChartDialog
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemQ = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemQH = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemQL = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.chart = new ASynt.Chart();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemQ,
            this.toolStripMenuItemP});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.ShowCheckMargin = true;
            this.contextMenuStrip.ShowImageMargin = false;
            this.contextMenuStrip.Size = new System.Drawing.Size(137, 48);
            // 
            // toolStripMenuItemQ
            // 
            this.toolStripMenuItemQ.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemQH,
            this.toolStripMenuItemQL});
            this.toolStripMenuItemQ.Name = "toolStripMenuItemQ";
            this.toolStripMenuItemQ.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItemQ.Text = "Jakość";
            // 
            // toolStripMenuItemP
            // 
            this.toolStripMenuItemP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem5,
            this.toolStripMenuItem10});
            this.toolStripMenuItemP.Name = "toolStripMenuItemP";
            this.toolStripMenuItemP.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItemP.Text = "Dokładność";
            // 
            // toolStripMenuItemQH
            // 
            this.toolStripMenuItemQH.Name = "toolStripMenuItemQH";
            this.toolStripMenuItemQH.Size = new System.Drawing.Size(115, 22);
            this.toolStripMenuItemQH.Text = "Wysoka";
            // 
            // toolStripMenuItemQL
            // 
            this.toolStripMenuItemQL.Checked = true;
            this.toolStripMenuItemQL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemQL.Name = "toolStripMenuItemQL";
            this.toolStripMenuItemQL.Size = new System.Drawing.Size(115, 22);
            this.toolStripMenuItemQL.Text = "Niska";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem1.Text = "1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem2.Text = "2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Checked = true;
            this.toolStripMenuItem3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem3.Text = "3";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem5.Text = "5";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem10.Text = "10";
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.chart.AxisColor = System.Drawing.Color.Black;
            this.chart.BackColor = System.Drawing.Color.White;
            this.chart.ContextMenuStrip = this.contextMenuStrip;
            this.chart.LinesColor = System.Drawing.Color.DarkBlue;
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.Points = new int[] {
        0,
        1,
        2,
        -1};
            this.chart.Precision = ((uint)(5u));
            this.chart.Size = new System.Drawing.Size(65535, 233);
            this.chart.Smoothing = System.Drawing.Drawing2D.SmoothingMode.Default;
            this.chart.TabIndex = 0;
            // 
            // ChartDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.chart);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "ChartDialog";
            this.ShowIcon = false;
            this.Text = "Wykres";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Chart chart;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQ;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQH;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQL;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemP;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;



    }
}