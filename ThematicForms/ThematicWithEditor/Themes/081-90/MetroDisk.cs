// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="MetroDisk.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 83. MetroDisk
        private bool MetroDisk__Theme;
        private int MetroDisk_W;
        private int MetroDisk_H;
        private Bitmap MetroDisk_B;
        private Color MetroDisk__MDcolor = Color.FromArgb(45, 150, 45);
        private string MetroDisk__text = "";

        #region " Dark Colors"

        private Color MetroDisk__HeaderColor = Color.FromArgb(60, 200, 80);
        private Color MetroDisk__BaseColor = Color.FromArgb(60, 70, 73);
        private Color MetroDisk__BorderColor = Color.FromArgb(53, 58, 60);

        private Color MetroDisk_TextColor = Color.FromArgb(234, 234, 234);
        #endregion

        #region " Light Colors"

        private Color MetroDisk__HeaderLight = Color.FromArgb(171, 171, 172);
        private Color MetroDisk__BaseLight = Color.FromArgb(196, 199, 200);

        public Color MetroDisk_TextLight = Color.FromArgb(45, 47, 49);


        #endregion

        [Category("MetroDisk Theme")]
        public bool MetrodiskTheme
        {
            get { return MetroDisk__Theme; }
            set
            {
                MetroDisk__Theme = value;
                Invalidate();
            }
        }

        void MetroDisk_PaintHook(PaintEventArgs e)
        {
            if (MetroDisk__Theme == true)
            {
                //light
                MetroDisk__HeaderColor = Color.FromArgb(255, 255, 255);
                MetroDisk__BaseColor = Color.FromArgb(255, 255, 255);
                MetroDisk__BorderColor = Color.FromArgb(0, 0, 0);
                MetroDisk__BorderColor = Color.FromArgb(0, 0, 0);

                ForeColor = Color.Black;
            }
            else
            {
                //dark
                MetroDisk__HeaderColor = Color.FromArgb(0, 0, 0);
                MetroDisk__BaseColor = Color.FromArgb(0, 0, 0);
                MetroDisk__BorderColor = Color.FromArgb(200, 200, 200);
                MetroDisk__BorderColor = Color.FromArgb(200, 200, 200);
            }

            MetroDisk_B = new Bitmap(Width, Height);
            G = Graphics.FromImage(MetroDisk_B);
            MetroDisk_W = Width;
            MetroDisk_H = Height;
            Rectangle MetroDisk_Base = new Rectangle(0, 0, MetroDisk_W, MetroDisk_H);
            Rectangle MetroDisk_Header = new Rectangle(0, 0, MetroDisk_W, 40);

            var _with2 = G;
            _with2.SmoothingMode = (SmoothingMode)2;
            _with2.PixelOffsetMode = (PixelOffsetMode)2;
            _with2.TextRenderingHint = (TextRenderingHint)5;
            _with2.Clear(Color.White);

            //-- Base
            _with2.FillRectangle(new SolidBrush(MetroDisk__BaseColor), MetroDisk_Base);

            //-- Header
            _with2.FillRectangle(new SolidBrush(MetroDisk__HeaderColor), MetroDisk_Header);

            //-- Logo
            _with2.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(23, 10, MetroDisk_W, H), NearSF);
            _with2.DrawString(MetroDisk__text, _Font, new SolidBrush(Color.DimGray), new Rectangle(MetroDisk_W - 120, MetroDisk_H - 15, MetroDisk_W, MetroDisk_H), NearSF);
            _with2.FillRectangle(new SolidBrush(MetroDisk__MDcolor), new Rectangle(1, 40, 12, 50));

            //-- Border
            _with2.DrawRectangle(new Pen(MetroDisk__BorderColor), MetroDisk_Base);


            //G.Dispose();
            e.Graphics.InterpolationMode = (InterpolationMode)7;
            e.Graphics.DrawImageUnscaled(MetroDisk_B, 0, 0);
            MetroDisk_B.Dispose();
        }

        #endregion
    }
}
