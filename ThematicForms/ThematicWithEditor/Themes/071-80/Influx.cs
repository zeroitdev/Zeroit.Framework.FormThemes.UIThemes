// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Influx.cs" company="Zeroit Dev Technologies">
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
        #region 71. Influx

        void Influx_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(53, 53, 53));
            //Draw form border
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(53, 53, 53))), new Rectangle(0, 0, Width - 1, Height - 1));
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(66, 66, 66))), new Rectangle(1, 1, Width - 3, Height - 3));
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(79, 79, 79)), 2), new Rectangle(3, 3, Width - 6, Height - 6));
            //Draw form content
            HatchBrush HB = new HatchBrush(HatchStyle.Percent20, Color.FromArgb(83, 83, 83), BackColor);
            G.FillRectangle(HB, new Rectangle(4, 15, Width - 8, Height - 19));
            //Draw title bar
            LinearGradientBrush TitleTopGradient = new LinearGradientBrush(new Rectangle(4, 4, Width - 8, 11), Color.FromArgb(79, 79, 79), Color.FromArgb(87, 87, 87), (float)0);
            TitleTopGradient.SetBlendTriangularShape(0.5f, 1f);
            G.FillRectangle(TitleTopGradient, new Rectangle(4, 4, Width - 8, 11));
            LinearGradientBrush TitleBottomGradient = new LinearGradientBrush(new Rectangle(4, 15, Width - 8, 11), Color.FromArgb(150, 67, 67, 67), Color.FromArgb(150, 73, 73, 73), (float)0);
            TitleBottomGradient.SetBlendTriangularShape(0.5f, 1f);
            G.FillRectangle(TitleBottomGradient, new Rectangle(4, 15, Width - 8, 11));
            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(ForeColor), new Point(30, 7));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(9, 6, 16, 16));
            //DrawCorners(Color.Fuchsia)
        }

        #endregion
    }
}
