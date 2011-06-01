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
            this.chart = new ASynt.Chart();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.chart.AxisColor = System.Drawing.Color.Black;
            this.chart.LinesColor = System.Drawing.Color.DarkBlue;
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.Points = new int[] {
        0,
        1,
        2,
        -1};
            this.chart.Precision = ((uint)(5u));
            this.chart.Size = new System.Drawing.Size(65535, 245);
            this.chart.TabIndex = 0;
            // 
            // ChartDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.chart);
            this.Name = "ChartDialog";
            this.ShowIcon = false;
            this.Text = "Wykres";
            this.ResumeLayout(false);

        }

        #endregion

        private Chart chart;



    }
}