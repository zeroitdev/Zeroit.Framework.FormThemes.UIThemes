using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Zeroit.Framework.Button
{
    [ToolboxItem(false)]
    public class BezierShapeControl : Control
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //PictureBox picBox = new PictureBox();
            //picBox.Size = this.Size;
            //picBox.Location = this.Location;
            //Parent.Controls.Add(picBox);

            //Bitmap DrawArea = new Bitmap(picBox.Width, picBox.Height);
            //Graphics g = Graphics.FromImage(DrawArea);
            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;

            Pen b1 = new Pen(Color.Black);
            Pen red = new Pen(Color.Red);

            Point p1 = new Point(25, 25);
            Point p2 = new Point(300, 25);
            Point p3 = new Point(25, 300);
            Point p4 = new Point(300, 300);

            List<Point> p = new List<Point> {p1, p2, p3, p4};
            g.DrawBezier(red, p1, p2, p3, p4);

            foreach (Point point in p)
            {
                g.DrawRectangle(b1, point.X - 1, point.Y - 1, 2, 2);
            }

            

        }
    }
}
