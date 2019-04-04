﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Sasi.cs" company="Zeroit Dev Technologies">
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
        #region 107. Sasi

        void Sasi_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(168, 219, 4));
            HatchBrush HB = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(30, Color.White), Color.Transparent);

            G.FillRectangle(new SolidBrush(Color.FromArgb(239, 254, 213)), new Rectangle(6, 36, Width - 13, Height - 43));
            G.FillRectangle(HB, new Rectangle(0, 0, Width - 1, Height - 1));
            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(Color.FromArgb(49, 51, 48)), new Point(35, 10));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(10, 10, 16, 16));
            DrawCorners(Color.Fuchsia);
        }

        #endregion
    }
}
