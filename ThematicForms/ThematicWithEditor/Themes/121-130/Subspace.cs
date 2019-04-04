// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Subspace.cs" company="Zeroit Dev Technologies">
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
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 123. Subspace

        void Subspace_PaintHook(PaintEventArgs e)
        {
            //Body
            G.Clear(Color.FromArgb(30, 30, 30));
            G.FillRectangle(Brushes.Fuchsia, 0, 0, Width, 5);
            DrawBorders(Pens.Black, 0, 30, Width, Height);

            //HeaderShadow
            DrawGradient(Color.Black, Color.FromArgb(30, 30, 30), 1, 28, Width, 10);

            //BottomBody
            DrawGradient(Color.FromArgb(30, 30, 30), Color.Black, 0, Height - 23, Width, 10);
            DrawGradient(Color.FromArgb(0, 0, 0), Color.FromArgb(57, 57, 58), 0, Height - 12, Width / 2, Height, 360);
            DrawGradient(Color.FromArgb(0, 0, 0), Color.FromArgb(57, 57, 58), Width / 2, Height - 12, Width / 2, Height, 180);
            G.DrawLine(Pens.Black, 0, Height - 13, Width, Height - 13);
            G.DrawLine(new Pen(Color.FromArgb(57, 57, 58)), Width / 2, Height - 11, Width / 2, Height);


            //LeftSideBody
            G.FillRectangle(Brushes.Black, 0, 30, 8, Height);
            DrawBorders(Pens.Black, 1, 30, 9, Height - 2);
            G.DrawLine(new Pen(Color.FromArgb(40, 40, 40)), 8, 30, 8, Height);

            //RightSideBody
            G.FillRectangle(Brushes.Black, Width - 9, 30, 11, Height - 20);
            DrawBorders(Pens.Black, Width - 10, 30, 11, Height - 2);
            G.DrawLine(new Pen(Color.FromArgb(60, 60, 60)), Width - 9, 30, Width - 9, Height);



            //Header
            G.FillRectangle(Brushes.Black, 0, 5, Width, 24);
            DrawText(Brushes.DodgerBlue, HorizontalAlignment.Left, 55, 2);
            G.FillRectangle(new SolidBrush(Color.FromArgb(50, Color.White)), 0, 5, Width - 1, 11);
            DrawBorders(Pens.Black, 1, 4, Width - 2, 24);
            G.DrawLine(new Pen(Color.FromArgb(108, 108, 108)), 1, 5, Width, 5);
            G.DrawLine(new Pen(Color.FromArgb(60, 60, 60)), 1, 28, Width - 2, 28);
            G.DrawLine(Pens.Black, 1, 30, Width - 3, 30);

            //-----------------------------------------------------
            //Box
            DrawBorders(Pens.Black, 8, 0, 34, 32);
            DrawGradient(Color.FromArgb(57, 57, 58), Color.FromArgb(2, 4, 12), 9, 1, 32, 16);
            DrawGradient(Color.FromArgb(2, 4, 23), Color.FromArgb(57, 57, 58), 9, 15, 32, 16);
            //Lines
            DrawGradient(Color.FromArgb(100, 213, 255), Color.FromArgb(51, 162, 255), 17, 8, 3, 15);
            DrawGradient(Color.FromArgb(100, 213, 255), Color.FromArgb(51, 162, 255), Convert.ToInt32(47 / 2), (int)4.5, 3, (int)20.5);
            DrawGradient(Color.FromArgb(100, 213, 255), Color.FromArgb(51, 162, 255), 30, 8, 3, 15);

            DrawImage(HorizontalAlignment.Left, 9, 1);

            //Gloss
            G.FillRectangle(new SolidBrush(Color.FromArgb(15, Color.White)), 10, 2, 31, 13);
            //------------------------------------------------------

            //SideBoxes
            DrawGradient(Color.FromArgb(10, 10, 10), Color.FromArgb(47, 47, 47), 42, 2, 5, 15);
            DrawGradient(Color.FromArgb(47, 47, 47), Color.FromArgb(10, 10, 10), 42, 15, 5, 15);
            DrawGradient(Color.FromArgb(47, 47, 47), Color.FromArgb(10, 10, 10), 3, 2, 5, 15);
            DrawGradient(Color.FromArgb(10, 10, 10), Color.FromArgb(47, 47, 47), 3, 15, 5, 15);
            DrawBorders(Pens.Black, 42, 2, 5, 29);
            DrawBorders(Pens.Black, 3, 2, 5, 29);
            G.DrawLine(Pens.Black, 3, 15, 7, 15);
            G.DrawLine(Pens.Black, 42, 15, 46, 15);

            //Animation


            //Icon

            G.DrawLine(Pens.Black, 0, Height - 1, Width, Height - 1);
            DrawCorners(Color.Fuchsia);
        }

        #endregion
    }
}
