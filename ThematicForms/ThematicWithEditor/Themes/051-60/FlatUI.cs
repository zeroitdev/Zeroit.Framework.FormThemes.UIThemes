// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="FlatUI.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 52. FlatUI
        #region " Colors"

        #region " Dark Colors"

        private Color _HeaderColor = Color.FromArgb(45, 47, 49);
        private Color _BaseColor = Color.FromArgb(60, 70, 73);
        private Color _BorderColor = Color.FromArgb(53, 58, 60);

        private Color TextColor = Color.FromArgb(234, 234, 234);
        #endregion

        #region " Light Colors"

        private Color _HeaderLight = Color.FromArgb(171, 171, 172);
        private Color _BaseLight = Color.FromArgb(196, 199, 200);

        public Color TextLight = Color.FromArgb(45, 47, 49);
        #endregion
        private int FlatUI_W;
        private int FlatUI_H;
        private Bitmap FlatUI_B;

        static internal Color _FlatColor = Color.FromArgb(35, 168, 109);
        static internal StringFormat NearSF = new StringFormat
        {
            Alignment = StringAlignment.Near,
            LineAlignment = StringAlignment.Near
        };
        static internal StringFormat CenterSF = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center

        };
        #endregion
        void FlatUI_Paint(PaintEventArgs e)
        {
            FlatUI_B = new Bitmap(Width, Height);
            G = Graphics.FromImage(FlatUI_B);
            FlatUI_W = Width;
            FlatUI_H = Height;

            Rectangle Base = new Rectangle(0, 0, FlatUI_W, FlatUI_H);
            Rectangle Header = new Rectangle(0, 0, FlatUI_W, 50);

            var _with2 = G;
            _with2.SmoothingMode = SmoothingMode.HighQuality;
            _with2.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            _with2.Clear(Color.White);

            //-- Base
            _with2.FillRectangle(new SolidBrush(_BaseColor), Base);

            //-- Header
            _with2.FillRectangle(new SolidBrush(_HeaderColor), Header);

            //-- Logo
            _with2.FillRectangle(new SolidBrush(Color.FromArgb(243, 243, 243)), new Rectangle(8, 16, 4, 18));
            _with2.FillRectangle(new SolidBrush(_FlatColor), 16, 16, 4, 18);
            _with2.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(26, 15, FlatUI_W, FlatUI_H), NearSF);

            //-- Border
            _with2.DrawRectangle(new Pen(_BorderColor), Base);

            e.Graphics.InterpolationMode = (InterpolationMode)7;
            e.Graphics.DrawImageUnscaled(FlatUI_B, 0, 0);
            //G.Dispose();

            FlatUI_B.Dispose();
        }

        #endregion
    }
}
