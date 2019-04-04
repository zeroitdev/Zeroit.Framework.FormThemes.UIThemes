// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="PaladinV2.cs" company="Zeroit Dev Technologies">
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

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 95. PalaDinV2

        private Pen PalaDinV2_P1;

        void PalaDinV2_PaintHook(PaintEventArgs e)
        {
            PalaDinV2_P1 = new Pen(Color.FromArgb(230, 230, 230));
            G.Clear(Color.FromArgb(200, Color.Gainsboro));
            LinearGradientBrush HeaderLGB = new LinearGradientBrush(new Rectangle(0, 0, Width, 17), Color.FromArgb(230, 230, 230), Color.FromArgb(210, 210, 210), 90);
            G.FillRectangle(HeaderLGB, new Rectangle(0, 0, Width, 17));


            DrawGradient(Color.FromArgb(170, 170, 170), Color.FromArgb(230, 230, 230), 0, Height - 12, Width / 2, Height, 360);
            DrawGradient(Color.FromArgb(170, 170, 170), Color.FromArgb(230, 230, 230), Width / 2, Height - 12, Width / 2, Height, 180);

            G.DrawLine(new Pen(Color.FromArgb(230, 230, 230)), Width / 2, Height - 11, Width / 2, Height);


            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(140, 140, 140))), new Rectangle(8, 32, Width - 18, Height - 42));

            LinearGradientBrush RecLGB = new LinearGradientBrush(new Point(0, 0), new Point(0, Height), Color.FromArgb(180, 180, 180), Color.FromArgb(200, 200, 200));
            G.FillRectangle(RecLGB, new Rectangle(9, 33, Width - 19, Height - 43));

            G.DrawLine(new Pen(Color.White), 1, 2, Width, 2);
            G.DrawLine(new Pen(Color.FromArgb(150, 150, 150)), 8, 30, Width - 10, 30);

            DrawBorders(PalaDinV2_P1, 1);
            DrawBorders(new Pen(new SolidBrush(Color.FromArgb(90, 90, 90))), ClientRectangle);

            DrawCorners(Color.Fuchsia, ClientRectangle);

            DrawImage(HorizontalAlignment.Left, 6, -9);
            DrawText(new SolidBrush(Color.White), HorizontalAlignment.Left, 29, 0);
            DrawText(new SolidBrush(Color.Black), HorizontalAlignment.Left, 30, 0);


        }


        #endregion
    }
}
