// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Electric.cs" company="Zeroit Dev Technologies">
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
        #region 40. Electric
        Color BGColor = Color.FromArgb(22, 84, 107);
        Color Electric_G1 = Color.FromArgb(43, 136, 170);
        Color Electric_G2 = Color.FromArgb(29, 102, 129);
        Color Electric_F = Color.Fuchsia;
        Pen Seperator = new Pen(Color.FromArgb(7, 65, 86));

        Pen Electric_B = Pens.Black;
        void Electric_PaintHook(PaintEventArgs e)
        {
            G.Clear(BGColor);
            //Background

            DrawGradient(Electric_G1, Electric_G2, 0, 0, Width, 20, 90);
            //Menu Bar
            G.DrawLine(Seperator, 0, 20, Width, 20);
            //Menu bar seperator line

            G.DrawRectangle(Electric_B, ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width - 1, ClientRectangle.Height - 1);
            //Border
            DrawCorners(Electric_F, ClientRectangle);
            //Form corners

            DrawText(HorizontalAlignment.Left, ForeColor, 3);
            //Menu bar's text
        }

        #endregion
    }
}
