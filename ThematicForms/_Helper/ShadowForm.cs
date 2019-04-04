// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-25-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="ShadowForm.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    /// <summary>
    /// Class ShadowForm.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public class ShadowForm : System.Windows.Forms.Form
    {
        #region Constructor

        #endregion

        #region Methods
        /// <summary>
        /// Computes my size.
        /// </summary>
        /// <param name="f">The f.</param>
        /// <param name="borderTimes2">The border times2.</param>
        /// <returns>Size.</returns>
        static Size ComputeMySize(System.Windows.Forms.Form f, int borderTimes2)
        {
            return new Size(f.Width + borderTimes2, f.Height + borderTimes2);
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the size of the border.
        /// </summary>
        /// <value>The size of the border.</value>
        public int BorderSize { get; set; } = 5;
        /// <summary>
        /// Gets or sets the window opacity.
        /// </summary>
        /// <value>The window opacity.</value>
        public float WindowOpacity { get; set; } = 0.30F;
        /// <summary>
        /// Gets or sets the shadow owner.
        /// </summary>
        /// <value>The shadow owner.</value>
        public System.Windows.Forms.Form ShadowOwner { get; set; }
        /// <summary>
        /// Gets or sets the color of the shadow.
        /// </summary>
        /// <value>The color of the shadow.</value>
        public Color ShadowColor { get; set; } = Color.Black;
        #endregion

        #region Other
        /// <summary>
        /// Shows the specified f.
        /// </summary>
        /// <param name="f">The f.</param>
        public void Show(System.Windows.Forms.Form f)
        {
            BackColor = ShadowColor;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            DoubleBuffered = true;
            if (f != null) {
                this.ShowInTaskbar = false;
                f.FormClosing += (sender, e) => this.Dispose();
                MaximizeBox = f.MaximizeBox;
                MinimizeBox = f.MinimizeBox;
                f.Load += (sender, e) => {
                    Left = f.Left - BorderSize;
                    Top = f.Top - BorderSize;
                    this.Opacity = WindowOpacity;
                };

                base.Show();
                this.Left = f.Left - BorderSize;
                this.Top = f.Top - BorderSize;
                switch (f.WindowState) {
                    case FormWindowState.Maximized:
                        this.Opacity = 0;
                        break;
                    default:
                        this.Opacity = WindowOpacity;
                        break;
                }

                var borderTimes2 = BorderSize * 2;
                this.Size = new Size(f.Width + borderTimes2, f.Height + borderTimes2);
                f.Move += (sender, e) => {
                    Refresh();
                    this.Left = f.Left - BorderSize;
                    this.Top = f.Top - BorderSize;
                };
                f.Owner = this;
                DoubleBuffered = true;
                ShadowOwner = f;
                f.VisibleChanged += (sender, e) => {
                    switch (f.WindowState) {
                        case FormWindowState.Maximized:
                            this.Opacity = 0;
                            break;
                        default:
                            this.Opacity = f.Visible ? WindowOpacity : 0;
                            break;
                    }
                };
                f.SizeChanged += (sender, e) => {
                    switch (f.WindowState) {
                        case FormWindowState.Maximized:
                            this.Opacity = 0;
                            break;
                        default:
                            this.Opacity = WindowOpacity;
                            break;
                    }
                    Refresh();
                    this.Size = ComputeMySize(f, borderTimes2);
                };
            }
        }
        /// <summary>
        /// Gets a value indicating whether the window will be activated when it is shown.
        /// </summary>
        /// <value><c>true</c> if [show without activation]; otherwise, <c>false</c>.</value>
        protected override bool ShowWithoutActivation {
            get {
                return true;
            }
        }
        #endregion
    }
    
}