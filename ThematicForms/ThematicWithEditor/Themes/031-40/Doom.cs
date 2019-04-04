// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Doom.cs" company="Zeroit Dev Technologies">
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
        #region 36. Doom

        void Doom_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Black);
            G.SmoothingMode = SmoothingMode.HighQuality;
            //Form Border
            HatchBrush HB = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(33, 33, 33), Color.FromArgb(10, 10, 10));
            G.FillRectangle(HB, new Rectangle(0, 0, Width - 1, Height - 1));
            G.DrawRectangle(new Pen(Color.FromArgb(33, 33, 33)), 0, 0, Width - 1, Height - 1);
            //Form Interior
            G.FillRectangle(new SolidBrush(Color.FromArgb(30, 30, 30)), new Rectangle(6, 25, Width - 11, Height - 30));
            //Title Box
            HatchBrush HB3 = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(33, 33, 33), Color.FromArgb(22, 22, 22));
            Point[] p = {
                new Point(3, 15),
                new Point(20, 3),
                new Point(230, 3),
                new Point(230, 15),
                new Point(200, 35),
                new Point(3, 35)
            };
            G.FillPolygon(HB3, p);
            G.DrawPolygon(Pens.Black, p);
            //Icon and Form Title
            G.DrawString(Text, Font, new SolidBrush(ForeColor = Color.Red), new Point(40, 12));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(20, 12, 16, 16));
            //Draw Border
            DrawBorders(Pens.Black, 0);

        }

        #endregion
    }
}
