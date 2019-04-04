// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Bullion.cs" company="Zeroit Dev Technologies">
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
        #region 20. Bullion

        Graphics Bullion_G;
        Bitmap Bullion_B;
        Rectangle Bullion_R1;
        Rectangle Bullion_R2;
        Color Bullion_C1;
        Color Bullion_C2;
        Color Bullion_C3;
        Pen Bullion_P1;
        Pen Bullion_P2;
        Pen Bullion_P3;
        Pen Bullion_P4;
        SolidBrush Bullion_B1;
        LinearGradientBrush Bullion_B2;

        LinearGradientBrush Bullion_B3;

        void Bullion_OnPaint(PaintEventArgs e)
        {
            Bullion_C1 = Color.FromArgb(248, 248, 248);
            //Background
            Bullion_C2 = Color.FromArgb(255, 255, 255);
            //Highlight
            Bullion_C3 = Color.FromArgb(235, 235, 235);
            //Shadow
            Bullion_P1 = new Pen(Color.FromArgb(215, 215, 215));
            //Border
            Bullion_P4 = new Pen(Color.FromArgb(230, 230, 230));
            //Diagnol Lines
            Bullion_P2 = new Pen(Bullion_C1);
            Bullion_P3 = new Pen(Bullion_C2);
            Bullion_B1 = new SolidBrush(Color.FromArgb(170, 170, 170));

            Bullion_R1 = new Rectangle(0, 2, Width, 18);
            Bullion_R2 = new Rectangle(0, 21, Width, 10);
            Bullion_B2 = new LinearGradientBrush(Bullion_R1, Bullion_C1, Bullion_C3, 90f);
            Bullion_B3 = new LinearGradientBrush(Bullion_R2, Color.FromArgb(18, 0, 0, 0), Color.Transparent, 90f);

            Bullion_B = new Bitmap(Width, Height);
            Bullion_G = Graphics.FromImage(Bullion_B);

            Bullion_G.Clear(Bullion_C1);

            for (int I = 0; I <= Width + 17; I += 4)
            {
                Bullion_G.DrawLine(Bullion_P4, I, 21, I - 17, 37);
                Bullion_G.DrawLine(Bullion_P4, I - 1, 21, I - 16, 37);
            }
            Bullion_G.FillRectangle(Bullion_B3, Bullion_R2);

            Bullion_G.FillRectangle(B2, R1);
            Bullion_G.DrawString(Text, Font, Bullion_B1, 5, 5);

            Bullion_G.DrawRectangle(Bullion_P2, 1, 1, Width - 3, 19);
            Bullion_G.DrawRectangle(Bullion_P3, 1, 39, Width - 3, Height - 41);

            Bullion_G.DrawRectangle(Bullion_P1, 0, 0, Width - 1, Height - 1);
            Bullion_G.DrawLine(Bullion_P1, 0, 21, Width, 21);
            Bullion_G.DrawLine(Bullion_P1, 0, 38, Width, 38);

            e.Graphics.DrawImage(Bullion_B, 0, 0);
            Bullion_G.Dispose();
            Bullion_B.Dispose();
        }

        #endregion
    }
}
