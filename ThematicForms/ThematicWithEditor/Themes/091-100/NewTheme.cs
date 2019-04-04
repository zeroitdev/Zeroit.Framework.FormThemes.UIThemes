// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="NewTheme.cs" company="Zeroit Dev Technologies">
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
        #region 91. New Theme

        void NewTheme_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(12, 27, 74));
            //DrawGradient(Color.FromArgb(25, Color.White), Color.FromArgb(5, Color.White), 0, 0, Width, 20, 90S)
            HatchBrush HB = new HatchBrush(HatchStyle.BackwardDiagonal, Color.FromArgb(25, Color.White), Color.Transparent);
            G.FillRectangle(new SolidBrush(Color.FromArgb(13, 13, 13)), new Rectangle(6, 26, Width - 13, Height - 33));
            G.FillRectangle(HB, new Rectangle(6, 26, Width - 13, Height - 33));
            G.DrawLine(Pens.Black, 6, 26, Width - 8, 26);
            G.DrawLine(Pens.Black, Width - 8, Height - 8, Width - 8, 26);
            G.DrawLine(Pens.Black, 6, Height - 8, 6, 26);
            G.DrawLine(Pens.Black, 6, Height - 8, Width - 8, Height - 8);
            G.DrawString(Text, Font, Brushes.White, new Point(25, 5));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(5, 5, 16, 16));
            //G.FillRectangle(New SolidBrush(Border), New Rectangle(6, 66, Width - 13, Height - 400))
            //////Rounding
            //////left upper corner
            DrawPixel(Color.Fuchsia, 0, 0);
            DrawPixel(Color.Fuchsia, 1, 0);
            DrawPixel(Color.Fuchsia, 2, 0);
            DrawPixel(Color.Fuchsia, 3, 0);
            DrawPixel(Color.Fuchsia, 0, 1);
            DrawPixel(Color.Fuchsia, 0, 2);
            DrawPixel(Color.Fuchsia, 0, 3);
            DrawPixel(Color.Fuchsia, 1, 1);
            //////right upper corner
            DrawPixel(Color.Fuchsia, Width - 1, 0);
            DrawPixel(Color.Fuchsia, Width - 2, 0);
            DrawPixel(Color.Fuchsia, Width - 3, 0);
            DrawPixel(Color.Fuchsia, Width - 4, 0);
            DrawPixel(Color.Fuchsia, Width - 1, 1);
            DrawPixel(Color.Fuchsia, Width - 1, 2);
            DrawPixel(Color.Fuchsia, Width - 1, 3);
            DrawPixel(Color.Fuchsia, Width - 2, 1);
        }

        #endregion
    }
}
