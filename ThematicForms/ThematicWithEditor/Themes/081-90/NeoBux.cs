// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="NeoBux.cs" company="Zeroit Dev Technologies">
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
        #region 88. NeoBux

        void NeoBux_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Gray);

            //MenuTop
            G.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 242)), new Rectangle(1, 1, Width - 2, Height - 2));

            //Border
            G.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle(1, 35, Width - 2, Height - 38));

            //MainForm
            G.FillRectangle(new SolidBrush(Color.WhiteSmoke), new Rectangle(1, 36, Width - 2, Height - 39));


            //ColorLine
            LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(1, 36, Width - 2, Height - 255), Color.FromArgb(0, 177, 253), Color.FromArgb(46, 202, 56), 180f);
            G.DrawRectangle(new Pen(Color.LightGray), 1, 35, Width - 3, 4);
            G.FillRectangle(LGB, new Rectangle(1, 35, Width - 2, 4));

            //MenuItems
            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(ForeColor), new Point(35, 10));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(10, 10, 16, 16));
            DrawCorners(Color.Fuchsia);

        }

        #endregion
    }
}
