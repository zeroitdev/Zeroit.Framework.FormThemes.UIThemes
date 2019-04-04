// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Purity.cs" company="Zeroit Dev Technologies">
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
        #region 100. Purity

        void Purity_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromKnownColor(KnownColor.Control));
            // Clear the form first

            //DrawGradient(Color.FromArgb(64, 64, 64), Color.FromArgb(32, 32, 32), 0, 0, Width, Height, 90S)   ' Form Gradient
            G.Clear(Color.FromArgb(60, 60, 60));
            DrawGradient(Color.FromArgb(45, 40, 45), Color.FromArgb(32, 32, 32), 0, 0, Width, 25, 90);
            // Form Top Bar

            G.DrawLine(Pens.Black, 0, 25, Width, 25);
            // Top Line
            //G.DrawLine(Pens.Black, 0, Height - 25, Width, Height - 25)   ' Bottom Line

            DrawCorners(Color.Fuchsia, ClientRectangle);
            // Then draw some clean corners
            DrawBorders(Pens.Black, Pens.DimGray, ClientRectangle);
            // Then we draw our form borders

            DrawText(HorizontalAlignment.Left, Color.Red, 7, 1);
            // Finally, we draw our text
        }

        #endregion
    }
}
