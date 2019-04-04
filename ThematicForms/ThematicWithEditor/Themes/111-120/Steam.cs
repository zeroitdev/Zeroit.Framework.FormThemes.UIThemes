// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Steam.cs" company="Zeroit Dev Technologies">
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
        #region 119. Steam

        void Steam_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(56, 54, 53));
            DrawGradient(Color.Black, Color.FromArgb(76, 108, 139), ClientRectangle, 65);
            G.FillRectangle(new SolidBrush(Color.FromArgb(56, 54, 53)), new Rectangle(1, 1, Width - 2, Height - 2));
            DrawGradient(Color.FromArgb(71, 68, 66), Color.FromArgb(57, 55, 54), new Rectangle(1, 1, Width - 2, 35), 90);
            DrawText(new SolidBrush(Color.FromArgb(195, 193, 191)), HorizontalAlignment.Left, 4, 0);
        }

        #endregion
    }
}
