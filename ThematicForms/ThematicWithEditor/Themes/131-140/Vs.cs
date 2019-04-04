// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Vs.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 138. Vs

        Color Vs_C1 = Color.FromArgb(249, 245, 226);
        Color Vs_C2 = Color.FromArgb(255, 232, 165);
        Color Vs_C3 = Color.FromArgb(64, 90, 127);
        Image Vs_Tile;

        void Vs_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {
            _TitleHeight = 23;
            using (Bitmap B = new Bitmap(3, 3))
            {
                using (Graphics G = Graphics.FromImage(B))
                {
                    G.Clear(Color.FromArgb(53, 67, 88));
                    G.DrawLine(new Pen(Color.FromArgb(33, 46, 67)), 0, 0, 2, 2);
                    Vs_Tile = (Bitmap)B.Clone();
                }
            }

            using (Bitmap B = new Bitmap(Width, Height))
            {
                using (Graphics G = Graphics.FromImage(B))
                {

                    using (TextureBrush T = new TextureBrush(Vs_Tile, 0))
                    {
                        G.FillRectangle(T, 0, _TitleHeight, Width, Height - _TitleHeight);
                    }
                    Utilities.Draw.Blend(G, Color.Transparent, Color.Transparent, Vs_C3, 0.1f, 1, 0, 0, Width, Height - _TitleHeight * 2);
                    G.FillRectangle(new SolidBrush(Vs_C3), 0, Height - _TitleHeight * 2, Width, _TitleHeight * 2);

                    Utilities.Draw.Gradient(G, Vs_C1, Vs_C2, 0, 0, Width, _TitleHeight);
                    G.FillRectangle(new SolidBrush(Color.FromArgb(100, 255, 255, 255)), 0, 0, Width, Convert.ToInt32(_TitleHeight / 2));

                    G.DrawRectangle(new Pen(Vs_C2, 2), 1, _TitleHeight - 1, Width - 2, Height - _TitleHeight);
                    G.DrawArc(new Pen(Color.Fuchsia, 2), -1, -1, 9, 9, 180, 90);
                    G.DrawArc(new Pen(Color.Fuchsia, 2), Width - 9, -1, 9, 9, 270, 90);

                    G.TextRenderingHint = (TextRenderingHint)5;
                    SizeF S = G.MeasureString(Text, Font);
                    int O = 6;
                    if (_TitleAlign == (HorizontalAlignment)2)
                        O = (int)Width / 2 - (int)S.Width / 2;
                    if (_TitleAlign == (HorizontalAlignment)1)
                        O = Width - (int)S.Width - 6;
                    G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(111, 88, 38)), O, Convert.ToInt32(_TitleHeight / 2 - S.Height / 2));

                    e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
                }
            }
        }


        #endregion
    }
}
