// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Metal.cs" company="Zeroit Dev Technologies">
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
        #region 81. Metal
        private Pen Metal_P1;

        private Pen Metal_P2;

        void Metal_PaintHook(PaintEventArgs e)
        {
            MoveHeight = 25;
            Metal_P1 = new Pen(Color.FromArgb(45, 45, 45));
            Metal_P2 = new Pen(Color.FromArgb(90, 90, 90));
            Color Textcolor = Color.White;

            G.Clear(Color.FromArgb(41, 41, 41));
            G.FillRectangle(new SolidBrush(Color.FromArgb(63, 63, 63)), 14, MoveHeight, Width - 30, Height - MoveHeight - 12);
            DrawGradient(Color.FromArgb(100, 100, 100), Color.FromArgb(41, 41, 41), 0, -12, Width, MoveHeight, 90);

            if (_TitleAlign == HorizontalAlignment.Center)
            {
                DrawText(HorizontalAlignment.Center, Textcolor, 5);
            }
            else if (_TitleAlign == HorizontalAlignment.Left)
            {
                DrawText(HorizontalAlignment.Left, Textcolor, 5);
            }
            else if (_TitleAlign == HorizontalAlignment.Right)
            {
                DrawText(HorizontalAlignment.Right, Textcolor, 5);
            }

            DrawBorders(Metal_P2, Metal_P1, ClientRectangle);
            DrawCorners(Color.Fuchsia, ClientRectangle);
        }


        #endregion
    }
}
