// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Drone.cs" company="Zeroit Dev Technologies">
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
        #region 37. Drone


        void Drone_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(24, 24, 24));

            DrawGradient(Color.FromArgb(0, 55, 90), Color.FromArgb(0, 70, 128), 11, 8, Width - 22, 17);
            G.FillRectangle(new SolidBrush(Color.FromArgb(0, 55, 90)), 11, 3, Width - 22, 5);

            Pen P = new Pen(Color.FromArgb(13, Color.White));
            G.DrawLine(P, 10, 1, 10, Height);
            G.DrawLine(P, Width - 11, 1, Width - 11, Height);
            G.DrawLine(P, 11, Height - 11, Width - 12, Height - 11);
            G.DrawLine(P, 11, 29, Width - 12, 29);
            G.DrawLine(P, 11, 25, Width - 12, 25);

            G.FillRectangle(new SolidBrush(Color.FromArgb(13, Color.White)), 0, 2, Width, 6);
            G.FillRectangle(new SolidBrush(Color.FromArgb(13, Color.White)), 0, Height - 6, Width, 4);

            G.FillRectangle(new SolidBrush(Color.FromArgb(24, 24, 24)), 11, Height - 6, Width - 22, 4);

            HatchBrush T = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(24, 24, 24), Color.FromArgb(8, 8, 8));
            G.FillRectangle(T, 11, 30, Width - 22, Height - 41);

            DrawText(Brushes.White, HorizontalAlignment.Left, 15, 2);

            DrawBorders(new Pen(Color.FromArgb(58, 58, 58)), 1);
            DrawBorders(Pens.Black);

            P = new Pen(Color.FromArgb(25, Color.White));
            G.DrawLine(P, 11, 3, Width - 12, 3);
            G.DrawLine(P, 12, 2, 12, 7);
            G.DrawLine(P, Width - 13, 2, Width - 13, 7);

            G.DrawLine(Pens.Black, 11, 0, 11, Height);
            G.DrawLine(Pens.Black, Width - 12, 0, Width - 12, Height);

            G.DrawRectangle(Pens.Black, 11, 2, Width - 23, 22);
            G.DrawLine(Pens.Black, 11, Height - 12, Width - 12, Height - 12);
            G.DrawLine(Pens.Black, 11, 30, Width - 12, 30);

            DrawCorners(Color.Fuchsia);
        }

        #endregion
    }
}
