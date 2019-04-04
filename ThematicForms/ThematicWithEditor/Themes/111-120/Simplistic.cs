// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Simplistic.cs" company="Zeroit Dev Technologies">
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
        #region 112. Simplistic

        void Simplistic_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.SteelBlue);

            DrawGradient(Color.DodgerBlue, Color.SteelBlue, 0, 0, Width, 24, 180);
            G.DrawLine(Pens.Black, 0, 24, Width, 24);

            DrawText(HorizontalAlignment.Left, Color.Black, 4);
            DrawBorders(Pens.Black, Pens.LightGray, ClientRectangle);
            DrawCorners(Color.Fuchsia, ClientRectangle);
        }

        #endregion
    }
}
