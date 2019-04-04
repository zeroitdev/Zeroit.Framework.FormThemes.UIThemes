// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Modern.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 84. Modern

        Color Modern_C1 = Color.FromArgb(240, 240, 240);
        Color Modern_C2 = Color.FromArgb(230, 230, 230);
        Color Modern_C3 = Color.FromArgb(190, 190, 190);
        private int _TitleHeight = 25;

        void Modern_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {
            using (Bitmap B = new Bitmap(Width, Height))
            {
                using (Graphics G = Graphics.FromImage(B))
                {
                    G.Clear(Color.FromArgb(245, 245, 245));

                    Utilities.Draw.Blend(G, Color.White, Modern_C2, Modern_C1, 0.7f, 1, 0, 0, Width, _TitleHeight);

                    G.FillRectangle(new SolidBrush(Color.FromArgb(80, 255, 255, 255)), 0, 0, Width, Convert.ToInt32(_TitleHeight / 2));
                    G.DrawRectangle(new Pen(Color.FromArgb(100, 255, 255, 255)), 1, 1, Width - 3, _TitleHeight - 2);

                    SizeF S = G.MeasureString(Text, Font);
                    float O = 6;
                    if (_TitleAlign == (HorizontalAlignment)2)
                        O = Width / 2 - S.Width / 2;
                    if (_TitleAlign == (HorizontalAlignment)1)
                        O = Width - S.Width - 6;
                    G.DrawString(Text, Font, new SolidBrush(Modern_C3), O, Convert.ToInt32(_TitleHeight / 2 - S.Height / 2));

                    G.DrawLine(new Pen(Modern_C3), 0, _TitleHeight, Width, _TitleHeight);
                    G.DrawLine(Pens.White, 0, _TitleHeight + 1, Width, _TitleHeight + 1);
                    G.DrawRectangle(new Pen(Modern_C3), 0, 0, Width - 1, Height - 1);

                    e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
                }
            }
        }



        #endregion
    }
}
