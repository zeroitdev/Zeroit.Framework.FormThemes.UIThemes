// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Evolve.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 47. Evolve

        void Evolve_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(47, 47, 47));
            DrawBorders(new Pen(Color.FromArgb(104, 104, 104)), 1);
            ColorBlend cblend = new ColorBlend(2);
            cblend.Colors[0] = Color.FromArgb(66, 66, 66);
            cblend.Colors[1] = Color.FromArgb(50, 50, 50);
            cblend.Positions[0] = 0;
            cblend.Positions[1] = 1;
            DrawGradient(cblend, new Rectangle(new Point(2, 2), new Size(this.Width - 4, 22)));
            G.DrawLine(new Pen(Color.FromArgb(30, 30, 30)), new Point(2, 24), new Point(this.Width - 3, 24));
            G.DrawLine(new Pen(Color.FromArgb(70, 70, 70)), new Point(2, 25), new Point(this.Width - 3, 25));
            DrawBorders(Pens.Black);
            DrawCorners(Color.Fuchsia);
            G.DrawIcon(this.ParentForm.Icon, new Rectangle(new Point(8, 5), new Size(16, 16)));
            G.DrawString(this.ParentForm.Text, Font, Brushes.White, new Point(28, 4));
        }

        #endregion
    }
}
