// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Simplistic.cs" company="Zeroit Dev Technologies">
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
        #region 112. Simplistic

        void Simplistic_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.SteelBlue);

            DrawGradient(Color.DodgerBlue, Color.SteelBlue, 0, 0, Width, 24, 180);
            G.DrawLine(Pens.Black, 0, 24, Width, 24);

            DrawText(HorizontalAlignment.Left, Color.Black, 4);
            DrawBorders(Pens.Black, Pens.LightGray, ClientRectangle);
            DrawCorners(Color.Fuchsia, ClientRectangle);
        }

        #endregion
    }
}
