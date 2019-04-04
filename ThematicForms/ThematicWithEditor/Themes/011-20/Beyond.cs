// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Beyond.cs" company="Zeroit Dev Technologies">
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
        #region 12. Beyond 

        void Beyond_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.White);
            DrawGradient(Color.FromArgb(15, 15, 15), Color.FromArgb(30, 30, 30), 0, 0, Width, Height, 90);
            DrawGradient(Color.FromArgb(50, 50, 50), Color.FromArgb(70, 70, 70), 0, 0, Width, Height);
            G.DrawLine(new Pen(Color.FromArgb(50, 50, 50)), 0, 0, 0, 20);
            G.DrawLine(new Pen(Color.FromArgb(50, 50, 50)), Width - 1, 0, Width - 1, 25);
            G.DrawLine(new Pen(Color.FromArgb(20, 20, 20)), 0, 0, 0, Height);
            G.DrawLine(new Pen(Color.FromArgb(20, 20, 20)), Width - 1, 0, Width - 1, Height);
            G.DrawLine(new Pen(Color.FromArgb(20, 20, 20)), 0, Height - 1, Width, Height - 1);
            G.FillRectangle(new SolidBrush(Color.FromArgb(15, 15, 15)), 10, 20, Width - 20, Height - 30);
            G.DrawLine(new Pen(Color.FromArgb(20, 20, 20)), 0, 0, Width, 0);
            DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
        }

        #endregion
    }
}
