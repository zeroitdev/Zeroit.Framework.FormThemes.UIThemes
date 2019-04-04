// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Modern.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 84. Modern

        Color Modern_C1 = Color.FromArgb(240, 240, 240);
        Color Modern_C2 = Color.FromArgb(230, 230, 230);
        Color Modern_C3 = Color.FromArgb(190, 190, 190);
        private int _TitleHeight = 25;

        void Modern_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {
            using (Bitmap B = new Bitmap(Width, Height))
            {
                using (Graphics G = Graphics.FromImage(B))
                {
                    G.Clear(Color.FromArgb(245, 245, 245));

                    Utilities.Draw.Blend(G, Color.White, Modern_C2, Modern_C1, 0.7f, 1, 0, 0, Width, _TitleHeight);

                    G.FillRectangle(new SolidBrush(Color.FromArgb(80, 255, 255, 255)), 0, 0, Width, Convert.ToInt32(_TitleHeight / 2));
                    G.DrawRectangle(new Pen(Color.FromArgb(100, 255, 255, 255)), 1, 1, Width - 3, _TitleHeight - 2);

                    SizeF S = G.MeasureString(Text, Font);
                    float O = 6;
                    if (_TitleAlign == (HorizontalAlignment)2)
                        O = Width / 2 - S.Width / 2;
                    if (_TitleAlign == (HorizontalAlignment)1)
                        O = Width - S.Width - 6;
                    G.DrawString(Text, Font, new SolidBrush(Modern_C3), O, Convert.ToInt32(_TitleHeight / 2 - S.Height / 2));

                    G.DrawLine(new Pen(Modern_C3), 0, _TitleHeight, Width, _TitleHeight);
                    G.DrawLine(Pens.White, 0, _TitleHeight + 1, Width, _TitleHeight + 1);
                    G.DrawRectangle(new Pen(Modern_C3), 0, 0, Width - 1, Height - 1);

                    e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
                }
            }
        }



        #endregion
    }
}
