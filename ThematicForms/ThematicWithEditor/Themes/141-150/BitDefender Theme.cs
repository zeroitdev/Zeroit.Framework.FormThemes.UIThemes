// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="BitDefender Theme.cs" company="Zeroit Dev Technologies">
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
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;


namespace Zeroit.Framework.FormThemes.UIThemes
{

    /// <summary>
    /// Class Bitdefender_Helper.
    /// </summary>
    static class Bitdefender_Helper
    {

        /// <summary>
        /// Rounds the rect.
        /// </summary>
        /// <param name="R">The r.</param>
        /// <param name="radius">The radius.</param>
        /// <returns>GraphicsPath.</returns>
        static internal GraphicsPath RoundRect(Rectangle R, int radius)
        {
            GraphicsPath GP = new GraphicsPath();
            GP.AddArc(R.X, R.Y, radius, radius, 180, 90);
            GP.AddArc(R.Right - radius, R.Y, radius, radius, 270, 90);
            GP.AddArc(R.Right - radius, R.Bottom - radius, radius, radius, 0, 90);
            GP.AddArc(R.X, R.Bottom - radius, radius, radius, 90, 90);
            GP.CloseFigure();
            return GP;
        }

    }

    /// <summary>
    /// Class Thematic150WithEditor.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.FormThemes.UIThemes.ThemeContainer154" />
    public partial class Thematic150WithEditor 
    {

        #region "Bitdefender_Init"
        /// <summary>
        /// Bitdefenders the form.
        /// </summary>
        public void BitdefenderForm()
        {
            //SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.SupportsTransparentBackColor, true);
            //DoubleBuffered = true;
            //Dock = DockStyle.Fill;
            //BackColor = Color.Fuchsia;
        }
        /// <summary>
        /// Bits the defender form on handle created.
        /// </summary>
        private void BitDefenderForm_OnHandleCreated(/*EventArgs e*/)
        {
            //base.OnHandleCreated(e);
            if (Parent.FindForm() != null)
            {
                Parent.FindForm().FormBorderStyle = FormBorderStyle.None;
                Parent.FindForm().TransparencyKey = BackColor;
            }

        }

        #region "Property"

        //public override string Text
        //{
        //    get { return base.Text; }
        //    set
        //    {
        //        base.Text = value;
        //        Invalidate(new Rectangle(0, 0, Width, 70), false);
        //    }
        //}



        /// <summary>
        /// The disable maximum
        /// </summary>
        private bool _DisableMax;
        /// <summary>
        /// Gets or sets a value indicating whether [disable controlbox maximum].
        /// </summary>
        /// <value><c>true</c> if [disable controlbox maximum]; otherwise, <c>false</c>.</value>
        public bool DisableControlboxMax
        {
            get { return _DisableMax; }
            set
            {
                _DisableMax = value;
                Invalidate(false);
            }
        }

        /// <summary>
        /// The disable minimum
        /// </summary>
        private bool _DisableMin;
        /// <summary>
        /// Gets or sets a value indicating whether [disable controlbox minimum].
        /// </summary>
        /// <value><c>true</c> if [disable controlbox minimum]; otherwise, <c>false</c>.</value>
        public bool DisableControlboxMin
        {
            get { return _DisableMin; }
            set
            {
                _DisableMin = value;
                Invalidate(false);
            }
        }

        /// <summary>
        /// The disable close
        /// </summary>
        private bool _DisableClose;
        /// <summary>
        /// Gets or sets a value indicating whether [disable controlbox close].
        /// </summary>
        /// <value><c>true</c> if [disable controlbox close]; otherwise, <c>false</c>.</value>
        public bool DisableControlboxClose
        {
            get { return _DisableClose; }
            set
            {
                _DisableClose = value;
                Invalidate(false);
            }
        }
        #endregion


