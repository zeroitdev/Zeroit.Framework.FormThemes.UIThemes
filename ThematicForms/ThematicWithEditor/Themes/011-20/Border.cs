// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Border.cs" company="Zeroit Dev Technologies">
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
        #region 19. Border


        void Border_PaintHook(PaintEventArgs e)
        {
            HatchBrush hb2 = new HatchBrush(HatchStyle.LightUpwardDiagonal, Color.FromArgb(35, 35, 35));
            G.Clear(Color.Fuchsia);
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(71, 71, 71))), new Rectangle(0, 0, Width - 1, Height - 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(5, 5, 5)), new Rectangle(0, 0, Width - 1, Height - 1));

            G.DrawString(Text, Font, Brushes.Black, new Point(10, 9));
            G.DrawString(Text, Font, Brushes.White, new Point(8, 6));

            //G.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));

            G.FillRectangle(new SolidBrush(Color.FromArgb(55, Color.White)), new Rectangle(0, 0, Width - 1, Height));
            G.FillRectangle(new SolidBrush(Color.FromArgb(5, Color.White)), new Rectangle(0, 0, Width - 1, 17));
            G.DrawRectangle(new Pen(new SolidBrush(Color.Black)), new Rectangle(11, 28, Width - 23, Height - 41));
            G.FillRectangle(new SolidBrush(Color.FromArgb(15, 15, 15)), new Rectangle(12, 29, Width - 24, Height - 42));

            DrawCorners(Color.Magenta);
        }

        #endregion
    }
}
