using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASynt
{
    public partial class ChartDialog : Form
    {
        public ChartDialog(int[] pointsToChart)
        {
            InitializeComponent();
            chart.Points = pointsToChart;
            toolStripMenuItemQH.Click += new EventHandler(toolStripMenuItemQ_Click);
            toolStripMenuItemQL.Click += new EventHandler(toolStripMenuItemQ_Click);

            toolStripMenuItemP.DropDownItemClicked += new ToolStripItemClickedEventHandler(toolStripMenuItemP_DropDownItemClicked);
        }

        public void toolStripMenuItemQ_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem t = (ToolStripMenuItem)sender;

            if (t.Name == "toolStripMenuItemQL")
            {
                toolStripMenuItemQH.Checked = false;
                chart.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            }
            else
            {
                toolStripMenuItemQL.Checked = false;
                chart.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            }

            t.Checked = true;
        }

        public void toolStripMenuItemP_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem tool in toolStripMenuItemP.DropDownItems)
            {
                tool.Checked = false;
            }

            ToolStripMenuItem t = (ToolStripMenuItem)e.ClickedItem;
            t.Checked = true;

            chart.Precision = UInt32.Parse(t.Text);
        }
    }
}