        #region "Flag mouse"
        /// <summary>
        /// The bitdefender mouse offset
        /// </summary>
        Point Bitdefender_mouseOffset;
        /// <summary>
        /// Bits the defender on mouse down.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void BitDefender_OnMouseDown(MouseEventArgs e)
        {
            //base.OnMouseDown(e);
            Bitdefender_mouseOffset = new Point(-e.X, -e.Y);
        }
        /// <summary>
        /// Bits the defender on mouse move.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void BitDefender_OnMouseMove(MouseEventArgs e)
        {
            //base.OnMouseMove(e);

            //#Zone " Move form "
            for (int x = 0; x <= Width - 1; x++)
            {
                for (int y = 0; y <= 30; y++)
                {
                    if (e.Button == MouseButtons.Left && e.Location.Equals(new Point(x, y)))
                    {
                        dynamic mousePos = Control.MousePosition;
                        mousePos.Offset(Bitdefender_mouseOffset.X, Bitdefender_mouseOffset.Y);
                        Parent.FindForm().Location = mousePos;
                    }
                }
            }
            //#End Zone

            //#Zone " None mouse flag "
            Bitdefender_MouseState = Bitdefender_State.None;
            Cursor = Cursors.Default;
            //#End Zone

            //#Zone " minRect "
            Rectangle minRect = new Rectangle(Right - Bitdefender_Padding - (Bitdefender_controlSize.Width + 20), Bitdefender_Padding, Bitdefender_btnSize.Width, Bitdefender_btnSize.Height);
            if (minRect.Contains(e.Location))
            {
                Cursor = Cursors.Hand;
                Bitdefender_MouseState = Bitdefender_State.HoverMin;
            }
            //#End Zone

            //#Zone " maxRect "
            Rectangle maxRect = new Rectangle(minRect.X + 29, minRect.Y, Bitdefender_btnSize.Width, Bitdefender_btnSize.Height);
            if (maxRect.Contains(e.Location))
            {
                Cursor = Cursors.Hand;
                Bitdefender_MouseState = Bitdefender_State.HoverMax;
            }
            //#End Zone

            //#Zone " closeRect "
            Rectangle closeRect = new Rectangle(maxRect.X + 29, minRect.Y, Bitdefender_btnSize.Width, Bitdefender_btnSize.Height);
            if (closeRect.Contains(e.Location))
            {
                Cursor = Cursors.Hand;
                Bitdefender_MouseState = Bitdefender_State.HoverClose;
            }
            //#End Zone




        }
        /// <summary>
        /// Bits the defender on mouse up.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void BitDefender_OnMouseUp(MouseEventArgs e)
        {
            //base.OnMouseUp(e);
            Rectangle min = new Rectangle(Right - Bitdefender_Padding - (Bitdefender_controlSize.Width + 20), Bitdefender_Padding, Bitdefender_btnSize.Width, Bitdefender_btnSize.Height);
            Rectangle max = new Rectangle(min.X + 29, min.Y, Bitdefender_btnSize.Width, Bitdefender_btnSize.Height);
            Rectangle close = new Rectangle(max.X + 29, max.Y, Bitdefender_btnSize.Width, Bitdefender_btnSize.Height);

            if (min.Contains(e.Location) && e.Button == MouseButtons.Left && !DisableControlboxMin)
            {
                Parent.FindForm().WindowState = FormWindowState.Minimized;
            }

            if (max.Contains(e.Location) && e.Button == MouseButtons.Left && !DisableControlboxMax)
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

            if (close.Contains(e.Location) && e.Button == MouseButtons.Left && !DisableControlboxClose)
            {
                Parent.FindForm().Close();
            }

        }

        #region "Draw mouse state"
        /// <summary>
        /// Enum Bitdefender_State
        /// </summary>
        private enum Bitdefender_State
        {
            /// <summary>
            /// The none
            /// </summary>
            None,
            /// <summary>
            /// The hover close
            /// </summary>
            HoverClose,
            /// <summary>
            /// The hover maximum
            /// </summary>
            HoverMax,
            /// <summary>
            /// The hover minimum
            /// </summary>
            HoverMin
        }

        /// <summary>
        /// The bitdefender mouse state
        /// </summary>
        private Bitdefender_State Bitdefender_mouseState;
        /// <summary>
        /// Gets or sets the state of the bitdefender mouse.
        /// </summary>
        /// <value>The state of the bitdefender mouse.</value>
        private Bitdefender_State Bitdefender_MouseState
        {
            get { return Bitdefender_mouseState; }
            set
            {
                Bitdefender_mouseState = value;
                Invalidate(false);
            }
        }
        #endregion

        #endregion


        #endregion

        #region "Draw"

        #region "Bitdefender_Init Draw Object"

        #region "Draw Object Declarations"
        /// <summary>
        /// The g
        /// </summary>
        private Graphics _G;
        /// <summary>
        /// The bitdefender padding
        /// </summary>
        private new const int Bitdefender_Padding = 10;
        //#Zone " Controlbox "
        /// <summary>
        /// The bitdefender BTN size
        /// </summary>
        private Size Bitdefender_btnSize = new Size(27, 30);
        /// <summary>
        /// The bitdefender control size
        /// </summary>
        private Size Bitdefender_controlSize;
        /// <summary>
        /// The bitdefender controlbox path
        /// </summary>
        private GraphicsPath Bitdefender_controlboxPath;
        //#End Zone

