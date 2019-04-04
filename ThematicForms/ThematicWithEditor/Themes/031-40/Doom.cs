// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Doom.cs" company="Zeroit Dev Technologies">
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
        #region 36. Doom

        void Doom_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Black);
            G.SmoothingMode = SmoothingMode.HighQuality;
            //Form Border
            HatchBrush HB = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(33, 33, 33), Color.FromArgb(10, 10, 10));
            G.FillRectangle(HB, new Rectangle(0, 0, Width - 1, Height - 1));
            G.DrawRectangle(new Pen(Color.FromArgb(33, 33, 33)), 0, 0, Width - 1, Height - 1);
            //Form Interior
            G.FillRectangle(new SolidBrush(Color.FromArgb(30, 30, 30)), new Rectangle(6, 25, Width - 11, Height - 30));
            //Title Box
            HatchBrush HB3 = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(33, 33, 33), Color.FromArgb(22, 22, 22));
            Point[] p = {
                new Point(3, 15),
                new Point(20, 3),
                new Point(230, 3),
                new Point(230, 15),
                new Point(200, 35),
                new Point(3, 35)
            };
            G.FillPolygon(HB3, p);
            G.DrawPolygon(Pens.Black, p);
            //Icon and Form Title
            G.DrawString(Text, Font, new SolidBrush(ForeColor = Color.Red), new Point(40, 12));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(20, 12, 16, 16));
            //Draw Border
            DrawBorders(Pens.Black, 0);

        }

        #endregion
    }
}
