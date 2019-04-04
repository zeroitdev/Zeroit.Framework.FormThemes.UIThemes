// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="SimplyGray.cs" company="Zeroit Dev Technologies">
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
        #region 111. Simply Gray

        System.Drawing.Font SimplyGray_F = new System.Drawing.Font("Verdana", 8);
        SolidBrush SimplyGray_B = new SolidBrush(Color.DimGray);
        Color SimplyGray_Gr = Color.Gray;
        Color SimplyGray_LG = Color.LightGray;
        Color SimplyGray_Fc = Color.Fuchsia;

        public Pen _BorderColor1 = Pens.DarkGray;
        public Pen _BorderColor2 = Pens.Black;

        void SimplyGray_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Gray);
            DrawGradient(SimplyGray_LG, SimplyGray_Gr, 0, 0, Width, 20, 90);

            DrawBorders(_BorderColor2, _BorderColor1, ClientRectangle);
            DrawCorners(SimplyGray_Fc, ClientRectangle);

            DrawText(HorizontalAlignment.Left, ForeColor = Color.FromArgb(60, 60, 60), 3, 0);
            G.DrawString(_SubText, SimplyGray_F, SimplyGray_B, 4, 19);
        }

        #endregion
    }
}