        /// <summary>
        /// The bitdefender r1
        /// </summary>
        private Rectangle Bitdefender_R1;
        /// <summary>
        /// The bitdefender r2
        /// </summary>
        private Rectangle Bitdefender_R2;
        /// <summary>
        /// The bitdefender r4
        /// </summary>
        private Rectangle Bitdefender_R4;
        /// <summary>
        /// The bitdefender r5
        /// </summary>
        private Rectangle Bitdefender_R5;
        /// <summary>
        /// The bitdefender r6
        /// </summary>
        private Rectangle Bitdefender_R6;
        /// <summary>
        /// The bitdefender g p1
        /// </summary>
        private GraphicsPath Bitdefender_GP1;
        /// <summary>
        /// The bitdefender g p2
        /// </summary>
        private GraphicsPath Bitdefender_GP2;
        /// <summary>
        /// The bitdefender g p3
        /// </summary>
        private GraphicsPath Bitdefender_GP3;
        /// <summary>
        /// The bitdefender g p4
        /// </summary>
        private GraphicsPath Bitdefender_GP4;
        /// <summary>
        /// The bitdefender p1
        /// </summary>
        private Pen Bitdefender_P1;
        /// <summary>
        /// The bitdefender p2
        /// </summary>
        private Pen Bitdefender_P2;
        /// <summary>
        /// The bitdefender p3
        /// </summary>
        private Pen Bitdefender_P3;
        /// <summary>
        /// The bitdefender p4
        /// </summary>
        private Pen Bitdefender_P4;
        /// <summary>
        /// The bitdefender p5
        /// </summary>
        private Pen Bitdefender_P5;
        /// <summary>
        /// The bitdefender p6
        /// </summary>
        private Pen Bitdefender_P6;
        /// <summary>
        /// The bitdefender b1
        /// </summary>
        private SolidBrush Bitdefender_B1;
        /// <summary>
        /// The bitdefender lg b1
        /// </summary>
        private LinearGradientBrush Bitdefender_LGB1;
        /// <summary>
        /// The bitdefender lg b2
        /// </summary>
        private LinearGradientBrush Bitdefender_LGB2;
        /// <summary>
        /// The bitdefender lg b3
        /// </summary>
        private LinearGradientBrush Bitdefender_LGB3;
        /// <summary>
        /// The bitdefender lg b4
        /// </summary>
        private LinearGradientBrush Bitdefender_LGB4;
        /// <summary>
        /// The bitdefender lg b5
        /// </summary>
        private LinearGradientBrush Bitdefender_LGB5;
        /// <summary>
        /// The bitdefender lg b6
        /// </summary>
        private LinearGradientBrush Bitdefender_LGB6;
        /// <summary>
        /// The bitdefender c1
        /// </summary>
        private Color Bitdefender_C1;
        /// <summary>
        /// The bitdefender c2
        /// </summary>
        private Color Bitdefender_C2;
        /// <summary>
        /// The bitdefender c3
        /// </summary>
        private Color Bitdefender_C3;
        /// <summary>
        /// The bitdefender c4
        /// </summary>
        private Color Bitdefender_C4;
        /// <summary>
        /// The bitdefender c5
        /// </summary>
        private Color Bitdefender_C5;
        /// <summary>
        /// The bitdefender c6
        /// </summary>
        private Color Bitdefender_C6;
        /// <summary>
        /// The bitdefender c7
        /// </summary>
        private Color Bitdefender_C7;
        /// <summary>
        /// The bitdefender c8
        /// </summary>
        private Color Bitdefender_C8;
        /// <summary>
        /// The bitdefender c9
        /// </summary>
        private Color Bitdefender_C9;

        /// <summary>
        /// The bitdefender C10
        /// </summary>
        private Color Bitdefender_C10;

        /// <summary>
        /// The container disposable
        /// </summary>
        private Bitdefender_ContainerObjectDisposable containerDisposable = new Bitdefender_ContainerObjectDisposable();
        #endregion


