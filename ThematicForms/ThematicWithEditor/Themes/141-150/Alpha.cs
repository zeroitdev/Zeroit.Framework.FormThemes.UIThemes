// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Alpha.cs" company="Zeroit Dev Technologies">
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
        #region 146. Alpha

        void Alpha_PaintHook(PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.Clear(Color.DimGray);

            DrawGradient(Color.LightGray, Color.Gray, 0, 0, Width, 25, 90);
            G.DrawLine(Pens.Lime, 0, 25, Width, 25);

            DrawBorders(Pens.Lime, Pens.DimGray, ClientRectangle);
            DrawCorners(Color.Blue, ClientRectangle);
        }

        #endregion
    }
}
