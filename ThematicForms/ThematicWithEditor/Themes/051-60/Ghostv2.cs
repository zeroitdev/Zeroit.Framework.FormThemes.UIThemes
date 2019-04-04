// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Ghostv2.cs" company="Zeroit Dev Technologies">
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
        #region 60. Ghostv2

        void Ghostv2_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.DimGray);
            ColorBlend hatch = new ColorBlend(2);
            DrawBorders(Pens.Gray, 1);
            hatch.Colors[0] = Color.DimGray;
            hatch.Colors[1] = Color.FromArgb(60, 60, 60);
            hatch.Positions[0] = 0;
            hatch.Positions[1] = 1;
            DrawGradient(hatch, new Rectangle(0, 0, Width, 24));
            hatch.Colors[0] = Color.FromArgb(100, 100, 100);
            hatch.Colors[1] = Color.DimGray;
            DrawGradient(hatch, new Rectangle(0, 0, Width, 12));
            HatchBrush asdf = default(HatchBrush);
            asdf = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(15, Color.Black), Color.FromArgb(0, Color.Gray));
            hatch.Colors[0] = Color.FromArgb(120, Color.Black);
            hatch.Colors[1] = Color.FromArgb(0, Color.Black);
            DrawGradient(hatch, new Rectangle(0, 0, Width, 30));
            G.FillRectangle(asdf, 0, 0, Width, 24);
            G.DrawLine(Pens.Black, 6, 24, Width - 7, 24);
            G.DrawLine(Pens.Black, 6, 24, 6, Height - 7);
            G.DrawLine(Pens.Black, 6, Height - 7, Width - 7, Height - 7);
            G.DrawLine(Pens.Black, Width - 7, 24, Width - 7, Height - 7);
            G.FillRectangle(new SolidBrush(Color.FromArgb(60, 60, 60)), new Rectangle(1, 24, 5, Height - 6 - 24));
            G.FillRectangle(asdf, 1, 24, 5, Height - 6 - 24);
            G.FillRectangle(new SolidBrush(Color.FromArgb(60, 60, 60)), new Rectangle(Width - 6, 24, Width - 1, Height - 6 - 24));
            G.FillRectangle(asdf, Width - 6, 24, Width - 2, Height - 6 - 24);
            G.FillRectangle(new SolidBrush(Color.FromArgb(60, 60, 60)), new Rectangle(1, Height - 6, Width - 2, Height - 1));
            G.FillRectangle(asdf, 1, Height - 6, Width - 2, Height - 1);
            DrawBorders(Pens.Black);
            asdf = new HatchBrush(HatchStyle.LightDownwardDiagonal, Color.DimGray);
            G.FillRectangle(asdf, 7, 25, Width - 14, Height - 24 - 8);
            G.FillRectangle(new SolidBrush(Color.FromArgb(230, 20, 20, 20)), 7, 25, Width - 14, Height - 24 - 8);
            DrawCorners(Color.Fuchsia);
            DrawCorners(Color.Fuchsia, 0, 1, 1, 1);
            DrawCorners(Color.Fuchsia, 1, 0, 1, 1);
            DrawPixel(Color.Black, 1, 1);

            DrawCorners(Color.Fuchsia, 0, Height - 2, 1, 1);
            DrawCorners(Color.Fuchsia, 1, Height - 1, 1, 1);
            DrawPixel(Color.Black, Width - 2, 1);

            DrawCorners(Color.Fuchsia, Width - 1, 1, 1, 1);
            DrawCorners(Color.Fuchsia, Width - 2, 0, 1, 1);
            DrawPixel(Color.Black, 1, Height - 2);

            DrawCorners(Color.Fuchsia, Width - 1, Height - 2, 1, 1);
            DrawCorners(Color.Fuchsia, Width - 2, Height - 1, 1, 1);
            DrawPixel(Color.Black, Width - 2, Height - 2);

            ColorBlend cblend = new ColorBlend(2);
            cblend.Colors[0] = Color.FromArgb(35, Color.Black);
            cblend.Colors[1] = Color.FromArgb(0, 0, 0, 0);
            cblend.Positions[0] = 0;
            cblend.Positions[1] = 1;
            DrawGradient(cblend, 7, 25, 15, Height - 6 - 24, 0);
            cblend.Colors[0] = Color.FromArgb(0, 0, 0, 0);
            cblend.Colors[1] = Color.FromArgb(35, Color.Black);
            DrawGradient(cblend, Width - 24, 25, 17, Height - 6 - 24, 0);
            cblend.Colors[1] = Color.FromArgb(0, 0, 0, 0);
            cblend.Colors[0] = Color.FromArgb(35, Color.Black);
            DrawGradient(cblend, 7, 25, this.Width - 14, 17, 90);
            cblend.Colors[0] = Color.FromArgb(0, 0, 0, 0);
            cblend.Colors[1] = Color.FromArgb(35, Color.Black);
            DrawGradient(cblend, 8, this.Height - 24, this.Width - 14, 17, 90);
            if (_ShowIcon == false)
            {
                G.DrawString(Text, Font, Brushes.White, new Point(6, 6));
            }
            else
            {
                G.DrawIcon(Parent.FindForm().Icon, new Rectangle(new Point(9, 5), new Size(16, 16)));
                G.DrawString(Text, Font, Brushes.White, new Point(28, 6));
            }

        }


        #endregion
    }
}
