// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Booster.cs" company="Zeroit Dev Technologies">
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
        #region 17. Booster


        void Booster_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(51, 51, 51));
            DrawGradient(Color.FromArgb(29, 29, 29), Color.FromArgb(65, 65, 65), 0, 28, Width, (Height / 2) - 10);
            DrawGradient(Color.FromArgb(87, 87, 87), Color.FromArgb(49, 49, 49), 0, 0, Width, 25);
            G.DrawLine(Pens.Black, 0, 25, Width, 25);

            G.DrawLine(new Pen(Color.FromArgb(192, 74, 74)), 0, 26, Width, 26);
            G.FillRectangle(new SolidBrush(Color.FromArgb(169, 0, 0)), 0, 27, Width, 27);
            G.FillRectangle(new SolidBrush(Color.FromArgb(45, Color.White)), 0, 27, Width, 13);

            G.DrawLine(new Pen(Color.FromArgb(38, 38, 38)), 0, Height - 25, Width, Height - 25);
            G.DrawLine(new Pen(Color.FromArgb(64, 64, 64)), 0, Height - 24, Width, Height - 24);

            DrawBorders(Pens.Black);
            DrawBorders(new Pen(Color.FromArgb(92, 92, 92)), 1);

            DrawCorners(Color.Fuchsia);
            DrawText(Brushes.Black, HorizontalAlignment.Center, 0, 0);
            DrawText(Brushes.White, HorizontalAlignment.Center, 0, 1);
        }

        #endregion
    }
}
