// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="BetaBlue.cs" company="Zeroit Dev Technologies">
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
        #region 11. Beta Blue

        void BetaBlue_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromKnownColor(KnownColor.Control));
            // Clear the form first
            //DrawGradient(Color.FromArgb(0, 105, 246), Color.FromArgb(0, 81, 181), 0, 0, Width, Height, 90S)   ' Form Gradient
            G.Clear(Color.FromArgb(0, 95, 218));
            DrawGradient(Color.FromArgb(0, 95, 218), Color.FromArgb(0, 55, 202), 0, 0, Width, 25, 90);
            // Form Top Bar

            DrawCorners(Color.Fuchsia, ClientRectangle);
            // Then draw some clean corners
            DrawBorders(Pens.DarkBlue, Pens.DodgerBlue, ClientRectangle);
            // Then we draw our form borders

            G.DrawLine(Pens.Black, 0, 25, Width, 25);
            // Top Line
            //G.DrawLine(Pens.Black, 0, Height - 25, Width, Height - 25)   ' Bottom Line

            DrawText(HorizontalAlignment.Left, Color.White, 8, 2);
            // Finally, we draw our text
        }

        #endregion
    }
}
