// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Patrick.cs" company="Zeroit Dev Technologies">
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
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 96. Patrick

        void Patrick_PaintHook(PaintEventArgs e)
        {
            HatchBrush hb2 = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(15, 15, 15));
            G.Clear(BackColor);
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(71, 71, 71))), new Rectangle(0, 0, Width, 20));
            G.FillRectangle(hb2, new Rectangle(0, 0, Width, 20));
            for (int i = 1; i <= 30; i++)
            {
                G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(Convert.ToInt32(255 / (i * 8)), Color.Black))), 0, 20 + i, Width, 20 + i);
            }
            HatchBrush hbi = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(15, 15, 15));
            G.FillRectangle(hbi, new Rectangle(0, 20, Width, 20));
            G.DrawString(Text, Font, Brushes.DarkGray, new Point(5, 5));
            Font SubFont = new Font(DefaultFont.FontFamily, Font.Size - 1);
            G.DrawString(Subtext, SubFont, new SolidBrush(Color.FromArgb(130, 130, 130)), new Point(8, 21));
            G.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));
            DrawCorners(Color.Magenta);
        }

        #endregion
    }
}
