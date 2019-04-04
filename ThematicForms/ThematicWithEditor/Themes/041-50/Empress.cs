// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Empress.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 45. Empress

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
    }
}
