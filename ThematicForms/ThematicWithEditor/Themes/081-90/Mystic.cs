// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Mystic.cs" company="Zeroit Dev Technologies">
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
        #region 87. Mystic

        private int Mystic_Header = 36;

        void Mystic_PaintHook(PaintEventArgs e)
        {

            G.Clear(Color.FromArgb(44, 51, 62));
            G.FillRectangle(new LinearGradientBrush(new Point(0, 0), new Point(0, Mystic_Header), Color.FromArgb(29, 36, 44), Color.FromArgb(22, 29, 35)), new Rectangle(0, 0, Width, _Header));

            G.FillRectangle(Brushes.Fuchsia, new Rectangle(0, 0, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(1, 0, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(0, 1, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(Width - 1, 0, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(Width - 1, 1, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(Width - 2, 0, 1, 1));

            StringFormat _StringF = new StringFormat();
            _StringF.Alignment = StringAlignment.Center;
            _StringF.LineAlignment = StringAlignment.Center;
            G.DrawString(Text, new Font("Segoe UI", 11), new SolidBrush(Color.FromArgb(0, 206, 153)), new RectangleF(0, 0, Width, _Header), _StringF);

        }


        #endregion
    }
}
