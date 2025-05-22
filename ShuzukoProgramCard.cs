using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SCARA_ROBOT_SOFTWARE
{
    public class ProgramCard : UserControl
    {


        private Label lblTitle;
        private Label lblLine1;
        private Label lblLine2;
        private bool isSelected = false;

        public ProgramCard()
        {
            this.Size = new Size(250, 90);
            this.Margin = new Padding(8);
            this.Padding = new Padding(12);
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.DoubleBuffered = true;

            lblTitle = new Label()
            {
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Text = "Program",
                AutoSize = false,
                Height = 24,
                Dock = DockStyle.Top
            };

            lblLine1 = new Label()
            {
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                Text = "", // Không có "Tube:"
                AutoSize = false,
                Height = 20,
                Dock = DockStyle.Top
            };

            lblLine2 = new Label()
            {
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                Text = "", // Không có "Volume:"
                AutoSize = false,
                Height = 20,
                Dock = DockStyle.Top
            };

            // Thêm từ dưới lên để Dock Top đúng thứ tự hiển thị
            this.Controls.Add(lblLine2);
            this.Controls.Add(lblLine1);
            this.Controls.Add(lblTitle);

            this.Cursor = Cursors.Hand;
            this.Click += (s, e) => ToggleSelection();
            foreach (Control ctrl in this.Controls)
                ctrl.Click += (s, e) => ToggleSelection();
        }

        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        public string Line1
        {
            get => lblLine1.Text;
            set => lblLine1.Text = value;
        }

        public string Line2
        {
            get => lblLine2.Text;
            set => lblLine2.Text = value;
        }

        public void SetSelected(bool selected)
        {
            isSelected = selected;
            this.BackColor = selected ? Color.FromArgb(0, 122, 255) : Color.White;
            this.ForeColor = selected ? Color.White : Color.Black;

            // Cập nhật màu chữ
            foreach (Control ctrl in this.Controls)
                ctrl.ForeColor = this.ForeColor;

            Invalidate();
        }

        private void ToggleSelection()
        {
            SetSelected(!isSelected);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(1, 1, this.Width - 2, this.Height - 2);
            using (GraphicsPath path = GetRoundedRectangle(rect, 10))
            {
                this.Region = new Region(GetRoundedRectangle(this.ClientRectangle, 10));
                using (Pen pen = new Pen(isSelected ? Color.FromArgb(0, 90, 200) : Color.FromArgb(0, 122, 255), 2))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = radius * 2;
            RectangleF arc = new RectangleF(rect.X, rect.Y, diameter, diameter);

            // Top-left corner
            path.AddArc(arc, 180, 90);

            // Top-right corner
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Bottom-right corner
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Bottom-left corner
            arc.X = rect.X;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}
