// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Reactor.cs" company="Zeroit Dev Technologies">
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

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 102. Reactor

        void Reactor_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {


            LinearGradientBrush glossLGB = new LinearGradientBrush(new Rectangle(0, 0, Width, 15), Color.FromArgb(102, 97, 93), Color.FromArgb(55, 54, 52), 90);
            LinearGradientBrush glossLGB2 = new LinearGradientBrush(new Rectangle(0, 15, Width, 15), Color.Black, Color.FromArgb(26, 25, 21), 90);
            LinearGradientBrush shadowLGB = new LinearGradientBrush(new Rectangle(5, 31, Width - 11, 20), Color.FromArgb(23, 23, 22), Color.FromArgb(38, 38, 38), 90);

            G.Clear(Color.FromArgb(26, 25, 21));
            G.FillRectangle(glossLGB, new Rectangle(0, 0, Width, 15));
            G.FillRectangle(glossLGB2, new Rectangle(0, 15, Width, 15));
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(42, 41, 37))), 4, 30, Width - 9, Height - 36);
            G.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), new Rectangle(5, 31, Width - 11, Height - 38));
            G.FillRectangle(shadowLGB, new Rectangle(5, 31, Width - 11, 20));
            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(24, 24, 24))), 5, 32, Width - 7, 32);
            G.DrawRectangle(Pens.Black, new Rectangle(5, 31, Width - 11, Height - 38));
            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(151, 150, 146))), 1, 1, Width - 2, 1);

            G.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));

            //G.DrawString(Text, Font, Brushes.Black, Width / 2 - (3 * Text.Length) + 3, 7)
            //G.DrawString(Text, Font, Brushes.White, Width / 2 - (3 * Text.Length) + 3, 8)
            G.DrawString(Text, Font, Brushes.Black, new Rectangle(0, 10, Width - 1, 10), new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center
            });
            G.DrawString(Text, Font, Brushes.White, new Rectangle(0, 11, Width - 1, 11), new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center
            });
        }


        #endregion
    }
}
