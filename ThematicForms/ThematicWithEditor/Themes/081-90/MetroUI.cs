// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="MetroUI.cs" company="Zeroit Dev Technologies">
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
        #region 82. MetroUI

        void MetroUI_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(53, 157, 181));

            G.FillRectangle(new SolidBrush(Color.White), new Rectangle(1, 1, Width - 2, Height - 24));
            G.FillRectangle(new SolidBrush(Color.FromArgb(53, 157, 181)), new Rectangle(0, 50, 7, 50));


            // G.DrawEllipse(circlec, New Rectangle(Width - 7, Height - 7, 3, 3))
            G.FillEllipse(new SolidBrush(Color.White), new Rectangle(Width - 7, Height - 7, 3, 3));

            //G.DrawEllipse(circlec, New Rectangle(Width - 13, Height - 7, 3, 3))
            G.FillEllipse(new SolidBrush(Color.White), new Rectangle(Width - 13, Height - 7, 3, 3));

            //  G.DrawEllipse(circlec, New Rectangle(Width - 19, Height - 7, 3, 3))
            G.FillEllipse(new SolidBrush(Color.White), new Rectangle(Width - 19, Height - 7, 3, 3));

            //  G.DrawEllipse(circlec, New Rectangle(Width - 7, Height - 13, 3, 3))
            G.FillEllipse(new SolidBrush(Color.White), new Rectangle(Width - 7, Height - 13, 3, 3));

            // G.DrawEllipse(circlec, New Rectangle(Width - 7, Height - 19, 3, 3))
            G.FillEllipse(new SolidBrush(Color.White), new Rectangle(Width - 7, Height - 19, 3, 3));

            //  G.DrawEllipse(circlec, New Rectangle(Width - 13, Height - 13, 3, 3))
            G.FillEllipse(new SolidBrush(Color.White), new Rectangle(Width - 13, Height - 13, 3, 3));


            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(10, 5, 23, 23));
            DrawText(new SolidBrush(Color.Black), HorizontalAlignment.Left, 44, 2);
            G.DrawString("|", Font, new SolidBrush(Color.Black), new Point(37, -3));

        }

        #endregion
    }
}
