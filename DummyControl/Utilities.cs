using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Drawing.Text;

namespace Zeroit.Framework.FormEditors.UIThemes.ControlEditor
{
    static class Draw
    {
        private static int ArcRectangleWidth;
        private static int UpperLeftCorner;
        private static int UpperRightCorner;
        private static int DownLeftCorner;
        private static int DownRightCorner;
        

        private static int curve = 3;

        public static GraphicsPath RoundRect(Rectangle Rectangle, int Curve, int UpperLeftCurve, int UpperRightCurve, int DownLeftCurve, int DownRightCurve)
        {
            //Curve = curve;
            GraphicsPath P = new GraphicsPath();
            ArcRectangleWidth = Curve * 2;

            UpperLeftCorner = UpperLeftCurve * 2;
            UpperRightCorner = UpperRightCurve * 2;
            DownLeftCorner = DownLeftCurve * 2;
            DownRightCorner = DownRightCurve * 2;

            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, UpperLeftCorner, UpperLeftCorner), -180, 90);
            P.AddArc(new Rectangle(Rectangle.Width - UpperRightCorner + Rectangle.X, Rectangle.Y, UpperRightCorner, UpperRightCorner), -90, 90);
            P.AddArc(new Rectangle(Rectangle.Width - DownRightCorner + Rectangle.X, Rectangle.Height - DownRightCorner + Rectangle.Y, DownRightCorner, DownRightCorner), 0, 90);
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Height - DownLeftCorner + Rectangle.Y, DownLeftCorner, DownLeftCorner), 90, 90);
            //P.AddLine(new Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), new Point(Rectangle.X, Curve + Rectangle.Y));

            //P.AddLine(new Point(Rectangle.X, Rectangle.Height - UpperLeftCorner + Rectangle.Y), new Point(Rectangle.X, UpperLeftCorner + Rectangle.Y));

            P.CloseAllFigures();
            return P;
        }
        
        public static GraphicsPath RoundRect(Rectangle Rectangle, int Curve)
        {
            //Curve = curve;
            GraphicsPath P = new GraphicsPath();
            ArcRectangleWidth = Curve * 2;
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90);
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90);
            P.AddLine(new Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), new Point(Rectangle.X, Curve + Rectangle.Y));
            return P;
        }

        public static GraphicsPath RoundRect(int X, int Y, int Width, int Height, int Curve)
        {
            //Curve = curve;
            Rectangle Rectangle = new Rectangle(X, Y, Width, Height);
            GraphicsPath P = new GraphicsPath();
            ArcRectangleWidth = Curve * 2;
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90);
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90);
            P.AddLine(new Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), new Point(Rectangle.X, Curve + Rectangle.Y));
            return P;
        }
        
        public static GraphicsPath RoundRect(RectangleF r, float r1, float r2, float r3, float r4)
        {
            float x = r.X;
            float y = r.Y;
            float w = r.Width;
            float h = r.Height;
            GraphicsPath rr5 = new GraphicsPath();
            rr5.AddBezier(x, y + r1, x, y, x + r1, y, x + r1, y);
            rr5.AddLine(x + r1, y, x + w - r2, y);
            rr5.AddBezier(x + w - r2, y, x + w, y, x + w, y + r2, x + w, y + r2);
            rr5.AddLine(x + w, y + r2, x + w, y + h - r3);
            rr5.AddBezier(x + w, y + h - r3, x + w, y + h, x + w - r3, y + h, x + w - r3, y + h);
            rr5.AddLine(x + w - r3, y + h, x + r4, y + h);
            rr5.AddBezier(x + r4, y + h, x, y + h, x, y + h - r4, x, y + h - r4);
            rr5.AddLine(x, y + h - r4, x, y + r1);
            return rr5;
        }

        public static GraphicsPath RoundRect(float X_cord, float Y_cord, float Width, float Height, float r1, float r2, float r3, float r4)
        {
            float x = X_cord;
            float y = X_cord;
            float w = Width;
            float h = Height;
            GraphicsPath rr5 = new GraphicsPath();
            rr5.AddBezier(x, y + r1, x, y, x + r1, y, x + r1, y);
            rr5.AddLine(x + r1, y, x + w - r2, y);
            rr5.AddBezier(x + w - r2, y, x + w, y, x + w, y + r2, x + w, y + r2);
            rr5.AddLine(x + w, y + r2, x + w, y + h - r3);
            rr5.AddBezier(x + w, y + h - r3, x + w, y + h, x + w - r3, y + h, x + w - r3, y + h);
            rr5.AddLine(x + w - r3, y + h, x + r4, y + h);
            rr5.AddBezier(x + r4, y + h, x, y + h, x, y + h - r4, x, y + h - r4);
            rr5.AddLine(x, y + h - r4, x, y + r1);
            return rr5;
        }

        /// <summary>
        /// Return an array of 10 points to be used in a Draw- or FillPolygon method
        /// </summary>
        /// <param name="Orig"> The origin is the middle of the star.</param>
        /// <param name="outerradius">Radius of the surrounding circle.</param>
        /// <param name="innerradius">Radius of the circle for the "inner" points</param>
        /// <returns>Array of 10 PointF structures</returns>
        public static Point[] CalculateVertices(int sides, int radius, int startingAngle, Point center)
        {

            
            if (sides < 3)
                throw new ArgumentException("Polygon must have 3 sides or more.");

            List<Point> points = new List<Point>();
            float step = 360.0f / sides;

            float angle = startingAngle; //starting angle
            for (double i = startingAngle; i < startingAngle + 360.0; i += step) //go in a circle
            {
                points.Add(DegreesToXY(angle, radius, center));
                angle += step;
            }

            return points.ToArray();
        }

        public static Point DegreesToXY(float degrees, float radius, Point origin)
        {
            Point xy = new Point();
            double radians = degrees * Math.PI / 180.0;

            xy.X = (int)(Math.Cos(radians) * radius + origin.X);
            xy.Y = (int)(Math.Sin(-radians) * radius + origin.Y);

            return xy;
        }


        /// <summary>
        ///     Position form so that it is centered beneath a control, adjusted to that it 
        ///		is entirely on the screen if possible.
        /// </summary>
        /// <param name="f">Form to position.</param>
        /// <param name="c">Control under which to position the form.</param>
        public static void SetStartPositionBelowControl(System.Windows.Forms.Form f, Control c)
        {
            // Get location so that f is on screen just below the center of c
            Point middleBottom = c.PointToScreen(new Point(c.Size.Width / 2, c.Size.Height));
            SetStartPosition(f, middleBottom);
        }

        /// <summary>
        ///     Position form such that the center of the top edge is at a particular point,
        ///		adjusted so that it is entirely on the screen if possible.
        /// </summary>
        /// <param name="f">Form to position.</param>
        /// <param name="p">Point at which to center the top edge of the form.</param>
        public static void SetStartPosition(System.Windows.Forms.Form f, Point p)
        {
            Screen screen = Screen.FromPoint(p);

            int left = p.X - f.Width / 2;
            int right = left + f.Width;
            int top = p.Y;
            int bottom = p.Y + f.Height;

            // Adjust right then left, so that left edge is always on screen.
            if (right > screen.WorkingArea.Right)
            {
                left -= (right - screen.WorkingArea.Right - 1);
            }
            if (left < screen.WorkingArea.Left)
            {
                left = screen.WorkingArea.Left;
            }

            // Adjust bottom then top, so that top edge is always on screen
            if (bottom > screen.WorkingArea.Bottom)
            {
                top -= (bottom - screen.WorkingArea.Bottom - 1);
            }
            if (top < screen.WorkingArea.Top)
            {
                top = screen.WorkingArea.Top;
            }

            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(left, top);
        }

    }


}
