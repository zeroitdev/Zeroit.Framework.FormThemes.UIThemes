// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Origin.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 94. Origin

        void Origin_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(39, 38, 38));
            // Dim HB As New HatchBrush(HatchStyle.Percent80, Color.FromArgb(45, Color.FromArgb(39, 38, 38)), Color.Transparent)
            G.FillRectangle(new SolidBrush(BackColor), new Rectangle(3, 26, Width - 6, Height - 29));
            //.FillRectangle(HB, New Rectangle(6, 26, Width - 12, Height - 33))
            G.DrawString(Parent.FindForm().Text, Font, Brushes.White, new Point(27, 3));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(10, 3, 16, 16));
            DrawCorners(Color.Transparent);
        }

        #endregion
    }
}
