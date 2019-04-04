// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Prime.cs" company="Zeroit Dev Technologies">
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
        #region 99. Prime

        private Color Prime_C1 = Color.FromArgb(232, 232, 232);
        private Color Prime_C2 = Color.FromArgb(252, 252, 252);
        private Color Prime_C3 = Color.FromArgb(242, 242, 242);
        private SolidBrush Prime_B1 = new SolidBrush(Color.FromArgb(255, 255, 255));
        private SolidBrush Prime_B2 = new SolidBrush(Color.FromArgb(80, 80, 80));
        private SolidBrush Prime_B3 = new SolidBrush(Color.FromArgb(255, 255, 255));
        private Pen Prime_P1 = new Pen(Color.FromArgb(180, 180, 180));
        private Pen Prime_P2 = new Pen(Color.FromArgb(255, 255, 255));
        private Pen Prime_P3 = new Pen(Color.FromArgb(255, 255, 255));
        private Pen Prime_P4 = new Pen(Color.FromArgb(150, 150, 150));

        private Rectangle Prime_RT1;

        void Prime_PaintHook(PaintEventArgs e)
        {
            G.Clear(Prime_C1);

            DrawGradient(Prime_C2, Prime_C3, 0, 0, Width, 15);

            DrawText(Prime_B1, HorizontalAlignment.Left, 13, 1);
            DrawText(Prime_B2, HorizontalAlignment.Left, 12, 0);

            Prime_RT1 = new Rectangle(12, 30, Width - 24, Height - 42);

            G.FillRectangle(Prime_B3, Prime_RT1);
            DrawBorders(Prime_P1, Prime_RT1, 1);
            DrawBorders(Prime_P2, Prime_RT1);

            DrawBorders(Prime_P3, 1);
            DrawBorders(Prime_P4);

            DrawCorners(TransparencyKey);
        }

        #endregion
    }
}
