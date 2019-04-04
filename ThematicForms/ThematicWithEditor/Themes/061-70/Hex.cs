// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Hex.cs" company="Zeroit Dev Technologies">
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
        #region 66. Hex

        void Hex_PaintHook(PaintEventArgs e)
        {

            G.Clear(Color.FromArgb(47, 51, 60));
            G.FillRectangle(new SolidBrush(Color.FromArgb(30, 33, 40)), new Rectangle(0, _Header, Width, Height - _Header));
            StringFormat _StringF = new StringFormat();
            _StringF.Alignment = StringAlignment.Center;
            _StringF.LineAlignment = StringAlignment.Center;
            G.DrawString(Text, new Font("Segoe UI", 11), new SolidBrush(Color.FromArgb(236, 95, 75)), new RectangleF(0, 0, Width, _Header), _StringF);
        }

        #endregion
    }
}
