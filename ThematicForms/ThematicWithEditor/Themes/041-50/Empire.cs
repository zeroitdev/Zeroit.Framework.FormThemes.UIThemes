// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Empire.cs" company="Zeroit Dev Technologies">
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
        #region 44. Empire

        Color EmpirePurple = Color.FromArgb(55, 173, 242);
        void Empire_PaintHook(PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.Clear(Color.FromArgb(200, 200, 200));

            LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(0, 0, Width, 37), Color.FromArgb(36, 36, 36), Color.FromArgb(25, 25, 25), 90f);
            G.FillRectangle(LGB, LGB.Rectangle);
            //LGB = New LinearGradientBrush(New Rectangle(0, 41, Width, 4), Color.FromArgb(80, Color.Black), Color.Transparent, 90.0F)
            //e.Graphics.FillRectangle(LGB, LGB.Rectangle)

            G.FillRectangle(new SolidBrush(EmpirePurple), new Rectangle(13, 31, (int)G.MeasureString(Text, new Font("Segoe UI", 11)).Width + 6, 4));
            G.FillRectangle(new SolidBrush(EmpirePurple), new Rectangle(0, 35, Width, 2));

            G.DrawString(Text, new Font("Segoe UI", 11), Brushes.Black, new Point(15, 9));
            G.DrawString(Text, new Font("Segoe UI", 11), Brushes.White, new Point(15, 8));

        }


        #endregion
    }
}
