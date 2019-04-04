// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Sugar.cs" company="Zeroit Dev Technologies">
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
        #region 124. Sugar

        void Sugar_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(190, 210, 217));
            HatchBrush HB = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(30, Color.White), Color.Transparent);

            G.FillRectangle(new SolidBrush(BackColor), new Rectangle(6, 36, Width - 13, Height - 43));
            G.FillRectangle(HB, new Rectangle(0, 0, Width - 1, Height - 1));
            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(Color.FromArgb(49, 51, 48)), new Point(35, 10));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(10, 10, 16, 16));
            DrawCorners(Color.Fuchsia);
        }

        #endregion
    }
}
