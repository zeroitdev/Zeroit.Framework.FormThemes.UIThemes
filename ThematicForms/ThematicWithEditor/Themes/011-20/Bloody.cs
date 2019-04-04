// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Bloody.cs" company="Zeroit Dev Technologies">
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
        #region 15. Bloody


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
    }
}
