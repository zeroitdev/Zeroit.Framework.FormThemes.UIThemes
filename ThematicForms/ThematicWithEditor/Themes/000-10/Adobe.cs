// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Adobe.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    /// <summary>
    /// Class Thematic150WithEditor.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.FormThemes.UIThemes.ThemeContainer154" />
    public partial class Thematic150WithEditor
    {
        #region 1. Adobe

        #region Private Fields
        /// <summary>
        /// The adobe top bar
        /// </summary>
        private Color Adobe_topBar = Color.FromArgb(51, 51, 51);
        /// <summary>
        /// The adobe bottom bar
        /// </summary>
        private Color Adobe_bottomBar = Color.FromArgb(51, 51, 51);

        /// <summary>
        /// The adobe line1
        /// </summary>
        private Color Adobe_Line1 = Color.FromArgb(31, 31, 31);
        /// <summary>
        /// The adobe line2
        /// </summary>
        private Color Adobe_Line2 = Color.FromArgb(60, 60, 60);
        /// <summary>
        /// The adobe border1
        /// </summary>
        private Color Adobe_border1 = Color.Black;
        /// <summary>
        /// The adobe border2
        /// </summary>
        private Color Adobe_border2 = Color.Gray;

        /// <summary>
        /// The adobe border width
        /// </summary>
        private int Adobe_borderWidth = 1;


        /// <summary>
        /// Enum Alignment
        /// </summary>
        public enum Alignment : int
        {
            /// <summary>
            /// The left
            /// </summary>
            Left = 0,
            /// <summary>
            /// The center
            /// </summary>
            Center = 1,
            /// <summary>
            /// The right
            /// </summary>
            Right = 2
        }

        #endregion

        #region "Properties"
        /// <summary>
        /// Gets or sets the top bar.
        /// </summary>
        /// <value>The top bar.</value>
        [Category("Adobe Theme")]
        public Color TopBar
        {
            get { return Adobe_topBar; }
            set
            {
                Adobe_topBar = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the line1.
        /// </summary>
        /// <value>The line1.</value>
        [Category("Adobe Theme")]
        public Color Line1
        {
            get { return Adobe_Line1; }
            set
            {
                Adobe_Line1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the line2.
        /// </summary>
        /// <value>The line2.</value>
        [Category("Adobe Theme")]
        public Color Line2
        {
            get { return Adobe_Line2; }
            set
            {
                Adobe_Line2 = value;
                Invalidate();
            }
        }
        /// <summary>
        /// Gets or sets the border1.
        /// </summary>
        /// <value>The border1.</value>
        [Category("Adobe Theme")]
        public Color Border1
        {
            get { return Adobe_border1; }
            set
            {
                Adobe_border1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the border2.
        /// </summary>
        /// <value>The border2.</value>
        [Category("Adobe Theme")]
        public Color Border2
        {
            get { return Adobe_border2; }
            set
            {
                Adobe_border2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the bottom bar.
        /// </summary>
        /// <value>The bottom bar.</value>
        [Category("Adobe Theme")]
        public Color BottomBar
        {
            get { return Adobe_bottomBar; }
            set
            {
                Adobe_bottomBar = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The text align
        /// </summary>
        private Alignment textAlign;
        /// <summary>
        /// Gets or sets the text alignment.
        /// </summary>
        /// <value>The text alignment.</value>
        public Alignment TextAlignment
        {
            get { return textAlign; }
            set
            {
                textAlign = value;
                Invalidate();
            }
        }


        //private Color textColor;
        //public override Color ForeColor
        //{
        //    get { return textColor; }
        //    set
        //    {
        //        textColor = value;
        //        Invalidate();
        //    }
        //}

        /// <summary>
        /// Gets or sets the background color for the control.
        /// </summary>
        /// <value>The color of the back.</value>
        public override Color BackColor
        {
            get { return base.BackColor; }

            set
            {
                base.BackColor = value;
                Invalidate();
            }
        }

        #endregion

        #region Paint Hook

        /// <summary>
        /// Adobes the paint hook.
        /// </summary>
        void Adobe_PaintHook()
        {

            G.Clear(BackColor);

            //Top bar
            G.FillRectangle(new SolidBrush(Adobe_topBar) /*ConversionFunctions.ConvertToBrush(51, 51, 51)*/, 0, 0, Width, 37);
            G.DrawLine(new Pen(Adobe_Line1) /*ConversionFunctions.ConvertToPen(31, 31, 31)*/, 0, 37, Width, 37);
            G.DrawLine(new Pen(Adobe_Line2) /*ConversionFunctions.ConvertToPen(60, 60, 60)*/, 0, 38, Width, 38);

            //Middle
            G.FillRectangle(new SolidBrush(BackColor)/*ConversionFunctions.ConvertToBrush(68, 68, 68)*/, 1, 39, Width - 2, Height - 41);

            //Bottom bar
            G.FillRectangle(new SolidBrush(Adobe_bottomBar) /*ConversionFunctions.ConvertToBrush(51, 51, 51)*/, 1, Height - 37, Width, 37);
            G.DrawLine(new Pen(Adobe_Line1) /*ConversionFunctions.ConvertToPen(31, 31, 31)*/, 0, Height - 37, Width, Height - 37);
            G.DrawLine(new Pen(Adobe_Line2) /*ConversionFunctions.ConvertToPen(60, 60, 60)*/, 0, Height - 38, Width, Height - 38);

            //Title

            switch (textAlign)
            {
                case Alignment.Left:
                    //Left
                    DrawText(Brushes.Black, Text, HorizontalAlignment.Left, 10, 20);
                    DrawText(ConversionFunctions.ConvertToBrush(ForeColor), Text, HorizontalAlignment.Left, 8, 18);
                    break;
                case Alignment.Center:
                    //Center
                    DrawText(Brushes.Black, Text, HorizontalAlignment.Center, 2, 20);
                    DrawText(ConversionFunctions.ConvertToBrush(ForeColor), Text, HorizontalAlignment.Center, 0, 18);
                    break;
                case Alignment.Right:
                    //Right   
                    DrawText(Brushes.Black, Text, HorizontalAlignment.Right, 10, 20);
                    DrawText(ConversionFunctions.ConvertToBrush(ForeColor), Text, HorizontalAlignment.Right, 8, 18);
                    break;
            }

            //Border
            DrawBorders(new Pen(Adobe_border1));
            DrawBorders(new Pen(Adobe_border2), 1);

            //Rounding
            switch (Parent.FindForm().FormBorderStyle)
            {
                case FormBorderStyle.None:
                    DrawCorners(Color.Fuchsia);
                    break;
                default:
                    DrawCorners(Color.Black);
                    break;
            }

        }

        #endregion

        #endregion
    }
}
