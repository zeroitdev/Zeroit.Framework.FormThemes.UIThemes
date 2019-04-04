// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Secure.cs" company="Zeroit Dev Technologies">
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
        #region 108. Secure

        void Secure_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Black);
            DrawBG(Color.DimGray, ClientRectangle);
            DrawGradient(Color.DimGray, Color.Black, 0, 0, Width, 20, 90);
            DrawCorners(Color.Fuchsia, ClientRectangle);
            DrawText(HorizontalAlignment.Center, Color.White, 3);
            DrawBorders(Pens.Transparent, Pens.LightGray, ClientRectangle);

        }

        #endregion
    }
}
