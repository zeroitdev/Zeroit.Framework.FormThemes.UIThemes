﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Tennis.cs" company="Zeroit Dev Technologies">
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
        #region 128. Tennis

        private Color Tennis_C1 = Color.White;
        private Color Tennis_C2 = Color.FromArgb(60, 60, 60);
        private Color Tennis_C3 = Color.FromArgb(50, 50, 50);
        private SolidBrush Tennis_B1 = new SolidBrush(Color.FromArgb(70, 70, 70));
        private Pen Tennis_P1 = new Pen(Color.FromArgb(50, 50, 50));
        private Pen Tennis_P2 = new Pen(Color.FromArgb(20, 20, 20));

        void Tennis_PaintHook(PaintEventArgs e)
        {
            G.Clear(Tennis_C1);
            DrawGradient(Color.FromArgb(255, 255, 255), Color.FromArgb(40, 40, 40), 10, 20, Width, Height, 90);
            DrawGradient(Tennis_C2, Tennis_C3, 0, 0, Width, Height);
            G.DrawLine(Tennis_P1, 30, 30, 30, 30);
            G.DrawLine(Tennis_P1, Width - 1, 0, Width - 1, 25);
            G.DrawLine(Tennis_P2, 0, 0, 0, Height);
            G.DrawLine(Tennis_P2, Width - 1, 0, Width - 1, Height);
            G.DrawLine(Tennis_P2, 0, Height - 1, Width, Height - 1);
            HatchBrush T = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(25, 25, 25), Color.FromArgb(35, 35, 35));
            G.FillRectangle(T, 10, 20, Width - 20, Height - 30);
            //G.FillRectangle(New SolidBrush(Color.FromArgb(25, 25, 25)), 10, 20, Width - 20, Height - 30)
            G.DrawLine(Tennis_P2, 0, 0, Width, 0);
            DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
            HatchBrush i = new HatchBrush(HatchStyle.Shingle, Color.FromArgb(25, 25, 25), Color.FromArgb(35, 35, 35));
            G.FillRectangle(i, 10, 20, Width - 20, Height - 30);
        }


        #endregion
    }
}
