// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Anom.cs" company="Zeroit Dev Technologies">
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
        #region 5. Anom

        void Anom_PaintHook(PaintEventArgs e)
        {
            G.Clear(border);
            LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(1, 1, Width - 2, Height - 2), Color.FromArgb(255, 222, 222, 222), Color.FromArgb(255, 170, 170, 170), 45f);
            HatchBrush HB = new HatchBrush(HatchStyle.LightDownwardDiagonal, Color.FromArgb(100, Color.Gray), Color.Transparent);
            G.FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 0, Width - 1, Height - 1));
            G.FillRectangle(LGB, new Rectangle(1, 1, Width - 2, Height - 2));
            G.FillRectangle(HB, new Rectangle(1, 1, Width - 2, Height - 2));
            G.FillRectangle(new SolidBrush(Color.Black), new Rectangle(6, 36, Width - 12, Height - 43));
            G.FillRectangle(new SolidBrush(BackColor), new Rectangle(7, 37, Width - 14, Height - 45));
            int TextXPos = 30;
            if ((Parent.FindForm().ShowIcon))
            {
                TextXPos = 30;
            }
            else
            {
                TextXPos = 6;
            }
            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(ForeColor), new Point(TextXPos, 10));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(10, 10, 16, 16));
        }

        #endregion
    }
}
