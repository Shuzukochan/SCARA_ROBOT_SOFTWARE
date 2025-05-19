using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace SCARA_ROBOT_SOFTWARE
{
    public class ShuzukoButton : Button
    {
        // Fields
        private int borderSize = 0;
        private int borderRadius = 20;
        private Color borderColor = Color.PaleVioletRed;
        private int textOffsetX = 0;
        private int textOffsetY = 0;
        private ContentAlignment textAlign = ContentAlignment.MiddleCenter;

        // Constructor
        public ShuzukoButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            UpdateFlatAppearanceColors();
            this.Resize += new EventHandler(Button_Resize);
            this.Text = "";
        }

        private void Button_Resize(object? sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            UpdateFlatAppearanceColors();
        }

        private void UpdateFlatAppearanceColors()
        {
            this.FlatAppearance.MouseOverBackColor = this.BackColor;
            this.FlatAppearance.MouseDownBackColor = this.BackColor;
        }

        // Properties for Text Offset
        [Category("Shuzuko Code Advance")]
        public int TextOffsetX
        {
            get { return textOffsetX; }
            set { textOffsetX = value; this.Invalidate(); }
        }

        [Category("Shuzuko Code Advance")]
        public int TextOffsetY
        {
            get { return textOffsetY; }
            set { textOffsetY = value; this.Invalidate(); }
        }

        [Category("Shuzuko Code Advance")]
        public override ContentAlignment TextAlign
        {
            get { return textAlign; }
            set { textAlign = value; this.Invalidate(); }
        }

        // Overridden OnPaint method
        protected override void OnPaint(PaintEventArgs pevent)
        {
            string originalText = this.Text;
            this.Text = "";

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            pevent.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            pevent.Graphics.Clear(this.Parent?.BackColor ?? Color.Transparent);

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = borderSize > 0 ? borderSize : 2;

            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent?.BackColor ?? Color.Transparent, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.FillPath(new SolidBrush(this.BackColor), pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                this.Region = new Region(rectSurface);
                pevent.Graphics.FillRectangle(new SolidBrush(this.BackColor), rectSurface);

                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }

            base.OnPaint(pevent);

            PointF textLocation;
            if (textOffsetX != 0 || textOffsetY != 0)
            {
                textLocation = new PointF(textOffsetX, textOffsetY);
            }
            else
            {
                var textSize = pevent.Graphics.MeasureString(originalText, this.Font);
                textLocation = GetTextLocation(rectSurface, textSize);
            }

            using (SolidBrush textBrush = new SolidBrush(this.ForeColor))
            {
                pevent.Graphics.DrawString(originalText, this.Font, textBrush, textLocation);
            }

            this.Text = originalText;
        }

        private PointF GetTextLocation(Rectangle rect, SizeF textSize)
        {
            float x = 0;
            float y = 0;

            switch (textAlign)
            {
                case ContentAlignment.TopLeft:
                    x = rect.Left;
                    y = rect.Top;
                    break;
                case ContentAlignment.TopCenter:
                    x = rect.Left + (rect.Width - textSize.Width) / 2;
                    y = rect.Top;
                    break;
                case ContentAlignment.TopRight:
                    x = rect.Right - textSize.Width;
                    y = rect.Top;
                    break;
                case ContentAlignment.MiddleLeft:
                    x = rect.Left;
                    y = rect.Top + (rect.Height - textSize.Height) / 2;
                    break;
                case ContentAlignment.MiddleCenter:
                    x = rect.Left + (rect.Width - textSize.Width) / 2;
                    y = rect.Top + (rect.Height - textSize.Height) / 2;
                    break;
                case ContentAlignment.MiddleRight:
                    x = rect.Right - textSize.Width;
                    y = rect.Top + (rect.Height - textSize.Height) / 2;
                    break;
                case ContentAlignment.BottomLeft:
                    x = rect.Left;
                    y = rect.Bottom - textSize.Height;
                    break;
                case ContentAlignment.BottomCenter:
                    x = rect.Left + (rect.Width - textSize.Width) / 2;
                    y = rect.Bottom - textSize.Height;
                    break;
                case ContentAlignment.BottomRight:
                    x = rect.Right - textSize.Width;
                    y = rect.Bottom - textSize.Height;
                    break;
            }

            return new PointF(x, y);
        }

        // Method to create rounded button
        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        // Other properties for border settings
        [Category("Shuzuko Code Advance")]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }

        [Category("Shuzuko Code Advance")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; this.Invalidate(); }
        }

        [Category("Shuzuko Code Advance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        [Category("Shuzuko Code Advance")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("Shuzuko Code Advance")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }
    }
}
