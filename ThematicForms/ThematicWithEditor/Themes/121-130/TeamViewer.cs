// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="TeamViewer.cs" company="Zeroit Dev Technologies">
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
        #region 125. TeamViewer

        void TeamViewer_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.White);
            DrawGradient(Color.FromArgb(0, 153, 255), Color.FromArgb(0, 102, 255), 0, 0, Width, 28, 90);
            DrawGradient(Color.FromArgb(51, 153, 255), Color.FromArgb(0, 102, 204), 0, 29, Width, 55, 90);
            DrawGradient(Color.White, Color.FromArgb(204, 204, 204), 0, 115, Width, Height - 55, 90);
            DrawGradient(Color.FromArgb(204, 204, 204), Color.White, 0, 84, Width, 35, 90);
            G.DrawLine(Pens.DarkBlue, 0, 28, Width, 28);
            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(51, 204, 255))), 0, 29, Width, 29);
            G.DrawLine(Pens.White, 0, 84, Width, 84);
            //G.DrawString(".", Me.Parent.Font, Brushes.Black, -2, Height - 12)
            //G.DrawString(".", Me.Parent.Font, Brushes.Black, Width - 5, Height - 12)
            //DrawBorders(Pens.Black, Pens.Transparent, ClientRectangle)
            //DrawCorners(Color.Fuchsia, ClientRectangle)

            DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Left, 4, 0);

        }

        #endregion
    }
}
