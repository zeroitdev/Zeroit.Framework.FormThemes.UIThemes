// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="ControlBoxFunctionality.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    /// <summary>
    /// Class Thematic150WithEditor.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.FormThemes.UIThemes.ThemeContainer154" />
    public partial class Thematic150WithEditor
    {
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
}
