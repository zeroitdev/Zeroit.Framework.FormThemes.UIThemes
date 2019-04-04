// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="TheBlack.cs" company="Zeroit Dev Technologies">
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
        #region 129. TheBlack

        private Color TheBlack_C1 = Color.FromArgb(30, 30, 30);
        private SolidBrush TheBlack_B1 = new SolidBrush(Color.FromArgb(0, 12, 12));
        private SolidBrush TheBlack_B2 = new SolidBrush(Color.FromArgb(45, 45, 48));
        private Pen TheBlack_P1 = new Pen(Color.FromArgb(29, 28, 27));
        private Pen TheBlack_P2 = new Pen(Color.FromArgb(85, 85, 85));

        private Pen TheBlack_P3 = new Pen(Color.FromArgb(85, 85, 85));

        void TheBlack_PaintHook(PaintEventArgs e)
        {
            G.Clear(TheBlack_C1);
            G.FillRectangle(TheBlack_B1, 0, 0, Width, 30);
            G.FillRectangle(TheBlack_B2, 1, Height - 31, Width - 1, 30);
            G.DrawLine(TheBlack_P1, 0, 0, Width, 0);
            G.DrawLine(TheBlack_P1, 0, 0, 0, 29);
            G.DrawLine(TheBlack_P1, 0, 29, Width, 29);
            G.DrawLine(TheBlack_P1, Width - 1, 0, Width - 1, 29);
            G.DrawLine(TheBlack_P2, 0, 30, 0, Height);
            G.DrawLine(TheBlack_P2, Width - 1, 30, Width - 1, Height);
            G.DrawLine(TheBlack_P2, 0, Height - 1, Width, Height - 1);
            G.DrawLine(TheBlack_P3, 1, Height - 32, Width - 2, Height - 32);
            DrawText(Brushes.White, HorizontalAlignment.Left, 5, 3);
        }

        #endregion
    }
}
