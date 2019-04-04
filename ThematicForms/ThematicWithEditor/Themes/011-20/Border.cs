// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Border.cs" company="Zeroit Dev Technologies">
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
        #region 19. Border


        void Border_PaintHook(PaintEventArgs e)
        {
            HatchBrush hb2 = new HatchBrush(HatchStyle.LightUpwardDiagonal, Color.FromArgb(35, 35, 35));
            G.Clear(Color.Fuchsia);
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(71, 71, 71))), new Rectangle(0, 0, Width - 1, Height - 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(5, 5, 5)), new Rectangle(0, 0, Width - 1, Height - 1));

            G.DrawString(Text, Font, Brushes.Black, new Point(10, 9));
            G.DrawString(Text, Font, Brushes.White, new Point(8, 6));

            //G.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));

            G.FillRectangle(new SolidBrush(Color.FromArgb(55, Color.White)), new Rectangle(0, 0, Width - 1, Height));
            G.FillRectangle(new SolidBrush(Color.FromArgb(5, Color.White)), new Rectangle(0, 0, Width - 1, 17));
            G.DrawRectangle(new Pen(new SolidBrush(Color.Black)), new Rectangle(11, 28, Width - 23, Height - 41));
            G.FillRectangle(new SolidBrush(Color.FromArgb(15, 15, 15)), new Rectangle(12, 29, Width - 24, Height - 42));

            DrawCorners(Color.Magenta);
        }

        #endregion
    }
}
