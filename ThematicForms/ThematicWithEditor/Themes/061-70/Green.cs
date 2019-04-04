// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Green.cs" company="Zeroit Dev Technologies">
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
        #region 63. Green

        Bitmap Green_B;
        Rectangle Green_R1;
        Rectangle Green_R2;
        Color Green_C1 = Color.FromArgb(41, 57, 34);
        Color Green_C2 = Color.FromArgb(190, 255, 159);
        Color Green_C3 = Color.FromArgb(22, 22, 22);
        Color Green_C4 = Color.FromArgb(20, 107, 18);
        Pen Green_P1 = new Pen(Color.FromArgb(20, 107, 18));
        Pen Green_P2 = new Pen(Color.FromArgb(41, 57, 34));
        Pen Green_P3 = new Pen(Color.FromArgb(190, 255, 159));
        SolidBrush Green_B1 = new SolidBrush(Color.FromArgb(190, 255, 159));
        LinearGradientBrush Green_B2;

        LinearGradientBrush Green_B3;

        void Green_PaintHook(PaintEventArgs e)
        {
            Green_B = new Bitmap(Width, Height);
            G = Graphics.FromImage(Green_B);

            Green_R1 = new Rectangle(0, 2, Width, 18);
            Green_R2 = new Rectangle(0, 21, Width, 10);
            Green_B2 = new LinearGradientBrush(Green_R1, Green_C1, Green_C3, 90f);
            Green_B3 = new LinearGradientBrush(Green_R2, Color.FromArgb(70, 0, 0, 0), Color.Transparent, 90f);


            G.Clear(Green_C1);

            for (int I = 0; I <= Width + 17; I += 4)
            {
                G.DrawLine(Green_P1, I, 21, I - 17, 37);
                G.DrawLine(Green_P1, I - 1, 21, I - 16, 37);
            }
            G.FillRectangle(Green_B3, Green_R2);

            G.FillRectangle(Green_B2, Green_R1);
            G.DrawString(Text, Font, Green_B1, 5, 5);

            G.DrawRectangle(Green_P2, 1, 1, Width - 3, 19);
            G.DrawRectangle(Green_P3, 1, 39, Width - 3, Height - 41);

            G.DrawRectangle(Green_P1, 0, 0, Width - 1, Height - 1);
            G.DrawLine(Green_P1, 0, 21, Width, 21);
            G.DrawLine(Green_P1, 0, 38, Width, 38);

            e.Graphics.DrawImage(Green_B, 0, 0);
            //G.Dispose();
            Green_B.Dispose();
        }


        #endregion
    }
}