        /// <summary>
        /// Bitdefenders the initialize.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void Bitdefender_Init(PaintEventArgs e)
        {
            G = e.Graphics;
            Bitdefender_controlSize = new Size(86, Bitdefender_btnSize.Height);
            //#Zone " Rectangle "
            Bitdefender_R1 = new Rectangle(Bitdefender_Padding, Bitdefender_Padding, Width - Bitdefender_Padding * 2, Height - Bitdefender_Padding * 2);
            Bitdefender_R2 = new Rectangle(Bitdefender_R1.X + 1, Bitdefender_R1.Y + 1, Bitdefender_R1.Width - 2, Bitdefender_R1.Height - 2);
            Bitdefender_R4 = new Rectangle(Bitdefender_Padding, Bitdefender_Padding, Width, 20);
            Bitdefender_R5 = new Rectangle(Right - Bitdefender_Padding - (Bitdefender_controlSize.Width + 20), Bitdefender_Padding, Bitdefender_controlSize.Width, Bitdefender_controlSize.Height);
            Bitdefender_R6 = new Rectangle(Bitdefender_R5.X + 1, Bitdefender_R5.Y + 1, Bitdefender_R5.Width - 2, Bitdefender_R5.Height - 2);
            //#End Zone

            //#Zone " Graphic path "
            Bitdefender_GP1 = Bitdefender_Helper.RoundRect(Bitdefender_R1, 18);
            Bitdefender_GP2 = Bitdefender_Helper.RoundRect(Bitdefender_R2, 18);
            //Bitdefender_GP3 = Bitdefender_ControlRect(Bitdefender_R5, 9);
            //Bitdefender_GP4 = Bitdefender_ControlRect(Bitdefender_R6, 9);

            Bitdefender_GP3 = Bitdefender_Helper.RoundRect(Bitdefender_R5, 9);
            Bitdefender_GP4 = Bitdefender_Helper.RoundRect(Bitdefender_R6, 9);
            Bitdefender_controlboxPath = new GraphicsPath();
            containerDisposable.AddObjectRange(new GraphicsPath[]{
            Bitdefender_GP1,
            Bitdefender_GP2,
            Bitdefender_GP3,
            Bitdefender_GP4,
            Bitdefender_controlboxPath
        });
            //#End Zone

            //#Zone " Brush "
            Bitdefender_B1 = new SolidBrush(Color.FromArgb(32, 32, 32));
            containerDisposable.AddObject(Bitdefender_B1);
            //#End Zone

            //#Zone " Color "
            Bitdefender_C1 = Color.FromArgb(81, 81, 81);
            Bitdefender_C2 = Color.FromArgb(43, 43, 43);
            Bitdefender_C3 = Color.FromArgb(21, 21, 21);
            Bitdefender_C4 = Color.FromArgb(10, 10, 10);
            Bitdefender_C5 = Color.FromArgb(167, 167, 167);
            Bitdefender_C6 = Color.FromArgb(83, 83, 83);
            Bitdefender_C7 = Color.FromArgb(41, 41, 41);
            Bitdefender_C8 = Color.FromArgb(33, 33, 33);
            Bitdefender_C9 = Color.FromArgb(41, 41, 41);
            Bitdefender_C10 = Color.FromArgb(77, 77, 77);
            //#End Zone

            //#Zone " Linear Gradient Brush "
            Bitdefender_LGB1 = new LinearGradientBrush(Bitdefender_R4, Bitdefender_C1, Bitdefender_C2, LinearGradientMode.Vertical);
            Bitdefender_LGB2 = new LinearGradientBrush(Bitdefender_R5, Bitdefender_C6, Bitdefender_C7, LinearGradientMode.Vertical);
            Bitdefender_LGB3 = new LinearGradientBrush(Bitdefender_R5, Bitdefender_C8, Bitdefender_C7, LinearGradientMode.Vertical);
            Bitdefender_LGB4 = new LinearGradientBrush(new Point(Bitdefender_R5.Left + 27, Bitdefender_R5.Top + 2), new Point(Bitdefender_R5.Left + 27, Bitdefender_R5.Bottom - 2), Bitdefender_C3, Bitdefender_C4);
            Bitdefender_LGB5 = new LinearGradientBrush(new Point(Bitdefender_R5.Left + 28, Bitdefender_R5.Top + 2), new Point(Bitdefender_R5.Left + 28, Bitdefender_R5.Bottom - 1), Bitdefender_C5, Bitdefender_C6);
            Bitdefender_LGB6 = new LinearGradientBrush(Bitdefender_R5, Bitdefender_C9, Bitdefender_C10, LinearGradientMode.Vertical);
            containerDisposable.AddObjectRange(new LinearGradientBrush[]{
            Bitdefender_LGB1,
            Bitdefender_LGB2,
            Bitdefender_LGB3,
            Bitdefender_LGB4,
            Bitdefender_LGB5,
            Bitdefender_LGB6
        });

            //#End Zone

            //#Zone " Pen "
            Bitdefender_P1 = new Pen(Color.FromArgb(33, 33, 33));
            Bitdefender_P2 = new Pen(Color.FromArgb(240, 240, 240));
            Bitdefender_P3 = new Pen(Bitdefender_LGB3);
            Bitdefender_P4 = new Pen(new SolidBrush(Color.FromArgb(83, 83, 83)));
            Bitdefender_P5 = new Pen(Bitdefender_LGB4);
            Bitdefender_P6 = new Pen(Bitdefender_LGB5);
            containerDisposable.AddObjectRange(new Pen[]{
            Bitdefender_P1,
            Bitdefender_P2,
            Bitdefender_P3,
            Bitdefender_P4,
            Bitdefender_P5,
            Bitdefender_P6
        });
            //#End Zone


        }

        #endregion



        /// <summary>
        /// Bits the defender paint hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void BitDefender_PaintHook(PaintEventArgs e)
        {
            //base.Bitdefender_OnPaint(e);

            //'#Zone " DebugMode "
#if DEBUG
            //Dim ST As New Stopwatch : ST.Start()
#endif

            //#End Zone

            Bitdefender_Init(e);

            //#Zone " Draw background"
            G.FillPath(Bitdefender_B1, Bitdefender_GP1);
            //#End Zone

            //#Zone " Draw header "
            G.SetClip(Bitdefender_GP2);
            G.FillRectangle(Bitdefender_LGB1, Bitdefender_R4);
            G.ResetClip();
            //#End Zone

            //#Zone " Draw title "
            G.DrawString(Text, new Font("Microsoft Sans Serif", 10, FontStyle.Regular), Brushes.White, 27, 22);
            //#End Zone

            //#Zone " Draw border "
            G.DrawPath(Bitdefender_P1, Bitdefender_GP1);
            G.DrawPath(Bitdefender_P2, Bitdefender_GP2);
            //#End Zone

            //#Zone " Mouse state "
            switch (Bitdefender_MouseState)
            {
                case Bitdefender_State.HoverClose:
                    Bitdefender_DrawControlBox_Close(G);
                    break;
                case Bitdefender_State.HoverMax:
                    Bitdefender_DrawControlBox_Max(G);
                    break;
                case Bitdefender_State.HoverMin:
                    Bitdefender_DrawControlBox_Min(G);
                    break;
                case Bitdefender_State.None:
                    Bitdefender_DrawControlBox(G);
                    break;
            }
            //#End Zone

            //#Zone " Dispose all draw object "
            containerDisposable.Dispose();
            //#End Zone

            //#Zone " DebugMode "
#if DEBUG
            //Debug.WriteLine(ST.Elapsed.ToString)
#endif

            //#End Zone

        }


