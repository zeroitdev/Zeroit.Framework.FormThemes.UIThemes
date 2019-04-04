// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Atrocity.cs" company="Zeroit Dev Technologies">
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
        #region 7. Atrocity


        #region "Close Button Border property"
        [Description("Choose weather or not to draw the border around the close button; Fixed Position!"), Browsable(true)]
        private bool _drawCButtonBorder = true;
        public bool drawCButtonBorder
        {
            get { return _drawCButtonBorder; }
            set
            {
                _drawCButtonBorder = value;
                Invalidate();
            }
        }

        #endregion


        void Atrocity_PaintHook(PaintEventArgs e)
        {
            //BackColor = Color.FromArgb(41, 41, 41);
            G.Clear(Color.FromArgb(41, 41, 41));

            DrawGradient(Color.FromArgb(60, 60, 60), Color.FromArgb(41, 41, 41), 0, 0, Width, 31);
            HatchBrush DarkDown = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.Transparent, Color.FromArgb(50, Color.Black));
            HatchBrush DarkUp = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.Transparent, Color.FromArgb(50, Color.Black));
            G.FillRectangle(DarkDown, new Rectangle(0, 0, ClientRectangle.Width, Header));
            G.FillRectangle(DarkUp, new Rectangle(0, 0, ClientRectangle.Width, Header));

            //New Pen(Color.FromArgb(58, 58, 58)
            G.DrawLine(new Pen(Color.FromArgb(58, 58, 58)), 0, 31, Width, 31);
            G.DrawLine(new Pen(Color.FromArgb(25, 25, 25)), 0, 32, Width, 32);
            G.DrawLine(new Pen(Color.FromArgb(58, 58, 58)), 0, 33, Width, 33);



            G.DrawLine(new Pen(Color.FromArgb(58, 58, 58)), 34, 30, 34, 0);
            G.DrawLine(new Pen(Color.FromArgb(25, 25, 25)), 33, 31, 33, 0);
            G.DrawLine(new Pen(Color.FromArgb(58, 58, 58)), 32, 30, 32, 0);

            G.FillRectangle(new SolidBrush(Color.FromArgb(41, 41, 41)), 0, 0, 32, 30);

            if (_drawCButtonBorder)
            {
                G.DrawLine(new Pen(Color.FromArgb(58, 58, 58)), this.Width - 36, 30, this.Width - 36, 0);
                G.DrawLine(new Pen(Color.FromArgb(25, 25, 25)), this.Width - 35, 31, this.Width - 35, 0);
                G.DrawLine(new Pen(Color.FromArgb(58, 58, 58)), this.Width - 34, 30, this.Width - 34, 0);
            }


            DrawText(new SolidBrush(Color.FromArgb(0, 168, 198)), HorizontalAlignment.Left, 36, 0);


            DrawBorders(new Pen(Color.FromArgb(65, 65, 65)), 0);
            DrawBorders(new Pen(Color.FromArgb(70, 70, 70), 1));


            //G.DrawImage(((Image)Cursors.Arrow, new Point(1, 1)));

            DrawCorners(TransparencyKey);

        }

        #endregion
    }
}
