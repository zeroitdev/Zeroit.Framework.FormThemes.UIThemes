// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Sharp.cs" company="Zeroit Dev Technologies">
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

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 109. Sharp
        private bool sharp_Color2 = true;

        public bool Sharp_Color2
        {
            get { return sharp_Color2; }
            set
            {
                sharp_Color2 = value;
                Invalidate();
            }
        }


        void Sharp_Paint(System.Windows.Forms.PaintEventArgs e)
        {

            Bitmap bmp = new Bitmap(Width, Height);
            G = Graphics.FromImage(bmp);
            Color TransparencyKey = this.ParentForm.TransparencyKey;


            G.Clear(Color.FromArgb(43, 53, 63));
            //---- Sides--
            Rectangle LGBunderGrdrect = new Rectangle(1, Header, Width, 130);
            LinearGradientBrush LGBunderGrd = new LinearGradientBrush(LGBunderGrdrect, Color.FromArgb(43, 53, 63), Color.FromArgb(70, 79, 85), 90);
            G.FillRectangle(LGBunderGrd, LGBunderGrdrect);


            if (sharp_Color2)
            {
                LinearGradientBrush BTNLGBOver = new LinearGradientBrush(new Rectangle(2, 1, Width - 3, Header / 2), Color.FromArgb(20, 30, 40), Color.FromArgb(135, Color.White), 360);
                G.FillRectangle(BTNLGBOver, new Rectangle(2, 1, Width - 3, Header / 2));
                LinearGradientBrush BTNLGB1 = new LinearGradientBrush(new Rectangle(-1, 1, Width, Header / 2), Color.FromArgb(100, Color.White), Color.FromArgb(20, 30, 40), 360);
                G.FillRectangle(BTNLGB1, new Rectangle(-1, 1, Width / 2, Header / 2));
                Brush txtbrushCL2 = new SolidBrush(Color.FromArgb(250, 250, 250));
                G.DrawString(Text, Font, txtbrushCL2, new Rectangle(16, 6, Width - 1, 22), new StringFormat
                {
                    LineAlignment = StringAlignment.Near,
                    Alignment = StringAlignment.Near
                });
            }
            else
            {
                LinearGradientBrush BTNLGBOver = new LinearGradientBrush(new Rectangle(2, 1, Width - 3, Header / 2), Color.FromArgb(35, 45, 55), Color.FromArgb(155, Color.White), 180);
                G.FillRectangle(BTNLGBOver, new Rectangle(2, 1, Width - 3, Header / 2));
                LinearGradientBrush BTNLGB1 = new LinearGradientBrush(new Rectangle(-1, 1, Width, Header / 2), Color.FromArgb(120, Color.White), Color.FromArgb(35, 45, 55), 180);
                G.FillRectangle(BTNLGB1, new Rectangle(-1, 1, Width / 2, Header / 2));
                Brush txtbrush = new SolidBrush(Color.FromArgb(210, 220, 230));
                G.DrawString(Text, Font, txtbrush, new Rectangle(16, 7, Width - 1, 22), new StringFormat
                {
                    LineAlignment = StringAlignment.Near,
                    Alignment = StringAlignment.Near
                });
            }





            Rectangle InerRecLGB = new Rectangle(11, 28, Width - 22, Height - 37);
            LinearGradientBrush InnerRecLGB = new LinearGradientBrush(InerRecLGB, Color.FromArgb(57, 67, 77), Color.FromArgb(60, 69, 75), 90);
            G.FillRectangle(InnerRecLGB, InerRecLGB);

            //----- InnerRect
            Pen P1 = new Pen(new SolidBrush(Color.FromArgb(23, 33, 43)));
            G.DrawRectangle(P1, 12, 29, Width - 25, Height - 40);
            Pen P2 = new Pen(new SolidBrush(Color.FromArgb(93, 103, 113)));
            G.DrawRectangle(P2, 11, 28, Width - 23, Height - 38);



            LinearGradientBrush LGBunderGrd3 = new LinearGradientBrush(new Rectangle(0, Height - 9, Width / 2, 50), Color.FromArgb(40, 50, 60), Color.FromArgb(50, Color.White), 360);
            G.FillRectangle(LGBunderGrd3, 0, Height - 9, Width / 2, 50);
            LinearGradientBrush LGBunderGrd2 = new LinearGradientBrush(new Rectangle(Width / 2, Height - 9, Width / 2, Height), Color.FromArgb(40, 50, 60), Color.FromArgb(50, Color.White), 180);
            G.FillRectangle(LGBunderGrd2, Width / 2, Height - 9, Width / 2, Height);
            G.DrawLine(new Pen(Color.FromArgb(90, 90, 90)), Width / 2, Height - 9, Width / 2, Height);

            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(137, 147, 157))), 1, 1, Width - 3, Height - 3);

            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            G.DrawPath(Pens.Black, Utilities.Draw.RoundRect(ClientRectangle, 0, 0, 0, 0));

            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(163, 173, 183))), 2, 1, Width - 3, 1);
            e.Graphics.DrawImage((Image)bmp.Clone(), 0, 0);
            bmp.Dispose();
            //G.Dispose();

        }


        #endregion
    }
}