        /// <summary>
        /// Bitdefenders the draw control box.
        /// </summary>
        /// <param name="G">The g.</param>
        private void Bitdefender_DrawControlBox(Graphics G)
        {
            G.SmoothingMode = SmoothingMode.HighQuality;

            G.FillPath(Bitdefender_LGB2, Bitdefender_GP3);
            G.DrawPath(Bitdefender_P3, Bitdefender_GP3);
            G.DrawPath(Bitdefender_P4, Bitdefender_GP4);
            //#Zone " If you want white line "
            G.DrawLine(Bitdefender_P2, Bitdefender_R5.Left, Bitdefender_R5.Top + 1, Bitdefender_R5.Right, Bitdefender_R5.Top + 1);
            //#End Zone
            //#Zone " Fix     !important "
            G.DrawLine(Bitdefender_P3, Bitdefender_R5.Right, Bitdefender_R5.Top, Bitdefender_R5.Right, Bitdefender_R5.Bottom - 4);
            G.DrawLine(Bitdefender_P4, Bitdefender_R6.Right, Bitdefender_R6.Top + 1, Bitdefender_R6.Right, Bitdefender_R6.Bottom - 4);

            G.SmoothingMode = SmoothingMode.Default;

            G.FillRectangle(Bitdefender_P3.Brush, new Rectangle(Bitdefender_R5.X, Bitdefender_R5.Y + 1, 1, 1));
            G.FillRectangle(Bitdefender_P3.Brush, new Rectangle(Bitdefender_R5.Right, Bitdefender_R5.Top + 1, 1, 1));
            //#End Zone
            //#Zone " First line "
            G.DrawLine(Bitdefender_P5, Bitdefender_R5.Left + 29, Bitdefender_R5.Top + 2, Bitdefender_R5.Left + 29, Bitdefender_R5.Bottom - 2);
            G.DrawLine(Bitdefender_P6, Bitdefender_R5.Left + 30, Bitdefender_R5.Top + 2, Bitdefender_R5.Left + 30, Bitdefender_R5.Bottom - 2);
            //#End Zone
            //#Zone " Second line "
            G.DrawLine(Bitdefender_P5, Bitdefender_R5.Left + 56, Bitdefender_R5.Top + 2, Bitdefender_R5.Left + 56, Bitdefender_R5.Bottom - 2);
            G.DrawLine(Bitdefender_P6, Bitdefender_R5.Left + 57, Bitdefender_R5.Top + 2, Bitdefender_R5.Left + 57, Bitdefender_R5.Bottom - 2);
            //#End Zone



            //#Zone " close string "
            Bitdefender_controlboxPath.AddString("r", new FontFamily("Webdings"), Convert.ToInt32(FontStyle.Regular), 15, new Point(Right - Bitdefender_Padding - (Bitdefender_btnSize.Width + 20) + 2, Bitdefender_Padding + 8), null);
            G.FillPath(Brushes.White, Bitdefender_controlboxPath);
            G.DrawPath(Pens.Black, Bitdefender_controlboxPath);
            //#End Zone

            //#Zone " max string "
            switch (Parent.FindForm().WindowState)
            {
                case FormWindowState.Maximized:
                    Bitdefender_controlboxPath.AddString("2", new FontFamily("Webdings"), Convert.ToInt32(FontStyle.Regular), 15, new Point(Right - Bitdefender_Padding - (Bitdefender_btnSize.Width * 2 + 20) + 4, Bitdefender_Padding + 8), null);
                    G.DrawPath(Pens.Black, Bitdefender_controlboxPath);
                    G.FillPath(Brushes.White, Bitdefender_controlboxPath);

                    break;
                case FormWindowState.Normal:
                    Bitdefender_controlboxPath.AddString("1", new FontFamily("Webdings"), Convert.ToInt32(FontStyle.Bold), 15, new Point(Right - Bitdefender_Padding - (Bitdefender_btnSize.Width * 2 + 20) + 2, Bitdefender_Padding + 8), null);
                    G.DrawPath(Pens.Black, Bitdefender_controlboxPath);
                    G.FillPath(Brushes.White, Bitdefender_controlboxPath);
                    break;
            }
            //#End Zone

            //#Zone " min string "
            Bitdefender_controlboxPath.AddString("0", new FontFamily("Webdings"), Convert.ToInt32(FontStyle.Bold), 15, new Point(Right - Bitdefender_Padding - (Bitdefender_btnSize.Width * 3 + 20) + 2, Bitdefender_Padding + 8), null);
            G.DrawPath(Pens.Black, Bitdefender_controlboxPath);
            G.FillPath(Brushes.White, Bitdefender_controlboxPath);
            //#End Zone

        }

