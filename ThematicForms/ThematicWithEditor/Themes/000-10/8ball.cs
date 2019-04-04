// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="8ball.cs" company="Zeroit Dev Technologies">
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
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    /// <summary>
    /// Class Thematic150WithEditor.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.FormThemes.UIThemes.ThemeContainer154" />
    public partial class Thematic150WithEditor
    {
        #region 0. 8ball


        #region Private Fields

        /// <summary>
        /// The eight ball move height
        /// </summary>
        private int EightBall_moveHeight = 39;
        /// <summary>
        /// The eight ball form can move
        /// </summary>
        private bool EightBall_formCanMove = false;
        /// <summary>
        /// The eight ball mouse x
        /// </summary>
        private int EightBall_mouseX;
        /// <summary>
        /// The eight ball mouse y
        /// </summary>
        private int EightBall_mouseY;
        /// <summary>
        /// The eight ball over exit
        /// </summary>
        private bool EightBall_overExit;
        /// <summary>
        /// The eight ball over minimum
        /// </summary>
        private bool EightBall_overMin;

        /// <summary>
        /// The eight ball t key
        /// </summary>
        private Color EightBall_tKey = Color.Fuchsia;

        /// <summary>
        /// The eight ball colors
        /// </summary>
        private Color[] eightBallColors = new Color[]
        {
            Color.FromArgb(60, 60, 60),
            Color.FromArgb(100, 100, 100),
            Color.FromArgb(60, 60, 60),
            Color.Black,
            Color.FromArgb(105, 105, 105),
            Color.FromArgb(75, 75, 75),
            Color.White,
            Color.DimGray,
            Color.FromArgb(40, 40, 40)
        };

        /// <summary>
        /// The eight string colors
        /// </summary>
        private Color[] eightStringColors = new Color[]
        {
            Color.White,
            Color.LightGray
        };

        #region MyRegion

        /// <summary>
        /// Gets or sets the eight ball colors.
        /// </summary>
        /// <value>The eight ball colors.</value>
        public Color[] EightBallColors
        {
            get { return eightBallColors; }
            set
            {
                eightBallColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the eight string colors.
        /// </summary>
        /// <value>The eight string colors.</value>
        public Color[] EightStringColors
        {
            get { return eightStringColors; }
            set
            {
                eightStringColors = value;
                Invalidate();
            }
        }


        #endregion

        #endregion

        #region Events

        /// <summary>
        /// Eights the ball paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void EightBall_PaintHook(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(EightBall_tKey);

            Rectangle mainRect = new Rectangle(0, 0, Width - 1, Height - 1);
            int slope = 8;
            GraphicsPath mainPath = EightBall_Drawing.TopRoundRect(mainRect, slope);
            g.FillPath(new SolidBrush(eightBallColors[0]), mainPath);

            Rectangle titleTopRect = new Rectangle(0, 0, Width - 1, Convert.ToInt32(EightBall_moveHeight / 1.75f));
            GraphicsPath titleTopPath = EightBall_Drawing.TopRoundRect(titleTopRect, slope);
            LinearGradientBrush titleTopBrush = new LinearGradientBrush(new Rectangle(titleTopRect.X, titleTopRect.Y, titleTopRect.Width, titleTopRect.Height + 2), eightBallColors[1],eightBallColors[2], 90f);
            g.FillPath(titleTopBrush, titleTopPath);

            Rectangle innerRect = new Rectangle(6, EightBall_moveHeight, Width - 13, Height - EightBall_moveHeight - 8);
            g.FillRectangle(new SolidBrush(BackColor), innerRect);
            g.DrawRectangle(new Pen(eightBallColors[3]), innerRect);

            int textY = (EightBall_moveHeight / 2) - (Convert.ToInt32(g.MeasureString(Text, Font).Height / 2) + 1);
            if (ShowIcon & Icon != null)
            {
                g.DrawIcon(Icon, new Rectangle(8, 6, EightBall_moveHeight - 11, EightBall_moveHeight - 11));
                EightBall_Drawing.ShadowedString(g, Text, Font, new SolidBrush(eightStringColors[0]), new Point(8 + EightBall_moveHeight - 11 + 4, textY));
            }
            else
            {
                EightBall_Drawing.ShadowedString(g, Text, Font, new SolidBrush(eightStringColors[0]), new Point(8, textY));
            }

            Rectangle exitRect = new Rectangle(Width - 29, 8, 22, 22);
            GraphicsPath exitPath = EightBall_Drawing.RoundRect(exitRect, 3);
            LinearGradientBrush exitBrush = new LinearGradientBrush(exitRect, eightBallColors[4], eightBallColors[5], 90f);
            g.FillPath(exitBrush, exitPath);
            if (EightBall_overExit)
                g.FillPath(new SolidBrush(Color.FromArgb(15, eightBallColors[6])), exitPath);
            g.DrawPath(new Pen(eightBallColors[8]), exitPath);
            g.DrawString("r", new Font("Marlett", 10), new SolidBrush(eightStringColors[1]), new Point(Width - 26, 13));

            Rectangle minRect = new Rectangle(Width - 55, 8, 22, 22);
            GraphicsPath minPath = EightBall_Drawing.RoundRect(minRect, 3);
            LinearGradientBrush minBrush = new LinearGradientBrush(minRect, eightBallColors[4], eightBallColors[5], 90f);
            g.FillPath(minBrush, minPath);
            if (EightBall_overMin)
                g.FillPath(new SolidBrush(Color.FromArgb(15, eightBallColors[6])), minPath);
            g.DrawPath(new Pen(eightBallColors[8]), minPath);
            g.DrawString("0", new Font("Marlett", 13), new SolidBrush(eightStringColors[1]), new Point(Width - 53, 10));

            g.SmoothingMode = SmoothingMode.Default;
            g.DrawPath(new Pen(eightBallColors[7]), EightBall_Drawing.TopRoundRect(new Rectangle(mainRect.X + 1, mainRect.Y, mainRect.Width - 2, mainRect.Height), slope));
            g.DrawPath(new Pen(eightBallColors[7]), EightBall_Drawing.TopRoundRect(new Rectangle(mainRect.X, mainRect.Y + 1, mainRect.Width, mainRect.Height - 2), slope));
            g.DrawPath(new Pen(eightBallColors[8]), mainPath);

        }

        /// <summary>
        /// Eights the ball mouse move.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        void EightBall_MouseMove(System.Windows.Forms.MouseEventArgs e)
        {


            //if (EightBall_formCanMove == true)
            //{
            //    Parent.FindForm().Location = new Point(MousePosition.X - EightBall_mouseX, MousePosition.Y - EightBall_mouseY);
            //}

            if (e.Y > 8 && e.Y < 30)
            {
                if (e.X > Width - 29 && e.X < Width - 7)
                    EightBall_overExit = true;
                else
                    EightBall_overExit = false;
                if (e.X > Width - 55 && e.X < Width - 33)
                    EightBall_overMin = true;
                else
                    EightBall_overMin = false;
            }
            else
            {
                EightBall_overExit = false;
                EightBall_overMin = false;
            }

            Invalidate();

        }

        /// <summary>
        /// Eights the ball on mouse down.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        void EightBall_OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {


            EightBall_mouseX = e.X;
            EightBall_mouseY = e.Y;

            if (e.Y <= EightBall_moveHeight && EightBall_overExit == false && EightBall_overMin == false)
                EightBall_formCanMove = true;

            if (EightBall_overExit)
            {
                Parent.FindForm().Close();
            }
            else if (EightBall_overMin)
            {
                Parent.FindForm().WindowState = FormWindowState.Minimized;
            }
            else
            {
                Focus();
            }

        }

        /// <summary>
        /// Eights the ball on mouse up.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        void EightBall_OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {

            EightBall_formCanMove = false;
        }

        #endregion


        #endregion
    }
}
