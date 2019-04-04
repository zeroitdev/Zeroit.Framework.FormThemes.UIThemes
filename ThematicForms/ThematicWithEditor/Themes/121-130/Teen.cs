// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Teen.cs" company="Zeroit Dev Technologies">
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
        #region 127. Teen

        void Teen_PaintHook(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);

            G.Clear(Color.FromArgb(50, 50, 50));
            G.DrawLine(new Pen(Color.DodgerBlue, 2), new Point(0, 30), new Point(Width, 30));
            G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(8, 6, Width - 1, Height - 1), StringFormat.GenericDefault);
            G.DrawLine(new Pen(Color.DodgerBlue, 3), new Point(8, 27), new Point(8 + (int)G.MeasureString(Text, Font).Width, 27));

            G.DrawRectangle(new Pen(Color.FromArgb(100, 100, 100)), new Rectangle(0, 0, Width - 1, Height - 1));

            e.Graphics.DrawImage(B, new Point(0, 0));
            G.Dispose();
            B.Dispose();
        }

        #endregion
    }
}
