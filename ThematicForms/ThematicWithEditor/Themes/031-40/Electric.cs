// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Electric.cs" company="Zeroit Dev Technologies">
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
        #region 40. Electric
        Color BGColor = Color.FromArgb(22, 84, 107);
        Color Electric_G1 = Color.FromArgb(43, 136, 170);
        Color Electric_G2 = Color.FromArgb(29, 102, 129);
        Color Electric_F = Color.Fuchsia;
        Pen Seperator = new Pen(Color.FromArgb(7, 65, 86));

        Pen Electric_B = Pens.Black;
        void Electric_PaintHook(PaintEventArgs e)
        {
            G.Clear(BGColor);
            //Background

            DrawGradient(Electric_G1, Electric_G2, 0, 0, Width, 20, 90);
            //Menu Bar
            G.DrawLine(Seperator, 0, 20, Width, 20);
            //Menu bar seperator line

            G.DrawRectangle(Electric_B, ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width - 1, ClientRectangle.Height - 1);
            //Border
            DrawCorners(Electric_F, ClientRectangle);
            //Form corners

            DrawText(HorizontalAlignment.Left, ForeColor, 3);
            //Menu bar's text
        }

        #endregion
    }
}
