// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="CarbonFibre.cs" company="Zeroit Dev Technologies">
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
        #region 22. Carbon Fibre

        private bool _showIcon = false;

        [Category("Carbon Fibre Theme")]
        public bool _ShowIcon
        {
            get { return _showIcon; }
            set
            {
                _showIcon = value;
                Invalidate();
            }
        }


        #region "Color of Control"
        void CarbonFibre_PaintHook(PaintEventArgs e)
        {
            //This G.Clear does not need ^^
            G.Clear(Color.FromArgb(31, 31, 31));

            ///''''''' Gradient the Body '''''''
            LinearGradientBrush GradientBG = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(25, 25, 25), Color.FromArgb(22, 22, 22), -270);
            G.FillRectangle(GradientBG, new Rectangle(0, 0, Width - 1, Height - 1));

            ///''''''' Draw Body '''''''
            HatchBrush BodyHatch = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(35, Color.Black), Color.Transparent);
            G.FillRectangle(BodyHatch, new Rectangle(0, 0, Width - 1, Height - 1));
            // G.FillRectangle(New SolidBrush(Color.FromArgb(32, 32, 32)), New Rectangle(10, 10, Width - 21, Height - 21))
            G.DrawRectangle(new Pen(Color.FromArgb(32, 32, 32)), new Rectangle(10, 32, Width - 21, Height - 43));
            G.DrawRectangle(new Pen(Color.FromArgb(6, 6, 6)), new Rectangle(9, 31, Width - 19, Height - 41));


            ///''''''' Draw Header '''''''
            LinearGradientBrush Header = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, 30), Color.FromArgb(25, 25, 25), Color.FromArgb(40, 40, 40), 270);
            G.FillRectangle(Header, new Rectangle(0, 0, Width - 1, 30));
            HatchBrush HeaderHatch = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(35, Color.Black), Color.Transparent);
            G.FillRectangle(HeaderHatch, new Rectangle(0, 0, Width - 1, 30));
            G.FillRectangle(new SolidBrush(Color.FromArgb(15, Color.White)), 0, 0, Width - 1, 15);

            ///''''''' Draw Header Seperator ''''''
            //G.DrawLine(New Pen(Color.FromArgb(18, 18, 18)), 0, 15, Width + 9000, 15) ' Please dont use 9000 above ^^
            G.DrawLine(new Pen(Color.FromArgb(42, 42, 42)), 0, 15, Width - 1, 15);
            // Cuz it has a bug dont worry i will fix it =)

            ///''''''' Draw Header Border '''''''
            //DrawGradient(BlendColor, New Rectangle(0, 0, Width - 1, 32), 0.0F)
            G.FillRectangle(new SolidBrush(Color.FromArgb(22, 22, 22)), new Rectangle(11, 33, Width - 23, Height - 45));
            G.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));
            G.DrawRectangle(new Pen(Color.FromArgb(49, 49, 49)), new Rectangle(1, 1, Width - 3, Height - 3));

            ///''''''' Reduce Corners '''''''


            ///''''''' Draw Icon and Text '''''''
            if (_ShowIcon == false)
            {
                G.DrawString(Text, Font, new SolidBrush(Color.Black), new Point(8, 7));
                // Text Shadow
                G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(255, 150, 0)), new Point(8, 8));
            }
            else
            {
                G.DrawIcon(Parent.FindForm().Icon, new Rectangle(new Point(9, 7), new Size(16, 16)));
                G.DrawString(Text, Font, new SolidBrush(Color.Black), new Point(28, 7));
                // Text Shadow
                G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(255, 150, 0)), new Point(28, 8));
            }

        }
        #endregion

        #endregion
    }
}
