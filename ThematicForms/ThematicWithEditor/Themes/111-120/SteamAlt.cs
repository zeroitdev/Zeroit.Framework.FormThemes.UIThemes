// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="SteamAlt.cs" company="Zeroit Dev Technologies">
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
        #region 120. SteamAlt

        void SteamAlt_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(44, 42, 40));

            HatchBrush T = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(20, 19, 19), Color.FromArgb(46, 44, 42));
            G.FillRectangle(T, ClientRectangle);
            DrawGradient(Color.Transparent, Color.FromArgb(29, 28, 27), new Rectangle(0, 0 - Height / 3 - Height / 9, Width, Height));
            G.FillRectangle(new SolidBrush(Color.FromArgb(29, 28, 28)), new Rectangle(0, Height / 3 + Height / 3 - Height / 9, Width, Height));


            DrawBorders(new Pen(new SolidBrush(Color.FromArgb(0, 0, 0))));
            DrawText(new SolidBrush(Color.FromArgb(195, 193, 191)), HorizontalAlignment.Left, 4, 0);

        }

        #endregion
    }
}
