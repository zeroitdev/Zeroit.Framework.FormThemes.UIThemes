// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Positron.cs" company="Zeroit Dev Technologies">
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
        #region 98. Positron


        private Color Positron_BG = Color.FromArgb(208, 208, 208);
        private Color Positron_GT = Color.FromArgb(100, 100, 100);
        private Color Positron_GB = Color.FromArgb(200, 200, 200);
        private Brush Positron_TB = new SolidBrush(Color.FromArgb(100, 100, 100));
        private Brush Positron_Black = Brushes.Black;
        private Brush Positron_H = new SolidBrush(Color.FromArgb(210, 210, 210));
        private Pen Positron_b = new Pen(Color.FromArgb(200, 200, 200));
        private Pen Positron_IB = new Pen(Color.FromArgb(200, 200, 200));

        private Pen Positron_PB = new Pen(Color.FromArgb(150, 150, 150));

        void Positron_PaintHook(PaintEventArgs e)
        {
            HatchBrush HBM = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(30, Color.White), Color.Transparent);
            G.Clear(Positron_BG);
            G.FillRectangle(HBM, new Rectangle(0, 0, Width - 1, Height - 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(225, 225, 225)), new Rectangle(8, 27, Width - 16, Height - 35));
            G.DrawString(Text, Font, Positron_TB, new Point(29, 7));
            G.DrawIcon(ParentForm.Icon, new Rectangle(7, 4, 19, 20));
            DrawBorders(Positron_PB);
            DrawBorders(Positron_IB, 1);

        }

        #endregion
    }
}
