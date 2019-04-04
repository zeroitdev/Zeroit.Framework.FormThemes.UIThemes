// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Genuine.cs" company="Zeroit Dev Technologies">
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
        #region 59. Genuine

        private Color Genuine_C1 = Color.FromArgb(41, 41, 41);
        private Color Genuine_C2 = Color.FromArgb(25, 25, 25);
        private Color Genuine_C3 = Color.FromArgb(41, 41, 41);
        private SolidBrush Genuine_B1 = new SolidBrush(Color.FromArgb(255, 255, 255));

        private Pen Genuine_P1 = new Pen(Color.FromArgb(25, 25, 25));
        private Pen Genuine_P2 = new Pen(Color.FromArgb(58, 58, 58));
        private Pen Genuine_P3 = new Pen(Color.FromArgb(58, 58, 58));

        private Pen Genuine_P4 = new Pen(Color.FromArgb(0, 0, 0));



        void Genuine_PaintHook(PaintEventArgs e)
        {
            G.Clear(Genuine_C1);

            DrawGradient(Genuine_C2, Genuine_C3, 0, 0, Width, 28);

            G.DrawLine(Genuine_P1, 0, 28, Width, 28);
            G.DrawLine(Genuine_P2, 0, 29, Width, 29);

            DrawText(Genuine_B1, HorizontalAlignment.Left, 7, 0);

            DrawBorders(Genuine_P3, 1);
            DrawBorders(Genuine_P4);

            DrawCorners(TransparencyKey);
        }

        #endregion
    }
}
