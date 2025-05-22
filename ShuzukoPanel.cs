using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SCARA_ROBOT_SOFTWARE
{
    public class ShuzukoPanel : Panel
    {
        private int borderRadius = 5;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.White;
        private Color gradientBottomColor = Color.White;
        private Color borderColor = Color.Silver;

        public ShuzukoPanel()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.DoubleBuffered = true;

            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor,
                true
            );
            this.UpdateStyles();
        }

        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; Invalidate(); }
        }

        public float GradientAngle
        {
            get => gradientAngle;
            set { gradientAngle = value; Invalidate(); }
        }

        public Color GradientTopColor
        {
            get => gradientTopColor;
            set { gradientTopColor = value; Invalidate(); }
        }

        public Color GradientBottomColor
        {
            get => gradientBottomColor;
            set { gradientBottomColor = value; Invalidate(); }
        }

        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        private GraphicsPath GetRoundPath(Rectangle bounds, int radius)
        {
            float r = radius * 2F;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(bounds.X, bounds.Y, r, r, 180, 90);
            path.AddArc(bounds.Right - r, bounds.Y, r, r, 270, 90);
            path.AddArc(bounds.Right - r, bounds.Bottom - r, r, r, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            using (GraphicsPath path = GetRoundPath(rect, borderRadius))
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(rect, gradientTopColor, gradientBottomColor, gradientAngle))
                    e.Graphics.FillPath(brush, path);

                if (borderColor != Color.Transparent)
                {
                    using (Pen pen = new Pen(borderColor, 1.2f))
                        e.Graphics.DrawPath(pen, path);
                }

                // Set region để bo góc không bị mất
                this.Region = new Region(path);
            }
        }
    }
}
