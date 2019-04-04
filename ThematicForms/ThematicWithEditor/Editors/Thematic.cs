// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Thematic.cs" company="Zeroit Dev Technologies">
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing.Text;
using Zeroit.Framework.FormThemes.UIThemes.Utilities;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    /// <summary>
    /// Class Thematic150.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.FormThemes.UIThemes.ThemeContainer154" />
    [ToolboxItem(false)]
    public partial class Thematic150 : ThemeContainer154
    {

        #region Private Fields

        /// <summary>
        /// The themes
        /// </summary>
        private themes _themes = themes.Mumtz;

        /// <summary>
        /// The border
        /// </summary>
        private Color border;

        /// <summary>
        /// The lock dimension
        /// </summary>
        private bool lockDimension = false;

        //private LockSize locksize = new LockSize();


        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets a value indicating whether [lock dimension].
        /// </summary>
        /// <value><c>true</c> if [lock dimension]; otherwise, <c>false</c>.</value>
        public bool LockDimension
        {
            get { return lockDimension; }
            set
            {
                lockDimension = value;
                Invalidate();
            }
        }


        //public LockSize LockSize
        //{
        //    get { return locksize; }
        //    set
        //    {
        //        locksize = value;
        //        Invalidate();
        //    }
        //}


        /// <summary>
        /// Gets or sets the theme.
        /// </summary>
        /// <value>The theme.</value>
        public themes Theme
        {
            get { return _themes; }
            set
            {
                _themes = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the border.
        /// </summary>
        /// <value>The border.</value>
        public Color Border
        {
            get { return border; }
            set
            {
                border = value;
                Invalidate();
            }
        }



        #endregion

        #region Themes

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
        /// Gets or sets the text.
        /// </summary>
        /// <value>The text.</value>
        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The eight ball icon
        /// </summary>
        private Icon EightBall_icon;
        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        /// <value>The icon.</value>
        public Icon Icon
        {
            get { return EightBall_icon; }
            set
            {
                EightBall_icon = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The eight ball show icon
        /// </summary>
        private bool EightBall_showIcon;
        /// <summary>
        /// Gets or sets a value indicating whether [show icon].
        /// </summary>
        /// <value><c>true</c> if [show icon]; otherwise, <c>false</c>.</value>
        public bool ShowIcon
        {
            get { return EightBall_showIcon; }
            set
            {
                EightBall_showIcon = value;
                Invalidate();
            }
        }


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
            g.FillPath(new SolidBrush(Color.FromArgb(60, 60, 60)), mainPath);

            Rectangle titleTopRect = new Rectangle(0, 0, Width - 1, Convert.ToInt32(EightBall_moveHeight / 1.75f));
            GraphicsPath titleTopPath = EightBall_Drawing.TopRoundRect(titleTopRect, slope);
            LinearGradientBrush titleTopBrush = new LinearGradientBrush(new Rectangle(titleTopRect.X, titleTopRect.Y, titleTopRect.Width, titleTopRect.Height + 2), Color.FromArgb(100, 100, 100), Color.FromArgb(60, 60, 60), 90f);
            g.FillPath(titleTopBrush, titleTopPath);

            Rectangle innerRect = new Rectangle(6, EightBall_moveHeight, Width - 13, Height - EightBall_moveHeight - 8);
            g.FillRectangle(new SolidBrush(BackColor), innerRect);
            g.DrawRectangle(Pens.Black, innerRect);

            int textY = (EightBall_moveHeight / 2) - (Convert.ToInt32(g.MeasureString(Text, Font).Height / 2) + 1);
            if (EightBall_showIcon & EightBall_icon != null)
            {
                g.DrawIcon(EightBall_icon, new Rectangle(8, 6, EightBall_moveHeight - 11, EightBall_moveHeight - 11));
                EightBall_Drawing.ShadowedString(g, Text, Font, Brushes.White, new Point(8 + EightBall_moveHeight - 11 + 4, textY));
            }
            else
            {
                EightBall_Drawing.ShadowedString(g, Text, Font, Brushes.White, new Point(8, textY));
            }

            Rectangle exitRect = new Rectangle(Width - 29, 8, 22, 22);
            GraphicsPath exitPath = EightBall_Drawing.RoundRect(exitRect, 3);
            LinearGradientBrush exitBrush = new LinearGradientBrush(exitRect, Color.FromArgb(105, 105, 105), Color.FromArgb(75, 75, 75), 90f);
            g.FillPath(exitBrush, exitPath);
            if (EightBall_overExit)
                g.FillPath(new SolidBrush(Color.FromArgb(15, Color.White)), exitPath);
            g.DrawPath(new Pen(Color.FromArgb(40, 40, 40)), exitPath);
            g.DrawString("r", new Font("Marlett", 10), Brushes.LightGray, new Point(Width - 26, 13));

            Rectangle minRect = new Rectangle(Width - 55, 8, 22, 22);
            GraphicsPath minPath = EightBall_Drawing.RoundRect(minRect, 3);
            LinearGradientBrush minBrush = new LinearGradientBrush(minRect, Color.FromArgb(105, 105, 105), Color.FromArgb(75, 75, 75), 90f);
            g.FillPath(minBrush, minPath);
            if (EightBall_overMin)
                g.FillPath(new SolidBrush(Color.FromArgb(15, Color.White)), minPath);
            g.DrawPath(new Pen(Color.FromArgb(40, 40, 40)), minPath);
            g.DrawString("0", new Font("Marlett", 13), Brushes.LightGray, new Point(Width - 53, 10));

            g.SmoothingMode = SmoothingMode.Default;
            g.DrawPath(Pens.DimGray, EightBall_Drawing.TopRoundRect(new Rectangle(mainRect.X + 1, mainRect.Y, mainRect.Width - 2, mainRect.Height), slope));
            g.DrawPath(Pens.DimGray, EightBall_Drawing.TopRoundRect(new Rectangle(mainRect.X, mainRect.Y + 1, mainRect.Width, mainRect.Height - 2), slope));
            g.DrawPath(new Pen(Color.FromArgb(40, 40, 40)), mainPath);

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
        /// Gets or sets the color of the back.
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

        #region 2. Advanced System 

        /// <summary>
        /// The move height
        /// </summary>
        private int moveHeight = 38;
        /// <summary>
        /// The form can move
        /// </summary>
        private bool formCanMove = false;
        /// <summary>
        /// The mouse x
        /// </summary>
        private int mouseX;
        /// <summary>
        /// The mouse y
        /// </summary>
        private int mouseY;
        /// <summary>
        /// The over exit
        /// </summary>
        private bool overExit;

        /// <summary>
        /// The over minimum
        /// </summary>
        private bool overMin;

        /// <summary>
        /// Advanceds the system on mouse move.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        void AdvancedSystem_OnMouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            
            //if (formCanMove == true)
            //{
            //    Parent.FindForm().Location = new Point(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            //}

            if (e.Y > 11 && e.Y < 24)
            {
                if (e.X > Width - 23 && e.X < Width - 10)
                    overExit = true;
                else
                    overExit = false;
                if (e.X > Width - 44 && e.X < Width - 31)
                    overMin = true;
                else
                    overMin = false;
            }
            else
            {
                overExit = false;
                overMin = false;
            }

            Invalidate();

        }

        /// <summary>
        /// Advanceds the system on mouse down.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        void AdvancedSystem_OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            //base.OnMouseDown(e);

            mouseX = e.X;
            mouseY = e.Y;

            if (e.Y <= moveHeight && overExit == false && overMin == false)
                formCanMove = true;

            if (overExit)
            {
                Parent.FindForm().Close();
            }
            else if (overMin)
            {
                Parent.FindForm().WindowState = FormWindowState.Minimized;
                overExit = false;
                overMin = false;
            }
            else
            {
                Focus();
            }

            Invalidate();

        }

        /// <summary>
        /// Advanceds the system on mouse up.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        void AdvancedSystem_OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            //base.OnMouseUp(e);
            formCanMove = false;
        }


        /// <summary>
        /// Advanceds the system hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void AdvancedSystem_Hook(PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.Clear(Parent.FindForm().TransparencyKey);

            int slope = 8;

            Rectangle mainRect = new Rectangle(0, 0, Width - 1, Height - 1);
            GraphicsPath mainPath = Advanced_System_Drawing.RoundRect(mainRect, slope);
            G.FillPath(new SolidBrush(BackColor), mainPath);
            G.DrawPath(new Pen(Color.FromArgb(30, 35, 45)), mainPath);
            G.FillPath(new SolidBrush(Color.FromArgb(30, 30, 40)), Advanced_System_Drawing.RoundRect(new Rectangle(0, 0, Width - 1, moveHeight - slope), slope));
            G.FillRectangle(new SolidBrush(Color.FromArgb(30, 30, 40)), new Rectangle(0, moveHeight - (slope * 2), Width - 1, slope * 2));
            G.DrawLine(new Pen(Color.FromArgb(60, 60, 60)), new Point(1, moveHeight), new Point(Width - 2, moveHeight));
            G.SmoothingMode = SmoothingMode.HighQuality;

            int textX = 6;
            int textY = (moveHeight / 2) - Convert.ToInt32((G.MeasureString(Text, Font).Height / 2)) + 1;
            Size textSize = new Size(Convert.ToInt32(G.MeasureString(Text, Font).Width), Convert.ToInt32(G.MeasureString(Text, Font).Height));
            Rectangle textRect = new Rectangle(textX, textY, textSize.Width, textSize.Height);
            LinearGradientBrush textBrush = new LinearGradientBrush(textRect, ForeColor /*Color.FromArgb(185, 190, 195)*/, Color.FromArgb(125, 125, 125), 90f);
            G.DrawString(Text, Font, textBrush, new Point(textX, textY));

            if (overExit)
            {
                G.DrawString("r", new Font("Marlett", 12, FontStyle.Bold), new SolidBrush(Color.FromArgb(25, 100, 140)), new Point(Width - 27, 11));
            }
            else
            {
                G.DrawString("r", new Font("Marlett", 12, FontStyle.Bold), new SolidBrush(Color.FromArgb(205, 210, 215)), new Point(Width - 27, 11));
            }
            if (overMin)
            {
                G.DrawString("0", new Font("Marlett", 12, FontStyle.Bold), new SolidBrush(Color.FromArgb(25, 100, 140)), new Point(Width - 47, 10));
            }
            else
            {
                G.DrawString("0", new Font("Marlett", 12, FontStyle.Bold), new SolidBrush(Color.FromArgb(205, 210, 215)), new Point(Width - 47, 10));
            }

            if (DesignMode)

                Advanced_System_Prevent.Prevents(G, Width, Height);
        }

        #endregion

        #region 3. Advantium

        #region Private Field

        /// <summary>
        /// The advantium border color
        /// </summary>
        Color Advantium_borderColor = Color.Black;

        /// <summary>
        /// The advantium border inner
        /// </summary>
        Color Advantium_borderInner = Color.FromArgb(65, 65, 65);

        #endregion



        /// <summary>
        /// Advantiums the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Advantium_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(40, 40, 40));
            DrawGradient(Color.FromArgb(20, 20, 20), Color.FromArgb(40, 40, 40), new Rectangle(0, 0, Width, 35), 90);

            HatchBrush T = new HatchBrush(HatchStyle.Percent10, Color.FromArgb(25, 25, 25), Color.FromArgb(35, 35, 35));
            G.FillRectangle(T, new Rectangle(11, 25, Width - 23, Height - 36));

            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(22, 22, 22))), new Rectangle(11, 25, Width - 23, Height - 36));
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(40, 40, 40))), new Rectangle(12, 26, Width - 25, Height - 38));
            DrawCorners(Color.FromArgb(40, 40, 40), new Rectangle(11, 25, Width - 22, Height - 35));

            DrawBorders(new Pen(new SolidBrush(Advantium_borderInner)), 1);
            DrawBorders(new Pen(new SolidBrush(Advantium_borderColor)));
            DrawCorners(TransparencyKey);
            DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Left, 15, -3);
        }

        #endregion

        #region 4. Angel

        #region " Back End "

        #region " Declarations "
        /// <summary>
        /// The h
        /// </summary>
        private int H = 52;
        /// <summary>
        /// The d
        /// </summary>
        private bool D = false;
        /// <summary>
        /// The p
        /// </summary>
        private Point P;
        #endregion
        /// <summary>
        /// a
        /// </summary>
        private Alignment A = Alignment.Left;

        #region " Mouse States "
        // Get more free themes at ThemesVB.NET
        /// <summary>
        /// Angels the on mouse up.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        void Angel_OnMouseUp(MouseEventArgs e)
        {
            
            D = false;
        }

        /// <summary>
        /// Angels the on mouse down.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        void Angel_OnMouseDown(MouseEventArgs e)
        {
            
            if (new Rectangle(0, 0, Width, H).Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                P = e.Location;
                D = true;
            }
        }

        /// <summary>
        /// Angels the on mouse move.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        void Angel_OnMouseMove(MouseEventArgs e)
        {
            
            if (D == true)
            {
                ParentForm.Location = new Point(MousePosition.X - P.X, MousePosition.Y - P.Y);
            }
        }


        #endregion

        #region " Properties "

        #region " Appearance "
        /// <summary>
        /// Angels the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        [Category("Appearance")]
        //public Alignment TextAlignment
        //{
        //    get { return A; }
        //    set
        //    {
        //        A = value;
        //        Invalidate();
        //    }
        //}

        #endregion

        #endregion

        #region " Paint "

        void Angel_PaintHook(PaintEventArgs e)
        {
            
            G.Clear(Color.Black);
            G.DrawRectangle(new Pen(Color.FromArgb(10, 33, 55)), new Rectangle(0, 0, Width - 1, H));
            G.FillRectangle(new LinearGradientBrush(new Point(1, 1), new Point(1, H), Color.FromArgb(75, 168, 218), Color.FromArgb(33, 112, 177)), new Rectangle(1, 1, Width - 2, H - 1));
            G.FillRectangle(new LinearGradientBrush(new Point(2, 2), new Point(2, H - 1), Color.FromArgb(54, 131, 203), Color.FromArgb(26, 86, 145)), new Rectangle(2, 2, Width - 4, H - 3));
            G.DrawRectangle(new Pen(Color.FromArgb(27, 48, 66)), new Rectangle(1, H + 1, Width - 3, Height - H - 3));
            G.FillRectangle(new SolidBrush(Color.FromArgb(17, 33, 47)), new Rectangle(2, H + 1, Width - 4, Height - H - 3));

            StringFormat F = new StringFormat { LineAlignment = StringAlignment.Center };
            switch (A)
            {
                case Alignment.Left:
                    G.DrawString(Text, Font, Brushes.White, new Rectangle(8, 0, Width, H), F);
                    break;
                case Alignment.Center:
                    F.Alignment = StringAlignment.Center;
                    G.DrawString(Text, Font, Brushes.White, new Rectangle(0, 0, Width - 1, H), F);
                    break;
                case Alignment.Right:
                    G.DrawString(Text, Font, Brushes.White, new Rectangle(Width - TextRenderer.MeasureText(Text, Font).Width - 8, 0, TextRenderer.MeasureText(Text, Font).Width + 8, H), F);
                    break;
            }

        }



        #endregion

        #endregion


        #endregion

        #region 5. Anom

        /// <summary>
        /// Anoms the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Anom_PaintHook(PaintEventArgs e)
        {
            G.Clear(border);
            LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(1, 1, Width - 2, Height - 2), Color.FromArgb(255, 222, 222, 222), Color.FromArgb(255, 170, 170, 170), 45f);
            HatchBrush HB = new HatchBrush(HatchStyle.LightDownwardDiagonal, Color.FromArgb(100, Color.Gray), Color.Transparent);
            G.FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 0, Width - 1, Height - 1));
            G.FillRectangle(LGB, new Rectangle(1, 1, Width - 2, Height - 2));
            G.FillRectangle(HB, new Rectangle(1, 1, Width - 2, Height - 2));
            G.FillRectangle(new SolidBrush(Color.Black), new Rectangle(6, 36, Width - 12, Height - 43));
            G.FillRectangle(new SolidBrush(BackColor), new Rectangle(7, 37, Width - 14, Height - 45));
            int TextXPos = 30;
            if ((Parent.FindForm().ShowIcon))
            {
                TextXPos = 30;
            }
            else
            {
                TextXPos = 6;
            }
            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(ForeColor), new Point(TextXPos, 10));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(10, 10, 16, 16));
        }

        #endregion

        #region 6. Aryan

        /// <summary>
        /// Aryans the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Aryan_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(25, 25, 25));
            DrawGradient(Color.FromArgb(255, 0, 0), Color.FromArgb(255, 0, 0), new Rectangle(0, 0, Width, 35), 90);

            HatchBrush T = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(25, 25, 25), Color.FromArgb(35, 35, 35));
            G.FillRectangle(T, new Rectangle(11, 25, Width - 23, Height - 36));

            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(22, 22, 22))), new Rectangle(11, 25, Width - 23, Height - 36));
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(40, 40, 40))), new Rectangle(12, 26, Width - 25, Height - 38));
            DrawCorners(Color.FromArgb(40, 40, 40), new Rectangle(11, 25, Width - 22, Height - 35));

            DrawBorders(new Pen(new SolidBrush(Color.FromArgb(25, 25, 25))), 1);
            DrawBorders(new Pen(new SolidBrush(Color.FromArgb(25, 25, 25))));
            DrawCorners(TransparencyKey);
            DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Left, 15, -3);
        }


        #endregion

        #region 7. Atrocity


        #region "Close Button Border property"
        /// <summary>
        /// The draw c button border
        /// </summary>
        [Description("Choose weather or not to draw the border around the close button; Fixed Position!"), Browsable(true)]
        private bool _drawCButtonBorder = true;
        /// <summary>
        /// Gets or sets a value indicating whether [draw c button border].
        /// </summary>
        /// <value><c>true</c> if [draw c button border]; otherwise, <c>false</c>.</value>
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


        /// <summary>
        /// Atrocities the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
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

        #region 8. Avatar

        /// <summary>
        /// Avatars the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Avatar_PaintHook(PaintEventArgs e)
        {
            LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(255, 32, 32, 32), Color.FromArgb(255, 10, 10, 10), 90f);
            G.DrawRectangle(new Pen(Border), new Rectangle(0, 0, Width, Height));
            G.FillRectangle(LGB1, new Rectangle(0, 0, Width, Height));
            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(ForeColor), new Point(25, 5));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(7, 6, 16, 16));
            //Dim HB As New HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(175, Color.DarkBlue), Color.FromArgb(255, 21, 21, 21))
            LinearGradientBrush LGB2 = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(125, Color.DeepSkyBlue), Color.FromArgb(175, 25, 25, 112), 85f);
            G.FillRectangle(LGB2, new Rectangle(6, 25, Width - 11, Height - 30));
            DrawCorners(Color.Fuchsia);

            
        }

        #endregion

        #region 9. AVG

        /// <summary>
        /// Averages the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void AVG_PaintHook(PaintEventArgs e)
        {
            G.Clear(Border);
            G.FillRectangle(new SolidBrush(Color.FromArgb(39, 43, 57)), new Rectangle(1, 1, Width - 2, Height - 2));
            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(ForeColor), new Point(40, 20));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(9, 18, 25, 25));
        }

        #endregion

        #region 10. Basic Code

        /// <summary>
        /// The blend
        /// </summary>
        private ColorBlend Blend;

        /// <summary>
        /// The glow position
        /// </summary>
        private float GlowPosition = -1f;
        /// <summary>
        /// Moves the glow.
        /// </summary>
        private void MoveGlow()
        {
            while (true)
            {
                GlowPosition += 0.01f;
                if (GlowPosition >= 1f)
                    GlowPosition = -1f;
                Invalidate();
                System.Threading.Thread.Sleep(60);
            }
        }
        /// <summary>
        /// The text position
        /// </summary>
        private float TextPosition = -1f;
        /// <summary>
        /// Moves the text.
        /// </summary>
        private void MoveText()
        {
            while (true)
            {
                TextPosition += 0.01f;
                if (TextPosition >= 1f)
                    TextPosition = -1f;
                Invalidate();
                System.Threading.Thread.Sleep(60);
            }
        }
        /// <summary>
        /// The base points
        /// </summary>
        private Point[] BasePoints;
        /// <summary>
        /// The base brush
        /// </summary>
        private LinearGradientBrush BaseBrush;
        /// <summary>
        /// The base col
        /// </summary>
        private Color BaseCol;
        /// <summary>
        /// The base col2
        /// </summary>
        private Color BaseCol2;
        /// <summary>
        /// The t box
        /// </summary>
        private Point[] TBox;
        /// <summary>
        /// The ti box
        /// </summary>
        private Point[] TIBox;
        /// <summary>
        /// The TRP box
        /// </summary>
        private Point[] TRPBox;
        /// <summary>
        /// The h brush
        /// </summary>
        private HatchBrush HBrush;

        /// <summary>
        /// Basics the code paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void BasicCode_PaintHook(PaintEventArgs e)
        {
            Blend = new ColorBlend();
            Blend.Colors = new Color[] {
                Color.FromArgb(16, 16, 16),
                Color.FromArgb(46, 46, 46),
                Color.FromArgb(46, 46, 46),
                Color.FromArgb(16, 16, 16)
            };
            Blend.Positions = new float[] {
                0f,
                0.45f,
                0.65f,
                1f
            };

            TBox = new Point[] {
                new Point(98, 1),
                new Point(ClientRectangle.Width - 98, 1),
                new Point(ClientRectangle.Width - 98, 22),
                new Point(98, 22),
                new Point(98, 1)
            };
            TIBox = new Point[] {
                new Point(101, 4),
                new Point(ClientRectangle.Width - 101, 4),
                new Point(ClientRectangle.Width - 101, 19),
                new Point(101, 19),
                new Point(101, 4)
            };
            TRPBox = new Point[] {
                new Point(100, 3),
                new Point(ClientRectangle.Width - 100, 3),
                new Point(ClientRectangle.Width - 100, 20),
                new Point(100, 20),
                new Point(100, 3)
            };
            BaseCol = Color.FromArgb(255, 170, 0, 0);
            BaseCol2 = Color.FromArgb(255, 150, 0, 0);
            BaseBrush = new LinearGradientBrush(ClientRectangle, BaseCol, BaseCol2, LinearGradientMode.Vertical);
            G.FillRectangle(BaseBrush, ClientRectangle);
            HBrush = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(24, 24, 24), Color.FromArgb(8, 8, 8));

            G.FillRectangle(HBrush, 11, 30, Width - 22, Height - 41);
            G.DrawLines(new Pen(Color.FromArgb(32, 32, 32), 1), TBox);
            G.FillRectangle(new SolidBrush(Color.FromArgb(50, 50, 50)), 98, 1, ClientRectangle.Width - 196, 8);
            DrawGradient(Color.FromArgb(8, 8, 8), Color.FromArgb(23, 23, 23), 98, 1, ClientRectangle.Width - 196, 22, 90f);
            G.SetClip(new Rectangle(101, 3, ClientRectangle.Width - 201, 17));
            G.FillRectangle(new SolidBrush(Color.FromArgb(16, 16, 16)), 98, 1, ClientRectangle.Width - 196, 22);
            DrawGradient(Blend, Convert.ToInt32(GlowPosition * ClientRectangle.Width + 50), 1, ClientRectangle.Width - 196, 22, 0f);
            G.DrawLines(new Pen(Color.FromArgb(15, Color.White), 1), TIBox);
            DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, -Convert.ToInt32(TextPosition * ClientRectangle.Width + 50), 0);
            G.ResetClip();
            G.FillRectangle(new SolidBrush(Color.FromArgb(26, Color.White)), 98, 1, ClientRectangle.Width - 196, 8);
            G.DrawLines(Pens.Black, TRPBox);
            G.DrawLines(Pens.Black, TBox);
            DrawBorders(Pens.Maroon, 0);
            DrawCorners(Color.Red, 0);
        }


        #endregion

        #region 11. Beta Blue

        /// <summary>
        /// Betas the blue paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void BetaBlue_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromKnownColor(KnownColor.Control));
            // Clear the form first
            //DrawGradient(Color.FromArgb(0, 105, 246), Color.FromArgb(0, 81, 181), 0, 0, Width, Height, 90S)   ' Form Gradient
            G.Clear(Color.FromArgb(0, 95, 218));
            DrawGradient(Color.FromArgb(0, 95, 218), Color.FromArgb(0, 55, 202), 0, 0, Width, 25, 90);
            // Form Top Bar

            DrawCorners(Color.Fuchsia, ClientRectangle);
            // Then draw some clean corners
            DrawBorders(Pens.DarkBlue, Pens.DodgerBlue, ClientRectangle);
            // Then we draw our form borders

            G.DrawLine(Pens.Black, 0, 25, Width, 25);
            // Top Line
            //G.DrawLine(Pens.Black, 0, Height - 25, Width, Height - 25)   ' Bottom Line

            DrawText(HorizontalAlignment.Left, Color.White, 8, 2);
            // Finally, we draw our text
        }

        #endregion

        #region 12. Beyond 

        /// <summary>
        /// Beyonds the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Beyond_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.White);
            DrawGradient(Color.FromArgb(15, 15, 15), Color.FromArgb(30, 30, 30), 0, 0, Width, Height, 90);
            DrawGradient(Color.FromArgb(50, 50, 50), Color.FromArgb(70, 70, 70), 0, 0, Width, Height);
            G.DrawLine(new Pen(Color.FromArgb(50, 50, 50)), 0, 0, 0, 20);
            G.DrawLine(new Pen(Color.FromArgb(50, 50, 50)), Width - 1, 0, Width - 1, 25);
            G.DrawLine(new Pen(Color.FromArgb(20, 20, 20)), 0, 0, 0, Height);
            G.DrawLine(new Pen(Color.FromArgb(20, 20, 20)), Width - 1, 0, Width - 1, Height);
            G.DrawLine(new Pen(Color.FromArgb(20, 20, 20)), 0, Height - 1, Width, Height - 1);
            G.FillRectangle(new SolidBrush(Color.FromArgb(15, 15, 15)), 10, 20, Width - 20, Height - 30);
            G.DrawLine(new Pen(Color.FromArgb(20, 20, 20)), 0, 0, Width, 0);
            DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
        }

        #endregion

        #region 13. Bionic

        #region " Declarations "
        /// <summary>
        /// Down
        /// </summary>
        private bool _Down = false;
        /// <summary>
        /// The header
        /// </summary>
        private int _Header = 34;
        #endregion
        /// <summary>
        /// The mouse point
        /// </summary>
        private Point _MousePoint;

        #region " MouseStates "
        /// <summary>
        /// Bionics the on mouse up.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        void Bionic_OnMouseUp(MouseEventArgs e)
        {
            //base.OnMouseUp(e);
            _Down = false;
        }
        // Get more free themes at ThemesVB.NET
        /// <summary>
        /// Bionics the on mouse down.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        void Bionic_OnMouseDown(MouseEventArgs e)
        {
            //base.OnMouseDown(e);
            if (e.Location.Y < _Header && e.Button == MouseButtons.Left)
            {
                _Down = true;
                _MousePoint = e.Location;
            }
        }

        /// <summary>
        /// Bionics the on mouse move.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        void Bionic_OnMouseMove(MouseEventArgs e)
        {
            //base.OnMouseMove(e);
            if (_Down == true)
            {
                ParentForm.Location = new Point(MousePosition.X - _MousePoint.X, MousePosition.Y - _MousePoint.Y);
            }
        }
        #endregion

        /// <summary>
        /// Bionics the on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Bionic_OnPaint(PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.Clear(Color.FromArgb(29, 29, 29));
            G.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), new Rectangle(2, 2, Width - 4, 15));
            G.FillRectangle(new SolidBrush(Color.FromArgb(48, 48, 48)), new Rectangle(2, 32, Width - 4, Height - 34));
            StringFormat _StringF = new StringFormat();
            _StringF.Alignment = StringAlignment.Center;
            _StringF.LineAlignment = StringAlignment.Center;
            G.DrawString(Parent.FindForm().Text, new Font("Arial", 11), Brushes.White, new RectangleF(2, 2, Width - 4, 30), _StringF);
        }

        #endregion

        #region 14. Black Shades

        #region " Control Help - Movement & Flicker Control "
        /// <summary>
        /// The mouse p
        /// </summary>
        private Point MouseP = new Point(0, 0);
        /// <summary>
        /// The cap
        /// </summary>
        private bool Cap = false;
        /// <summary>
        /// The move height
        /// </summary>
        private int MoveHeight;

        /// <summary>
        /// The position
        /// </summary>
        private int pos = 0;

        /// <summary>
        /// Blacks the shades on paint.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        void BlackShades_OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            const int curve = 7;
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            
            G.SmoothingMode = SmoothingMode.Default;
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            Color TransparencyKey = this.ParentForm.TransparencyKey;
            Draw d = new Draw();
            
            G.Clear(TransparencyKey);

            G.FillPath(new SolidBrush(Color.FromArgb(42, 47, 49)), d.RoundRect(ClientRectangle, curve));


            //DRAW GRADIENTED BORDER
            LinearGradientBrush innerGradLeft = new LinearGradientBrush(new Rectangle(1, 1, Width / 2 - 1, Height - 3), Color.FromArgb(102, 108, 112), Color.FromArgb(204, 216, 224), 0f);
            LinearGradientBrush innerGradRight = new LinearGradientBrush(new Rectangle(1, 1, Width / 2 - 1, Height - 3), Color.FromArgb(204, 216, 224), Color.FromArgb(102, 108, 112), 0f);
            G.DrawPath(new Pen(innerGradLeft), d.RoundRect(new Rectangle(1, 1, Width / 2 + 3, Height - 3), curve));
            G.DrawPath(new Pen(innerGradRight), d.RoundRect(new Rectangle(Width / 2 - 5, 1, Width / 2 + 3, Height - 3), curve));


            G.FillPath(new SolidBrush(Color.FromArgb(42, 47, 49)), d.RoundRect(new Rectangle(2, 2, Width - 5, Height - 5), curve));


            LinearGradientBrush topGradLeft = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, 25), Color.FromArgb(42, 46, 48), Color.FromArgb(93, 98, 101), 0f);
            LinearGradientBrush topGradRight = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, 25), Color.FromArgb(93, 98, 101), Color.FromArgb(42, 46, 48), 0f);
            G.FillPath(topGradLeft, d.RoundRect(new Rectangle(2, 2, Width / 2 + 2, 25), curve));
            G.FillPath(topGradRight, d.RoundRect(new Rectangle(Width / 2 - 3, 2, Width / 2 - 1, 25), curve));

            G.FillRectangle(new SolidBrush(Color.FromArgb(42, 47, 49)), new Rectangle(2, 23, Width - 5, 10));

            G.DrawPath(new Pen(Color.FromArgb(42, 46, 48)), d.RoundRect(new Rectangle(2, 2, Width - 5, Height - 5), curve));
            G.DrawPath(new Pen(Color.FromArgb(9, 11, 12)), d.RoundRect(ClientRectangle, curve));

            G.DrawString(Text, Font, Brushes.White, new Rectangle(curve, curve - 2, Width - 1, 22), new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near
            });

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            G.Dispose();
            B.Dispose();
        }


        #endregion


        #endregion

        #region 15. Bloody


        /// <summary>
        /// Bloodies the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Bloody_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(195, 100, 0, 0));
            //Lignes diagonales
            HatchBrush HB = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(200, 45, 0, 0), Color.Black);
            //Dessine le "fond"
            G.FillRectangle(new SolidBrush(BackColor), new Rectangle(6, 24, Width - 12, Height - 30));
            //Dessine les lignes diagonales
            G.FillRectangle(HB, new Rectangle(6, 24, Width - 12, Height - 30));


            G.DrawString(Text, Font, new SolidBrush(ForeColor), new Point(10, 3));
            DrawCorners(Color.Fuchsia);
        }

        #endregion

        #region 16. Blue and White

        #region " Declarations "
        /// <summary>
        /// The over CLS
        /// </summary>
        private bool OverCls;
        /// <summary>
        /// The over maximum
        /// </summary>
        private bool OverMax;
        /// <summary>
        /// The over minimum
        /// </summary>
        private bool OverMin;
        /// <summary>
        /// The xf
        /// </summary>
        private Font XF = new Font("Tahoma", 12);
        /// <summary>
        /// The pf
        /// </summary>
        private Font PF = new Font("Arial", 16);
        /// <summary>
        /// The mf
        /// </summary>
        private Font MF = new Font("Arial", 20);

        /// <summary>
        /// The base
        /// </summary>
        private GraphicsPath Base = new GraphicsPath();
        /// <summary>
        /// The baw header
        /// </summary>
        private GraphicsPath BAWHeader = new GraphicsPath();

        /// <summary>
        /// The base gb
        /// </summary>
        private LinearGradientBrush BaseGB;
        /// <summary>
        /// The header gb
        /// </summary>
        private LinearGradientBrush HeaderGB;
        /// <summary>
        /// The header outline gb
        /// </summary>
        private LinearGradientBrush HeaderOutlineGB;


        /// <summary>
        /// The button outer gb
        /// </summary>
        private LinearGradientBrush ButtonOuterGB = new LinearGradientBrush(new Rectangle(0, 15, 25, 25), Color.FromArgb(89, 158, 228), Color.FromArgb(150, 202, 241), 90);
        /// <summary>
        /// The button inner gb
        /// </summary>
        private LinearGradientBrush ButtonInnerGB = new LinearGradientBrush(new Rectangle(0, 20, 16, 16), Color.FromArgb(185, 211, 239), Color.FromArgb(145, 191, 238), 90);
        /// <summary>
        /// The button o inner gb
        /// </summary>
        private LinearGradientBrush ButtonOInnerGB = new LinearGradientBrush(new Rectangle(0, 22, 16, 16), Color.FromArgb(94, 163, 215), Color.FromArgb(13, 67, 141), 90);


        /// <summary>
        /// The r1
        /// </summary>
        private Rectangle R1;
        /// <summary>
        /// The r2
        /// </summary>
        private Rectangle R2;

        /// <summary>
        /// The p2
        /// </summary>
        private Pen P2;
        /// <summary>
        /// The p1
        /// </summary>
        private Pen P1 = new Pen(Color.FromArgb(128, 128, 128));
        // P2 is in the OnSizeChanged event.
        /// <summary>
        /// The p3
        /// </summary>
        private Pen P3 = new Pen(Color.FromArgb(180, 217, 246));
        /// <summary>
        /// The b1
        /// </summary>
        private SolidBrush B1 = new SolidBrush(Color.FromArgb(58, 118, 181));
        /// <summary>
        /// The b2
        /// </summary>
        private SolidBrush B2 = new SolidBrush(Color.FromArgb(71, 132, 191));
        /// <summary>
        /// The b3
        /// </summary>
        private SolidBrush B3 = new SolidBrush(Color.FromArgb(128, 0, 0, 0));

        /// <summary>
        /// The CSF
        /// </summary>
        private StringFormat CSF = new StringFormat { Alignment = StringAlignment.Center };
        #endregion

        /// <summary>
        /// The draw button strings
        /// </summary>
        private bool _DrawButtonStrings = true;

        #region " Properties "
        /// <summary>
        /// Gets or sets a value indicating whether [draw button strings].
        /// </summary>
        /// <value><c>true</c> if [draw button strings]; otherwise, <c>false</c>.</value>
        [Category("Drawing")]
        public bool DrawButtonStrings
        {
            get { return _DrawButtonStrings; }
            set { _DrawButtonStrings = value; }
        }
        #endregion

        /// <summary>
        /// Blues the and white construtor.
        /// </summary>
        void BlueAndWhite_Construtor()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            BackColor = Color.White;
            Dock = DockStyle.Fill;
            DoubleBuffered = true;
            
        }

        /// <summary>
        /// Blues the and white create handle.
        /// </summary>
        void BlueAndWhite_CreateHandle()
        {
            Font = new Font("Arial", 12, FontStyle.Bold);
            
            Parent.FindForm().FormBorderStyle = FormBorderStyle.None;
            if (Parent.FindForm().TransparencyKey == null)
                Parent.FindForm().TransparencyKey = Color.Fuchsia;
            
        }

        /// <summary>
        /// Blues the and white on mouse down.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        void BlueAndWhite_OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (OverMin)
                {
                    Parent.FindForm().WindowState = FormWindowState.Minimized;
                }
                else if (OverMax)
                {
                    if (Parent.FindForm().WindowState == FormWindowState.Maximized)
                        Parent.FindForm().WindowState = FormWindowState.Normal;
                    else
                        Parent.FindForm().WindowState = FormWindowState.Maximized;
                }
                else if (OverCls)
                {
                    Parent.FindForm().Close();
                }
                else
                {
                    if (new Rectangle(Parent.FindForm().Location.X, Parent.FindForm().Location.Y, Width, 50).IntersectsWith(new Rectangle(MousePosition.X, MousePosition.Y, 1, 1)) && !(Parent.FindForm().WindowState == FormWindowState.Maximized))
                    {
                        Capture = false;
                        Message M = Message.Create(Parent.FindForm().Handle, 161, new IntPtr(2), IntPtr.Zero);
                        DefWndProc(ref M);
                    }
                }
            }
            
        }

        /// <summary>
        /// Blues the and white on mouse move.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        void BlueAndWhite_OnMouseMove(MouseEventArgs e)
        {
            if (e.Location.X >= 33 && e.Location.Y >= 19 && e.Location.X <= 120 && e.Location.Y <= 37)
            {
                if (e.Location.X >= 33 && e.Location.X <= 51)
                {
                    OverCls = true;
                    Invalidate();
                }
                else
                {
                    OverCls = false;
                    Invalidate();
                }

                if (e.Location.X >= 104)
                {
                    OverMax = true;
                    Invalidate();
                }
                else
                {
                    OverMax = false;
                    Invalidate();
                }

                if (e.Location.X >= 68 && e.Location.X <= 86)
                {
                    OverMin = true;
                    Invalidate();
                }
                else
                {
                    OverMin = false;
                    Invalidate();
                }
            }
            else
            {
                OverMin = false;
                OverMax = false;
                OverCls = false;
                Invalidate();
            }
            
        }

        /// <summary>
        /// Blues the and white on text changed.
        /// </summary>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void BlueAndWhite_OnTextChanged(System.EventArgs e)
        {
            Invalidate();
           
        }

        /// <summary>
        /// Blues the and white on size changed.
        /// </summary>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        void BlueAndWhite_OnSizeChanged(System.EventArgs e)
        {
            if (Width > 0 && Height > 0)
            {
                

                var _with1 = Base;
                _with1.AddLine(Width - 1, 50, Width - 1, Height - 11);
                _with1.AddArc(Width - 11, Height - 11, 10, 10, 0, 90);
                _with1.AddArc(0, Height - 11, 10, 10, 90, 90);
                _with1.AddLine(0, Height - 11, 0, 50);

                var _with2 = BAWHeader;
                _with2.AddArc(0, 0, 10, 10, 180, 90);
                _with2.AddArc(Width - 11, 0, 10, 10, -90, 90);
                _with2.AddLine(Width - 1, 50, 0, 50);
                _with2.AddLine(0, 50, 0, 5);
                Invalidate();
            }

            Invalidate();
           
        }

        /// <summary>
        /// Blues the and white paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void BlueAndWhite_PaintHook(PaintEventArgs e)
        {
            Graphics _with3 = e.Graphics;
            _with3.SmoothingMode = SmoothingMode.HighQuality;
            _with3.Clear(Color.FromArgb(236, 236, 236));

            BaseGB = new LinearGradientBrush(new Rectangle(0, 50, Width, Height), Color.FromArgb(236, 236, 236), Color.FromArgb(232, 232, 232), 90);
            HeaderGB = new LinearGradientBrush(new Rectangle(0, 0, Width, 50), Color.FromArgb(161, 207, 243), Color.FromArgb(80, 152, 222), 90);
            HeaderOutlineGB = new LinearGradientBrush(new Rectangle(0, 0, Width, 50), Color.FromArgb(102, 167, 227), Color.FromArgb(52, 130, 202), -90);

            R1 = new Rectangle(-1, Convert.ToInt32((50 - Font.Size) / 2 - 1), Width, Height);
            R2 = new Rectangle(0, Convert.ToInt32((50 - Font.Size) / 2 - 2), Width, Height);

            P2 = new Pen(HeaderOutlineGB);

            var _with1 = Base;
            _with1.AddLine(Width - 1, 50, Width - 1, Height - 11);
            _with1.AddArc(Width - 11, Height - 11, 10, 10, 0, 90);
            _with1.AddArc(0, Height - 11, 10, 10, 90, 90);
            _with1.AddLine(0, Height - 11, 0, 50);

            var _with2 = BAWHeader;
            _with2.AddArc(0, 0, 10, 10, 180, 90);
            _with2.AddArc(Width - 11, 0, 10, 10, -90, 90);
            _with2.AddLine(Width - 1, 50, 0, 50);
            _with2.AddLine(0, 50, 0, 5);

            // Base & Header
            _with3.FillPath(BaseGB, Base);
            _with3.DrawPath(P1, Base);

            _with3.FillPath(HeaderGB, BAWHeader);
            _with3.DrawPath(P2, BAWHeader);
            _with3.DrawLine(P3, 4, 1, Width - 5, 1);
            // Little header shine

            
            // Buttons
            if (OverCls)
            {
                _with3.FillEllipse(ButtonOuterGB, 30, 15, 25, 25);
                _with3.FillEllipse(B1, 33, 19, 18, 18);
                _with3.FillEllipse(ButtonOInnerGB, 34, 21, 16, 16);
                if (_DrawButtonStrings)
                    _with3.DrawString("x", XF, B3, 36, 17);
            }
            else
            {
                _with3.FillEllipse(ButtonOuterGB, 30, 15, 25, 25);
                _with3.FillEllipse(B2, 33, 19, 18, 18);
                _with3.FillEllipse(ButtonInnerGB, 34, 19, 16, 16);
            }

            if (OverMax)
            {
                _with3.FillEllipse(ButtonOuterGB, 100, 15, 25, 25);
                _with3.FillEllipse(B1, 103, 19, 18, 18);
                _with3.FillEllipse(ButtonOInnerGB, 104, 21, 16, 16);
                if (_DrawButtonStrings)
                    _with3.DrawString("+", PF, B3, 102, 17);
            }
            else
            {
                _with3.FillEllipse(ButtonOuterGB, 100, 15, 25, 25);
                _with3.FillEllipse(B2, 103, 19, 18, 18);
                _with3.FillEllipse(ButtonInnerGB, 104, 19, 16, 16);
            }

            if (OverMin)
            {
                _with3.FillEllipse(ButtonOuterGB, 65, 15, 25, 25);
                _with3.FillEllipse(B1, 68, 19, 18, 18);
                _with3.FillEllipse(ButtonOInnerGB, 69, 21, 16, 16);
                if (_DrawButtonStrings)
                    _with3.DrawString("-", MF, B3, 69, 10);
            }
            else
            {
                _with3.FillEllipse(ButtonOuterGB, 65, 15, 25, 25);
                _with3.FillEllipse(B2, 68, 19, 18, 18);
                _with3.FillEllipse(ButtonInnerGB, 69, 19, 16, 16);
            }


            _with3.DrawString(Text, Font, Brushes.DarkSlateGray, R1, CSF);
            _with3.DrawString(Text, Font, Brushes.WhiteSmoke, R2, CSF);
            
        }


        #endregion

        #region 17. Booster


        /// <summary>
        /// Boosters the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Booster_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(51, 51, 51));
            DrawGradient(Color.FromArgb(29, 29, 29), Color.FromArgb(65, 65, 65), 0, 28, Width, (Height / 2) - 10);
            DrawGradient(Color.FromArgb(87, 87, 87), Color.FromArgb(49, 49, 49), 0, 0, Width, 25);
            G.DrawLine(Pens.Black, 0, 25, Width, 25);

            G.DrawLine(new Pen(Color.FromArgb(192, 74, 74)), 0, 26, Width, 26);
            G.FillRectangle(new SolidBrush(Color.FromArgb(169, 0, 0)), 0, 27, Width, 27);
            G.FillRectangle(new SolidBrush(Color.FromArgb(45, Color.White)), 0, 27, Width, 13);

            G.DrawLine(new Pen(Color.FromArgb(38, 38, 38)), 0, Height - 25, Width, Height - 25);
            G.DrawLine(new Pen(Color.FromArgb(64, 64, 64)), 0, Height - 24, Width, Height - 24);

            DrawBorders(Pens.Black);
            DrawBorders(new Pen(Color.FromArgb(92, 92, 92)), 1);

            DrawCorners(Color.Fuchsia);
            DrawText(Brushes.Black, HorizontalAlignment.Center, 0, 0);
            DrawText(Brushes.White, HorizontalAlignment.Center, 0, 1);
        }

        #endregion

        #region 18. Blue


        /// <summary>
        /// The blue c1
        /// </summary>
        private Color Blue_C1 = Color.FromArgb(255, 255, 255);
        /// <summary>
        /// The blue b1
        /// </summary>
        private SolidBrush Blue_B1 = new SolidBrush(Color.FromArgb(109, 132, 180));
        /// <summary>
        /// The blue b2
        /// </summary>
        private SolidBrush Blue_B2 = new SolidBrush(Color.FromArgb(242, 242, 242));
        /// <summary>
        /// The blue p1
        /// </summary>
        private Pen Blue_P1 = new Pen(Color.FromArgb(59, 89, 152));
        /// <summary>
        /// The blue p2
        /// </summary>
        private Pen Blue_P2 = new Pen(Color.FromArgb(85, 85, 85));

        /// <summary>
        /// The blue p3
        /// </summary>
        private Pen Blue_P3 = new Pen(Color.FromArgb(204, 204, 204));
        /// <summary>
        /// Blues the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Blue_PaintHook(PaintEventArgs e)
        {
            G.Clear(Blue_C1);
            G.FillRectangle(Blue_B1, 0, 0, Width, 30);
            G.FillRectangle(Blue_B2, 1, Height - 31, Width - 1, 30);
            G.DrawLine(Blue_P1, 0, 0, Width, 0);
            G.DrawLine(Blue_P1, 0, 0, 0, 29);
            G.DrawLine(Blue_P1, 0, 29, Width, 29);
            G.DrawLine(Blue_P1, Width - 1, 0, Width - 1, 29);
            G.DrawLine(Blue_P2, 0, 30, 0, Height);
            G.DrawLine(Blue_P2, Width - 1, 30, Width - 1, Height);
            G.DrawLine(Blue_P2, 0, Height - 1, Width, Height - 1);
            G.DrawLine(Blue_P3, 1, Height - 32, Width - 2, Height - 32);
            DrawText(Brushes.White, HorizontalAlignment.Left, 5, 3);
        }


        #endregion

        #region 19. Border


        /// <summary>
        /// Borders the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Border_PaintHook(PaintEventArgs e)
        {
            HatchBrush hb2 = new HatchBrush(HatchStyle.LightUpwardDiagonal, Color.FromArgb(35, 35, 35));
            G.Clear(Color.Fuchsia);
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(71, 71, 71))), new Rectangle(0, 0, Width - 1, Height - 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(5, 5, 5)), new Rectangle(0, 0, Width - 1, Height - 1));

            G.DrawString(Text, Font, Brushes.Black, new Point(10, 9));
            G.DrawString(Text, Font, Brushes.White, new Point(8, 6));

            //G.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));

            G.FillRectangle(new SolidBrush(Color.FromArgb(55, Color.White)), new Rectangle(0, 0, Width - 1, Height));
            G.FillRectangle(new SolidBrush(Color.FromArgb(5, Color.White)), new Rectangle(0, 0, Width - 1, 17));
            G.DrawRectangle(new Pen(new SolidBrush(Color.Black)), new Rectangle(11, 28, Width - 23, Height - 41));
            G.FillRectangle(new SolidBrush(Color.FromArgb(15, 15, 15)), new Rectangle(12, 29, Width - 24, Height - 42));

            DrawCorners(Color.Magenta);
        }

        #endregion

        #region 20. Bullion

        /// <summary>
        /// The bullion g
        /// </summary>
        Graphics Bullion_G;
        /// <summary>
        /// The bullion b
        /// </summary>
        Bitmap Bullion_B;
        /// <summary>
        /// The bullion r1
        /// </summary>
        Rectangle Bullion_R1;
        /// <summary>
        /// The bullion r2
        /// </summary>
        Rectangle Bullion_R2;
        /// <summary>
        /// The bullion c1
        /// </summary>
        Color Bullion_C1;
        /// <summary>
        /// The bullion c2
        /// </summary>
        Color Bullion_C2;
        /// <summary>
        /// The bullion c3
        /// </summary>
        Color Bullion_C3;
        /// <summary>
        /// The bullion p1
        /// </summary>
        Pen Bullion_P1;
        /// <summary>
        /// The bullion p2
        /// </summary>
        Pen Bullion_P2;
        /// <summary>
        /// The bullion p3
        /// </summary>
        Pen Bullion_P3;
        /// <summary>
        /// The bullion p4
        /// </summary>
        Pen Bullion_P4;
        /// <summary>
        /// The bullion b1
        /// </summary>
        SolidBrush Bullion_B1;
        /// <summary>
        /// The bullion b2
        /// </summary>
        LinearGradientBrush Bullion_B2;

        /// <summary>
        /// The bullion b3
        /// </summary>
        LinearGradientBrush Bullion_B3;

        /// <summary>
        /// Bullions the on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Bullion_OnPaint(PaintEventArgs e)
        {
            Bullion_C1 = Color.FromArgb(248, 248, 248);
            //Background
            Bullion_C2 = Color.FromArgb(255, 255, 255);
            //Highlight
            Bullion_C3 = Color.FromArgb(235, 235, 235);
            //Shadow
            Bullion_P1 = new Pen(Color.FromArgb(215, 215, 215));
            //Border
            Bullion_P4 = new Pen(Color.FromArgb(230, 230, 230));
            //Diagnol Lines
            Bullion_P2 = new Pen(Bullion_C1);
            Bullion_P3 = new Pen(Bullion_C2);
            Bullion_B1 = new SolidBrush(Color.FromArgb(170, 170, 170));

            Bullion_R1 = new Rectangle(0, 2, Width, 18);
            Bullion_R2 = new Rectangle(0, 21, Width, 10);
            Bullion_B2 = new LinearGradientBrush(Bullion_R1, Bullion_C1, Bullion_C3, 90f);
            Bullion_B3 = new LinearGradientBrush(Bullion_R2, Color.FromArgb(18, 0, 0, 0), Color.Transparent, 90f);

            Bullion_B = new Bitmap(Width, Height);
            Bullion_G = Graphics.FromImage(Bullion_B);

            Bullion_G.Clear(Bullion_C1);

            for (int I = 0; I <= Width + 17; I += 4)
            {
                Bullion_G.DrawLine(Bullion_P4, I, 21, I - 17, 37);
                Bullion_G.DrawLine(Bullion_P4, I - 1, 21, I - 16, 37);
            }
            Bullion_G.FillRectangle(Bullion_B3, Bullion_R2);

            Bullion_G.FillRectangle(B2, R1);
            Bullion_G.DrawString(Text, Font, Bullion_B1, 5, 5);

            Bullion_G.DrawRectangle(Bullion_P2, 1, 1, Width - 3, 19);
            Bullion_G.DrawRectangle(Bullion_P3, 1, 39, Width - 3, Height - 41);

            Bullion_G.DrawRectangle(Bullion_P1, 0, 0, Width - 1, Height - 1);
            Bullion_G.DrawLine(Bullion_P1, 0, 21, Width, 21);
            Bullion_G.DrawLine(Bullion_P1, 0, 38, Width, 38);

            e.Graphics.DrawImage(Bullion_B, 0, 0);
            Bullion_G.Dispose();
            Bullion_B.Dispose();
        }

        #endregion

        #region 21. ButterScotch

        /// <summary>
        /// The with events field mytimer
        /// </summary>
        private System.Windows.Forms.Timer withEventsField__mytimer;
        /// <summary>
        /// Gets or sets the mytimer.
        /// </summary>
        /// <value>The mytimer.</value>
        public System.Windows.Forms.Timer _mytimer
        {
            get { return withEventsField__mytimer; }
            set
            {
                if (withEventsField__mytimer != null)
                {
                    withEventsField__mytimer.Tick -= MyTimer_Tick;
                }
                withEventsField__mytimer = value;
                if (withEventsField__mytimer != null)
                {
                    withEventsField__mytimer.Tick += MyTimer_Tick;
                }
            }
        }

        /// <summary>
        /// Handles the Tick event of the MyTimer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            if (_myval == 0)
            {
                _myval = 1;
            }
            else if (_myval == 1)
            {
                _myval = 0;
            }
            Invalidate();
        }

        /// <summary>
        /// The myval
        /// </summary>
        int _myval = 0;
        /// <summary>
        /// The mousepos
        /// </summary>
        private Point _mousepos = new Point(0, 0);
        /// <summary>
        /// The drag
        /// </summary>
        private bool _drag = false;

        /// <summary>
        /// The icon
        /// </summary>
        private Icon _icon;
        //public Icon Icon
        //{
        //    get { return _icon; }
        //    set
        //    {
        //        _icon = value;
        //        Invalidate();
        //    }
        //}

        /// <summary>
        /// The border
        /// </summary>
        private bool _border = true;

        /// <summary>
        /// Gets or sets a value indicating whether [enable border].
        /// </summary>
        /// <value><c>true</c> if [enable border]; otherwise, <c>false</c>.</value>
        [Category("ButterScotch Theme")]
        public bool Enable_Border
        {
            get { return _border; }
            set
            {
                _border = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Class ButterScotchDraw.
        /// </summary>
        static class ButterScotchDraw
        {
            //Special Thanks to Aeonhack for RoundRect Functions... ;)
            /// <summary>
            /// Rounds the rect.
            /// </summary>
            /// <param name="rectangle">The rectangle.</param>
            /// <param name="curve">The curve.</param>
            /// <returns>GraphicsPath.</returns>
            public static GraphicsPath RoundRect(Rectangle rectangle, int curve)
            {
                GraphicsPath p = new GraphicsPath();
                int arcRectangleWidth = curve * 2;
                p.AddArc(new Rectangle(rectangle.X, rectangle.Y, arcRectangleWidth, arcRectangleWidth), -180, 90);
                p.AddArc(new Rectangle(rectangle.Width - arcRectangleWidth + rectangle.X, rectangle.Y, arcRectangleWidth, arcRectangleWidth), -90, 90);
                p.AddArc(new Rectangle(rectangle.Width - arcRectangleWidth + rectangle.X, rectangle.Height - arcRectangleWidth + rectangle.Y, arcRectangleWidth, arcRectangleWidth), 0, 90);
                p.AddArc(new Rectangle(rectangle.X, rectangle.Height - arcRectangleWidth + rectangle.Y, arcRectangleWidth, arcRectangleWidth), 90, 90);
                p.AddLine(new Point(rectangle.X, rectangle.Height - arcRectangleWidth + rectangle.Y), new Point(rectangle.X, curve + rectangle.Y));
                return p;
            }
            /// <summary>
            /// Rounds the rect.
            /// </summary>
            /// <param name="x">The x.</param>
            /// <param name="y">The y.</param>
            /// <param name="width">The width.</param>
            /// <param name="height">The height.</param>
            /// <param name="curve">The curve.</param>
            /// <returns>GraphicsPath.</returns>
            public static GraphicsPath RoundRect(int x, int y, int width, int height, int curve)
            {
                Rectangle rectangle = new Rectangle(x, y, width, height);
                GraphicsPath p = new GraphicsPath();
                int arcRectangleWidth = curve * 2;
                p.AddArc(new Rectangle(rectangle.X, rectangle.Y, arcRectangleWidth, arcRectangleWidth), -180, 90);
                p.AddArc(new Rectangle(rectangle.Width - arcRectangleWidth + rectangle.X, rectangle.Y, arcRectangleWidth, arcRectangleWidth), -90, 90);
                p.AddArc(new Rectangle(rectangle.Width - arcRectangleWidth + rectangle.X, rectangle.Height - arcRectangleWidth + rectangle.Y, arcRectangleWidth, arcRectangleWidth), 0, 90);
                p.AddArc(new Rectangle(rectangle.X, rectangle.Height - arcRectangleWidth + rectangle.Y, arcRectangleWidth, arcRectangleWidth), 90, 90);
                p.AddLine(new Point(rectangle.X, rectangle.Height - arcRectangleWidth + rectangle.Y), new Point(rectangle.X, curve + rectangle.Y));
                return p;
            }

            //Special Thanks to Mephobia's for NoiseBrush Functions...
            /// <summary>
            /// Noises the brush.
            /// </summary>
            /// <param name="colors">The colors.</param>
            /// <returns>TextureBrush.</returns>
            public static TextureBrush NoiseBrush(Color[] colors)
            {
                Bitmap b = new Bitmap(128, 128);
                Random r = new Random(128);
                for (int x = 0; x <= b.Width - 1; x++)
                {
                    for (int y = 0; y <= b.Height - 1; y++)
                    {
                        b.SetPixel(x, y, colors[r.Next(colors.Length)]);
                    }
                }
                TextureBrush T = new TextureBrush(b);
                b.Dispose();
                return T;
            }
        }

        /// <summary>
        /// Butters the scotch paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void ButterScotch_PaintHook(PaintEventArgs e)
        {
            
            
            Bitmap b = new Bitmap(Width, Height);
            Graphics g = Graphics.FromImage(b);
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle headrect = new Rectangle(60, 7, Width - 141, 37);
            
            g.Clear(Color.Fuchsia);
            g.SmoothingMode = SmoothingMode.HighQuality;
            TextureBrush bodygb = ButterScotchDraw.NoiseBrush(new Color[]{
                Color.FromArgb(34, 29, 23),
                Color.FromArgb(50, 45, 39)
            });
            g.FillPath(bodygb, ButterScotchDraw.RoundRect(rect, 3));
            try
            {
                g.DrawIcon(_icon, new Rectangle(8, 8, 38, 38));
            }
            catch
            {
            }
            if (_myval == 0)
            {
                g.DrawString(Text, new Font("Segoe UI", 12, FontStyle.Bold), new SolidBrush(Color.FromArgb(206, 209, 208)), headrect, new StringFormat
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Center
                });
            }
            else if (_myval == 1)
            {
                g.DrawString(Text, new Font("Segoe UI", 12, FontStyle.Bold), new SolidBrush(Color.FromArgb(128, 128, 128)), headrect, new StringFormat
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Center
                });
            }
            if (Enable_Border == true)
            {
                g.DrawPath(new Pen(Color.FromArgb(212, 212, 212), 3), ButterScotchDraw.RoundRect(rect, 3));
            }
            if (!DesignMode)
                _mytimer.Start();
            e.Graphics.DrawImage(b, new Point(0, 0));
            g.Dispose();
            b.Dispose();
        }

        #endregion

        #region 22. Carbon Fibre

        /// <summary>
        /// The show icon
        /// </summary>
        private bool _showIcon = false;

        /// <summary>
        /// Gets or sets a value indicating whether [show icon].
        /// </summary>
        /// <value><c>true</c> if [show icon]; otherwise, <c>false</c>.</value>
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
        /// <summary>
        /// Carbons the fibre paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
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

        #region 23. Chrome 

        /// <summary>
        /// The x
        /// </summary>
        private int X;
        /// <summary>
        /// The y
        /// </summary>
        private int Y;

        /// <summary>
        /// Chromes the constructor.
        /// </summary>
        public void ChromeConstructor()
        {
            
        }

        /// <summary>
        /// Chromes the on mouse move.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        void Chrome_OnMouseMove(MouseEventArgs e)
        {
            X = e.Location.X;
            Y = e.Location.Y;
            
        }

        /// <summary>
        /// Chromes the on mouse click.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        void Chrome_OnMouseClick(MouseEventArgs e)
        {
            if (new Rectangle(Width - 22, 5, 15, 15).Contains(new Point(X, Y)))
            {
                ParentForm.FindForm().Close();
            }
            
        }


        /// <summary>
        /// Chromes the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Chrome_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.White);
            DrawCorners(Color.Fuchsia);
            DrawCorners(Color.Fuchsia, 1, 0, Width - 2, Height);
            DrawCorners(Color.Fuchsia, 0, 1, Width, Height - 2);
            DrawCorners(Color.Fuchsia, 2, 0, Width - 4, Height);
            DrawCorners(Color.Fuchsia, 0, 2, Width, Height - 4);

            G.SmoothingMode = SmoothingMode.HighQuality;
            if (new Rectangle(Width - 22, 5, 15, 15).Contains(new Point(X, Y)))
            {
                G.FillEllipse(new SolidBrush(Color.FromArgb(114, 114, 114)), new Rectangle(Width - 24, 6, 16, 16));
                G.DrawString("r", new Font("Webdings", 8), new SolidBrush(BackColor), new Point(Width - 23, 5));
            }
            else
            {
                G.DrawString("r", new Font("Webdings", 8), new SolidBrush(Color.FromArgb(90, 90, 90)), new Point(Width - 23, 5));
            }

            DrawText(new SolidBrush(ForeColor), new Point(8, 7));
        }

        #endregion

        #region 24. Clarity


        /// <summary>
        /// Clarities the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Clarity_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(31, 31, 31));


            LinearGradientBrush GradientBG = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(67, 68, 69), Color.FromArgb(22, 22, 22), -270);
            G.FillRectangle(GradientBG, new Rectangle(0, 0, Width - 1, Height - 1));


            HatchBrush BodyHatch = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
            G.FillRectangle(BodyHatch, new Rectangle(0, 0, Width - 1, Height - 1));

            G.DrawRectangle(new Pen(Color.FromArgb(32, 32, 32)), new Rectangle(10, 32, Width - 21, Height - 43));
            G.DrawRectangle(new Pen(Color.FromArgb(6, 6, 6)), new Rectangle(9, 31, Width - 19, Height - 41));


            LinearGradientBrush Header = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, 30), Color.FromArgb(25, 25, 25), Color.FromArgb(40, 40, 40), 270);
            G.FillRectangle(Header, new Rectangle(0, 0, Width - 1, 30));
            HatchBrush HeaderHatch = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
            G.FillRectangle(HeaderHatch, new Rectangle(0, 0, Width - 1, 30));
            G.FillRectangle(new SolidBrush(Color.FromArgb(15, Color.White)), 0, 0, Width - 1, 15);

            G.DrawLine(new Pen(Color.FromArgb(42, 42, 42)), 0, 15, Width - 1, 15);



            G.FillRectangle(new SolidBrush(Color.FromArgb(22, 22, 22)), new Rectangle(11, 33, Width - 23, Height - 45));
            G.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));
            G.DrawRectangle(new Pen(Color.FromArgb(49, 49, 49)), new Rectangle(1, 1, Width - 3, Height - 3));


            if (_ShowIcon == false)
            {
                G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(255, 255, 255)), new Rectangle(0, 0, Width, 37), new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                });
            }
            else
            {
                G.DrawIcon(Parent.FindForm().Icon, new Rectangle(new Point(9, 7), new Size(16, 16)));
                G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(255, 255, 255)), new Rectangle(0, 0, Width, 37), new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                });
            }

        }

        #endregion

        #region 25. Classic

        //private Bloom[] Classic_Bloom;
        /// <summary>
        /// The classic r1
        /// </summary>
        private Rectangle Classic_R1;
        /// <summary>
        /// The classic l1
        /// </summary>
        private LinearGradientBrush Classic_L1;
        /// <summary>
        /// The classic h
        /// </summary>
        private HatchBrush Classic_H;

        /// <summary>
        /// Classics the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Classic_PaintHook(PaintEventArgs e)
        {
            //Classic_Bloom = new Bloom[]{
            //    new Bloom("Border", Color.Black),
            //    new Bloom("Highlight Border", Color.FromArgb(87, 87, 87)),
            //    new Bloom("BackColor", Color.FromArgb(51, 51, 51)),
            //    new Bloom("Text Color", Color.FromArgb(128, Color.White)),
            //    new Bloom("Background", Color.FromArgb(73, 73, 73)),
            //    new Bloom("Grid Color", Color.FromArgb(128, 31, 31, 31)),
            //    new Bloom("Gradient #1", Color.FromArgb(128, Color.Black)),
            //    new Bloom("Highlight", Color.FromArgb(26, Color.White)),
            //    new Bloom("Shadow", Color.FromArgb(10, Color.Black)),
            //    new Bloom("Trasparency", Color.Fuchsia)
            //{ Pen = new Pen(Bloom[1].Value, 2) }
            //};
            

            G.Clear(Color.Black);
            DrawBorders(new Pen(Color.FromArgb(87, 87, 87)), 1, 1, Width - 2, Height - 2);
            G.FillRectangle(new SolidBrush(Color.FromArgb(51, 51, 51)), 2, 2, Width - 4, 18);
            G.FillRectangle(new SolidBrush(Color.FromArgb(51, 51, 51)), 2, Height - 20, Width - 4, 18);
            G.DrawLine(new Pen(Color.FromArgb(87, 87, 87)), 2, 21, Width - 2, 21);
            G.FillRectangle(new SolidBrush(Color.FromArgb(73, 73, 73)), 2, 22, Width - 4, Height - 44);
            G.DrawLine(new Pen(Color.FromArgb(87, 87, 87)), 2, Height - 21, Width - 2, Height - 21);

            Classic_H = new HatchBrush(HatchStyle.SmallCheckerBoard, Color.FromArgb(128, 31, 31, 31), Color.Empty);
            Classic_R1 = new Rectangle(2, 2, Width - 4, Height);
            Classic_L1 = new LinearGradientBrush(Classic_R1, Color.Empty, Color.Black, 270f);

            G.FillRectangle(Classic_L1, ClientRectangle);

            G.FillRectangle(Classic_H, 2, 22, Width - 4, Height - 44);

            G.FillRectangle(new SolidBrush(Color.FromArgb(255, Color.FromArgb(18, 17, 17))), 0, 0, Width, 30);

            //G.FillRectangle(new SolidBrush(Color.FromArgb(255,Color.Black)), 0, 4, Width, Height - 10);

            if (_Round)
            {
                G.DrawArc(Pens.Fuchsia, -1, -1, 9, 9, 180, 90);
                G.DrawArc(Pens.Fuchsia, Width - 9, -1, 9, 9, 270, 90);

                G.DrawArc(Pens.Fuchsia, Width - 9, Height - 9, 9, 9, 360, 90);
                G.DrawArc(Pens.Fuchsia, -1, Height - 9, 9, 9, 90, 90);

                G.DrawArc(Pens.Black, 0, 0, 9, 9, 180, 90);
                G.DrawArc(Pens.Black, Width - 10, 0, 9, 9, 270, 90);

                G.DrawArc(Pens.Black, Width - 10, Height - 10, 9, 9, 360, 90);
                G.DrawArc(Pens.Black, 0, Height - 10, 9, 9, 90, 90);
            }
            else
            {
                DrawCorners(Color.Fuchsia);
            }

            DrawText(new SolidBrush(ForeColor), 5, 5);
        }

        /// <summary>
        /// The round
        /// </summary>
        private bool _Round = false;
        /// <summary>
        /// Gets or sets a value indicating whether [new property].
        /// </summary>
        /// <value><c>true</c> if [new property]; otherwise, <c>false</c>.</value>
        public bool NewProperty
        {
            get { return _Round; }
            set
            {
                _Round = value;
                Invalidate();
            }
        }

        #endregion

        #region 26. clsNeoBux


        /// <summary>
        /// CLSs the neo bux paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void clsNeoBux_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Gray);

            //MenuTop
            G.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 242)), new Rectangle(1, 1, Width - 2, Height - 2));

            //Border
            G.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle(1, 35, Width - 2, Height - 38));

            //MainForm
            G.FillRectangle(new SolidBrush(Color.WhiteSmoke), new Rectangle(1, 36, Width - 2, Height - 39));


            //ColorLine
            LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(1, 36, Width - 2, Height - 255), Color.FromArgb(0, 177, 253), Color.FromArgb(46, 202, 56), 180f);
            G.DrawRectangle(new Pen(Color.LightGray), 1, 35, Width - 3, 4);
            G.FillRectangle(LGB, new Rectangle(1, 35, Width - 2, 4));

            //MenuItems
            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(ForeColor), new Point(35, 10));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(10, 10, 16, 16));
            DrawCorners(Color.Fuchsia);

        }

        #endregion

        #region 27. Coca Cola


        /// <summary>
        /// Cocas the cola paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void CocaCola_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Crimson);
            DrawGradient(Color.Brown, Color.Firebrick, 0, 0, Width, 24, 315);
            DrawGradient(Color.Brown, Color.Crimson, 0, 24, Width, Height, 67);
            DrawCorners(Color.RosyBrown, ClientRectangle);

            DrawBorders(new Pen(new SolidBrush(Color.RosyBrown)));
            DrawBorders(new Pen(new SolidBrush(Color.RosyBrown)), 1);
            DrawBorders(new Pen(new SolidBrush(Color.RosyBrown)), 2);

            DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);

        }

        #endregion

        #region 28. Complex

        /// <summary>
        /// Complexes the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Complex_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(190, 190, 190));
            HatchBrush HB = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(2, Color.White), Color.Transparent);
            G.FillRectangle(HB, new Rectangle(0, 0, Width - 1, Height - 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(211, 211, 211)), new Rectangle(6, 36, Width - 13, Height - 43));
            G.FillRectangle(HB, new Rectangle(0, 0, Width - 1, Height - 1));
            G.DrawString(Text, Font, new SolidBrush(ForeColor), new Point(30, 10));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(10, 10, 16, 16));
            DrawCorners(Color.Fuchsia);
        }


        #endregion

        #region 29. Crystal
        /// <summary>
        /// The rounding
        /// </summary>
        private RoundingType _Rounding;
        /// <summary>
        /// Enum RoundingType
        /// </summary>
        public enum RoundingType : int
        {
            /// <summary>
            /// The type one
            /// </summary>
            TypeOne = 1,
            /// <summary>
            /// The type two
            /// </summary>
            TypeTwo = 2,
            /// <summary>
            /// The none
            /// </summary>
            None = 0
        }

        /// <summary>
        /// Gets or sets the rounding.
        /// </summary>
        /// <value>The rounding.</value>
        [Category("Crystal Theme")]
        public RoundingType Rounding
        {
            get { return _Rounding; }
            set { _Rounding = value; }
        }


        /// <summary>
        /// Crystals the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Crystal_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(230, 230, 230));

            //Draw titlebar gradient
            LinearGradientBrush LB = new LinearGradientBrush(new Rectangle(new Point(1, 1), new Size(Width - 2, 25)), Color.FromArgb(230, 230, 230), Color.FromArgb(210, 210, 210), 90f);
            G.FillRectangle(LB, new Rectangle(new Point(1, 1), new Size(Width - 2, 25)));

            //Draw glow
            G.FillRectangle(new SolidBrush(Color.FromArgb(230, 230, 230)), new Rectangle(new Point(1, 1), new Size(Width - 2, 11)));

            //Draw outline + rounded corners
            G.DrawRectangle(new Pen(Color.FromArgb(170, 170, 170)), new Rectangle(0, 0, Width - 1, Height - 1));
            G.DrawLine(new Pen(Color.FromArgb(170, 170, 170)), new Point(0, 26), new Point(Width, 26));

            switch (_Rounding)
            {
                case RoundingType.TypeOne:
                    //////left upper corner
                    DrawPixel(Color.Fuchsia, 0, 0);
                    DrawPixel(Color.Fuchsia, 1, 0);
                    DrawPixel(Color.Fuchsia, 0, 1);
                    DrawPixel(Color.FromArgb(170, 170, 170), 1, 1);
                    //////right upper corner
                    DrawPixel(Color.Fuchsia, Width - 1, 0);
                    DrawPixel(Color.Fuchsia, Width - 2, 0);
                    DrawPixel(Color.Fuchsia, Width - 1, 1);
                    DrawPixel(Color.FromArgb(170, 170, 170), Width - 2, 1);
                    //////left bottom corner
                    DrawPixel(Color.Fuchsia, 0, Height - 1);
                    DrawPixel(Color.Fuchsia, 1, Height - 1);
                    DrawPixel(Color.Fuchsia, 0, Height - 2);
                    DrawPixel(Color.FromArgb(170, 170, 170), 1, Height - 2);
                    //////right bottom corner
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 2, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 2);
                    DrawPixel(Color.FromArgb(170, 170, 170), Width - 2, Height - 2);
                    break;
                case RoundingType.TypeTwo:
                    //////left upper corner
                    DrawPixel(Color.Fuchsia, 0, 0);
                    DrawPixel(Color.Fuchsia, 1, 0);
                    DrawPixel(Color.Fuchsia, 2, 0);
                    DrawPixel(Color.Fuchsia, 3, 0);
                    DrawPixel(Color.Fuchsia, 0, 1);
                    DrawPixel(Color.Fuchsia, 0, 2);
                    DrawPixel(Color.Fuchsia, 0, 3);
                    DrawPixel(Color.Fuchsia, 1, 1);
                    DrawPixel(Color.FromArgb(170, 170, 170), 2, 1);
                    DrawPixel(Color.FromArgb(170, 170, 170), 3, 1);
                    DrawPixel(Color.FromArgb(170, 170, 170), 1, 2);
                    DrawPixel(Color.FromArgb(170, 170, 170), 1, 3);
                    //////right upper corner
                    DrawPixel(Color.Fuchsia, Width - 1, 0);
                    DrawPixel(Color.Fuchsia, Width - 2, 0);
                    DrawPixel(Color.Fuchsia, Width - 3, 0);
                    DrawPixel(Color.Fuchsia, Width - 4, 0);
                    DrawPixel(Color.Fuchsia, Width - 1, 1);
                    DrawPixel(Color.Fuchsia, Width - 1, 2);
                    DrawPixel(Color.Fuchsia, Width - 1, 3);
                    DrawPixel(Color.Fuchsia, Width - 2, 1);
                    DrawPixel(Color.FromArgb(170, 170, 170), Width - 3, 1);
                    DrawPixel(Color.FromArgb(170, 170, 170), Width - 4, 1);
                    DrawPixel(Color.FromArgb(170, 170, 170), Width - 2, 2);
                    DrawPixel(Color.FromArgb(170, 170, 170), Width - 2, 3);
                    //////left bottom corner
                    DrawPixel(Color.Fuchsia, 0, Height - 1);
                    DrawPixel(Color.Fuchsia, 0, Height - 2);
                    DrawPixel(Color.Fuchsia, 0, Height - 3);
                    DrawPixel(Color.Fuchsia, 0, Height - 4);
                    DrawPixel(Color.Fuchsia, 1, Height - 1);
                    DrawPixel(Color.Fuchsia, 2, Height - 1);
                    DrawPixel(Color.Fuchsia, 3, Height - 1);
                    DrawPixel(Color.Fuchsia, 1, Height - 2);
                    DrawPixel(Color.FromArgb(170, 170, 170), 2, Height - 2);
                    DrawPixel(Color.FromArgb(170, 170, 170), 3, Height - 2);
                    DrawPixel(Color.FromArgb(170, 170, 170), 1, Height - 3);
                    DrawPixel(Color.FromArgb(170, 170, 170), 1, Height - 4);
                    //////right bottom corner
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 2);
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 3);
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 4);
                    DrawPixel(Color.Fuchsia, Width - 2, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 3, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 4, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 2, Height - 2);
                    DrawPixel(Color.FromArgb(170, 170, 170), Width - 3, Height - 2);
                    DrawPixel(Color.FromArgb(170, 170, 170), Width - 4, Height - 2);
                    DrawPixel(Color.FromArgb(170, 170, 170), Width - 2, Height - 3);
                    DrawPixel(Color.FromArgb(170, 170, 170), Width - 2, Height - 4);
                    break;
            }



            //Draw title & icon
            G.DrawString(Parent.FindForm().Text, new Font("Segoe UI", 9), Brushes.Black, new Point(27, 5));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(7, 6, 16, 16));
        }


        #endregion

        #region 30. Cypher


        /// <summary>
        /// The bgimagee
        /// </summary>
        Bitmap Bgimagee;

        /// <summary>
        /// The balk
        /// </summary>
        Rectangle Balk;

        /// <summary>
        /// Creates the bg.
        /// </summary>
        /// <returns>Bitmap.</returns>
        public Bitmap CreateBg()
        {
            Bitmap b = new Bitmap(5, 5);
            Graphics g = Graphics.FromImage(b);
            Color P1 = Color.FromArgb(29, 25, 22);
            Color P2 = Color.FromArgb(35, 31, 28);

            for (int y = 0; y <= Height; y += 4)
            {
                for (int x = 3; x <= Width; x += 4)
                {
                    g.FillRectangle(new SolidBrush(P1), new Rectangle(x, y, 1, 1));
                    g.FillRectangle(new SolidBrush(P2), new Rectangle(x, y + 1, 1, 1));
                    try
                    {
                        g.FillRectangle(new SolidBrush(P1), new Rectangle(x + 2, y + 2, 1, 1));
                        g.FillRectangle(new SolidBrush(P2), new Rectangle(x + 2, y + 3, 1, 1));
                    }
                    catch
                    {
                    }
                }
            }

            return (Bitmap)b.Clone();


        }

        /// <summary>
        /// The entered minimize
        /// </summary>
        bool EnteredMinimize = false;

        /// <summary>
        /// The entred close
        /// </summary>
        bool EntredClose = false;
        /// <summary>
        /// The temporary bitmap
        /// </summary>
        Bitmap TempBitmap = new Bitmap(32, 32);
        //public Bitmap ResizeIcon()
        //{
        //    Icon TempIcon = Icon;

        //    Graphics BitmapGraphic = Graphics.FromImage(TempBitmap);
        //    int XPos = 0;
        //    int YPos = 0;
        //    XPos = (TempBitmap.Width - TempIcon.Width) / 2;
        //    YPos = (TempBitmap.Height - TempIcon.Height) / 2;

        //    BitmapGraphic.DrawIcon(TempIcon, new Rectangle(XPos, YPos, TempIcon.Width, TempIcon.Height));
        //    return TempBitmap;
        //}

        /// <summary>
        /// The icon
        /// </summary>
        Icon _Icon;
        //public Icon Icon
        //{
        //    get { return _Icon; }
        //    set
        //    {
        //        _Icon = value;
        //        if (Parent is System.Windows.Forms.Form)
        //        {
        //            var _with2 = (System.Windows.Forms.Form)Parent;
        //            _with2.Icon = value;
        //            _Icon = value;
        //            Invalidate();
        //        }
        //    }
        //}

        /// <summary>
        /// The fading out
        /// </summary>
        bool FadingOut = true;
        // <summary>
        // This boolean indicates the use of the Fade Out Effect on close
        // </summary>
        /// <summary>
        /// Gets or sets a value indicating whether [use fade out].
        /// </summary>
        /// <value><c>true</c> if [use fade out]; otherwise, <c>false</c>.</value>
        public bool UseFadeOut
        {
            get { return FadingOut; }
            set { FadingOut = value; }
        }

        //bool Minibox = true;
        //public bool MinimizeBox
        //{
        //    get { return Minibox; }
        //    set
        //    {
        //        Minibox = value;
        //        Invalidate();
        //    }
        //}

        /// <summary>
        /// Fades the out.
        /// </summary>
        /// <returns>System.Object.</returns>
        public object FadeOut()
        {
            if (Parent is System.Windows.Forms.Form)
            {
                var _with7 = (System.Windows.Forms.Form)Parent;
                for (double i = 1; i >= 0.0; i += -0.1)
                {
                    _with7.Opacity = i;
                    System.Threading.Thread.Sleep(50);
                }
            }
            return true;
        }

        #region " Global Variables "
        /// <summary>
        /// The point
        /// </summary>
        Point Point = new Point();
        //int X;
        //#endregion
        //int Y;


        #endregion

        /// <summary>
        /// Cyphers the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        void Cypher_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {
            Balk = new Rectangle(4, 4, Width - 8, 27);

            Bgimagee = CreateBg();

            
            using (Bitmap b = new Bitmap(Width, Height))
            {
                using (Graphics g = Graphics.FromImage(b))
                {
                    g.FillRectangle(new SolidBrush(Color.FromArgb(25, 18, 12)), new Rectangle(0, 0, Width, Height));

                    Color P1 = Color.FromArgb(29, 25, 22);
                    Color P2 = Color.FromArgb(35, 31, 28);
                    if (!Bgimagee.Equals(null))
                    {
                        g.DrawImage(Bgimagee, 0, 0);
                    }

                    g.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(15, 10, 5))), new Rectangle(0, 0, Width - 2, Height - 1));
                    g.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(55, 45, 35))), new Rectangle(1, 1, Width - 3, Height - 3));
                    g.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(75, 70, 65)), 2), new Rectangle(3, 3, Width - 6, Height - 6));



                    Rectangle BovenHelftBalk = new Rectangle(4, 4, Width - 8, Convert.ToInt32(27 / 2));
                    Rectangle OnderHelftBalk = new Rectangle(4, Convert.ToInt32(27 / 2) + 2, Width - 8, Convert.ToInt32(27 / 2));

                    g.FillRectangle(new SolidBrush(Color.FromArgb(200, Color.FromArgb(75, 70, 65))), BovenHelftBalk);
                    g.FillRectangle(new SolidBrush(Color.FromArgb(230, P2)), OnderHelftBalk);

                    g.DrawIcon(Parent.FindForm().Icon, new Rectangle(10, 10, 16, 16));

                    SizeF S = g.MeasureString(Text, Font);
                    g.DrawString(Text, new Font("Arial", 8, FontStyle.Bold), new SolidBrush(ForeColor), 36, 10);

                    Rectangle MinimizeRec = new Rectangle(Width - 32, 16, 9, 5);

                    if (MinimizeBox)
                    {
                        switch (EnteredMinimize)
                        {
                            case true:
                                g.FillRectangle(Brushes.White, MinimizeRec);
                                g.DrawRectangle(new Pen(Color.FromArgb(255, Color.Black), 1), MinimizeRec);
                                break;
                            case false:
                                g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.White)), MinimizeRec);
                                g.DrawRectangle(new Pen(Color.FromArgb(150, Color.Black), 1), MinimizeRec);
                                break;
                        }
                    }

                    switch (EntredClose)
                    {
                        case true:
                            g.DrawString("x", new Font("Arial", 13, FontStyle.Bold), Brushes.White, Width - 20, 5);
                            break;
                        case false:
                            g.DrawString("x", new Font("Arial", 13, FontStyle.Bold), new SolidBrush(Color.FromArgb(100, Color.White)), Width - 20, 5);
                            break;
                    }


                    e.Graphics.DrawImage(b, 0, 0);
                }
            }
            
        }

        /// <summary>
        /// Cyphers the on handle created.
        /// </summary>
        void Cypher_OnHandleCreated()
        {
            Dock = DockStyle.Fill;
            //Bgimagee = CreateBg();
            if (Parent is System.Windows.Forms.Form)
            {
                var _with1 = (System.Windows.Forms.Form)Parent;
                _with1.FormBorderStyle = 0;
                _with1.BackColor = Color.FromArgb(25, 18, 12);
                _with1.ForeColor = Color.White;
                _with1.Font = new Font("Arial", 8);
                _Icon = _with1.Icon;
                _with1.Text = Text;
                DoubleBuffered = true;
                _with1.BackgroundImage = Bgimagee;
                BackgroundImage = Bgimagee;
            }
            
        }

        /// <summary>
        /// Cyphers the on mouse move.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        void Cypher_OnMouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            bool Last = EnteredMinimize;

            Rectangle MinimizeRec = new Rectangle(Width - 32, 16, 9, 5);
            if (MinimizeRec.Contains(e.Location))
            {
                EnteredMinimize = true;
            }
            else
            {
                EnteredMinimize = false;
            }

            if (!(Last == EnteredMinimize))
            {
                Invalidate();
            }

            Last = EntredClose;

            Rectangle CloseRec = new Rectangle(Width - 20, 5, 16, 16);
            if (CloseRec.Contains(e.Location))
            {
                EntredClose = true;
            }
            else
            {
                EntredClose = false;
            }

            if (!(Last == EntredClose))
            {
                Invalidate();
            }

            if (Parent is System.Windows.Forms.Form)
            {
                var _with3 = (System.Windows.Forms.Form)Parent;
                if (e.Button == MouseButtons.Left & e.Location.X < Width & e.Location.Y < Balk.Height)
                {
                    Point = Control.MousePosition;
                    Point.X = Point.X - (X);
                    Point.Y = Point.Y - (Y);
                    _with3.Location = Point;
                }
            }


        }

        /// <summary>
        /// Cyphers the on mouse down.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        void Cypher_OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            if (Parent is System.Windows.Forms.Form)
            {
                var _with4 = (System.Windows.Forms.Form)Parent;
                X = Control.MousePosition.X - _with4.Location.X;
                Y = Control.MousePosition.Y - _with4.Location.Y;
            }

            Rectangle MinimizeRec = new Rectangle(Width - 32, 16, 9, 5);
            if (MinimizeRec.Contains(e.Location))
            {
                if (Parent is System.Windows.Forms.Form)
                {
                    var _with5 = (System.Windows.Forms.Form)Parent;
                    _with5.WindowState = FormWindowState.Minimized;
                }
            }

            Rectangle CloseRec = new Rectangle(Width - 20, 5, 16, 16);
            if (CloseRec.Contains(e.Location))
            {
                if (Parent is System.Windows.Forms.Form)
                {
                    var _with6 = (System.Windows.Forms.Form)Parent;
                    if (FadingOut)
                        FadeOut();
                    _with6.Close();

                }

            }


        }


        #endregion

        #region 31. Dark Matter
        /// <summary>
        /// Enum ColorTheme
        /// </summary>
        public enum ColorTheme
        {
            /// <summary>
            /// The gamma ray
            /// </summary>
            GammaRay = 0,
            /// <summary>
            /// The red shift
            /// </summary>
            RedShift = 1,
            /// <summary>
            /// The subspace
            /// </summary>
            Subspace = 2,
            /// <summary>
            /// The solar flare
            /// </summary>
            SolarFlare = 3
        }
        /// <summary>
        /// The theme color
        /// </summary>
        private ColorTheme _ThemeColor;

        /// <summary>
        /// The t
        /// </summary>
        HatchBrush T = new HatchBrush(HatchStyle.LightUpwardDiagonal, Color.Black, Color.FromArgb(39, 39, 41));
        /// <summary>
        /// The t glow
        /// </summary>
        Color tGlow;
        /// <summary>
        /// The t color
        /// </summary>
        Color tColor;

        /// <summary>
        /// Gets or sets the theme style.
        /// </summary>
        /// <value>The theme style.</value>
        [Category("Dark Matter Theme")]
        public ColorTheme ThemeStyle
        {
            get { return _ThemeColor; }
            set
            {
                _ThemeColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Darks the matter paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void DarkMatter_PaintHook(PaintEventArgs e)
        {
            G.SmoothingMode = SmoothingMode.HighQuality;

            switch (_ThemeColor)
            {
                case ColorTheme.GammaRay:
                    //GammaRay
                    tGlow = Color.FromArgb(35, Color.LawnGreen);
                    tColor = Color.FromArgb(255, Color.LawnGreen);
                    break;
                case ColorTheme.RedShift:
                    //RedShift
                    tGlow = Color.FromArgb(35, Color.Red);
                    tColor = Color.FromArgb(255, Color.Red);
                    break;
                case ColorTheme.Subspace:
                    //SubSpace
                    tGlow = Color.FromArgb(35, Color.DodgerBlue);
                    tColor = Color.FromArgb(255, Color.DodgerBlue);
                    break;
                case ColorTheme.SolarFlare:
                    //SolarFlare
                    tGlow = Color.FromArgb(35, Color.Gold);
                    tColor = Color.FromArgb(255, Color.Gold);
                    break;
            }

            G.Clear(Color.FromArgb(39, 41, 41));
            DrawGradient(Color.FromArgb(109, 109, 111), Color.FromArgb(26, 26, 29), ClientRectangle, 45);
            //Border Out
            DrawGradient(Color.FromArgb(58, 58, 60), Color.FromArgb(14, 14, 14), new Rectangle(2, 2, Width - 4, Height - 4), 45);

            DrawBorders(new Pen(new SolidBrush(Color.Black)));

            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 4, 0);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 4, 1);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 4, -1);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 6, 0);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 6, 1);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 6, -1);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 5, 1);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 5, -1);

            DrawText(new SolidBrush(tColor), HorizontalAlignment.Left, 5, 0);
            DrawCorners(Color.Cyan);
        }

        #endregion

        #region 32. Dark Matter Alt

        /// <summary>
        /// Darks the matter alt paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void DarkMatterAlt_PaintHook(PaintEventArgs e)
        {
            G.SmoothingMode = SmoothingMode.HighQuality;

            switch (_ThemeColor)
            {
                case ColorTheme.GammaRay:
                    //GammaRay
                    tGlow = Color.FromArgb(35, Color.LawnGreen);
                    tColor = Color.FromArgb(255, Color.LawnGreen);
                    break;
                case ColorTheme.RedShift:
                    //RedShift
                    tGlow = Color.FromArgb(35, Color.Red);
                    tColor = Color.FromArgb(255, Color.Red);
                    break;
                case ColorTheme.Subspace:
                    //SubSpace
                    tGlow = Color.FromArgb(35, Color.DodgerBlue);
                    tColor = Color.FromArgb(255, Color.DodgerBlue);
                    break;
                case ColorTheme.SolarFlare:
                    //SolarFlare
                    tGlow = Color.FromArgb(35, Color.Gold);
                    tColor = Color.FromArgb(255, Color.Gold);
                    break;
            }

            G.Clear(Color.FromArgb(39, 41, 41));
            DrawGradient(Color.FromArgb(100, 100, 100), Color.FromArgb(31, 31, 31), ClientRectangle, 90);
            DrawGradient(Color.FromArgb(53, 53, 54), Color.FromArgb(54, 54, 56), new Rectangle(2, 2, Width - 6, Height - 4), 90);
            DrawGradient(Color.FromArgb(31, 31, 31), Color.FromArgb(42, 42, 42), new Rectangle(2, 10, Width - 6, Height - 19), 90);
            G.FillRectangle(new SolidBrush(Color.FromArgb(15, 15, 17)), new Rectangle(3, 11, Width - 7, Height - 20));
            G.DrawLine(Pens.Black, 3, 11, 3, Height - 10);
            G.DrawLine(Pens.Black, Width - 4, 11, Width - 4, Height - 10);

            //DrawGradient(Color.FromArgb(109, 109, 111), Color.FromArgb(26, 26, 29), ClientRectangle, 45S) 'Border Out
            //DrawGradient(Color.FromArgb(58, 58, 60), Color.FromArgb(14, 14, 14), New Rectangle(2, 2, Width - 4, Height - 4), 45S)

            DrawBorders(new Pen(new SolidBrush(Color.Black)));

            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 4, 0);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 4, 1);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 4, -1);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 6, 0);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 6, 1);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 6, -1);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 5, 1);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 5, -1);

            DrawText(new SolidBrush(tColor), HorizontalAlignment.Left, 5, 0);
            DrawCorners(Color.Cyan);
        }

        #endregion

        #region 33. Design



        /// <summary>
        /// The locked
        /// </summary>
        private bool Locked = false;

        /// <summary>
        /// The position
        /// </summary>
        private Point Position;
        /// <summary>
        /// The couleur ecriture
        /// </summary>
        Color Couleur_Ecriture = Color.FromArgb(70, 70, 70);

        /// <summary>
        /// The couleur back color
        /// </summary>
        Color Couleur_BackColor = Color.FromArgb(25, 25, 25);
        /// <summary>
        /// The couleur degrade1
        /// </summary>
        Color Couleur_Degrade1 = Color.FromArgb(35, 35, 35);

        /// <summary>
        /// The couleur degrade2
        /// </summary>
        Color Couleur_Degrade2 = Color.FromArgb(25, 25, 25);

        /// <summary>
        /// The couleur bordure ext
        /// </summary>
        Color Couleur_BordureExt = Color.Black;
        /// <summary>
        /// The couleur bordure int1 haut
        /// </summary>
        Color Couleur_BordureInt1_Haut = Color.FromArgb(74, 74, 74);
        /// <summary>
        /// The couleur bordure int1 bas
        /// </summary>
        Color Couleur_BordureInt1_Bas = Color.FromArgb(39, 39, 39);

        /// <summary>
        /// The couleur bordure int2
        /// </summary>
        Color Couleur_BordureInt2 = Color.FromArgb(43, 43, 43);
        /// <summary>
        /// The couleur separation1
        /// </summary>
        Color Couleur_Separation1 = Color.Black;
        /// <summary>
        /// The couleur separation2
        /// </summary>
        Color Couleur_Separation2 = Color.FromArgb(0, 255, 0);

        /// <summary>
        /// The couleur separation3
        /// </summary>
        Color Couleur_Separation3 = Color.Black;

        /// <summary>
        /// The hauteur barre
        /// </summary>
        int Hauteur_Barre = 33;

        /// <summary>
        /// Gets or sets the color of the design border.
        /// </summary>
        /// <value>The color of the design border.</value>
        [Category("Design Theme")]
        public Color DesignBorderColor
        {
            get { return Couleur_Separation2; }
            set
            {
                Couleur_Separation2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Designs the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        void Design_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {
            Padding = new Padding(2, 36, 2, 2);
            e.Graphics.SmoothingMode = SmoothingMode.Default;

            //BACKGROUND

            e.Graphics.Clear(Couleur_BackColor);

            //HAUT

            Rectangle Rectangle_Haut = new Rectangle(0, 0, Width, Hauteur_Barre);
            LinearGradientBrush Haut_Brush = new LinearGradientBrush(Rectangle_Haut, Couleur_Degrade1, Couleur_Degrade2, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(Haut_Brush, Rectangle_Haut);
            Haut_Brush.Dispose();

            
            //BORDURE INT1

            Rectangle Rectangle_BordureInt1 = new Rectangle(1, 1, Width - 3, Hauteur_Barre - 4);
            Rectangle Rectangle_BordureInt1_AvecBordure = new Rectangle(0, 0, Width - 1, Hauteur_Barre - 2);

            LinearGradientBrush Brush_BordureInt1 = new LinearGradientBrush(Rectangle_BordureInt1_AvecBordure, Couleur_BordureInt1_Haut, Couleur_BordureInt1_Bas, LinearGradientMode.Vertical);
            e.Graphics.DrawRectangle(new Pen(Brush_BordureInt1, 1), Rectangle_BordureInt1);

            //BORDURE INT2

            Rectangle Rectangle_BordureInt2 = new Rectangle(1, Hauteur_Barre + 2, Width - 3, Height - Hauteur_Barre - 4);
            e.Graphics.DrawRectangle(new Pen(Couleur_BordureInt2, 1), Rectangle_BordureInt2);

            //SEPARATION

            Point Separation_Point1 = new Point(0, Hauteur_Barre);
            Point Separation_Point2 = new Point(Width, Hauteur_Barre);

            LinearGradientBrush Separation_Brush = new LinearGradientBrush(Separation_Point1, Separation_Point2, Color.Black, Color.Black);

            ColorBlend ColorBlend = new ColorBlend();
            ColorBlend.Colors = new Color[] {
                Couleur_Separation1,
                Couleur_Separation2,
                Couleur_Separation3
            };
            ColorBlend.Positions = new float[] {
                0,
                0.5f,
                1
            };

            Separation_Brush.InterpolationColors = ColorBlend;

            e.Graphics.DrawLine(new Pen(Separation_Brush, 2), Separation_Point1, Separation_Point2);

            Separation_Brush.Dispose();

            //BORDURE EXT1

            Rectangle Rectangle_BordureExt1 = new Rectangle(0, 0, Width - 1, Hauteur_Barre - 2);
            e.Graphics.DrawRectangle(new Pen(Couleur_BordureExt, 1), Rectangle_BordureExt1);

            //BORDURE EXT2

            Rectangle Rectangle_BordureExt2 = new Rectangle(0, Hauteur_Barre + 1, Width - 1, Height - Hauteur_Barre - 2);
            e.Graphics.DrawRectangle(new Pen(Couleur_BordureExt, 1), Rectangle_BordureExt2);


            //ECRITURE

            StringFormat StringFormat = new StringFormat();
            StringFormat.LineAlignment = StringAlignment.Center;
            StringFormat.Alignment = StringAlignment.Near;

            Rectangle Rectangle_Ecriture = new Rectangle(15, 0, Width - 15, Hauteur_Barre);

            e.Graphics.DrawString(Text, Font, new SolidBrush(/*Couleur_Ecriture*/ForeColor), Rectangle_Ecriture, StringFormat);
            StringFormat.Dispose();

        }


        #endregion

        #region 34. Destiny

        /// <summary>
        /// Destinies the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Destiny_PaintHook(PaintEventArgs e)
        {
            G.Clear(BackColor);

            DrawGradient(Color.Teal, Color.Black, 0, 0, Width, 20, 90);
            G.DrawLine(Pens.Teal, 0, 20, Width, 20);

            DrawBorders(Pens.Black, Pens.Teal, ClientRectangle);
            DrawCorners(Color.Fuchsia, ClientRectangle);
            G.DrawString(Text, new Font("Arial", 8, FontStyle.Bold), new SolidBrush(ForeColor), 25, 5);

        }

        #endregion

        #region  35. Deumos

        /// <summary>
        /// Deumoses the color hook.
        /// </summary>
        void Deumos_ColorHook()
        {
            Header = 24;
            TransparencyKey = Color.Fuchsia;
            BackColor = Deumos_C1;
        }

        /// <summary>
        /// The deumos c1
        /// </summary>
        private Color Deumos_C1 = Color.FromArgb(14, 14, 14);
        /// <summary>
        /// The deumos c2
        /// </summary>
        private Color Deumos_C2 = Color.FromArgb(48, 48, 48);
        /// <summary>
        /// The deumos c3
        /// </summary>
        private Color Deumos_C3 = Color.FromArgb(4, 4, 4);
        /// <summary>
        /// The deumos p1
        /// </summary>
        private Pen Deumos_P1 = new Pen(Color.FromArgb(45, 45, 45));
        /// <summary>
        /// The deumos p2
        /// </summary>
        private Pen Deumos_P2 = new Pen(Color.Black);
        /// <summary>
        /// The deumos p3
        /// </summary>
        private Pen Deumos_P3 = new Pen(Color.Black);
        /// <summary>
        /// The deumos p4
        /// </summary>
        private Pen Deumos_P4 = new Pen(Color.FromArgb(100, 100, 100));
        /// <summary>
        /// The deumos p5
        /// </summary>
        private Pen Deumos_P5 = new Pen(Color.FromArgb(14, 14, 14));
        /// <summary>
        /// The deumos b1
        /// </summary>
        private SolidBrush Deumos_B1 = new SolidBrush(Color.FromArgb(100, 100, 100));
        /// <summary>
        /// The deumos b2
        /// </summary>
        private SolidBrush Deumos_B2 = new SolidBrush(Color.FromArgb(255,Color.Gray));
        /// <summary>
        /// The deumos b3
        /// </summary>
        private SolidBrush Deumos_B3 = new SolidBrush(Color.White);
        /// <summary>
        /// The deumos b4
        /// </summary>
        private SolidBrush Deumos_B4 = new SolidBrush(Color.FromArgb(100, 100, 100));
        /// <summary>
        /// The deumos r1
        /// </summary>
        private Rectangle Deumos_R1;

        /// <summary>
        /// The deumos path
        /// </summary>
        private GraphicsPath Deumos_Path;
        /// <summary>
        /// The deumos path clone
        /// </summary>
        private GraphicsPath Deumos_PathClone;

        /// <summary>
        /// The deumos g1
        /// </summary>
        private LinearGradientBrush Deumos_G1;

        /// <summary>
        /// The header offset
        /// </summary>
        private int _HeaderOffset = 1;
        /// <summary>
        /// Gets or sets the header offset.
        /// </summary>
        /// <value>The header offset.</value>
        public int HeaderOffset
        {
            get { return _HeaderOffset; }
            set
            {
                if (value < 0 || value > 2)
                    return;

                _HeaderOffset = value;
                Invalidate();
            }
        }
        /// <summary>
        /// Deumoses the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Deumos_PaintHook(PaintEventArgs e)
        {
            Deumos_Path = new GraphicsPath();
            Blend = new ColorBlend();

            Blend.Colors = new Color[] {
                Color.FromArgb(14, 14, 14),
                Color.FromArgb(41, 41, 41),
                Color.FromArgb(41, 41, 41),
                Color.FromArgb(14, 14, 14)
            };
            
            Blend.Positions = new float[] {
                0,
                0.4f,
                0.6f,
                1
            };

            Deumos_P1.Alignment = PenAlignment.Inset;

            //Draw background
            G.Clear(Color.FromArgb(14, 14, 14));
            G.FillRectangle(Brushes.Fuchsia, 0, 0, Width, 3);

            //Draw border
            DrawBorders(Deumos_P1, 0, 17, Width + 1, Height - 16);
            //Border

            //Draw outline
            DrawBorders(Deumos_P5, 1, 23, Width - 2, Height - 24);
            DrawBorders(Deumos_P2, 0, 24, Width, Height - 24);
            //InnerOutline
            DrawBorders(Deumos_P2, 7, 23, Width - 14, Height - 30);
            //OuterOutline

            //Draw title gradient
            Deumos_R1 = new Rectangle(30, _HeaderOffset, Width - 67, 24 - _HeaderOffset);
            Deumos_G1 = new LinearGradientBrush(Deumos_R1, Color.Empty, Color.Empty, 0f);
            Deumos_G1.InterpolationColors = Blend;
            G.FillRectangle(Deumos_G1, Deumos_R1);

            //Draw title gloss
            G.FillRectangle(Deumos_B1, 30, _HeaderOffset, Width - 67, 12 - _HeaderOffset);
            G.DrawLine(Deumos_P4, 30, _HeaderOffset + 1, Width - 67, _HeaderOffset + 1);

            //Draw title outline
            G.DrawLine(Deumos_P2, 30, _HeaderOffset, Width - 67, _HeaderOffset);
            //TitleOutline

            Deumos_Path.Reset();

            Deumos_Path.AddLine(3, 0, 31, 0);
            Deumos_Path.AddLine(55, 24, 0, 24);
            Deumos_Path.AddLine(0, 24, 0, 3);
            Deumos_Path.CloseFigure();

            Deumos_Path.AddLine(Width - 68, 0, Width - 4, 0);
            Deumos_Path.AddLine(Width - 1, 3, Width - 1, 24);
            Deumos_Path.AddLine(Width - 1, 24, Width - 92, 24);
            Deumos_Path.CloseFigure();

            Deumos_PathClone = (GraphicsPath)Deumos_Path.Clone();
            Deumos_PathClone.Widen(Pens.Black);
            //Draw corner gradient
            G.SetClip(Deumos_Path);
            Deumos_R1 = new Rectangle(0, 0, Width, 24);
            Deumos_G1 = new LinearGradientBrush(Deumos_R1, Deumos_C2, Deumos_C3, 90);
            G.FillRectangle(Deumos_G1, Deumos_R1);

            //Draw corner gloss
            G.FillRectangle(Deumos_B2, 0, 0, Width, 11);
            G.DrawPath(Deumos_P3, Deumos_PathClone);
            G.ResetClip();

            //Draw corner outline
            G.DrawPath(Deumos_P2, Deumos_Path);
            //CornerOutline

            //Draw title elements
            DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, -21, _HeaderOffset + 1);
            DrawText(Deumos_B4, HorizontalAlignment.Center, -20, _HeaderOffset);
            DrawImage(HorizontalAlignment.Left, 11, 0);
        }

        /// <summary>
        /// Deumoses the on creation.
        /// </summary>
        void Deumos_OnCreation()
        {
            Parent.MinimumSize = new Size(120, 80);
        }



        /// <summary>
        /// Deumoses the on resize.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        void Deumos_OnResize(EventArgs e)
        {
            Deumos_Path.Reset();

            Deumos_Path.AddLine(3, 0, 31, 0);
            Deumos_Path.AddLine(55, 24, 0, 24);
            Deumos_Path.AddLine(0, 24, 0, 3);
            Deumos_Path.CloseFigure();

            Deumos_Path.AddLine(Width - 68, 0, Width - 4, 0);
            Deumos_Path.AddLine(Width - 1, 3, Width - 1, 24);
            Deumos_Path.AddLine(Width - 1, 24, Width - 92, 24);
            Deumos_Path.CloseFigure();

            Deumos_PathClone = (GraphicsPath)Deumos_Path.Clone();
            Deumos_PathClone.Widen(Pens.Black);

            
        }


        #endregion

        #region 36. Doom

        /// <summary>
        /// Dooms the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Doom_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Black);
            G.SmoothingMode = SmoothingMode.HighQuality;
            //Form Border
            HatchBrush HB = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(33, 33, 33), Color.FromArgb(10, 10, 10));
            G.FillRectangle(HB, new Rectangle(0, 0, Width - 1, Height - 1));
            G.DrawRectangle(new Pen(Color.FromArgb(33, 33, 33)), 0, 0, Width - 1, Height - 1);
            //Form Interior
            G.FillRectangle(new SolidBrush(Color.FromArgb(30, 30, 30)), new Rectangle(6, 25, Width - 11, Height - 30));
            //Title Box
            HatchBrush HB3 = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(33, 33, 33), Color.FromArgb(22, 22, 22));
            Point[] p = {
                new Point(3, 15),
                new Point(20, 3),
                new Point(230, 3),
                new Point(230, 15),
                new Point(200, 35),
                new Point(3, 35)
            };
            G.FillPolygon(HB3, p);
            G.DrawPolygon(Pens.Black, p);
            //Icon and Form Title
            G.DrawString(Text, Font, new SolidBrush(ForeColor = Color.Red), new Point(40, 12));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(20, 12, 16, 16));
            //Draw Border
            DrawBorders(Pens.Black, 0);

        }

        #endregion

        #region 37. Drone


        /// <summary>
        /// Drones the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Drone_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(24, 24, 24));

            DrawGradient(Color.FromArgb(0, 55, 90), Color.FromArgb(0, 70, 128), 11, 8, Width - 22, 17);
            G.FillRectangle(new SolidBrush(Color.FromArgb(0, 55, 90)), 11, 3, Width - 22, 5);

            Pen P = new Pen(Color.FromArgb(13, Color.White));
            G.DrawLine(P, 10, 1, 10, Height);
            G.DrawLine(P, Width - 11, 1, Width - 11, Height);
            G.DrawLine(P, 11, Height - 11, Width - 12, Height - 11);
            G.DrawLine(P, 11, 29, Width - 12, 29);
            G.DrawLine(P, 11, 25, Width - 12, 25);

            G.FillRectangle(new SolidBrush(Color.FromArgb(13, Color.White)), 0, 2, Width, 6);
            G.FillRectangle(new SolidBrush(Color.FromArgb(13, Color.White)), 0, Height - 6, Width, 4);

            G.FillRectangle(new SolidBrush(Color.FromArgb(24, 24, 24)), 11, Height - 6, Width - 22, 4);

            HatchBrush T = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(24, 24, 24), Color.FromArgb(8, 8, 8));
            G.FillRectangle(T, 11, 30, Width - 22, Height - 41);

            DrawText(Brushes.White, HorizontalAlignment.Left, 15, 2);

            DrawBorders(new Pen(Color.FromArgb(58, 58, 58)), 1);
            DrawBorders(Pens.Black);

            P = new Pen(Color.FromArgb(25, Color.White));
            G.DrawLine(P, 11, 3, Width - 12, 3);
            G.DrawLine(P, 12, 2, 12, 7);
            G.DrawLine(P, Width - 13, 2, Width - 13, 7);

            G.DrawLine(Pens.Black, 11, 0, 11, Height);
            G.DrawLine(Pens.Black, Width - 12, 0, Width - 12, Height);

            G.DrawRectangle(Pens.Black, 11, 2, Width - 23, 22);
            G.DrawLine(Pens.Black, 11, Height - 12, Width - 12, Height - 12);
            G.DrawLine(Pens.Black, 11, 30, Width - 12, 30);

            DrawCorners(Color.Fuchsia);
        }

        #endregion

        #region 38. Earn

        /// <summary>
        /// Earns the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Earn_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(75, 77, 89));
            G.FillRectangle(new SolidBrush(Color.FromArgb(242, 242, 242)), new Rectangle(6, 36, Width - 13, Height - 43));
            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(ForeColor), new Point(8, 10));
            DrawCorners(Color.Fuchsia);
        }

        #endregion

        #region 39. Effectual

        /// <summary>
        /// Class Effectual_ImageToCodeClass.
        /// </summary>
        class Effectual_ImageToCodeClass
        {
            /// <summary>
            /// Images to code.
            /// </summary>
            /// <param name="Img">The img.</param>
            /// <returns>System.String.</returns>
            public string ImageToCode(Bitmap Img)
            {
                return Convert.ToBase64String((byte[])System.ComponentModel.TypeDescriptor.GetConverter(Img).ConvertTo(Img, typeof(byte[])));
            }

            /// <summary>
            /// Codes to image.
            /// </summary>
            /// <param name="Code">The code.</param>
            /// <returns>Image.</returns>
            public Image CodeToImage(string Code)
            {
                return Image.FromStream(new System.IO.MemoryStream(Convert.FromBase64String(Code)));
            }
        }

        /// <summary>
        /// The sub text
        /// </summary>
        string _SubText;
        /// <summary>
        /// Gets or sets the subtext.
        /// </summary>
        /// <value>The subtext.</value>
        public new string Subtext
        {
            get { return _SubText; }
            set
            {
                _SubText = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Effectuals the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        void Effectual_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            Rectangle MainBox = new Rectangle(0, 0, Width, 32);
            Rectangle SecondBox = new Rectangle(0, 33, Width, Height);
            Rectangle BottomBox = new Rectangle(-3, Height - 25, Width + 5, Height - 25);

            
            G.Clear(Color.Fuchsia);

            G.CompositingQuality = CompositingQuality.HighQuality;
            Effectual_ImageToCodeClass d = new Effectual_ImageToCodeClass();
            Bitmap HATCHIMAGE = (Bitmap)(d.CodeToImage("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"));
            Bitmap BODYIMAGE = (Bitmap)(d.CodeToImage("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"));
            TextureBrush TEXTUREIMAGE = new TextureBrush(HATCHIMAGE, WrapMode.TileFlipXY);
            TextureBrush BACKIMAGE = new TextureBrush(BODYIMAGE, WrapMode.TileFlipXY);
            G.FillRectangle(TEXTUREIMAGE, MainBox);

            Pen p1 = new Pen(new SolidBrush(Color.FromArgb(35, 35, 35)));
            G.DrawLine(p1, 0, 31, Width, 31);
            Pen p2 = new Pen(new SolidBrush(Color.FromArgb(50, 50, 50)));
            G.DrawLine(p2, 0, 30, Width, 30);
            G.DrawLine(Pens.Black, 0, 32, Width, 32);

            G.FillRectangle(BACKIMAGE, SecondBox);

            Point[] Pt = {
                new Point(10, 0),
                new Point(10, 66),
                new Point(36, 40),
                new Point(62, 66),
                new Point(62, 0)
            };

            Pen penCurrent = new Pen(Color.Black);
            G.DrawPolygon(penCurrent, Pt);
            SolidBrush br = new SolidBrush(Color.FromArgb(86, 86, 86));
            G.FillPolygon(br, Pt);

            Point[] Pt2 = {
                new Point(14, 0),
                new Point(14, 62),
                new Point(36, 40),
                new Point(58, 62),
                new Point(58, 0)
            };

            Pen penCurrent2 = new Pen(Color.FromArgb(51, 51, 50));
            G.DrawPolygon(penCurrent2, Pt2);
            HatchBrush br2 = new HatchBrush(HatchStyle.SmallGrid, Color.FromArgb(52, 52, 51), Color.FromArgb(48, 49, 48));
            G.FillPolygon(TEXTUREIMAGE, Pt2);

            G.DrawLine(Pens.Black, 10, 0, 10, 66);
            G.DrawLine(Pens.Black, 10, 66, 36, 40);

            Font p = new Font("Tahoma", 10, FontStyle.Bold);
            G.DrawString(_SubText, p, Brushes.WhiteSmoke, 68, 9);

            Rectangle IconRect = new Rectangle(23, 8, 26, 26);
            G.DrawIcon(Parent.FindForm().Icon, IconRect);

            Pen BottomPen = new Pen(new SolidBrush(Color.FromArgb(99, 99, 99)), 7);
            G.DrawRectangle(BottomPen, BottomBox);
            Bitmap BOTTOMIMAGE = (Bitmap)(d.CodeToImage("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"));
            TextureBrush BOTTOMTEXTURE = new TextureBrush(BOTTOMIMAGE, WrapMode.TileFlipXY);
            G.FillRectangle(BOTTOMTEXTURE, BottomBox);

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            G.Dispose();
            B.Dispose();
        }


        #endregion

        #region 40. Electric
        /// <summary>
        /// The bg color
        /// </summary>
        Color BGColor = Color.FromArgb(22, 84, 107);
        /// <summary>
        /// The electric g1
        /// </summary>
        Color Electric_G1 = Color.FromArgb(43, 136, 170);
        /// <summary>
        /// The electric g2
        /// </summary>
        Color Electric_G2 = Color.FromArgb(29, 102, 129);
        /// <summary>
        /// The electric f
        /// </summary>
        Color Electric_F = Color.Fuchsia;
        /// <summary>
        /// The seperator
        /// </summary>
        Pen Seperator = new Pen(Color.FromArgb(7, 65, 86));

        /// <summary>
        /// The electric b
        /// </summary>
        Pen Electric_B = Pens.Black;
        /// <summary>
        /// Electrics the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Electric_PaintHook(PaintEventArgs e)
        {
            G.Clear(BGColor);
            //Background

            DrawGradient(Electric_G1, Electric_G2, 0, 0, Width, 20, 90);
            //Menu Bar
            G.DrawLine(Seperator, 0, 20, Width, 20);
            //Menu bar seperator line

            G.DrawRectangle(Electric_B, ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width - 1, ClientRectangle.Height - 1);
            //Border
            DrawCorners(Electric_F, ClientRectangle);
            //Form corners

            DrawText(HorizontalAlignment.Left, ForeColor, 3);
            //Menu bar's text
        }

        #endregion

        #region 41. Electrified

        /// <summary>
        /// Electrifieds the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Electrified_PaintHook(PaintEventArgs e)
        {
            G.Clear(BackColor);

            DrawGradient(Color.LightGray, Color.Gray, 0, 0, Width, 20, 90);
            DrawGradient(Color.LightGray, Color.DimGray, 0, 20, Width, Height - 25, 90);
            DrawGradient(Color.LightGray, Color.Gray, 0, Height - 25, Width, Height + 25 - Height, 90);
            DrawGradient(Color.LightGray, Color.Gray, 0, Height + 25 - Height - 5, 10, Height - 45, 180);
            DrawGradient(Color.LightGray, Color.Gray, Width - 10, Height + 25 - Height - 5, 10, Height - 45, 180);
            DrawCorners(Color.Fuchsia, ClientRectangle);
            DrawText(HorizontalAlignment.Center, ForeColor, 3);
            DrawBorders(Pens.Green, Pens.White, ClientRectangle);
        }

        #endregion

        #region 42. Elegant

        /// <summary>
        /// Class Elegant_DrawHelpers.
        /// </summary>
        static class Elegant_DrawHelpers
        {

            #region "Functions"

            /// <summary>
            /// Rounds the rectangle.
            /// </summary>
            /// <param name="Rectangle">The rectangle.</param>
            /// <param name="Curve">The curve.</param>
            /// <returns>GraphicsPath.</returns>
            public static GraphicsPath RoundRectangle(Rectangle Rectangle, int Curve)
            {
                GraphicsPath P = new GraphicsPath();
                int ArcRectangleWidth = Curve * 2;
                P.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90);
                P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90);
                P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90);
                P.AddArc(new Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90);
                P.AddLine(new Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), new Point(Rectangle.X, Curve + Rectangle.Y));
                return P;
            }

            /// <summary>
            /// Rounds the rect.
            /// </summary>
            /// <param name="x">The x.</param>
            /// <param name="y">The y.</param>
            /// <param name="w">The w.</param>
            /// <param name="h">The h.</param>
            /// <param name="r">The r.</param>
            /// <param name="TL">if set to <c>true</c> [tl].</param>
            /// <param name="TR">if set to <c>true</c> [tr].</param>
            /// <param name="BR">if set to <c>true</c> [br].</param>
            /// <param name="BL">if set to <c>true</c> [bl].</param>
            /// <returns>GraphicsPath.</returns>
            public static GraphicsPath RoundRect(dynamic x, dynamic y, dynamic w, dynamic h, dynamic r, bool TL = true, bool TR = true, bool BR = true, bool BL = true)
            {
                r = 0.3;

                GraphicsPath functionReturnValue = default(GraphicsPath);
                dynamic d = Math.Min(w, h) * r;
                dynamic xw = x + w;
                dynamic yh = y + h;
                functionReturnValue = new GraphicsPath();

                var _with1 = functionReturnValue;
                if (TL)
                    _with1.AddArc(x, y, d, d, 180, 90);
                else
                    _with1.AddLine(x, y, x, y);
                if (TR)
                    _with1.AddArc(xw - d, y, d, d, 270, 90);
                else
                    _with1.AddLine(xw, y, xw, y);
                if (BR)
                    _with1.AddArc(xw - d, yh - d, d, d, 0, 90);
                else
                    _with1.AddLine(xw, yh, xw, yh);
                if (BL)
                    _with1.AddArc(x, yh - d, d, d, 90, 90);
                else
                    _with1.AddLine(x, yh, x, yh);

                _with1.CloseFigure();
                return functionReturnValue;
            }

            /// <summary>
            /// Enum MouseState
            /// </summary>
            public enum MouseState : byte
            {
                /// <summary>
                /// The none
                /// </summary>
                None = 0,
                /// <summary>
                /// The over
                /// </summary>
                Over = 1,
                /// <summary>
                /// Down
                /// </summary>
                Down = 2,
                /// <summary>
                /// The block
                /// </summary>
                Block = 3
            }

            #endregion

        }


        #region "Declarations"

        /// <summary>
        /// The font size
        /// </summary>
        private int _FontSize = 12;
        /// <summary>
        /// The state
        /// </summary>
        private MouseState State = MouseState.None;
        /// <summary>
        /// The mouse x loc
        /// </summary>
        private int MouseXLoc;
        /// <summary>
        /// The mouse y loc
        /// </summary>
        private int MouseYLoc;
        /// <summary>
        /// The capture movement
        /// </summary>
        private bool CaptureMovement = false;
        /// <summary>
        /// The elegant move height
        /// </summary>
        private int Elegant_MoveHeight = 26;
        /// <summary>
        /// The elegant mouse p
        /// </summary>
        private Point Elegant_MouseP = new Point(0, 0);
        /// <summary>
        /// The control box colour
        /// </summary>
        private Color _ControlBoxColour = Color.FromArgb(123, 150, 106);
        /// <summary>
        /// The control base colour
        /// </summary>
        private Color _ControlBaseColour = Color.FromArgb(247, 249, 248);
        /// <summary>
        /// The top strip border colour
        /// </summary>
        private Color _TopStripBorderColour = Color.FromArgb(183, 210, 166);
        /// <summary>
        /// The top strip colour
        /// </summary>
        private Color _TopStripColour = Color.FromArgb(240, 242, 241);
        /// <summary>
        /// The base colour
        /// </summary>
        private Color _BaseColour = Color.FromArgb(250, 250, 250);
        /// <summary>
        /// The border colour
        /// </summary>
        private Color _BorderColour = Color.FromArgb(10, 10, 10);
        /// <summary>
        /// The control box button split colour
        /// </summary>
        private Color _ControlBoxButtonSplitColour = Color.FromArgb(210, 210, 210);
        /// <summary>
        /// The icon colour
        /// </summary>
        private Color _IconColour = Color.FromArgb(90, 90, 90);
        /// <summary>
        /// The allow close
        /// </summary>
        private bool _AllowClose = false;
        /// <summary>
        /// The allow minimize
        /// </summary>
        private bool _AllowMinimize = false;
        /// <summary>
        /// The allow maximize
        /// </summary>
        private bool _AllowMaximize = false;

        /// <summary>
        /// The font
        /// </summary>
        private Font _Font = new Font("Segoe UI", 12);
        #endregion

        #region "Properties & Events"

        //[Category("Elegant Theme - Colours")]
        //public Color IconColour
        //{
        //    get { return _IconColour; }
        //    set { _IconColour = value; }
        //}
        //[Category("Elegant Theme - Colours")]
        //public Color ControlBoxButtonSplitColour
        //{
        //    get { return _ControlBoxButtonSplitColour; }
        //    set { _ControlBoxButtonSplitColour = value; }
        //}
        //[Category("Elegant Theme - Colours")]
        //public Color ControlBaseColour
        //{
        //    get { return _ControlBaseColour; }
        //    set { _ControlBaseColour = value; }
        //}
        //[Category("Elegant Theme - Colours")]
        //public Color ControlBoxColour
        //{
        //    get { return _ControlBoxColour; }
        //    set { _ControlBoxColour = value; }
        //}
        //[Category("Elegant Theme - Colours")]
        //public Color TopStripBorderColour
        //{
        //    get { return _TopStripBorderColour; }
        //    set { _TopStripBorderColour = value; }
        //}
        //[Category("Elegant Theme - Colours")]
        //public Color BorderColour
        //{
        //    get { return _BorderColour; }
        //    set { _BorderColour = value; }
        //}
        //[Category("Elegant Theme - Colours")]
        //public Color TopStripColour
        //{
        //    get { return _TopStripColour; }
        //    set { _TopStripColour = value; }
        //}

        //[Category("Elegant Theme - Colours")]
        //public Color BaseColour
        //{
        //    get { return _BaseColour; }
        //    set { _BaseColour = value; }
        //}

        //[Category("Elegant Theme - Colours")]
        //public bool AllowClose
        //{
        //    get { return _AllowClose; }
        //    set { _AllowClose = value; }
        //}

        //[Category("Elegant Theme - Colours")]
        //public bool AllowMinimize
        //{
        //    get { return _AllowMinimize; }
        //    set { _AllowMinimize = value; }
        //}

        //[Category("Elegant Theme - Colours")]
        //public bool AllowMaximize
        //{
        //    get { return _AllowMaximize; }
        //    set { _AllowMaximize = value; }
        //}


        #endregion

        /// <summary>
        /// Elegants the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Elegant_PaintHook(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            //Graphics G = e.Graphics;
            G = Graphics.FromImage(B);
            Rectangle Base = new Rectangle(0, 0, Width, Height);
            var _with2 = G;
            Point[] LeftBorderPoints = {
                new Point(0, (int)_with2.MeasureString(Text, _Font).Height + 10),
                new Point((int)_with2.MeasureString(Text, _Font).Width + 3, (int)_with2.MeasureString(Text, _Font).Height + 10),
                new Point((int)_with2.MeasureString(Text, _Font).Width + 16, 0)
            };
            Point[] LeftBorderPoints1 = {
                new Point(0, 0),
                new Point(0, (int)_with2.MeasureString(Text, _Font).Height + 10),
                new Point((int)_with2.MeasureString(Text, _Font).Width + 3, (int)_with2.MeasureString(Text, _Font).Height + 10),
                new Point((int)_with2.MeasureString(Text, _Font).Width + 16, 0)
            };
            Point[] MiddleStripPoints = {
                new Point((int)_with2.MeasureString(Text, _Font).Width + 4, (int)_with2.MeasureString(Text, _Font).Height + 3),
                new Point((int)_with2.MeasureString(Text, _Font).Width + 16, 0),
                new Point(Width /*- 84*/, 0),
                new Point(Width /*- 84*/, (int)_with2.MeasureString(Text, _Font).Height + 3)
            };
            _with2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with2.SmoothingMode = SmoothingMode.HighQuality;
            _with2.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with2.FillRectangle(new SolidBrush(_BaseColour), new Rectangle(0, 0, Width, Height));
            _with2.FillPolygon(new SolidBrush(_TopStripBorderColour), MiddleStripPoints);
            _with2.FillPolygon(new SolidBrush(_TopStripColour), LeftBorderPoints1);
            //_with2.FillRectangle(new SolidBrush(_ControlBaseColour), Width - 84, 0, Width, 25);
            //_with2.DrawLine(new Pen(_IconColour, 2), Width - 19, 7, Width - 7, 19);
            //_with2.DrawLine(new Pen(_IconColour, 2), Width - 19, 19, Width - 7, 7);
            //_with2.DrawLine(new Pen(_IconColour, 2), Width - 76, 18, Width - 64, 18);
            //_with2.DrawLine(new Pen(_IconColour, 2), Width - 48, 19, Width - 48, 6);
            //_with2.DrawLine(new Pen(_IconColour, 2), Width - 48, 19, Width - 34, 19);
            //_with2.DrawLine(new Pen(_IconColour, 4), Width - 48, 8, Width - 34, 8);
            //_with2.DrawLine(new Pen(_IconColour, 2), Width - 34, 6, Width - 34, 19);
            //_with2.DrawLine(new Pen(_ControlBoxColour), Width, 25, Width - 84, 25);
            //_with2.DrawLine(new Pen(_TopStripBorderColour), Width - 84, 25, Width - 84, 0);
            //_with2.DrawLine(new Pen(_ControlBoxButtonSplitColour), Width - 56, 25, Width - 56, 0);
            //_with2.DrawLine(new Pen(_ControlBoxButtonSplitColour), Width - 26, 25, Width - 26, 0);
            //_with2.DrawLines(new Pen(_TopStripBorderColour, 2), LeftBorderPoints);
            _with2.DrawRectangle(new Pen(_BorderColour), new Rectangle(0, 0, Width, Height));
            _with2.DrawString(Text, _Font, new SolidBrush(Color.FromArgb(120, 120, 120)), new Point(5, 5));

            e.Graphics.InterpolationMode = (InterpolationMode)7;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            //G.Dispose();
            
            B.Dispose();
        }

        /// <summary>
        /// Elegants the on mouse down.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        void Elegant_OnMouseDown(MouseEventArgs e)
        {
            
            if (MouseXLoc > Width - 26 && MouseYLoc < 25)
            {
                if (_AllowClose)
                {
                    Environment.Exit(0);
                }
            }
            else if (MouseXLoc > Width - 56 && MouseXLoc < Width - 26 && MouseYLoc < 25)
            {
                if (_AllowMaximize)
                {
                    switch (Parent.FindForm().WindowState)
                    {
                        case FormWindowState.Maximized:
                            Parent.FindForm().WindowState = FormWindowState.Normal;
                            break;
                        case FormWindowState.Normal:
                            Parent.FindForm().WindowState = FormWindowState.Maximized;
                            break;
                    }
                }
            }
            else if (MouseXLoc > Width - 84 && MouseXLoc < Width - 56 && MouseYLoc < 25)
            {
                if (_AllowMinimize)
                {
                    switch (Parent.FindForm().WindowState)
                    {
                        case FormWindowState.Normal:
                            Parent.FindForm().WindowState = FormWindowState.Minimized;
                            break;
                        case FormWindowState.Maximized:
                            Parent.FindForm().WindowState = FormWindowState.Minimized;
                            break;
                    }
                }
            }
            else if (e.Button == MouseButtons.Left & new Rectangle(0, 0, Width - 84, MoveHeight).Contains(e.Location))
            {
                CaptureMovement = true;
                MouseP = e.Location;
            }
            else
            {
                Focus();
            }
            Invalidate();
        }


        #endregion

        #region 43. Element
        /// <summary>
        /// The center text
        /// </summary>
        private bool _CenterText;
        /// <summary>
        /// Gets or sets a value indicating whether [center text].
        /// </summary>
        /// <value><c>true</c> if [center text]; otherwise, <c>false</c>.</value>
        public bool CenterText
        {
            get
            {
                bool functionReturnValue = false;
                return functionReturnValue;
                return functionReturnValue;
            }
            set { _CenterText = value; }
        }

        /// <summary>
        /// Elements the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Element_PaintHook(PaintEventArgs e)
        {
            
            G = e.Graphics;
            G.Clear(Color.FromArgb(32, 32, 32));
            G.FillRectangle(new SolidBrush(Color.FromArgb(41, 41, 41)), new Rectangle(9, _Header, Width - 18, Height - _Header - 9));
            if (_CenterText == true)
            {
                StringFormat _StringF = new StringFormat();
                _StringF.Alignment = StringAlignment.Center;
                _StringF.LineAlignment = StringAlignment.Center;
                G.DrawString(Text, new Font("Arial", 11), Brushes.White, new RectangleF(0, 0, Width, _Header), _StringF);
            }
            else
            {
                G.DrawString(Text, new Font("Arial", 11), Brushes.White, new Point(8, 7));
            }
        }

        #endregion

        #region 44. Empire

        /// <summary>
        /// The empire purple
        /// </summary>
        Color EmpirePurple = Color.FromArgb(55, 173, 242);
        /// <summary>
        /// Empires the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Empire_PaintHook(PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.Clear(Color.FromArgb(200, 200, 200));

            LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(0, 0, Width, 37), Color.FromArgb(36, 36, 36), Color.FromArgb(25, 25, 25), 90f);
            G.FillRectangle(LGB, LGB.Rectangle);
            //LGB = New LinearGradientBrush(New Rectangle(0, 41, Width, 4), Color.FromArgb(80, Color.Black), Color.Transparent, 90.0F)
            //e.Graphics.FillRectangle(LGB, LGB.Rectangle)

            G.FillRectangle(new SolidBrush(EmpirePurple), new Rectangle(13, 31, (int)G.MeasureString(Text, new Font("Segoe UI", 11)).Width + 6, 4));
            G.FillRectangle(new SolidBrush(EmpirePurple), new Rectangle(0, 35, Width, 2));

            G.DrawString(Text, new Font("Segoe UI", 11), Brushes.Black, new Point(15, 9));
            G.DrawString(Text, new Font("Segoe UI", 11), Brushes.White, new Point(15, 8));
            
        }


        #endregion

        #region 45. Empress

        /// <summary>
        /// Empresses the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Empress_PaintHook(PaintEventArgs e)
        {
            int Curve = 6;
            G.Clear(Parent.FindForm().TransparencyKey);
            HatchBrush BodyHatch = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(20, Color.Black), Color.Transparent);
            G.FillPath(new SolidBrush(Utilities.ColorConverter.HexToColor("#A12F35")), Utilities.Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), Curve));
            G.DrawPath(Pens.Black, Utilities.Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), Curve));
            G.SetClip(Utilities.Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), Curve));
            G.FillRectangle(BodyHatch, new Rectangle(0, 0, Width - 1, Height - 1));
            G.ResetClip();
            G.FillRectangle(new SolidBrush(Utilities.ColorConverter.HexToColor("#DE873A")), new Rectangle(6, 36, Width - 13, Height - 43));
            G.DrawString(FindForm().Text, Font, new SolidBrush(ForeColor), new Point(35, 10));
            G.DrawIcon(FindForm().Icon, new Rectangle(10, 10, 18, 18));
        }

        #endregion

        #region 46. ETheme

        /// <summary>
        /// es the theme paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void ETheme_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(53, 53, 53));
            DrawGradient(Color.FromArgb(50, 50, 50), Color.FromArgb(50, 50, 50), 0, 1, Width, 14, 90);
            DrawGradient(Color.FromArgb(29, 29, 29), Color.FromArgb(29, 29, 29), 2, 16, Width, 14, 90);
            G.DrawLine(Pens.Black, 0, 30, Width, 30);
            DrawBorders(Pens.Gray, Pens.Black, ClientRectangle);
            DrawText(HorizontalAlignment.Center, Color.Gray, 0);

        }

        #endregion

        #region 47. Evolve

        /// <summary>
        /// Evolves the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Evolve_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(47, 47, 47));
            DrawBorders(new Pen(Color.FromArgb(104, 104, 104)), 1);
            ColorBlend cblend = new ColorBlend(2);
            cblend.Colors[0] = Color.FromArgb(66, 66, 66);
            cblend.Colors[1] = Color.FromArgb(50, 50, 50);
            cblend.Positions[0] = 0;
            cblend.Positions[1] = 1;
            DrawGradient(cblend, new Rectangle(new Point(2, 2), new Size(this.Width - 4, 22)));
            G.DrawLine(new Pen(Color.FromArgb(30, 30, 30)), new Point(2, 24), new Point(this.Width - 3, 24));
            G.DrawLine(new Pen(Color.FromArgb(70, 70, 70)), new Point(2, 25), new Point(this.Width - 3, 25));
            DrawBorders(Pens.Black);
            DrawCorners(Color.Fuchsia);
            G.DrawIcon(this.ParentForm.Icon, new Rectangle(new Point(8, 5), new Size(16, 16)));
            G.DrawString(this.ParentForm.Text, Font, Brushes.White, new Point(28, 4));
        }

        #endregion

        #region 48. Excision

        /// <summary>
        /// The create round path
        /// </summary>
        private GraphicsPath CreateRoundPath;

        /// <summary>
        /// The create round rectangle
        /// </summary>
        private Rectangle CreateRoundRectangle;
        /// <summary>
        /// Creates the round.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="slope">The slope.</param>
        /// <returns>GraphicsPath.</returns>
        public GraphicsPath CreateRound(int x, int y, int width, int height, int slope)
        {
            CreateRoundRectangle = new Rectangle(x, y, width, height);
            return CreateRound(CreateRoundRectangle, slope);
        }

        /// <summary>
        /// Creates the round.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="slope">The slope.</param>
        /// <returns>GraphicsPath.</returns>
        public GraphicsPath CreateRound(Rectangle r, int slope)
        {
            CreateRoundPath = new GraphicsPath(FillMode.Winding);
            CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180f, 90f);
            CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270f, 90f);
            CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0f, 90f);
            CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90f, 90f);
            CreateRoundPath.CloseFigure();
            return CreateRoundPath;
        }

        /// <summary>
        /// Excisions the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        void Excision_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);

            Rectangle CR = new Rectangle(0, 0, Width - 1, 35);
            Rectangle Main = new Rectangle(0, 35, Width, Height - 35);

            
            G.Clear(Color.Fuchsia);

            G.CompositingQuality = CompositingQuality.HighQuality;

            ImageToCodeClass itc = new ImageToCodeClass();
            Bitmap BG = (Bitmap)itc.CodeToImage("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");
            TextureBrush BGT = new TextureBrush(BG, WrapMode.TileFlipXY);
            G.FillRectangle(BGT, Main);


            LinearGradientBrush lbb = new LinearGradientBrush(CR, Color.FromArgb(68, 68, 68), Color.FromArgb(45, 45, 45), 90);
            G.FillRectangle(lbb, CR);
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(26, 26, 26))), CR);

            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(70, 70, 70))), 0, 36, Width - 1, 36);

            G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(15, 15, 15))), CreateRound(new Rectangle(0, 0, Width - 1, Height - 1), 10));
            G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(88, 88, 88))), CreateRound(new Rectangle(1, 1, Width - 3, Height - 3), 10));

            Font drawFont = new Font("Tahoma", 10, FontStyle.Bold);
            G.DrawString(Parent.FindForm().Text, drawFont, Brushes.WhiteSmoke, 12, 10);

            //////left upper corner
            G.FillRectangle(Brushes.Fuchsia, 0, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 1, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 2, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 3, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 0, 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 0, 2, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 0, 3, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 1, 1, 1, 1);
            //'////right upper corner
            G.FillRectangle(Brushes.Fuchsia, Width - 1, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 2, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 3, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 4, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 1, 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 1, 2, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 1, 3, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 2, 1, 1, 1);
            //'////left bottom corner
            G.FillRectangle(Brushes.Fuchsia, 0, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 0, Height - 2, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 0, Height - 3, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 0, Height - 4, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 1, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 2, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 3, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 1, Height - 1, 1, 1);
            //G.FillRectangle(Brushes.Fuchsia, 2, Height - 2, 1, 1)
            //'////right bottom corner
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 2, Height, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 3, Height, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 4, Height, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 2, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 3, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 2, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 3, Height - 1, 1, 1);


            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            G.Dispose();
            B.Dispose();
        }



        #endregion

        #region 49. Exotic

        /// <summary>
        /// The test
        /// </summary>
        private bool _test = true;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Thematic150"/> is test.
        /// </summary>
        /// <value><c>true</c> if test; otherwise, <c>false</c>.</value>
        public bool test
        {
            get { return _test; }
            set
            {
                _test = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Exotics the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Exotic_PaintHook(PaintEventArgs e)
        {
            int Size1 = 0;
            int Size2 = 0;
            switch (test)
            {
                case true:
                    Size1 = 38;
                    Size2 = 37;
                    break;
                case false:
                    Size1 = 21;
                    Size2 = -1;
                    break;
            }
            G.Clear(Color.Black);
            switch (test)
            {
                case true:
                    DrawGradient(Color.FromArgb(240, 248, 250), Color.FromArgb(0, 0, 0), 0, 19, Width, 18, 90);
                    break;
            }
            G.DrawLine(Pens.AliceBlue, 0, 20, Width, 20);
            G.DrawLine(Pens.AliceBlue, 0, Size2, Width, Size2);
            switch (test)
            {
                case true:
                    for (int I = 0; I <= Width + 17; I += 4)
                    {
                        G.DrawLine(Pens.Black, I, 21, I - 17, Size1);
                        G.DrawLine(Pens.Black, I - 1, 21, I - 18, Size1);
                    }

                    break;
            }
            DrawBorders(Pens.Black, Pens.AliceBlue, ClientRectangle);
            DrawCorners(Color.Black, ClientRectangle);
            DrawText((HorizontalAlignment)Top, Color.FromArgb(240, 248, 255), 0);
        }

        #endregion

        #region 50. Facebook

        /// <summary>
        /// The main colour
        /// </summary>
        private Color _MainColour = Color.FromArgb(252, 252, 252);
        /// <summary>
        /// The header colour
        /// </summary>
        private Color _HeaderColour = Color.FromArgb(67, 96, 156);

        /// <summary>
        /// The main brush colour
        /// </summary>
        private SolidBrush _MainBrushColour;
        /// <summary>
        /// The header brush colour
        /// </summary>
        private SolidBrush _HeaderBrushColour;
        /// <summary>
        /// The facebook f
        /// </summary>
        private Font Facebook_F = new Font("Tahoma", 13, FontStyle.Bold);


        /// <summary>
        /// Facebooks the paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Facebook_Paint(PaintEventArgs e)
        {
            _MainBrushColour = new SolidBrush(_MainColour);
            _HeaderBrushColour = new SolidBrush(_HeaderColour);
            _BorderColour = Color.DarkGray;
            MoveHeight = 45;

            Graphics G = default(Graphics);
            G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;

            G.Clear(_MainColour);

            G.FillRectangle(_HeaderBrushColour, new Rectangle(-1, -1, this.Width + 1, 45));
            G.DrawLine(new Pen(new SolidBrush(_BorderColour)), new Point(-1, 45), new Point(this.Width - 1, 45));
            G.DrawRectangle(new Pen(new SolidBrush(_BorderColour)), new Rectangle(0, 0, Width - 1, Height - 1));
            Bitmap I = this.ParentForm.Icon.ToBitmap();
            Image IM = I;
            string FormText = this.ParentForm.Text;
            G.TextRenderingHint = TextRenderingHint.AntiAlias;
            G.DrawString(FormText, Facebook_F, new SolidBrush(Color.FromArgb(220, 220, 220)), new Point(43, 11));
            G.DrawImage(IM, new Rectangle(8, 6, 32, 32));
            
            I.Dispose();
            IM.Dispose();
        }


        #endregion

        #region 51. Festus

        /// <summary>
        /// The title align
        /// </summary>
        private HorizontalAlignment _TitleAlign;

        /// <summary>
        /// The festus p1
        /// </summary>
        private Pen Festus_P1;

        /// <summary>
        /// The festus p2
        /// </summary>
        private Pen Festus_P2;

        /// <summary>
        /// Festuses the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Festus_PaintHook(PaintEventArgs e)
        {
            MoveHeight = 25;
            Festus_P1 = new Pen(Color.FromArgb(220, 219, 219));
            Festus_P2 = new Pen(Color.FromArgb(225, 225, 225));
            Color Textcolor = Color.Black;

            G.Clear(Color.White);

            G.FillRectangle(new SolidBrush(Color.FromArgb(224, 224, 224)), 14, MoveHeight, Width - 30, Height - MoveHeight - 10);
            DrawGradient(Color.FromArgb(220, 220, 220), Color.White, 0, -12, Width, MoveHeight, 90);
            

            if (_TitleAlign == HorizontalAlignment.Center)
            {
                DrawText(HorizontalAlignment.Center, ForeColor, 5);
            }
            else if (_TitleAlign == HorizontalAlignment.Left)
            {
                DrawText(HorizontalAlignment.Left, ForeColor, 5);
            }
            else if (_TitleAlign == HorizontalAlignment.Right)
            {
                DrawText(HorizontalAlignment.Right, ForeColor, 5);
            }

            DrawBorders(Festus_P2, Festus_P1, ClientRectangle);
            DrawCorners(Color.Fuchsia, ClientRectangle);
        }

        #endregion

        #region 52. FlatUI
        #region " Colors"

        #region " Dark Colors"

        /// <summary>
        /// The header color
        /// </summary>
        private Color _HeaderColor = Color.FromArgb(45, 47, 49);
        /// <summary>
        /// The base color
        /// </summary>
        private Color _BaseColor = Color.FromArgb(60, 70, 73);
        /// <summary>
        /// The border color
        /// </summary>
        private Color _BorderColor = Color.FromArgb(53, 58, 60);

        /// <summary>
        /// The text color
        /// </summary>
        private Color TextColor = Color.FromArgb(234, 234, 234);
        #endregion

        #region " Light Colors"

        /// <summary>
        /// The header light
        /// </summary>
        private Color _HeaderLight = Color.FromArgb(171, 171, 172);
        /// <summary>
        /// The base light
        /// </summary>
        private Color _BaseLight = Color.FromArgb(196, 199, 200);

        /// <summary>
        /// The text light
        /// </summary>
        public Color TextLight = Color.FromArgb(45, 47, 49);
        #endregion
        /// <summary>
        /// The flat UI w
        /// </summary>
        private int FlatUI_W;
        /// <summary>
        /// The flat UI h
        /// </summary>
        private int FlatUI_H;
        /// <summary>
        /// The flat UI b
        /// </summary>
        private Bitmap FlatUI_B;

        /// <summary>
        /// The flat color
        /// </summary>
        static internal Color _FlatColor = Color.FromArgb(35, 168, 109);
        /// <summary>
        /// The near sf
        /// </summary>
        static internal StringFormat NearSF = new StringFormat
        {
            Alignment = StringAlignment.Near,
            LineAlignment = StringAlignment.Near
        };
        /// <summary>
        /// The center sf
        /// </summary>
        static internal StringFormat CenterSF = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center

        };
        #endregion
        /// <summary>
        /// Flats the UI paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
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

        #region 53. Flow

        /// <summary>
        /// The flow c1
        /// </summary>
        private Color Flow_C1 = Color.FromArgb(40, 40, 40);
        /// <summary>
        /// The flow c2
        /// </summary>
        private Color Flow_C2 = Color.FromArgb(18, 18, 18);
        /// <summary>
        /// The flow b1
        /// </summary>
        private SolidBrush Flow_B1 = new SolidBrush(Color.FromArgb(0, 132, 255));
        /// <summary>
        /// The flow p1
        /// </summary>
        private Pen Flow_P1 = new Pen(Color.FromArgb(40, 40, 40));
        /// <summary>
        /// The flow p2
        /// </summary>
        private Pen Flow_P2 = new Pen(Color.FromArgb(22, 22, 22));
        /// <summary>
        /// The flow p3
        /// </summary>
        private Pen Flow_P3 = new Pen(Color.FromArgb(65, 65, 65));
        /// <summary>
        /// The flow p4
        /// </summary>
        private Pen Flow_P4 = new Pen(Color.FromArgb(255, Color.Black));

        /// <summary>
        /// The tile
        /// </summary>
        private TextureBrush Tile;
        /// <summary>
        /// The tile data
        /// </summary>
        private byte[] TileData = Convert.FromBase64String("AgIBAQEBAwMBAQEBAAABAQEBAQEBAgIBAQEBAwMBAQEBAAAB");
        /// <summary>
        /// Creates the tile.
        /// </summary>
        private void CreateTile()
        {
            Bitmap TileImage = new Bitmap(6, 6);
            Color[] TileColors = new Color[] {
                Color.FromArgb(39, 39, 39),
                Color.FromArgb(35, 35, 35),
                Color.FromArgb(29, 29, 29),
                Color.FromArgb(26, 26, 26)
            };

            for (int I = 0; I <= 35; I++)
            {
                TileImage.SetPixel(I % 6, I / 6, TileColors[TileData[I]]);
            }

            Tile = new TextureBrush(TileImage);
            TileImage.Dispose();
        }

        /// <summary>
        /// The shade
        /// </summary>
        private Pen[] Shade;
        /// <summary>
        /// Creates the shade.
        /// </summary>
        private void CreateShade()
        {
            if (Shade != null)
            {
                for (int I = 0; I <= Shade.Length - 1; I++)
                {
                    Shade[I].Dispose();
                }
            }

            Bitmap ShadeImage = new Bitmap(1, 20);
            Graphics ShadeGraphics = Graphics.FromImage(ShadeImage);

            Rectangle ShadeBounds = new Rectangle(0, 0, 1, 20);
            LinearGradientBrush Gradient = new LinearGradientBrush(ShadeBounds, Color.FromArgb(50, 7, 7, 7), Color.Transparent, 90f);

            Shade = new Pen[20];
            ShadeGraphics.FillRectangle(Gradient, ShadeBounds);

            for (int I = 0; I <= Shade.Length - 1; I++)
            {
                Shade[I] = new Pen(ShadeImage.GetPixel(0, I));
            }

            Gradient.Dispose();
            ShadeGraphics.Dispose();
            ShadeImage.Dispose();
        }

        /// <summary>
        /// The flow r t1
        /// </summary>
        private Rectangle Flow_RT1;
        /// <summary>
        /// Flows the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Flow_PaintHook(PaintEventArgs e)
        {
            G.Clear(Flow_C1);

            DrawGradient(Flow_C2, Flow_C1, 0, 0, Width, 24);
            DrawText(Flow_B1, HorizontalAlignment.Left, 8, 0);

            Flow_RT1 = new Rectangle(8, 24, Width - 16, Height - 32);


            CreateTile();
            CreateShade();

            G.FillRectangle(Tile, Flow_RT1);

            for (int I = 0; I <= Shade.Length - 1; I++)
            {
                DrawBorders(Shade[I], Flow_RT1, I);
            }

            Flow_RT1 = new Rectangle(8, 24, Width - 16, Height - 32);
            DrawBorders(Flow_P1, Flow_RT1, 1);
            DrawBorders(Flow_P2, Flow_RT1);
            DrawCorners(Flow_C1, Flow_RT1);

            DrawBorders(Flow_P3, 1);
            DrawBorders(Flow_P4);

            DrawCorners(TransparencyKey);
        }


        #endregion

        #region 54. Frog

        /// <summary>
        /// Frogs the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Frog_PaintHook(PaintEventArgs e)
        {
            G.SmoothingMode = SmoothingMode.AntiAlias;

            int BarHeight = 20;

            Point[] Polygon = null;
            Point[] Polygon2 = null;

            Color Color2 = default(Color);
            Color Color = default(Color);
            Color DOES = default(Color);
            Color Border = default(Color);

            Border = Color.FromArgb(160, 200, 200, 200);

            Polygon = new Point[] {
                new Point(50, 2),
                new Point(Width - 51, 2),
                new Point(Width - 56, 18),
                new Point(55, 18)
            };
            Polygon2 = new Point[] {
                new Point((int)51.5, 3),
                new Point(Width - 52, 3),
                new Point(Width - 57, 17),
                new Point(56, 17)
            };

            DOES = Color.FromArgb(255, 60, 60, 60);
            Color = Color.FromArgb(255, 90, 90, 90);
            Color2 = Color.FromArgb(255, 100, 100, 100);

            LinearGradientBrush LGB = new LinearGradientBrush(new Point(0, 0), new Point(0, BarHeight), Color2, DOES);

            G.FillRectangle(new SolidBrush(DOES), new Rectangle(0, 0, Width, Height));
            G.FillRectangle(LGB, new Rectangle(0, 0, Width, BarHeight));
            G.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));
            G.FillPolygon(new SolidBrush(DOES), Polygon);
            G.DrawPolygon(Pens.Black, Polygon);
            G.DrawPolygon(new Pen(Border), Polygon2);
            G.DrawRectangle(Pens.Black, new Rectangle(3, 20, Width - 7, Height - 24));
            G.DrawRectangle(new Pen(Border), new Rectangle(4, 21, Width - 9, Height - 26));
            Font TextFont = default(Font);
            TextFont = new Font("Verdana", 8);
            //G.DrawString(Text, TextFont, Brushes.Black, New Point((Width / 2) - (G.MeasureString(Text, TextFont).Width / 2), 3))
            G.DrawString(Text, TextFont, new SolidBrush(Color.FromArgb(255, 200, 200, 200)), new Point((int)(Width / 2) - (int)(G.MeasureString(Text, TextFont).Width / 2) + 1, 4));
        }

        #endregion

        #region 55. Fusion
        /// <summary>
        /// The fusion p1
        /// </summary>
        private Pen Fusion_P1 = new Pen(Color.Fuchsia);
        /// <summary>
        /// The fusion p2
        /// </summary>
        private Pen Fusion_P2 = new Pen(Color.FromArgb(255, Color.Black));
        /// <summary>
        /// The fusion p3
        /// </summary>
        private Pen Fusion_P3 = new Pen(Color.FromArgb(60, 60, 63));
        /// <summary>
        /// The fusion p4
        /// </summary>
        private Pen Fusion_P4 = new Pen(Color.FromArgb(60, 60, 63));
        /// <summary>
        /// The fusion p5
        /// </summary>
        private Pen Fusion_P5 = new Pen(Color.FromArgb(255,Color.Black));
        /// <summary>
        /// The fusion c1
        /// </summary>
        private Color Fusion_C1 = Color.FromArgb(47, 47, 50);
        /// <summary>
        /// The fusion c2
        /// </summary>
        private Color Fusion_C2 = Color.FromArgb(52, 52, 55);
        /// <summary>
        /// The fusion c3
        /// </summary>
        private Color Fusion_C3 = Color.FromArgb(47, 47, 50);
        /// <summary>
        /// The fusion b1
        /// </summary>
        private SolidBrush Fusion_B1 = new SolidBrush(Color.White);

        /// <summary>
        /// The fusion b2
        /// </summary>
        private SolidBrush Fusion_B2 = new SolidBrush(Color.White);
        /// <summary>
        /// The fusion r t1
        /// </summary>
        private Rectangle Fusion_RT1;

        /// <summary>
        /// The fusion path
        /// </summary>
        private GraphicsPath Fusion_Path;

        /// <summary>
        /// The fusion blend
        /// </summary>
        private ColorBlend Fusion_Blend;
        /// <summary>
        /// Fusions the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Fusion_PaintHook(PaintEventArgs e)
        {
            Fusion_Path = new GraphicsPath();

            Fusion_Blend = new ColorBlend();
            Fusion_Blend.Colors = new Color[]
            {
                Color.Transparent,
                Color.FromArgb(60, 60, 63),
                Color.Transparent
            };

            Fusion_Blend.Positions = new float[] {
                0f,
                0.5f,
                1f
            };
            G.DrawRectangle(Fusion_P1, ClientRectangle);

            Fusion_Path.Reset();
            Fusion_Path.AddLines(new Point[] {
                new Point(2, 0),
                new Point(Width - 3, 0),
                new Point(Width - 1, 2),
                new Point(Width - 1, Height - 3),
                new Point(Width - 3, Height - 1),
                new Point(2, Height - 1),
                new Point(0, Height - 3),
                new Point(0, 2),
                new Point(2, 0)
            });
            G.SetClip(Fusion_Path);

            G.Clear(Fusion_C1);

            DrawGradient(Fusion_C2, Fusion_C3, 0, 0, 16, Height);
            DrawGradient(Fusion_C2, Fusion_C3, Width - 16, 0, 16, Height);

            DrawText(Fusion_B1, HorizontalAlignment.Left, 12, 0);

            Fusion_RT1 = new Rectangle(12, 34, Width - 24, Height - 34 - 12);

            G.FillRectangle(Fusion_B2, Fusion_RT1);
            DrawBorders(Fusion_P2, Fusion_RT1, 1);
            DrawBorders(Fusion_P3, Fusion_RT1);

            DrawBorders(Fusion_P4, 1);
            DrawGradient(Fusion_Blend, 1, 1, Width - 2, 2, 0f);

            G.ResetClip();
            G.DrawPath(Fusion_P5, Fusion_Path);
        }


        #endregion

        #region 56. Future
        /// <summary>
        /// The future c1
        /// </summary>
        private Color Future_C1 = Color.FromArgb(34, 34, 34);
        /// <summary>
        /// The future c2
        /// </summary>
        private Color Future_C2 = Color.FromArgb(34, 34, 34);
        /// <summary>
        /// The future c3
        /// </summary>
        private Color Future_C3 = Color.FromArgb(23, 23, 23);
        /// <summary>
        /// The future c4
        /// </summary>
        private Color Future_C4 = Color.FromArgb(70, Color.Black);
        /// <summary>
        /// The future c5
        /// </summary>
        private Color Future_C5 = Color.FromArgb(255,Color.Transparent);
        /// <summary>
        /// The future p1
        /// </summary>
        private Pen Future_P1 = new Pen(Color.FromArgb(34, 34, 34));
        /// <summary>
        /// The future p2
        /// </summary>
        private Pen Future_P2 = new Pen(Color.FromArgb(255, Color.Black));
        /// <summary>
        /// The future p3
        /// </summary>
        private Pen Future_P3 = new Pen(Color.FromArgb(255, Color.Black));
        /// <summary>
        /// The future p4
        /// </summary>
        private Pen Future_P4 = new Pen(Color.FromArgb(49, 49, 49));
        /// <summary>
        /// The future p5
        /// </summary>
        private Pen Future_P5 = new Pen(Color.FromArgb(255, Color.Black));
        /// <summary>
        /// The future b1
        /// </summary>
        private HatchBrush Future_B1;

        /// <summary>
        /// The future b2
        /// </summary>
        private SolidBrush Future_B2;

        /// <summary>
        /// The future r t1
        /// </summary>
        private Rectangle Future_RT1;
        /// <summary>
        /// Futures the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Future_PaintHook(PaintEventArgs e)
        {
            
            G.Clear(Future_C1);

            Future_B1 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.Black, Color.FromArgb(34, 34, 34));
            Future_B2 = new SolidBrush(ForeColor);
            Future_RT1 = new Rectangle(1, 1, Width - 2, 22);
            DrawGradient(Future_C2, Future_C3, Future_RT1, 90f);
            DrawBorders(Future_P1, Future_RT1);

            G.DrawLine(Future_P2, 0, 23, Width, 23);

            G.FillRectangle(Future_B1, 0, 24, Width, 13);

            DrawGradient(Future_C4, Future_C5, 0, 24, Width, 6);

            G.DrawLine(Future_P3, 0, 37, Width, 37);
            DrawBorders(Future_P4, 1, 38, Width - 2, Height - 39);

            DrawText(Future_B2, HorizontalAlignment.Left, 5, 0);

            DrawBorders(Future_P5);
        }

        #endregion

        #region 57. GTheme

        /// <summary>
        /// The g theme c1
        /// </summary>
        private Color GTheme_C1 = Color.FromArgb(25, 25, 25);
        /// <summary>
        /// The g theme c2
        /// </summary>
        private Color GTheme_C2 = Color.FromArgb(51, 51, 51);
        /// <summary>
        /// The g theme p1
        /// </summary>
        private Pen GTheme_P1 = new Pen(Color.FromArgb(58, 58, 58));
        /// <summary>
        /// The g theme p2
        /// </summary>
        private Pen GTheme_P2;

        /// <summary>
        /// The g theme b1
        /// </summary>
        private Color GTheme_B1 = Color.FromArgb(204, 204, 204);
        /// <summary>
        /// gs the theme paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void GTheme_PaintHook(PaintEventArgs e)
        {
            
            GTheme_P2 = new Pen(GTheme_C2);
            G.Clear(GTheme_C1);

            DrawGradient(GTheme_C2, GTheme_C1, 0, 0, Width, 28, 90);

            G.DrawLine(GTheme_P2, 0, 28, Width, 28);
            G.DrawLine(GTheme_P1, 0, 29, Width, 29);

            DrawText(HorizontalAlignment.Center, GTheme_B1, 5 + 3/*ImageWidth*/);
            G.DrawIcon(ParentForm.FindForm().Icon, new Rectangle(4, 4, 20, 20));
            //DrawIcon(HorizontalAlignment.Left, 5);

            DrawBorders(Pens.Black, GTheme_P1, ClientRectangle);
            DrawCorners(Color.Fuchsia, ClientRectangle);
        }


        #endregion

        #region 58. Game Booster
        /// <summary>
        /// The game booster c1
        /// </summary>
        private Color GameBooster_C1 = Color.FromArgb(232, 232, 232);
        /// <summary>
        /// The game booster c2
        /// </summary>
        private Color GameBooster_C2 = Color.FromArgb(252, 252, 252);
        /// <summary>
        /// The game booster c3
        /// </summary>
        private Color GameBooster_C3 = Color.FromArgb(242, 242, 242);
        /// <summary>
        /// The game booster b1
        /// </summary>
        private SolidBrush GameBooster_B1 = new SolidBrush(Color.FromArgb(255, 255, 255));
        /// <summary>
        /// The game booster b2
        /// </summary>
        private SolidBrush GameBooster_B2 = new SolidBrush(Color.FromArgb(80, 80, 80));
        /// <summary>
        /// The game booster b3
        /// </summary>
        private SolidBrush GameBooster_B3 = new SolidBrush(Color.FromArgb(255, 255, 255));
        /// <summary>
        /// The game booster p1
        /// </summary>
        private Pen GameBooster_P1 = new Pen(Color.FromArgb(24, 24, 24));
        /// <summary>
        /// The game booster p2
        /// </summary>
        private Pen GameBooster_P2 = new Pen(Color.FromArgb(126, 126, 126));
        /// <summary>
        /// The game booster p3
        /// </summary>
        private Pen GameBooster_P3 = new Pen(Color.FromArgb(92, 92, 92));

        /// <summary>
        /// The game booster p4
        /// </summary>
        private Pen GameBooster_P4 = new Pen(Color.FromArgb(24, 24, 24));


        /// <summary>
        /// The game booster r t1
        /// </summary>
        private Rectangle GameBooster_RT1;

        /// <summary>
        /// Games the booster paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void GameBooster_PaintHook(PaintEventArgs e)
        {
            
            G.Clear(Color.FromArgb(51, 51, 51));

            DrawGradient(GameBooster_C2, GameBooster_C3, 0, 0, Width, 15);

            DrawText(GameBooster_B1, HorizontalAlignment.Left, 13, 1);
            DrawText(GameBooster_B2, HorizontalAlignment.Left, 12, 0);

            DrawGradient(Color.FromArgb(92, 92, 92), Color.FromArgb(49, 49, 49), 0, 0, Width, 26);
            G.DrawLine(new Pen(GameBooster_P1.Color), new Point(0, 26), new Point(Width, 26));
            G.DrawRectangle(GameBooster_P1, 0, 0, Width - 1, Height - 1);
            G.DrawRectangle(GameBooster_P2, 1, 1, Width - 3, Height - 3);
            DrawPixel(GameBooster_P1.Color, 1, 1);
            DrawPixel(GameBooster_P2.Color, 2, 2);
            DrawPixel(GameBooster_P1.Color, Width - 2, 1);
            DrawPixel(GameBooster_P2.Color, Width - 3, 2);
            DrawPixel(GameBooster_P1.Color, 1, Height - 2);
            DrawPixel(GameBooster_P2.Color, 2, Height - 3);
            DrawPixel(GameBooster_P1.Color, Width - 2, Height - 2);
            DrawPixel(GameBooster_P2.Color, Width - 3, Height - 3);
            DrawText(new SolidBrush(Color.FromArgb(61, 61, 61)), HorizontalAlignment.Center, 0, 1);
            DrawText(new SolidBrush(Color.White), HorizontalAlignment.Center, 0, 2);

        }

        #endregion

        #region 59. Genuine

        /// <summary>
        /// The genuine c1
        /// </summary>
        private Color Genuine_C1 = Color.FromArgb(41, 41, 41);
        /// <summary>
        /// The genuine c2
        /// </summary>
        private Color Genuine_C2 = Color.FromArgb(25, 25, 25);
        /// <summary>
        /// The genuine c3
        /// </summary>
        private Color Genuine_C3 = Color.FromArgb(41, 41, 41);
        /// <summary>
        /// The genuine b1
        /// </summary>
        private SolidBrush Genuine_B1 = new SolidBrush(Color.FromArgb(255, 255, 255));

        /// <summary>
        /// The genuine p1
        /// </summary>
        private Pen Genuine_P1 = new Pen(Color.FromArgb(25, 25, 25));
        /// <summary>
        /// The genuine p2
        /// </summary>
        private Pen Genuine_P2 = new Pen(Color.FromArgb(58, 58, 58));
        /// <summary>
        /// The genuine p3
        /// </summary>
        private Pen Genuine_P3 = new Pen(Color.FromArgb(58, 58, 58));

        /// <summary>
        /// The genuine p4
        /// </summary>
        private Pen Genuine_P4 = new Pen(Color.FromArgb(0,0,0));



        /// <summary>
        /// Genuines the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Genuine_PaintHook(PaintEventArgs e)
        {
            G.Clear(Genuine_C1);

            DrawGradient(Genuine_C2, Genuine_C3, 0, 0, Width, 28);

            G.DrawLine(Genuine_P1, 0, 28, Width, 28);
            G.DrawLine(Genuine_P2, 0, 29, Width, 29);

            DrawText(Genuine_B1, HorizontalAlignment.Left, 7, 0);

            DrawBorders(Genuine_P3, 1);
            DrawBorders(Genuine_P4);

            DrawCorners(TransparencyKey);
        }

        #endregion

        #region 60. Ghostv2

        /// <summary>
        /// Ghostv2s the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Ghostv2_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.DimGray);
            ColorBlend hatch = new ColorBlend(2);
            DrawBorders(Pens.Gray, 1);
            hatch.Colors[0] = Color.DimGray;
            hatch.Colors[1] = Color.FromArgb(60, 60, 60);
            hatch.Positions[0] = 0;
            hatch.Positions[1] = 1;
            DrawGradient(hatch, new Rectangle(0, 0, Width, 24));
            hatch.Colors[0] = Color.FromArgb(100, 100, 100);
            hatch.Colors[1] = Color.DimGray;
            DrawGradient(hatch, new Rectangle(0, 0, Width, 12));
            HatchBrush asdf = default(HatchBrush);
            asdf = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(15, Color.Black), Color.FromArgb(0, Color.Gray));
            hatch.Colors[0] = Color.FromArgb(120, Color.Black);
            hatch.Colors[1] = Color.FromArgb(0, Color.Black);
            DrawGradient(hatch, new Rectangle(0, 0, Width, 30));
            G.FillRectangle(asdf, 0, 0, Width, 24);
            G.DrawLine(Pens.Black, 6, 24, Width - 7, 24);
            G.DrawLine(Pens.Black, 6, 24, 6, Height - 7);
            G.DrawLine(Pens.Black, 6, Height - 7, Width - 7, Height - 7);
            G.DrawLine(Pens.Black, Width - 7, 24, Width - 7, Height - 7);
            G.FillRectangle(new SolidBrush(Color.FromArgb(60, 60, 60)), new Rectangle(1, 24, 5, Height - 6 - 24));
            G.FillRectangle(asdf, 1, 24, 5, Height - 6 - 24);
            G.FillRectangle(new SolidBrush(Color.FromArgb(60, 60, 60)), new Rectangle(Width - 6, 24, Width - 1, Height - 6 - 24));
            G.FillRectangle(asdf, Width - 6, 24, Width - 2, Height - 6 - 24);
            G.FillRectangle(new SolidBrush(Color.FromArgb(60, 60, 60)), new Rectangle(1, Height - 6, Width - 2, Height - 1));
            G.FillRectangle(asdf, 1, Height - 6, Width - 2, Height - 1);
            DrawBorders(Pens.Black);
            asdf = new HatchBrush(HatchStyle.LightDownwardDiagonal, Color.DimGray);
            G.FillRectangle(asdf, 7, 25, Width - 14, Height - 24 - 8);
            G.FillRectangle(new SolidBrush(Color.FromArgb(230, 20, 20, 20)), 7, 25, Width - 14, Height - 24 - 8);
            DrawCorners(Color.Fuchsia);
            DrawCorners(Color.Fuchsia, 0, 1, 1, 1);
            DrawCorners(Color.Fuchsia, 1, 0, 1, 1);
            DrawPixel(Color.Black, 1, 1);

            DrawCorners(Color.Fuchsia, 0, Height - 2, 1, 1);
            DrawCorners(Color.Fuchsia, 1, Height - 1, 1, 1);
            DrawPixel(Color.Black, Width - 2, 1);

            DrawCorners(Color.Fuchsia, Width - 1, 1, 1, 1);
            DrawCorners(Color.Fuchsia, Width - 2, 0, 1, 1);
            DrawPixel(Color.Black, 1, Height - 2);

            DrawCorners(Color.Fuchsia, Width - 1, Height - 2, 1, 1);
            DrawCorners(Color.Fuchsia, Width - 2, Height - 1, 1, 1);
            DrawPixel(Color.Black, Width - 2, Height - 2);

            ColorBlend cblend = new ColorBlend(2);
            cblend.Colors[0] = Color.FromArgb(35, Color.Black);
            cblend.Colors[1] = Color.FromArgb(0, 0, 0, 0);
            cblend.Positions[0] = 0;
            cblend.Positions[1] = 1;
            DrawGradient(cblend, 7, 25, 15, Height - 6 - 24, 0);
            cblend.Colors[0] = Color.FromArgb(0, 0, 0, 0);
            cblend.Colors[1] = Color.FromArgb(35, Color.Black);
            DrawGradient(cblend, Width - 24, 25, 17, Height - 6 - 24, 0);
            cblend.Colors[1] = Color.FromArgb(0, 0, 0, 0);
            cblend.Colors[0] = Color.FromArgb(35, Color.Black);
            DrawGradient(cblend, 7, 25, this.Width - 14, 17, 90);
            cblend.Colors[0] = Color.FromArgb(0, 0, 0, 0);
            cblend.Colors[1] = Color.FromArgb(35, Color.Black);
            DrawGradient(cblend, 8, this.Height - 24, this.Width - 14, 17, 90);
            if (_ShowIcon == false)
            {
                G.DrawString(Text, Font, Brushes.White, new Point(6, 6));
            }
            else
            {
                G.DrawIcon(Parent.FindForm().Icon, new Rectangle(new Point(9, 5), new Size(16, 16)));
                G.DrawString(Text, Font, Brushes.White, new Point(28, 6));
            }

        }


        #endregion

        #region Ghost

        /// <summary>
        /// Ghosts the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Ghost_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.DimGray);
            ColorBlend hatch = new ColorBlend(2);
            DrawBorders(Pens.Gray, 1);
            hatch.Colors[0] = Color.DimGray;
            hatch.Colors[1] = Color.FromArgb(60, 60, 60);
            hatch.Positions[0] = 0;
            hatch.Positions[1] = 1;
            DrawGradient(hatch, new Rectangle(0, 0, Width, 24));
            hatch.Colors[0] = Color.FromArgb(100, 100, 100);
            hatch.Colors[1] = Color.DimGray;
            DrawGradient(hatch, new Rectangle(0, 0, Width, 12));
            HatchBrush asdf = default(HatchBrush);
            asdf = new HatchBrush(HatchStyle.DottedDiamond, Color.FromArgb(15, Color.Black), Color.FromArgb(0, Color.Gray));
            hatch.Colors[0] = Color.FromArgb(120, Color.Black);
            hatch.Colors[1] = Color.FromArgb(0, Color.Black);
            DrawGradient(hatch, new Rectangle(0, 0, Width, 30));
            G.FillRectangle(asdf, 0, 0, Width, 24);
            G.DrawLine(Pens.Black, 6, 24, Width - 7, 24);
            G.DrawLine(Pens.Black, 6, 24, 6, Height - 7);
            G.DrawLine(Pens.Black, 6, Height - 7, Width - 7, Height - 7);
            G.DrawLine(Pens.Black, Width - 7, 24, Width - 7, Height - 7);
            G.FillRectangle(new SolidBrush(Color.FromArgb(60, 60, 60)), new Rectangle(1, 24, 5, Height - 6 - 24));
            G.FillRectangle(asdf, 1, 24, 5, Height - 6 - 24);
            G.FillRectangle(new SolidBrush(Color.FromArgb(60, 60, 60)), new Rectangle(Width - 6, 24, Width - 1, Height - 6 - 24));
            G.FillRectangle(asdf, Width - 6, 24, Width - 2, Height - 6 - 24);
            G.FillRectangle(new SolidBrush(Color.FromArgb(60, 60, 60)), new Rectangle(1, Height - 6, Width - 2, Height - 1));
            G.FillRectangle(asdf, 1, Height - 6, Width - 2, Height - 1);
            DrawBorders(Pens.Black);
            asdf = new HatchBrush(HatchStyle.LightDownwardDiagonal, Color.DimGray);
            G.FillRectangle(asdf, 7, 25, Width - 14, Height - 24 - 8);
            G.FillRectangle(new SolidBrush(Color.FromArgb(230, 20, 20, 20)), 7, 25, Width - 14, Height - 24 - 8);
            DrawCorners(Color.Fuchsia);
            DrawCorners(Color.Fuchsia, 0, 1, 1, 1);
            DrawCorners(Color.Fuchsia, 1, 0, 1, 1);
            DrawPixel(Color.Black, 1, 1);

            DrawCorners(Color.Fuchsia, 0, Height - 2, 1, 1);
            DrawCorners(Color.Fuchsia, 1, Height - 1, 1, 1);
            DrawPixel(Color.Black, Width - 2, 1);

            DrawCorners(Color.Fuchsia, Width - 1, 1, 1, 1);
            DrawCorners(Color.Fuchsia, Width - 2, 0, 1, 1);
            DrawPixel(Color.Black, 1, Height - 2);

            DrawCorners(Color.Fuchsia, Width - 1, Height - 2, 1, 1);
            DrawCorners(Color.Fuchsia, Width - 2, Height - 1, 1, 1);
            DrawPixel(Color.Black, Width - 2, Height - 2);

            ColorBlend cblend = new ColorBlend(2);
            cblend.Colors[0] = Color.FromArgb(35, Color.Black);
            cblend.Colors[1] = Color.FromArgb(0, 0, 0, 0);
            cblend.Positions[0] = 0;
            cblend.Positions[1] = 1;
            DrawGradient(cblend, 7, 25, 15, Height - 6 - 24, 0);
            cblend.Colors[0] = Color.FromArgb(0, 0, 0, 0);
            cblend.Colors[1] = Color.FromArgb(35, Color.Black);
            DrawGradient(cblend, Width - 24, 25, 17, Height - 6 - 24, 0);
            cblend.Colors[1] = Color.FromArgb(0, 0, 0, 0);
            cblend.Colors[0] = Color.FromArgb(35, Color.Black);
            DrawGradient(cblend, 7, 25, this.Width - 14, 17, 90);
            cblend.Colors[0] = Color.FromArgb(0, 0, 0, 0);
            cblend.Colors[1] = Color.FromArgb(35, Color.Black);
            DrawGradient(cblend, 8, this.Height - 24, this.Width - 14, 17, 90);
            if (_ShowIcon == false)
            {
                G.DrawString(Text, Font, Brushes.White, new Point(6, 6));
            }
            else
            {
                G.DrawIcon(Parent.FindForm().Icon, new Rectangle(new Point(9, 5), new Size(16, 16)));
                G.DrawString(Text, Font, Brushes.White, new Point(28, 6));
            }

        }


        #endregion

        #region Gray

        /// <summary>
        /// Grays the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        void Gray_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {
            
            G.Clear(Color.FromArgb(51, 51, 51));

            G.SmoothingMode = SmoothingMode.AntiAlias;
            
            G.FillPath(DesignFunctions.ToBrush(20, Color.Black), DesignFunctions.RoundRect(0, 0, Width - 1, Height - 2, 5));
            G.DrawPath(DesignFunctions.ToPen(50, Color.White), DesignFunctions.RoundRect(-1, -4, Width + 1, Height + 3, 5));
            G.DrawPath(DesignFunctions.ToPen(50, Color.Black), DesignFunctions.RoundRect(0, 0, Width - 1, Height - 2, 5));

            for (int i = 0; i <= 10; i++)
            {
                G.DrawPath(DesignFunctions.ToPen(50 / (i + 1), Color.Black), DesignFunctions.RoundRect(i, i, Width - 1 - (i * 2), Height - 2 - (i * 2), 5));
            }
        }


        #endregion

        #region Green

        /// <summary>
        /// The green b
        /// </summary>
        Bitmap Green_B;
        /// <summary>
        /// The green r1
        /// </summary>
        Rectangle Green_R1;
        /// <summary>
        /// The green r2
        /// </summary>
        Rectangle Green_R2;
        /// <summary>
        /// The green c1
        /// </summary>
        Color Green_C1 = Color.FromArgb(41, 57, 34);
        /// <summary>
        /// The green c2
        /// </summary>
        Color Green_C2 = Color.FromArgb(190, 255, 159);
        /// <summary>
        /// The green c3
        /// </summary>
        Color Green_C3 = Color.FromArgb(22, 22, 22);
        /// <summary>
        /// The green c4
        /// </summary>
        Color Green_C4 = Color.FromArgb(20, 107, 18);
        /// <summary>
        /// The green p1
        /// </summary>
        Pen Green_P1 = new Pen(Color.FromArgb(20, 107, 18));
        /// <summary>
        /// The green p2
        /// </summary>
        Pen Green_P2 = new Pen(Color.FromArgb(41, 57, 34));
        /// <summary>
        /// The green p3
        /// </summary>
        Pen Green_P3 = new Pen(Color.FromArgb(190, 255, 159));
        /// <summary>
        /// The green b1
        /// </summary>
        SolidBrush Green_B1 = new SolidBrush(Color.FromArgb(190, 255, 159));
        /// <summary>
        /// The green b2
        /// </summary>
        LinearGradientBrush Green_B2;

        /// <summary>
        /// The green b3
        /// </summary>
        LinearGradientBrush Green_B3;

        /// <summary>
        /// Greens the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Green_PaintHook(PaintEventArgs e)
        {
            Green_B = new Bitmap(Width, Height);
            G = Graphics.FromImage(Green_B);

            Green_R1 = new Rectangle(0, 2, Width, 18);
            Green_R2 = new Rectangle(0, 21, Width, 10);
            Green_B2 = new LinearGradientBrush(Green_R1, Green_C1, Green_C3, 90f);
            Green_B3 = new LinearGradientBrush(Green_R2, Color.FromArgb(70, 0, 0, 0), Color.Transparent, 90f);


            G.Clear(Green_C1);

            for (int I = 0; I <= Width + 17; I += 4)
            {
                G.DrawLine(Green_P1, I, 21, I - 17, 37);
                G.DrawLine(Green_P1, I - 1, 21, I - 16, 37);
            }
            G.FillRectangle(Green_B3, Green_R2);

            G.FillRectangle(Green_B2, Green_R1);
            G.DrawString(Text, Font, Green_B1, 5, 5);

            G.DrawRectangle(Green_P2, 1, 1, Width - 3, 19);
            G.DrawRectangle(Green_P3, 1, 39, Width - 3, Height - 41);

            G.DrawRectangle(Green_P1, 0, 0, Width - 1, Height - 1);
            G.DrawLine(Green_P1, 0, 21, Width, 21);
            G.DrawLine(Green_P1, 0, 38, Width, 38);

            e.Graphics.DrawImage(Green_B, 0, 0);
            //G.Dispose();
            Green_B.Dispose();
        }


        #endregion

        #region Hacker

        /// <summary>
        /// The hacker colors
        /// </summary>
        private Color[] hacker_colors = new Color[]
        {
            Color.FromArgb(255, 16, 16, 16),
            Color.FromArgb(255, 14, 14, 14),
            Color.FromArgb(120, 80, 80, 80),
            Color.FromArgb(120, 64, 64, 64),
            Color.FromArgb(255, 20, 20, 20),
            Color.FromArgb(255, 12, 12, 12)

        };

        /// <summary>
        /// The hacker hatchstyle
        /// </summary>
        private HatchStyle hacker_hatchstyle = HatchStyle.DarkDownwardDiagonal;

        /// <summary>
        /// Enum HackerDrawMode
        /// </summary>
        public enum HackerDrawMode
        {
            /// <summary>
            /// The solid
            /// </summary>
            Solid,
            /// <summary>
            /// The hatch
            /// </summary>
            Hatch,
            /// <summary>
            /// The gradient
            /// </summary>
            Gradient
        }

        /// <summary>
        /// The hacker draw mode
        /// </summary>
        HackerDrawMode hackerDrawMode = HackerDrawMode.Hatch;

        /// <summary>
        /// The hacker linear grade mode
        /// </summary>
        private LinearGradientMode hacker_linearGradeMode = LinearGradientMode.ForwardDiagonal;

        /// <summary>
        /// Gets or sets the hacker colors.
        /// </summary>
        /// <value>The hacker colors.</value>
        [Category("Hacker Theme")]
        public Color[] HackerColors
        {
            get { return hacker_colors; }
            set
            {
                hacker_colors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the hacker hatch.
        /// </summary>
        /// <value>The hacker hatch.</value>
        [Category("Hacker Theme")]
        public HatchStyle HackerHatch
        {
            get { return hacker_hatchstyle; }
            set
            {
                hacker_hatchstyle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the hack draw mode.
        /// </summary>
        /// <value>The hack draw mode.</value>
        [Category("Hacker Theme")]
        public HackerDrawMode HackDrawMode
        {
            get { return hackerDrawMode; }
            set
            {
                hackerDrawMode = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the hacker grad mode.
        /// </summary>
        /// <value>The hacker grad mode.</value>
        [Category("Hacker Theme")]
        public LinearGradientMode HackerGradMode
        {
            get { return hacker_linearGradeMode; }
            set
            {
                hacker_linearGradeMode = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Hackers the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Hacker_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Black);
            G.SmoothingMode = SmoothingMode.HighQuality;

            switch (hackerDrawMode)
            {
                case HackerDrawMode.Hatch:
                {
                    //Form Border
                    HatchBrush HB = new HatchBrush(hacker_hatchstyle, hacker_colors[0], hacker_colors[1]);
                    G.FillRectangle(HB, new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(Color.Black), 0, 0, Width - 1, Height - 1);
                    //Form Interior
                    HatchBrush HB2 = new HatchBrush(hacker_hatchstyle, hacker_colors[2], hacker_colors[3]);
                    G.FillRectangle(HB2, new Rectangle(6, 25, Width - 11, Height - 30));
                    //Title Box
                    HatchBrush HB3 = new HatchBrush(hacker_hatchstyle, hacker_colors[4], hacker_colors[5]);
                    Point[] p = {
                        new Point(3, 15),
                        new Point(20, 3),
                        new Point(230, 3),
                        new Point(230, 15),
                        new Point(200, 35),
                        new Point(3, 35)
                    };
                    G.FillPolygon(HB3, p);
                    G.DrawPolygon(Pens.Black, p);
                        break;
                }

                case HackerDrawMode.Solid:
                {
                    //Form Border
                    SolidBrush Solid1 = new SolidBrush(hacker_colors[0]);
                    G.FillRectangle(Solid1, new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(Color.Black), 0, 0, Width - 1, Height - 1);
                    //Form Interior
                    SolidBrush Solid2 = new SolidBrush(hacker_colors[2]);
                    G.FillRectangle(Solid2, new Rectangle(6, 25, Width - 11, Height - 30));
                    //Title Box
                    SolidBrush Solid3 = new SolidBrush(hacker_colors[4]);
                    Point[] p = {
                        new Point(3, 15),
                        new Point(20, 3),
                        new Point(230, 3),
                        new Point(230, 15),
                        new Point(200, 35),
                        new Point(3, 35)
                    };
                    G.FillPolygon(Solid3, p);
                    G.DrawPolygon(Pens.Black, p);
                        break;
                }

                case HackerDrawMode.Gradient:
                {
                    //Form Border
                    LinearGradientBrush LinBr = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), hacker_colors[0], hacker_colors[1], hacker_linearGradeMode);
                    G.FillRectangle(LinBr, new Rectangle(0, 0, Width - 1, Height - 1));

                    G.DrawRectangle(new Pen(Color.Black), 0, 0, Width - 1, Height - 1);
                        //Form Interior
                    LinearGradientBrush LinBr1 = new LinearGradientBrush(new Rectangle(6, 25, Width - 11, Height - 30), hacker_colors[2], hacker_colors[3], hacker_linearGradeMode);
                    G.FillRectangle(LinBr1, new Rectangle(6, 25, Width - 11, Height - 30));
                        //Title Box
                    PointF[] p = {
                        new Point(3, 15),
                        new Point(20, 3),
                        new Point(230, 3),
                        new Point(230, 15),
                        new Point(200, 35),
                        new Point(3, 35)
                    };
                    LinearGradientBrush LinBr2 = new LinearGradientBrush(new Point(3,15), new Point(230,15), hacker_colors[4], hacker_colors[5]);

                        G.FillPolygon(LinBr2, p);
                    G.DrawPolygon(Pens.Black, p);
                        break;
                }

            }
            
            //Icon and Form Title
            G.DrawString(Text, Font, new SolidBrush(ForeColor), new Point(40, 12));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(20, 12, 16, 16));
            //Draw Border
            DrawBorders(Pens.Black, 0);
        }

        #endregion

        #region Hero

        /// <summary>
        /// Heroes the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Hero_PaintHook(PaintEventArgs e)
        {
            MoveHeight = 25;
            G.Clear(Color.FromArgb(211, 211, 211));


            G.Clear(Color.FromArgb(211, 211, 211));
            DrawGradient(Color.FromArgb(62, 62, 62), Color.FromArgb(40, 40, 40), 0, 0, Width, 25, 90);

            G.DrawLine(Pens.Black, 0, 25, Width, 25);

            DrawCorners(Color.Fuchsia, ClientRectangle);
            DrawBorders(Pens.Black, Pens.DimGray, ClientRectangle);

            DrawText(HorizontalAlignment.Left, Color.FromArgb(211, 211, 211), 7, 1);
        }

        #endregion

        #region Hex

        /// <summary>
        /// Hexadecimals the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Hex_PaintHook(PaintEventArgs e)
        {
            
            G.Clear(Color.FromArgb(47, 51, 60));
            G.FillRectangle(new SolidBrush(Color.FromArgb(30, 33, 40)), new Rectangle(0, _Header, Width, Height - _Header));
            StringFormat _StringF = new StringFormat();
            _StringF.Alignment = StringAlignment.Center;
            _StringF.LineAlignment = StringAlignment.Center;
            G.DrawString(Text, new Font("Segoe UI", 11), new SolidBrush(Color.FromArgb(236, 95, 75)), new RectangleF(0, 0, Width, _Header), _StringF);
        }

        #endregion

        #region HF

        /// <summary>
        /// Hfs the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void HF_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromKnownColor(KnownColor.Control));
            // Clear the form first

            //DrawGradient(Color.FromArgb(64, 64, 64), Color.FromArgb(32, 32, 32), 0, 0, Width, Height, 90S)   ' Form Gradient
            G.Clear(Color.Gray);
            DrawGradient(Color.Gray, Color.Purple, 0, 0, Width, 25, 90);

            G.DrawLine(Pens.Black, 0, 25, Width, 25);
            // Top Line
            //G.DrawLine(Pens.Black, 0, Height - 25, Width, Height - 25)   ' Bottom Line

            DrawCorners(Color.Fuchsia, ClientRectangle);
            // Then draw some clean corners
            DrawBorders(Pens.Purple, Pens.Purple, ClientRectangle);
            // Then we draw our form borders

            DrawText(HorizontalAlignment.Left, Color.White, 7, 1);
            // Finally, we draw our text
        }

        #endregion

        #region Hura

        /// <summary>
        /// Hurathemes the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Huratheme_PaintHook(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            
            G.Clear(Color.FromArgb(40, 40, 40));
            G.DrawLine(new Pen(Color.DodgerBlue, 1), new Point(0, 30), new Point(Width, 30));
            G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(8, 6, Width - 1, Height - 1), StringFormat.GenericDefault);
            G.DrawRectangle(new Pen(Color.FromArgb(100, 100, 100)), new Rectangle(0, 0, Width - 1, Height - 1));
            e.Graphics.DrawImage(B, new Point(0, 0));
            //G.Dispose();
            B.Dispose();
        }


        #endregion

        #region iBlack
        /// <summary>
        /// The i black c1
        /// </summary>
        private Color iBlack_C1 = Color.White;
        /// <summary>
        /// The i black c2
        /// </summary>
        private Color iBlack_C2 = Color.FromArgb(60, 60, 60);
        /// <summary>
        /// The i black c3
        /// </summary>
        private Color iBlack_C3 = Color.FromArgb(50, 50, 50);
        /// <summary>
        /// The i black b1
        /// </summary>
        private SolidBrush iBlack_B1 = new SolidBrush(Color.DarkSlateGray);
        /// <summary>
        /// The i black b2
        /// </summary>
        private SolidBrush iBlack_B2 = new SolidBrush(Color.FromArgb(45, Color.White));
        /// <summary>
        /// The i black p1
        /// </summary>
        private Pen iBlack_P1 = new Pen(Color.FromArgb(138, 138, 138));
        /// <summary>
        /// The i black p2
        /// </summary>
        private Pen iBlack_P2 = new Pen(Color.FromArgb(255, Color.Black));

        /// <summary>
        /// is the black paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void iBlack_PaintHook(PaintEventArgs e)
        {
            G.Clear(iBlack_C1);
            DrawGradient(Color.FromArgb(30, 255, 255, 255), Color.FromArgb(95, 3, 35, 58), 10, 20, Width, Height, 90);
            DrawGradient(iBlack_C2, iBlack_C3, 0, 0, Width, Height);
            G.FillRectangle(iBlack_B2, 0, 0, Width, 4);
            G.DrawLine(iBlack_P1, 30, 30, 30, 30);
            G.DrawLine(iBlack_P1, Width - 1, 0, Width - 1, 25);
            G.DrawLine(iBlack_P2, 0, 0, 0, Height);
            G.DrawLine(iBlack_P2, Width - 1, 0, Width - 1, Height);
            G.DrawLine(iBlack_P2, 0, Height - 1, Width, Height - 1);
            HatchBrush T = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(95, 3, 35, 58), Color.FromArgb(95, 3, 35, 58));
            G.FillRectangle(T, 10, 20, Width - 20, Height - 30);
            G.DrawLine(iBlack_P2, 0, 0, Width, 0);
            DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
            HatchBrush i = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(25, 25, 25), Color.FromArgb(90, 35, 35, 35));
            G.FillRectangle(i, 10, 20, Width - 20, Height - 30);
            G.DrawRectangle(Pens.Black, 10, 20, Width - 20, Height - 30);
            HatchBrush d = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(95, 40, 142, 172), Color.FromArgb(90, 40, 142, 172));
            G.FillRectangle(iBlack_B2, 0, Convert.ToInt32(Height - 5), Width, 4);

        }


        #endregion

        #region Influence

        /// <summary>
        /// Influences the paint.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        void Influence_Paint(System.Windows.Forms.PaintEventArgs e)
        {


            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);

            //if (_minimBool)
            //{
            //    Controls.Add(minimBtn);
            //}
            //else
            //{
            //    Controls.Remove(minimBtn);
            //}

            //minimBtn.Location = new Point(Width - 81, 0);
            //closeBtn.Location = new Point(Width - 52, 0);

            G.SmoothingMode = SmoothingMode.HighSpeed;
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            Color TransparencyKey = this.ParentForm.TransparencyKey;
            Draw d = new Draw();
            

            G.Clear(TransparencyKey);

            G.FillPath(new SolidBrush(Color.FromArgb(20, 20, 20)), d.RoundRect(ClientRectangle, 2));


            HatchBrush h1 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
            LinearGradientBrush g1 = new LinearGradientBrush(new Rectangle(0, 2, Width - 1, 25), Color.FromArgb(40, 40, 40), Color.FromArgb(29, 29, 29), 90);

            G.FillPath(g1, d.RoundRect(new Rectangle(0, 2, Width - 1, 25), 2));
            G.FillPath(h1, d.RoundRect(new Rectangle(0, 2, Width - 1, 25), 2));

            LinearGradientBrush s1 = new LinearGradientBrush(g1.Rectangle, Color.FromArgb(15, Color.White), Color.FromArgb(0, Color.White), 90);
            G.FillRectangle(s1, new Rectangle(1, 1, Width - 1, 13));

            G.DrawLine(new Pen(Color.FromArgb(75, Color.White)), 1, 1, Width - 1, 1);

            G.DrawLine(new Pen(Color.FromArgb(18, 18, 18)), 1, 26, Width - 1, 26);

            G.DrawRectangle(new Pen(Color.FromArgb(37, 37, 37)), new Rectangle(1, 27, Width - 3, Height - 29));

            G.DrawPath(Pens.Black, d.RoundRect(ClientRectangle, 2));

            G.DrawString(Text, Font, Brushes.Black, new Rectangle(8, 8, Width - 1, 10), new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Near
            });
            G.DrawString(Text, Font, Brushes.White, new Rectangle(8, 9, Width - 1, 11), new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Near
            });

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            G.Dispose();
            B.Dispose();
        }


        #endregion

        #region Influx

        /// <summary>
        /// Influxes the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Influx_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(53, 53, 53));
            //Draw form border
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(53, 53, 53))), new Rectangle(0, 0, Width - 1, Height - 1));
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(66, 66, 66))), new Rectangle(1, 1, Width - 3, Height - 3));
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(79, 79, 79)), 2), new Rectangle(3, 3, Width - 6, Height - 6));
            //Draw form content
            HatchBrush HB = new HatchBrush(HatchStyle.Percent20, Color.FromArgb(83, 83, 83), BackColor);
            G.FillRectangle(HB, new Rectangle(4, 15, Width - 8, Height - 19));
            //Draw title bar
            LinearGradientBrush TitleTopGradient = new LinearGradientBrush(new Rectangle(4, 4, Width - 8, 11), Color.FromArgb(79, 79, 79), Color.FromArgb(87, 87, 87), (float)0);
            TitleTopGradient.SetBlendTriangularShape(0.5f, 1f);
            G.FillRectangle(TitleTopGradient, new Rectangle(4, 4, Width - 8, 11));
            LinearGradientBrush TitleBottomGradient = new LinearGradientBrush(new Rectangle(4, 15, Width - 8, 11), Color.FromArgb(150, 67, 67, 67), Color.FromArgb(150, 73, 73, 73), (float)0);
            TitleBottomGradient.SetBlendTriangularShape(0.5f, 1f);
            G.FillRectangle(TitleBottomGradient, new Rectangle(4, 15, Width - 8, 11));
            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(ForeColor), new Point(30, 7));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(9, 6, 16, 16));
            //DrawCorners(Color.Fuchsia)
        }

        #endregion

        #region Inner Darkness

        /// <summary>
        /// Inners the darkness paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void InnerDarkness_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Black);
            DrawBG(Color.DimGray, ClientRectangle);
            DrawGradient(Color.DimGray, Color.Black, 0, 0, Width, 20, 90);
            DrawCorners(Color.Fuchsia, ClientRectangle);
            DrawText(HorizontalAlignment.Center, Color.White, 3);
            DrawBorders(Pens.Transparent, Pens.LightGray, ClientRectangle);

        }

        #endregion

        #region Insomia
        /// <summary>
        /// The insomia c1
        /// </summary>
        private Color Insomia_C1 = Color.White;
        /// <summary>
        /// The insomia c2
        /// </summary>
        private Color Insomia_C2 = Color.FromArgb(60, 60, 60);
        /// <summary>
        /// The insomia c3
        /// </summary>
        private Color Insomia_C3 = Color.FromArgb(50, 50, 50);
        /// <summary>
        /// The insomia b1
        /// </summary>
        private SolidBrush Insomia_B1 = new SolidBrush(Color.DarkSlateGray);
        /// <summary>
        /// The insomia b2
        /// </summary>
        private SolidBrush Insomia_B2 = new SolidBrush(Color.FromArgb(45, Color.White));
        /// <summary>
        /// The insomia p1
        /// </summary>
        private Pen Insomia_P1 = new Pen(Color.FromArgb(138, 138, 138));
        /// <summary>
        /// The insomia p2
        /// </summary>
        private Pen Insomia_P2 = new Pen(Color.FromArgb(158, 183, 85));

        /// <summary>
        /// Insomias the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Insomia_PaintHook(PaintEventArgs e)
        {
            G.Clear(Insomia_C1);
            DrawGradient(Color.FromArgb(30, 255, 255, 255), Color.FromArgb(95, 3, 35, 58), 10, 20, Width, Height, 90);
            DrawGradient(Insomia_C2, Insomia_C3, 0, 0, Width, Height);
            G.FillRectangle(Insomia_B2, 0, 0, Width, 4);
            G.DrawLine(Insomia_P1, 30, 30, 30, 30);
            G.DrawLine(Insomia_P1, Width - 1, 0, Width - 1, 25);
            G.DrawLine(Insomia_P2, 0, 0, 0, Height);
            G.DrawLine(Insomia_P2, Width - 1, 0, Width - 1, Height);
            G.DrawLine(Insomia_P2, 0, Height - 1, Width, Height - 1);
            HatchBrush T = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(95, 3, 35, 58), Color.FromArgb(95, 3, 35, 58));
            G.FillRectangle(T, 10, 20, Width - 20, Height - 30);
            G.DrawLine(Insomia_P2, 0, 0, Width, 0);
            DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
            HatchBrush i = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(25, 25, 25), Color.FromArgb(90, 35, 35, 35));
            G.FillRectangle(i, 10, 20, Width - 20, Height - 30);
            G.DrawRectangle(Pens.Black, 10, 20, Width - 20, Height - 30);
            HatchBrush d = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(95, 40, 142, 172), Color.FromArgb(90, 40, 142, 172));
            G.FillRectangle(Insomia_B2, 0, Convert.ToInt32(Height - 5), Width, 4);

        }

        #endregion

        #region Intel

        /// <summary>
        /// Intels the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Intel_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Fuchsia);

            //Rounded Form
            GraphicsPath gp = CreateRound(new Rectangle(0, 0, Width - 1, Height - 1), 16);
            G.FillPath(new SolidBrush(Color.FromArgb(45, 45, 45)), gp);
            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(60, 60, 60))), 0, 24, Width - 1, 24);
            G.DrawLine(Pens.DeepSkyBlue, 0, 25, Width - 1, 25);
            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(60, 60, 60))), 0, 26, Width - 1, 26);
            G.DrawPath(Pens.DeepSkyBlue, gp);

            //Title Text and Icon
            Color fontColor = Color.WhiteSmoke;
            if (ShowIcon)
            {
                if (Icon == null)
                    Icon = Parent.FindForm().Icon;
                G.DrawIcon(_Icon, new Rectangle(6, 6, 16, 16));
                G.DrawString(Text, new Font("Verdana", 11), Brushes.Black, new Point(26, 5));
                G.DrawString(Text, new Font("Verdana", 11), new SolidBrush(fontColor), new Point(25, 4));
            }
            else
            {
                G.DrawString(Text, new Font("Verdana", 11), Brushes.Black, new Point(5, 5));
                G.DrawString(Text, new Font("Verdana", 11), new SolidBrush(fontColor), new Point(4, 4));
            }

            //Square Off Bottom Corners
            G.FillRectangle(new SolidBrush(Color.FromArgb(45, 45, 45)), new Rectangle(0, Height - 35, Width - 1, 34));
            G.DrawLine(Pens.DeepSkyBlue, new Point(0, Height - 35), new Point(0, Height - 1));
            G.DrawLine(Pens.DeepSkyBlue, new Point(Width - 1, Height - 35), new Point(Width - 1, Height - 1));
            G.DrawLine(Pens.DeepSkyBlue, new Point(0, Height - 1), new Point(Width - 1, Height - 1));

            //Border Lines
            if (Enable_Border)
            {
                G.DrawLine(Pens.DeepSkyBlue, new Point(6, 25), new Point(6, Height - 7));
                G.DrawLine(Pens.DeepSkyBlue, new Point(6, Height - 7), new Point(Width - 7, Height - 7));
                G.DrawLine(Pens.DeepSkyBlue, new Point(Width - 7, Height - 7), new Point(Width - 7, 25));
            }

        }

        #endregion

        #region JTheme
        /// <summary>
        /// The color1
        /// </summary>
        Color Color1 = Color.FromArgb(20, 20, 20);
        /// <summary>
        /// The color2
        /// </summary>
        Brush Color2 = new SolidBrush(Color.FromArgb(50, 50, 50));
        /// <summary>
        /// The color3
        /// </summary>
        Color Color3 = Color.FromArgb(50, 50, 50);
        /// <summary>
        /// The color4
        /// </summary>
        Brush Color4 = new SolidBrush(Color.White);
        /// <summary>
        /// js the theme paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void JTheme_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color1);
            Rectangle rect = new Rectangle(10, 20, Width - 20, Height - 30);
            G.FillRectangle(Color2, rect);
            DrawBorders(Pens.Black, rect);
            DrawBorders(Pens.Black);
            DrawCorners(Color3);
            DrawText(Color4, HorizontalAlignment.Center, 0, 0);


        }

        #endregion

        #region Knight

        /// <summary>
        /// Knights the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Knight_PaintHook(PaintEventArgs e)
        {

            _Header = 38;
            G.Clear(Color.FromArgb(236, 73, 99));
            G.FillRectangle(new SolidBrush(Color.FromArgb(46, 49, 61)), new Rectangle(0, _Header, Width, Height - _Header));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(0, 0, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(1, 0, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(0, 1, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(Width - 1, 0, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(Width - 2, 0, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(Width - 1, 1, 1, 1));
            StringFormat _StringF = new StringFormat();
            _StringF.Alignment = StringAlignment.Center;
            _StringF.LineAlignment = StringAlignment.Center;
            G.DrawString(Text, new Font("Segoe UI", 12), Brushes.White, new RectangleF(0, 0, Width, _Header), _StringF);
        }


        #endregion

        #region Light

        /// <summary>
        /// Lights the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Light_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(176, 176, 176));
            this.ForeColor = Color.FromArgb(45, 45, 45);
            HatchBrush hb = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(20, Color.White), Color.Transparent);
            HatchBrush hb2 = new HatchBrush(HatchStyle.BackwardDiagonal, Color.FromArgb(35, Color.White), Color.Transparent);
            DrawGradient(Color.FromArgb(176, 176, 176), Color.FromArgb(215, 215, 215), 0, 0, Width, 30, 270);
            G.FillRectangle(hb, 1, 1, Width, Height);
            G.FillRectangle(new SolidBrush(Color.FromArgb(235, 235, 235)), 5, 30, Width - 10, Height - 35);
            G.FillRectangle(hb2, 5, 30, Width - 10, Height - 35);
            DrawGradient(Color.FromArgb(30, Color.White), Color.Transparent, 3, 3, Width - 6, 14, 60);
            G.DrawRectangle(new Pen(Color.FromArgb(195, 195, 195)), 5, 30, Width - 10, Height - 35);
            DrawBorders(new Pen(Color.FromArgb(109, 109, 109)), Pens.LightGray, ClientRectangle);
            DrawCorners(Color.Fuchsia, ClientRectangle);
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(5, 6, 20, 20));
            G.DrawString(Parent.FindForm().Text, this.Font, new SolidBrush(this.ForeColor), new Point(25, 10));
            
        }

        #endregion

        #region Login

        /// <summary>
        /// The close choice
        /// </summary>
        private __CloseChoice _CloseChoice = __CloseChoice.Form;
        /// <summary>
        /// Gets or sets the close choice.
        /// </summary>
        /// <value>The close choice.</value>
        public __CloseChoice CloseChoice
        {
            get { return _CloseChoice; }
            set { _CloseChoice = value; }
        }


        /// <summary>
        /// Logins the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Login_PaintHook(PaintEventArgs e)
        {
            
            var _with2 = G;
            _with2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with2.SmoothingMode = SmoothingMode.HighQuality;
            _with2.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with2.FillRectangle(new SolidBrush(Color.FromArgb(35, 35, 35)), new Rectangle(0, 0, Width, Height));
            _with2.FillRectangle(new SolidBrush(Color.FromArgb(54, 54, 54)), new Rectangle(2, 35, Width - 4, Height - 37));
            _with2.DrawRectangle(new Pen(Color.FromArgb(35, 35, 35)), new Rectangle(0, 0, Width, Height));
            Point[] ControlBoxPoints = {
                new Point(Width - 90, 0),
                new Point(Width - 90, 22),
                new Point(Width - 15, 22),
                new Point(Width - 15, 0)
            };
            _with2.DrawLines(new Pen(Color.FromArgb(35, 35, 35)), ControlBoxPoints);
            _with2.DrawLine(new Pen(Color.FromArgb(35, 35, 35)), Width - 65, 0, Width - 65, 22);
            GetMouseLocation = PointToClient(MousePosition);
            switch (State)
            {
                case MouseState.Over:
                    if (GetMouseLocation.X > Width - 39 && GetMouseLocation.X < Width - 16 && GetMouseLocation.Y < 22)
                    {
                        _with2.FillRectangle(new SolidBrush(Color.FromArgb(42, 42, 42)), new Rectangle(Width - 39, 0, 23, 22));
                    }
                    else if (GetMouseLocation.X > Width - 64 && GetMouseLocation.X < Width - 41 && GetMouseLocation.Y < 22)
                    {
                        _with2.FillRectangle(new SolidBrush(Color.FromArgb(42, 42, 42)), new Rectangle(Width - 64, 0, 23, 22));
                    }
                    else if (GetMouseLocation.X > Width - 89 && GetMouseLocation.X < Width - 66 && GetMouseLocation.Y < 22)
                    {
                        _with2.FillRectangle(new SolidBrush(Color.FromArgb(42, 42, 42)), new Rectangle(Width - 89, 0, 23, 22));
                    }
                    break;
            }

            
            //_with2.DrawLine(new Pen(Color.FromArgb(60, 60, 60)), Width - 40, 0, Width - 40, 22);

            //'Close Button
            //_with2.DrawLine(new Pen(Color.FromArgb(255, 255, 255), 2), Width - 33, 6, Width - 22, 16);
            //_with2.DrawLine(new Pen(Color.FromArgb(255, 255, 255), 2), Width - 33, 16, Width - 22, 6);

            //'Minimize Button

            //_with2.DrawLine(new Pen(Color.FromArgb(255, 255, 255)), Width - 83, 16, Width - 72, 16);

            //'Maximize Button

            //_with2.DrawLine(new Pen(Color.FromArgb(255, 255, 255)), Width - 58, 16, Width - 47, 16);
            //_with2.DrawLine(new Pen(Color.FromArgb(255, 255, 255)), Width - 58, 16, Width - 58, 6);
            //_with2.DrawLine(new Pen(Color.FromArgb(255, 255, 255)), Width - 47, 16, Width - 47, 6);
            //_with2.DrawLine(new Pen(Color.FromArgb(255, 255, 255)), Width - 58, 6, Width - 47, 6);
            //_with2.DrawLine(new Pen(Color.FromArgb(255, 255, 255)), Width - 58, 7, Width - 47, 7);

            if (_ShowIcon)
            {
                _with2.DrawIcon(Parent.FindForm().Icon, new Rectangle(6, 6, 22, 22));
                _with2.DrawString(Text, Font, new SolidBrush(Color.FromArgb(255, 255, 255)), new RectangleF(31, 0, Width - 110, 35), new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Near
                });
            }
            else
            {
                _with2.DrawString(Text, Font, new SolidBrush(Color.FromArgb(255, 255, 255)), new RectangleF(4, 0, Width - 110, 35), new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Near
                });
            }
            _with2.InterpolationMode = (InterpolationMode)7;
        }


        #endregion

        #region Loyal
        /// <summary>
        /// The text alignment
        /// </summary>
        private TextAlign _TextAlignment = TextAlign.Center;
        /// <summary>
        /// The header size
        /// </summary>
        private int _HeaderSize = 30;

        /// <summary>
        /// Loyals the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Loyal_PaintHook(PaintEventArgs e)
        {
            
            var _with1 = G;
            StringFormat _StringF = new StringFormat { LineAlignment = StringAlignment.Center };
            _with1.Clear(Color.FromArgb(31, 31, 31));
            _with1.FillRectangle(new SolidBrush(Color.Aqua), new Rectangle(0, 0, Width, 5));
            _with1.FillRectangle(new SolidBrush(Color.FromArgb(34, 34, 34)), new Rectangle(0, 5, Width, _HeaderSize));
            _with1.DrawLine(new Pen(Color.FromArgb(38, 38, 38)), new Point(0, _HeaderSize + 5), new Point(Width, _HeaderSize + 5));
            _with1.DrawLine(new Pen(Color.FromArgb(24, 24, 24)), new Point(0, _HeaderSize + 6), new Point(Width, _HeaderSize + 6));
            _with1.DrawLine(Pens.Fuchsia, new Point(0, 0), new Point(0, 2));
            _with1.DrawLine(Pens.Fuchsia, new Point(0, 0), new Point(2, 0));
            _with1.DrawLine(Pens.Fuchsia, new Point(Width - 1, 0), new Point(Width - 1, 2));
            _with1.DrawLine(Pens.Fuchsia, new Point(Width - 1, 0), new Point(Width - 3, 0));

            
            switch (_TextAlignment)
            {
                case TextAlign.Center:
                    _StringF.Alignment = StringAlignment.Center;
                    _with1.DrawString(Text, new Font("Arial", 9), Brushes.White, new RectangleF(0, 5, Width, _HeaderSize), _StringF);

                    break;
                case TextAlign.Left:
                    _with1.DrawString(Text, new Font("Arial", 9), Brushes.White, new RectangleF(10, 5, Width, _HeaderSize), _StringF);

                    break;
                case TextAlign.Right:
                    int _TextLength = TextRenderer.MeasureText(Text, new Font("Arial", 9)).Width + 10;
                    _with1.DrawString(Text, new Font("Arial", 9), Brushes.White, new RectangleF(Width - _TextLength, 5, Width, _HeaderSize), _StringF);
                    break;
            }
        }

        #endregion

        #region Meph

        /// <summary>
        /// The sub header
        /// </summary>
        private string _subHeader = "Insert Sub Header";
        /// <summary>
        /// Gets or sets the sub header.
        /// </summary>
        /// <value>The sub header.</value>
        public string SubHeader
        {
            get { return _subHeader; }
            set
            {
                _subHeader = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Mephes the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        void MephPaintHook(System.Windows.Forms.PaintEventArgs e)
        {
            
            Rectangle mainRect = new Rectangle(0, 0, Width, Height);
            
            G.Clear(Color.Fuchsia);
            //G.SetClip(Draw.RoundRect(New Rectangle(0, 0, Width, Height), 9))

            Color[] c = new Color[] {
                Color.FromArgb(10, 10, 10),
                Color.FromArgb(45, 45, 45),
                Color.FromArgb(40, 40, 40),
                Color.FromArgb(45, 45, 45),
                Color.FromArgb(46, 46, 46),
                Color.FromArgb(47, 47, 47),
                Color.FromArgb(48, 48, 48),
                Color.FromArgb(49, 49, 49),
                Color.FromArgb(50, 50, 50)
            };
            G.FillRectangle(new SolidBrush(Color.FromArgb(50, 50, 50)), mainRect);
            Utilities.Draw.InnerGlow(G, mainRect, c);

            Color[] c2 = new Color[] {
                Color.FromArgb(5, 5, 5),
                Color.FromArgb(40, 40, 40),
                Color.FromArgb(41, 41, 41),
                Color.FromArgb(42, 42, 42),
                Color.FromArgb(43, 43, 43),
                Color.FromArgb(44, 44, 44),
                Color.FromArgb(45, 45, 45)
            };
            G.FillRectangle(new SolidBrush(Color.FromArgb(45, 45, 45)), new Rectangle(0, 35, Width, 23));
            Utilities.Draw.InnerGlow(G, new Rectangle(0, 35, Width, 23), c2);

            LinearGradientBrush accentGradient = new LinearGradientBrush(new Rectangle(0, 36, 11, 21), Color.DarkRed, Color.FromArgb((Color.DarkRed.R >= 10 ? Color.DarkRed.R - 10 : Color.DarkRed.R + 10), (Color.DarkRed.G >= 10 ? Color.DarkRed.G - 10 : Color.DarkRed.G + 10), (Color.DarkRed.B >= 10 ? Color.DarkRed.B - 10 : Color.DarkRed.B + 10)), 90);
            G.FillRectangle(accentGradient, new Rectangle(0, 36, 11, 21));
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(5, 5, 5))), new Rectangle(0, 35, 11, 22));
            G.FillRectangle(accentGradient, new Rectangle(Width - 12, 36, 11, 21));
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(5, 5, 5))), new Rectangle(Width - 12, 35, 11, 22));

            LinearGradientBrush gloss = new LinearGradientBrush(new Rectangle(1, 0, Width - 1, 35 / 2), Color.FromArgb(255, Color.FromArgb(90, 90, 90)), Color.FromArgb(255, 71, 71, 71), 90);
            G.FillRectangle(gloss, new Rectangle(1, 0, Width - 2, 35 / 2));

            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(5, 5, 5))), 0, 0, Width, 0);
            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(150, 150, 150))), 1, 1, Width - 2, 1);
            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(85, 85, 85))), 1, 34, Width - 2, 34);
            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(45, 45, 45))), 1, 58, Width - 2, 58);

            Font drawFont = new Font("Verdana", 10, FontStyle.Regular);
            G.DrawString(Text, drawFont, new SolidBrush(Color.FromArgb(225, 225, 225)), new Rectangle(0, 0, Width, 35), new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            });

            Font subFont = new Font("Verdana", 8, FontStyle.Regular);
            G.DrawString(_subHeader, subFont, new SolidBrush(Color.FromArgb(225, 225, 225)), new Rectangle(0, 35, Width, 23), new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            });

            Font controlFont = new Font("Marlett", 10, FontStyle.Regular);
            switch (State)
            {
                case MouseState.None:
                    G.DrawString("r", controlFont, new SolidBrush(Color.FromArgb(178, 178, 178)), new Rectangle(-4, -6, Width, 35), new StringFormat
                    {
                        Alignment = StringAlignment.Far,
                        LineAlignment = StringAlignment.Center
                    });
                    G.DrawString("1", controlFont, new SolidBrush(Color.FromArgb(178, 178, 178)), new Rectangle(-21, -5, Width, 35), new StringFormat
                    {
                        Alignment = StringAlignment.Far,
                        LineAlignment = StringAlignment.Center
                    });
                    G.DrawString("0", controlFont, new SolidBrush(Color.FromArgb(178, 178, 178)), new Rectangle(-38, -6, Width, 35), new StringFormat
                    {
                        Alignment = StringAlignment.Far,
                        LineAlignment = StringAlignment.Center
                    });
                    break;
                case MouseState.Over:
                    if (X > Width - 18 & X < Width - 10 & Y < 18 & Y > 8)
                    {
                        G.DrawString("r", controlFont, new SolidBrush(Color.FromArgb(255, 255, 255)), new Rectangle(-4, -6, Width, 35), new StringFormat
                        {
                            Alignment = StringAlignment.Far,
                            LineAlignment = StringAlignment.Center
                        });
                        G.DrawString("1", controlFont, new SolidBrush(Color.FromArgb(178, 178, 178)), new Rectangle(-21, -5, Width, 35), new StringFormat
                        {
                            Alignment = StringAlignment.Far,
                            LineAlignment = StringAlignment.Center
                        });
                        G.DrawString("0", controlFont, new SolidBrush(Color.FromArgb(178, 178, 178)), new Rectangle(-38, -6, Width, 35), new StringFormat
                        {
                            Alignment = StringAlignment.Far,
                            LineAlignment = StringAlignment.Center
                        });
                    }
                    else if (X > Width - 36 & X < Width - 25 & Y < 18 & Y > 8)
                    {
                        G.DrawString("r", controlFont, new SolidBrush(Color.FromArgb(178, 178, 178)), new Rectangle(-4, -6, Width, 35), new StringFormat
                        {
                            Alignment = StringAlignment.Far,
                            LineAlignment = StringAlignment.Center
                        });
                        G.DrawString("1", controlFont, new SolidBrush(Color.FromArgb(255, 255, 255)), new Rectangle(-21, -5, Width, 35), new StringFormat
                        {
                            Alignment = StringAlignment.Far,
                            LineAlignment = StringAlignment.Center
                        });
                        G.DrawString("0", controlFont, new SolidBrush(Color.FromArgb(178, 178, 178)), new Rectangle(-38, -6, Width, 35), new StringFormat
                        {
                            Alignment = StringAlignment.Far,
                            LineAlignment = StringAlignment.Center
                        });
                    }
                    else if (X > Width - 52 & X < Width - 44 & Y < 18 & Y > 8)
                    {
                        G.DrawString("r", controlFont, new SolidBrush(Color.FromArgb(178, 178, 178)), new Rectangle(-4, -6, Width, 35), new StringFormat
                        {
                            Alignment = StringAlignment.Far,
                            LineAlignment = StringAlignment.Center
                        });
                        G.DrawString("1", controlFont, new SolidBrush(Color.FromArgb(178, 178, 178)), new Rectangle(-21, -5, Width, 35), new StringFormat
                        {
                            Alignment = StringAlignment.Far,
                            LineAlignment = StringAlignment.Center
                        });
                        G.DrawString("0", controlFont, new SolidBrush(Color.FromArgb(255, 255, 255)), new Rectangle(-38, -6, Width, 35), new StringFormat
                        {
                            Alignment = StringAlignment.Far,
                            LineAlignment = StringAlignment.Center
                        });
                    }
                    else
                    {
                        G.DrawString("r", controlFont, new SolidBrush(Color.FromArgb(178, 178, 178)), new Rectangle(-4, -6, Width, 35), new StringFormat
                        {
                            Alignment = StringAlignment.Far,
                            LineAlignment = StringAlignment.Center
                        });
                        G.DrawString("1", controlFont, new SolidBrush(Color.FromArgb(178, 178, 178)), new Rectangle(-21, -5, Width, 35), new StringFormat
                        {
                            Alignment = StringAlignment.Far,
                            LineAlignment = StringAlignment.Center
                        });
                        G.DrawString("0", controlFont, new SolidBrush(Color.FromArgb(178, 178, 178)), new Rectangle(-38, -6, Width, 35), new StringFormat
                        {
                            Alignment = StringAlignment.Far,
                            LineAlignment = StringAlignment.Center
                        });
                    }
                    break;
                case MouseState.Down:
                    G.DrawString("r", controlFont, new SolidBrush(Color.FromArgb(178, 178, 178)), new Rectangle(-4, -6, Width, 35), new StringFormat
                    {
                        Alignment = StringAlignment.Far,
                        LineAlignment = StringAlignment.Center
                    });
                    G.DrawString("1", controlFont, new SolidBrush(Color.FromArgb(178, 178, 178)), new Rectangle(-21, -5, Width, 35), new StringFormat
                    {
                        Alignment = StringAlignment.Far,
                        LineAlignment = StringAlignment.Center
                    });
                    G.DrawString("0", controlFont, new SolidBrush(Color.FromArgb(178, 178, 178)), new Rectangle(-38, -6, Width, 35), new StringFormat
                    {
                        Alignment = StringAlignment.Far,
                        LineAlignment = StringAlignment.Center
                    });
                    break;
            }

        }


        #endregion

        #region Metal
        /// <summary>
        /// The metal p1
        /// </summary>
        private Pen Metal_P1;

        /// <summary>
        /// The metal p2
        /// </summary>
        private Pen Metal_P2;

        /// <summary>
        /// Metals the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Metal_PaintHook(PaintEventArgs e)
        {
            MoveHeight = 25;
            Metal_P1 = new Pen(Color.FromArgb(45, 45, 45));
            Metal_P2 = new Pen(Color.FromArgb(90, 90, 90));
            Color Textcolor = Color.White;

            G.Clear(Color.FromArgb(41, 41, 41));
            G.FillRectangle(new SolidBrush(Color.FromArgb(63, 63, 63)), 14, MoveHeight, Width - 30, Height - MoveHeight - 12);
            DrawGradient(Color.FromArgb(100, 100, 100), Color.FromArgb(41, 41, 41), 0, -12, Width, MoveHeight, 90);

            if (_TitleAlign == HorizontalAlignment.Center)
            {
                DrawText(HorizontalAlignment.Center, Textcolor, 5);
            }
            else if (_TitleAlign == HorizontalAlignment.Left)
            {
                DrawText(HorizontalAlignment.Left, Textcolor, 5);
            }
            else if (_TitleAlign == HorizontalAlignment.Right)
            {
                DrawText(HorizontalAlignment.Right, Textcolor, 5);
            }

            DrawBorders(Metal_P2, Metal_P1, ClientRectangle);
            DrawCorners(Color.Fuchsia, ClientRectangle);
        }


        #endregion

        #region MetroUI

        /// <summary>
        /// Metroes the UI paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void MetroUI_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(53, 157, 181));

            G.FillRectangle(new SolidBrush(Color.White), new Rectangle(1, 1, Width - 2, Height - 24));
            G.FillRectangle(new SolidBrush(Color.FromArgb(53, 157, 181)), new Rectangle(0, 50, 7, 50));


            // G.DrawEllipse(circlec, New Rectangle(Width - 7, Height - 7, 3, 3))
            G.FillEllipse(new SolidBrush(Color.White), new Rectangle(Width - 7, Height - 7, 3, 3));

            //G.DrawEllipse(circlec, New Rectangle(Width - 13, Height - 7, 3, 3))
            G.FillEllipse(new SolidBrush(Color.White), new Rectangle(Width - 13, Height - 7, 3, 3));

            //  G.DrawEllipse(circlec, New Rectangle(Width - 19, Height - 7, 3, 3))
            G.FillEllipse(new SolidBrush(Color.White), new Rectangle(Width - 19, Height - 7, 3, 3));

            //  G.DrawEllipse(circlec, New Rectangle(Width - 7, Height - 13, 3, 3))
            G.FillEllipse(new SolidBrush(Color.White), new Rectangle(Width - 7, Height - 13, 3, 3));

            // G.DrawEllipse(circlec, New Rectangle(Width - 7, Height - 19, 3, 3))
            G.FillEllipse(new SolidBrush(Color.White), new Rectangle(Width - 7, Height - 19, 3, 3));

            //  G.DrawEllipse(circlec, New Rectangle(Width - 13, Height - 13, 3, 3))
            G.FillEllipse(new SolidBrush(Color.White), new Rectangle(Width - 13, Height - 13, 3, 3));


            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(10, 5, 23, 23));
            DrawText(new SolidBrush(Color.Black), HorizontalAlignment.Left, 44, 2);
            G.DrawString("|", Font, new SolidBrush(Color.Black), new Point(37, -3));

        }

        #endregion

        #region MetroDisk
        /// <summary>
        /// The metro disk theme
        /// </summary>
        private bool MetroDisk__Theme;
        /// <summary>
        /// The metro disk w
        /// </summary>
        private int MetroDisk_W;
        /// <summary>
        /// The metro disk h
        /// </summary>
        private int MetroDisk_H;
        /// <summary>
        /// The metro disk b
        /// </summary>
        private Bitmap MetroDisk_B;
        /// <summary>
        /// The metro disk m dcolor
        /// </summary>
        private Color MetroDisk__MDcolor = Color.FromArgb(45, 150, 45);
        /// <summary>
        /// The metro disk text
        /// </summary>
        private string MetroDisk__text = "";

        #region " Dark Colors"

        /// <summary>
        /// The metro disk header color
        /// </summary>
        private Color MetroDisk__HeaderColor = Color.FromArgb(60, 200, 80);
        /// <summary>
        /// The metro disk base color
        /// </summary>
        private Color MetroDisk__BaseColor = Color.FromArgb(60, 70, 73);
        /// <summary>
        /// The metro disk border color
        /// </summary>
        private Color MetroDisk__BorderColor = Color.FromArgb(53, 58, 60);

        /// <summary>
        /// The metro disk text color
        /// </summary>
        private Color MetroDisk_TextColor = Color.FromArgb(234, 234, 234);
        #endregion

        #region " Light Colors"

        /// <summary>
        /// The metro disk header light
        /// </summary>
        private Color MetroDisk__HeaderLight = Color.FromArgb(171, 171, 172);
        /// <summary>
        /// The metro disk base light
        /// </summary>
        private Color MetroDisk__BaseLight = Color.FromArgb(196, 199, 200);

        /// <summary>
        /// The metro disk text light
        /// </summary>
        public Color MetroDisk_TextLight = Color.FromArgb(45, 47, 49);


        #endregion

        /// <summary>
        /// Gets or sets a value indicating whether [metrodisk theme].
        /// </summary>
        /// <value><c>true</c> if [metrodisk theme]; otherwise, <c>false</c>.</value>
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

        /// <summary>
        /// Metroes the disk paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
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

        #region Modern

        /// <summary>
        /// The modern c1
        /// </summary>
        Color Modern_C1 = Color.FromArgb(240, 240, 240);
        /// <summary>
        /// The modern c2
        /// </summary>
        Color Modern_C2 = Color.FromArgb(230, 230, 230);
        /// <summary>
        /// The modern c3
        /// </summary>
        Color Modern_C3 = Color.FromArgb(190, 190, 190);
        /// <summary>
        /// The title height
        /// </summary>
        private int _TitleHeight = 25;

        /// <summary>
        /// Moderns the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        void Modern_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {
            using (Bitmap B = new Bitmap(Width, Height))
            {
                using (Graphics G = Graphics.FromImage(B))
                {
                    G.Clear(Color.FromArgb(245, 245, 245));

                    Utilities.Draw.Blend(G, Color.White, Modern_C2, Modern_C1, 0.7f, 1, 0, 0, Width, _TitleHeight);

                    G.FillRectangle(new SolidBrush(Color.FromArgb(80, 255, 255, 255)), 0, 0, Width, Convert.ToInt32(_TitleHeight / 2));
                    G.DrawRectangle(new Pen(Color.FromArgb(100, 255, 255, 255)), 1, 1, Width - 3, _TitleHeight - 2);

                    SizeF S = G.MeasureString(Text, Font);
                    float O = 6;
                    if (_TitleAlign == (HorizontalAlignment)2)
                        O = Width / 2 - S.Width / 2;
                    if (_TitleAlign == (HorizontalAlignment)1)
                        O = Width - S.Width - 6;
                    G.DrawString(Text, Font, new SolidBrush(Modern_C3), O, Convert.ToInt32(_TitleHeight / 2 - S.Height / 2));

                    G.DrawLine(new Pen(Modern_C3), 0, _TitleHeight, Width, _TitleHeight);
                    G.DrawLine(Pens.White, 0, _TitleHeight + 1, Width, _TitleHeight + 1);
                    G.DrawRectangle(new Pen(Modern_C3), 0, 0, Width - 1, Height - 1);

                    e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
                }
            }
        }



        #endregion

        #region MPGH

        /// <summary>
        /// MPGHs the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void MPGH_PaintHook(PaintEventArgs e)
        {
            DrawGradient(Color.FromArgb(0, 0, 128), Color.FromArgb(35, 107, 142), 0, 0, Width, 55, 180);
            // Top Top
            DrawGradient(Color.FromArgb(35, 107, 142), Color.FromArgb(0, 0, 128), 0, 0, Width, 55, 90);
            // Top Top
            DrawGradient(Color.FromArgb(34, 34, 34), Color.FromArgb(34, 34, 34), 0, 56, Width, Height - 55, 90);
            // Middel Bottom
            DrawGradient(Color.FromArgb(34, 34, 34), Color.FromArgb(34, 34, 34), 0, 84, Width, 35, 90);
            // Midel Top
            G.DrawLine(Pens.Black, 0, 28, Width, 28);
            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(1, 0, 0, 0))), 0, 29, Width, 29);
            DrawCorners(TransparencyKey);

            DrawText(Brushes.White, HorizontalAlignment.Left, 6, 5);

            Pen p4 = new Pen(Color.FromArgb(34, 34, 34));
            Int32 ClientPtA = default(Int32);
            Int32 ClientPtB = default(Int32);

            ClientPtA = 55;
            ClientPtB = 30;
            for (int I = 0; I <= Width + 17; I += 4)
            {
                G.DrawLine(p4, I, 30, I - 17, ClientPtA);
                G.DrawLine(p4, I - 1, 30, I - 18, ClientPtA);
            }
        }

        #endregion

        #region Mumtz

        /// <summary>
        /// Mumtzs the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Mumtz_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.MediumTurquoise);
            G.FillRectangle(new SolidBrush(Color.White), new Rectangle(6, 36, Width - 13, Height - 43));
            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(ForeColor), new Point(30, 9));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(6, 10, 16, 16));
            DrawCorners(Color.Fuchsia);
        }

        #endregion

        #region Mystic

        /// <summary>
        /// The mystic header
        /// </summary>
        private int Mystic_Header = 36;

        /// <summary>
        /// Mystics the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Mystic_PaintHook(PaintEventArgs e)
        {
            
            G.Clear(Color.FromArgb(44, 51, 62));
            G.FillRectangle(new LinearGradientBrush(new Point(0, 0), new Point(0, Mystic_Header), Color.FromArgb(29, 36, 44), Color.FromArgb(22, 29, 35)), new Rectangle(0, 0, Width, _Header));

            G.FillRectangle(Brushes.Fuchsia, new Rectangle(0, 0, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(1, 0, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(0, 1, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(Width - 1, 0, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(Width - 1, 1, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(Width - 2, 0, 1, 1));

            StringFormat _StringF = new StringFormat();
            _StringF.Alignment = StringAlignment.Center;
            _StringF.LineAlignment = StringAlignment.Center;
            G.DrawString(Text, new Font("Segoe UI", 11), new SolidBrush(Color.FromArgb(0, 206, 153)), new RectangleF(0, 0, Width, _Header), _StringF);

        }


        #endregion

        #region NeoBux

        /// <summary>
        /// Neoes the bux paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void NeoBux_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Gray);

            //MenuTop
            G.FillRectangle(new SolidBrush(Color.FromArgb(239, 239, 242)), new Rectangle(1, 1, Width - 2, Height - 2));

            //Border
            G.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle(1, 35, Width - 2, Height - 38));

            //MainForm
            G.FillRectangle(new SolidBrush(Color.WhiteSmoke), new Rectangle(1, 36, Width - 2, Height - 39));


            //ColorLine
            LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(1, 36, Width - 2, Height - 255), Color.FromArgb(0, 177, 253), Color.FromArgb(46, 202, 56), 180f);
            G.DrawRectangle(new Pen(Color.LightGray), 1, 35, Width - 3, 4);
            G.FillRectangle(LGB, new Rectangle(1, 35, Width - 2, 4));

            //MenuItems
            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(ForeColor), new Point(35, 10));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(10, 10, 16, 16));
            DrawCorners(Color.Fuchsia);

        }

        #endregion

        #region Nameless

        /// <summary>
        /// The nameless p1
        /// </summary>
        private Pen Nameless_P1;
        /// <summary>
        /// The nameless h
        /// </summary>
        int Nameless_H = 25;
        /// <summary>
        /// Namelesses the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Nameless_PaintHook(PaintEventArgs e)
        {
            Nameless_P1 = new Pen(Color.FromArgb(100, 100, 100));
            G.Clear(Color.FromArgb(0, 0, 0));

            //Sides Gradient
            DrawGradient(Color.Black, Color.FromArgb(45, 45, 45), new Rectangle(1, Nameless_H, Width, 100));
            //Inner Rect Grad
            DrawGradient(Color.FromArgb(35, 35, 35), Color.FromArgb(5, 5, 5), 9, 32, Width - 19, Height - 39);

            //Header Grad
            LinearGradientBrush HeaderLGB = new LinearGradientBrush(new Rectangle(2, 2, Width - 5, 11), Color.FromArgb(150, 150, 150), Color.FromArgb(50, 50, 50), 90);
            G.FillRectangle(HeaderLGB, new Rectangle(2, 2, Width - 5, 12));
            DrawBorders(new Pen(Color.FromArgb(65, 65, 65)), new Rectangle(3, 3, Width - 6, 26));
            //----------

            //buttom Gradient.
            DrawGradient(Color.FromArgb(8, 8, 8), Color.FromArgb(34, 34, 34), 9, 31, Width - 20, 20);
            DrawGradient(Color.Black, Color.FromArgb(75, 75, 75), 0, Height - 9, Width / 2, Height, 360);
            DrawGradient(Color.Black, Color.FromArgb(75, 75, 75), Width / 2, Height - 9, Width / 2, Height, 180);
            G.DrawLine(new Pen(Color.FromArgb(75, 75, 75)), Width / 2, Height - 9, Width / 2, Height);
            //----------

            //Inner Rect
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(55, 55, 55))), new Rectangle(9, 30, Width - 19, Height - 41));
            G.DrawLine(new Pen(Color.FromArgb(50, 50, 50)), 9, 30, Width - 10, 30);


            DrawBorders(Nameless_P1, 1);
            DrawBorders(new Pen(new SolidBrush(Color.FromArgb(0, 0, 0))), ClientRectangle);


            DrawCorners(Color.Fuchsia, ClientRectangle);
            G.DrawString(Text, Font, Brushes.White, new Point(9, 7));

        }

        #endregion

        #region Net Seal
        /// <summary>
        /// The net seal r1
        /// </summary>
        private Rectangle NetSeal_R1;
        /// <summary>
        /// The net seal p1
        /// </summary>
        private Pen NetSeal_P1 = new Pen(Color.FromArgb(24, 24, 24));
        /// <summary>
        /// The net seal p2
        /// </summary>
        private Pen NetSeal_P2 = new Pen(Color.FromArgb(60, 60, 60));

        /// <summary>
        /// The net seal b1
        /// </summary>
        private SolidBrush NetSeal_B1 = new SolidBrush(Color.FromArgb(50, 50, 50));

        /// <summary>
        /// The net seal pad
        /// </summary>
        private int NetSeal_Pad;
        /// <summary>
        /// The accent offset
        /// </summary>
        private int _AccentOffset = 42;

        /// <summary>
        /// Nets the seal paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void NetSeal_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(50, 50, 50));
            DrawBorders(NetSeal_P2, 1);

            G.DrawLine(NetSeal_P1, 0, 26, Width, 26);
            G.DrawLine(NetSeal_P2, 0, 25, Width, 25);

            NetSeal_Pad = Math.Max(Measure().Width + 20, 80);
            NetSeal_R1 = new Rectangle(NetSeal_Pad, 17, Width - (NetSeal_Pad * 2) + _AccentOffset, 8);

            G.DrawRectangle(NetSeal_P2, NetSeal_R1);
            G.DrawRectangle(NetSeal_P1, NetSeal_R1.X + 1, NetSeal_R1.Y + 1, NetSeal_R1.Width - 2, NetSeal_R1.Height);

            G.DrawLine(NetSeal_P1, 0, 29, Width, 29);
            G.DrawLine(NetSeal_P2, 0, 30, Width, 30);




            DrawText(Brushes.Black, HorizontalAlignment.Left, 8, 1);
            DrawText(Brushes.WhiteSmoke, HorizontalAlignment.Left, 7, 0);

            G.FillRectangle(NetSeal_B1, 0, 27, Width, 2);
            DrawBorders(Pens.Black);
        }


        #endregion

        #region New Theme

        /// <summary>
        /// News the theme paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void NewTheme_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(12, 27, 74));
            //DrawGradient(Color.FromArgb(25, Color.White), Color.FromArgb(5, Color.White), 0, 0, Width, 20, 90S)
            HatchBrush HB = new HatchBrush(HatchStyle.BackwardDiagonal, Color.FromArgb(25, Color.White), Color.Transparent);
            G.FillRectangle(new SolidBrush(Color.FromArgb(13, 13, 13)), new Rectangle(6, 26, Width - 13, Height - 33));
            G.FillRectangle(HB, new Rectangle(6, 26, Width - 13, Height - 33));
            G.DrawLine(Pens.Black, 6, 26, Width - 8, 26);
            G.DrawLine(Pens.Black, Width - 8, Height - 8, Width - 8, 26);
            G.DrawLine(Pens.Black, 6, Height - 8, 6, 26);
            G.DrawLine(Pens.Black, 6, Height - 8, Width - 8, Height - 8);
            G.DrawString(Text, Font, Brushes.White, new Point(25, 5));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(5, 5, 16, 16));
            //G.FillRectangle(New SolidBrush(Border), New Rectangle(6, 66, Width - 13, Height - 400))
            //////Rounding
            //////left upper corner
            DrawPixel(Color.Fuchsia, 0, 0);
            DrawPixel(Color.Fuchsia, 1, 0);
            DrawPixel(Color.Fuchsia, 2, 0);
            DrawPixel(Color.Fuchsia, 3, 0);
            DrawPixel(Color.Fuchsia, 0, 1);
            DrawPixel(Color.Fuchsia, 0, 2);
            DrawPixel(Color.Fuchsia, 0, 3);
            DrawPixel(Color.Fuchsia, 1, 1);
            //////right upper corner
            DrawPixel(Color.Fuchsia, Width - 1, 0);
            DrawPixel(Color.Fuchsia, Width - 2, 0);
            DrawPixel(Color.Fuchsia, Width - 3, 0);
            DrawPixel(Color.Fuchsia, Width - 4, 0);
            DrawPixel(Color.Fuchsia, Width - 1, 1);
            DrawPixel(Color.Fuchsia, Width - 1, 2);
            DrawPixel(Color.Fuchsia, Width - 1, 3);
            DrawPixel(Color.Fuchsia, Width - 2, 1);
        }

        #endregion

        #region NYX

        /// <summary>
        /// The n yx grad color
        /// </summary>
        private Color[] nYX_GradColor = new Color[]
        {
            Color.FromArgb(35,35,35),
            Color.FromArgb(210, 0, 0),
            Color.FromArgb(35,35,35),
        };
        /// <summary>
        /// Gets or sets the color of the nyx grad.
        /// </summary>
        /// <value>The color of the nyx grad.</value>
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

        /// <summary>
        /// The nyx h
        /// </summary>
        int NYX_H;
        /// <summary>
        /// The nyx f
        /// </summary>
        bool NYX_f;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Thematic150"/> is animated.
        /// </summary>
        /// <value><c>true</c> if animated; otherwise, <c>false</c>.</value>
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

        /// <summary>
        /// Nyxes the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
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

            if(ShowIcon)
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(5, 5, 20, 20));

        }

        /// <summary>
        /// Called when [animation].
        /// </summary>
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

        #region Orains
        /// <summary>
        /// The orains border
        /// </summary>
        Color Orains_Border = Color.Black;
        /// <summary>
        /// The orains text color
        /// </summary>
        Color Orains_TextColor = Color.Orange;
        /// <summary>
        /// The orains r1
        /// </summary>
        Color Orains_R1 = Color.FromArgb(14, 14, 14);
        /// <summary>
        /// The orains r2
        /// </summary>
        Color Orains_R2 = Color.FromArgb(20, 20, 20);
        /// <summary>
        /// The orains inner border
        /// </summary>
        Color Orains_InnerBorder = Color.FromArgb(40, 40, 40);
        /// <summary>
        /// The orains outerborder
        /// </summary>
        Pen Orains_outerborder = Pens.Black;
        /// <summary>
        /// The orains bg color
        /// </summary>
        Brush Orains_BGColor = new SolidBrush(Color.FromArgb(20, 20, 20));

        /// <summary>
        /// The header c
        /// </summary>
        Brush HeaderC = new SolidBrush(Color.FromArgb(22, 22, 22));

        /// <summary>
        /// Orainses the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Orains_PaintHook(PaintEventArgs e)
        {
            G.Clear(Orains_R1);



            LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Orains_R1, Orains_R2, -90);
            G.FillRectangle(LGB, new Rectangle(0, 0, Width - 1, Height - 1));


            HatchBrush BodyHatch = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(75, Color.Black), Color.Transparent);
            G.FillRectangle(BodyHatch, new Rectangle(0, 0, Width - 1, Height - 1));

            // w x 2 + 1 =  , w + h = 
            G.FillRectangle(Orains_BGColor, new Rectangle(8, 28, Width - 17, Height - 36));
            G.DrawRectangle(new Pen(Orains_InnerBorder), 9, 29, Width - 19, Height - 38);
            G.DrawRectangle(Orains_outerborder, new Rectangle(8, 28, Width - 17, Height - 36));

            G.DrawRectangle(Orains_outerborder, new Rectangle(0, 0, Width - 1, Height - 1));
            // OuterBorder of BackColor

            //  G.FillRectangle(HeaderC, New Rectangle(0, 0, Width - 1, 15))
            //  Dim BodyHatch2 As New HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(30, Color.Black), Color.Transparent)
            // G.FillRectangle(BodyHatch2, New Rectangle(0, 0, Width - 1, 15))

            G.DrawRectangle(new Pen(Orains_InnerBorder), new Rectangle(1, 1, Width - 3, Height - 3));
            //InnerBorder of BackCOlor' 


            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(ForeColor), new Point(35, 7));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(10, 4, 22, 22));

            // DrawCorners(Color.Fuchsia)
        }

        #endregion

        #region Origin

        /// <summary>
        /// Origins the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Origin_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(39, 38, 38));
            // Dim HB As New HatchBrush(HatchStyle.Percent80, Color.FromArgb(45, Color.FromArgb(39, 38, 38)), Color.Transparent)
            G.FillRectangle(new SolidBrush(BackColor), new Rectangle(3, 26, Width - 6, Height - 29));
            //.FillRectangle(HB, New Rectangle(6, 26, Width - 12, Height - 33))
            G.DrawString(Parent.FindForm().Text, Font, Brushes.White, new Point(27, 3));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(10, 3, 16, 16));
            DrawCorners(Color.Transparent);
        }

        #endregion

        #region PalaDinV2

        /// <summary>
        /// The pala din v2 p1
        /// </summary>
        private Pen PalaDinV2_P1;

        /// <summary>
        /// Palas the din v2 paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void PalaDinV2_PaintHook(PaintEventArgs e)
        {
            PalaDinV2_P1 = new Pen(Color.FromArgb(230, 230, 230));
            G.Clear(Color.FromArgb(200, Color.Gainsboro));
            LinearGradientBrush HeaderLGB = new LinearGradientBrush(new Rectangle(0, 0, Width, 17), Color.FromArgb(230, 230, 230), Color.FromArgb(210, 210, 210), 90);
            G.FillRectangle(HeaderLGB, new Rectangle(0, 0, Width, 17));


            DrawGradient(Color.FromArgb(170, 170, 170), Color.FromArgb(230, 230, 230), 0, Height - 12, Width / 2, Height, 360);
            DrawGradient(Color.FromArgb(170, 170, 170), Color.FromArgb(230, 230, 230), Width / 2, Height - 12, Width / 2, Height, 180);

            G.DrawLine(new Pen(Color.FromArgb(230, 230, 230)), Width / 2, Height - 11, Width / 2, Height);


            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(140, 140, 140))), new Rectangle(8, 32, Width - 18, Height - 42));

            LinearGradientBrush RecLGB = new LinearGradientBrush(new Point(0, 0), new Point(0, Height), Color.FromArgb(180, 180, 180), Color.FromArgb(200, 200, 200));
            G.FillRectangle(RecLGB, new Rectangle(9, 33, Width - 19, Height - 43));

            G.DrawLine(new Pen(Color.White), 1, 2, Width, 2);
            G.DrawLine(new Pen(Color.FromArgb(150, 150, 150)), 8, 30, Width - 10, 30);

            DrawBorders(PalaDinV2_P1, 1);
            DrawBorders(new Pen(new SolidBrush(Color.FromArgb(90, 90, 90))), ClientRectangle);

            DrawCorners(Color.Fuchsia, ClientRectangle);
            
            DrawImage(HorizontalAlignment.Left, 6, -9);
            DrawText(new SolidBrush(Color.White), HorizontalAlignment.Left, 29, 0);
            DrawText(new SolidBrush(Color.Black), HorizontalAlignment.Left, 30, 0);
            

        }


        #endregion

        #region Patrick

        /// <summary>
        /// Patricks the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Patrick_PaintHook(PaintEventArgs e)
        {
            HatchBrush hb2 = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(15, 15, 15));
            G.Clear(BackColor);
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(71, 71, 71))), new Rectangle(0, 0, Width, 20));
            G.FillRectangle(hb2, new Rectangle(0, 0, Width, 20));
            for (int i = 1; i <= 30; i++)
            {
                G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(Convert.ToInt32(255 / (i * 8)), Color.Black))), 0, 20 + i, Width, 20 + i);
            }
            HatchBrush hbi = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(15, 15, 15));
            G.FillRectangle(hbi, new Rectangle(0, 20, Width, 20));
            G.DrawString(Text, Font, Brushes.DarkGray, new Point(5, 5));
            Font SubFont = new Font(DefaultFont.FontFamily, Font.Size - 1);
            G.DrawString(Subtext, SubFont, new SolidBrush(Color.FromArgb(130, 130, 130)), new Point(8, 21));
            G.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));
            DrawCorners(Color.Magenta);
        }

        #endregion

        #region Perplex

        /// <summary>
        /// Perplexes the paint.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        void Perplex_Paint(System.Windows.Forms.PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            Rectangle TopLeft = new Rectangle(0, 0, Width - 125, 28);
            Rectangle TopRight = new Rectangle(Width - 82, 0, 81, 28);
            Rectangle Body = new Rectangle(10, 10, Width - 21, Height - 16);
            Rectangle Body2 = new Rectangle(5, 5, Width - 11, Height - 6);

            G.Clear(Color.Fuchsia);

            LinearGradientBrush BodyBrush = new LinearGradientBrush(Body2, Color.FromArgb(26, 26, 26), Color.FromArgb(30, 35, 48), 90);
            G.FillPath(BodyBrush, Utilities.Draw.RoundRect(Body2, 3));
            G.DrawPath(new Pen(Brushes.Black), Utilities.Draw.RoundRect(Body2, 3));

            LinearGradientBrush BodyBrush2 = new LinearGradientBrush(Body, Color.FromArgb(46, 46, 46), Color.FromArgb(50, 55, 58), 120);
            G.FillPath(BodyBrush2, Utilities.Draw.RoundRect(Body, 3));
            G.DrawPath(new Pen(Brushes.Black), Utilities.Draw.RoundRect(Body, 3));

            LinearGradientBrush gloss = new LinearGradientBrush(new Rectangle(0, 0, Width - 125, 28 / 2), Color.FromArgb(240, Color.FromArgb(26, 26, 26)), Color.FromArgb(5, 255, 255, 255), 90);
            LinearGradientBrush mainbrush = new LinearGradientBrush(TopLeft, Color.FromArgb(26, 26, 26), Color.FromArgb(30, 30, 30), 90);
            G.FillPath(mainbrush, Utilities.Draw.RoundRect(TopLeft, 3));
            G.FillPath(gloss, Utilities.Draw.RoundRect(TopLeft, 3));
            G.DrawPath(new Pen(Brushes.Black), Utilities.Draw.RoundRect(TopLeft, 3));

            LinearGradientBrush gloss2 = new LinearGradientBrush(new Rectangle(Width - 82, 0, Width - 205, 28 / 2), Color.FromArgb(240, Color.FromArgb(26, 26, 26)), Color.FromArgb(5, 255, 255, 255), 90);
            LinearGradientBrush mainbrush2 = new LinearGradientBrush(TopRight, Color.FromArgb(26, 26, 26), Color.FromArgb(30, 30, 30), 90);
            G.FillPath(mainbrush, Utilities.Draw.RoundRect(TopRight, 3));
            G.FillPath(gloss2, Utilities.Draw.RoundRect(TopRight, 3));
            G.DrawPath(new Pen(Brushes.Black), Utilities.Draw.RoundRect(TopRight, 3));

            Pen p1 = new Pen(Color.FromArgb(174, 195, 30), 2);
            G.DrawLine(p1, 14, 9, 14, 22);
            Pen p2 = new Pen(Color.FromArgb(174, 195, 30), 2);
            G.DrawLine(p2, 17, 6, 17, 25);
            Pen p3 = new Pen(Color.FromArgb(174, 195, 30), 2);
            G.DrawLine(p3, 20, 9, 20, 22);

            Pen p4 = new Pen(Color.FromArgb(174, 195, 30), 2);
            G.DrawLine(p4, 11, 12, 11, 19);
            Pen p5 = new Pen(Color.FromArgb(174, 195, 30), 2);
            G.DrawLine(p4, 23, 12, 23, 19);

            Pen p6 = new Pen(Color.FromArgb(174, 195, 30), 2);
            G.DrawLine(p6, 8, 14, 8, 17);
            Pen p7 = new Pen(Color.FromArgb(174, 195, 30), 2);
            G.DrawLine(p7, 26, 14, 26, 17);


            Font drawFont = new Font("Tahoma", 10, FontStyle.Bold);
            G.DrawString(Text, drawFont, new SolidBrush(Color.WhiteSmoke), new Rectangle(32, 1, Width - 1, 27), new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            });

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            G.Dispose();
            B.Dispose();
        }


        #endregion

        #region Positron


        /// <summary>
        /// The positron bg
        /// </summary>
        private Color Positron_BG = Color.FromArgb(208, 208, 208);
        /// <summary>
        /// The positron gt
        /// </summary>
        private Color Positron_GT = Color.FromArgb(100, 100, 100);
        /// <summary>
        /// The positron gb
        /// </summary>
        private Color Positron_GB = Color.FromArgb(200, 200, 200);
        /// <summary>
        /// The positron tb
        /// </summary>
        private Brush Positron_TB = new SolidBrush(Color.FromArgb(100, 100, 100));
        /// <summary>
        /// The positron black
        /// </summary>
        private Brush Positron_Black = Brushes.Black;
        /// <summary>
        /// The positron h
        /// </summary>
        private Brush Positron_H = new SolidBrush(Color.FromArgb(210, 210, 210));
        /// <summary>
        /// The positron b
        /// </summary>
        private Pen Positron_b = new Pen(Color.FromArgb(200, 200, 200));
        /// <summary>
        /// The positron ib
        /// </summary>
        private Pen Positron_IB = new Pen(Color.FromArgb(200, 200, 200));

        /// <summary>
        /// The positron pb
        /// </summary>
        private Pen Positron_PB = new Pen(Color.FromArgb(150, 150, 150));

        /// <summary>
        /// Positrons the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Positron_PaintHook(PaintEventArgs e)
        {
            HatchBrush HBM = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(30, Color.White), Color.Transparent);
            G.Clear(Positron_BG);
            G.FillRectangle(HBM, new Rectangle(0, 0, Width - 1, Height - 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(225, 225, 225)), new Rectangle(8, 27, Width - 16, Height - 35));
            G.DrawString(Text, Font, Positron_TB, new Point(29, 7));
            G.DrawIcon(ParentForm.Icon, new Rectangle(7, 4, 19, 20));
            DrawBorders(Positron_PB);
            DrawBorders(Positron_IB, 1);

        }

        #endregion

        #region Prime

        /// <summary>
        /// The prime c1
        /// </summary>
        private Color Prime_C1 = Color.FromArgb(232, 232, 232);
        /// <summary>
        /// The prime c2
        /// </summary>
        private Color Prime_C2 = Color.FromArgb(252, 252, 252);
        /// <summary>
        /// The prime c3
        /// </summary>
        private Color Prime_C3 = Color.FromArgb(242, 242, 242);
        /// <summary>
        /// The prime b1
        /// </summary>
        private SolidBrush Prime_B1 = new SolidBrush(Color.FromArgb(255,255,255));
        /// <summary>
        /// The prime b2
        /// </summary>
        private SolidBrush Prime_B2 = new SolidBrush(Color.FromArgb(80, 80, 80));
        /// <summary>
        /// The prime b3
        /// </summary>
        private SolidBrush Prime_B3 = new SolidBrush(Color.FromArgb(255,255,255));
        /// <summary>
        /// The prime p1
        /// </summary>
        private Pen Prime_P1 = new Pen(Color.FromArgb(180, 180, 180));
        /// <summary>
        /// The prime p2
        /// </summary>
        private Pen Prime_P2 = new Pen(Color.FromArgb(255,255,255));
        /// <summary>
        /// The prime p3
        /// </summary>
        private Pen Prime_P3 = new Pen(Color.FromArgb(255,255,255));
        /// <summary>
        /// The prime p4
        /// </summary>
        private Pen Prime_P4 = new Pen(Color.FromArgb(150, 150, 150));

        /// <summary>
        /// The prime r t1
        /// </summary>
        private Rectangle Prime_RT1;

        /// <summary>
        /// Primes the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Prime_PaintHook(PaintEventArgs e)
        {
            G.Clear(Prime_C1);

            DrawGradient(Prime_C2, Prime_C3, 0, 0, Width, 15);

            DrawText(Prime_B1, HorizontalAlignment.Left, 13, 1);
            DrawText(Prime_B2, HorizontalAlignment.Left, 12, 0);

            Prime_RT1 = new Rectangle(12, 30, Width - 24, Height - 42);

            G.FillRectangle(Prime_B3, Prime_RT1);
            DrawBorders(Prime_P1, Prime_RT1, 1);
            DrawBorders(Prime_P2, Prime_RT1);

            DrawBorders(Prime_P3, 1);
            DrawBorders(Prime_P4);

            DrawCorners(TransparencyKey);
        }

        #endregion

        #region Purity

        /// <summary>
        /// Purities the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Purity_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromKnownColor(KnownColor.Control));
            // Clear the form first

            //DrawGradient(Color.FromArgb(64, 64, 64), Color.FromArgb(32, 32, 32), 0, 0, Width, Height, 90S)   ' Form Gradient
            G.Clear(Color.FromArgb(60, 60, 60));
            DrawGradient(Color.FromArgb(45, 40, 45), Color.FromArgb(32, 32, 32), 0, 0, Width, 25, 90);
            // Form Top Bar

            G.DrawLine(Pens.Black, 0, 25, Width, 25);
            // Top Line
            //G.DrawLine(Pens.Black, 0, Height - 25, Width, Height - 25)   ' Bottom Line

            DrawCorners(Color.Fuchsia, ClientRectangle);
            // Then draw some clean corners
            DrawBorders(Pens.Black, Pens.DimGray, ClientRectangle);
            // Then we draw our form borders

            DrawText(HorizontalAlignment.Left, Color.Red, 7, 1);
            // Finally, we draw our text
        }

        #endregion

        #region Qube

        /// <summary>
        /// The left panel size
        /// </summary>
        private int _LeftPanelSize = 4;

        /// <summary>
        /// Qubes the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
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

        #region Reactor

        /// <summary>
        /// Reactors the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        void Reactor_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {
            
            
            LinearGradientBrush glossLGB = new LinearGradientBrush(new Rectangle(0, 0, Width, 15), Color.FromArgb(102, 97, 93), Color.FromArgb(55, 54, 52), 90);
            LinearGradientBrush glossLGB2 = new LinearGradientBrush(new Rectangle(0, 15, Width, 15), Color.Black, Color.FromArgb(26, 25, 21), 90);
            LinearGradientBrush shadowLGB = new LinearGradientBrush(new Rectangle(5, 31, Width - 11, 20), Color.FromArgb(23, 23, 22), Color.FromArgb(38, 38, 38), 90);

            G.Clear(Color.FromArgb(26, 25, 21));
            G.FillRectangle(glossLGB, new Rectangle(0, 0, Width, 15));
            G.FillRectangle(glossLGB2, new Rectangle(0, 15, Width, 15));
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(42, 41, 37))), 4, 30, Width - 9, Height - 36);
            G.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), new Rectangle(5, 31, Width - 11, Height - 38));
            G.FillRectangle(shadowLGB, new Rectangle(5, 31, Width - 11, 20));
            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(24, 24, 24))), 5, 32, Width - 7, 32);
            G.DrawRectangle(Pens.Black, new Rectangle(5, 31, Width - 11, Height - 38));
            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(151, 150, 146))), 1, 1, Width - 2, 1);

            G.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));

            //G.DrawString(Text, Font, Brushes.Black, Width / 2 - (3 * Text.Length) + 3, 7)
            //G.DrawString(Text, Font, Brushes.White, Width / 2 - (3 * Text.Length) + 3, 8)
            G.DrawString(Text, Font, Brushes.Black, new Rectangle(0, 10, Width - 1, 10), new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center
            });
            G.DrawString(Text, Font, Brushes.White, new Rectangle(0, 11, Width - 1, 11), new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center
            });
        }


        #endregion

        #region Recon

        /// <summary>
        /// Recons the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Recon_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(41, 41, 41));
            DrawGradient(Color.FromArgb(11, 11, 11), Color.FromArgb(26, 26, 26), 1, 1, ClientRectangle.Width, ClientRectangle.Height, 270);
            DrawBorders(Pens.Black, new Pen(Color.FromArgb(52, 52, 52)), ClientRectangle);
            DrawGradient(Color.FromArgb(42, 42, 42), Color.FromArgb(40, 40, 40), 5, 30, Width - 10, Height - 35, 90);
            G.DrawRectangle(new Pen(Color.FromArgb(18, 18, 18)), 5, 30, Width - 10, Height - 35);

            //Icon

            switch (_TextAlignment)
            {
                case TextAlign.Left:
                    break;
                case TextAlign.Center:
                    break;
                case TextAlign.Right:
                    break;
                default:
                    break;
            }

            if (_ShowIcon == false)
            {
                switch (_TextAlignment)
                {
                    case TextAlign.Left:
                        DrawText(HorizontalAlignment.Left, this.ForeColor, 6);
                        break;
                    case TextAlign.Center:
                        DrawText(HorizontalAlignment.Center, this.ForeColor, 0);
                        break;
                    case TextAlign.Right:
                        MessageBox.Show("Invalid Alignment, will not show text.");
                        break;
                }

            }
            else
            {
                switch (_TextAlignment)
                {
                    case TextAlign.Left:
                        DrawText(HorizontalAlignment.Left, this.ForeColor, 35);
                        break;
                    case TextAlign.Center:
                        DrawText(HorizontalAlignment.Center, this.ForeColor, 0);
                        break;
                    case TextAlign.Right:
                        MessageBox.Show("Invalid Alignment, will not show text.");
                        break;
                }
                G.DrawIcon(this.ParentForm.Icon, new Rectangle(new Point(6, 2), new Size(29, 29)));
            }

            DrawCorners(Color.Fuchsia, ClientRectangle);
        }

        #endregion

        #region RedDwagon

        /// <summary>
        /// Reds the dwagon paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void RedDwagon_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Black);

            DrawGradient(Color.FromArgb(153, 0, 0), Color.FromArgb(255, 0, 0), 0, 0, Width, 55, 180);
            // Top Top
            DrawGradient(Color.FromArgb(255, 0, 0), Color.FromArgb(153, 0, 0), 0, 0, Width, 55, 90);
            // Top Top
            DrawGradient(Color.FromArgb(34, 34, 34), Color.FromArgb(34, 34, 34), 0, 56, Width, Height - 55, 90);
            // Middel Bottom
            DrawGradient(Color.FromArgb(34, 34, 34), Color.FromArgb(34, 34, 34), 0, 84, Width, 35, 90);
            // Midel Top
            G.DrawLine(Pens.Black, 0, 28, Width, 28);
            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(1, 0, 0, 0))), 0, 29, Width, 29);

            Pen p4 = new Pen(Color.FromArgb(34, 34, 34));
            Int32 ClientPtA = default(Int32);
            Int32 ClientPtB = default(Int32);
            ClientPtA = 55;
            ClientPtB = 30;
            DrawImage(HorizontalAlignment.Left, 5, 0);
            DrawText(Brushes.Black, 35, 7);

            G.DrawLine(p4, 0, ClientPtB, Width, ClientPtB);
            // Damn SlantedLines Where a BITCH to get in proper spot!

            for (int I = 0; I <= Width + 17; I += 4)
            {
                G.DrawLine(p4, I, 30, I - 17, ClientPtA);
                G.DrawLine(p4, I - 1, 30, I - 18, ClientPtA);
            }

            DrawCorners(TransparencyKey);
        }

        #endregion

        #region Redemption

        /// <summary>
        /// Redemptions the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        void Redemption_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            
            G.SmoothingMode = SmoothingMode.HighQuality;
            G.TextRenderingHint = TextRenderingHint.AntiAlias;

            //G.FillRectangle(MatteNoise, ClientRectangle)
            G.FillRectangle(new SolidBrush(Color.FromArgb(25, Color.White)), new Rectangle(0, 0, Width - 1, 28));
            G.FillRectangle(new SolidBrush(Color.FromArgb(25, Color.White)), new Rectangle(0, 28, 6, Height - 35));
            G.FillRectangle(new SolidBrush(Color.FromArgb(25, Color.White)), new Rectangle(Width - 7, 28, 7, Height - 35));
            G.FillRectangle(new SolidBrush(Color.FromArgb(25, Color.White)), new Rectangle(0, Height - 7, Width - 1, 7));
            G.FillRectangle(new SolidBrush(Color.FromArgb(15, Color.White)), new Rectangle(6, 28, Width - 13, Height - 35));
            G.DrawLine(new Pen(Color.FromArgb(44, 45, 48)), new Point(6, 29), new Point(Width - 7, 29));
            G.DrawLine(new Pen(Color.FromArgb(37, 38, 40)), new Point(6, 30), new Point(Width - 7, 30));
            G.DrawLine(new Pen(Color.FromArgb(75, 60, 61, 62)), new Point(6, 31), new Point(Width - 7, 31));
            G.DrawLine(new Pen(Color.FromArgb(56, 57, 60)), new Point(5, 31), new Point(5, Height - 7));
            G.DrawLine(new Pen(Color.FromArgb(77, 78, 79)), new Point(6, 31), new Point(6, Height - 7));
            G.DrawLine(new Pen(Color.FromArgb(56, 57, 60)), new Point(Width - 7, 31), new Point(Width - 7, Height - 7));
            G.DrawLine(new Pen(Color.FromArgb(77, 78, 79)), new Point(Width - 8, 31), new Point(Width - 8, Height - 7));
            G.DrawLine(new Pen(Color.FromArgb(63, 64, 65)), new Point(6, Height - 8), new Point(Width - 7, Height - 8));
            G.DrawLine(new Pen(Color.FromArgb(63, 63, 63)), new Point(5, Height - 7), new Point(Width - 6, Height - 7));
            G.DrawLine(new Pen(Color.FromArgb(85, 86, 88)), new Point(0, 1), new Point(Width - 1, 1));
            G.DrawRectangle(new Pen(Color.FromArgb(21, 23, 25)), ClientRectangle);

            Color[] ColorList = {
                Color.FromArgb(200, 34, 36, 39),
                Color.FromArgb(200, 5, 185, 238),
                Color.FromArgb(200, 34, 36, 39)
            };
            float[] PointList = {
                0 / 2,
                1 / 2,
                2 / 2
            };
            LinearGradientBrush AccentBrush = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.Black, Color.White, 90);
            ColorBlend AccentBlend = new ColorBlend
            {
                Colors = ColorList,
                Positions = PointList
            };
            AccentBrush.InterpolationColors = AccentBlend;
            G.DrawRectangle(new Pen(AccentBrush), new Rectangle(0, 0, Width - 1, Height - 1));

            StringFormat TextFormat = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            };
            G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(200, Color.Black)), new Rectangle(8, 1, Width - 1, 28), TextFormat);
            G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(8, 2, Width - 1, 28), TextFormat);


            e.Graphics.DrawImage(B, new Point(0, 0));
            G.Dispose();
            B.Dispose();
        }


        #endregion

        #region Rockstar

        /// <summary>
        /// Rockstars the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Rockstar_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Black);


            G.DrawLine(Pens.Gold, 0, 20, Width, 20);

            DrawGradient(Color.Yellow, Color.Gold, 0, 0, Width, 20, 90);
            DrawText(HorizontalAlignment.Center, Color.Black, 0);

            DrawBorders(Pens.Yellow, Pens.Yellow, ClientRectangle);
            DrawCorners(Color.Fuchsia, ClientRectangle);
        }

        #endregion

        #region Sasi

        /// <summary>
        /// Sasis the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Sasi_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(168, 219, 4));
            HatchBrush HB = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(30, Color.White), Color.Transparent);

            G.FillRectangle(new SolidBrush(Color.FromArgb(239, 254, 213)), new Rectangle(6, 36, Width - 13, Height - 43));
            G.FillRectangle(HB, new Rectangle(0, 0, Width - 1, Height - 1));
            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(Color.FromArgb(49, 51, 48)), new Point(35, 10));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(10, 10, 16, 16));
            DrawCorners(Color.Fuchsia);
        }

        #endregion

        #region Secure

        /// <summary>
        /// Secures the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Secure_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Black);
            DrawBG(Color.DimGray, ClientRectangle);
            DrawGradient(Color.DimGray, Color.Black, 0, 0, Width, 20, 90);
            DrawCorners(Color.Fuchsia, ClientRectangle);
            DrawText(HorizontalAlignment.Center, Color.White, 3);
            DrawBorders(Pens.Transparent, Pens.LightGray, ClientRectangle);

        }

        #endregion

        #region Sharp
        /// <summary>
        /// The sharp color2
        /// </summary>
        private bool sharp_Color2 = true;

        /// <summary>
        /// Gets or sets a value indicating whether [sharp color2].
        /// </summary>
        /// <value><c>true</c> if [sharp color2]; otherwise, <c>false</c>.</value>
        public bool Sharp_Color2
        {
            get { return sharp_Color2; }
            set
            {
                sharp_Color2 = value;
                Invalidate();
            }
        }


        /// <summary>
        /// Sharps the paint.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
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

        #region Simpla

        /// <summary>
        /// Simplas the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        void Simpla_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);

            Rectangle mainTop = new Rectangle(0, 0, Width - 1, 40);
            Rectangle mainBottom = new Rectangle(0, 40, Width, Height);

            
            G.Clear(Color.Fuchsia);
            G.SetClip(Utilities.Draw.RoundRect(new Rectangle(0, 0, Width, Height), 4));

            SolidBrush gradientBackground = new SolidBrush(Color.FromArgb(34, 34, 34));
            G.FillRectangle(gradientBackground, mainBottom);

            LinearGradientBrush gradientBackground2 = new LinearGradientBrush(mainTop, Color.FromArgb(23, 23, 23), Color.FromArgb(17, 17, 17), 90);
            G.FillRectangle(gradientBackground2, mainTop);

            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(56, 56, 56))), 0, 40, Width - 1, 40);
            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(42, 42, 42))), 0, 41, Width - 1, 41);

            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(12, 12, 12))), new Rectangle(0, 0, Width - 1, Height - 1));

            Font drawFont = new Font("Calibri (Body)", 10, FontStyle.Bold);
            G.DrawString(Text, drawFont, new SolidBrush(Color.FromArgb(225, 225, 225)), 3, 10);

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            //G.Dispose();
            B.Dispose();
        }


        #endregion

        #region Simply Gray

        /// <summary>
        /// The simply gray f
        /// </summary>
        System.Drawing.Font SimplyGray_F = new System.Drawing.Font("Verdana", 8);
        /// <summary>
        /// The simply gray b
        /// </summary>
        SolidBrush SimplyGray_B = new SolidBrush(Color.DimGray);
        /// <summary>
        /// The simply gray gr
        /// </summary>
        Color SimplyGray_Gr = Color.Gray;
        /// <summary>
        /// The simply gray lg
        /// </summary>
        Color SimplyGray_LG = Color.LightGray;
        /// <summary>
        /// The simply gray fc
        /// </summary>
        Color SimplyGray_Fc = Color.Fuchsia;

        /// <summary>
        /// The border color1
        /// </summary>
        public Pen _BorderColor1 = Pens.DarkGray;
        /// <summary>
        /// The border color2
        /// </summary>
        public Pen _BorderColor2 = Pens.Black;

        /// <summary>
        /// Simplies the gray paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void SimplyGray_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Gray);
            DrawGradient(SimplyGray_LG, SimplyGray_Gr, 0, 0, Width, 20, 90);

            DrawBorders(_BorderColor2, _BorderColor1, ClientRectangle);
            DrawCorners(SimplyGray_Fc, ClientRectangle);

            DrawText(HorizontalAlignment.Left, ForeColor = Color.FromArgb(60, 60, 60), 3, 0);
            G.DrawString(_SubText, SimplyGray_F, SimplyGray_B, 4, 19);
        }

        #endregion

        #region Simplistic

        /// <summary>
        /// Simplistics the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Simplistic_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.SteelBlue);

            DrawGradient(Color.DodgerBlue, Color.SteelBlue, 0, 0, Width, 24, 180);
            G.DrawLine(Pens.Black, 0, 24, Width, 24);

            DrawText(HorizontalAlignment.Left, Color.Black, 4);
            DrawBorders(Pens.Black, Pens.LightGray, ClientRectangle);
            DrawCorners(Color.Fuchsia, ClientRectangle);
        }

        #endregion

        #region Situation

        /// <summary>
        /// Situations the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Situation_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.DarkSlateGray);
            DrawGradient(Color.DarkSlateGray, Color.DarkGray, 0, 0, Width, 20, 90);
            DrawGradient(Color.DimGray, Color.Black, 0, 20, Width, Height - 25, 90);
            DrawGradient(Color.DarkGray, Color.Black, 0, Height - 25, Width, Height + 25 - Height, 90);
            DrawGradient(Color.DarkGray, Color.DarkSlateGray, 0, Height + 25 - Height - 5, 10, Height - 45, 180);
            DrawGradient(Color.DarkSlateGray, Color.Black, Width - 10, Height + 25 - Height - 5, 10, Height - 45, 180);
            DrawCorners(Color.Fuchsia, ClientRectangle);
            DrawText(HorizontalAlignment.Center, ForeColor, 3);
            DrawBorders(Pens.DarkSlateGray, Pens.LightBlue, ClientRectangle);
        }

        #endregion

        #region SkyBase

        /// <summary>
        /// The sky base t1
        /// </summary>
        Rectangle SkyBase_T1;
        /// <summary>
        /// The sky base c1
        /// </summary>
        Color SkyBase_C1 = Color.FromArgb(62, 60, 58);
        /// <summary>
        /// The sky base c2
        /// </summary>
        Color SkyBase_C2 = Color.FromArgb(81, 79, 77);
        /// <summary>
        /// The sky base c3
        /// </summary>
        Color SkyBase_C3 = Color.FromArgb(71, 70, 69);

        /// <summary>
        /// The sky base c4
        /// </summary>
        Color SkyBase_C4 = Color.FromArgb(58, 56, 54);

        /// <summary>
        /// Skies the base paint hook.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        void SkyBase_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {
            SkyBase_T1 = new Rectangle(1, 1, Width - 3, 18);

            Bitmap SkyBase_B = new Bitmap(Width, Height);
            G = Graphics.FromImage(SkyBase_B);

            //Drawing
            G.Clear(SkyBase_C1);
            LinearGradientBrush SkyBase_G1 = new LinearGradientBrush(new Point(SkyBase_T1.X, SkyBase_T1.Y), new Point(SkyBase_T1.X, SkyBase_T1.Y + SkyBase_T1.Height), SkyBase_C3, SkyBase_C4);
            G.FillRectangle(SkyBase_G1, SkyBase_T1);
            G.DrawRectangle(ConversionFunctions.ToPen(SkyBase_C2), SkyBase_T1);
            G.DrawRectangle(ConversionFunctions.ToPen(SkyBase_C2), new Rectangle(SkyBase_T1.X, SkyBase_T1.Y + SkyBase_T1.Height + 2, SkyBase_T1.Width, Height - SkyBase_T1.Y - SkyBase_T1.Height - 4));

            SkyBase_G1.Dispose();

            G.DrawString(Text, Font, ConversionFunctions.ToBrush(113, 170, 186), new Rectangle(new Point(SkyBase_T1.X + 4, SkyBase_T1.Y), new Size(SkyBase_T1.Width - 40, SkyBase_T1.Height)), new StringFormat { LineAlignment = StringAlignment.Center });


            //Finish Up
            e.Graphics.DrawImage((Bitmap)SkyBase_B.Clone(), 0, 0);
            //G.Dispose();
            SkyBase_B.Dispose();
        }


        #endregion

        #region Skype

        /// <summary>
        /// Skypes the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Skype_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(148, 195, 255));
            G.DrawRectangle(new Pen(Color.FromArgb(105, 142, 191)), 0, 0, Width - 1, Height - 1);

            DrawGradient(Color.FromArgb(241, 247, 255), Color.FromArgb(148, 195, 255), 1, 1, Width - 2, 25);
            DrawGradient(Color.FromArgb(211, 230, 255), Color.FromArgb(148, 195, 255), 2, 2, Width - 4, 25);

            G.DrawString(Text, new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.FromArgb(51, 51, 51)), 5, 3);
        }

        #endregion

        #region SLC


        /// <summary>
        /// The topc
        /// </summary>
        private Color topc = Color.FromArgb(21, 18, 37);
        /// <summary>
        /// The botc
        /// </summary>
        private Color botc = Color.FromArgb(32, 35, 54);
        /// <summary>
        /// The topc2
        /// </summary>
        private Color topc2 = Color.FromArgb(32, 35, 54);
        /// <summary>
        /// The botc2
        /// </summary>
        private Color botc2 = Color.FromArgb(21, 18, 37);



        /// <summary>
        /// Prepares the border.
        /// </summary>
        /// <returns>GraphicsPath.</returns>
        private GraphicsPath PrepareBorder()
        {
            GraphicsPath P = new GraphicsPath();

            List<Point> PS = new List<Point>();
            PS.Add(new Point(0, 2));
            PS.Add(new Point(2, 0));
            PS.Add(new Point(100, 0));
            PS.Add(new Point(115, 15));
            PS.Add(new Point(Width - 1 - 115, 15));
            PS.Add(new Point(Width - 1 - 100, 0));
            PS.Add(new Point(Width - 2, 0));
            PS.Add(new Point(Width - 1, 3));


            //PS.Add(New Point(Width - 1, Height - 1))

            //bottom
            PS.Add(new Point(Width - 1, Height - 3));
            PS.Add(new Point(Width - 3, Height - 1));
            PS.Add(new Point(Width - 100, Height - 1));
            PS.Add(new Point(Width - 115, Height - 15 - 1));
            PS.Add(new Point(116, Height - 15 - 1));
            PS.Add(new Point(101, Height - 1));
            PS.Add(new Point(2, Height - 1));
            PS.Add(new Point(0, Height - 2));

            P.AddPolygon(PS.ToArray());
            return P;
        }

        /// <summary>
        /// SLCs the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void SLC_PaintHook(PaintEventArgs e)
        {
            TransparencyKey = Color.Fuchsia;

            G.Clear(Color.Fuchsia);

            HatchBrush HB = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(50, Color.FromArgb(38, 138, 201)), Color.FromArgb(80, Color.FromArgb(12, 40, 57)));
            LinearGradientBrush linear = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(108, 137, 184), Color.FromArgb(13, 20, 25), 20f);

            G.FillRectangle(linear, new Rectangle(3, 3, Width - 5, Height - 3));

            G.FillRectangle(HB, new Rectangle(3, 3, Width - 5, Height - 3));


            G.DrawLine(Pens.Fuchsia, 1, 0, Width - 1, 0);
            G.DrawLine(Pens.Fuchsia, 1, 1, Width - 1, 1);
            G.DrawLine(new Pen(Color.FromArgb(26, 47, 59)), 1, 2, Width - 1, 2);

            G.DrawLine(Pens.Fuchsia, 1, Height - 1, Width - 1, Height - 1);
            G.DrawLine(Pens.Fuchsia, 1, Height - 2, Width - 1, Height - 2);
            G.DrawLine(new Pen(Color.FromArgb(26, 47, 59)), 1, Height - 2, Width - 4, Height - 2);




            GraphicsPath GPF = PrepareBorder();


            PathGradientBrush PB2 = default(PathGradientBrush);
            PB2 = new PathGradientBrush(GPF);
            PB2.CenterColor = Color.FromArgb(250, 250, 250);
            PB2.SurroundColors = new Color[] { Color.FromArgb(237, 237, 237) };
            PB2.FocusScales = new PointF(0.9f, 0.5f);

            G.SetClip(GPF);

            G.FillPath(PB2, GPF);
            G.DrawPath(new Pen(Color.White, 3), GPF);
            G.ResetClip();

            GraphicsPath tmpG = PrepareBorder();

            G.DrawPath(Pens.Gray, tmpG);



            LinearGradientBrush linear2 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(13, 59, 85), Color.FromArgb(22, 35, 43), 180f);



            GraphicsPath barGP = new GraphicsPath();

            PathGradientBrush PB3 = default(PathGradientBrush);
            PB3 = new PathGradientBrush(GPF);
            PB3.CenterColor = Color.FromArgb(39, 60, 73);
            PB3.SurroundColors = new Color[] { Color.FromArgb(31, 105, 152) };
            PB3.FocusScales = new PointF(0.5f, 0.5f);
            PB3.CenterPoint = new Point(Width / 2, 10);

            barGP.AddRectangle(new Rectangle(0, 39, Width - 1, 20));

            G.FillPath(PB3, barGP);
            G.FillPath(new HatchBrush(HatchStyle.NarrowHorizontal, Color.FromArgb(20, 34, 45), Color.Transparent), barGP);

            //// get rid of some pixels
            G.DrawRectangle(Pens.Fuchsia, new Rectangle(Width - 4, 40, 3, 17));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(Width - 4, 40, 3, 17));

            G.DrawRectangle(Pens.Fuchsia, new Rectangle(0, 40, 3, 17));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(0, 40, 3, 17));


            //// inside square

            //Dim SQpth As GraphicsPath = FormInsideSQ()
            // G.DrawPath(Pens.Red, SQpth)



            DrawText(new SolidBrush(Color.FromArgb(30, Color.Black)), HorizontalAlignment.Left, 12, 6);
            DrawText(new SolidBrush(Color.FromArgb(20, Color.Black)), HorizontalAlignment.Left, 11, 5);
            DrawText(Brushes.Black, HorizontalAlignment.Left, 10, 4);





        }
        #endregion

        #region Somnium

        /// <summary>
        /// The somnium c1
        /// </summary>
        private Color Somnium_C1 = Color.White;
        /// <summary>
        /// The somnium c2
        /// </summary>
        private Color Somnium_C2 = Color.FromArgb(50, 50, 50);
        /// <summary>
        /// The somnium c3
        /// </summary>
        private Color Somnium_C3 = Color.FromArgb(0, 0, 0);
        /// <summary>
        /// The somnium c4
        /// </summary>
        private Color Somnium_C4 = Color.Gray;
        /// <summary>
        /// The somnium c5
        /// </summary>
        private Color Somnium_C5 = Color.LightGray;
        /// <summary>
        /// The somnium p1
        /// </summary>
        private Pen Somnium_P1 = Pens.Black;
        /// <summary>
        /// The somnium b1
        /// </summary>
        private Brush Somnium_B1 = new SolidBrush(Color.FromArgb(15, 15, 15));
        /// <summary>
        /// The somnium b2
        /// </summary>
        private Brush Somnium_B2 = new SolidBrush(Color.FromArgb(50, Color.White));
        /// <summary>
        /// The somnium b3
        /// </summary>
        private Brush Somnium_B3 = new SolidBrush(Color.White);
        /// <summary>
        /// The somnium b4
        /// </summary>
        private Brush Somnium_B4 = new SolidBrush(Color.FromArgb(30, Color.White));
        /// <summary>
        /// The somnium h b1
        /// </summary>
        private HatchBrush Somnium_HB1;


        /// <summary>
        /// Somniums the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Somnium_PaintHook(PaintEventArgs e)
        {
            Somnium_HB1 = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(15, 15, 15));

            G.Clear(Somnium_C1);
            //BackGround'
            G.FillRectangle(Somnium_HB1, 0, 0, Width, Height);

            //Top'
            DrawGradient(Somnium_C2, Somnium_C3, 0, 0, Width, 15, 90);
            G.DrawRectangle(Somnium_P1, 0, 0, Width, 15);

            //Bottom'
            G.FillRectangle(Somnium_B1, 0, Convert.ToInt32(Height - 11), Width, 10);
            G.DrawRectangle(Somnium_P1, 0, Convert.ToInt32(Height - 11), Width, 10);
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(30, 30, 30))), 14, Convert.ToInt32(Height - 10), Convert.ToInt32(Width - 29), 8);
            //Left Side'
            //Left'
            G.FillRectangle(Somnium_B1, 0, 0, 5, Convert.ToInt32(Height - 1));
            G.DrawRectangle(Somnium_P1, 0, 0, 5, Convert.ToInt32(Height - 1));
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(30, 30, 30))), 1, 1, 3, Convert.ToInt32(Height - 3));
            //Middle'
            DrawGradient(Somnium_C4, Somnium_C5, 5, 15, 3, Convert.ToInt32(Height - 16), 180);
            G.DrawRectangle(Somnium_P1, 5, 15, 3, Convert.ToInt32(Height - 16));
            //Right'
            G.FillRectangle(Somnium_B1, 8, 15, 5, Convert.ToInt32(Height - 16));
            G.DrawRectangle(Somnium_P1, 8, 15, 5, Convert.ToInt32(Height - 16));
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(30, 30, 30))), 9, 16, 3, Convert.ToInt32(Height - 18));

            //Right Side'
            //Right'
            G.FillRectangle(Somnium_B1, Convert.ToInt32(Width - 6), 0, 5, Convert.ToInt32(Height - 1));
            G.DrawRectangle(Somnium_P1, Convert.ToInt32(Width - 6), 0, 5, Convert.ToInt32(Height - 1));
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(30, 30, 30))), Convert.ToInt32(Width - 5), 1, 3, Convert.ToInt32(Height - 3));
            //Middle'
            DrawGradient(Somnium_C4, Somnium_C5, Convert.ToInt32(Width - 9), 15, 3, Convert.ToInt32(Height - 16), 180);
            G.DrawRectangle(Somnium_P1, Convert.ToInt32(Width - 9), 15, 3, Convert.ToInt32(Height - 16));
            //Left'
            G.FillRectangle(Somnium_B1, Convert.ToInt32(Width - 14), 15, 5, Convert.ToInt32(Height - 16));
            G.DrawRectangle(Somnium_P1, Convert.ToInt32(Width - 14), 15, 5, Convert.ToInt32(Height - 16));
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(30, 30, 30))), Convert.ToInt32(Width - 13), 16, 3, Convert.ToInt32(Height - 18));
            //Top Gloss'
            G.FillRectangle(Somnium_B2, 0, 0, Width, 5);

            //Bottom Gloss'
            G.FillRectangle(Somnium_B4, 0, Convert.ToInt32(Height - 3), Width, 3);

            DrawText(Somnium_B3, HorizontalAlignment.Center, 0, 3);

        }

        #endregion

        #region SpicyLips

        /// <summary>
        /// Spicies the lips paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void SpicyLips_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(20, 20, 20));

            HatchBrush T = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(9, 9, 9), Color.FromArgb(15, 15, 15));
            G.FillRectangle(T, ClientRectangle);
            G.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.White)), ClientRectangle);
            DrawBorders(new Pen(Color.FromArgb(7, 7, 7)), 0, 0, Width, Height);

            G.FillRectangle(new SolidBrush(Color.FromArgb(22, 22, 22)), 12, 22, Width - 24, Height - 27);
            DrawBorders(new Pen(Color.FromArgb(7, 7, 7)), 12, 22, Width - 24, Height - 27);

            DrawText(new SolidBrush(Color.White), HorizontalAlignment.Center, 0, 2);
            DrawCorners(TransparencyKey);

        }

        #endregion

        #region Steam

        /// <summary>
        /// Steams the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Steam_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(56, 54, 53));
            DrawGradient(Color.Black, Color.FromArgb(76, 108, 139), ClientRectangle, 65);
            G.FillRectangle(new SolidBrush(Color.FromArgb(56, 54, 53)), new Rectangle(1, 1, Width - 2, Height - 2));
            DrawGradient(Color.FromArgb(71, 68, 66), Color.FromArgb(57, 55, 54), new Rectangle(1, 1, Width - 2, 35), 90);
            DrawText(new SolidBrush(Color.FromArgb(195, 193, 191)), HorizontalAlignment.Left, 4, 0);
        }

        #endregion

        #region SteamAlt

        /// <summary>
        /// Steams the alt paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void SteamAlt_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(44, 42, 40));

            HatchBrush T = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(20, 19, 19), Color.FromArgb(46, 44, 42));
            G.FillRectangle(T, ClientRectangle);
            DrawGradient(Color.Transparent, Color.FromArgb(29, 28, 27), new Rectangle(0, 0 - Height / 3 - Height / 9, Width, Height));
            G.FillRectangle(new SolidBrush(Color.FromArgb(29, 28, 28)), new Rectangle(0, Height / 3 + Height / 3 - Height / 9, Width, Height));


            DrawBorders(new Pen(new SolidBrush(Color.FromArgb(0, 0, 0))));
            DrawText(new SolidBrush(Color.FromArgb(195, 193, 191)), HorizontalAlignment.Left, 4, 0);

        }

        #endregion

        #region Storm

        /// <summary>
        /// The storm c1
        /// </summary>
        private Color Storm_C1 = Color.FromArgb(90, 90, 110);
        /// <summary>
        /// The storm c2
        /// </summary>
        private Color Storm_C2 = Color.FromArgb(175, 175, 190);
        /// <summary>
        /// The storm c3
        /// </summary>
        private Color Storm_C3 = Color.FromArgb(140, 140, 155);
        /// <summary>
        /// The storm p1
        /// </summary>
        private Pen Storm_P1 = new Pen(Color.FromArgb(70, 70, 90));
        /// <summary>
        /// The storm p2
        /// </summary>
        private Pen Storm_P2 = new Pen(Color.FromArgb(105, 105, 120));
        /// <summary>
        /// The storm p3
        /// </summary>
        private Pen Storm_P3 = new Pen(Color.FromArgb(25, 25, 30));

        /// <summary>
        /// The storm b1
        /// </summary>
        private HatchBrush Storm_B1;

        /// <summary>
        /// The top height
        /// </summary>
        private int _TopHeight = 40;
        /// <summary>
        /// The bottom height
        /// </summary>
        private int _BottomHeight = 40;
        /// <summary>
        /// Storms the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Storm_PaintHook(PaintEventArgs e)
        {
            Storm_B1 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(35, 35, 45), Color.FromArgb(40, 40, 50));

            G.Clear(Storm_C1);

            if (!(_TopHeight == 0))
            {
                DrawGradient(Storm_C2, Storm_C3, 0, 0, Width, _TopHeight);
                G.DrawLine(Storm_P1, 0, _TopHeight - 1, Width, _TopHeight - 1);
                G.DrawLine(Storm_P2, 0, _TopHeight, Width, _TopHeight);
            }

            if (!(_BottomHeight == 0))
            {
                G.FillRectangle(Storm_B1, 0, Height - _BottomHeight, Width, _BottomHeight);
                G.DrawLine(Storm_P3, 0, Height - _BottomHeight, Width, Height - _BottomHeight);
            }

            DrawText(new SolidBrush(Color.FromArgb(195, 193, 191)), HorizontalAlignment.Left, 4, 0);

        }

        #endregion

        #region Studio


        /// <summary>
        /// The studio c1
        /// </summary>
        private Color Studio_C1 = Color.FromArgb(50, 70, 100);
        /// <summary>
        /// The studio c2
        /// </summary>
        private Color Studio_C2 = Color.FromArgb(65, 85, 115);
        /// <summary>
        /// The studio c3
        /// </summary>
        private Color Studio_C3 = Color.FromArgb(50, 70, 100);
        /// <summary>
        /// The studio c4
        /// </summary>
        private Color Studio_C4 = Color.FromArgb(15, Color.Black);
        /// <summary>
        /// The studio c5
        /// </summary>
        private Color Studio_C5 = Color.Transparent;
        /// <summary>
        /// The studio p1
        /// </summary>
        private Pen Studio_P1 = new Pen(Color.Fuchsia, 3);
        /// <summary>
        /// The studio p2
        /// </summary>
        private Pen Studio_P2 = new Pen(Color.FromArgb(12, 32, 62));
        /// <summary>
        /// The studio p3
        /// </summary>
        private Pen Studio_P3 = new Pen(Color.FromArgb(20, Color.Black));
        /// <summary>
        /// The studio p4
        /// </summary>
        private Pen Studio_P4 = new Pen(Color.FromArgb(30, Color.White));
        /// <summary>
        /// The studio p5
        /// </summary>
        private Pen Studio_P5 = new Pen(Color.Black);
        /// <summary>
        /// The studio b1
        /// </summary>
        private HatchBrush Studio_B1;

        /// <summary>
        /// The studio b2
        /// </summary>
        private SolidBrush Studio_B2;

        /// <summary>
        /// The studio r t1
        /// </summary>
        private Rectangle Studio_RT1;

        /// <summary>
        /// The studio path
        /// </summary>
        private GraphicsPath Studio_Path = new GraphicsPath();

        /// <summary>
        /// Studioes the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Studio_PaintHook(PaintEventArgs e)
        {
            Studio_B1 = new HatchBrush(HatchStyle.LightDownwardDiagonal, Color.FromArgb(20, 40, 70), Color.FromArgb(40, 60, 90));
            Studio_B2 = new SolidBrush(Color.White);

            G.DrawRectangle(Studio_P1, ClientRectangle);

            Studio_Path.Reset();
            Studio_Path.AddLines(new Point[] {
                new Point(2, 0),
                new Point(Width - 3, 0),
                new Point(Width - 1, 2),
                new Point(Width - 1, Height - 3),
                new Point(Width - 3, Height - 1),
                new Point(2, Height - 1),
                new Point(0, Height - 3),
                new Point(0, 2),
                new Point(2, 0)
            });
            G.SetClip(Studio_Path);

            G.Clear(Studio_C1);
            DrawGradient(Studio_C2, Studio_C3, 0, 0, Width, 30);

            Studio_RT1 = new Rectangle(12, 30, Width - 24, Height - 12 - 30);
            G.FillRectangle(Studio_B1, Studio_RT1);

            DrawGradient(Studio_C4, Studio_C5, 12, 30, Width - 24, 30);

            DrawBorders(Studio_P2, Studio_RT1);
            DrawBorders(Studio_P3, 14, 32, Width - 26, Height - 12 - 32);

            DrawText(Studio_B2, HorizontalAlignment.Left, 12, 0);

            DrawBorders(Studio_P4, 1);

            G.ResetClip();
            G.DrawPath(Studio_P5, Studio_Path);
        }


        #endregion

        #region Subspace

        /// <summary>
        /// Subspaces the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Subspace_PaintHook(PaintEventArgs e)
        {
            //Body
            G.Clear(Color.FromArgb(30, 30, 30));
            G.FillRectangle(Brushes.Fuchsia, 0, 0, Width, 5);
            DrawBorders(Pens.Black, 0, 30, Width, Height);

            //HeaderShadow
            DrawGradient(Color.Black, Color.FromArgb(30, 30, 30), 1, 28, Width, 10);

            //BottomBody
            DrawGradient(Color.FromArgb(30, 30, 30), Color.Black, 0, Height - 23, Width, 10);
            DrawGradient(Color.FromArgb(0, 0, 0), Color.FromArgb(57, 57, 58), 0, Height - 12, Width / 2, Height, 360);
            DrawGradient(Color.FromArgb(0, 0, 0), Color.FromArgb(57, 57, 58), Width / 2, Height - 12, Width / 2, Height, 180);
            G.DrawLine(Pens.Black, 0, Height - 13, Width, Height - 13);
            G.DrawLine(new Pen(Color.FromArgb(57, 57, 58)), Width / 2, Height - 11, Width / 2, Height);


            //LeftSideBody
            G.FillRectangle(Brushes.Black, 0, 30, 8, Height);
            DrawBorders(Pens.Black, 1, 30, 9, Height - 2);
            G.DrawLine(new Pen(Color.FromArgb(40, 40, 40)), 8, 30, 8, Height);

            //RightSideBody
            G.FillRectangle(Brushes.Black, Width - 9, 30, 11, Height - 20);
            DrawBorders(Pens.Black, Width - 10, 30, 11, Height - 2);
            G.DrawLine(new Pen(Color.FromArgb(60, 60, 60)), Width - 9, 30, Width - 9, Height);



            //Header
            G.FillRectangle(Brushes.Black, 0, 5, Width, 24);
            DrawText(Brushes.DodgerBlue, HorizontalAlignment.Left, 55, 2);
            G.FillRectangle(new SolidBrush(Color.FromArgb(50, Color.White)), 0, 5, Width - 1, 11);
            DrawBorders(Pens.Black, 1, 4, Width - 2, 24);
            G.DrawLine(new Pen(Color.FromArgb(108, 108, 108)), 1, 5, Width, 5);
            G.DrawLine(new Pen(Color.FromArgb(60, 60, 60)), 1, 28, Width - 2, 28);
            G.DrawLine(Pens.Black, 1, 30, Width - 3, 30);

            //-----------------------------------------------------
            //Box
            DrawBorders(Pens.Black, 8, 0, 34, 32);
            DrawGradient(Color.FromArgb(57, 57, 58), Color.FromArgb(2, 4, 12), 9, 1, 32, 16);
            DrawGradient(Color.FromArgb(2, 4, 23), Color.FromArgb(57, 57, 58), 9, 15, 32, 16);
            //Lines
            DrawGradient(Color.FromArgb(100, 213, 255), Color.FromArgb(51, 162, 255), 17, 8, 3, 15);
            DrawGradient(Color.FromArgb(100, 213, 255), Color.FromArgb(51, 162, 255), Convert.ToInt32(47 / 2), (int)4.5, 3, (int)20.5);
            DrawGradient(Color.FromArgb(100, 213, 255), Color.FromArgb(51, 162, 255), 30, 8, 3, 15);

            DrawImage(HorizontalAlignment.Left, 9, 1);

            //Gloss
            G.FillRectangle(new SolidBrush(Color.FromArgb(15, Color.White)), 10, 2, 31, 13);
            //------------------------------------------------------

            //SideBoxes
            DrawGradient(Color.FromArgb(10, 10, 10), Color.FromArgb(47, 47, 47), 42, 2, 5, 15);
            DrawGradient(Color.FromArgb(47, 47, 47), Color.FromArgb(10, 10, 10), 42, 15, 5, 15);
            DrawGradient(Color.FromArgb(47, 47, 47), Color.FromArgb(10, 10, 10), 3, 2, 5, 15);
            DrawGradient(Color.FromArgb(10, 10, 10), Color.FromArgb(47, 47, 47), 3, 15, 5, 15);
            DrawBorders(Pens.Black, 42, 2, 5, 29);
            DrawBorders(Pens.Black, 3, 2, 5, 29);
            G.DrawLine(Pens.Black, 3, 15, 7, 15);
            G.DrawLine(Pens.Black, 42, 15, 46, 15);

            //Animation


            //Icon

            G.DrawLine(Pens.Black, 0, Height - 1, Width, Height - 1);
            DrawCorners(Color.Fuchsia);
        }

        #endregion

        #region Sugar

        /// <summary>
        /// Sugars the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Sugar_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(190, 210, 217));
            HatchBrush HB = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(30, Color.White), Color.Transparent);

            G.FillRectangle(new SolidBrush(BackColor), new Rectangle(6, 36, Width - 13, Height - 43));
            G.FillRectangle(HB, new Rectangle(0, 0, Width - 1, Height - 1));
            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(Color.FromArgb(49, 51, 48)), new Point(35, 10));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(10, 10, 16, 16));
            DrawCorners(Color.Fuchsia);
        }

        #endregion

        #region TeamViewer

        /// <summary>
        /// Teams the viewer paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void TeamViewer_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.White);
            DrawGradient(Color.FromArgb(0, 153, 255), Color.FromArgb(0, 102, 255), 0, 0, Width, 28, 90);
            DrawGradient(Color.FromArgb(51, 153, 255), Color.FromArgb(0, 102, 204), 0, 29, Width, 55, 90);
            DrawGradient(Color.White, Color.FromArgb(204, 204, 204), 0, 115, Width, Height - 55, 90);
            DrawGradient(Color.FromArgb(204, 204, 204), Color.White, 0, 84, Width, 35, 90);
            G.DrawLine(Pens.DarkBlue, 0, 28, Width, 28);
            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(51, 204, 255))), 0, 29, Width, 29);
            G.DrawLine(Pens.White, 0, 84, Width, 84);
            //G.DrawString(".", Me.Parent.Font, Brushes.Black, -2, Height - 12)
            //G.DrawString(".", Me.Parent.Font, Brushes.Black, Width - 5, Height - 12)
            //DrawBorders(Pens.Black, Pens.Transparent, ClientRectangle)
            //DrawCorners(Color.Fuchsia, ClientRectangle)

            DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Left, 4, 0);

        }

        #endregion

        #region Tech

        /// <summary>
        /// Teches the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Tech_PaintHook(PaintEventArgs e)
        {
            Pen lineColor = new Pen(Color.FromArgb(98, 142, 179));
            Pen borderColor1 = new Pen(Color.FromArgb(48, 71, 92));
            Pen borderColor2 = new Pen(Color.FromArgb(17, 36, 53));
            //Dim mainRect As New LinearGradientBrush(ClientRectangle, Color.FromArgb(98, 142, 179), Color.Black, 90S)



            G.Clear(Color.FromArgb(33, 52, 69));
            DrawGradient(Color.FromArgb(3, 13, 32), Color.FromArgb(14, 28, 41), 0, 0, Width, 30, 90);
            G.DrawLine(lineColor, 0, 30, Width, 30);
            DrawGradient(Color.FromArgb(61, 105, 144), Color.FromArgb(33, 52, 69), 0, 30, Width, 30, 90);
            //G.FillRectangle(mainRect, 10, 5, Width - 20, 50)

            //DrawGradient(Color.FromArgb(61, 105, 144), Color.FromArgb(33, 52, 69), 0, Height - 30, Width, Height - 30, 270S)
            //G.DrawLine(lineColor, 0, Height - 30, Width, Height - 30)
            DrawBorders(Pens.LightSteelBlue, Pens.CadetBlue, ClientRectangle);
            DrawText(HorizontalAlignment.Left, Color.FromArgb(204, 231, 250), 5, 3);
        }

        #endregion

        #region Teen

        /// <summary>
        /// Teens the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Teen_PaintHook(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            
            G.Clear(Color.FromArgb(50, 50, 50));
            G.DrawLine(new Pen(Color.DodgerBlue, 2), new Point(0, 30), new Point(Width, 30));
            G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(8, 6, Width - 1, Height - 1), StringFormat.GenericDefault);
            G.DrawLine(new Pen(Color.DodgerBlue, 3), new Point(8, 27), new Point(8 + (int)G.MeasureString(Text, Font).Width, 27));

            G.DrawRectangle(new Pen(Color.FromArgb(100, 100, 100)), new Rectangle(0, 0, Width - 1, Height - 1));

            e.Graphics.DrawImage(B, new Point(0, 0));
            G.Dispose();
            B.Dispose();
        }

        #endregion

        #region Tennis

        /// <summary>
        /// The tennis c1
        /// </summary>
        private Color Tennis_C1 = Color.White;
        /// <summary>
        /// The tennis c2
        /// </summary>
        private Color Tennis_C2 = Color.FromArgb(60, 60, 60);
        /// <summary>
        /// The tennis c3
        /// </summary>
        private Color Tennis_C3 = Color.FromArgb(50, 50, 50);
        /// <summary>
        /// The tennis b1
        /// </summary>
        private SolidBrush Tennis_B1 = new SolidBrush(Color.FromArgb(70, 70, 70));
        /// <summary>
        /// The tennis p1
        /// </summary>
        private Pen Tennis_P1 = new Pen(Color.FromArgb(50, 50, 50));
        /// <summary>
        /// The tennis p2
        /// </summary>
        private Pen Tennis_P2 = new Pen(Color.FromArgb(20, 20, 20));

        /// <summary>
        /// Tennises the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Tennis_PaintHook(PaintEventArgs e)
        {
            G.Clear(Tennis_C1);
            DrawGradient(Color.FromArgb(255, 255, 255), Color.FromArgb(40, 40, 40), 10, 20, Width, Height, 90);
            DrawGradient(Tennis_C2, Tennis_C3, 0, 0, Width, Height);
            G.DrawLine(Tennis_P1, 30, 30, 30, 30);
            G.DrawLine(Tennis_P1, Width - 1, 0, Width - 1, 25);
            G.DrawLine(Tennis_P2, 0, 0, 0, Height);
            G.DrawLine(Tennis_P2, Width - 1, 0, Width - 1, Height);
            G.DrawLine(Tennis_P2, 0, Height - 1, Width, Height - 1);
            HatchBrush T = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(25, 25, 25), Color.FromArgb(35, 35, 35));
            G.FillRectangle(T, 10, 20, Width - 20, Height - 30);
            //G.FillRectangle(New SolidBrush(Color.FromArgb(25, 25, 25)), 10, 20, Width - 20, Height - 30)
            G.DrawLine(Tennis_P2, 0, 0, Width, 0);
            DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
            HatchBrush i = new HatchBrush(HatchStyle.Shingle, Color.FromArgb(25, 25, 25), Color.FromArgb(35, 35, 35));
            G.FillRectangle(i, 10, 20, Width - 20, Height - 30);
        }


        #endregion

        #region TheBlack

        /// <summary>
        /// The black c1
        /// </summary>
        private Color TheBlack_C1 = Color.FromArgb(30,30,30);
        /// <summary>
        /// The black b1
        /// </summary>
        private SolidBrush TheBlack_B1 = new SolidBrush(Color.FromArgb(0, 12, 12));
        /// <summary>
        /// The black b2
        /// </summary>
        private SolidBrush TheBlack_B2 = new SolidBrush(Color.FromArgb(45, 45, 48));
        /// <summary>
        /// The black p1
        /// </summary>
        private Pen TheBlack_P1 = new Pen(Color.FromArgb(29, 28, 27));
        /// <summary>
        /// The black p2
        /// </summary>
        private Pen TheBlack_P2 = new Pen(Color.FromArgb(85, 85, 85));

        /// <summary>
        /// The black p3
        /// </summary>
        private Pen TheBlack_P3 = new Pen(Color.FromArgb(85, 85, 85));

        /// <summary>
        /// Thes the black paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void TheBlack_PaintHook(PaintEventArgs e)
        {
            G.Clear(TheBlack_C1);
            G.FillRectangle(TheBlack_B1, 0, 0, Width, 30);
            G.FillRectangle(TheBlack_B2, 1, Height - 31, Width - 1, 30);
            G.DrawLine(TheBlack_P1, 0, 0, Width, 0);
            G.DrawLine(TheBlack_P1, 0, 0, 0, 29);
            G.DrawLine(TheBlack_P1, 0, 29, Width, 29);
            G.DrawLine(TheBlack_P1, Width - 1, 0, Width - 1, 29);
            G.DrawLine(TheBlack_P2, 0, 30, 0, Height);
            G.DrawLine(TheBlack_P2, Width - 1, 30, Width - 1, Height);
            G.DrawLine(TheBlack_P2, 0, Height - 1, Width, Height - 1);
            G.DrawLine(TheBlack_P3, 1, Height - 32, Width - 2, Height - 32);
            DrawText(Brushes.White, HorizontalAlignment.Left, 5, 3);
        }

        #endregion

        #region Thief

        /// <summary>
        /// The b stripes
        /// </summary>
        private bool _bStripes;
        /// <summary>
        /// Gets or sets a value indicating whether [hatch enable].
        /// </summary>
        /// <value><c>true</c> if [hatch enable]; otherwise, <c>false</c>.</value>
        [Category("Thief Theme")]
        public bool HatchEnable
        {
            get { return _bStripes; }
            set
            {
                _bStripes = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The c style
        /// </summary>
        private bool _cStyle;

        /// <summary>
        /// Gets or sets a value indicating whether [dark theme].
        /// </summary>
        /// <value><c>true</c> if [dark theme]; otherwise, <c>false</c>.</value>
        [Category("Thief Theme")]
        public bool DarkTheme
        {
            get { return _cStyle; }
            set
            {
                _cStyle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The t align
        /// </summary>
        private HorizontalAlignment _tAlign;

        /// <summary>
        /// Gets or sets the title text align.
        /// </summary>
        /// <value>The title text align.</value>
        [Category("Thief Theme")]
        public HorizontalAlignment TitleTextAlign
        {
            get { return _tAlign; }
            set
            {
                _tAlign = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Thiefs the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Thief_PaintHook(PaintEventArgs e)
        {
            int ClientPtA = 0;
            int ClientPtB = 0;
            int GradA = 0;
            int GradB = 0;
            Pen PenColor = default(Pen);
            switch (HatchEnable)
            {
                case true:
                    ClientPtA = 38;
                    ClientPtB = 37;
                    break;
                case false:
                    ClientPtA = 21;
                    ClientPtB = -1;
                    break;
            }
            switch (DarkTheme)
            {
                case true:
                    GradA = 51;
                    GradB = 30;
                    PenColor = Pens.Black;
                    break;
                case false:
                    GradA = 200;
                    GradB = 160;
                    PenColor = Pens.DimGray;
                    break;
            }
            G.Clear(Color.FromArgb(GradA, GradA, GradA));
            DrawGradient(Color.FromArgb(GradA, GradA, GradA), Color.FromArgb(GradB, GradB, GradB), 0, 0, Width, 19, 90);
            switch (HatchEnable)
            {
                case true:
                    DrawGradient(Color.FromArgb(GradB, GradB, GradB), Color.FromArgb(GradA, GradA, GradA), 0, 19, Width, 18, 90);
                    break;
            }
            G.DrawLine(PenColor, 0, 20, Width, 20);
            G.DrawLine(PenColor, 0, ClientPtB, Width, ClientPtB);
            switch (HatchEnable)
            {
                case true:
                    for (int I = 0; I <= Width + 17; I += 4)
                    {
                        G.DrawLine(PenColor, I, 21, I - 17, ClientPtA);
                        G.DrawLine(PenColor, I - 1, 21, I - 18, ClientPtA);
                    }

                    break;
            }
            G.DrawLine(new Pen(new SolidBrush(Color.DodgerBlue)), 0, ClientPtA, Width, ClientPtA);
            G.DrawLine(new Pen(new SolidBrush(Color.DodgerBlue)), 0, Height - 2, Width, Height - 2);
            G.DrawLine(new Pen(new SolidBrush(Color.DodgerBlue)), 1, ClientPtA, 1, Height - 2);
            G.DrawLine(new Pen(new SolidBrush(Color.DodgerBlue)), Width - 2, ClientPtA, Width - 2, Height - 1);
            G.DrawString(".", this.Parent.Font, Brushes.Black, -2, Height - 12);
            G.DrawString(".", this.Parent.Font, Brushes.Black, Width - 5, Height - 12);
            DrawText(TitleTextAlign, Color.DodgerBlue, 6, 0);
            DrawBorders(Pens.Black, Pens.Transparent, ClientRectangle);
            DrawCorners(Color.Fuchsia, ClientRectangle);
        }


        #endregion

        #region Twitch

        /// <summary>
        /// The twitch fill
        /// </summary>
        bool twitch_Fill = true;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Thematic150"/> is fill.
        /// </summary>
        /// <value><c>true</c> if fill; otherwise, <c>false</c>.</value>
        [Category("Twitch Theme")]
        public bool Fill
        {
            get { return twitch_Fill; }
            set
            {
                twitch_Fill = value;
                Invalidate();
            } 
            
        }

        /// <summary>
        /// Twitches the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Twitch_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Red);
            G.FillRectangle(Brushes.White, new Rectangle(0, 0, Width, Height));
            G.FillRectangle(new SolidBrush(Color.FromArgb(40, 40, 40)), new Rectangle(0, 0, Width, 30));
            //G.FillRectangle(New SolidBrush(Color.FromArgb(40, 40, 40)), New Rectangle(0, 30, 10, Height - 30))
            //G.DrawLine(Pens.Black, Width - 11, 30, Width - 10, Height - 30)
            G.FillRectangle(new SolidBrush(Color.FromArgb(40, 40, 40)), new Rectangle(Width - 10, 30, 10, Height - 30));
            //G.DrawLine(Pens.Black, 10, Height - 11, Width - 10, Height - 11)
            G.FillRectangle(new SolidBrush(Color.FromArgb(40, 40, 40)), new Rectangle(0, Height - 10, Width, 10));
            DrawCorners(Color.Fuchsia);
            G.DrawString(Parent.FindForm().Text, Font, Brushes.White, 5, 6);
            if (Fill == true)
            {
                G.FillRectangle(new SolidBrush(Color.FromArgb(40, 40, 40)), new Rectangle(0, 0, Width, Height));
                DrawCorners(Color.Fuchsia);
                G.DrawString(Parent.FindForm().Text, Font, Brushes.White, 5, 6);
            }
        }

        #endregion

        #region Ubuntu

        /// <summary>
        /// Ubuntus the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        void Ubuntu_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            Rectangle TopBar = new Rectangle(0, 0, Width - 1, 30);
            Rectangle FixBottom = new Rectangle(0, 26, Width - 1, 0);
            Rectangle Body = new Rectangle(0, 5, Width - 1, Height - 6);
            
            G.Clear(Color.Fuchsia);

            G.SmoothingMode = SmoothingMode.HighSpeed;

            LinearGradientBrush lbb = new LinearGradientBrush(Body, Color.FromArgb(242, 241, 240), Color.FromArgb(240, 240, 238), 90);
            G.FillPath(lbb, Utilities.Draw.RoundRect(Body, 1));
            G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(60, 60, 60))), Utilities.Draw.RoundRect(Body, 1));

            LinearGradientBrush lgb = new LinearGradientBrush(TopBar, Color.FromArgb(87, 86, 81), Color.FromArgb(60, 59, 55), 90);
            //Dim tophatch As New HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(20, 20, 20), Color.Transparent)
            G.FillPath(lgb, Utilities.Draw.RoundRect(TopBar, 4));
            //G.FillPath(tophatch, Draw.RoundRect(TopBar, 4))
            G.DrawPath(Pens.Black, Utilities.Draw.RoundRect(TopBar, 3));
            G.DrawPath(Pens.Black, Utilities.Draw.RoundRect(FixBottom, 1));
            G.FillRectangle(Brushes.White, 1, 27, Width - 2, Height - 29);

            Font drawFont = new Font("Tahoma", 10, FontStyle.Regular);
            G.DrawString(Text, drawFont, new SolidBrush(Color.WhiteSmoke), new Rectangle(25, 0, Width - 1, 27), new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            });

            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(5, 5, 16, 16));

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            G.Dispose();
            B.Dispose();
        }


        #endregion

        #region Uclear

        /// <summary>
        /// Uclears the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Uclear_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(246, 246, 246));
            LinearGradientBrush LB = new LinearGradientBrush(new Rectangle(new Point(1, 1), new Size(Width - 2, 25)), Color.FromArgb(35, 35, 35), Color.FromArgb(50, 50, 50), 90f);
            G.FillRectangle(LB, new Rectangle(new Point(1, 1), new Size(Width - 2, 25)));
            G.FillRectangle(new SolidBrush(Color.FromArgb(50, 50, 50)), new Rectangle(new Point(1, 1), new Size(Width - 2, 11)));
            G.DrawRectangle(new Pen(Color.FromArgb(35, 35, 35)), new Rectangle(0, 0, Width - 1, Height - 1));
            G.DrawLine(new Pen(Brushes.Black), new Point(0, 25), new Point(Width, 25));

            Font drawFont = new Font("Tahoma", 10, FontStyle.Regular);
            G.DrawString(Text, drawFont, new SolidBrush(Color.WhiteSmoke), new Rectangle(25, 0, Width - 1, 27), new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            });
        }

        #endregion

        #region Uplay

        /// <summary>
        /// The uplay g1
        /// </summary>
        private Color Uplay_G1 = Color.FromArgb(50, 50, 50);
        /// <summary>
        /// The uplay g2
        /// </summary>
        private Color Uplay_G2 = Color.FromArgb(70, 70, 70);
        /// <summary>
        /// Uplays the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Uplay_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(221, 221, 221));

            G.DrawRectangle(new Pen(Color.FromArgb(60, 60, 60)), new Rectangle(0, 0, Width - 1, Height - 1));
            G.DrawLine(new Pen(Color.FromArgb(60, 60, 60)), new Point(0, 26), new Point(Width, 26));
            LinearGradientBrush LB = new LinearGradientBrush(new Rectangle(new Point(1, 1), new Size(Width - 2, 25)), Uplay_G2, Uplay_G1, 90f);
            G.FillRectangle(LB, new Rectangle(new Point(1, 1), new Size(Width - 2, 25)));

            //Draw glow
            G.FillRectangle(new SolidBrush(Uplay_G2), new Rectangle(new Point(1, 1), new Size(Width - 2, 11)));
            G.DrawString(Parent.FindForm().Text, new Font("Segoe UI", 9), Brushes.White, new Point(5, 4));
            switch (_Rounding)
            {
                // thanks to mava
                case RoundingType.TypeOne:
                    //////left upper corner
                    DrawPixel(Color.Fuchsia, 0, 0);
                    DrawPixel(Color.Fuchsia, 1, 0);
                    DrawPixel(Color.Fuchsia, 0, 1);
                    DrawPixel(Color.FromArgb(60, 60, 60), 1, 1);
                    //////right upper corner
                    DrawPixel(Color.Fuchsia, Width - 1, 0);
                    DrawPixel(Color.Fuchsia, Width - 2, 0);
                    DrawPixel(Color.Fuchsia, Width - 1, 1);
                    DrawPixel(Color.FromArgb(60, 60, 60), Width - 2, 1);
                    //////left bottom corner
                    DrawPixel(Color.Fuchsia, 0, Height - 1);
                    DrawPixel(Color.Fuchsia, 1, Height - 1);
                    DrawPixel(Color.Fuchsia, 0, Height - 2);
                    DrawPixel(Color.FromArgb(60, 60, 60), 1, Height - 2);
                    //////right bottom corner
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 2, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 2);
                    DrawPixel(Color.FromArgb(60, 60, 60), Width - 2, Height - 2);
                    break;
                case RoundingType.TypeTwo:
                    //////left upper corner
                    DrawPixel(Color.Fuchsia, 0, 0);
                    DrawPixel(Color.Fuchsia, 1, 0);
                    DrawPixel(Color.Fuchsia, 2, 0);
                    DrawPixel(Color.Fuchsia, 3, 0);
                    DrawPixel(Color.Fuchsia, 0, 1);
                    DrawPixel(Color.Fuchsia, 0, 2);
                    DrawPixel(Color.Fuchsia, 0, 3);
                    DrawPixel(Color.Fuchsia, 1, 1);
                    DrawPixel(Color.FromArgb(60, 60, 60), 2, 1);
                    DrawPixel(Color.FromArgb(60, 60, 60), 3, 1);
                    DrawPixel(Color.FromArgb(60, 60, 60), 1, 2);
                    DrawPixel(Color.FromArgb(60, 60, 60), 1, 3);
                    //////right upper corner
                    DrawPixel(Color.Fuchsia, Width - 1, 0);
                    DrawPixel(Color.Fuchsia, Width - 2, 0);
                    DrawPixel(Color.Fuchsia, Width - 3, 0);
                    DrawPixel(Color.Fuchsia, Width - 4, 0);
                    DrawPixel(Color.Fuchsia, Width - 1, 1);
                    DrawPixel(Color.Fuchsia, Width - 1, 2);
                    DrawPixel(Color.Fuchsia, Width - 1, 3);
                    DrawPixel(Color.Fuchsia, Width - 2, 1);
                    DrawPixel(Color.FromArgb(60, 60, 60), Width - 3, 1);
                    DrawPixel(Color.FromArgb(60, 60, 60), Width - 4, 1);
                    DrawPixel(Color.FromArgb(60, 60, 60), Width - 2, 2);
                    DrawPixel(Color.FromArgb(60, 60, 60), Width - 2, 3);
                    //////left bottom corner
                    DrawPixel(Color.Fuchsia, 0, Height - 1);
                    DrawPixel(Color.Fuchsia, 0, Height - 2);
                    DrawPixel(Color.Fuchsia, 0, Height - 3);
                    DrawPixel(Color.Fuchsia, 0, Height - 4);
                    DrawPixel(Color.Fuchsia, 1, Height - 1);
                    DrawPixel(Color.Fuchsia, 2, Height - 1);
                    DrawPixel(Color.Fuchsia, 3, Height - 1);
                    DrawPixel(Color.Fuchsia, 1, Height - 2);
                    DrawPixel(Color.FromArgb(60, 60, 60), 2, Height - 2);
                    DrawPixel(Color.FromArgb(60, 60, 60), 3, Height - 2);
                    DrawPixel(Color.FromArgb(60, 60, 60), 1, Height - 3);
                    DrawPixel(Color.FromArgb(60, 60, 60), 1, Height - 4);
                    //////right bottom corner
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 2);
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 3);
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 4);
                    DrawPixel(Color.Fuchsia, Width - 2, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 3, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 4, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 2, Height - 2);
                    DrawPixel(Color.FromArgb(60, 60, 60), Width - 3, Height - 2);
                    DrawPixel(Color.FromArgb(60, 60, 60), Width - 4, Height - 2);
                    DrawPixel(Color.FromArgb(60, 60, 60), Width - 2, Height - 3);
                    DrawPixel(Color.FromArgb(60, 60, 60), Width - 2, Height - 4);
                    break;
            }


        }

        #endregion

        #region VTheme

        /// <summary>
        /// vs the theme paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void VTheme_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(12, 12, 12));
            Pen P = new Pen(Color.FromArgb(32, 32, 32));
            G.DrawLine(P, 11, 31, Width - 12, 31);
            G.DrawLine(P, 11, 8, Width - 12, 8);
            G.FillRectangle(new LinearGradientBrush(new Rectangle(8, 38, Width - 16, Height - 46), Color.FromArgb(12, 12, 12), Color.FromArgb(18, 18, 18), LinearGradientMode.BackwardDiagonal), 8, 38, Width - 16, Height - 46);
            DrawText(Brushes.White, HorizontalAlignment.Left, 25, 6);
            DrawBorders(new Pen(Color.FromArgb(60, 60, 60)), 1);
            DrawBorders(Pens.Black);

            P = new Pen(Color.FromArgb(25, 25, 25));
            G.DrawLine(Pens.Black, 6, 0, 6, Height - 6);
            G.DrawLine(Pens.Black, Width - 6, 0, Width - 6, Height - 6);
            G.DrawLine(P, 6, 0, 6, Height - 6);
            G.DrawLine(P, Width - 8, 0, Width - 8, Height - 6);

            G.DrawRectangle(Pens.Black, 11, 4, Width - 23, 22);
            G.DrawLine(P, 6, Height - 6, Width - 8, Height - 6);
            G.DrawLine(Pens.Black, 6, Height - 8, Width - 8, Height - 8);
            DrawCorners(Color.Fuchsia);
        }

        #endregion

        #region Visceral

        /// <summary>
        /// Viscerals the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        void Visceral_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            Rectangle TopBar = new Rectangle(0, 0, Width - 1, 30);
            Rectangle Body = new Rectangle(0, 10, Width - 1, Height - 1);
            
            G.Clear(Color.Fuchsia);

            //G.SmoothingMode = SmoothingMode.HighQuality

            LinearGradientBrush lbb = new LinearGradientBrush(Body, Color.FromArgb(19, 19, 19), Color.FromArgb(17, 17, 17), 90);
            HatchBrush bodyhatch = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(20, 20, 20), Color.Transparent);
            G.FillPath(lbb, Utilities.Draw.RoundRect(Body, 5));
            G.FillPath(bodyhatch, Utilities.Draw.RoundRect(Body, 5));
            G.DrawPath(Pens.Black, Utilities.Draw.RoundRect(Body, 5));


            LinearGradientBrush lgb = new LinearGradientBrush(TopBar, Color.FromArgb(60, 60, 62), Color.FromArgb(25, 25, 25), 90);
            //Dim tophatch As New HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(20, 20, 20), Color.Transparent)
            G.FillPath(lgb, Utilities.Draw.RoundRect(TopBar, 4));
            //G.FillPath(tophatch, Draw.RoundRect(TopBar, 4))
            G.DrawPath(Pens.Black, Utilities.Draw.RoundRect(TopBar, 4));
            G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(33, 0, Width - 1, 30), new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            });

            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(11, 8, 16, 16));

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            G.Dispose();
            B.Dispose();
        }


        #endregion

        #region Vitality

        /// <summary>
        /// The vitality g1
        /// </summary>
        Color Vitality_G1 = Color.White;
        /// <summary>
        /// The vitality g2
        /// </summary>
        Color Vitality_G2 = Color.LightGray;

        /// <summary>
        /// The vitality bg
        /// </summary>
        Color Vitality_BG = Color.FromArgb(240, 240, 240);

        /// <summary>
        /// Vitalities the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Vitality_PaintHook(PaintEventArgs e)
        {
            G.Clear(Vitality_BG);

            LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(new Point(1, 1), new Size(this.Width - 2, 23)), Vitality_G1, Vitality_G2, 90f);
            G.FillRectangle(LGB, new Rectangle(new Point(1, 1), new Size(this.Width - 2, 23)));

            G.DrawLine(Pens.LightGray, 1, 25, this.Width - 2, 25);
            G.DrawLine(Pens.White, 1, 26, this.Width - 2, 26);

            DrawCorners(TransparencyKey);
            DrawBorders(Pens.LightGray, 1);

            Rectangle IconRec = new Rectangle(3, 3, 20, 20);
            G.DrawIcon(ParentForm.Icon, IconRec);

            G.DrawString(ParentForm.Text, new Font("Segoe UI", 9), Brushes.Gray, new Point(25, 5));
        }

        #endregion

        #region Vs

        /// <summary>
        /// The vs c1
        /// </summary>
        Color Vs_C1 = Color.FromArgb(249, 245, 226);
        /// <summary>
        /// The vs c2
        /// </summary>
        Color Vs_C2 = Color.FromArgb(255, 232, 165);
        /// <summary>
        /// The vs c3
        /// </summary>
        Color Vs_C3 = Color.FromArgb(64, 90, 127);
        /// <summary>
        /// The vs tile
        /// </summary>
        Image Vs_Tile;

        /// <summary>
        /// Vses the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        void Vs_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {
            _TitleHeight = 23;
            using (Bitmap B = new Bitmap(3, 3))
            {
                using (Graphics G = Graphics.FromImage(B))
                {
                    G.Clear(Color.FromArgb(53, 67, 88));
                    G.DrawLine(new Pen(Color.FromArgb(33, 46, 67)), 0, 0, 2, 2);
                    Vs_Tile = (Bitmap)B.Clone();
                }
            }

            using (Bitmap B = new Bitmap(Width, Height))
            {
                using (Graphics G = Graphics.FromImage(B))
                {

                    using (TextureBrush T = new TextureBrush(Vs_Tile, 0))
                    {
                        G.FillRectangle(T, 0, _TitleHeight, Width, Height - _TitleHeight);
                    }
                    Utilities.Draw.Blend(G, Color.Transparent, Color.Transparent, Vs_C3, 0.1f, 1, 0, 0, Width, Height - _TitleHeight * 2);
                    G.FillRectangle(new SolidBrush(Vs_C3), 0, Height - _TitleHeight * 2, Width, _TitleHeight * 2);

                    Utilities.Draw.Gradient(G, Vs_C1, Vs_C2, 0, 0, Width, _TitleHeight);
                    G.FillRectangle(new SolidBrush(Color.FromArgb(100, 255, 255, 255)), 0, 0, Width, Convert.ToInt32(_TitleHeight / 2));

                    G.DrawRectangle(new Pen(Vs_C2, 2), 1, _TitleHeight - 1, Width - 2, Height - _TitleHeight);
                    G.DrawArc(new Pen(Color.Fuchsia, 2), -1, -1, 9, 9, 180, 90);
                    G.DrawArc(new Pen(Color.Fuchsia, 2), Width - 9, -1, 9, 9, 270, 90);

                    G.TextRenderingHint = (TextRenderingHint)5;
                    SizeF S = G.MeasureString(Text, Font);
                    int O = 6;
                    if (_TitleAlign == (HorizontalAlignment)2)
                        O = (int)Width / 2 - (int)S.Width / 2;
                    if (_TitleAlign == (HorizontalAlignment)1)
                        O = Width - (int)S.Width - 6;
                    G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(111, 88, 38)), O, Convert.ToInt32(_TitleHeight / 2 - S.Height / 2));

                    e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
                }
            }
        }


        #endregion

        #region White
        /// <summary>
        /// The white p1
        /// </summary>
        Pen White_P1 = new Pen(Color.FromArgb(225, 225, 225));
        /// <summary>
        /// The white p2
        /// </summary>
        Pen White_P2 = new Pen(Color.FromArgb(150, 150, 150));
        /// <summary>
        /// The white c1
        /// </summary>
        Color White_c1 = Color.FromArgb(225, 225, 225);
        /// <summary>
        /// The white c2
        /// </summary>
        Color White_c2 = Color.FromArgb(185, 185, 185);

        /// <summary>
        /// The white tr
        /// </summary>
        Color White_tr;

        /// <summary>
        /// Whites the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void White_PaintHook(PaintEventArgs e)
        {
            //Header = 20;
            G.Clear(Color.FromArgb(250, 250, 250));
            DrawBorders(White_P1, 1);

            DrawGradient(White_c1, White_c2, 0, 0, Width, 20);
            HatchBrush DarkDown = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.Transparent, Color.FromArgb(50, Color.FromArgb(75, 75, 75)));
            HatchBrush DarkUp = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.Transparent, Color.FromArgb(50, Color.FromArgb(75, 75, 75)));
            //G.FillRectangle(DarkDown, New Rectangle(0, 0, ClientRectangle.Width, Header))
            G.FillRectangle(DarkUp, new Rectangle(0, 0, ClientRectangle.Width, Header));


            DrawBorders(White_P2, 0);

            G.DrawLine(White_P2, 0, 20, Width, 20);
            G.DrawLine(White_P1, 0, 21, Width, 21);
            G.DrawLine(White_P1, 0, 22, Width, 22);
            G.DrawLine(White_P2, 0, 23, Width, 23);

            DrawText(Brushes.DarkBlue, HorizontalAlignment.Left, 5, 1);

            DrawCorners(TransparencyKey);
        }

        #endregion

        #region Winter
        /// <summary>
        /// The winter header
        /// </summary>
        private int Winter_Header = 13;
        /// <summary>
        /// Winters the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Winter_PaintHook(PaintEventArgs e)
        {
            
            G.Clear(Color.FromArgb(40, 40, 40));
            G.FillRectangle(new SolidBrush(Color.FromArgb(211, 222, 228)), new Rectangle(0, Winter_Header, Width, Height - Winter_Header));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(0, 0, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(1, 0, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(0, 1, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(Width - 1, 0, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(Width - 2, 0, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(Width - 1, 1, 1, 1));

            StringFormat _StringF = new StringFormat();
            _StringF.Alignment = StringAlignment.Center;
            _StringF.LineAlignment = StringAlignment.Center;
            G.DrawString(Text, new Font("Segoe UI", 11), Brushes.White, new RectangleF(0, 0, Width, Winter_Header), _StringF);
        }



        #endregion

        #region Xbox

        /// <summary>
        /// Xboxes the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Xbox_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(20, 20, 20));
            DrawGradient(Color.FromArgb(48, 255, 0), (Color.FromArgb(42, 218, 2)), 0, 0, Width, 20, 90);
            DrawGradient(Color.GhostWhite, Color.LightGray, 0, 20, Width, Height - 20, 90);
            G.DrawLine(Pens.DarkGray, 0, 20, Width, 20);
            DrawGradient(Color.DarkGreen, (Color.FromArgb(18, 255, 0)), 0, 0, Width, 20, 90);
            G.DrawLine(Pens.Green, 0, 20, Width, 20);
            DrawBorders(Pens.Black, Pens.DarkGreen, ClientRectangle);
            DrawCorners(Color.DarkGreen, ClientRectangle);
            DrawText(HorizontalAlignment.Center, Color.FromArgb(210, 210, 210), 0);
        }

        #endregion

        #region Xtreme

        /// <summary>
        /// Xtremes the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Xtreme_PaintHook(PaintEventArgs e)
        {
            //Body
            G.Clear(Color.FromArgb(30, 30, 30));
            G.FillRectangle(Brushes.Fuchsia, 0, 0, Width, 5);
            DrawBorders(Pens.Black, 0, 30, Width, Height);

            //HeaderShadow
            DrawGradient(Color.Black, Color.FromArgb(30, 30, 30), 1, 28, Width, 10);

            //BottomBody
            DrawGradient(Color.FromArgb(30, 30, 30), Color.Black, 0, Height - 23, Width, 10);
            DrawGradient(Color.FromArgb(0, 0, 0), Color.FromArgb(57, 57, 58), 0, Height - 12, Width / 2, Height, 360);
            DrawGradient(Color.FromArgb(0, 0, 0), Color.FromArgb(57, 57, 58), Width / 2, Height - 12, Width / 2, Height, 180);
            G.DrawLine(Pens.Black, 0, Height - 13, Width, Height - 13);
            G.DrawLine(new Pen(Color.FromArgb(57, 57, 58)), Width / 2, Height - 11, Width / 2, Height);


            //LeftSideBody
            G.FillRectangle(Brushes.Black, 0, 30, 8, Height);
            DrawBorders(Pens.Black, 1, 30, 9, Height - 2);
            G.DrawLine(new Pen(Color.FromArgb(40, 40, 40)), 8, 30, 8, Height);

            //RightSideBody
            G.FillRectangle(Brushes.Black, Width - 9, 30, 11, Height - 20);
            DrawBorders(Pens.Black, Width - 10, 30, 11, Height - 2);
            G.DrawLine(new Pen(Color.FromArgb(60, 60, 60)), Width - 9, 30, Width - 9, Height);



            //Header
            G.FillRectangle(Brushes.Black, 0, 5, Width, 24);
            DrawText(Brushes.Red, HorizontalAlignment.Left, 55, 2);
            G.FillRectangle(new SolidBrush(Color.FromArgb(50, Color.White)), 0, 5, Width - 1, 11);
            DrawBorders(Pens.Black, 1, 4, Width - 2, 24);
            G.DrawLine(new Pen(Color.FromArgb(108, 108, 108)), 1, 5, Width, 5);
            G.DrawLine(new Pen(Color.FromArgb(60, 60, 60)), 1, 28, Width - 2, 28);
            G.DrawLine(Pens.Black, 1, 30, Width - 3, 30);

            //-----------------------------------------------------
            //Box
            DrawBorders(Pens.Black, 8, 0, 34, 32);
            DrawGradient(Color.FromArgb(57, 57, 58), Color.FromArgb(2, 4, 12), 9, 1, 32, 16);
            DrawGradient(Color.FromArgb(2, 4, 23), Color.FromArgb(57, 57, 58), 9, 15, 32, 16);
            //Lines
            //if (!((Icon == null))) {
            //	G.DrawIcon(Icon, new Rectangle(10, 0, 32, 32));
            //} else {
            //	G.DrawIcon(Icon, new Rectangle(10, 0, 32, 32));
            //}


            DrawImage(HorizontalAlignment.Left, 9, 1);

            //Gloss
            G.FillRectangle(new SolidBrush(Color.FromArgb(15, Color.White)), 10, 2, 31, 13);
            //------------------------------------------------------

            //SideBoxes
            DrawGradient(Color.FromArgb(10, 10, 10), Color.FromArgb(47, 47, 47), 42, 2, 5, 15);
            DrawGradient(Color.FromArgb(47, 47, 47), Color.FromArgb(10, 10, 10), 42, 15, 5, 15);
            DrawGradient(Color.FromArgb(47, 47, 47), Color.FromArgb(10, 10, 10), 3, 2, 5, 15);
            DrawGradient(Color.FromArgb(10, 10, 10), Color.FromArgb(47, 47, 47), 3, 15, 5, 15);
            DrawBorders(Pens.Black, 42, 2, 5, 29);
            DrawBorders(Pens.Black, 3, 2, 5, 29);
            G.DrawLine(Pens.Black, 3, 15, 7, 15);
            G.DrawLine(Pens.Black, 42, 15, 46, 15);

            //Animation


            //Icon

            G.DrawLine(Pens.Black, 0, Height - 1, Width, Height - 1);
            DrawCorners(Color.Fuchsia);
        }

        #endregion

        #region xVisual

        /// <summary>
        /// The top texture
        /// </summary>
        TextureBrush TopTexture = Utilities.Draw.NoiseBrush(new Color[]{
            Color.FromArgb(66, 64, 62),
            Color.FromArgb(63, 61, 59),
            Color.FromArgb(69, 67, 65)
        });

        /// <summary>
        /// The inner texture
        /// </summary>
        TextureBrush InnerTexture = Utilities.Draw.NoiseBrush(new Color[]{
            Color.FromArgb(57, 53, 50),
            Color.FromArgb(56, 52, 49),
            Color.FromArgb(58, 55, 51)
        });

        /// <summary>
        /// The draw font
        /// </summary>
        Font drawFont = new Font("Arial", 11, FontStyle.Bold);

        /// <summary>
        /// xes the visual paint hook.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        void xVisual_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {

            G.Clear(Color.Fuchsia);

            Rectangle mainRect = new Rectangle(0, 0, Width, Height);
            LinearGradientBrush LeftHighlight = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(66, 64, 63), Color.FromArgb(56, 54, 53), 90);
            LinearGradientBrush RightHighlight = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(80, 78, 77), Color.FromArgb(70, 68, 67), 90);
            LinearGradientBrush TopOverlay = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, 53), Color.FromArgb(15, Color.White), Color.FromArgb(100, Color.FromArgb(43, 40, 38)), 90);

            LinearGradientBrush mainGradient = new LinearGradientBrush(mainRect, Color.FromArgb(73, 71, 69), Color.FromArgb(69, 67, 64), 90);
            G.FillRectangle(mainGradient, mainRect);
            //Outside Rectangle
            G.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));

            G.FillRectangle(InnerTexture, new Rectangle(10, 53, Width - 21, Height - 84));
            //Inner Rectangle
            G.DrawRectangle(Pens.Black, new Rectangle(10, 53, Width - 21, Height - 84));

            G.FillRectangle(TopTexture, new Rectangle(0, 0, Width - 1, 53));
            //Top Bar Rectangle
            G.FillRectangle(TopOverlay, new Rectangle(0, 0, Width - 1, 53));
            G.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, 53));

            ColorBlend blend = new ColorBlend();

            //Add the Array of Color
            Color[] bColors = new Color[] {
                Color.FromArgb(10, Color.White),
                Color.FromArgb(10, Color.Black),
                Color.FromArgb(10, Color.White)
            };
            blend.Colors = bColors;

            //Add the Array Single (0-1) colorpoints to place each Color
            float[] bPts = new float[] {
                0,
                0.7f,
                1
            };
            blend.Positions = bPts;

            Rectangle rect = new Rectangle(0, 0, Width - 1, 53);
            using (LinearGradientBrush br = new LinearGradientBrush(rect, Color.White, Color.Black, LinearGradientMode.Vertical))
            {

                //Blend the colors into the Brush
                br.InterpolationColors = blend;

                //Fill the rect with the blend
                G.FillRectangle(br, rect);

            }

            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(173, 172, 172)), 4, 1, Width - 5, 1);
            //Top Middle Highlight
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(110, 109, 107)), 11, Height - 30, Width - 12, Height - 30);
            //Bottom Middle Highlight

            G.FillRectangle(Utilities.Draw.GetBrush(Color.FromArgb(173, 172, 172)), 3, 2, 1, 1);
            //Top Left Corner Highlight
            G.FillRectangle(Utilities.Draw.GetBrush(Color.FromArgb(133, 132, 132)), 2, 2, 1, 1);
            G.FillRectangle(Utilities.Draw.GetBrush(Color.FromArgb(113, 112, 112)), 2, 3, 1, 1);
            G.FillRectangle(Utilities.Draw.GetBrush(Color.FromArgb(83, 82, 82)), 1, 4, 1, 1);

            G.FillRectangle(Utilities.Draw.GetBrush(Color.FromArgb(173, 172, 172)), Width - 4, 2, 1, 1);
            //Top Right Corner Highlight
            G.FillRectangle(Utilities.Draw.GetBrush(Color.FromArgb(133, 132, 132)), Width - 3, 2, 1, 1);
            G.FillRectangle(Utilities.Draw.GetBrush(Color.FromArgb(113, 112, 112)), Width - 3, 3, 1, 1);
            G.FillRectangle(Utilities.Draw.GetBrush(Color.FromArgb(83, 82, 82)), Width - 2, 4, 1, 1);

            //// Shadows
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(91, 90, 89)), 1, 52, Width - 2, 52);
            //Middle Top Horizontal
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(40, 37, 34)), 11, 54, Width - 12, 54);
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(45, 42, 39)), 11, 55, Width - 12, 55);
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(50, 47, 44)), 11, 56, Width - 12, 56);

            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(50, 47, 44)), 11, Height - 32, Width - 12, Height - 32);
            //Middle Bottom Horizontal
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(52, 49, 46)), 11, Height - 33, Width - 12, Height - 33);
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(54, 51, 48)), 11, Height - 34, Width - 12, Height - 34);


            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(59, 57, 55)), 1, 54, 9, 54);
            //Left Horizontal
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(64, 62, 60)), 1, 55, 9, 55);
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(73, 71, 69)), 1, 56, 9, 56);

            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(59, 57, 55)), Width - 10, 54, Width - 2, 54);
            //Right Horizontal
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(64, 62, 60)), Width - 10, 55, Width - 2, 55);
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(73, 71, 69)), Width - 10, 56, Width - 2, 56);

            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(59, 57, 55)), 1, 54, 1, Height - 5);
            //Left Vertical
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(64, 62, 60)), 2, 55, 2, Height - 4);
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(73, 71, 69)), 3, 56, 3, Height - 3);
            G.DrawLine(new Pen(LeftHighlight), 1, 5, 1, 51);
            G.DrawLine(new Pen(RightHighlight), 2, 5, 2, 51);
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(69, 67, 65)), 9, 56, 9, Height - 31);

            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(59, 57, 55)), Width - 2, 54, Width - 2, Height - 5);
            //Right Vertical
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(64, 62, 60)), Width - 3, 55, Width - 3, Height - 4);
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(73, 71, 69)), Width - 4, 56, Width - 4, Height - 3);
            G.DrawLine(new Pen(LeftHighlight), Width - 2, 5, Width - 2, 51);
            G.DrawLine(new Pen(RightHighlight), Width - 3, 5, Width - 3, 51);
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(69, 67, 65)), Width - 10, 56, Width - 10, Height - 31);

            G.DrawString(Text, drawFont, new SolidBrush(Color.FromArgb(255, 255, 255)), new Rectangle(0, 0, Width, 37), new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            });

            //////left upper corner
            G.FillRectangle(Brushes.Fuchsia, 0, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 1, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 2, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 3, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 0, 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 0, 2, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 0, 3, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 1, 1, 1, 1);

            G.FillRectangle(Brushes.Black, 1, 3, 1, 1);
            G.FillRectangle(Brushes.Black, 1, 2, 1, 1);
            G.FillRectangle(Brushes.Black, 2, 1, 1, 1);
            G.FillRectangle(Brushes.Black, 3, 1, 1, 1);
            //'////right upper corner
            G.FillRectangle(Brushes.Fuchsia, Width - 1, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 2, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 3, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 4, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 1, 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 1, 2, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 1, 3, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 2, 1, 1, 1);

            G.FillRectangle(Brushes.Black, Width - 2, 3, 1, 1);
            G.FillRectangle(Brushes.Black, Width - 2, 2, 1, 1);
            G.FillRectangle(Brushes.Black, Width - 3, 1, 1, 1);
            G.FillRectangle(Brushes.Black, Width - 4, 1, 1, 1);
            //'////left bottom corner
            G.FillRectangle(Brushes.Fuchsia, 0, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 0, Height - 2, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 0, Height - 3, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 0, Height - 4, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 1, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 2, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 3, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 1, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 1, Height - 2, 1, 1);

            G.FillRectangle(Brushes.Black, 1, Height - 3, 1, 1);
            G.FillRectangle(Brushes.Black, 1, Height - 4, 1, 1);
            G.FillRectangle(Brushes.Black, 3, Height - 2, 1, 1);
            G.FillRectangle(Brushes.Black, 2, Height - 2, 1, 1);
            //'////right bottom corner
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 2, Height, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 3, Height, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 4, Height, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 2, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 3, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 2, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 3, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 4, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 4, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 2, Height - 2, 1, 1);

            G.FillRectangle(Brushes.Black, Width - 2, Height - 3, 1, 1);
            G.FillRectangle(Brushes.Black, Width - 2, Height - 4, 1, 1);
            G.FillRectangle(Brushes.Black, Width - 4, Height - 2, 1, 1);
            G.FillRectangle(Brushes.Black, Width - 3, Height - 2, 1, 1);

        }

        #endregion

        #region Youtube

        /// <summary>
        /// Youtubes the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Youtube_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.White);
            DrawGradient(Color.DarkRed, Color.Red, 0, 0, Width, 20, 90);
            DrawGradient(Color.White, Color.LightGray, 0, 20, Width, Height - 25, 90);
            DrawGradient(Color.DarkRed, Color.Red, 0, Height - 25, Width, Height + 25 - Height, 90);
            DrawGradient(Color.DarkRed, Color.Red, 0, Height + 25 - Height - 5, 10, Height - 45, 180);
            DrawGradient(Color.Red, Color.DarkRed, Width - 10, Height + 25 - Height - 5, 10, Height - 45, 180);
            DrawCorners(Color.Fuchsia, ClientRectangle);
            DrawText(HorizontalAlignment.Center, ForeColor, 3);
            DrawBorders(Pens.DarkRed, Pens.White, ClientRectangle);
        }

        #endregion

        #region Zeus

        /// <summary>
        /// Zeuses the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Zeus_PaintHook(PaintEventArgs e)
        {
            Color C1 = Color.FromArgb(38, 38, 38);
            Color C2 = Color.AliceBlue;
            Pen P1 = Pens.Black;
            Pen P2 = Pens.AliceBlue;


            G.Clear(C1);
            G.DrawLine(P2, 50, 0, 0, 50);
            G.DrawLine(P2, Width - 50, 0, Width, 50);
            G.DrawLine(P2, 50, 20, Width - 50, 20);
            G.DrawLine(P2, 70, 0, 50, 20);
            G.DrawLine(P2, Width - 70, 0, Width - 50, 20);
            G.DrawLine(P2, 0, 75, 35, 40);
            G.DrawLine(P2, Width - 35, 40, Width, 75);
            G.DrawLine(P2, 35, 40, Width - 35, 40);
            G.DrawRectangle(P2, 15, 75, Width - 30, Height - 90);
            G.DrawString("<<>>", this.Font, Brushes.AliceBlue, Width - 32, 0);
            G.DrawString("<<>>", this.Font, Brushes.AliceBlue, 8, 0);
            DrawBorders(P1, P2, ClientRectangle);
            DrawText(HorizontalAlignment.Center, C2, 0);

        }


        #endregion

        #region Resizable

        #region Private Fields
        /// <summary>
        /// The c grip
        /// </summary>
        private int cGrip = 10;      // Grip size
        /// <summary>
        /// The c caption
        /// </summary>
        private int cCaption = 32;   // Caption bar height;
        /// <summary>
        /// The border width
        /// </summary>
        private int borderWidth = 1;

        /// <summary>
        /// The header
        /// </summary>
        private Color header = Color.Transparent;
        /// <summary>
        /// The border color
        /// </summary>
        private Color borderColor = Color.Red;

        /// <summary>
        /// The background color1
        /// </summary>
        private Color backgroundColor1 = Color.DarkSeaGreen;
        /// <summary>
        /// The background color
        /// </summary>
        private Color backgroundColor = Color.Orange;


        /// <summary>
        /// The default shadow
        /// </summary>
        private bool defaultShadow = true;

        /// <summary>
        /// The shadow
        /// </summary>
        private bool shadow = false;
        /// <summary>
        /// The interval
        /// </summary>
        private int interval = 100;

        #region Include in Private Field (Color Blend)
        /// <summary>
        /// The blend positions
        /// </summary>
        private float[] blendPositions = new float[11];

        /// <summary>
        /// The color blends
        /// </summary>
        private Color[] colorBlends = new Color[11];

        /// <summary>
        /// The gamma correction
        /// </summary>
        private bool gammaCorrection = false;

        /// <summary>
        /// The wrap mode
        /// </summary>
        private WrapMode wrapMode = WrapMode.Clamp;

        /// <summary>
        /// The enable color blend
        /// </summary>
        private bool enableColorBlend = false;

        /// <summary>
        /// The angle
        /// </summary>
        private float angle = 90f;

        /// <summary>
        /// The blend rotate
        /// </summary>
        private float blendRotate = 0f;

        /// <summary>
        /// The handle draw dash style
        /// </summary>
        private DashStyle handleDrawDashStyle = DashStyle.Dot;

        /// <summary>
        /// The handle border width
        /// </summary>
        private int handleBorderWidth = 1;

        /// <summary>
        /// The handle color border
        /// </summary>
        private Color handleColorBorder = Color.Black;

        /// <summary>
        /// Enum drawMode
        /// </summary>
        public enum drawMode { Solid, Gradient, Hatch }

        /// <summary>
        /// The draw mode
        /// </summary>
        private drawMode _drawMode = drawMode.Solid;


        #endregion

        #endregion

        #region Include in Private Field


        /// <summary>
        /// The automatic animate
        /// </summary>
        private bool autoAnimate = false;
        /// <summary>
        /// The timer
        /// </summary>
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        #endregion

        #region Include in Public Properties

        /// <summary>
        /// Gets or sets a value indicating whether [automatic animate].
        /// </summary>
        /// <value><c>true</c> if [automatic animate]; otherwise, <c>false</c>.</value>
        [Category("Resizable Theme")]
        public bool AutoAnimate
        {
            get { return autoAnimate; }
            set
            {
                autoAnimate = value;

                if (value == true)
                {
                    timer.Enabled = true;
                }

                else
                {
                    timer.Enabled = false;
                }

                Invalidate();
            }
        }

        #endregion

        #region Public Properties

        #region Include in Public Properties (Color Blend)

        /// <summary>
        /// Gets or sets the angle.
        /// </summary>
        /// <value>The angle.</value>
        [Category("Resizable Theme")]
        public float Angle
        {
            get { return angle; }
            set
            {
                angle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [enable color blend].
        /// </summary>
        /// <value><c>true</c> if [enable color blend]; otherwise, <c>false</c>.</value>
        [Category("Resizable Theme")]
        public bool EnableColorBlend
        {
            get { return enableColorBlend; }
            set
            {
                enableColorBlend = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the wrap mode.
        /// </summary>
        /// <value>The wrap mode.</value>
        [Category("Resizable Theme")]
        public WrapMode WrapMode
        {
            get { return wrapMode; }
            set
            {
                wrapMode = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [gamma correction].
        /// </summary>
        /// <value><c>true</c> if [gamma correction]; otherwise, <c>false</c>.</value>
        [Category("Resizable Theme")]
        public bool GammaCorrection
        {
            get { return gammaCorrection; }
            set
            {
                gammaCorrection = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color blends.
        /// </summary>
        /// <value>The color blends.</value>
        [Category("Resizable Theme")]
        public Color[] ColorBlends
        {
            get { return colorBlends; }
            set
            {
                colorBlends = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the blend positions.
        /// </summary>
        /// <value>The blend positions.</value>
        [Category("Resizable Theme")]
        public float[] BlendPositions
        {
            get { return blendPositions; }
            set
            {
                for (int x = 1; x <= 10; x++)
                {
                    if (blendPositions[x] > 1.0f)
                    {
                        blendPositions[x] = 1.0f;
                    }
                }

                #region Old Code
                //if (blendPositions[0] > 1.0f)
                //{
                //    blendPositions[0] = 1.0f;
                //    Invalidate();
                //}

                //if (blendPositions[1] > 1.0f)
                //{
                //    blendPositions[1] = 1.0f;
                //    Invalidate();
                //}

                //if (blendPositions[2] > 1.0f)
                //{
                //    blendPositions[2] = 1.0f;
                //    Invalidate();
                //}

                //if (blendPositions[3] > 1.0f)
                //{
                //    blendPositions[3] = 1.0f;
                //    Invalidate();
                //}

                //if (blendPositions[4] > 1.0f)
                //{
                //    blendPositions[4] = 1.0f;
                //    Invalidate();
                //}

                //if (blendPositions[5] > 1.0f)
                //{
                //    blendPositions[5] = 1.0f;
                //    Invalidate();
                //}

                //if (blendPositions[6] > 1.0f)
                //{
                //    blendPositions[6] = 1.0f;
                //    Invalidate();
                //}

                //if (blendPositions[7] > 1.0f)
                //{
                //    blendPositions[7] = 1.0f;
                //    Invalidate();
                //}

                //if (blendPositions[8] > 1.0f)
                //{
                //    blendPositions[8] = 1.0f;
                //    Invalidate();
                //}

                //if (blendPositions[9] > 1.0f)
                //{
                //    blendPositions[9] = 1.0f;
                //    Invalidate();
                //} 
                #endregion

                blendPositions = value;

                Invalidate();
            }
        }

        #endregion


        #region HatchBrush

        /// <summary>
        /// The hatch brushgradient1
        /// </summary>
        private Color hatchBrushgradient1 = Color.Black;
        /// <summary>
        /// The hatch brushgradient2
        /// </summary>
        private Color hatchBrushgradient2 = Color.Transparent;

        /// <summary>
        /// The hatch brush type
        /// </summary>
        private HatchBrushType hatchBrushType = HatchBrushType.ForwardDiagonal;

        /// <summary>
        /// Enum HatchBrushType
        /// </summary>
        public enum HatchBrushType
        {
            /// <summary>
            /// The backward diagonal
            /// </summary>
            BackwardDiagonal,
            /// <summary>
            /// The cross
            /// </summary>
            Cross,
            /// <summary>
            /// The dark downward diagonal
            /// </summary>
            DarkDownwardDiagonal,
            /// <summary>
            /// The dark horizontal
            /// </summary>
            DarkHorizontal,
            /// <summary>
            /// The dark upward diagonal
            /// </summary>
            DarkUpwardDiagonal,
            /// <summary>
            /// The dark vertical
            /// </summary>
            DarkVertical,
            /// <summary>
            /// The dashed downward diagonal
            /// </summary>
            DashedDownwardDiagonal,
            /// <summary>
            /// The dashed horizontal
            /// </summary>
            DashedHorizontal,
            /// <summary>
            /// The dashed upward diagonal
            /// </summary>
            DashedUpwardDiagonal,
            /// <summary>
            /// The dashed vertical
            /// </summary>
            DashedVertical,
            /// <summary>
            /// The diagonal brick
            /// </summary>
            DiagonalBrick,
            /// <summary>
            /// The diagonal cross
            /// </summary>
            DiagonalCross,
            /// <summary>
            /// The divot
            /// </summary>
            Divot,
            /// <summary>
            /// The dotted diamond
            /// </summary>
            DottedDiamond,
            /// <summary>
            /// The dotted grid
            /// </summary>
            DottedGrid,
            /// <summary>
            /// The forward diagonal
            /// </summary>
            ForwardDiagonal,
            /// <summary>
            /// The horizontal
            /// </summary>
            Horizontal,
            /// <summary>
            /// The horizontal brick
            /// </summary>
            HorizontalBrick,
            /// <summary>
            /// The large checker board
            /// </summary>
            LargeCheckerBoard,
            /// <summary>
            /// The large confetti
            /// </summary>
            LargeConfetti,
            /// <summary>
            /// The large grid
            /// </summary>
            LargeGrid,
            /// <summary>
            /// The light downward diagonal
            /// </summary>
            LightDownwardDiagonal,
            /// <summary>
            /// The light horizontal
            /// </summary>
            LightHorizontal,
            /// <summary>
            /// The light upward diagonal
            /// </summary>
            LightUpwardDiagonal,
            /// <summary>
            /// The light vertical
            /// </summary>
            LightVertical,
            /// <summary>
            /// The maximum
            /// </summary>
            Max,
            /// <summary>
            /// The minimum
            /// </summary>
            Min,
            /// <summary>
            /// The narrow horizontal
            /// </summary>
            NarrowHorizontal,
            /// <summary>
            /// The narrow vertical
            /// </summary>
            NarrowVertical,
            /// <summary>
            /// The outlined diamond
            /// </summary>
            OutlinedDiamond,
            /// <summary>
            /// The percent05
            /// </summary>
            Percent05,
            /// <summary>
            /// The percent10
            /// </summary>
            Percent10,
            /// <summary>
            /// The percent20
            /// </summary>
            Percent20,
            /// <summary>
            /// The percent25
            /// </summary>
            Percent25,
            /// <summary>
            /// The percent30
            /// </summary>
            Percent30,
            /// <summary>
            /// The percent40
            /// </summary>
            Percent40,
            /// <summary>
            /// The percent50
            /// </summary>
            Percent50,
            /// <summary>
            /// The percent60
            /// </summary>
            Percent60,
            /// <summary>
            /// The percent70
            /// </summary>
            Percent70,
            /// <summary>
            /// The percent75
            /// </summary>
            Percent75,
            /// <summary>
            /// The percent80
            /// </summary>
            Percent80,
            /// <summary>
            /// The percent90
            /// </summary>
            Percent90,
            /// <summary>
            /// The plaid
            /// </summary>
            Plaid,
            /// <summary>
            /// The shingle
            /// </summary>
            Shingle,
            /// <summary>
            /// The small checker board
            /// </summary>
            SmallCheckerBoard,
            /// <summary>
            /// The small confetti
            /// </summary>
            SmallConfetti,
            /// <summary>
            /// The small grid
            /// </summary>
            SmallGrid,
            /// <summary>
            /// The solid diamond
            /// </summary>
            SolidDiamond,
            /// <summary>
            /// The sphere
            /// </summary>
            Sphere,
            /// <summary>
            /// The trellis
            /// </summary>
            Trellis,
            /// <summary>
            /// The vertical
            /// </summary>
            Vertical,
            /// <summary>
            /// The wave
            /// </summary>
            Wave,
            /// <summary>
            /// The weave
            /// </summary>
            Weave,
            /// <summary>
            /// The wide downward diagonal
            /// </summary>
            WideDownwardDiagonal,
            /// <summary>
            /// The wide upward diagonal
            /// </summary>
            WideUpwardDiagonal,
            /// <summary>
            /// The zig zag
            /// </summary>
            ZigZag
        }
        #endregion


        #region HatchBrush Property

        /// <summary>
        /// Gets or sets the color hatch brushgradient1.
        /// </summary>
        /// <value>The color hatch brushgradient1.</value>
        [Category("Resizable Theme")]
        public Color ColorHatchBrushgradient1
        {
            get { return hatchBrushgradient1; }
            set
            {
                hatchBrushgradient1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color hatch brushgradient2.
        /// </summary>
        /// <value>The color hatch brushgradient2.</value>
        [Category("Resizable Theme")]
        public Color ColorHatchBrushgradient2
        {
            get { return hatchBrushgradient2; }
            set
            {
                hatchBrushgradient2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the hatch brush.
        /// </summary>
        /// <value>The hatch brush.</value>
        [Category("Resizable Theme")]
        public HatchBrushType HatchBrush
        {
            get
            {
                return hatchBrushType;
            }

            set
            {
                hatchBrushType = value;
                Invalidate();
            }
        }
        #endregion

        /// <summary>
        /// Gets or sets the timer interval.
        /// </summary>
        /// <value>The timer interval.</value>
        [Category("Resizable Theme")]
        public int TimerInterval
        {
            get { return interval; }
            set
            {
                interval = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the background.
        /// </summary>
        /// <value>The color of the background.</value>
        [Category("Resizable Theme")]
        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set
            {
                backgroundColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the background color1.
        /// </summary>
        /// <value>The background color1.</value>
        [Category("Resizable Theme")]
        public Color BackgroundColor1
        {
            get { return backgroundColor1; }
            set
            {
                backgroundColor1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [default shadow].
        /// </summary>
        /// <value><c>true</c> if [default shadow]; otherwise, <c>false</c>.</value>
        [Category("Resizable Theme")]
        public bool DefaultShadow
        {
            get { return defaultShadow; }
            set
            {
                defaultShadow = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [custom shadow].
        /// </summary>
        /// <value><c>true</c> if [custom shadow]; otherwise, <c>false</c>.</value>
        [Category("Resizable Theme")]
        public bool CustomShadow
        {
            get { return shadow; }
            set
            {
                shadow = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the grip region.
        /// </summary>
        /// <value>The color of the grip region.</value>
        [Category("Resizable Theme")]
        public Color GripRegionColor
        {
            get { return header; }
            set
            {
                header = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the border.
        /// </summary>
        /// <value>The color of the border.</value>
        [Category("Resizable Theme")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the width of the border.
        /// </summary>
        /// <value>The width of the border.</value>
        [Category("Resizable Theme")]
        public int BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the size of the grip.
        /// </summary>
        /// <value>The size of the grip.</value>
        [Category("Resizable Theme")]
        public int GripSize
        {
            get { return cGrip; }
            set
            {
                cGrip = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the height of the caption.
        /// </summary>
        /// <value>The height of the caption.</value>
        [Category("Resizable Theme")]
        public int CaptionHeight
        {
            get { return cCaption; }
            set
            {
                cCaption = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the handle draw style.
        /// </summary>
        /// <value>The handle draw style.</value>
        [Category("Resizable Theme")]
        public DashStyle HandleDrawStyle
        {
            get { return handleDrawDashStyle; }
            set
            {
                handleDrawDashStyle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the width of the handle border.
        /// </summary>
        /// <value>The width of the handle border.</value>
        [Category("Resizable Theme")]
        public int HandleBorderWidth
        {
            get { return handleBorderWidth; }
            set
            {
                handleBorderWidth = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the handle color border.
        /// </summary>
        /// <value>The handle color border.</value>
        [Category("Resizable Theme")]
        public Color HandleColorBorder
        {
            get
            {
                return handleColorBorder;
            }

            set
            {
                handleColorBorder = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the draw mode.
        /// </summary>
        /// <value>The draw mode.</value>
        [Category("Resizable Theme")]
        public drawMode DrawMode
        {
            get { return _drawMode; }
            set
            {
                _drawMode = value;
                Invalidate();
            }
        }

        #endregion

        #region Private Methods
        /// <summary>
        /// Resizables the color blends.
        /// </summary>
        public void ResizableColorBlends()
        {
            

            blendPositions[0] = 0.000f;
            blendPositions[1] = blendRotate + 0.100f;
            blendPositions[2] = blendRotate + 0.200f;
            blendPositions[3] = blendRotate + 0.300f;
            blendPositions[4] = blendRotate + 0.400f;
            blendPositions[5] = blendRotate + 0.500f;
            blendPositions[6] = blendRotate + 0.600f;
            blendPositions[7] = blendRotate + 0.700f;
            blendPositions[8] = blendRotate + 0.800f;
            blendPositions[9] = blendRotate + 0.900f;
            blendPositions[10] = blendRotate + 1.00f;

            colorBlends[0] = Color.Red;
            colorBlends[1] = Color.Yellow;
            colorBlends[2] = Color.Lime;
            colorBlends[3] = Color.Cyan;
            colorBlends[4] = Color.Blue;
            colorBlends[5] = Color.Violet;
            colorBlends[6] = Color.LightGray;
            colorBlends[7] = Color.Indigo;
            colorBlends[8] = Color.IndianRed;
            colorBlends[9] = Color.DarkOrange;
            colorBlends[10] = Color.Turquoise;

            


        }

        /// <summary>
        /// Resizables the animation.
        /// </summary>
        public void Resizable_Animation()
        {
            #region Animation

            if (DesignMode)
        {
            timer.Tick += Timer_Tick;
            if (AutoAnimate)
            {
                //timer.Interval = 100;
                timer.Start();
            }
        }

        if (!DesignMode)
        {
            timer.Tick += Timer_Tick;

            if (AutoAnimate)
            {
                //timer.Interval = 100;
                timer.Start();
            }
        }



        #endregion
        }


        #endregion

        #region Event

        /// <summary>
        /// Handles the Tick event of the Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.angle + 1 > 360f)
                this.angle = 0;
            else
            {
                this.angle++;
                Invalidate();
            }

            if (this.blendRotate + 0.01f > 1)
            {
                blendRotate = 0f;
            }

            else
            {
                blendRotate += 0.01f;
                Invalidate();
            }

        }

        #endregion

        /// <summary>
        /// Resizables the paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        void Resizable_PaintHook(PaintEventArgs e)
        {

            timer.Interval = interval;

            
            Bitmap bit = new Bitmap(1, 1);
            
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            Rectangle border = new Rectangle(0, 0, Width - 1, Height - 1);

            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);

            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);

            #region Adding Color Blend
            // Create a new LinearGradientBrush using the rectangle, 
            // DarkSeaGreen and Orange. and 90-degree angle.


            Rectangle linearRectangle = new Rectangle(0, 0, Width - 1, Height - 1);

            LinearGradientBrush brush = new LinearGradientBrush(linearRectangle, backgroundColor, backgroundColor1, angle, true);

            if (enableColorBlend)
            {

                ColorBlend colorBlend = new ColorBlend();

                Single[] blendPoints = new Single[]
                {
                    blendPositions[0],
                    blendPositions[1],
                    blendPositions[2],
                    blendPositions[3],
                    blendPositions[4],
                    blendPositions[5],
                    blendPositions[6],
                    blendPositions[7],
                    blendPositions[8],
                    blendPositions[9],
                    blendPositions[10]

                };


                Color[] blendcolors = new System.Drawing.Color[]
                {
                    colorBlends[0],
                    colorBlends[1],
                    colorBlends[2],
                    colorBlends[3],
                    colorBlends[4],
                    colorBlends[5],
                    colorBlends[6],
                    colorBlends[7],
                    colorBlends[8],
                    colorBlends[9],
                    colorBlends[10]
                };

                colorBlend.Positions = blendPoints;

                colorBlend.Colors = blendcolors;

                brush.InterpolationColors = colorBlend;
                brush.GammaCorrection = gammaCorrection;


            }
            #endregion


            Pen drawHandleRegion = new Pen(handleColorBorder, handleBorderWidth);
            drawHandleRegion.DashStyle = handleDrawDashStyle;


            switch (_drawMode)
            {
                case drawMode.Solid:
                    e.Graphics.FillRectangle(new SolidBrush(BackColor), linearRectangle);
                    e.Graphics.DrawRectangle(new Pen(borderColor, borderWidth), border);
                    break;
                case drawMode.Gradient:
                    e.Graphics.FillRectangle(brush, linearRectangle);
                    e.Graphics.DrawRectangle(new Pen(borderColor, borderWidth), border);

                    break;
                case drawMode.Hatch:

                    #region HatchBrush Paint
                    switch (hatchBrushType)
                    {
                        case HatchBrushType.BackwardDiagonal:
                            HatchBrush HB = new HatchBrush(HatchStyle.BackwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB, linearRectangle);
                            break;
                        case HatchBrushType.Cross:
                            HatchBrush HB1 = new HatchBrush(HatchStyle.Cross, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB1, linearRectangle);
                            break;
                        case HatchBrushType.DarkDownwardDiagonal:
                            HatchBrush HB2 = new HatchBrush(HatchStyle.DarkDownwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB2, linearRectangle);
                            break;
                        case HatchBrushType.DarkHorizontal:
                            HatchBrush HB3 = new HatchBrush(HatchStyle.DarkHorizontal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB3, linearRectangle);
                            break;
                        case HatchBrushType.DarkUpwardDiagonal:
                            HatchBrush HB4 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB4, linearRectangle);
                            break;
                        case HatchBrushType.DarkVertical:
                            HatchBrush HB5 = new HatchBrush(HatchStyle.DarkVertical, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB5, linearRectangle);
                            break;
                        case HatchBrushType.DashedDownwardDiagonal:
                            HatchBrush HB6 = new HatchBrush(HatchStyle.DashedDownwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB6, linearRectangle);
                            break;
                        case HatchBrushType.DashedHorizontal:
                            HatchBrush HB7 = new HatchBrush(HatchStyle.DashedHorizontal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB7, linearRectangle);
                            break;
                        case HatchBrushType.DashedUpwardDiagonal:
                            HatchBrush HB8 = new HatchBrush(HatchStyle.DashedUpwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB8, linearRectangle);
                            break;
                        case HatchBrushType.DashedVertical:
                            HatchBrush HB9 = new HatchBrush(HatchStyle.DashedVertical, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB9, linearRectangle);
                            break;
                        case HatchBrushType.DiagonalBrick:
                            HatchBrush HBA = new HatchBrush(HatchStyle.DiagonalBrick, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBA, linearRectangle);
                            break;
                        case HatchBrushType.DiagonalCross:
                            HatchBrush HBB = new HatchBrush(HatchStyle.DiagonalCross, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBB, linearRectangle);
                            break;
                        case HatchBrushType.Divot:
                            HatchBrush HBC = new HatchBrush(HatchStyle.Divot, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBC, linearRectangle);
                            break;
                        case HatchBrushType.DottedDiamond:
                            HatchBrush HBD = new HatchBrush(HatchStyle.DottedDiamond, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBD, linearRectangle);
                            break;
                        case HatchBrushType.DottedGrid:
                            HatchBrush HBE = new HatchBrush(HatchStyle.DottedGrid, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBE, linearRectangle);
                            break;
                        case HatchBrushType.ForwardDiagonal:
                            HatchBrush HBF = new HatchBrush(HatchStyle.ForwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBF, linearRectangle);
                            break;
                        case HatchBrushType.Horizontal:
                            HatchBrush HBG = new HatchBrush(HatchStyle.Horizontal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBG, linearRectangle);
                            break;
                        case HatchBrushType.HorizontalBrick:
                            HatchBrush HBH = new HatchBrush(HatchStyle.HorizontalBrick, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBH, linearRectangle);
                            break;
                        case HatchBrushType.LargeCheckerBoard:
                            HatchBrush HBI = new HatchBrush(HatchStyle.LargeCheckerBoard, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBI, linearRectangle);
                            break;
                        case HatchBrushType.LargeConfetti:
                            HatchBrush HBJ = new HatchBrush(HatchStyle.LargeConfetti, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBJ, linearRectangle);
                            break;
                        case HatchBrushType.LargeGrid:
                            HatchBrush HBK = new HatchBrush(HatchStyle.LargeGrid, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBK, linearRectangle);
                            break;
                        case HatchBrushType.LightDownwardDiagonal:
                            HatchBrush HBL = new HatchBrush(HatchStyle.LightDownwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBL, linearRectangle);
                            break;
                        case HatchBrushType.LightHorizontal:
                            HatchBrush HBM = new HatchBrush(HatchStyle.LightHorizontal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBM, linearRectangle);
                            break;
                        case HatchBrushType.LightUpwardDiagonal:
                            HatchBrush HBN = new HatchBrush(HatchStyle.LightUpwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBN, linearRectangle);
                            break;
                        case HatchBrushType.LightVertical:
                            HatchBrush HBO = new HatchBrush(HatchStyle.LightVertical, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBO, linearRectangle);
                            break;
                        case HatchBrushType.Max:
                            HatchBrush HBP = new HatchBrush(HatchStyle.Max, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBP, linearRectangle);
                            break;
                        case HatchBrushType.Min:
                            HatchBrush HBQ = new HatchBrush(HatchStyle.Min, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBQ, linearRectangle);
                            break;
                        case HatchBrushType.NarrowHorizontal:
                            HatchBrush HBR = new HatchBrush(HatchStyle.NarrowHorizontal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBR, linearRectangle);
                            break;
                        case HatchBrushType.NarrowVertical:
                            HatchBrush HBS = new HatchBrush(HatchStyle.NarrowVertical, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBS, linearRectangle);
                            break;
                        case HatchBrushType.OutlinedDiamond:
                            HatchBrush HBT = new HatchBrush(HatchStyle.OutlinedDiamond, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBT, linearRectangle);
                            break;
                        case HatchBrushType.Percent05:
                            HatchBrush HBU = new HatchBrush(HatchStyle.Percent05, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBU, linearRectangle);
                            break;
                        case HatchBrushType.Percent10:
                            HatchBrush HBV = new HatchBrush(HatchStyle.Percent10, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBV, linearRectangle);
                            break;
                        case HatchBrushType.Percent20:
                            HatchBrush HBW = new HatchBrush(HatchStyle.Percent20, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBW, linearRectangle);
                            break;
                        case HatchBrushType.Percent25:
                            HatchBrush HBX = new HatchBrush(HatchStyle.Percent25, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBX, linearRectangle);
                            break;
                        case HatchBrushType.Percent30:
                            HatchBrush HBY = new HatchBrush(HatchStyle.Percent30, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBY, linearRectangle);
                            break;
                        case HatchBrushType.Percent40:
                            HatchBrush HBZ = new HatchBrush(HatchStyle.Percent40, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBZ, linearRectangle);
                            break;
                        case HatchBrushType.Percent50:
                            HatchBrush HB10 = new HatchBrush(HatchStyle.Percent50, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB10, linearRectangle);
                            break;
                        case HatchBrushType.Percent60:
                            HatchBrush HB11 = new HatchBrush(HatchStyle.Percent60, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB11, linearRectangle);
                            break;
                        case HatchBrushType.Percent70:
                            HatchBrush HB12 = new HatchBrush(HatchStyle.Percent70, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB12, linearRectangle);
                            break;
                        case HatchBrushType.Percent75:
                            HatchBrush HB13 = new HatchBrush(HatchStyle.Percent75, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB13, linearRectangle);
                            break;
                        case HatchBrushType.Percent80:
                            HatchBrush HB14 = new HatchBrush(HatchStyle.Percent80, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB14, linearRectangle);
                            break;
                        case HatchBrushType.Percent90:
                            HatchBrush HB15 = new HatchBrush(HatchStyle.Percent90, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB15, linearRectangle);
                            break;
                        case HatchBrushType.Plaid:
                            HatchBrush HB16 = new HatchBrush(HatchStyle.Plaid, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB16, linearRectangle);
                            break;
                        case HatchBrushType.Shingle:
                            HatchBrush HB17 = new HatchBrush(HatchStyle.Shingle, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB17, linearRectangle);
                            break;
                        case HatchBrushType.SmallCheckerBoard:
                            HatchBrush HB18 = new HatchBrush(HatchStyle.SmallCheckerBoard, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB18, linearRectangle);
                            break;
                        case HatchBrushType.SmallConfetti:
                            HatchBrush HB19 = new HatchBrush(HatchStyle.SmallConfetti, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB19, linearRectangle);
                            break;
                        case HatchBrushType.SmallGrid:
                            HatchBrush HB20 = new HatchBrush(HatchStyle.SmallGrid, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB20, linearRectangle);
                            break;
                        case HatchBrushType.SolidDiamond:
                            HatchBrush HB21 = new HatchBrush(HatchStyle.SolidDiamond, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB21, linearRectangle);
                            break;
                        case HatchBrushType.Sphere:
                            HatchBrush HB22 = new HatchBrush(HatchStyle.Sphere, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB22, linearRectangle);
                            break;
                        case HatchBrushType.Trellis:
                            HatchBrush HB23 = new HatchBrush(HatchStyle.Trellis, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB23, linearRectangle);
                            break;
                        case HatchBrushType.Vertical:
                            HatchBrush HB24 = new HatchBrush(HatchStyle.Vertical, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB24, linearRectangle);
                            break;
                        case HatchBrushType.Wave:
                            HatchBrush HB25 = new HatchBrush(HatchStyle.Wave, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB25, linearRectangle);
                            break;
                        case HatchBrushType.Weave:
                            HatchBrush HB26 = new HatchBrush(HatchStyle.Weave, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB26, linearRectangle);
                            break;
                        case HatchBrushType.WideDownwardDiagonal:
                            HatchBrush HB27 = new HatchBrush(HatchStyle.WideDownwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB27, linearRectangle);
                            break;
                        case HatchBrushType.WideUpwardDiagonal:
                            HatchBrush HB28 = new HatchBrush(HatchStyle.WideUpwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB28, linearRectangle);
                            break;
                        case HatchBrushType.ZigZag:
                            HatchBrush HB29 = new HatchBrush(HatchStyle.ZigZag, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB29, linearRectangle);
                            break;
                        default:
                            break;
                    }
                    #endregion

                    //e.Graphics.FillRectangle(brush, linearRectangle);

                    e.Graphics.DrawRectangle(new Pen(borderColor, borderWidth), border);

                    break;
                default:
                    break;
            }




            e.Graphics.FillRectangle(new SolidBrush(header), rc);
            e.Graphics.DrawRectangle(drawHandleRegion, rc);

        }



        #endregion


        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Thematic150"/> class.
        /// </summary>
        public Thematic150()
        {

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            //ParentForm.TransparencyKey = Color.Fuchsia;

            _mytimer = new Timer();
            _mytimer.Interval = 2000;

            //locksize.Height = Size.Height;
            //locksize.Width = Size.Width;

            //if (lockDimension)
            //{
            //    LockHeight = locksize.Height;
            //    LockWidth = locksize.Width;
            //}


            switch (_themes)
            {
                case themes.EightBall:
                    //SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
                    Dock = DockStyle.Fill;
                    Font = new Font("Segoe UI", 9);
                    BackColor = Color.FromArgb(90, 90, 90);
                    ShowIcon = true;
                    break;

                case themes.Adobe:
                    //MoveHeight = 19;
                    TransparencyKey = Color.Fuchsia;
                    BackColor = Color.FromArgb(68, 68, 68);
                    this.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                    ForeColor = Color.White;
                    break;

                case themes.Advanced_System:
                    SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
                    Dock = DockStyle.Fill;
                    Font = new Font("Arial", 12, FontStyle.Bold | FontStyle.Italic);
                    BackColor = Color.FromArgb(15, 15, 15);
                    break;

                case themes.Advantium:
                    TransparencyKey = Color.Fuchsia;
                    //MoveHeight = 35;
                    ForeColor = Color.LawnGreen;
                    break;

                case themes.Alpha:
                    break;

                case themes.Anom:
                    TransparencyKey = Color.Fuchsia;
                    //BackColor = Color.LightGray
                    Font = new Font("Segoe UI", 9);
                    
                    break;
                case themes.Aryan:
                    TransparencyKey = Color.Fuchsia;
                    MoveHeight = 35;

                    
                    break;
                case themes.Atrocity:
                    Header = 30;
                    TransparencyKey = Color.Fuchsia;

                    SetColor("45", 45, 45, 45);

                    break;
                case themes.Avatar:
                    break;
                case themes.AVG:
                    break;
                case themes.BasicCode:
                    break;
                case themes.BetaBlue:
                    break;
                case themes.Beyond:
                    break;
                case themes.Bionic:
                    break;
                case themes.BitDefender:
                    break;
                case themes.BlackShades:
                    break;
                case themes.Bloody:
                    break;
                //case themes.BlueAndWhite:
                //    //BlueAndWhite_CreateHandle();
                //    break;
                case themes.Blue:
                    break;
                case themes.Booster:
                    break;
                case themes.Border:
                    break;
                case themes.Bullion:
                    break;
                case themes.ButterScotch:
                    break;
                case themes.CarbonFibre:
                    break;
                case themes.Chrome:
                    break;
                case themes.Clarity:
                    break;
                case themes.Classic:
                    break;
                case themes.clsNeoBux:
                    break;
                case themes.CocaCola:
                    break;
                case themes.Complex:
                    break;
                case themes.Crystal:
                    break;
                case themes.Cypher:
                    break;
                //case themes.CypherX:
                //    break;
                case themes.DarkMatter:
                    break;
                case themes.Design:
                    break;
                case themes.Destiny:
                    break;
                case themes.Deumos:
                    break;
                case themes.Doom:
                    break;
                case themes.Drone:
                    break;
                case themes.Earn:
                    break;
                case themes.Effectual:
                    break;
                case themes.Electric:
                    break;
                case themes.Electrified:
                    break;
                case themes.Elegant:
                    break;
                case themes.Element:
                    break;
                case themes.Empire:
                    break;
                case themes.Empress:
                    break;
                case themes.ETheme:
                    break;
                case themes.Evolve:
                    break;
                case themes.Excision:
                    break;
                case themes.Exotic:
                    break;
                case themes.Facebook:
                    break;
                case themes.Festus:
                    break;
                case themes.FlatUI:
                    break;
                case themes.Flow:
                    break;
                case themes.Frog:
                    break;
                case themes.Fusion:
                    break;
                case themes.Future:
                    break;
                case themes.GTheme:
                    break;
                case themes.GameBooster:
                    break;
                case themes.Genuine:
                    break;
                case themes.Ghostv2:
                    break;
                case themes.GhostTheme:
                    break;
                case themes.Gray:
                    break;
                case themes.Green:
                    break;
                case themes.Hacker:
                    break;
                case themes.Hero:
                    break;
                case themes.Hex:
                    break;
                case themes.HF:
                    break;
                case themes.Hura:
                    break;
                case themes.iBlack:
                    break;
                case themes.Influence:
                    break;
                case themes.InnerDarkness:
                    break;
                case themes.Insomia:
                    break;
                case themes.Intel:
                    break;
                case themes.JTheme:
                    break;
                case themes.Knight:
                    break;
                case themes.Light:
                    break;
                case themes.Login:
                    break;
                case themes.Loyal:
                    break;
                case themes.Meph:
                    break;
                case themes.Metal:
                    break;
                case themes.MetroUI:
                    break;
                case themes.MetroDisk:
                    break;
                case themes.Modern:
                    break;
                case themes.MPGH:
                    break;
                case themes.Mumtz:
                    break;
                case themes.Mystic:
                    break;
                case themes.Nameless:
                    break;
                case themes.NeoBux:
                    break;
                case themes.NetSeal:
                    break;
                case themes.New:
                    break;
                case themes.NYX:
                    break;
                case themes.Orains:
                    break;
                case themes.Origin:
                    break;
                case themes.Paladin:
                    break;
                case themes.Patrick:
                    break;
                case themes.Perplex:
                    break;
                case themes.Positron:
                    break;
                case themes.Prime:
                    break;
                case themes.Purity:
                    break;
                case themes.Qube:
                    break;
                case themes.Reactor:
                    break;
                case themes.Recon:
                    break;
                case themes.Redwagon:
                    break;
                case themes.Redemption:
                    break;
                case themes.Rockstar:
                    break;
                case themes.Sasi:
                    break;
                case themes.Secure:
                    break;
                case themes.Sharp:
                    break;
                case themes.Simpla:
                    break;
                case themes.SimpleGrey:
                    break;
                case themes.Simplistic:
                    break;
                //case themes.SimplyGray:
                //    break;
                case themes.Situation:
                    break;
                case themes.SkyBase:
                    break;
                case themes.Skype:
                    break;
                case themes.SLC:
                    break;
                case themes.Somnium:
                    break;
                case themes.Spicylips:
                    break;
                case themes.Steam:
                    break;
                case themes.Storm:
                    break;
                case themes.Studio:
                    break;
                case themes.Subspace:
                    break;
                case themes.Sugar:
                    break;
                case themes.TeamViewer:
                    break;
                case themes.Tech:
                    break;
                case themes.Teen:
                    break;
                case themes.Tennis:
                    break;
                case themes.TheBlack:
                    break;
                case themes.Thief:
                    break;
                case themes.Twitch:
                    break;
                case themes.Ubuntu:
                    break;
                case themes.Uclear:
                    break;
                case themes.Uplay:
                    break;
                case themes.VTheme:
                    break;
                case themes.Visceral:
                    break;
                case themes.Vitality:
                    break;
                case themes.Vs:
                    break;
                case themes.White:
                    break;
                case themes.Winter:
                    break;
                case themes.Xbox:
                    break;
                case themes.Xtreme:
                    break;
                case themes.xVisual:
                    break;
                case themes.Youtube:
                    break;
                case themes.Zeus:
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Events

        /// <summary>
        /// Paints the hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        protected override void PaintHook(PaintEventArgs e)
        {
            switch (_themes)
            {
                case themes.EightBall:
                    EightBall_PaintHook(e);
                    break;

                case themes.Adobe:
                    Adobe_PaintHook();
                    break;

                case themes.Advanced_System:
                    AdvancedSystem_Hook(e);
                    break;
                case themes.Advantium:
                    Advantium_PaintHook(e);
                    break;

                case themes.Angel:
                    Angel_PaintHook(e);
                    break;

                case themes.Anom:
                    Anom_PaintHook(e);
                    break;
                case themes.Aryan:
                    Aryan_PaintHook(e);
                    break;
                case themes.Atrocity:
                    Atrocity_PaintHook(e);
                    break;
                case themes.Avatar:
                    Avatar_PaintHook(e);
                    break;
                case themes.AVG:
                    AVG_PaintHook(e);
                    break;
                case themes.BasicCode:
                    BasicCode_PaintHook(e);
                    break;
                case themes.BetaBlue:
                    BetaBlue_PaintHook(e);
                    break;
                case themes.Beyond:
                    Beyond_PaintHook(e);
                    break;
                case themes.Bionic:
                    Bionic_OnPaint(e);
                    break;
                case themes.BitDefender:
                    //BitDefender_PaintHook(e);
                    break;
                case themes.BlackShades:
                    BlackShades_OnPaint(e);
                    break;
                case themes.Bloody:
                    Bloody_PaintHook(e);
                    break;
                //case themes.BlueAndWhite:
                //    //BlueAndWhite_PaintHook(e);
                //    break;
                case themes.Blue:
                    Blue_PaintHook(e);
                    break;
                case themes.Booster:
                    Booster_PaintHook(e);
                    break;
                case themes.Border:
                    Border_PaintHook(e);
                    break;
                case themes.Bullion:
                    Bullion_OnPaint(e);
                    break;
                case themes.ButterScotch:
                    ButterScotch_PaintHook(e);
                    break;
                case themes.CarbonFibre:
                    CarbonFibre_PaintHook(e);
                    break;
                case themes.Chrome:
                    Chrome_PaintHook(e);
                    break;
                case themes.Clarity:
                    Clarity_PaintHook(e);
                    break;
                case themes.Classic:
                    Classic_PaintHook(e);
                    break;
                case themes.clsNeoBux:
                    clsNeoBux_PaintHook(e);
                    break;
                case themes.CocaCola:
                    CocaCola_PaintHook(e);
                    break;
                case themes.Complex:
                    Complex_PaintHook(e);
                    break;
                case themes.Crystal:
                    Crystal_PaintHook(e);
                    break;
                case themes.Cypher:
                    Cypher_PaintHook(e);
                    break;
                //case themes.CypherX:
                //    break;
                case themes.DarkMatter:
                    DarkMatter_PaintHook(e);
                    break;
                case themes.DarkMatterAlt:
                    DarkMatterAlt_PaintHook(e);
                    break;
                case themes.Design:
                    Design_PaintHook(e);
                    break;
                case themes.Destiny:
                    Destiny_PaintHook(e);
                    break;
                case themes.Deumos:
                    Deumos_PaintHook(e);
                    break;
                case themes.Doom:
                    Doom_PaintHook(e);
                    break;
                case themes.Drone:
                    Drone_PaintHook(e);
                    break;
                case themes.Earn:
                    Earn_PaintHook(e);
                    break;
                case themes.Effectual:
                    Effectual_PaintHook(e);
                    break;
                case themes.Electric:
                    Electric_PaintHook(e);
                    break;
                case themes.Electrified:
                    Electrified_PaintHook(e);
                    break;
                case themes.Elegant:
                    Elegant_PaintHook(e);
                    break;
                case themes.Element:
                    Element_PaintHook(e);
                    break;
                case themes.Empire:
                    Empire_PaintHook(e);
                    break;
                case themes.Empress:
                    Empress_PaintHook(e);
                    break;
                case themes.ETheme:
                    ETheme_PaintHook(e);
                    break;
                case themes.Evolve:
                    Evolve_PaintHook(e);
                    break;
                case themes.Excision:
                    Excision_PaintHook(e);
                    break;
                case themes.Exotic:
                    Exotic_PaintHook(e);
                    break;
                case themes.Facebook:
                    Facebook_Paint(e);
                    break;
                case themes.Festus:
                    Festus_PaintHook(e);
                    break;
                case themes.FlatUI:
                    FlatUI_Paint(e);
                    break;
                case themes.Flow:
                    Flow_PaintHook(e);
                    break;
                case themes.Frog:
                    Frog_PaintHook(e);
                    break;
                case themes.Fusion:
                    Fusion_PaintHook(e);
                    break;
                case themes.Future:
                    Future_PaintHook(e);
                    break;
                case themes.GTheme:
                    GTheme_PaintHook(e);
                    break;
                case themes.GameBooster:
                    GameBooster_PaintHook(e);
                    break;
                case themes.Genuine:
                    Genuine_PaintHook(e);
                    break;
                case themes.Ghostv2:
                    Ghostv2_PaintHook(e);
                    break;
                case themes.GhostTheme:
                    Ghost_PaintHook(e);
                    break;
                case themes.Gray:
                    Gray_PaintHook(e);
                    break;
                case themes.Green:
                    Green_PaintHook(e);
                    break;
                case themes.Hacker:
                    Hacker_PaintHook(e);
                    break;
                case themes.Hero:
                    Hero_PaintHook(e);
                    break;
                case themes.Hex:
                    Hex_PaintHook(e);
                    break;
                case themes.HF:
                    HF_PaintHook(e);
                    break;
                case themes.Hura:
                    Huratheme_PaintHook(e);
                    break;
                case themes.iBlack:
                    iBlack_PaintHook(e);
                    break;
                case themes.Influence:
                    Influence_Paint(e);
                    break;
                case themes.Influx:
                    Influx_PaintHook(e);
                    break;
                case themes.InnerDarkness:
                    InnerDarkness_PaintHook(e);
                    break;
                case themes.Insomia:
                    Insomia_PaintHook(e);
                    break;
                case themes.Intel:
                    Intel_PaintHook(e);
                    break;
                case themes.JTheme:
                    JTheme_PaintHook(e);
                    break;
                case themes.Knight:
                    Knight_PaintHook(e);
                    break;
                case themes.Light:
                    Light_PaintHook(e);
                    break;
                case themes.Login:
                    Login_PaintHook(e);
                    break;
                case themes.Loyal:
                    Loyal_PaintHook(e);
                    break;
                case themes.Meph:
                    MephPaintHook(e);
                    break;
                case themes.Metal:
                    Metal_PaintHook(e);
                    break;
                case themes.MetroUI:
                    MetroUI_PaintHook(e);
                    break;
                case themes.MetroDisk:
                    MetroDisk_PaintHook(e);
                    break;
                case themes.Modern:
                    Modern_PaintHook(e);
                    break;
                case themes.MPGH:
                    MPGH_PaintHook(e);
                    break;
                case themes.Mumtz:
                    Mumtz_PaintHook(e);
                    break;
                case themes.Mystic:
                    Mystic_PaintHook(e);
                    break;
                case themes.Nameless:
                    Nameless_PaintHook(e);
                    break;
                case themes.NeoBux:
                    NeoBux_PaintHook(e);
                    break;
                case themes.NetSeal:
                    NetSeal_PaintHook(e);
                    break;
                case themes.New:
                    NewTheme_PaintHook(e);
                    break;
                case themes.NYX:
                    NYX_PaintHook(e);
                    break;
                case themes.Orains:
                    Orains_PaintHook(e);
                    break;
                case themes.Origin:
                    Origin_PaintHook(e);
                    break;
                case themes.Paladin:
                    PalaDinV2_PaintHook(e);
                    break;
                case themes.Patrick:
                    Patrick_PaintHook(e);
                    break;
                case themes.Perplex:
                    Perplex_Paint(e);
                    break;
                case themes.Positron:
                    Positron_PaintHook(e);
                    break;
                case themes.Prime:
                    Prime_PaintHook(e);
                    break;
                case themes.Purity:
                    Purity_PaintHook(e);
                    break;
                case themes.Qube:
                    Qube_PaintHook(e);
                    break;
                case themes.Reactor:
                    Reactor_PaintHook(e);
                    break;
                case themes.Recon:
                    Recon_PaintHook(e);
                    break;
                case themes.Redwagon:
                    RedDwagon_PaintHook(e);
                    break;
                case themes.Redemption:
                    Redemption_PaintHook(e);
                    break;
                case themes.Resizable:
                    Resizable_PaintHook(e);
                    break;
                case themes.Rockstar:
                    Rockstar_PaintHook(e);
                    break;
                case themes.Sasi:
                    Sasi_PaintHook(e);
                    break;
                case themes.Secure:
                    Secure_PaintHook(e);
                    break;
                case themes.Sharp:
                    Sharp_Paint(e);
                    break;
                case themes.Simpla:
                    Simpla_PaintHook(e);
                    break;
                case themes.SimpleGrey:
                    SimplyGray_PaintHook(e);
                    break;
                case themes.Simplistic:
                    Simplistic_PaintHook(e);
                    break;
                //case themes.SimplyGray:
                //    break;
                case themes.Situation:
                    Situation_PaintHook(e);
                    break;
                case themes.SkyBase:
                    SkyBase_PaintHook(e);
                    break;
                case themes.Skype:
                    Skype_PaintHook(e);
                    break;
                case themes.SLC:
                    SLC_PaintHook(e);
                    break;
                case themes.Somnium:
                    Somnium_PaintHook(e);
                    break;
                case themes.Spicylips:
                    SpicyLips_PaintHook(e);
                    break;
                case themes.Steam:
                    Steam_PaintHook(e);
                    break;
                case themes.SteamAlt:
                    SteamAlt_PaintHook(e);
                    break;
                case themes.Storm:
                    Storm_PaintHook(e);
                    break;
                case themes.Studio:
                    Studio_PaintHook(e);
                    break;
                case themes.Subspace:
                    Subspace_PaintHook(e);
                    break;
                case themes.Sugar:
                    Sugar_PaintHook(e);
                    break;
                case themes.TeamViewer:
                    TeamViewer_PaintHook(e);
                    break;
                case themes.Tech:
                    Tech_PaintHook(e);
                    break;
                case themes.Teen:
                    Teen_PaintHook(e);
                    break;
                case themes.Tennis:
                    Tennis_PaintHook(e);
                    break;
                case themes.TheBlack:
                    TheBlack_PaintHook(e);
                    break;
                case themes.Thief:
                    Thief_PaintHook(e);
                    break;
                case themes.Twitch:
                    Twitch_PaintHook(e);
                    break;
                case themes.Ubuntu:
                    Ubuntu_PaintHook(e);
                    break;
                case themes.Uclear:
                    Uclear_PaintHook(e);
                    break;
                case themes.Uplay:
                    Uplay_PaintHook(e);
                    break;
                case themes.VTheme:
                    VTheme_PaintHook(e);
                    break;
                case themes.Visceral:
                    Visceral_PaintHook(e);
                    break;
                case themes.Vitality:
                    Vitality_PaintHook(e);
                    break;
                case themes.Vs:
                    Vs_PaintHook(e);
                    break;
                case themes.White:
                    White_PaintHook(e);
                    break;
                case themes.Winter:
                    Winter_PaintHook(e);
                    break;
                case themes.Xbox:
                    Xbox_PaintHook(e);
                    break;
                case themes.Xtreme:
                    Xtreme_PaintHook(e);
                    break;
                case themes.xVisual:
                    xVisual_PaintHook(e);
                    break;
                case themes.Youtube:
                    Youtube_PaintHook(e);
                    break;
                case themes.Zeus:
                    Zeus_PaintHook(e);
                    break;
                default:
                    break;

            }
        }

        /// <summary>
        /// Creates a handle for the control.
        /// </summary>
        protected override void CreateHandle()
        {
            base.CreateHandle();

            switch (_themes)
            {
                case themes.EightBall:
                    if (Parent.FindForm().TransparencyKey == null)
                    { ParentForm.FindForm().TransparencyKey = EightBall_tKey; }
                    Parent.FindForm().FormBorderStyle = FormBorderStyle.None;
                    ParentForm.FindForm().TransparencyKey = EightBall_tKey;
                    break;
                case themes.Adobe:
                    break;
                case themes.Advanced_System:
                    Parent.FindForm().FormBorderStyle = FormBorderStyle.None;
                    ParentForm.FindForm().TransparencyKey = EightBall_tKey;
                    if (Parent.FindForm().TransparencyKey == null)
                        Parent.FindForm().TransparencyKey = Color.Fuchsia;

                    break;

                case themes.Anom:
                    border = Color.Black;
                    break;
                case themes.Aryan:
                    break;
                case themes.Atrocity:
                    BackColor = Color.FromArgb(41, 41, 41);
                    break;
                case themes.Avatar:

                    break;
                case themes.AVG:

                    Font = new Font("Arial", 14);
                    Border = Color.DimGray;

                    break;
                case themes.BasicCode:

                    ForeColor = Color.Gray;
                    TransparencyKey = Color.Fuchsia;


                    break;
                case themes.BetaBlue:
                    break;
                case themes.Beyond:
                    break;
                case themes.Bionic:
                    break;
                case themes.BitDefender:
                    if (Parent.FindForm() != null)
                    {
                        Parent.FindForm().FormBorderStyle = FormBorderStyle.None;
                        Parent.FindForm().TransparencyKey = BackColor;
                    }
                    break;
                case themes.BlackShades:
                    break;
                case themes.Bloody:
                    TransparencyKey = Color.Fuchsia;
                    BackColor = Color.Gray;
                    Font = new Font("Sylfaen", 10);
                    SetColor("Border", Color.FromArgb(195, 100, 0, 0));
                    ForeColor = Color.White;
                    break;
                //case themes.BlueAndWhite:

                //    break;
                case themes.Blue:
                    break;
                case themes.Booster:
                    break;
                case themes.Border:
                    break;
                case themes.Bullion:
                    break;
                case themes.ButterScotch:
                    break;
                case themes.CarbonFibre:
                    BackColor = Color.FromArgb(22, 22, 22);
                    TransparencyKey = Color.Fuchsia;
                    Font = new Font("Verdana", 8);
                    Header = 30;
                    break;
                case themes.Chrome:
                    BackColor = Color.FromArgb(22, 22, 22);
                    TransparencyKey = Color.Fuchsia;
                    Font = new Font("Verdana", 8.25f);
                    Header = 30;
                    break;
                case themes.Clarity:
                    break;
                case themes.Classic:
                    TransparencyKey = Color.Fuchsia;
                    MoveHeight = 22;
                    Font = new Font("Verdana", 7f);
                    break;
                case themes.clsNeoBux:
                    TransparencyKey = Color.Fuchsia;
                    BackColor = Color.FromArgb(239, 239, 242);
                    Font = new Font("Segoe UI", 9);
                    break;
                case themes.CocaCola:
                    break;
                case themes.Complex:
                    //Font = new Font("Segoe UI", 12);
                    break;
                case themes.Crystal:
                    break;
                case themes.Cypher:

                    break;
                //case themes.CypherX:
                //    break;
                case themes.DarkMatter:
                    break;
                case themes.Design:
                    break;
                case themes.Destiny:
                    ForeColor = Color.Aquamarine;
                    BackColor = Color.Black;
                    MoveHeight = 20;
                    TransparencyKey = Color.Fuchsia;
                    Font F = new Font("Verdana", 7);
                    Font = F;
                    break;
                case themes.Deumos:
                    Header = 24;
                    TransparencyKey = Color.Fuchsia;

                    BackColor = Color.FromArgb(14, 14, 14);
                    break;
                case themes.Doom:
                    break;
                case themes.Drone:
                    break;
                case themes.Earn:
                    ForeColor = Color.White;
                    break;
                case themes.Effectual:
                    break;
                case themes.Electric:
                    MoveHeight = 20;
                    TransparencyKey = Color.Fuchsia;
                    ForeColor = Color.White;
                    BackColor = Color.FromArgb(22, 84, 107);
                    Font Electric_F = new Font("Verdana", 7);
                    Font = Electric_F;
                    break;
                case themes.Electrified:
                    Font = new Font("Tahoma", 8.25f);
                    ForeColor = Color.Black;
                    BackColor = Color.White;
                    TransparencyKey = Color.Fuchsia;
                    MoveHeight = 20;
                    break;
                case themes.Elegant:
                    Font = new Font("Segoe UI", 12);
                    break;
                case themes.Element:
                    BackColor = Color.FromArgb(41, 41, 41);
                    break;
                case themes.Empire:
                    BackColor = Color.FromArgb(50, 50, 50);
                    ForeColor = Color.White;
                    break;
                case themes.Empress:
                    BackColor = Utilities.ColorConverter.HexToColor("#DE873A");
                    break;
                case themes.ETheme:
                    BackColor = Color.FromArgb(53, 53, 53);
                    MoveHeight = 30;
                    break;
                case themes.Evolve:
                    break;
                case themes.Excision:
                    break;
                case themes.Exotic:
                    //test = true;
                    //MoveHeight = 20;
                    //this.Font = new Font("Gabriola", 12, FontStyle.Regular);

                    break;
                case themes.Facebook:
                    BackColor = _MainColour;
                    MoveHeight = 45;
                    break;
                case themes.Festus:
                    ForeColor = Color.Black;
                    MoveHeight = 25;
                    break;
                case themes.FlatUI:
                    BackColor = _BaseColor;
                    MoveHeight = 50;
                    break;
                case themes.Flow:
                    BackColor = Color.FromArgb(35, 35, 35);
                    CreateShade();
                    CreateTile();
                    break;
                case themes.Frog:
                    break;
                case themes.Fusion:
                    break;
                case themes.Future:
                    BackColor = Color.FromArgb(34, 34, 34);
                    break;
                case themes.GTheme:
                    BackColor = Color.FromArgb(25, 25, 25);
                    ForeColor = Color.FromArgb(76, 76, 76);
                    break;
                case themes.GameBooster:
                    this.BackColor = Color.FromArgb(51, 51, 51);
                    //BackColor = Color.FromArgb(255, 255, 255);
                    break;
                case themes.Genuine:
                    break;
                case themes.Ghostv2:
                    break;
                case themes.GhostTheme:
                    break;
                case themes.Gray:
                    break;
                case themes.Green:
                    break;
                case themes.Hacker:
                    break;
                case themes.Hero:
                    break;
                case themes.Hex:
                    break;
                case themes.HF:
                    break;
                case themes.Hura:
                    break;
                case themes.iBlack:
                    break;
                case themes.Influence:
                    break;
                case themes.InnerDarkness:
                    break;
                case themes.Insomia:
                    break;
                case themes.Intel:
                    break;
                case themes.JTheme:
                    break;
                case themes.Knight:
                    break;
                case themes.Light:
                    break;
                case themes.Login:
                    break;
                case themes.Loyal:
                    break;
                case themes.Meph:
                    break;
                case themes.Metal:
                    break;
                case themes.MetroUI:
                    break;
                case themes.MetroDisk:
                    BackColor = Color.White;
                    Font = new Font("Segoe UI", 12);
                    break;
                case themes.Modern:
                    break;
                case themes.MPGH:
                    break;
                case themes.Mumtz:
                    BackColor = Color.White;
                    Font = new Font("Segoe UI", 10);
                    break;
                case themes.Mystic:
                    break;
                case themes.Nameless:
                    break;
                case themes.NeoBux:
                    break;
                case themes.NetSeal:
                    BackColor = Color.FromArgb(50, 50, 50);
                    break;
                case themes.New:
                    break;
                case themes.NYX:
                    Animated = true;
                    NYX_H = 25;
                    break;
                case themes.Orains:
                    break;
                case themes.Origin:
                    break;
                case themes.Paladin:
                    break;
                case themes.Patrick:
                    TransparencyKey = Color.Fuchsia;
                    break;
                case themes.Perplex:
                    break;
                case themes.Positron:
                    break;
                case themes.Prime:
                    break;
                case themes.Purity:
                    break;
                case themes.Qube:
                    TransparencyKey = Color.Fuchsia;
                    break;
                case themes.Reactor:
                    break;
                case themes.Recon:
                    break;
                case themes.Redwagon:
                    break;
                case themes.Redemption:
                    break;
                case themes.Resizable:
                    Resizable_Animation();
                    break;
                case themes.Rockstar:
                    break;
                case themes.Sasi:
                    TransparencyKey = Color.Fuchsia;
                    BackColor = Color.FromArgb(239, 254, 213);
                    Font = new Font("Century Gothic", 11);
                    break;
                case themes.Secure:
                    Font = new Font("Verdana", 8.25f);
                    ForeColor = Color.Black;
                    BackColor = Color.Black;
                    TransparencyKey = Color.Fuchsia;
                    MoveHeight = 20;
                    break;
                case themes.Sharp:
                    break;
                case themes.Simpla:
                    TransparencyKey = Color.Fuchsia;
                    break;
                case themes.SimpleGrey:
                    break;
                case themes.Simplistic:
                    break;
                //case themes.SimplyGray:
                //    break;
                case themes.Situation:
                    BackColor = Color.DarkSlateGray;
                    break;
                case themes.SkyBase:
                    break;
                case themes.Skype:
                    break;
                case themes.SLC:
                    break;
                case themes.Somnium:
                    break;
                case themes.Spicylips:
                    break;
                case themes.Steam:
                    
                    break;
                case themes.SteamAlt:
                    BackColor = Color.FromArgb(44, 42, 40);
                    break;
                case themes.Storm:
                    break;
                case themes.Studio:
                    BackColor = Color.FromArgb(40, 60, 90);
                    break;
                case themes.Subspace:
                    TransparencyKey = Color.Fuchsia;
                    BackColor = Color.FromArgb(30, 30, 30);
                    Header = 30;
                    break;
                case themes.Sugar:
                    TransparencyKey = Color.Fuchsia;
                    BackColor = Color.FromArgb(247, 249, 254);
                    Font = new Font("Century Gothic", 11);
                    break;
                case themes.TeamViewer:
                    break;
                case themes.Tech:
                    break;
                case themes.Teen:
                    BackColor = Color.FromArgb(50, 50, 50);
                    break;
                case themes.Tennis:
                    break;
                case themes.TheBlack:
                    break;
                case themes.Thief:
                    break;
                case themes.Twitch:
                    break;
                case themes.Ubuntu:
                    break;
                case themes.Uclear:
                    break;
                case themes.Uplay:
                    break;
                case themes.VTheme:
                    break;
                case themes.Visceral:
                    break;
                case themes.Vitality:
                    break;
                case themes.Vs:
                    break;
                case themes.White:
                    break;
                case themes.Winter:
                    break;
                case themes.Xbox:
                    BackColor = Color.FromArgb(20, 20, 20);
                    MoveHeight = 20;
                    TransparencyKey = Color.Fuchsia;
                    break;
                case themes.Xtreme:
                    TransparencyKey = Color.Fuchsia;
                    BackColor = Color.FromArgb(30, 30, 30);
                    Header = 30;
                    break;
                case themes.xVisual:
                    break;
                case themes.Youtube:
                    Font = new Font("Verdana", 8.25f);
                    ForeColor = Color.White;
                    BackColor = Color.White;
                    TransparencyKey = Color.Fuchsia;
                    MoveHeight = 20;
                    break;
                case themes.Zeus:
                    Font = new Font("Candara", 8, FontStyle.Bold);
                    break;
                default:
                    break;

            }

        }

        /// <summary>
        /// Called when [create control].
        /// </summary>
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            switch (_themes)
            {
                case themes.Angel:
                    Parent.FindForm().AllowTransparency = true;
                    Parent.FindForm().TransparencyKey = Color.Fuchsia;
                    Parent.FindForm().FormBorderStyle = FormBorderStyle.None;
                    BackColor = Color.FromArgb(17, 33, 47);
                    Dock = DockStyle.Fill;
                    Font = new Font("Segoe UI", 12);
                    Invalidate();
                    break;
                case themes.Anom:

                    break;
                case themes.Aryan:
                    break;
                case themes.Atrocity:
                    break;
                case themes.Avatar:
                    break;
                case themes.AVG:
                    break;
                case themes.BasicCode:
                    break;
                case themes.BetaBlue:
                    BackColor = Color.FromKnownColor(KnownColor.Control);
                    MoveHeight = 25;
                    TransparencyKey = Color.Fuchsia;
                    break;
                case themes.Beyond:
                    break;
                case themes.Bionic:
                    ParentForm.TransparencyKey = Color.Fuchsia;
                    ParentForm.FormBorderStyle = FormBorderStyle.None;
                    Dock = DockStyle.Fill;
                    BackColor = Color.FromArgb(48, 48, 48);
                    Invalidate();
                    break;
                case themes.BitDefender:
                    //SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.SupportsTransparentBackColor, true);
                    //DoubleBuffered = true;
                    //Dock = DockStyle.Fill;
                    //BackColor = Color.Fuchsia;
                    break;
                case themes.BlackShades:
                    break;
                case themes.Bloody:
                    break;
                //case themes.BlueAndWhite:

                //    break;
                case themes.Blue:
                    break;
                case themes.Booster:
                    Header = 25;
                    break;
                case themes.Border:
                    break;
                case themes.Bullion:
                    break;
                case themes.ButterScotch:
                    break;
                case themes.CarbonFibre:
                    break;
                case themes.Chrome:
                    break;
                case themes.Clarity:
                    break;
                case themes.Classic:
                    break;
                case themes.clsNeoBux:
                    break;
                case themes.CocaCola:
                    break;
                case themes.Complex:
                    Font = new Font("Segoe UI", 12);
                    break;
                case themes.Crystal:
                    break;
                case themes.Cypher:
                    break;
                //case themes.CypherX:
                //    break;
                case themes.DarkMatter:
                    break;
                case themes.Design:
                    break;
                case themes.Destiny:
                    break;
                case themes.Deumos:
                    BackColor = Deumos_C1;
                    break;
                case themes.Doom:
                    break;
                case themes.Drone:
                    break;
                case themes.Earn:
                    ForeColor = Color.White;
                    break;
                case themes.Effectual:
                    break;
                case themes.Electric:
                    MoveHeight = 20;
                    TransparencyKey = Color.Fuchsia;
                    ForeColor = Color.White;
                    BackColor = Color.FromArgb(22, 84, 107);
                    Font Electric_F = new Font("Verdana", 7);
                    Font = Electric_F;
                    break;
                case themes.Electrified:
                    Font = new Font("Tahoma", 8.25f);
                    ForeColor = Color.Black;
                    BackColor = Color.White;
                    TransparencyKey = Color.Fuchsia;
                    MoveHeight = 20;
                    break;
                case themes.Elegant:
                    Font = new Font("Segoe UI", 12);
                    break;
                case themes.Element:
                    BackColor = Color.FromArgb(41, 41, 41);
                    break;
                case themes.Empire:
                    BackColor = Color.FromArgb(50, 50, 50);
                    ForeColor = Color.White;
                    break;
                case themes.Empress:
                    BackColor = Utilities.ColorConverter.HexToColor("#DE873A");
                    break;
                case themes.ETheme:
                    BackColor = Color.FromArgb(53, 53, 53);
                    MoveHeight = 30;
                    break;
                case themes.Evolve:
                    break;
                case themes.Excision:
                    break;
                case themes.Exotic:
                    //test = true;
                    //MoveHeight = 20;
                    //this.Font = new Font("Gabriola", 12, FontStyle.Regular);

                    break;
                case themes.Facebook:
                    BackColor = _MainColour;
                    MoveHeight = 45;
                    break;
                case themes.Festus:
                    ForeColor = Color.Black;
                    MoveHeight = 25;
                    break;
                case themes.FlatUI:
                    BackColor = _BaseColor;
                    MoveHeight = 50;
                    break;
                case themes.Flow:
                    BackColor = Color.FromArgb(35, 35, 35);
                    CreateShade();
                    CreateTile();
                    break;
                case themes.Frog:
                    break;
                case themes.Fusion:
                    break;
                case themes.Future:
                    BackColor = Color.FromArgb(34, 34, 34);
                    break;
                case themes.GTheme:
                    BackColor = Color.FromArgb(25, 25, 25);
                    ForeColor = Color.FromArgb(76, 76, 76);
                    break;
                case themes.GameBooster:
                    this.BackColor = Color.FromArgb(51, 51, 51);
                    //BackColor = Color.FromArgb(255, 255, 255);
                    break;
                case themes.Genuine:
                    break;
                case themes.Ghostv2:
                    break;
                case themes.GhostTheme:
                    break;
                case themes.Gray:
                    break;
                case themes.Green:
                    break;
                case themes.Hacker:
                    break;
                case themes.Hero:
                    break;
                case themes.Hex:
                    break;
                case themes.HF:
                    break;
                case themes.Hura:
                    break;
                case themes.iBlack:
                    break;
                case themes.Influence:
                    break;
                case themes.InnerDarkness:
                    break;
                case themes.Insomia:
                    break;
                case themes.Intel:
                    break;
                case themes.JTheme:
                    break;
                case themes.Knight:
                    break;
                case themes.Light:
                    break;
                case themes.Login:
                    break;
                case themes.Loyal:
                    break;
                case themes.Meph:
                    break;
                case themes.Metal:
                    break;
                case themes.MetroUI:
                    break;
                case themes.MetroDisk:
                    BackColor = Color.White;
                    Font = new Font("Segoe UI", 12);
                    break;
                case themes.Modern:
                    break;
                case themes.MPGH:
                    break;
                case themes.Mumtz:
                    BackColor = Color.White;
                    Font = new Font("Segoe UI", 10);
                    break;
                case themes.Mystic:
                    break;
                case themes.Nameless:
                    break;
                case themes.NeoBux:
                    break;
                case themes.NetSeal:
                    BackColor = Color.FromArgb(50, 50, 50);
                    break;
                case themes.New:
                    break;
                case themes.NYX:
                    Animated = true;
                    NYX_H = 25;
                    break;
                case themes.Orains:
                    break;
                case themes.Origin:
                    break;
                case themes.Paladin:
                    break;
                case themes.Patrick:
                    TransparencyKey = Color.Fuchsia;
                    break;
                case themes.Perplex:
                    break;
                case themes.Positron:
                    break;
                case themes.Prime:
                    break;
                case themes.Purity:
                    break;
                case themes.Qube:
                    TransparencyKey = Color.Fuchsia;
                    break;
                case themes.Reactor:
                    break;
                case themes.Recon:
                    break;
                case themes.Redwagon:
                    break;
                case themes.Redemption:
                    break;
                case themes.Resizable:
                    Resizable_Animation();
                    break;
                case themes.Rockstar:
                    break;
                case themes.Sasi:
                    TransparencyKey = Color.Fuchsia;
                    BackColor = Color.FromArgb(239, 254, 213);
                    Font = new Font("Century Gothic", 11);
                    break;
                case themes.Secure:
                    Font = new Font("Verdana", 8.25f);
                    ForeColor = Color.Black;
                    BackColor = Color.Black;
                    TransparencyKey = Color.Fuchsia;
                    MoveHeight = 20;
                    break;
                case themes.Sharp:
                    break;
                case themes.Simpla:
                    TransparencyKey = Color.Fuchsia;
                    break;
                case themes.SimpleGrey:
                    break;
                case themes.Simplistic:
                    break;
                //case themes.SimplyGray:
                //    break;
                case themes.Situation:
                    BackColor = Color.DarkSlateGray;
                    break;
                case themes.SkyBase:
                    break;
                case themes.Skype:
                    break;
                case themes.SLC:
                    break;
                case themes.Somnium:
                    break;
                case themes.Spicylips:
                    break;
                case themes.Steam:
                    break;
                case themes.SteamAlt:
                    BackColor = Color.FromArgb(44, 42, 40);
                    break;
                case themes.Storm:
                    break;
                case themes.Studio:
                    BackColor = Color.FromArgb(40, 60, 90);
                    break;
                case themes.Subspace:
                    TransparencyKey = Color.Fuchsia;
                    BackColor = Color.FromArgb(30, 30, 30);
                    Header = 30;
                    break;
                case themes.Sugar:
                    TransparencyKey = Color.Fuchsia;
                    BackColor = Color.FromArgb(247, 249, 254);
                    Font = new Font("Century Gothic", 11);
                    break;
                case themes.TeamViewer:
                    break;
                case themes.Tech:
                    break;
                case themes.Teen:
                    BackColor = Color.FromArgb(50, 50, 50);
                    break;
                case themes.Tennis:
                    break;
                case themes.TheBlack:
                    break;
                case themes.Thief:
                    break;
                case themes.Twitch:
                    break;
                case themes.Ubuntu:
                    break;
                case themes.Uclear:
                    break;
                case themes.Uplay:
                    break;
                case themes.VTheme:
                    break;
                case themes.Visceral:
                    break;
                case themes.Vitality:
                    break;
                case themes.Vs:
                    break;
                case themes.White:
                    break;
                case themes.Winter:
                    break;
                case themes.Xbox:
                    BackColor = Color.FromArgb(20, 20, 20);
                    MoveHeight = 20;
                    TransparencyKey = Color.Fuchsia;
                    break;
                case themes.Xtreme:
                    TransparencyKey = Color.Fuchsia;
                    BackColor = Color.FromArgb(30, 30, 30);
                    Header = 30;
                    break;
                case themes.xVisual:
                    break;
                case themes.Youtube:
                    Font = new Font("Verdana", 8.25f);
                    ForeColor = Color.White;
                    BackColor = Color.White;
                    TransparencyKey = Color.Fuchsia;
                    MoveHeight = 20;
                    break;
                case themes.Zeus:
                    Font = new Font("Candara", 8, FontStyle.Bold);
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {
            //void : Add details to it

            switch (_themes)
            {
                case themes.EightBall:
                    
                    break;
                case themes.Adobe:
                    break;
                case themes.Advanced_System:
                    
                    break;
                case themes.Advantium:
                    break;
                case themes.Anom:
                    break;
                case themes.Aryan:
                    break;
                case themes.Atrocity:
                    break;
                case themes.Avatar:
                    TransparencyKey = Color.Fuchsia;
                    BackColor = Color.Black;
                    Font = new Font("Century Gothic", 9);
                    SetColor("Text", Color.DeepSkyBlue);
                    Border = Color.Fuchsia;
                    break;
                case themes.AVG:
                    break;
                case themes.BasicCode:
                    break;
                case themes.BetaBlue:
                    break;
                case themes.Beyond:
                    break;
                case themes.Bionic:
                    break;
                case themes.BitDefender:
                    break;
                case themes.BlackShades:
                    break;
                case themes.Bloody:
                    break;
                //case themes.BlueAndWhite:
                //    break;
                case themes.Blue:
                    break;
                case themes.Booster:
                    break;
                case themes.Border:
                    break;
                case themes.Bullion:
                    break;
                case themes.ButterScotch:
                    break;
                case themes.CarbonFibre:
                    break;
                case themes.Chrome:
                    break;
                case themes.Clarity:
                    break;
                case themes.Classic:
                    break;
                case themes.clsNeoBux:
                    break;
                case themes.CocaCola:
                    break;
                case themes.Complex:
                    break;
                case themes.Crystal:
                    break;
                case themes.Cypher:
                    Cypher_OnHandleCreated();
                    break;
                //case themes.CypherX:
                //    break;
                case themes.DarkMatter:
                    break;
                case themes.Design:
                    SendToBack();
                    Padding = new Padding(2, 36, 2, 2);
                    Font = new Font("Verdana", 10, FontStyle.Regular);
                    break;
                case themes.Destiny:
                    ForeColor = Color.Aquamarine;
                    BackColor = Color.Black;
                    MoveHeight = 20;
                    TransparencyKey = Color.Fuchsia;
                    Font F = new Font("Verdana", 7);
                    Font = F;
                    break;
                case themes.Deumos:
                    BackColor = Deumos_C1;
                    break;
                case themes.Doom:
                    break;
                case themes.Drone:
                    break;
                case themes.Earn:
                    break;
                case themes.Effectual:
                    break;
                case themes.Electric:
                    break;
                case themes.Electrified:
                    break;
                case themes.Elegant:
                    break;
                case themes.Element:
                    break;
                case themes.Empire:
                    break;
                case themes.Empress:
                    break;
                case themes.ETheme:
                    break;
                case themes.Evolve:
                    break;
                case themes.Excision:
                    break;
                case themes.Exotic:
                    break;
                case themes.Facebook:
                    break;
                case themes.Festus:
                    break;
                case themes.FlatUI:
                    break;
                case themes.Flow:
                    break;
                case themes.Frog:
                    break;
                case themes.Fusion:
                    break;
                case themes.Future:
                    break;
                case themes.GTheme:
                    break;
                case themes.GameBooster:
                    break;
                case themes.Genuine:
                    break;
                case themes.Ghostv2:
                    break;
                case themes.GhostTheme:
                    break;
                case themes.Gray:
                    break;
                case themes.Green:
                    break;
                case themes.Hacker:
                    break;
                case themes.Hero:
                    break;
                case themes.Hex:
                    break;
                case themes.HF:
                    break;
                case themes.Hura:
                    break;
                case themes.iBlack:
                    break;
                case themes.Influence:
                    break;
                case themes.InnerDarkness:
                    break;
                case themes.Insomia:
                    break;
                case themes.Intel:
                    break;
                case themes.JTheme:
                    break;
                case themes.Knight:
                    break;
                case themes.Light:
                    break;
                case themes.Login:
                    break;
                case themes.Loyal:
                    break;
                case themes.Meph:
                    break;
                case themes.Metal:
                    break;
                case themes.MetroUI:
                    break;
                case themes.MetroDisk:
                    break;
                case themes.Modern:
                    break;
                case themes.MPGH:
                    break;
                case themes.Mumtz:
                    break;
                case themes.Mystic:
                    break;
                case themes.Nameless:
                    break;
                case themes.NeoBux:
                    break;
                case themes.NetSeal:
                    break;
                case themes.New:
                    break;
                case themes.NYX:
                    break;
                case themes.Orains:
                    break;
                case themes.Origin:
                    break;
                case themes.Paladin:
                    break;
                case themes.Patrick:
                    break;
                case themes.Perplex:
                    break;
                case themes.Positron:
                    break;
                case themes.Prime:
                    break;
                case themes.Purity:
                    break;
                case themes.Qube:
                    break;
                case themes.Reactor:
                    break;
                case themes.Recon:
                    break;
                case themes.Redwagon:
                    break;
                case themes.Redemption:
                    break;
                case themes.Rockstar:
                    break;
                case themes.Sasi:
                    break;
                case themes.Secure:
                    break;
                case themes.Sharp:
                    break;
                case themes.Simpla:
                    break;
                case themes.SimpleGrey:
                    break;
                case themes.Simplistic:
                    break;
                //case themes.SimplyGray:
                //    break;
                case themes.Situation:
                    break;
                case themes.SkyBase:
                    break;
                case themes.Skype:
                    break;
                case themes.SLC:
                    break;
                case themes.Somnium:
                    break;
                case themes.Spicylips:
                    break;
                case themes.Steam:
                    break;
                case themes.Storm:
                    break;
                case themes.Studio:
                    break;
                case themes.Subspace:
                    break;
                case themes.Sugar:
                    
                    break;
                case themes.TeamViewer:
                    break;
                case themes.Tech:
                    break;
                case themes.Teen:
                    break;
                case themes.Tennis:
                    break;
                case themes.TheBlack:
                    break;
                case themes.Thief:
                    break;
                case themes.Twitch:
                    break;
                case themes.Ubuntu:
                    break;
                case themes.Uclear:
                    break;
                case themes.Uplay:
                    break;
                case themes.VTheme:
                    break;
                case themes.Visceral:
                    break;
                case themes.Vitality:
                    break;
                case themes.Vs:
                    break;
                case themes.White:
                    break;
                case themes.Winter:
                    break;
                case themes.Xbox:
                    break;
                case themes.Xtreme:
                    break;
                case themes.xVisual:
                    break;
                case themes.Youtube:
                    break;
                case themes.Zeus:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Handles the <see cref="E:MouseMove" /> event.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            switch (_themes)
            {
                case themes.EightBall:
                    EightBall_MouseMove(e);
                    break;
                case themes.Advanced_System:
                    AdvancedSystem_OnMouseMove(e);
                    break;
                case themes.Angel:
                    Angel_OnMouseMove(e);
                    break;

                case themes.Anom:
                    break;
                case themes.Aryan:
                    break;
                case themes.Atrocity:
                    break;
                case themes.Avatar:
                    break;
                case themes.AVG:
                    break;
                case themes.BasicCode:
                    break;
                case themes.BetaBlue:
                    break;
                case themes.Beyond:
                    break;
                case themes.Bionic:
                    //Bionic_OnMouseMove(e);
                    break;
                case themes.BitDefender:
                    //BitDefender_OnMouseMove(e);

                    break;
                case themes.BlackShades:
                    break;
                case themes.Bloody:
                    break;
                //case themes.BlueAndWhite:
                   
                //    break;
                case themes.Blue:
                    break;
                case themes.Booster:
                    break;
                case themes.Border:
                    break;
                case themes.Bullion:
                    break;
                case themes.ButterScotch:
                    break;
                case themes.CarbonFibre:
                    break;
                case themes.Chrome:
                    Chrome_OnMouseMove(e);
                    break;
                case themes.Clarity:
                    break;
                case themes.Classic:
                    break;
                case themes.clsNeoBux:
                    break;
                case themes.CocaCola:
                    break;
                case themes.Complex:
                    break;
                case themes.Crystal:
                    break;
                case themes.Cypher:
                    Cypher_OnMouseMove(e);
                    break;
                //case themes.CypherX:
                //    break;
                case themes.DarkMatter:
                    break;
                case themes.Design:
                    break;
                case themes.Destiny:
                    break;
                case themes.Deumos:
                    break;
                case themes.Doom:
                    break;
                case themes.Drone:
                    break;
                case themes.Earn:
                    break;
                case themes.Effectual:
                    break;
                case themes.Electric:
                    break;
                case themes.Electrified:
                    break;
                case themes.Elegant:
                    break;
                case themes.Element:
                    break;
                case themes.Empire:
                    break;
                case themes.Empress:
                    break;
                case themes.ETheme:
                    break;
                case themes.Evolve:
                    break;
                case themes.Excision:
                    break;
                case themes.Exotic:
                    break;
                case themes.Facebook:
                    break;
                case themes.Festus:
                    break;
                case themes.FlatUI:
                    break;
                case themes.Flow:
                    break;
                case themes.Frog:
                    break;
                case themes.Fusion:
                    break;
                case themes.Future:
                    break;
                case themes.GTheme:
                    break;
                case themes.GameBooster:
                    break;
                case themes.Genuine:
                    break;
                case themes.Ghostv2:
                    break;
                case themes.GhostTheme:
                    break;
                case themes.Gray:
                    break;
                case themes.Green:
                    break;
                case themes.Hacker:
                    break;
                case themes.Hero:
                    break;
                case themes.Hex:
                    break;
                case themes.HF:
                    break;
                case themes.Hura:
                    break;
                case themes.iBlack:
                    break;
                case themes.Influence:
                    break;
                case themes.InnerDarkness:
                    break;
                case themes.Insomia:
                    break;
                case themes.Intel:
                    break;
                case themes.JTheme:
                    break;
                case themes.Knight:
                    break;
                case themes.Light:
                    break;
                case themes.Login:
                    break;
                case themes.Loyal:
                    break;
                case themes.Meph:
                    break;
                case themes.Metal:
                    break;
                case themes.MetroUI:
                    break;
                case themes.MetroDisk:
                    break;
                case themes.Modern:
                    break;
                case themes.MPGH:
                    break;
                case themes.Mumtz:
                    break;
                case themes.Mystic:
                    break;
                case themes.Nameless:
                    break;
                case themes.NeoBux:
                    break;
                case themes.NetSeal:
                    break;
                case themes.New:
                    break;
                case themes.NYX:
                    break;
                case themes.Orains:
                    break;
                case themes.Origin:
                    break;
                case themes.Paladin:
                    break;
                case themes.Patrick:
                    break;
                case themes.Perplex:
                    break;
                case themes.Positron:
                    break;
                case themes.Prime:
                    break;
                case themes.Purity:
                    break;
                case themes.Qube:
                    break;
                case themes.Reactor:
                    break;
                case themes.Recon:
                    break;
                case themes.Redwagon:
                    break;
                case themes.Redemption:
                    break;
                case themes.Resizable:
                    
                    break;
                case themes.Rockstar:
                    break;
                case themes.Sasi:
                    break;
                case themes.Secure:
                    break;
                case themes.Sharp:
                    break;
                case themes.Simpla:
                    break;
                case themes.SimpleGrey:
                    break;
                case themes.Simplistic:
                    break;
                //case themes.SimplyGray:
                //    break;
                case themes.Situation:
                    break;
                case themes.SkyBase:
                    break;
                case themes.Skype:
                    break;
                case themes.SLC:
                    break;
                case themes.Somnium:
                    break;
                case themes.Spicylips:
                    break;
                case themes.Steam:
                    break;
                case themes.Storm:
                    break;
                case themes.Studio:
                    break;
                case themes.Subspace:
                    break;
                case themes.Sugar:
                    break;
                case themes.TeamViewer:
                    break;
                case themes.Tech:
                    break;
                case themes.Teen:
                    break;
                case themes.Tennis:
                    break;
                case themes.TheBlack:
                    break;
                case themes.Thief:
                    break;
                case themes.Twitch:
                    break;
                case themes.Ubuntu:
                    break;
                case themes.Uclear:
                    break;
                case themes.Uplay:
                    break;
                case themes.VTheme:
                    break;
                case themes.Visceral:
                    break;
                case themes.Vitality:
                    break;
                case themes.Vs:
                    break;
                case themes.White:
                    break;
                case themes.Winter:
                    break;
                case themes.Xbox:
                    break;
                case themes.Xtreme:
                    break;
                case themes.xVisual:
                    break;
                case themes.Youtube:
                    break;
                case themes.Zeus:
                    break;
                default:
                    break;

            }
        }

        /// <summary>
        /// Handles the <see cref="E:MouseUp" /> event.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            switch (_themes)
            {
                case themes.EightBall:
                    break;
                case themes.Advanced_System:
                    break;
                case themes.Angel:
                    Angel_OnMouseUp(e);
                    break;
                case themes.Anom:
                    break;
                case themes.Aryan:
                    break;
                case themes.Atrocity:
                    break;
                case themes.Avatar:
                    break;
                case themes.AVG:
                    break;
                case themes.BasicCode:
                    break;
                case themes.BetaBlue:
                    break;
                case themes.Beyond:
                    break;
                case themes.Bionic:
                    //Bionic_OnMouseUp(e);
                    break;
                case themes.BitDefender:
                    //BitDefender_OnMouseUp(e);
                    break;
                case themes.BlackShades:
                    break;
                case themes.Bloody:
                    break;
                //case themes.BlueAndWhite:
                //    break;
                case themes.Blue:
                    break;
                case themes.Booster:
                    break;
                case themes.Border:
                    break;
                case themes.Bullion:
                    break;
                case themes.ButterScotch:
                    break;
                case themes.CarbonFibre:
                    break;
                case themes.Chrome:
                    break;
                case themes.Clarity:
                    break;
                case themes.Classic:
                    break;
                case themes.clsNeoBux:
                    break;
                case themes.CocaCola:
                    break;
                case themes.Complex:
                    break;
                case themes.Crystal:
                    break;
                case themes.Cypher:
                    break;
                //case themes.CypherX:
                //    break;
                case themes.DarkMatter:
                    break;
                case themes.Design:
                    break;
                case themes.Destiny:
                    break;
                case themes.Deumos:
                    break;
                case themes.Doom:
                    break;
                case themes.Drone:
                    break;
                case themes.Earn:
                    break;
                case themes.Effectual:
                    break;
                case themes.Electric:
                    break;
                case themes.Electrified:
                    break;
                case themes.Elegant:
                    break;
                case themes.Element:
                    break;
                case themes.Empire:
                    break;
                case themes.Empress:
                    break;
                case themes.ETheme:
                    break;
                case themes.Evolve:
                    break;
                case themes.Excision:
                    break;
                case themes.Exotic:
                    break;
                case themes.Facebook:
                    break;
                case themes.Festus:
                    break;
                case themes.FlatUI:
                    break;
                case themes.Flow:
                    break;
                case themes.Frog:
                    break;
                case themes.Fusion:
                    break;
                case themes.Future:
                    break;
                case themes.GTheme:
                    break;
                case themes.GameBooster:
                    break;
                case themes.Genuine:
                    break;
                case themes.Ghostv2:
                    break;
                case themes.GhostTheme:
                    break;
                case themes.Gray:
                    break;
                case themes.Green:
                    break;
                case themes.Hacker:
                    break;
                case themes.Hero:
                    break;
                case themes.Hex:
                    break;
                case themes.HF:
                    break;
                case themes.Hura:
                    break;
                case themes.iBlack:
                    break;
                case themes.Influence:
                    break;
                case themes.InnerDarkness:
                    break;
                case themes.Insomia:
                    break;
                case themes.Intel:
                    break;
                case themes.JTheme:
                    break;
                case themes.Knight:
                    break;
                case themes.Light:
                    break;
                case themes.Login:
                    break;
                case themes.Loyal:
                    break;
                case themes.Meph:
                    break;
                case themes.Metal:
                    break;
                case themes.MetroUI:
                    break;
                case themes.MetroDisk:
                    break;
                case themes.Modern:
                    break;
                case themes.MPGH:
                    break;
                case themes.Mumtz:
                    break;
                case themes.Mystic:
                    break;
                case themes.Nameless:
                    break;
                case themes.NeoBux:
                    break;
                case themes.NetSeal:
                    break;
                case themes.New:
                    break;
                case themes.NYX:
                    break;
                case themes.Orains:
                    break;
                case themes.Origin:
                    break;
                case themes.Paladin:
                    break;
                case themes.Patrick:
                    break;
                case themes.Perplex:
                    break;
                case themes.Positron:
                    break;
                case themes.Prime:
                    break;
                case themes.Purity:
                    break;
                case themes.Qube:
                    break;
                case themes.Reactor:
                    break;
                case themes.Recon:
                    break;
                case themes.Redwagon:
                    break;
                case themes.Redemption:
                    break;
                case themes.Rockstar:
                    break;
                case themes.Sasi:
                    break;
                case themes.Secure:
                    break;
                case themes.Sharp:
                    break;
                case themes.Simpla:
                    break;
                case themes.SimpleGrey:
                    break;
                case themes.Simplistic:
                    break;
                //case themes.SimplyGray:
                //    break;
                case themes.Situation:
                    break;
                case themes.SkyBase:
                    break;
                case themes.Skype:
                    break;
                case themes.SLC:
                    break;
                case themes.Somnium:
                    break;
                case themes.Spicylips:
                    break;
                case themes.Steam:
                    break;
                case themes.Storm:
                    break;
                case themes.Studio:
                    break;
                case themes.Subspace:
                    break;
                case themes.Sugar:
                    break;
                case themes.TeamViewer:
                    break;
                case themes.Tech:
                    break;
                case themes.Teen:
                    break;
                case themes.Tennis:
                    break;
                case themes.TheBlack:
                    break;
                case themes.Thief:
                    break;
                case themes.Twitch:
                    break;
                case themes.Ubuntu:
                    break;
                case themes.Uclear:
                    break;
                case themes.Uplay:
                    break;
                case themes.VTheme:
                    break;
                case themes.Visceral:
                    break;
                case themes.Vitality:
                    break;
                case themes.Vs:
                    break;
                case themes.White:
                    break;
                case themes.Winter:
                    break;
                case themes.Xbox:
                    break;
                case themes.Xtreme:
                    break;
                case themes.xVisual:
                    break;
                case themes.Youtube:
                    break;
                case themes.Zeus:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Handles the <see cref="E:MouseDown" /> event.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (EnableControlBox)
            {
                ControlBoxFunctionality(e);
            }
            

            switch (_themes)
            {
                case themes.EightBall:
                    EightBall_OnMouseDown(e);
                    break;
                case themes.Advanced_System:
                    AdvancedSystem_OnMouseDown(e);
                    break;
                case themes.Angel:
                    Angel_OnMouseDown(e);
                    break;

                case themes.Anom:
                    break;
                case themes.Aryan:
                    break;
                case themes.Atrocity:
                    break;
                case themes.Avatar:
                    break;
                case themes.AVG:
                    break;
                case themes.BasicCode:
                    break;
                case themes.BetaBlue:
                    break;
                case themes.Beyond:
                    break;
                case themes.Bionic:
                    //Bionic_OnMouseDown(e);
                    break;
                case themes.BitDefender:
                    //BitDefender_OnMouseDown(e);
                    break;
                case themes.BlackShades:
                    break;
                case themes.Bloody:
                    break;
                //case themes.BlueAndWhite:
                //    break;
                case themes.Blue:
                    break;
                case themes.Booster:
                    break;
                case themes.Border:
                    break;
                case themes.Bullion:
                    break;
                case themes.ButterScotch:
                    break;
                case themes.CarbonFibre:
                    break;
                case themes.Chrome:
                    break;
                case themes.Clarity:
                    break;
                case themes.Classic:
                    break;
                case themes.clsNeoBux:
                    break;
                case themes.CocaCola:
                    break;
                case themes.Complex:
                    break;
                case themes.Crystal:
                    break;
                case themes.Cypher:
                    Cypher_OnMouseDown(e);
                    break;
                //case themes.CypherX:
                //    break;
                case themes.DarkMatter:
                    break;
                case themes.Design:
                    break;
                case themes.Destiny:
                    break;
                case themes.Deumos:
                    break;
                case themes.Doom:
                    break;
                case themes.Drone:
                    break;
                case themes.Earn:
                    break;
                case themes.Effectual:
                    break;
                case themes.Electric:
                    break;
                case themes.Electrified:
                    break;
                case themes.Elegant:
                    Elegant_OnMouseDown(e);
                    break;
                case themes.Element:
                    break;
                case themes.Empire:
                    break;
                case themes.Empress:
                    break;
                case themes.ETheme:
                    break;
                case themes.Evolve:
                    break;
                case themes.Excision:
                    break;
                case themes.Exotic:
                    break;
                case themes.Facebook:
                    break;
                case themes.Festus:
                    break;
                case themes.FlatUI:
                    break;
                case themes.Flow:
                    break;
                case themes.Frog:
                    break;
                case themes.Fusion:
                    break;
                case themes.Future:
                    break;
                case themes.GTheme:
                    break;
                case themes.GameBooster:
                    break;
                case themes.Genuine:
                    break;
                case themes.Ghostv2:
                    break;
                case themes.GhostTheme:
                    break;
                case themes.Gray:
                    break;
                case themes.Green:
                    break;
                case themes.Hacker:
                    break;
                case themes.Hero:
                    break;
                case themes.Hex:
                    break;
                case themes.HF:
                    break;
                case themes.Hura:
                    break;
                case themes.iBlack:
                    break;
                case themes.Influence:
                    break;
                case themes.InnerDarkness:
                    break;
                case themes.Insomia:
                    break;
                case themes.Intel:
                    break;
                case themes.JTheme:
                    break;
                case themes.Knight:
                    break;
                case themes.Light:
                    break;
                case themes.Login:
                    
                    break;
                case themes.Loyal:
                    break;
                case themes.Meph:
                    break;
                case themes.Metal:
                    break;
                case themes.MetroUI:
                    break;
                case themes.MetroDisk:
                    break;
                case themes.Modern:
                    break;
                case themes.MPGH:
                    break;
                case themes.Mumtz:
                    break;
                case themes.Mystic:
                    break;
                case themes.Nameless:
                    break;
                case themes.NeoBux:
                    break;
                case themes.NetSeal:
                    break;
                case themes.New:
                    break;
                case themes.NYX:
                    break;
                case themes.Orains:
                    break;
                case themes.Origin:
                    break;
                case themes.Paladin:
                    break;
                case themes.Patrick:
                    break;
                case themes.Perplex:
                    break;
                case themes.Positron:
                    break;
                case themes.Prime:
                    break;
                case themes.Purity:
                    break;
                case themes.Qube:
                    break;
                case themes.Reactor:
                    break;
                case themes.Recon:
                    break;
                case themes.Redwagon:
                    break;
                case themes.Redemption:
                    break;
                case themes.Rockstar:
                    break;
                case themes.Sasi:
                    break;
                case themes.Secure:
                    break;
                case themes.Sharp:
                    break;
                case themes.Simpla:
                    break;
                case themes.SimpleGrey:
                    break;
                case themes.Simplistic:
                    break;
                //case themes.SimplyGray:
                //    break;
                case themes.Situation:
                    break;
                case themes.SkyBase:
                    break;
                case themes.Skype:
                    break;
                case themes.SLC:
                    break;
                case themes.Somnium:
                    break;
                case themes.Spicylips:
                    break;
                case themes.Steam:
                    break;
                case themes.Storm:
                    break;
                case themes.Studio:
                    break;
                case themes.Subspace:
                    break;
                case themes.Sugar:
                    break;
                case themes.TeamViewer:
                    break;
                case themes.Tech:
                    break;
                case themes.Teen:
                    break;
                case themes.Tennis:
                    break;
                case themes.TheBlack:
                    break;
                case themes.Thief:
                    break;
                case themes.Twitch:
                    break;
                case themes.Ubuntu:
                    break;
                case themes.Uclear:
                    break;
                case themes.Uplay:
                    break;
                case themes.VTheme:
                    break;
                case themes.Visceral:
                    break;
                case themes.Vitality:
                    break;
                case themes.Vs:
                    break;
                case themes.White:
                    break;
                case themes.Winter:
                    break;
                case themes.Xbox:
                    break;
                case themes.Xtreme:
                    break;
                case themes.xVisual:
                    break;
                case themes.Youtube:
                    break;
                case themes.Zeus:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseClick" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            switch (_themes)
            {
                case themes.Chrome:
                    Chrome_OnMouseClick(e);
                    break;
            }
        }

        /// <summary>
        /// Called when [creation].
        /// </summary>
        protected override void OnCreation()
        {
            switch (_themes)
            {
                case themes.BasicCode:
                    if (!DesignMode)
                    {
                        System.Threading.Thread G = new System.Threading.Thread(MoveGlow);
                        System.Threading.Thread T = new System.Threading.Thread(MoveText);
                        G.IsBackground = true;
                        T.IsBackground = true;
                        G.Start();
                        T.Start();
                    }
                    break;

                //case themes.BlueAndWhite:
                //    //BlueAndWhite_CreateHandle();
                //break;
            }
            
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Resize" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }




        #endregion

        #region Private Methods
        /// <summary>
        /// The get mouse location
        /// </summary>
        private Point GetMouseLocation;

        //private Color _HoverColour = Color.FromArgb(42, 42, 42);

        /// <summary>
        /// The old size
        /// </summary>
        private Size OldSize;

        /// <summary>
        /// Controls the box functionality.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void ControlBoxFunctionality(MouseEventArgs e)
        {
            switch (ControlBoxType)
            {
                case controlBoxType.Large:
                    if (EnableControlBox)
                    {
                        GetMouseLocation = PointToClient(MousePosition);

                        if (GetMouseLocation.X > Width - 39 && GetMouseLocation.X < Width - 16 &&
                            GetMouseLocation.Y < 22)
                        {
                            if (_AllowClose)
                            {
                                if (_CloseChoice == __CloseChoice.Application)
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    ParentForm.Close();
                                }
                            }
                        }
                        else if (GetMouseLocation.X > Width - 64 && GetMouseLocation.X < Width - 41 &&
                                 GetMouseLocation.Y < 22)
                        {
                            if (_AllowMaximize)
                            {
                                switch (Parent.FindForm().WindowState)
                                {
                                    case FormWindowState.Maximized:
                                        Parent.FindForm().WindowState = FormWindowState.Normal;
                                        break;
                                    case FormWindowState.Normal:
                                        OldSize = Size;
                                        Parent.FindForm().WindowState = FormWindowState.Maximized;
                                        break;
                                }
                            }
                        }
                        else if (GetMouseLocation.X > Width - 89 && GetMouseLocation.X < Width - 66 &&
                                 GetMouseLocation.Y < 22)
                        {
                            if (_AllowMinimize)
                            {
                                switch (Parent.FindForm().WindowState)
                                {
                                    case FormWindowState.Normal:
                                        OldSize = Size;
                                        Parent.FindForm().WindowState = FormWindowState.Minimized;
                                        break;
                                    case FormWindowState.Maximized:
                                        Parent.FindForm().WindowState = FormWindowState.Minimized;
                                        break;
                                }
                            }
                        }


                    }
                    break;

                case controlBoxType.Small:

                    if (EnableControlBox)
                    {

                        switch (ControlsAlign)
                        {
                            case ControlsAlign.Right:
                                //_ShowClose
                                if (CloseBox == true)
                                {
                                    if (new Rectangle(Width - 23, (((_HeaderSize + 2) - 18) / 2), 18, 18).Contains(e
                                        .Location))
                                    {
                                        Application.Exit();
                                    }
                                }

                                //_ShowMinimize
                                if (Parent.FindForm().MinimizeBox == true)
                                {
                                    if (Parent.FindForm().MaximizeBox == true)
                                    {

                                        if (CloseBox == true)
                                        {
                                            if (new Rectangle(Width - 58, (((_HeaderSize + 2) - 18) / 2), 17, 18).Contains(e
                                                .Location))
                                            {
                                                Parent.FindForm().WindowState = FormWindowState.Minimized;
                                                return;
                                            }

                                        }
                                        else
                                        {
                                            if (new Rectangle(Width - 41, (((_HeaderSize + 2) - 18) / 2), 18, 18).Contains(e
                                                .Location))
                                            {
                                                Parent.FindForm().WindowState = FormWindowState.Minimized;
                                                return;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (CloseBox == true)
                                        {
                                            if (new Rectangle(Width - 41, (((_HeaderSize + 2) - 18) / 2), 18, 18).Contains(e
                                                .Location))
                                            {
                                                Parent.FindForm().WindowState = FormWindowState.Minimized;
                                                return;
                                            }
                                        }
                                        else
                                        {
                                            if (new Rectangle(Width - 23, (((_HeaderSize + 2) - 18) / 2), 18, 18).Contains(e
                                                .Location))
                                            {
                                                Parent.FindForm().WindowState = FormWindowState.Minimized;
                                                return;
                                            }
                                        }
                                    }
                                }
                                // Get more free themes at ThemesVB.NET
                                //_ShowMaximize
                                if (Parent.FindForm().MaximizeBox == true)
                                {

                                    if (CloseBox == true)
                                    {
                                        if (new Rectangle(Width - 41, (((_HeaderSize + 2) - 18) / 2), 18, 18).Contains(e
                                            .Location))
                                        {
                                            if (Parent.FindForm().WindowState == FormWindowState.Maximized)
                                            {
                                                Parent.FindForm().WindowState = FormWindowState.Normal;
                                                Refresh();
                                            }
                                            else if (Parent.FindForm().WindowState == FormWindowState.Normal)
                                            {
                                                Parent.FindForm().WindowState = FormWindowState.Maximized;
                                                Refresh();
                                            }
                                            return;
                                        }

                                    }
                                    else
                                    {
                                        if (new Rectangle(Width - 23, (((_HeaderSize + 2) - 18) / 2), 18, 18).Contains(e
                                            .Location))
                                        {
                                            if (Parent.FindForm().WindowState == FormWindowState.Maximized)
                                            {
                                                Parent.FindForm().WindowState = FormWindowState.Normal;
                                                Refresh();
                                            }
                                            else if (Parent.FindForm().WindowState == FormWindowState.Normal)
                                            {
                                                Parent.FindForm().WindowState = FormWindowState.Maximized;
                                                Refresh();
                                            }
                                            return;
                                        }
                                    }
                                }

                                break;
                            case ControlsAlign.Left:
                                //_ShowClose
                                if (CloseBox == true)
                                {
                                    if (new Rectangle(4, (((_HeaderSize + 2) - 18) / 2), 18, 18).Contains(e.Location))
                                    {
                                        Application.Exit();
                                    }
                                }

                                //_ShowMinimize
                                if (Parent.FindForm().MinimizeBox == true)
                                {
                                    if (Parent.FindForm().MaximizeBox == true)
                                    {

                                        if (CloseBox == true)
                                        {
                                            if (new Rectangle(40, (((_HeaderSize + 2) - 18) / 2), 17, 18).Contains(e
                                                .Location))
                                            {
                                                Parent.FindForm().WindowState = FormWindowState.Minimized;
                                                return;
                                            }

                                        }
                                        else
                                        {
                                            if (new Rectangle(22, (((_HeaderSize + 2) - 18) / 2), 18, 18).Contains(e
                                                .Location))
                                            {
                                                Parent.FindForm().WindowState = FormWindowState.Minimized;
                                                return;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (CloseBox == true)
                                        {
                                            if (new Rectangle(22, (((_HeaderSize + 2) - 18) / 2), 18, 18).Contains(e
                                                .Location))
                                            {
                                                Parent.FindForm().WindowState = FormWindowState.Minimized;
                                                return;
                                            }
                                        }
                                        else
                                        {
                                            if (new Rectangle(4, (((_HeaderSize + 2) - 18) / 2), 18, 18)
                                                .Contains(e.Location))
                                            {
                                                Parent.FindForm().WindowState = FormWindowState.Minimized;
                                                return;
                                            }
                                        }
                                    }
                                }

                                //_ShowMaximize
                                if (Parent.FindForm().MaximizeBox == true)
                                {

                                    if (CloseBox == true)
                                    {
                                        if (new Rectangle(22, (((_HeaderSize + 2) - 18) / 2), 18, 18).Contains(e.Location))
                                        {
                                            if (Parent.FindForm().WindowState == FormWindowState.Maximized)
                                            {
                                                Parent.FindForm().WindowState = FormWindowState.Normal;
                                                Refresh();
                                            }
                                            else if (Parent.FindForm().WindowState == FormWindowState.Normal)
                                            {
                                                Parent.FindForm().WindowState = FormWindowState.Maximized;
                                                Refresh();
                                            }
                                            return;
                                        }

                                    }
                                    else
                                    {
                                        if (new Rectangle(4, (((_HeaderSize + 2) - 18) / 2), 18, 18).Contains(e.Location))
                                        {
                                            if (Parent.FindForm().WindowState == FormWindowState.Maximized)
                                            {
                                                Parent.FindForm().WindowState = FormWindowState.Normal;
                                                Refresh();
                                            }
                                            else if (Parent.FindForm().WindowState == FormWindowState.Normal)
                                            {
                                                Parent.FindForm().WindowState = FormWindowState.Maximized;
                                                Refresh();
                                            }
                                            return;
                                        }
                                    }
                                }

                                break;
                        }
                    }

                    if (e.Y < _Header && e.Button == MouseButtons.Left)
                    {
                        _Down = true;
                        _MousePoint = new Point(e.Location.X, e.Location.Y);
                    }
                    break;
            }

        }


        #endregion
    }

    //public class LockSize : Component
    //{
        

    //    [Browsable(true)]
    //    public int Width
    //    {
    //        get;
    //        set;
    //    }

    //    public int Height
    //    {
    //        get;
    //        set;
    //    }

        
    //    //[Browsable(true)]
    //    //public int Width
    //    //{
    //    //    get;
    //    //    set;
    //    //}

    //    //public int Height
    //    //{
    //    //    get;
    //    //    set;
    //    //}
    //}
    

}
