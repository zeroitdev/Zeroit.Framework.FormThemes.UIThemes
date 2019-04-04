// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="VTheme.cs" company="Zeroit Dev Technologies">
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
        #region 135. VTheme

        void VTheme_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(12, 12, 12));
            Pen P = new Pen(Color.FromArgb(32, 32, 32));
            G.DrawLine(P, 11, 31, Width - 12, 31);
            G.DrawLine(P, 11, 8, Width - 12, 8);
            G.FillRectangle(new LinearGradientBrush(new Rectangle(8, 38, Width - 16, Height - 46), Color.FromArgb(12, 12, 12), Color.FromArgb(18, 18, 18), LinearGradientMode.BackwardDiagonal), 8, 38, Width - 16, Height - 46);
            DrawText(Brushes.White, HorizontalAlignment.Left, 25, 6);
            DrawBorders(new Pen(Color.FromArgb(60, 60, 60)), 1);
            DrawBorders(Pens.Black);

            P = new Pen(Color.FromArgb(25, 25, 25));
            G.DrawLine(Pens.Black, 6, 0, 6, Height - 6);
            G.DrawLine(Pens.Black, Width - 6, 0, Width - 6, Height - 6);
            G.DrawLine(P, 6, 0, 6, Height - 6);
            G.DrawLine(P, Width - 8, 0, Width - 8, Height - 6);

            G.DrawRectangle(Pens.Black, 11, 4, Width - 23, 22);
            G.DrawLine(P, 6, Height - 6, Width - 8, Height - 6);
            G.DrawLine(Pens.Black, 6, Height - 8, Width - 8, Height - 8);
            DrawCorners(Color.Fuchsia);
        }

        #endregion
    }
}
