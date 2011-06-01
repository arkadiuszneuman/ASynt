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
        }
    }
}
