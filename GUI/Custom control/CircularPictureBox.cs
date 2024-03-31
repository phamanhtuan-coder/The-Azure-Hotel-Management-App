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
    /// <summary>
    /// Custom Picture box khung tròn
    /// </summary>
    public class CircularPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            using (var path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
                Region = new Region(path);
                pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pe.Graphics.DrawEllipse(new Pen(Color.Black, 1), 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
            }
        }
    }
}