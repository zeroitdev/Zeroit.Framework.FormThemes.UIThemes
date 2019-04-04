// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Future.cs" company="Zeroit Dev Technologies">
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
        #region 56. Future
        private Color Future_C1 = Color.FromArgb(34, 34, 34);
        private Color Future_C2 = Color.FromArgb(34, 34, 34);
        private Color Future_C3 = Color.FromArgb(23, 23, 23);
        private Color Future_C4 = Color.FromArgb(70, Color.Black);
        private Color Future_C5 = Color.FromArgb(255, Color.Transparent);
        private Pen Future_P1 = new Pen(Color.FromArgb(34, 34, 34));
        private Pen Future_P2 = new Pen(Color.FromArgb(255, Color.Black));
        private Pen Future_P3 = new Pen(Color.FromArgb(255, Color.Black));
        private Pen Future_P4 = new Pen(Color.FromArgb(49, 49, 49));
        private Pen Future_P5 = new Pen(Color.FromArgb(255, Color.Black));
        private HatchBrush Future_B1;

        private SolidBrush Future_B2;

        private Rectangle Future_RT1;
        void Future_PaintHook(PaintEventArgs e)
        {

            G.Clear(Future_C1);

            Future_B1 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.Black, Color.FromArgb(34, 34, 34));
            Future_B2 = new SolidBrush(ForeColor);
            Future_RT1 = new Rectangle(1, 1, Width - 2, 22);
            DrawGradient(Future_C2, Future_C3, Future_RT1, 90f);
            DrawBorders(Future_P1, Future_RT1);

            G.DrawLine(Future_P2, 0, 23, Width, 23);

            G.FillRectangle(Future_B1, 0, 24, Width, 13);

            DrawGradient(Future_C4, Future_C5, 0, 24, Width, 6);

            G.DrawLine(Future_P3, 0, 37, Width, 37);
            DrawBorders(Future_P4, 1, 38, Width - 2, Height - 39);

            DrawText(Future_B2, HorizontalAlignment.Left, 5, 0);

            DrawBorders(Future_P5);
        }

        #endregion
    }
}
