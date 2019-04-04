// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="White.cs" company="Zeroit Dev Technologies">
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
        #region 139. White
        Pen White_P1 = new Pen(Color.FromArgb(225, 225, 225));
        Pen White_P2 = new Pen(Color.FromArgb(150, 150, 150));
        Color White_c1 = Color.FromArgb(225, 225, 225);
        Color White_c2 = Color.FromArgb(185, 185, 185);

        Color White_tr;

        void White_PaintHook(PaintEventArgs e)
        {
            //Header = 20;
            G.Clear(Color.FromArgb(250, 250, 250));
            DrawBorders(White_P1, 1);

            DrawGradient(White_c1, White_c2, 0, 0, Width, 20);
            HatchBrush DarkDown = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.Transparent, Color.FromArgb(50, Color.FromArgb(75, 75, 75)));
            HatchBrush DarkUp = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.Transparent, Color.FromArgb(50, Color.FromArgb(75, 75, 75)));
            //G.FillRectangle(DarkDown, New Rectangle(0, 0, ClientRectangle.Width, Header))
            G.FillRectangle(DarkUp, new Rectangle(0, 0, ClientRectangle.Width, Header));


            DrawBorders(White_P2, 0);

            G.DrawLine(White_P2, 0, 20, Width, 20);
            G.DrawLine(White_P1, 0, 21, Width, 21);
            G.DrawLine(White_P1, 0, 22, Width, 22);
            G.DrawLine(White_P2, 0, 23, Width, 23);

            DrawText(Brushes.DarkBlue, HorizontalAlignment.Left, 5, 1);

            DrawCorners(TransparencyKey);
        }

        #endregion
    }
}
