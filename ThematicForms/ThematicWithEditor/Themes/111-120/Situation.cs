// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Situation.cs" company="Zeroit Dev Technologies">
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
        #region 113. Situation

        void Situation_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.DarkSlateGray);
            DrawGradient(Color.DarkSlateGray, Color.DarkGray, 0, 0, Width, 20, 90);
            DrawGradient(Color.DimGray, Color.Black, 0, 20, Width, Height - 25, 90);
            DrawGradient(Color.DarkGray, Color.Black, 0, Height - 25, Width, Height + 25 - Height, 90);
            DrawGradient(Color.DarkGray, Color.DarkSlateGray, 0, Height + 25 - Height - 5, 10, Height - 45, 180);
            DrawGradient(Color.DarkSlateGray, Color.Black, Width - 10, Height + 25 - Height - 5, 10, Height - 45, 180);
            DrawCorners(Color.Fuchsia, ClientRectangle);
            DrawText(HorizontalAlignment.Center, ForeColor, 3);
            DrawBorders(Pens.DarkSlateGray, Pens.LightBlue, ClientRectangle);
        }

        #endregion
    }
}
