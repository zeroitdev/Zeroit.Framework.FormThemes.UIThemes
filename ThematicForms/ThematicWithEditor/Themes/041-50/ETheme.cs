// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="ETheme.cs" company="Zeroit Dev Technologies">
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
        #region 46. ETheme

        void ETheme_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(53, 53, 53));
            DrawGradient(Color.FromArgb(50, 50, 50), Color.FromArgb(50, 50, 50), 0, 1, Width, 14, 90);
            DrawGradient(Color.FromArgb(29, 29, 29), Color.FromArgb(29, 29, 29), 2, 16, Width, 14, 90);
            G.DrawLine(Pens.Black, 0, 30, Width, 30);
            DrawBorders(Pens.Gray, Pens.Black, ClientRectangle);
            DrawText(HorizontalAlignment.Center, Color.Gray, 0);

        }

        #endregion
    }
}
