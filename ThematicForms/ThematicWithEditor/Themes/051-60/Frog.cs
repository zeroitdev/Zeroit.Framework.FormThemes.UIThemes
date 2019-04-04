// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Frog.cs" company="Zeroit Dev Technologies">
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
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Point = System.Drawing.Point;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 54. Frog

        void Frog_PaintHook(PaintEventArgs e)
        {
            G.SmoothingMode = SmoothingMode.AntiAlias;

            int BarHeight = 20;

            Point[] Polygon = null;
            Point[] Polygon2 = null;

            System.Drawing.Color Color2 = default(System.Drawing.Color);
            System.Drawing.Color Color = default(System.Drawing.Color);
            System.Drawing.Color DOES = default(System.Drawing.Color);
            System.Drawing.Color Border = default(System.Drawing.Color);

            Border = System.Drawing.Color.FromArgb(160, 200, 200, 200);

            Polygon = new Point[] {
                new Point(50, 2),
                new Point(Width - 51, 2),
                new Point(Width - 56, 18),
                new Point(55, 18)
            };
            Polygon2 = new Point[] {
                new Point((int)51.5, 3),
                new Point(Width - 52, 3),
                new Point(Width - 57, 17),
                new Point(56, 17)
            };

            DOES = System.Drawing.Color.FromArgb(255, 60, 60, 60);
            Color = System.Drawing.Color.FromArgb(255, 90, 90, 90);
            Color2 = System.Drawing.Color.FromArgb(255, 100, 100, 100);

            LinearGradientBrush LGB = new LinearGradientBrush(new Point(0, 0), new Point(0, BarHeight), Color2, DOES);

            G.FillRectangle(new SolidBrush(DOES), new Rectangle(0, 0, Width, Height));
            G.FillRectangle(LGB, new Rectangle(0, 0, Width, BarHeight));
            G.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));
            G.FillPolygon(new SolidBrush(DOES), Polygon);
            G.DrawPolygon(Pens.Black, Polygon);
            G.DrawPolygon(new Pen(Border), Polygon2);
            G.DrawRectangle(Pens.Black, new Rectangle(3, 20, Width - 7, Height - 24));
            G.DrawRectangle(new Pen(Border), new Rectangle(4, 21, Width - 9, Height - 26));
            Font TextFont = default(Font);
            TextFont = new Font("Verdana", 8);
            //G.DrawString(Text, TextFont, Brushes.Black, New Point((Width / 2) - (G.MeasureString(Text, TextFont).Width / 2), 3))
            G.DrawString(Text, TextFont, new SolidBrush(Color.FromArgb(255, 200, 200, 200)), new Point((int)(Width / 2) - (int)(G.MeasureString(Text, TextFont).Width / 2) + 1, 4));
        }

        #endregion
    }
}
