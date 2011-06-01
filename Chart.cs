using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASynt
{
    public class Chart : Panel
    {
        private int[] points = new int[4];
        private int max;
        private int min;

        /// <summary>
        /// Określenie precyzji malowania - co którą próbkę malować
        /// </summary>
        private uint precision = 1;
        [Browsable(true), Category("Chart")]
        public uint Precision
        {
            get { return precision; }
            set 
            {
                precision = value;
                Invalidate();
            } 
        }

        private Color linesColor = Color.Red, axisColor = Color.Black;
        /// <summary>
        /// Setter i getter koloru linii
        /// </summary>
        [Browsable(true), Category("Chart")]
        public Color LinesColor
        {
            get { return linesColor; }
            set { linesColor = value; Invalidate(); }
        }

        /// <summary>
        /// Setter i getter koloru osi
        /// </summary>
        [Browsable(true), Category("Chart")]
        public Color AxisColor
        {
            get { return axisColor; }
            set { axisColor = value; Invalidate(); }
        }

        /// <summary>
        /// Setter i getter wszystkich punktów wykresu
        /// </summary>
        [Browsable(true), Category("Chart"),
        DefaultValue(new int[] {0, 1, -1, 2, 3})]
        public int[] Points
        {
            get { return points; }
            set
            {
                points = value;

                max = points.Max();
                min = points.Min();

                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
            Pen axisPen = new Pen(axisColor, 1);
            
            //pionowa x
            g.DrawLine(axisPen, 8, 0, 8, Size.Height);
            g.DrawLine(axisPen, 8, 0, 5, 12);
            g.DrawLine(axisPen, 8, 0, 11, 12);

            //pozioma y
            int heightY;
            float sectorX, sectorY = 0;
            if (min >= 0)
            {
                heightY = Size.Height - 10;
                if (max != 0)
                    sectorY = (Size.Height - 20) / max;
            }
            else
            {
                float diff = max - min;
                sectorY = (Size.Height - 10) / (diff);
                heightY = (int)(sectorY * max);
            }
            g.DrawLine(axisPen, 0, heightY, Size.Width, heightY);
            g.DrawLine(axisPen, Size.Width - 12, heightY - 3, Size.Width, heightY);
            g.DrawLine(axisPen, Size.Width - 12, heightY + 3, Size.Width, heightY);

            axisPen.Dispose();

            //malowanie lini pomiedzy punktami
            if (points != null && points.Length > precision + 1)
            {
                Pen linesPen = new Pen(linesColor);
                sectorX = (float)((Size.Width) * 1.0 / (points.Length + 2));

                Point[] p = new Point[points.Length/precision + 1];
                int sample = 0;
                for (int i = 0; i < points.Length; ++i)
                {

                    if (i % precision == 0)
                    {
                        p[sample] = new Point((int)(sectorX * i) + 8, heightY - (int)(sectorY * points[i]));
                        ++sample;
                    }
                }

                g.DrawLines(linesPen, p);

                linesPen.Dispose();
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Invalidate();
        }
    }
}
