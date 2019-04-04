// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="MPGH.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
        #region 85. MPGH

        void MPGH_PaintHook(PaintEventArgs e)
        {
            DrawGradient(Color.FromArgb(0, 0, 128), Color.FromArgb(35, 107, 142), 0, 0, Width, 55, 180);
            // Top Top
            DrawGradient(Color.FromArgb(35, 107, 142), Color.FromArgb(0, 0, 128), 0, 0, Width, 55, 90);
            // Top Top
            DrawGradient(Color.FromArgb(34, 34, 34), Color.FromArgb(34, 34, 34), 0, 56, Width, Height - 55, 90);
            // Middel Bottom
            DrawGradient(Color.FromArgb(34, 34, 34), Color.FromArgb(34, 34, 34), 0, 84, Width, 35, 90);
            // Midel Top
            G.DrawLine(Pens.Black, 0, 28, Width, 28);
            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(1, 0, 0, 0))), 0, 29, Width, 29);
            DrawCorners(TransparencyKey);

            DrawText(Brushes.White, HorizontalAlignment.Left, 6, 5);

            Pen p4 = new Pen(Color.FromArgb(34, 34, 34));
            Int32 ClientPtA = default(Int32);
            Int32 ClientPtB = default(Int32);

            ClientPtA = 55;
            ClientPtB = 30;
            for (int I = 0; I <= Width + 17; I += 4)
            {
                G.DrawLine(p4, I, 30, I - 17, ClientPtA);
                G.DrawLine(p4, I - 1, 30, I - 18, ClientPtA);
            }
        }

        #endregion
    }
}
