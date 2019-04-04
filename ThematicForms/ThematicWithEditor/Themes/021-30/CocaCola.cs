// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="CocaCola.cs" company="Zeroit Dev Technologies">
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
        #region 27. Coca Cola


        void CocaCola_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Crimson);
            DrawGradient(Color.Brown, Color.Firebrick, 0, 0, Width, 24, 315);
            DrawGradient(Color.Brown, Color.Crimson, 0, 24, Width, Height, 67);
            DrawCorners(Color.RosyBrown, ClientRectangle);

            DrawBorders(new Pen(new SolidBrush(Color.RosyBrown)));
            DrawBorders(new Pen(new SolidBrush(Color.RosyBrown)), 1);
            DrawBorders(new Pen(new SolidBrush(Color.RosyBrown)), 2);

            DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);

        }

        #endregion
    }
}
