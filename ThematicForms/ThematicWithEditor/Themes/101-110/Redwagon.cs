﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Redwagon.cs" company="Zeroit Dev Technologies">
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
        #region 104. RedDwagon

        void RedDwagon_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Black);

            DrawGradient(Color.FromArgb(153, 0, 0), Color.FromArgb(255, 0, 0), 0, 0, Width, 55, 180);
            // Top Top
            DrawGradient(Color.FromArgb(255, 0, 0), Color.FromArgb(153, 0, 0), 0, 0, Width, 55, 90);
            // Top Top
            DrawGradient(Color.FromArgb(34, 34, 34), Color.FromArgb(34, 34, 34), 0, 56, Width, Height - 55, 90);
            // Middel Bottom
            DrawGradient(Color.FromArgb(34, 34, 34), Color.FromArgb(34, 34, 34), 0, 84, Width, 35, 90);
            // Midel Top
            G.DrawLine(Pens.Black, 0, 28, Width, 28);
            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(1, 0, 0, 0))), 0, 29, Width, 29);

            Pen p4 = new Pen(Color.FromArgb(34, 34, 34));
            Int32 ClientPtA = default(Int32);
            Int32 ClientPtB = default(Int32);
            ClientPtA = 55;
            ClientPtB = 30;
            DrawImage(HorizontalAlignment.Left, 5, 0);
            DrawText(Brushes.Black, 35, 7);

            G.DrawLine(p4, 0, ClientPtB, Width, ClientPtB);
            // Damn SlantedLines Where a BITCH to get in proper spot!

            for (int I = 0; I <= Width + 17; I += 4)
            {
                G.DrawLine(p4, I, 30, I - 17, ClientPtA);
                G.DrawLine(p4, I - 1, 30, I - 18, ClientPtA);
            }

            DrawCorners(TransparencyKey);
        }

        #endregion
    }
}
