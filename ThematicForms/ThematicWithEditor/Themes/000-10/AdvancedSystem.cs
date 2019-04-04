// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="AdvancedSystem.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 2. Advanced System 

        private int moveHeight = 38;
        private bool formCanMove = false;
        private int mouseX;
        private int mouseY;
        private bool overExit;

        private bool overMin;

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

        void AdvancedSystem_OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            //base.OnMouseUp(e);
            formCanMove = false;
        }


        private void AdvancedSystem_Hook(PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.Clear(Parent.FindForm().TransparencyKey);
            //G.Clear(BackColor);
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
    }
}
