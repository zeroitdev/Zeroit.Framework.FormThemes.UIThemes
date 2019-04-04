// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="JTheme.cs" company="Zeroit Dev Technologies">
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
        #region 75. JTheme
        Color Color1 = Color.FromArgb(20, 20, 20);
        Brush Color2 = new SolidBrush(Color.FromArgb(50, 50, 50));
        Color Color3 = Color.FromArgb(50, 50, 50);
        Brush Color4 = new SolidBrush(Color.White);
        void JTheme_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color1);
            Rectangle rect = new Rectangle(10, 20, Width - 20, Height - 30);
            G.FillRectangle(Color2, rect);
            DrawBorders(Pens.Black, rect);
            DrawBorders(Pens.Black);
            DrawCorners(Color3);
            DrawText(Color4, HorizontalAlignment.Center, 0, 0);


        }

        #endregion
    }
}
