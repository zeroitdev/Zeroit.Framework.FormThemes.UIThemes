// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Advantium.cs" company="Zeroit Dev Technologies">
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
        #region 3. Advantium

        #region Private Field

        Color Advantium_borderColor = Color.Black;

        Color Advantium_borderInner = Color.FromArgb(65, 65, 65);

        #endregion



        void Advantium_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(40, 40, 40));
            DrawGradient(Color.FromArgb(20, 20, 20), Color.FromArgb(40, 40, 40), new Rectangle(0, 0, Width, 35), 90);

            HatchBrush T = new HatchBrush(HatchStyle.Percent10, Color.FromArgb(25, 25, 25), Color.FromArgb(35, 35, 35));
            G.FillRectangle(T, new Rectangle(11, 25, Width - 23, Height - 36));

            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(22, 22, 22))), new Rectangle(11, 25, Width - 23, Height - 36));
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(40, 40, 40))), new Rectangle(12, 26, Width - 25, Height - 38));
            DrawCorners(Color.FromArgb(40, 40, 40), new Rectangle(11, 25, Width - 22, Height - 35));

            DrawBorders(new Pen(new SolidBrush(Advantium_borderInner)), 1);
            DrawBorders(new Pen(new SolidBrush(Advantium_borderColor)));
            DrawCorners(TransparencyKey);
            DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Left, 15, -3);
        }

        #endregion
    }
}
