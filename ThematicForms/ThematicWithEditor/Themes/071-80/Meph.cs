// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Meph.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 80. Meph

        private string _subHeader = "Insert Sub Header";
        public string SubHeader
        {
            get { return _subHeader; }
            set
            {
                _subHeader = value;
                Invalidate();
            }
        }

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
    }
}
