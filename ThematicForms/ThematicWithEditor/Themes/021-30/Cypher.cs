// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Cypher.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 30. Cypher


        Bitmap Bgimagee;

        Rectangle Balk;

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

        bool EnteredMinimize = false;

        bool EntredClose = false;
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

        bool FadingOut = true;
        // <summary>
        // This boolean indicates the use of the Fade Out Effect on close
        // </summary>
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
        Point Point = new Point();
        //int X;
        //#endregion
        //int Y;


        #endregion

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
    }
}
