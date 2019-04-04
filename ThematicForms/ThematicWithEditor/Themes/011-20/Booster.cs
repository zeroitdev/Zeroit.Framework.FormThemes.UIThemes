// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Booster.cs" company="Zeroit Dev Technologies">
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
        #region 17. Booster


        void Booster_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(51, 51, 51));
            DrawGradient(Color.FromArgb(29, 29, 29), Color.FromArgb(65, 65, 65), 0, 28, Width, (Height / 2) - 10);
            DrawGradient(Color.FromArgb(87, 87, 87), Color.FromArgb(49, 49, 49), 0, 0, Width, 25);
            G.DrawLine(Pens.Black, 0, 25, Width, 25);

            G.DrawLine(new Pen(Color.FromArgb(192, 74, 74)), 0, 26, Width, 26);
            G.FillRectangle(new SolidBrush(Color.FromArgb(169, 0, 0)), 0, 27, Width, 27);
            G.FillRectangle(new SolidBrush(Color.FromArgb(45, Color.White)), 0, 27, Width, 13);

            G.DrawLine(new Pen(Color.FromArgb(38, 38, 38)), 0, Height - 25, Width, Height - 25);
            G.DrawLine(new Pen(Color.FromArgb(64, 64, 64)), 0, Height - 24, Width, Height - 24);

            DrawBorders(Pens.Black);
            DrawBorders(new Pen(Color.FromArgb(92, 92, 92)), 1);

            DrawCorners(Color.Fuchsia);
            DrawText(Brushes.Black, HorizontalAlignment.Center, 0, 0);
            DrawText(Brushes.White, HorizontalAlignment.Center, 0, 1);
        }

        #endregion
    }
}