        /// <summary>
        /// Bitdefenders the draw control box close.
        /// </summary>
        /// <param name="G">The g.</param>
        private void Bitdefender_DrawControlBox_Close(Graphics G)
        {
            G.SmoothingMode = SmoothingMode.HighQuality;

            G.FillPath(Bitdefender_LGB2, Bitdefender_GP3);

            G.SetClip(new Rectangle(Right - Bitdefender_Padding - (Bitdefender_btnSize.Width + 23) + 1, Bitdefender_Padding, Bitdefender_btnSize.Width + 3, Bitdefender_btnSize.Height));
            G.FillPath(Bitdefender_LGB6, Bitdefender_GP3);
            G.ResetClip();

            G.DrawPath(Bitdefender_P3, Bitdefender_GP3);
            G.DrawPath(Bitdefender_P4, Bitdefender_GP4);

            //#Zone " If you want white line "
            G.DrawLine(Bitdefender_P2, Bitdefender_R5.Left, Bitdefender_R5.Top + 1, Bitdefender_R5.Right, Bitdefender_R5.Top + 1);
            //#End Zone

            //#Zone " Fix     !important "
            G.DrawLine(Bitdefender_P3, Bitdefender_R5.Right, Bitdefender_R5.Top, Bitdefender_R5.Right, Bitdefender_R5.Bottom - 4);
            G.DrawLine(Bitdefender_P4, Bitdefender_R6.Right, Bitdefender_R6.Top + 1, Bitdefender_R6.Right, Bitdefender_R6.Bottom - 4);

            G.SmoothingMode = SmoothingMode.Default;

            G.FillRectangle(Bitdefender_P3.Brush, new Rectangle(Bitdefender_R5.X, Bitdefender_R5.Y + 1, 1, 1));
            G.FillRectangle(Bitdefender_P3.Brush, new Rectangle(Bitdefender_R5.Right, Bitdefender_R5.Top + 1, 1, 1));
            //#End Zone

            //#Zone " First line "
            G.DrawLine(Bitdefender_P5, Bitdefender_R5.Left + 29, Bitdefender_R5.Top + 2, Bitdefender_R5.Left + 29, Bitdefender_R5.Bottom - 2);
            G.DrawLine(Bitdefender_P6, Bitdefender_R5.Left + 30, Bitdefender_R5.Top + 2, Bitdefender_R5.Left + 30, Bitdefender_R5.Bottom - 2);
            //#End Zone

            //#Zone " Second line "
            G.DrawLine(Bitdefender_P5, Bitdefender_R5.Left + 56, Bitdefender_R5.Top + 2, Bitdefender_R5.Left + 56, Bitdefender_R5.Bottom - 2);
            //#End Zone

            //#Zone " close string "
            Bitdefender_controlboxPath.AddString("r", new FontFamily("Webdings"), Convert.ToInt32(FontStyle.Regular), 15, new Point(Right - Bitdefender_Padding - (Bitdefender_btnSize.Width + 20) + 2, Bitdefender_Padding + 10), null);
            G.FillPath(Brushes.White, Bitdefender_controlboxPath);
            G.DrawPath(Pens.Black, Bitdefender_controlboxPath);
            //#End Zone

            //#Zone " max string "
            switch (Parent.FindForm().WindowState)
            {
                case FormWindowState.Maximized:
                    Bitdefender_controlboxPath.AddString("2", new FontFamily("Webdings"), Convert.ToInt32(FontStyle.Regular), 15, new Point(Right - Bitdefender_Padding - (Bitdefender_btnSize.Width * 2 + 20) + 4, Bitdefender_Padding + 8), null);
                    G.DrawPath(Pens.Black, Bitdefender_controlboxPath);
                    G.FillPath(Brushes.White, Bitdefender_controlboxPath);

                    break;
                case FormWindowState.Normal:
                    Bitdefender_controlboxPath.AddString("1", new FontFamily("Webdings"), Convert.ToInt32(FontStyle.Bold), 15, new Point(Right - Bitdefender_Padding - (Bitdefender_btnSize.Width * 2 + 20) + 2, Bitdefender_Padding + 8), null);
                    G.DrawPath(Pens.Black, Bitdefender_controlboxPath);
                    G.FillPath(Brushes.White, Bitdefender_controlboxPath);
                    break;
            }
            //#End Zone

            //#Zone " min string "
            Bitdefender_controlboxPath.AddString("0", new FontFamily("Webdings"), Convert.ToInt32(FontStyle.Bold), 15, new Point(Right - Bitdefender_Padding - (Bitdefender_btnSize.Width * 3 + 20) + 2, Bitdefender_Padding + 8), null);
            G.DrawPath(Pens.Black, Bitdefender_controlboxPath);
            G.FillPath(Brushes.White, Bitdefender_controlboxPath);
            //#End Zone

        }

