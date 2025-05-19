using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SCARA_ROBOT_SOFTWARE
{
    public class ShuzukoPanel : Panel
    {
        private int borderRadius = 30;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.DodgerBlue;

        public ShuzukoPanel()
        {
            this.BackColor = Color.White; 
            this.ForeColor = Color.Black; 
            this.DoubleBuffered = true;   
            this.Resize += new EventHandler(OnResize); 
        }

        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                UpdateRegion();
            }
        }

        public float GradientAngle
        {
            get => gradientAngle;
            set
            {
                gradientAngle = value;
                this.Invalidate();
            }
        }

        public Color GradientTopColor
        {
            get => gradientTopColor;
            set
            {
                gradientTopColor = value;
                this.Invalidate();
            }
        }

        public Color GradientBottomColor
        {
            get => gradientBottomColor;
            set
            {
                gradientBottomColor = value;
                this.Invalidate();
            }
        }

        private GraphicsPath GetShuzukoPath(RectangleF rectangle, float radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            float curveSize = radius * 2F;

            graphicsPath.StartFigure();
            graphicsPath.AddArc(rectangle.X, rectangle.Y, curveSize, curveSize, 180, 90); // Top-left
            graphicsPath.AddArc(rectangle.Right - curveSize, rectangle.Y, curveSize, curveSize, 270, 90); // Top-right
            graphicsPath.AddArc(rectangle.Right - curveSize, rectangle.Bottom - curveSize, curveSize, curveSize, 0, 90); // Bottom-right
            graphicsPath.AddArc(rectangle.X, rectangle.Bottom - curveSize, curveSize, curveSize, 90, 90); // Bottom-left
            graphicsPath.CloseFigure();

            return graphicsPath;
        }

        private void UpdateRegion()
        {
            if (borderRadius > 2)
            {
                using (GraphicsPath path = GetShuzukoPath(new RectangleF(0, 0, this.Width, this.Height), borderRadius))
                {
                    this.Region = new Region(path);
                }
            }
            else
            {
                this.Region = new Region(new RectangleF(0, 0, this.Width, this.Height));
            }
            this.Invalidate(); 
        }

        private void OnResize(object? sender, EventArgs e)
        {
            UpdateRegion(); 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            if (gradientTopColor != Color.Transparent || gradientBottomColor != Color.Transparent)
            {
                this.BackColor = Color.Transparent;
                e.Graphics.Clear(this.Parent?.BackColor ?? Color.Transparent);

                using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, gradientTopColor, gradientBottomColor, gradientAngle))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }

                if (borderRadius > 2)
                {
                    using (GraphicsPath path = GetShuzukoPath(ClientRectangle, borderRadius))
                    using (Pen pen = new Pen(this.Parent?.BackColor ?? SystemColors.Control, 2))
                    {
                        e.Graphics.DrawPath(pen, path);
                        this.Region = new Region(path);
                    }
                }
                else
                {
                    this.Region = new Region(ClientRectangle);
                }
            }
            else
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, gradientTopColor, gradientBottomColor, gradientAngle))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }

                if (borderRadius > 2)
                {
                    using (GraphicsPath path = GetShuzukoPath(ClientRectangle, borderRadius))
                    using (Pen pen = new Pen(this.Parent?.BackColor ?? SystemColors.Control, 2))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }

            }
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            this.Invalidate();;
        }
    }
}
