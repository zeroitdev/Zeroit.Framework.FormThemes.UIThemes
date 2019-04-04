// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Origin.cs" company="Zeroit Dev Technologies">
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
        #region 94. Origin

        void Origin_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(39, 38, 38));
            // Dim HB As New HatchBrush(HatchStyle.Percent80, Color.FromArgb(45, Color.FromArgb(39, 38, 38)), Color.Transparent)
            G.FillRectangle(new SolidBrush(BackColor), new Rectangle(3, 26, Width - 6, Height - 29));
            //.FillRectangle(HB, New Rectangle(6, 26, Width - 12, Height - 33))
            G.DrawString(Parent.FindForm().Text, Font, Brushes.White, new Point(27, 3));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(10, 3, 16, 16));
            DrawCorners(Color.Transparent);
        }

        #endregion
    }
}
