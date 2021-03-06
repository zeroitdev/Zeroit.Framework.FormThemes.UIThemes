﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Qube.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Form control with themes.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
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
