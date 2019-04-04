// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Metal.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 81. Metal
        private Pen Metal_P1;

        private Pen Metal_P2;

        void Metal_PaintHook(PaintEventArgs e)
        {
            MoveHeight = 25;
            Metal_P1 = new Pen(Color.FromArgb(45, 45, 45));
            Metal_P2 = new Pen(Color.FromArgb(90, 90, 90));
            Color Textcolor = Color.White;

            G.Clear(Color.FromArgb(41, 41, 41));
            G.FillRectangle(new SolidBrush(Color.FromArgb(63, 63, 63)), 14, MoveHeight, Width - 30, Height - MoveHeight - 12);
            DrawGradient(Color.FromArgb(100, 100, 100), Color.FromArgb(41, 41, 41), 0, -12, Width, MoveHeight, 90);

            if (_TitleAlign == HorizontalAlignment.Center)
            {
                DrawText(HorizontalAlignment.Center, Textcolor, 5);
            }
            else if (_TitleAlign == HorizontalAlignment.Left)
            {
                DrawText(HorizontalAlignment.Left, Textcolor, 5);
            }
            else if (_TitleAlign == HorizontalAlignment.Right)
            {
                DrawText(HorizontalAlignment.Right, Textcolor, 5);
            }

            DrawBorders(Metal_P2, Metal_P1, ClientRectangle);
            DrawCorners(Color.Fuchsia, ClientRectangle);
        }


        #endregion
    }
}
