// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="SimplyGray.cs" company="Zeroit Dev Technologies">
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
        #region 111. Simply Gray

        System.Drawing.Font SimplyGray_F = new System.Drawing.Font("Verdana", 8);
        SolidBrush SimplyGray_B = new SolidBrush(Color.DimGray);
        Color SimplyGray_Gr = Color.Gray;
        Color SimplyGray_LG = Color.LightGray;
        Color SimplyGray_Fc = Color.Fuchsia;

        public Pen _BorderColor1 = Pens.DarkGray;
        public Pen _BorderColor2 = Pens.Black;

        void SimplyGray_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Gray);
            DrawGradient(SimplyGray_LG, SimplyGray_Gr, 0, 0, Width, 20, 90);

            DrawBorders(_BorderColor2, _BorderColor1, ClientRectangle);
            DrawCorners(SimplyGray_Fc, ClientRectangle);

            DrawText(HorizontalAlignment.Left, ForeColor = Color.FromArgb(60, 60, 60), 3, 0);
            G.DrawString(_SubText, SimplyGray_F, SimplyGray_B, 4, 19);
        }

        #endregion
    }
}
