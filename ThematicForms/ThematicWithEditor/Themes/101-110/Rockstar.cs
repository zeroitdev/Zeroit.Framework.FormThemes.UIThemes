// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Rockstar.cs" company="Zeroit Dev Technologies">
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
        #region 106. Rockstar

        void Rockstar_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Black);


            G.DrawLine(Pens.Gold, 0, 20, Width, 20);

            DrawGradient(Color.Yellow, Color.Gold, 0, 0, Width, 20, 90);
            DrawText(HorizontalAlignment.Center, Color.Black, 0);

            DrawBorders(Pens.Yellow, Pens.Yellow, ClientRectangle);
            DrawCorners(Color.Fuchsia, ClientRectangle);
        }

        #endregion
    }
}
