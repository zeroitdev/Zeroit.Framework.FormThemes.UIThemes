﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Utilities.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Form control with themes.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes.ThematicForms.FormEditors.Utilities
{
    /// <summary>
    /// Class Draw.
    /// </summary>
    static class Draw
    {
        /// <summary>
        /// The arc rectangle width
        /// </summary>
        private static int ArcRectangleWidth;
        /// <summary>
        /// The upper left corner
        /// </summary>
        private static int UpperLeftCorner;
        /// <summary>
        /// The upper right corner
        /// </summary>
        private static int UpperRightCorner;
        /// <summary>
        /// Down left corner
        /// </summary>
        private static int DownLeftCorner;
        /// <summary>
        /// Down right corner
        /// </summary>
        private static int DownRightCorner;


        /// <summary>
        /// The curve
        /// </summary>
        private static int curve = 3;

        /// <summary>
        /// Rounds the rect.
        /// </summary>
        /// <param name="Rectangle">The rectangle.</param>
        /// <param name="Curve">The curve.</param>
        /// <param name="UpperLeftCurve">The upper left curve.</param>
        /// <param name="UpperRightCurve">The upper right curve.</param>
        /// <param name="DownLeftCurve">Down left curve.</param>
        /// <param name="DownRightCurve">Down right curve.</param>
        /// <returns>GraphicsPath.</returns>
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

        /// <summary>
        /// Rounds the rect.
        /// </summary>
        /// <param name="Rectangle">The rectangle.</param>
        /// <param name="Curve">The curve.</param>
        /// <returns>GraphicsPath.</returns>
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

        /// <summary>
        /// Rounds the rect.
        /// </summary>
        /// <param name="X">The x.</param>
        /// <param name="Y">The y.</param>
        /// <param name="Width">The width.</param>
        /// <param name="Height">The height.</param>
        /// <param name="Curve">The curve.</param>
        /// <returns>GraphicsPath.</returns>
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

        /// <summary>
        /// Rounds the rect.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="r1">The r1.</param>
        /// <param name="r2">The r2.</param>
        /// <param name="r3">The r3.</param>
        /// <param name="r4">The r4.</param>
        /// <returns>GraphicsPath.</returns>
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

        /// <summary>
        /// Rounds the rect.
        /// </summary>
        /// <param name="X_cord">The x cord.</param>
        /// <param name="Y_cord">The y cord.</param>
        /// <param name="Width">The width.</param>
        /// <param name="Height">The height.</param>
        /// <param name="r1">The r1.</param>
        /// <param name="r2">The r2.</param>
        /// <param name="r3">The r3.</param>
        /// <param name="r4">The r4.</param>
        /// <returns>GraphicsPath.</returns>
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
        /// <param name="sides">The sides.</param>
        /// <param name="radius">The radius.</param>
        /// <param name="startingAngle">The starting angle.</param>
        /// <param name="center">The center.</param>
        /// <returns>Array of 10 PointF structures</returns>
        /// <exception cref="ArgumentException">Polygon must have 3 sides or more.</exception>
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

        /// <summary>
        /// Degreeses to xy.
        /// </summary>
        /// <param name="degrees">The degrees.</param>
        /// <param name="radius">The radius.</param>
        /// <param name="origin">The origin.</param>
        /// <returns>Point.</returns>
        public static Point DegreesToXY(float degrees, float radius, Point origin)
        {
            Point xy = new Point();
            double radians = degrees * Math.PI / 180.0;

            xy.X = (int)(Math.Cos(radians) * radius + origin.X);
            xy.Y = (int)(Math.Sin(-radians) * radius + origin.Y);

            return xy;
        }


        /// <summary>
        /// Position form so that it is centered beneath a control, adjusted to that it
        /// is entirely on the screen if possible.
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
        /// Position form such that the center of the top edge is at a particular point,
        /// adjusted so that it is entirely on the screen if possible.
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
