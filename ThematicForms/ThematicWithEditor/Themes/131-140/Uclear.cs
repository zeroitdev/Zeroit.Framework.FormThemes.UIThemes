// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Uclear.cs" company="Zeroit Dev Technologies">
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
        #region 133. Uclear

        void Uclear_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(246, 246, 246));
            LinearGradientBrush LB = new LinearGradientBrush(new Rectangle(new Point(1, 1), new Size(Width - 2, 25)), Color.FromArgb(35, 35, 35), Color.FromArgb(50, 50, 50), 90f);
            G.FillRectangle(LB, new Rectangle(new Point(1, 1), new Size(Width - 2, 25)));
            G.FillRectangle(new SolidBrush(Color.FromArgb(50, 50, 50)), new Rectangle(new Point(1, 1), new Size(Width - 2, 11)));
            G.DrawRectangle(new Pen(Color.FromArgb(35, 35, 35)), new Rectangle(0, 0, Width - 1, Height - 1));
            G.DrawLine(new Pen(Brushes.Black), new Point(0, 25), new Point(Width, 25));

            Font drawFont = new Font("Tahoma", 10, FontStyle.Regular);
            G.DrawString(Text, drawFont, new SolidBrush(Color.WhiteSmoke), new Rectangle(25, 0, Width - 1, 27), new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            });
        }

        #endregion
    }
}
