// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Visceral.cs" company="Zeroit Dev Technologies">
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
        #region 136. Visceral

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
    }
}
