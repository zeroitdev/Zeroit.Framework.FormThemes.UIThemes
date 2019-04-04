// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Tennis.cs" company="Zeroit Dev Technologies">
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
