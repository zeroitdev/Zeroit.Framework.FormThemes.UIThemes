// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Zeus.cs" company="Zeroit Dev Technologies">
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
        #region 145. Zeus

        void Zeus_PaintHook(PaintEventArgs e)
        {
            Color C1 = Color.FromArgb(38, 38, 38);
            Color C2 = Color.AliceBlue;
            Pen P1 = Pens.Black;
            Pen P2 = Pens.AliceBlue;


            G.Clear(C1);
            G.DrawLine(P2, 50, 0, 0, 50);
            G.DrawLine(P2, Width - 50, 0, Width, 50);
            G.DrawLine(P2, 50, 20, Width - 50, 20);
            G.DrawLine(P2, 70, 0, 50, 20);
            G.DrawLine(P2, Width - 70, 0, Width - 50, 20);
            G.DrawLine(P2, 0, 75, 35, 40);
            G.DrawLine(P2, Width - 35, 40, Width, 75);
            G.DrawLine(P2, 35, 40, Width - 35, 40);
            G.DrawRectangle(P2, 15, 75, Width - 30, Height - 90);
            G.DrawString("<<>>", this.Font, Brushes.AliceBlue, Width - 32, 0);
            G.DrawString("<<>>", this.Font, Brushes.AliceBlue, 8, 0);
            DrawBorders(P1, P2, ClientRectangle);
            DrawText(HorizontalAlignment.Center, C2, 0);

        }


        #endregion
    }
}