        /// <summary>
        /// Bitdefenders the draw control box maximum.
        /// </summary>
        /// <param name="G">The g.</param>
        private void Bitdefender_DrawControlBox_Max(Graphics G)
        {
            G.SmoothingMode = SmoothingMode.HighQuality;

            G.FillPath(Bitdefender_LGB2, Bitdefender_GP3);

            G.SetClip(new Rectangle(Right - Bitdefender_Padding - (Bitdefender_btnSize.Width * 2 + 23) + 1, Bitdefender_Padding, Bitdefender_btnSize.Width, Bitdefender_btnSize.Height));
            G.FillPath(Bitdefender_LGB6, Bitdefender_GP3);
            G.ResetClip();

            G.DrawPath(Bitdefender_P3, Bitdefender_GP3);
            G.DrawPath(Bitdefender_P4, Bitdefender_GP4);

            //#Zone " If you want white line "
            G.DrawLine(Bitdefender_P2, Bitdefender_R5.Left, Bitdefender_R5.Top + 1, Bitdefender_R5.Right, Bitdefender_R5.Top + 1);
            //#End Zone

            //#Zone " Fix     !important "
            G.DrawLine(Bitdefender_P3, Bitdefender_R5.Right, Bitdefender_R5.Top, Bitdefender_R5.Right, Bitdefender_R5.Bottom - 4);
            G.DrawLine(Bitdefender_P4, Bitdefender_R6.Right, Bitdefender_R6.Top + 1, Bitdefender_R6.Right, Bitdefender_R6.Bottom - 4);

            G.SmoothingMode = SmoothingMode.Default;

            G.FillRectangle(Bitdefender_P3.Brush, new Rectangle(Bitdefender_R5.X, Bitdefender_R5.Y + 1, 1, 1));
            G.FillRectangle(Bitdefender_P3.Brush, new Rectangle(Bitdefender_R5.Right, Bitdefender_R5.Top + 1, 1, 1));
            //#End Zone

            //#Zone " First line "
            G.DrawLine(Bitdefender_P5, Bitdefender_R5.Left + 29, Bitdefender_R5.Top + 2, Bitdefender_R5.Left + 29, Bitdefender_R5.Bottom - 2);
            //#End Zone

            //#Zone " Second line "
            G.DrawLine(Bitdefender_P5, Bitdefender_R5.Left + 56, Bitdefender_R5.Top + 2, Bitdefender_R5.Left + 56, Bitdefender_R5.Bottom - 2);
            G.DrawLine(Bitdefender_P6, Bitdefender_R5.Left + 57, Bitdefender_R5.Top + 2, Bitdefender_R5.Left + 57, Bitdefender_R5.Bottom - 2);
            //#End Zone

            //#Zone " close string "
            Bitdefender_controlboxPath.AddString("r", new FontFamily("Webdings"), Convert.ToInt32(FontStyle.Regular), 15, new Point(Right - Bitdefender_Padding - (Bitdefender_btnSize.Width + 20) + 2, Bitdefender_Padding + 8), null);
            G.FillPath(Brushes.White, Bitdefender_controlboxPath);
            G.DrawPath(Pens.Black, Bitdefender_controlboxPath);
            //#End Zone

            //#Zone " max string "
            switch (Parent.FindForm().WindowState)
            {
                case FormWindowState.Maximized:
                    Bitdefender_controlboxPath.AddString("2", new FontFamily("Webdings"), Convert.ToInt32(FontStyle.Regular), 15, new Point(Right - Bitdefender_Padding - (Bitdefender_btnSize.Width * 2 + 20) + 4, Bitdefender_Padding + 10), null);
                    G.DrawPath(Pens.Black, Bitdefender_controlboxPath);
                    G.FillPath(Brushes.White, Bitdefender_controlboxPath);

                    break;
                case FormWindowState.Normal:
                    Bitdefender_controlboxPath.AddString("1", new FontFamily("Webdings"), Convert.ToInt32(FontStyle.Bold), 15, new Point(Right - Bitdefender_Padding - (Bitdefender_btnSize.Width * 2 + 20) + 2, Bitdefender_Padding + 10), null);
                    G.DrawPath(Pens.Black, Bitdefender_controlboxPath);
                    G.FillPath(Brushes.White, Bitdefender_controlboxPath);
                    break;
            }
            //#End Zone

            //#Zone " min string "
            Bitdefender_controlboxPath.AddString("0", new FontFamily("Webdings"), Convert.ToInt32(FontStyle.Bold), 15, new Point(Right - Bitdefender_Padding - (Bitdefender_btnSize.Width * 3 + 20) + 2, Bitdefender_Padding + 8), null);
            G.DrawPath(Pens.Black, Bitdefender_controlboxPath);
            G.FillPath(Brushes.White, Bitdefender_controlboxPath);
            //#End Zone
        }

