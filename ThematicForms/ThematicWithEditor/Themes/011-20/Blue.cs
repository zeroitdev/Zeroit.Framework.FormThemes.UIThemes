﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Blue.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 18. Blue


        private Color Blue_C1 = Color.FromArgb(255, 255, 255);
        private SolidBrush Blue_B1 = new SolidBrush(Color.FromArgb(109, 132, 180));
        private SolidBrush Blue_B2 = new SolidBrush(Color.FromArgb(242, 242, 242));
        private Pen Blue_P1 = new Pen(Color.FromArgb(59, 89, 152));
        private Pen Blue_P2 = new Pen(Color.FromArgb(85, 85, 85));

        private Pen Blue_P3 = new Pen(Color.FromArgb(204, 204, 204));
        void Blue_PaintHook(PaintEventArgs e)
        {
            G.Clear(Blue_C1);
            G.FillRectangle(Blue_B1, 0, 0, Width, 30);
            G.FillRectangle(Blue_B2, 1, Height - 31, Width - 1, 30);
            G.DrawLine(Blue_P1, 0, 0, Width, 0);
            G.DrawLine(Blue_P1, 0, 0, 0, 29);
            G.DrawLine(Blue_P1, 0, 29, Width, 29);
            G.DrawLine(Blue_P1, Width - 1, 0, Width - 1, 29);
            G.DrawLine(Blue_P2, 0, 30, 0, Height);
            G.DrawLine(Blue_P2, Width - 1, 30, Width - 1, Height);
            G.DrawLine(Blue_P2, 0, Height - 1, Width, Height - 1);
            G.DrawLine(Blue_P3, 1, Height - 32, Width - 2, Height - 32);
            DrawText(Brushes.White, HorizontalAlignment.Left, 5, 3);
        }


        #endregion
    }
}
