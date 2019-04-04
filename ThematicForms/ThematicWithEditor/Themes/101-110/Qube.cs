// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Qube.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 101. Qube

        private int _LeftPanelSize = 4;

        void Qube_PaintHook(PaintEventArgs e)
        {

            G.Clear(Color.Fuchsia);

            G.SmoothingMode = SmoothingMode.Default;
            G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            G.InterpolationMode = InterpolationMode.HighQualityBicubic;


            GraphicsPath GP2 = CreateRound(new Rectangle(-1, -1, Width, Height + 2), 1);
            G.FillPath(new SolidBrush(Color.FromArgb(255, 255, 255)), GP2);
            G.SmoothingMode = SmoothingMode.HighQuality;

            G.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath GP3 = CreateRound(new Rectangle(-1, -1, Width / _LeftPanelSize, Height + 2), 1);
            G.FillPath(new SolidBrush(Color.FromArgb(68, 76, 99)), GP3);
            G.SmoothingMode = SmoothingMode.HighQuality;


        }


        #endregion
    }
}
