using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace NeuroBuddy.View
{
    public partial class CircularProgressBar : UserControl
    {

        private int value = 0;
        private int min = 0;
        private int max = 100;
        private Color progressColor = Color.DodgerBlue;
        private int strokeWidth = 10;
        private bool transperancy;

        [Browsable(true)]
        [DefaultValue(0)]
        public int Minimum
        {
            get => min;
            set { min = value; Invalidate(); }
        }

        [Browsable(true)]
        [DefaultValue(100)]
        public int Maximum
        {
            get => max;
            set { max = value; Invalidate(); }
        }

        [Browsable(true)]
        [DefaultValue(0)]
        public int Value
        {
            get => this.value;
            set
            {
                if (value < min || value > max)
                    throw new ArgumentOutOfRangeException();
                this.value = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        [DefaultValue(typeof(Color), "DodgerBlue")]
        public Color ProgressColor
        {
            get => progressColor;
            set { progressColor = value; Invalidate(); }
        }

        [Browsable(true)]
        [DefaultValue(10)]
        public int StrokeWidth
        {
            get => strokeWidth;
            set { strokeWidth = value; Invalidate(); }
        }

        public CircularProgressBar()
        {
            this.Size = new Size(120, 120);
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw background circle
            Rectangle rect = new Rectangle(strokeWidth, strokeWidth,
                                           Width - 2 * strokeWidth,
                                           Height - 2 * strokeWidth);

            using (Pen bgPen = new Pen(Color.LightGray, strokeWidth))
                e.Graphics.DrawArc(bgPen, rect, -90, 360);

            // Draw progress arc
            float sweepAngle = 360f * (Value - Minimum) / (Maximum - Minimum);
            using (Pen progressPen = new Pen(progressColor, strokeWidth))
                e.Graphics.DrawArc(progressPen, rect, -90, sweepAngle);

            // Optional: draw percentage text
              string text = $"{(int)((Value - Minimum) * 100.0 / (Maximum - Minimum))}%";
              SizeF textSize = e.Graphics.MeasureString(text, this.Font);
              e.Graphics.DrawString(text, this.Font, Brushes.Black,
                  (Width - textSize.Width) / 2, (Height - textSize.Height) / 2);
          }
        }
    }
  

