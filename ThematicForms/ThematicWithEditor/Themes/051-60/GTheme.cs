﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="GTheme.cs" company="Zeroit Dev Technologies">
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
        #region 57. GTheme

        private Color GTheme_C1 = Color.FromArgb(25, 25, 25);
        private Color GTheme_C2 = Color.FromArgb(51, 51, 51);
        private Pen GTheme_P1 = new Pen(Color.FromArgb(58, 58, 58));
        private Pen GTheme_P2;

        private Color GTheme_B1 = Color.FromArgb(204, 204, 204);
        void GTheme_PaintHook(PaintEventArgs e)
        {

            GTheme_P2 = new Pen(GTheme_C2);
            G.Clear(GTheme_C1);

            DrawGradient(GTheme_C2, GTheme_C1, 0, 0, Width, 28, 90);

            G.DrawLine(GTheme_P2, 0, 28, Width, 28);
            G.DrawLine(GTheme_P1, 0, 29, Width, 29);

            DrawText(HorizontalAlignment.Center, GTheme_B1, 5 + 3/*ImageWidth*/);
            G.DrawIcon(ParentForm.FindForm().Icon, new Rectangle(4, 4, 20, 20));
            //DrawIcon(HorizontalAlignment.Left, 5);

            DrawBorders(Pens.Black, GTheme_P1, ClientRectangle);
            DrawCorners(Color.Fuchsia, ClientRectangle);
        }


        #endregion
    }
}
