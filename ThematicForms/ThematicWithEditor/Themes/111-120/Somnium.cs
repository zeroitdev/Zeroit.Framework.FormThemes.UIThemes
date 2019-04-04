// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Somnium.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 117. Somnium

        private Color Somnium_C1 = Color.White;
        private Color Somnium_C2 = Color.FromArgb(50, 50, 50);
        private Color Somnium_C3 = Color.FromArgb(0, 0, 0);
        private Color Somnium_C4 = Color.Gray;
        private Color Somnium_C5 = Color.LightGray;
        private Pen Somnium_P1 = Pens.Black;
        private Brush Somnium_B1 = new SolidBrush(Color.FromArgb(15, 15, 15));
        private Brush Somnium_B2 = new SolidBrush(Color.FromArgb(50, Color.White));
        private Brush Somnium_B3 = new SolidBrush(Color.White);
        private Brush Somnium_B4 = new SolidBrush(Color.FromArgb(30, Color.White));
        private HatchBrush Somnium_HB1;


        void Somnium_PaintHook(PaintEventArgs e)
        {
            Somnium_HB1 = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(15, 15, 15));

            G.Clear(Somnium_C1);
            //BackGround'
            G.FillRectangle(Somnium_HB1, 0, 0, Width, Height);

            //Top'
            DrawGradient(Somnium_C2, Somnium_C3, 0, 0, Width, 15, 90);
            G.DrawRectangle(Somnium_P1, 0, 0, Width, 15);

            //Bottom'
            G.FillRectangle(Somnium_B1, 0, Convert.ToInt32(Height - 11), Width, 10);
            G.DrawRectangle(Somnium_P1, 0, Convert.ToInt32(Height - 11), Width, 10);
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(30, 30, 30))), 14, Convert.ToInt32(Height - 10), Convert.ToInt32(Width - 29), 8);
            //Left Side'
            //Left'
            G.FillRectangle(Somnium_B1, 0, 0, 5, Convert.ToInt32(Height - 1));
            G.DrawRectangle(Somnium_P1, 0, 0, 5, Convert.ToInt32(Height - 1));
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(30, 30, 30))), 1, 1, 3, Convert.ToInt32(Height - 3));
            //Middle'
            DrawGradient(Somnium_C4, Somnium_C5, 5, 15, 3, Convert.ToInt32(Height - 16), 180);
            G.DrawRectangle(Somnium_P1, 5, 15, 3, Convert.ToInt32(Height - 16));
            //Right'
            G.FillRectangle(Somnium_B1, 8, 15, 5, Convert.ToInt32(Height - 16));
            G.DrawRectangle(Somnium_P1, 8, 15, 5, Convert.ToInt32(Height - 16));
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(30, 30, 30))), 9, 16, 3, Convert.ToInt32(Height - 18));

            //Right Side'
            //Right'
            G.FillRectangle(Somnium_B1, Convert.ToInt32(Width - 6), 0, 5, Convert.ToInt32(Height - 1));
            G.DrawRectangle(Somnium_P1, Convert.ToInt32(Width - 6), 0, 5, Convert.ToInt32(Height - 1));
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(30, 30, 30))), Convert.ToInt32(Width - 5), 1, 3, Convert.ToInt32(Height - 3));
            //Middle'
            DrawGradient(Somnium_C4, Somnium_C5, Convert.ToInt32(Width - 9), 15, 3, Convert.ToInt32(Height - 16), 180);
            G.DrawRectangle(Somnium_P1, Convert.ToInt32(Width - 9), 15, 3, Convert.ToInt32(Height - 16));
            //Left'
            G.FillRectangle(Somnium_B1, Convert.ToInt32(Width - 14), 15, 5, Convert.ToInt32(Height - 16));
            G.DrawRectangle(Somnium_P1, Convert.ToInt32(Width - 14), 15, 5, Convert.ToInt32(Height - 16));
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(30, 30, 30))), Convert.ToInt32(Width - 13), 16, 3, Convert.ToInt32(Height - 18));
            //Top Gloss'
            G.FillRectangle(Somnium_B2, 0, 0, Width, 5);

            //Bottom Gloss'
            G.FillRectangle(Somnium_B4, 0, Convert.ToInt32(Height - 3), Width, 3);

            DrawText(Somnium_B3, HorizontalAlignment.Center, 0, 3);

        }

        #endregion
    }
}
