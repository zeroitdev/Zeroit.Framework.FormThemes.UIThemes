// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="NetSeal.cs" company="Zeroit Dev Technologies">
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
        #region 90. Net Seal
        private Rectangle NetSeal_R1;
        private Pen NetSeal_P1 = new Pen(Color.FromArgb(24, 24, 24));
        private Pen NetSeal_P2 = new Pen(Color.FromArgb(60, 60, 60));

        private SolidBrush NetSeal_B1 = new SolidBrush(Color.FromArgb(50, 50, 50));

        private int NetSeal_Pad;
        private int _AccentOffset = 42;

        void NetSeal_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(50, 50, 50));
            DrawBorders(NetSeal_P2, 1);

            G.DrawLine(NetSeal_P1, 0, 26, Width, 26);
            G.DrawLine(NetSeal_P2, 0, 25, Width, 25);

            NetSeal_Pad = Math.Max(Measure().Width + 20, 80);
            NetSeal_R1 = new Rectangle(NetSeal_Pad, 17, Width - (NetSeal_Pad * 2) + _AccentOffset, 8);

            G.DrawRectangle(NetSeal_P2, NetSeal_R1);
            G.DrawRectangle(NetSeal_P1, NetSeal_R1.X + 1, NetSeal_R1.Y + 1, NetSeal_R1.Width - 2, NetSeal_R1.Height);

            G.DrawLine(NetSeal_P1, 0, 29, Width, 29);
            G.DrawLine(NetSeal_P2, 0, 30, Width, 30);




            DrawText(Brushes.Black, HorizontalAlignment.Left, 8, 1);
            DrawText(Brushes.WhiteSmoke, HorizontalAlignment.Left, 7, 0);

            G.FillRectangle(NetSeal_B1, 0, 27, Width, 2);
            DrawBorders(Pens.Black);
        }


        #endregion
    }
}
