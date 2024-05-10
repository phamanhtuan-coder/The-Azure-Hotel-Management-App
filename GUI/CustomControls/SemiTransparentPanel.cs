using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class SemiTransparentPanel : Panel
    {
        public SemiTransparentPanel()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            int diameter = radius * 2;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rect.Location, size);

            path.AddArc(arc, 180, 90);
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();

          
            int alphaValue = 70;
            Color semiTransparentColor = Color.FromArgb(alphaValue, this.BackColor);

            using (SolidBrush brush = new SolidBrush(semiTransparentColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            path.Dispose();
        }


        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Invalidate();
        }
    }
}
