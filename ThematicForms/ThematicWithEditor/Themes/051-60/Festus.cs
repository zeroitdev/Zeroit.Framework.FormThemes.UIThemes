// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Festus.cs" company="Zeroit Dev Technologies">
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
        #region 51. Festus

        private HorizontalAlignment _TitleAlign;

        private Pen Festus_P1;

        private Pen Festus_P2;

        void Festus_PaintHook(PaintEventArgs e)
        {
            MoveHeight = 25;
            Festus_P1 = new Pen(Color.FromArgb(220, 219, 219));
            Festus_P2 = new Pen(Color.FromArgb(225, 225, 225));
            Color Textcolor = Color.Black;

            G.Clear(Color.White);

            G.FillRectangle(new SolidBrush(Color.FromArgb(224, 224, 224)), 14, MoveHeight, Width - 30, Height - MoveHeight - 10);
            DrawGradient(Color.FromArgb(220, 220, 220), Color.White, 0, -12, Width, MoveHeight, 90);


            if (_TitleAlign == HorizontalAlignment.Center)
            {
                DrawText(HorizontalAlignment.Center, ForeColor, 5);
            }
            else if (_TitleAlign == HorizontalAlignment.Left)
            {
                DrawText(HorizontalAlignment.Left, ForeColor, 5);
            }
            else if (_TitleAlign == HorizontalAlignment.Right)
            {
                DrawText(HorizontalAlignment.Right, ForeColor, 5);
            }

            DrawBorders(Festus_P2, Festus_P1, ClientRectangle);
            DrawCorners(Color.Fuchsia, ClientRectangle);
        }

        #endregion
    }
}
