// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="VTheme.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
        #region 135. VTheme

        void VTheme_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(12, 12, 12));
            Pen P = new Pen(Color.FromArgb(32, 32, 32));
            G.DrawLine(P, 11, 31, Width - 12, 31);
            G.DrawLine(P, 11, 8, Width - 12, 8);
            G.FillRectangle(new LinearGradientBrush(new Rectangle(8, 38, Width - 16, Height - 46), Color.FromArgb(12, 12, 12), Color.FromArgb(18, 18, 18), LinearGradientMode.BackwardDiagonal), 8, 38, Width - 16, Height - 46);
            DrawText(Brushes.White, HorizontalAlignment.Left, 25, 6);
            DrawBorders(new Pen(Color.FromArgb(60, 60, 60)), 1);
            DrawBorders(Pens.Black);

            P = new Pen(Color.FromArgb(25, 25, 25));
            G.DrawLine(Pens.Black, 6, 0, 6, Height - 6);
            G.DrawLine(Pens.Black, Width - 6, 0, Width - 6, Height - 6);
            G.DrawLine(P, 6, 0, 6, Height - 6);
            G.DrawLine(P, Width - 8, 0, Width - 8, Height - 6);

            G.DrawRectangle(Pens.Black, 11, 4, Width - 23, 22);
            G.DrawLine(P, 6, Height - 6, Width - 8, Height - 6);
            G.DrawLine(Pens.Black, 6, Height - 8, Width - 8, Height - 8);
            DrawCorners(Color.Fuchsia);
        }

        #endregion
    }
}
