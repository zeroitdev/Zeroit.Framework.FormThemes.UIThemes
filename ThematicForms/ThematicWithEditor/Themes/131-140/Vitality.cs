// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Vitality.cs" company="Zeroit Dev Technologies">
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
        #region 137. Vitality

        Color Vitality_G1 = Color.White;
        Color Vitality_G2 = Color.LightGray;

        Color Vitality_BG = Color.FromArgb(240, 240, 240);

        void Vitality_PaintHook(PaintEventArgs e)
        {
            G.Clear(Vitality_BG);

            LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(new Point(1, 1), new Size(this.Width - 2, 23)), Vitality_G1, Vitality_G2, 90f);
            G.FillRectangle(LGB, new Rectangle(new Point(1, 1), new Size(this.Width - 2, 23)));

            G.DrawLine(Pens.LightGray, 1, 25, this.Width - 2, 25);
            G.DrawLine(Pens.White, 1, 26, this.Width - 2, 26);

            DrawCorners(TransparencyKey);
            DrawBorders(Pens.LightGray, 1);

            Rectangle IconRec = new Rectangle(3, 3, 20, 20);
            G.DrawIcon(ParentForm.Icon, IconRec);

            G.DrawString(ParentForm.Text, new Font("Segoe UI", 9), Brushes.Gray, new Point(25, 5));
        }

        #endregion
    }
}
