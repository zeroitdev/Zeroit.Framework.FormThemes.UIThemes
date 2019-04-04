// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="DarkMatterAlt.cs" company="Zeroit Dev Technologies">
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
        #region 32. Dark Matter Alt

        void DarkMatterAlt_PaintHook(PaintEventArgs e)
        {
            G.SmoothingMode = SmoothingMode.HighQuality;

            switch (_ThemeColor)
            {
                case ColorTheme.GammaRay:
                    //GammaRay
                    tGlow = Color.FromArgb(35, Color.LawnGreen);
                    tColor = Color.FromArgb(255, Color.LawnGreen);
                    break;
                case ColorTheme.RedShift:
                    //RedShift
                    tGlow = Color.FromArgb(35, Color.Red);
                    tColor = Color.FromArgb(255, Color.Red);
                    break;
                case ColorTheme.Subspace:
                    //SubSpace
                    tGlow = Color.FromArgb(35, Color.DodgerBlue);
                    tColor = Color.FromArgb(255, Color.DodgerBlue);
                    break;
                case ColorTheme.SolarFlare:
                    //SolarFlare
                    tGlow = Color.FromArgb(35, Color.Gold);
                    tColor = Color.FromArgb(255, Color.Gold);
                    break;
            }

            G.Clear(Color.FromArgb(39, 41, 41));
            DrawGradient(Color.FromArgb(100, 100, 100), Color.FromArgb(31, 31, 31), ClientRectangle, 90);
            DrawGradient(Color.FromArgb(53, 53, 54), Color.FromArgb(54, 54, 56), new Rectangle(2, 2, Width - 6, Height - 4), 90);
            DrawGradient(Color.FromArgb(31, 31, 31), Color.FromArgb(42, 42, 42), new Rectangle(2, 10, Width - 6, Height - 19), 90);
            G.FillRectangle(new SolidBrush(Color.FromArgb(15, 15, 17)), new Rectangle(3, 11, Width - 7, Height - 20));
            G.DrawLine(Pens.Black, 3, 11, 3, Height - 10);
            G.DrawLine(Pens.Black, Width - 4, 11, Width - 4, Height - 10);

            //DrawGradient(Color.FromArgb(109, 109, 111), Color.FromArgb(26, 26, 29), ClientRectangle, 45S) 'Border Out
            //DrawGradient(Color.FromArgb(58, 58, 60), Color.FromArgb(14, 14, 14), New Rectangle(2, 2, Width - 4, Height - 4), 45S)

            DrawBorders(new Pen(new SolidBrush(Color.Black)));

            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 4, 0);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 4, 1);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 4, -1);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 6, 0);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 6, 1);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 6, -1);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 5, 1);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 5, -1);

            DrawText(new SolidBrush(tColor), HorizontalAlignment.Left, 5, 0);
            DrawCorners(Color.Cyan);
        }

        #endregion
    }
}
