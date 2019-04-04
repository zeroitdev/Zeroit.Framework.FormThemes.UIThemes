// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Evolve.cs" company="Zeroit Dev Technologies">
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
        #region 47. Evolve

        void Evolve_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(47, 47, 47));
            DrawBorders(new Pen(Color.FromArgb(104, 104, 104)), 1);
            ColorBlend cblend = new ColorBlend(2);
            cblend.Colors[0] = Color.FromArgb(66, 66, 66);
            cblend.Colors[1] = Color.FromArgb(50, 50, 50);
            cblend.Positions[0] = 0;
            cblend.Positions[1] = 1;
            DrawGradient(cblend, new Rectangle(new Point(2, 2), new Size(this.Width - 4, 22)));
            G.DrawLine(new Pen(Color.FromArgb(30, 30, 30)), new Point(2, 24), new Point(this.Width - 3, 24));
            G.DrawLine(new Pen(Color.FromArgb(70, 70, 70)), new Point(2, 25), new Point(this.Width - 3, 25));
            DrawBorders(Pens.Black);
            DrawCorners(Color.Fuchsia);
            G.DrawIcon(this.ParentForm.Icon, new Rectangle(new Point(8, 5), new Size(16, 16)));
            G.DrawString(this.ParentForm.Text, Font, Brushes.White, new Point(28, 4));
        }

        #endregion
    }
}
