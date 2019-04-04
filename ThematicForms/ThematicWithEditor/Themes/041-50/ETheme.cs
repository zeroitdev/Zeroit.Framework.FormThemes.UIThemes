// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="ETheme.cs" company="Zeroit Dev Technologies">
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
        #region 46. ETheme

        void ETheme_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(53, 53, 53));
            DrawGradient(Color.FromArgb(50, 50, 50), Color.FromArgb(50, 50, 50), 0, 1, Width, 14, 90);
            DrawGradient(Color.FromArgb(29, 29, 29), Color.FromArgb(29, 29, 29), 2, 16, Width, 14, 90);
            G.DrawLine(Pens.Black, 0, 30, Width, 30);
            DrawBorders(Pens.Gray, Pens.Black, ClientRectangle);
            DrawText(HorizontalAlignment.Center, Color.Gray, 0);

        }

        #endregion
    }
}