        /// <summary>
        /// Bitdefenders the draw control box minimum.
        /// </summary>
        /// <param name="G">The g.</param>
        private void Bitdefender_DrawControlBox_Min(Graphics G)
        {
            G.SmoothingMode = SmoothingMode.HighQuality;

            G.FillPath(Bitdefender_LGB2, Bitdefender_GP3);

            G.SetClip(new Rectangle(Right - Bitdefender_Padding - (Bitdefender_controlSize.Width + 20) + 1, Bitdefender_Padding, Bitdefender_btnSize.Width + 3, Bitdefender_btnSize.Height));
            G.FillPath(Bitdefender_LGB6, Bitdefender_GP3);
            G.ResetClip();

            G.DrawPath(Bitdefender_P3, Bitdefender_GP3);
            G.DrawPath(Bitdefender_P4, Bitdefender_GP4);

            //#Zone " If you want white line "
            G.DrawLine(Bitdefender_P2, Bitdefender_R5.Left, Bitdefender_R5.Top + 1, Bitdefender_R5.Right, Bitdefender_R5.Top + 1);
            //#End Zone

            //#Zone " Fix     !important "
            G.DrawLine(Bitdefender_P3, Bitdefender_R5.Right, Bitdefender_R5.Top, Bitdefender_R5.Right, Bitdefender_R5.Bottom - 4);
            G.DrawLine(Bitdefender_P4, Bitdefender_R6.Right, Bitdefender_R6.Top + 1, Bitdefender_R6.Right, Bitdefender_R6.Bottom - 4);

            G.SmoothingMode = SmoothingMode.Default;

            G.FillRectangle(Bitdefender_P3.Brush, new Rectangle(Bitdefender_R5.X, Bitdefender_R5.Y + 1, 1, 1));
            G.FillRectangle(Bitdefender_P3.Brush, new Rectangle(Bitdefender_R5.Right, Bitdefender_R5.Top + 1, 1, 1));
            //#End Zone

            //#Zone " First line "
            G.DrawLine(Bitdefender_P5, Bitdefender_R5.Left + 29, Bitdefender_R5.Top + 2, Bitdefender_R5.Left + 29, Bitdefender_R5.Bottom - 2);
            G.DrawLine(Bitdefender_P6, Bitdefender_R5.Left + 30, Bitdefender_R5.Top + 2, Bitdefender_R5.Left + 30, Bitdefender_R5.Bottom - 2);
            //#End Zone

            //#Zone " Second line "
            G.DrawLine(Bitdefender_P5, Bitdefender_R5.Left + 56, Bitdefender_R5.Top + 2, Bitdefender_R5.Left + 56, Bitdefender_R5.Bottom - 2);
            G.DrawLine(Bitdefender_P6, Bitdefender_R5.Left + 57, Bitdefender_R5.Top + 2, Bitdefender_R5.Left + 57, Bitdefender_R5.Bottom - 2);

            //#End Zone

            //#Zone " close string "
            Bitdefender_controlboxPath.AddString("r", new FontFamily("Webdings"), Convert.ToInt32(FontStyle.Regular), 15, new Point(Right - Bitdefender_Padding - (Bitdefender_btnSize.Width + 20) + 2, Bitdefender_Padding + 8), null);
            G.FillPath(Brushes.White, Bitdefender_controlboxPath);
            G.DrawPath(Pens.Black, Bitdefender_controlboxPath);
            //#End Zone

            //#Zone " max string "
            switch (Parent.FindForm().WindowState)
            {
                case FormWindowState.Maximized:
                    Bitdefender_controlboxPath.AddString("2", new FontFamily("Webdings"), Convert.ToInt32(FontStyle.Regular), 15, new Point(Right - Bitdefender_Padding - (Bitdefender_btnSize.Width * 2 + 20) + 4, Bitdefender_Padding + 8), null);
                    G.DrawPath(Pens.Black, Bitdefender_controlboxPath);
                    G.FillPath(Brushes.White, Bitdefender_controlboxPath);

                    break;
                case FormWindowState.Normal:
                    Bitdefender_controlboxPath.AddString("1", new FontFamily("Webdings"), Convert.ToInt32(FontStyle.Bold), 15, new Point(Right - Bitdefender_Padding - (Bitdefender_btnSize.Width * 2 + 20) + 2, Bitdefender_Padding + 8), null);
                    G.DrawPath(Pens.Black, Bitdefender_controlboxPath);
                    G.FillPath(Brushes.White, Bitdefender_controlboxPath);
                    break;
            }
            //#End Zone

            //#Zone " min string "
            Bitdefender_controlboxPath.AddString("0", new FontFamily("Webdings"), Convert.ToInt32(FontStyle.Bold), 15, new Point(Right - Bitdefender_Padding - (Bitdefender_btnSize.Width * 3 + 20) + 2, Bitdefender_Padding + 10), null);
            G.DrawPath(Pens.Black, Bitdefender_controlboxPath);
            G.FillPath(Brushes.White, Bitdefender_controlboxPath);
            //#End Zone
        }


        /// <summary>
        /// Bitdefenders the control rect.
        /// </summary>
        /// <param name="R">The r.</param>
        /// <param name="radius">The radius.</param>
        /// <returns>System.Object.</returns>
        private object Bitdefender_ControlRect(Rectangle R, int radius)
        {
            GraphicsPath GP = new GraphicsPath();
            GP.AddArc(R.Right - radius, R.Bottom - radius, radius, radius, 0, 90);
            GP.AddArc(R.X, R.Bottom - radius, radius, radius, 90, 90);
            GP.AddLine(R.Left, R.Top, R.Right, R.Top);
            return GP;
        }


        #endregion

    }

    /// <summary>
    /// Class Bitdefender_ContainerObjectDisposable.
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public class Bitdefender_ContainerObjectDisposable : IDisposable
    {

        /// <summary>
        /// The i list
        /// </summary>
        private List<IDisposable> iList = new List<IDisposable>();
        /// <summary>
        /// Adds the object.
        /// </summary>
        /// <param name="Obj">The object.</param>
        public void AddObject(IDisposable Obj)
        {
            iList.Add(Obj);
        }
        /// <summary>
        /// Adds the object range.
        /// </summary>
        /// <param name="Obj">The object.</param>
        public void AddObjectRange(IDisposable[] Obj)
        {
            iList.AddRange(Obj);
        }
        #region "IDisposable Support"
        /// <summary>
        /// The disposed value
        /// </summary>
        private bool disposedValue;
        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    foreach (IDisposable ObjectDisposable in iList)
                    {
                        ObjectDisposable.Dispose();
#if DEBUG
                        Debug.WriteLine("Dispose : " + ObjectDisposable.ToString());
#endif
                    }
                }

            }
            iList.Clear();
            this.disposedValue = true;
        }
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

    }


}


