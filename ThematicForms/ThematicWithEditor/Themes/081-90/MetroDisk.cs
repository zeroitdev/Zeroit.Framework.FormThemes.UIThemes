// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="MetroDisk.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
