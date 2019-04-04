// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="JTheme.cs" company="Zeroit Dev Technologies">
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
        #region 75. JTheme
        Color Color1 = Color.FromArgb(20, 20, 20);
        Brush Color2 = new SolidBrush(Color.FromArgb(50, 50, 50));
        Color Color3 = Color.FromArgb(50, 50, 50);
        Brush Color4 = new SolidBrush(Color.White);
        void JTheme_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color1);
            Rectangle rect = new Rectangle(10, 20, Width - 20, Height - 30);
            G.FillRectangle(Color2, rect);
            DrawBorders(Pens.Black, rect);
            DrawBorders(Pens.Black);
            DrawCorners(Color3);
            DrawText(Color4, HorizontalAlignment.Center, 0, 0);


        }

        #endregion
    }
}
