// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Xbox.cs" company="Zeroit Dev Technologies">
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
        #region 141. Xbox

        void Xbox_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(20, 20, 20));
            DrawGradient(Color.FromArgb(48, 255, 0), (Color.FromArgb(42, 218, 2)), 0, 0, Width, 20, 90);
            DrawGradient(Color.GhostWhite, Color.LightGray, 0, 20, Width, Height - 20, 90);
            G.DrawLine(Pens.DarkGray, 0, 20, Width, 20);
            DrawGradient(Color.DarkGreen, (Color.FromArgb(18, 255, 0)), 0, 0, Width, 20, 90);
            G.DrawLine(Pens.Green, 0, 20, Width, 20);
            DrawBorders(Pens.Black, Pens.DarkGreen, ClientRectangle);
            DrawCorners(Color.DarkGreen, ClientRectangle);
            DrawText(HorizontalAlignment.Center, Color.FromArgb(210, 210, 210), 0);
        }

        #endregion
    }
}
