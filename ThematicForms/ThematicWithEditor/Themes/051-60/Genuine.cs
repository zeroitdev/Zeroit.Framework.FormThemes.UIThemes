// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Genuine.cs" company="Zeroit Dev Technologies">
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
        #region 59. Genuine

        private Color Genuine_C1 = Color.FromArgb(41, 41, 41);
        private Color Genuine_C2 = Color.FromArgb(25, 25, 25);
        private Color Genuine_C3 = Color.FromArgb(41, 41, 41);
        private SolidBrush Genuine_B1 = new SolidBrush(Color.FromArgb(255, 255, 255));

        private Pen Genuine_P1 = new Pen(Color.FromArgb(25, 25, 25));
        private Pen Genuine_P2 = new Pen(Color.FromArgb(58, 58, 58));
        private Pen Genuine_P3 = new Pen(Color.FromArgb(58, 58, 58));

        private Pen Genuine_P4 = new Pen(Color.FromArgb(0, 0, 0));



        void Genuine_PaintHook(PaintEventArgs e)
        {
            G.Clear(Genuine_C1);

            DrawGradient(Genuine_C2, Genuine_C3, 0, 0, Width, 28);

            G.DrawLine(Genuine_P1, 0, 28, Width, 28);
            G.DrawLine(Genuine_P2, 0, 29, Width, 29);

            DrawText(Genuine_B1, HorizontalAlignment.Left, 7, 0);

            DrawBorders(Genuine_P3, 1);
            DrawBorders(Genuine_P4);

            DrawCorners(TransparencyKey);
        }

        #endregion
    }
}
