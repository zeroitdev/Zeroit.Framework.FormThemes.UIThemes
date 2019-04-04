// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Hero.cs" company="Zeroit Dev Technologies">
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
        #region 65. Hero

        void Hero_PaintHook(PaintEventArgs e)
        {
            MoveHeight = 25;
            G.Clear(Color.FromArgb(211, 211, 211));


            G.Clear(Color.FromArgb(211, 211, 211));
            DrawGradient(Color.FromArgb(62, 62, 62), Color.FromArgb(40, 40, 40), 0, 0, Width, 25, 90);

            G.DrawLine(Pens.Black, 0, 25, Width, 25);

            DrawCorners(Color.Fuchsia, ClientRectangle);
            DrawBorders(Pens.Black, Pens.DimGray, ClientRectangle);

            DrawText(HorizontalAlignment.Left, Color.FromArgb(211, 211, 211), 7, 1);
        }

        #endregion
    }
}
