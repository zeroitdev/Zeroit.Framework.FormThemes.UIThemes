﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="clsNeoBux.cs" company="Zeroit Dev Technologies">
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
        #region 26. clsNeoBux


        void clsNeoBux_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Gray);

            //MenuTop
            G.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 242)), new Rectangle(1, 1, Width - 2, Height - 2));

            //Border
            G.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle(1, 35, Width - 2, Height - 38));

            //MainForm
            G.FillRectangle(new SolidBrush(Color.WhiteSmoke), new Rectangle(1, 36, Width - 2, Height - 39));


            //ColorLine
            LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(1, 36, Width - 2, Height - 255), Color.FromArgb(0, 177, 253), Color.FromArgb(46, 202, 56), 180f);
            G.DrawRectangle(new Pen(Color.LightGray), 1, 35, Width - 3, 4);
            G.FillRectangle(LGB, new Rectangle(1, 35, Width - 2, 4));

            //MenuItems
            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(ForeColor), new Point(35, 10));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(10, 10, 16, 16));
            DrawCorners(Color.Fuchsia);

        }

        #endregion
    }
}
