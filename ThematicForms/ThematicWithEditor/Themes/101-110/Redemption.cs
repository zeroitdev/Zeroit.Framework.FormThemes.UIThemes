// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Redemption.cs" company="Zeroit Dev Technologies">
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
using System.Drawing.Text;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 105. Redemption

        void Redemption_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);

            G.SmoothingMode = SmoothingMode.HighQuality;
            G.TextRenderingHint = TextRenderingHint.AntiAlias;

            //G.FillRectangle(MatteNoise, ClientRectangle)
            G.FillRectangle(new SolidBrush(Color.FromArgb(25, Color.White)), new Rectangle(0, 0, Width - 1, 28));
            G.FillRectangle(new SolidBrush(Color.FromArgb(25, Color.White)), new Rectangle(0, 28, 6, Height - 35));
            G.FillRectangle(new SolidBrush(Color.FromArgb(25, Color.White)), new Rectangle(Width - 7, 28, 7, Height - 35));
            G.FillRectangle(new SolidBrush(Color.FromArgb(25, Color.White)), new Rectangle(0, Height - 7, Width - 1, 7));
            G.FillRectangle(new SolidBrush(Color.FromArgb(15, Color.White)), new Rectangle(6, 28, Width - 13, Height - 35));
            G.DrawLine(new Pen(Color.FromArgb(44, 45, 48)), new Point(6, 29), new Point(Width - 7, 29));
            G.DrawLine(new Pen(Color.FromArgb(37, 38, 40)), new Point(6, 30), new Point(Width - 7, 30));
            G.DrawLine(new Pen(Color.FromArgb(75, 60, 61, 62)), new Point(6, 31), new Point(Width - 7, 31));
            G.DrawLine(new Pen(Color.FromArgb(56, 57, 60)), new Point(5, 31), new Point(5, Height - 7));
            G.DrawLine(new Pen(Color.FromArgb(77, 78, 79)), new Point(6, 31), new Point(6, Height - 7));
            G.DrawLine(new Pen(Color.FromArgb(56, 57, 60)), new Point(Width - 7, 31), new Point(Width - 7, Height - 7));
            G.DrawLine(new Pen(Color.FromArgb(77, 78, 79)), new Point(Width - 8, 31), new Point(Width - 8, Height - 7));
            G.DrawLine(new Pen(Color.FromArgb(63, 64, 65)), new Point(6, Height - 8), new Point(Width - 7, Height - 8));
            G.DrawLine(new Pen(Color.FromArgb(63, 63, 63)), new Point(5, Height - 7), new Point(Width - 6, Height - 7));
            G.DrawLine(new Pen(Color.FromArgb(85, 86, 88)), new Point(0, 1), new Point(Width - 1, 1));
            G.DrawRectangle(new Pen(Color.FromArgb(21, 23, 25)), ClientRectangle);

            Color[] ColorList = {
                Color.FromArgb(200, 34, 36, 39),
                Color.FromArgb(200, 5, 185, 238),
                Color.FromArgb(200, 34, 36, 39)
            };
            float[] PointList = {
                0 / 2,
                1 / 2,
                2 / 2
            };
            LinearGradientBrush AccentBrush = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.Black, Color.White, 90);
            ColorBlend AccentBlend = new ColorBlend
            {
                Colors = ColorList,
                Positions = PointList
            };
            AccentBrush.InterpolationColors = AccentBlend;
            G.DrawRectangle(new Pen(AccentBrush), new Rectangle(0, 0, Width - 1, Height - 1));

            StringFormat TextFormat = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            };
            G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(200, Color.Black)), new Rectangle(8, 1, Width - 1, 28), TextFormat);
            G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(8, 2, Width - 1, 28), TextFormat);


            e.Graphics.DrawImage(B, new Point(0, 0));
            G.Dispose();
            B.Dispose();
        }


        #endregion
    }
}
