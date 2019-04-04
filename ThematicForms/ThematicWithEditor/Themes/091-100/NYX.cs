// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="NYX.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 92. NYX

        private Color[] nYX_GradColor = new Color[]
        {
            Color.FromArgb(35,35,35),
            Color.FromArgb(210, 0, 0),
            Color.FromArgb(35,35,35),
        };
        [Category("NYX Theme")]
        public Color[] NYX_GradColor
        {
            get { return nYX_GradColor; }
            set
            {
                nYX_GradColor = value;
                Invalidate();
            }
        }

        int NYX_H;
        bool NYX_f;
        [DefaultValue(true)]
        public bool Animated
        {
            get { return IsAnimated; }
            set
            {
                IsAnimated = value;
                Invalidate();
            }
        }

        void NYX_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Fuchsia);
            //Borders
            Point[] bTopPoints = {
                new Point(0, 1),
                new Point(1, 0),
                new Point(Width - 2, 0),
                new Point(Width - 1, 1),
                new Point(Width - 1, 25),
                new Point(0, 25)
            };
            LinearGradientBrush bTopLGB = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, 25), Color.FromArgb(60, 60, 60), Color.FromArgb(35, 35, 35), 90f);
            G.FillPolygon(bTopLGB, bTopPoints);
            G.DrawPolygon(Pens.Black, bTopPoints);
            Point[] bBottomPoints = {
                new Point(0, 25),
                new Point(Width - 1, 25),
                new Point(Width - 1, Height - 2),
                new Point(Width - 2, Height - 1),
                new Point(1, Height - 1),
                new Point(0, Height - 2)
            };
            G.FillPolygon(new SolidBrush(Color.FromArgb(35, 35, 35)), bBottomPoints);
            G.DrawPolygon(Pens.Black, bBottomPoints);
            //Glow
            if (Animated == true)
            {
                ColorBlend bg_cblend = new ColorBlend(3);
                bg_cblend.Colors[0] = nYX_GradColor[0];
                bg_cblend.Colors[1] = nYX_GradColor[1];
                bg_cblend.Colors[2] = nYX_GradColor[2];
                bg_cblend.Positions = new float[]{
                    0,
                    0.6f,
                    1
                };
                DrawGradient(bg_cblend, new Rectangle(1, NYX_H, Width, 75));
                //Reinforce Borders After Glow
                G.DrawPolygon(Pens.Black, bTopPoints);
                G.DrawPolygon(Pens.Black, bBottomPoints);
                G.DrawLine(Pens.Black, new Point(0, Height - 9), new Point(Width, Height - 9));
            }
            //Main
            Rectangle mainRect = new Rectangle(8, 25, Width - 17, Height - 34);
            G.FillRectangle(new SolidBrush(Color.FromArgb(22, 22, 22)), mainRect);
            G.DrawRectangle(Pens.Black, mainRect);
            //Text
            Font titleFont = new Font("Arial", 10, FontStyle.Bold);
            int textWidth = (int)this.CreateGraphics().MeasureString(Text, Font).Width;
            int textHeight = (int)this.CreateGraphics().MeasureString(Text, Font).Height;
            SolidBrush textShadow = new SolidBrush(Color.FromArgb(30, 0, 0));
            int m = Width / 2;
            G.DrawString(Text, titleFont, textShadow, new Point(m - (textWidth / 2) + 1, 5));
            G.DrawString(Text, titleFont, new SolidBrush(/*Color.FromArgb(210, 10, 10)*/ ForeColor), new Point(m - (textWidth / 2), 4));

            if (ShowIcon)
                G.DrawIcon(Parent.FindForm().Icon, new Rectangle(5, 5, 20, 20));

        }

        protected override void OnAnimation()
        {
            if (NYX_f == true)
            {
                NYX_H -= 1;
            }
            else
            {
                NYX_H += 1;
            }
            if (NYX_H == 25)
            {
                NYX_f = false;
            }
            if (NYX_H == Height - 8 - 75)
            {
                NYX_f = true;
            }
        }


        #endregion
    }
}
