// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Gray.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using Zeroit.Framework.FormThemes.UIThemes.Utilities;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 62. Gray

        void Gray_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {

            G.Clear(Color.FromArgb(51, 51, 51));

            G.SmoothingMode = SmoothingMode.AntiAlias;

            G.FillPath(DesignFunctions.ToBrush(20, Color.Black), DesignFunctions.RoundRect(0, 0, Width - 1, Height - 2, 5));
            G.DrawPath(DesignFunctions.ToPen(50, Color.White), DesignFunctions.RoundRect(-1, -4, Width + 1, Height + 3, 5));
            G.DrawPath(DesignFunctions.ToPen(50, Color.Black), DesignFunctions.RoundRect(0, 0, Width - 1, Height - 2, 5));

            for (int i = 0; i <= 10; i++)
            {
                G.DrawPath(DesignFunctions.ToPen(50 / (i + 1), Color.Black), DesignFunctions.RoundRect(i, i, Width - 1 - (i * 2), Height - 2 - (i * 2), 5));
            }
        }


        #endregion
    }
}
