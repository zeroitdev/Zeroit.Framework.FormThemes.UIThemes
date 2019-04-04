// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="MainFormTheme.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace Zeroit.Framework.FormThemes.Helper
{

   
    #region Theme Base
    
    /// <summary>
    /// Class ThemeContainer154.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.ContainerControl" />
    public abstract class ThemeContainer154 : ContainerControl
    {

        #region " Initialization "

        /// <summary>
        /// The g
        /// </summary>
        protected Graphics G;

        /// <summary>
        /// The b
        /// </summary>
        protected Bitmap B;
        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeContainer154"/> class.
        /// </summary>
        public ThemeContainer154()
        {
            SetStyle((ControlStyles)139270, true);

            _ImageSize = Size.Empty;
            Font = new Font("Verdana", 8);

            MeasureBitmap = new Bitmap(1, 1);
            MeasureGraphics = Graphics.FromImage(MeasureBitmap);

            DrawRadialPath = new GraphicsPath();

            InvalidateCustimization();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.HandleCreated" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override sealed void OnHandleCreated(EventArgs e)
        {
            if (DoneCreation)
                InitializeMessages();

            InvalidateCustimization();
            ColorHook();

            if (!(_LockWidth == 0))
                Width = _LockWidth;
            if (!(_LockHeight == 0))
                Height = _LockHeight;
            if (!_ControlMode)
                base.Dock = DockStyle.Fill;

            Transparent = _Transparent;
            if (_Transparent && _BackColor)
                BackColor = Color.Transparent;

            base.OnHandleCreated(e);
        }

        /// <summary>
        /// The done creation
        /// </summary>
        private bool DoneCreation;
        /// <summary>
        /// Handles the <see cref="E:ParentChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override sealed void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);

            if (Parent == null)
                return;
            _IsParentForm = Parent is System.Windows.Forms.Form;

            if (!_ControlMode)
            {
                InitializeMessages();

                if (_IsParentForm)
                {
                    ParentForm.FormBorderStyle = _BorderStyle;
                    ParentForm.TransparencyKey = _TransparencyKey;

                    if (!DesignMode)
                    {
                        ParentForm.Shown += FormShown;
                    }
                }

                Parent.BackColor = BackColor;
            }

            OnCreation();
            DoneCreation = true;
            InvalidateTimer();
        }

        #endregion

        /// <summary>
        /// Does the animation.
        /// </summary>
        /// <param name="i">if set to <c>true</c> [i].</param>
        private void DoAnimation(bool i)
        {
            OnAnimation();
            if (i)
                Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        protected override sealed void OnPaint(PaintEventArgs e)
        {
            if (Width == 0 || Height == 0)
                return;

            if (_Transparent && _ControlMode)
            {
                PaintHook();
                e.Graphics.DrawImage(B, 0, 0);
            }
            else
            {
                G = e.Graphics;
                PaintHook();
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.HandleDestroyed" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnHandleDestroyed(EventArgs e)
        {
            ThemeShare.RemoveAnimationCallback(DoAnimation);
            base.OnHandleDestroyed(e);
        }

        /// <summary>
        /// The has shown
        /// </summary>
        private bool HasShown;
        /// <summary>
        /// Forms the shown.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FormShown(object sender, EventArgs e)
        {
            if (_ControlMode || HasShown)
                return;

            if (_StartPosition == FormStartPosition.CenterParent || _StartPosition == FormStartPosition.CenterScreen)
            {
                Rectangle SB = Screen.PrimaryScreen.Bounds;
                Rectangle CB = ParentForm.Bounds;
                ParentForm.Location = new Point(SB.Width / 2 - CB.Width / 2, SB.Height / 2 - CB.Width / 2);
            }

            HasShown = true;
        }


        #region " Size Handling "

        /// <summary>
        /// The frame
        /// </summary>
        private Rectangle Frame;
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.SizeChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override sealed void OnSizeChanged(EventArgs e)
        {
            if (_Movable && !_ControlMode)
            {
                Frame = new Rectangle(7, 7, Width - 14, _Header - 7);
            }

            InvalidateBitmap();
            Invalidate();

            base.OnSizeChanged(e);
        }

        /// <summary>
        /// Performs the work of setting the specified bounds of this control.
        /// </summary>
        /// <param name="x">The new <see cref="P:System.Windows.Forms.Control.Left" /> property value of the control.</param>
        /// <param name="y">The new <see cref="P:System.Windows.Forms.Control.Top" /> property value of the control.</param>
        /// <param name="width">The new <see cref="P:System.Windows.Forms.Control.Width" /> property value of the control.</param>
        /// <param name="height">The new <see cref="P:System.Windows.Forms.Control.Height" /> property value of the control.</param>
        /// <param name="specified">A bitwise combination of the <see cref="T:System.Windows.Forms.BoundsSpecified" /> values.</param>
        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            if (!(_LockWidth == 0))
                width = _LockWidth;
            if (!(_LockHeight == 0))
                height = _LockHeight;
            base.SetBoundsCore(x, y, width, height, specified);
        }

        #endregion

        #region " State Handling "

        /// <summary>
        /// The state
        /// </summary>
        protected MouseState State;
        /// <summary>
        /// Sets the state.
        /// </summary>
        /// <param name="current">The current.</param>
        private void SetState(MouseState current)
        {
            State = current;
            Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseMove" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (!(_IsParentForm && ParentForm.WindowState == FormWindowState.Maximized))
            {
                if (_Sizable && !_ControlMode)
                    InvalidateMouse();
            }

            base.OnMouseMove(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.EnabledChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnEnabledChanged(EventArgs e)
        {
            if (Enabled)
                SetState(MouseState.None);
            else
                SetState(MouseState.Block);
            base.OnEnabledChanged(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseEnter" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnMouseEnter(EventArgs e)
        {
            SetState(MouseState.Over);
            base.OnMouseEnter(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseUp" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            SetState(MouseState.Over);
            base.OnMouseUp(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseLeave" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnMouseLeave(EventArgs e)
        {
            SetState(MouseState.None);

            if (GetChildAtPoint(PointToClient(MousePosition)) != null)
            {
                if (_Sizable && !_ControlMode)
                {
                    Cursor = Cursors.Default;
                    Previous = 0;
                }
            }

            base.OnMouseLeave(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseDown" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                SetState(MouseState.Down);

            if (!(_IsParentForm && ParentForm.WindowState == FormWindowState.Maximized || _ControlMode))
            {
                if (_Movable && Frame.Contains(e.Location))
                {
                    Capture = false;
                    WM_LMBUTTONDOWN = true;
                    DefWndProc(ref Messages[0]);
                }
                else if (_Sizable && !(Previous == 0))
                {
                    Capture = false;
                    WM_LMBUTTONDOWN = true;
                    DefWndProc(ref Messages[Previous]);
                }
            }

            base.OnMouseDown(e);
        }

        /// <summary>
        /// The wm lmbuttondown
        /// </summary>
        private bool WM_LMBUTTONDOWN;
        /// <summary>
        /// Processes Windows messages.
        /// </summary>
        /// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message" /> to process.</param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (WM_LMBUTTONDOWN && m.Msg == 513)
            {
                WM_LMBUTTONDOWN = false;

                SetState(MouseState.Over);
                if (!_SmartBounds)
                    return;

                if (IsParentMdi)
                {
                    CorrectBounds(new Rectangle(Point.Empty, Parent.Parent.Size));
                }
                else
                {
                    CorrectBounds(Screen.FromControl(Parent).WorkingArea);
                }
            }
        }

        /// <summary>
        /// The get index point
        /// </summary>
        private Point GetIndexPoint;
        /// <summary>
        /// The b1
        /// </summary>
        private bool B1;
        /// <summary>
        /// The b2
        /// </summary>
        private bool B2;
        /// <summary>
        /// The b3
        /// </summary>
        private bool B3;
        /// <summary>
        /// The b4
        /// </summary>
        private bool B4;
        /// <summary>
        /// Gets the index.
        /// </summary>
        /// <returns>System.Int32.</returns>
        private int GetIndex()
        {
            GetIndexPoint = PointToClient(MousePosition);
            B1 = GetIndexPoint.X < 7;
            B2 = GetIndexPoint.X > Width - 7;
            B3 = GetIndexPoint.Y < 7;
            B4 = GetIndexPoint.Y > Height - 7;

            if (B1 && B3)
                return 4;
            if (B1 && B4)
                return 7;
            if (B2 && B3)
                return 5;
            if (B2 && B4)
                return 8;
            if (B1)
                return 1;
            if (B2)
                return 2;
            if (B3)
                return 3;
            if (B4)
                return 6;
            return 0;
        }

        /// <summary>
        /// The current
        /// </summary>
        private int Current;
        /// <summary>
        /// The previous
        /// </summary>
        private int Previous;
        /// <summary>
        /// Invalidates the mouse.
        /// </summary>
        private void InvalidateMouse()
        {
            Current = GetIndex();
            if (Current == Previous)
                return;

            Previous = Current;
            switch (Previous)
            {
                case 0:
                    Cursor = Cursors.Default;
                    break;
                case 1:
                case 2:
                    Cursor = Cursors.SizeWE;
                    break;
                case 3:
                case 6:
                    Cursor = Cursors.SizeNS;
                    break;
                case 4:
                case 8:
                    Cursor = Cursors.SizeNWSE;
                    break;
                case 5:
                case 7:
                    Cursor = Cursors.SizeNESW;
                    break;
            }
        }

        /// <summary>
        /// The messages
        /// </summary>
        private Message[] Messages = new Message[9];
        /// <summary>
        /// Initializes the messages.
        /// </summary>
        private void InitializeMessages()
        {
            Messages[0] = Message.Create(Parent.Handle, 161, new IntPtr(2), IntPtr.Zero);
            for (int I = 1; I <= 8; I++)
            {
                Messages[I] = Message.Create(Parent.Handle, 161, new IntPtr(I + 9), IntPtr.Zero);
            }
        }

        /// <summary>
        /// Corrects the bounds.
        /// </summary>
        /// <param name="bounds">The bounds.</param>
        private void CorrectBounds(Rectangle bounds)
        {
            if (Parent.Width > bounds.Width)
                Parent.Width = bounds.Width;
            if (Parent.Height > bounds.Height)
                Parent.Height = bounds.Height;

            int X = Parent.Location.X;
            int Y = Parent.Location.Y;

            if (X < bounds.X)
                X = bounds.X;
            if (Y < bounds.Y)
                Y = bounds.Y;

            int Width = bounds.X + bounds.Width;
            int Height = bounds.Y + bounds.Height;

            if (X + Parent.Width > Width)
                X = Width - Parent.Width;
            if (Y + Parent.Height > Height)
                Y = Height - Parent.Height;

            Parent.Location = new Point(X, Y);
        }

        #endregion


        #region " Base Properties "

        /// <summary>
        /// Gets or sets which control borders are docked to its parent control and determines how a control is resized with its parent.
        /// </summary>
        /// <value>The dock.</value>
        public override DockStyle Dock
        {
            get { return base.Dock; }
            set
            {
                if (!_ControlMode)
                    return;
                base.Dock = value;
            }
        }

        /// <summary>
        /// The back color
        /// </summary>
        private bool _BackColor;
        /// <summary>
        /// Gets or sets the background color for the control.
        /// </summary>
        /// <value>The color of the back.</value>
        [Category("Misc")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                if (value == base.BackColor)
                    return;

                if (!IsHandleCreated && _ControlMode && value == Color.Transparent)
                {
                    _BackColor = true;
                    return;
                }

                base.BackColor = value;
                if (Parent != null)
                {
                    if (!_ControlMode)
                        Parent.BackColor = value;
                    ColorHook();
                }
            }
        }

        /// <summary>
        /// Gets or sets the size that is the lower limit that <see cref="M:System.Windows.Forms.Control.GetPreferredSize(System.Drawing.Size)" /> can specify.
        /// </summary>
        /// <value>The minimum size.</value>
        public override Size MinimumSize
        {
            get { return base.MinimumSize; }
            set
            {
                base.MinimumSize = value;
                if (Parent != null)
                    Parent.MinimumSize = value;
            }
        }

        /// <summary>
        /// Gets or sets the size that is the upper limit that <see cref="M:System.Windows.Forms.Control.GetPreferredSize(System.Drawing.Size)" /> can specify.
        /// </summary>
        /// <value>The maximum size.</value>
        public override Size MaximumSize
        {
            get { return base.MaximumSize; }
            set
            {
                base.MaximumSize = value;
                if (Parent != null)
                    Parent.MaximumSize = value;
            }
        }

        /// <summary>
        /// Gets or sets the text associated with this control.
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
        /// Gets or sets the font of the text displayed by the control.
        /// </summary>
        /// <value>The font.</value>
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the foreground color of the control.
        /// </summary>
        /// <value>The color of the fore.</value>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color ForeColor
        {
            get { return Color.Empty; }
            set { }
        }
        /// <summary>
        /// Gets or sets the background image displayed in the control.
        /// </summary>
        /// <value>The background image.</value>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Image BackgroundImage
        {
            get { return null; }
            set { }
        }
        /// <summary>
        /// Gets or sets the background image layout as defined in the <see cref="T:System.Windows.Forms.ImageLayout" /> enumeration.
        /// </summary>
        /// <value>The background image layout.</value>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override ImageLayout BackgroundImageLayout
        {
            get { return ImageLayout.None; }
            set { }
        }

        #endregion

        #region " Public Properties "

        /// <summary>
        /// The smart bounds
        /// </summary>
        private bool _SmartBounds = true;
        /// <summary>
        /// Gets or sets a value indicating whether [smart bounds].
        /// </summary>
        /// <value><c>true</c> if [smart bounds]; otherwise, <c>false</c>.</value>
        public bool SmartBounds
        {
            get { return _SmartBounds; }
            set { _SmartBounds = value; }
        }

        /// <summary>
        /// The movable
        /// </summary>
        private bool _Movable = true;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ThemeContainer154"/> is movable.
        /// </summary>
        /// <value><c>true</c> if movable; otherwise, <c>false</c>.</value>
        public bool Movable
        {
            get { return _Movable; }
            set { _Movable = value; }
        }

        /// <summary>
        /// The sizable
        /// </summary>
        private bool _Sizable = true;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ThemeContainer154"/> is sizable.
        /// </summary>
        /// <value><c>true</c> if sizable; otherwise, <c>false</c>.</value>
        public bool Sizable
        {
            get { return _Sizable; }
            set { _Sizable = value; }
        }

        /// <summary>
        /// The transparency key
        /// </summary>
        private Color _TransparencyKey;
        /// <summary>
        /// Gets or sets the transparency key.
        /// </summary>
        /// <value>The transparency key.</value>
        public Color TransparencyKey
        {
            get
            {
                if (_IsParentForm && !_ControlMode)
                    return ParentForm.TransparencyKey;
                else
                    return _TransparencyKey;
            }
            set
            {
                if (value == _TransparencyKey)
                    return;
                _TransparencyKey = value;

                if (_IsParentForm && !_ControlMode)
                {
                    ParentForm.TransparencyKey = value;
                    ColorHook();
                }
            }
        }

        /// <summary>
        /// The border style
        /// </summary>
        private FormBorderStyle _BorderStyle;
        /// <summary>
        /// Gets or sets the border style.
        /// </summary>
        /// <value>The border style.</value>
        public FormBorderStyle BorderStyle
        {
            get
            {
                if (_IsParentForm && !_ControlMode)
                    return ParentForm.FormBorderStyle;
                else
                    return _BorderStyle;
            }
            set
            {
                _BorderStyle = value;

                if (_IsParentForm && !_ControlMode)
                {
                    ParentForm.FormBorderStyle = value;

                    if (!(value == FormBorderStyle.None))
                    {
                        Movable = false;
                        Sizable = false;
                    }
                }
            }
        }

        /// <summary>
        /// The start position
        /// </summary>
        private FormStartPosition _StartPosition;
        /// <summary>
        /// Gets or sets the start position.
        /// </summary>
        /// <value>The start position.</value>
        public FormStartPosition StartPosition
        {
            get
            {
                if (_IsParentForm && !_ControlMode)
                    return ParentForm.StartPosition;
                else
                    return _StartPosition;
            }
            set
            {
                _StartPosition = value;

                if (_IsParentForm && !_ControlMode)
                {
                    ParentForm.StartPosition = value;
                }
            }
        }

        /// <summary>
        /// The no rounding
        /// </summary>
        private bool _NoRounding;
        /// <summary>
        /// Gets or sets a value indicating whether [no rounding].
        /// </summary>
        /// <value><c>true</c> if [no rounding]; otherwise, <c>false</c>.</value>
        public bool NoRounding
        {
            get { return _NoRounding; }
            set
            {
                _NoRounding = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The image
        /// </summary>
        private Image _Image;
        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>The image.</value>
        public Image Image
        {
            get { return _Image; }
            set
            {
                if (value == null)
                    _ImageSize = Size.Empty;
                else
                    _ImageSize = value.Size;

                _Image = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The items
        /// </summary>
        private Dictionary<string, Color> Items = new Dictionary<string, Color>();
        /// <summary>
        /// Gets or sets the colors.
        /// </summary>
        /// <value>The colors.</value>
        public Bloom[] Colors
        {
            get
            {
                List<Bloom> T = new List<Bloom>();
                Dictionary<string, Color>.Enumerator E = Items.GetEnumerator();

                while (E.MoveNext())
                {
                    T.Add(new Bloom(E.Current.Key, E.Current.Value));
                }

                return T.ToArray();
            }
            set
            {
                foreach (Bloom B in value)
                {
                    if (Items.ContainsKey(B.Name))
                        Items[B.Name] = B.Value;
                }

                InvalidateCustimization();
                ColorHook();
                Invalidate();
            }
        }

        /// <summary>
        /// The customization
        /// </summary>
        private string _Customization;
        /// <summary>
        /// Gets or sets the customization.
        /// </summary>
        /// <value>The customization.</value>
        public string Customization
        {
            get { return _Customization; }
            set
            {
                if (value == _Customization)
                    return;

                byte[] Data = null;
                Bloom[] Items = Colors;

                try
                {
                    Data = Convert.FromBase64String(value);
                    for (int I = 0; I <= Items.Length - 1; I++)
                    {
                        Items[I].Value = Color.FromArgb(BitConverter.ToInt32(Data, I * 4));
                    }
                }
                catch
                {
                    return;
                }

                _Customization = value;

                Colors = Items;
                ColorHook();
                Invalidate();
            }
        }

        /// <summary>
        /// The transparent
        /// </summary>
        private bool _Transparent;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ThemeContainer154"/> is transparent.
        /// </summary>
        /// <value><c>true</c> if transparent; otherwise, <c>false</c>.</value>
        /// <exception cref="System.Exception">Unable to change value to false while a transparent BackColor is in use.</exception>
        public bool Transparent
        {
            get { return _Transparent; }
            set
            {
                _Transparent = value;
                if (!(IsHandleCreated || _ControlMode))
                    return;

                if (!value && !(BackColor.A == 255))
                {
                    throw new Exception("Unable to change value to false while a transparent BackColor is in use.");
                }

                SetStyle(ControlStyles.Opaque, !value);
                SetStyle(ControlStyles.SupportsTransparentBackColor, value);

                InvalidateBitmap();
                Invalidate();
            }
        }

        #endregion

        #region " Private Properties "

        /// <summary>
        /// The image size
        /// </summary>
        private Size _ImageSize;
        /// <summary>
        /// Gets the size of the image.
        /// </summary>
        /// <value>The size of the image.</value>
        protected Size ImageSize
        {
            get { return _ImageSize; }
        }

        /// <summary>
        /// The is parent form
        /// </summary>
        private bool _IsParentForm;
        /// <summary>
        /// Gets a value indicating whether this instance is parent form.
        /// </summary>
        /// <value><c>true</c> if this instance is parent form; otherwise, <c>false</c>.</value>
        protected bool IsParentForm
        {
            get { return _IsParentForm; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is parent MDI.
        /// </summary>
        /// <value><c>true</c> if this instance is parent MDI; otherwise, <c>false</c>.</value>
        protected bool IsParentMdi
        {
            get
            {
                if (Parent == null)
                    return false;
                return Parent.Parent != null;
            }
        }

        /// <summary>
        /// The lock width
        /// </summary>
        private int _LockWidth;
        /// <summary>
        /// Gets or sets the width of the lock.
        /// </summary>
        /// <value>The width of the lock.</value>
        protected int LockWidth
        {
            get { return _LockWidth; }
            set
            {
                _LockWidth = value;
                if (!(LockWidth == 0) && IsHandleCreated)
                    Width = LockWidth;
            }
        }

        /// <summary>
        /// The lock height
        /// </summary>
        private int _LockHeight;
        /// <summary>
        /// Gets or sets the height of the lock.
        /// </summary>
        /// <value>The height of the lock.</value>
        protected int LockHeight
        {
            get { return _LockHeight; }
            set
            {
                _LockHeight = value;
                if (!(LockHeight == 0) && IsHandleCreated)
                    Height = LockHeight;
            }
        }

        /// <summary>
        /// The header
        /// </summary>
        private int _Header = 24;
        /// <summary>
        /// Gets or sets the header.
        /// </summary>
        /// <value>The header.</value>
        protected int Header
        {
            get { return _Header; }
            set
            {
                _Header = value;

                if (!_ControlMode)
                {
                    Frame = new Rectangle(7, 7, Width - 14, value - 7);
                    Invalidate();
                }
            }
        }

        /// <summary>
        /// The control mode
        /// </summary>
        private bool _ControlMode;
        /// <summary>
        /// Gets or sets a value indicating whether [control mode].
        /// </summary>
        /// <value><c>true</c> if [control mode]; otherwise, <c>false</c>.</value>
        protected bool ControlMode
        {
            get { return _ControlMode; }
            set
            {
                _ControlMode = value;

                Transparent = _Transparent;
                if (_Transparent && _BackColor)
                    BackColor = Color.Transparent;

                InvalidateBitmap();
                Invalidate();
            }
        }

        /// <summary>
        /// The is animated
        /// </summary>
        private bool _IsAnimated;
        /// <summary>
        /// Gets or sets a value indicating whether this instance is animated.
        /// </summary>
        /// <value><c>true</c> if this instance is animated; otherwise, <c>false</c>.</value>
        protected bool IsAnimated
        {
            get { return _IsAnimated; }
            set
            {
                _IsAnimated = value;
                InvalidateTimer();
            }
        }

        #endregion


        #region " Property Helpers "

        /// <summary>
        /// Gets the pen.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Pen.</returns>
        protected Pen GetPen(string name)
        {
            return new Pen(Items[name]);
        }
        /// <summary>
        /// Gets the pen.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="width">The width.</param>
        /// <returns>Pen.</returns>
        protected Pen GetPen(string name, float width)
        {
            return new Pen(Items[name], width);
        }

        /// <summary>
        /// Gets the brush.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>SolidBrush.</returns>
        protected SolidBrush GetBrush(string name)
        {
            return new SolidBrush(Items[name]);
        }

        /// <summary>
        /// Gets the color.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Color.</returns>
        protected Color GetColor(string name)
        {
            return Items[name];
        }

        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        protected void SetColor(string name, Color value)
        {
            if (Items.ContainsKey(name))
                Items[name] = value;
            else
                Items.Add(name, value);
        }
        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="r">The r.</param>
        /// <param name="g">The g.</param>
        /// <param name="b">The b.</param>
        protected void SetColor(string name, byte r, byte g, byte b)
        {
            SetColor(name, Color.FromArgb(r, g, b));
        }
        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="a">a.</param>
        /// <param name="r">The r.</param>
        /// <param name="g">The g.</param>
        /// <param name="b">The b.</param>
        protected void SetColor(string name, byte a, byte r, byte g, byte b)
        {
            SetColor(name, Color.FromArgb(a, r, g, b));
        }
        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="a">a.</param>
        /// <param name="value">The value.</param>
        protected void SetColor(string name, byte a, Color value)
        {
            SetColor(name, Color.FromArgb(a, value));
        }

        /// <summary>
        /// Invalidates the bitmap.
        /// </summary>
        private void InvalidateBitmap()
        {
            if (_Transparent && _ControlMode)
            {
                if (Width == 0 || Height == 0)
                    return;
                B = new Bitmap(Width, Height, PixelFormat.Format32bppPArgb);
                G = Graphics.FromImage(B);
            }
            else
            {
                G = null;
                B = null;
            }
        }

        /// <summary>
        /// Invalidates the custimization.
        /// </summary>
        private void InvalidateCustimization()
        {
            MemoryStream M = new MemoryStream(Items.Count * 4);

            foreach (Bloom B in Colors)
            {
                M.Write(BitConverter.GetBytes(B.Value.ToArgb()), 0, 4);
            }

            M.Close();
            _Customization = Convert.ToBase64String(M.ToArray());
        }

        /// <summary>
        /// Invalidates the timer.
        /// </summary>
        private void InvalidateTimer()
        {
            if (DesignMode || !DoneCreation)
                return;

            if (_IsAnimated)
            {
                ThemeShare.AddAnimationCallback(DoAnimation);
            }
            else
            {
                ThemeShare.RemoveAnimationCallback(DoAnimation);
            }
        }

        #endregion


        #region " User Hooks "

        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected abstract void ColorHook();
        /// <summary>
        /// Paints the hook.
        /// </summary>
        protected abstract void PaintHook();

        /// <summary>
        /// Called when [creation].
        /// </summary>
        protected virtual void OnCreation()
        {
        }

        /// <summary>
        /// Called when [animation].
        /// </summary>
        protected virtual void OnAnimation()
        {
        }

        #endregion


        #region " Offset "

        /// <summary>
        /// The offset return rectangle
        /// </summary>
        private Rectangle OffsetReturnRectangle;
        /// <summary>
        /// Offsets the specified r.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="amount">The amount.</param>
        /// <returns>Rectangle.</returns>
        protected Rectangle Offset(Rectangle r, int amount)
        {
            OffsetReturnRectangle = new Rectangle(r.X + amount, r.Y + amount, r.Width - (amount * 2), r.Height - (amount * 2));
            return OffsetReturnRectangle;
        }

        /// <summary>
        /// The offset return size
        /// </summary>
        private Size OffsetReturnSize;
        /// <summary>
        /// Offsets the specified s.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="amount">The amount.</param>
        /// <returns>Size.</returns>
        protected Size Offset(Size s, int amount)
        {
            OffsetReturnSize = new Size(s.Width + amount, s.Height + amount);
            return OffsetReturnSize;
        }

        /// <summary>
        /// The offset return point
        /// </summary>
        private Point OffsetReturnPoint;
        /// <summary>
        /// Offsets the specified p.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="amount">The amount.</param>
        /// <returns>Point.</returns>
        protected Point Offset(Point p, int amount)
        {
            OffsetReturnPoint = new Point(p.X + amount, p.Y + amount);
            return OffsetReturnPoint;
        }

        #endregion

        #region " Center "


        /// <summary>
        /// The center return
        /// </summary>
        private Point CenterReturn;
        /// <summary>
        /// Centers the specified p.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="c">The c.</param>
        /// <returns>Point.</returns>
        protected Point Center(Rectangle p, Rectangle c)
        {
            CenterReturn = new Point((p.Width / 2 - c.Width / 2) + p.X + c.X, (p.Height / 2 - c.Height / 2) + p.Y + c.Y);
            return CenterReturn;
        }
        /// <summary>
        /// Centers the specified p.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="c">The c.</param>
        /// <returns>Point.</returns>
        protected Point Center(Rectangle p, Size c)
        {
            CenterReturn = new Point((p.Width / 2 - c.Width / 2) + p.X, (p.Height / 2 - c.Height / 2) + p.Y);
            return CenterReturn;
        }

        /// <summary>
        /// Centers the specified child.
        /// </summary>
        /// <param name="child">The child.</param>
        /// <returns>Point.</returns>
        protected Point Center(Rectangle child)
        {
            return Center(Width, Height, child.Width, child.Height);
        }
        /// <summary>
        /// Centers the specified child.
        /// </summary>
        /// <param name="child">The child.</param>
        /// <returns>Point.</returns>
        protected Point Center(Size child)
        {
            return Center(Width, Height, child.Width, child.Height);
        }
        /// <summary>
        /// Centers the specified child width.
        /// </summary>
        /// <param name="childWidth">Width of the child.</param>
        /// <param name="childHeight">Height of the child.</param>
        /// <returns>Point.</returns>
        protected Point Center(int childWidth, int childHeight)
        {
            return Center(Width, Height, childWidth, childHeight);
        }

        /// <summary>
        /// Centers the specified p.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="c">The c.</param>
        /// <returns>Point.</returns>
        protected Point Center(Size p, Size c)
        {
            return Center(p.Width, p.Height, c.Width, c.Height);
        }

        /// <summary>
        /// Centers the specified p width.
        /// </summary>
        /// <param name="pWidth">Width of the p.</param>
        /// <param name="pHeight">Height of the p.</param>
        /// <param name="cWidth">Width of the c.</param>
        /// <param name="cHeight">Height of the c.</param>
        /// <returns>Point.</returns>
        protected Point Center(int pWidth, int pHeight, int cWidth, int cHeight)
        {
            CenterReturn = new Point(pWidth / 2 - cWidth / 2, pHeight / 2 - cHeight / 2);
            return CenterReturn;
        }

        #endregion

        #region " Measure "

        /// <summary>
        /// The measure bitmap
        /// </summary>
        private Bitmap MeasureBitmap;

        /// <summary>
        /// The measure graphics
        /// </summary>
        private Graphics MeasureGraphics;
        /// <summary>
        /// Measures this instance.
        /// </summary>
        /// <returns>Size.</returns>
        protected Size Measure()
        {
            lock (MeasureGraphics)
            {
                return MeasureGraphics.MeasureString(Text, Font, Width).ToSize();
            }
        }
        /// <summary>
        /// Measures the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>Size.</returns>
        protected Size Measure(string text)
        {
            lock (MeasureGraphics)
            {
                return MeasureGraphics.MeasureString(text, Font, Width).ToSize();
            }
        }

        #endregion


        #region " DrawPixel "


        /// <summary>
        /// The draw pixel brush
        /// </summary>
        private SolidBrush DrawPixelBrush;
        /// <summary>
        /// Draws the pixel.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawPixel(Color c1, int x, int y)
        {
            if (_Transparent)
            {
                B.SetPixel(x, y, c1);
            }
            else
            {
                DrawPixelBrush = new SolidBrush(c1);
                G.FillRectangle(DrawPixelBrush, x, y, 1, 1);
            }
        }

        #endregion

        #region " DrawCorners "


        /// <summary>
        /// The draw corners brush
        /// </summary>
        private SolidBrush DrawCornersBrush;
        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawCorners(Color c1, int offset)
        {
            DrawCorners(c1, 0, 0, Width, Height, offset);
        }
        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="r1">The r1.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawCorners(Color c1, Rectangle r1, int offset)
        {
            DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height, offset);
        }
        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawCorners(Color c1, int x, int y, int width, int height, int offset)
        {
            DrawCorners(c1, x + offset, y + offset, width - (offset * 2), height - (offset * 2));
        }

        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        protected void DrawCorners(Color c1)
        {
            DrawCorners(c1, 0, 0, Width, Height);
        }
        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="r1">The r1.</param>
        protected void DrawCorners(Color c1, Rectangle r1)
        {
            DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height);
        }
        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawCorners(Color c1, int x, int y, int width, int height)
        {
            if (_NoRounding)
                return;

            if (_Transparent)
            {
                B.SetPixel(x, y, c1);
                B.SetPixel(x + (width - 1), y, c1);
                B.SetPixel(x, y + (height - 1), c1);
                B.SetPixel(x + (width - 1), y + (height - 1), c1);
            }
            else
            {
                DrawCornersBrush = new SolidBrush(c1);
                G.FillRectangle(DrawCornersBrush, x, y, 1, 1);
                G.FillRectangle(DrawCornersBrush, x + (width - 1), y, 1, 1);
                G.FillRectangle(DrawCornersBrush, x, y + (height - 1), 1, 1);
                G.FillRectangle(DrawCornersBrush, x + (width - 1), y + (height - 1), 1, 1);
            }
        }

        #endregion

        #region " DrawBorders "

        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawBorders(Pen p1, int offset)
        {
            DrawBorders(p1, 0, 0, Width, Height, offset);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="r">The r.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawBorders(Pen p1, Rectangle r, int offset)
        {
            DrawBorders(p1, r.X, r.Y, r.Width, r.Height, offset);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawBorders(Pen p1, int x, int y, int width, int height, int offset)
        {
            DrawBorders(p1, x + offset, y + offset, width - (offset * 2), height - (offset * 2));
        }

        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        protected void DrawBorders(Pen p1)
        {
            DrawBorders(p1, 0, 0, Width, Height);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="r">The r.</param>
        protected void DrawBorders(Pen p1, Rectangle r)
        {
            DrawBorders(p1, r.X, r.Y, r.Width, r.Height);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawBorders(Pen p1, int x, int y, int width, int height)
        {
            G.DrawRectangle(p1, x, y, width - 1, height - 1);
        }

        #endregion

        #region " DrawText "

        /// <summary>
        /// The draw text point
        /// </summary>
        private Point DrawTextPoint;

        /// <summary>
        /// The draw text size
        /// </summary>
        private Size DrawTextSize;
        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="b1">The b1.</param>
        /// <param name="a">a.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawText(Brush b1, HorizontalAlignment a, int x, int y)
        {
            DrawText(b1, Text, a, x, y);
        }
        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="b1">The b1.</param>
        /// <param name="text">The text.</param>
        /// <param name="a">a.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawText(Brush b1, string text, HorizontalAlignment a, int x, int y)
        {
            if (text.Length == 0)
                return;

            DrawTextSize = Measure(text);
            DrawTextPoint = new Point(Width / 2 - DrawTextSize.Width / 2, Header / 2 - DrawTextSize.Height / 2);

            switch (a)
            {
                case HorizontalAlignment.Left:
                    G.DrawString(text, Font, b1, x, DrawTextPoint.Y + y);
                    break;
                case HorizontalAlignment.Center:
                    G.DrawString(text, Font, b1, DrawTextPoint.X + x, DrawTextPoint.Y + y);
                    break;
                case HorizontalAlignment.Right:
                    G.DrawString(text, Font, b1, Width - DrawTextSize.Width - x, DrawTextPoint.Y + y);
                    break;
            }
        }

        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="b1">The b1.</param>
        /// <param name="p1">The p1.</param>
        protected void DrawText(Brush b1, Point p1)
        {
            if (Text.Length == 0)
                return;
            G.DrawString(Text, Font, b1, p1);
        }
        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="b1">The b1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawText(Brush b1, int x, int y)
        {
            if (Text.Length == 0)
                return;
            G.DrawString(Text, Font, b1, x, y);
        }

        #endregion

        #region " DrawImage "


        /// <summary>
        /// The draw image point
        /// </summary>
        private Point DrawImagePoint;
        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawImage(HorizontalAlignment a, int x, int y)
        {
            DrawImage(_Image, a, x, y);
        }
        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="a">a.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawImage(Image image, HorizontalAlignment a, int x, int y)
        {
            if (image == null)
                return;
            DrawImagePoint = new Point(Width / 2 - image.Width / 2, Header / 2 - image.Height / 2);

            switch (a)
            {
                case HorizontalAlignment.Left:
                    G.DrawImage(image, x, DrawImagePoint.Y + y, image.Width, image.Height);
                    break;
                case HorizontalAlignment.Center:
                    G.DrawImage(image, DrawImagePoint.X + x, DrawImagePoint.Y + y, image.Width, image.Height);
                    break;
                case HorizontalAlignment.Right:
                    G.DrawImage(image, Width - image.Width - x, DrawImagePoint.Y + y, image.Width, image.Height);
                    break;
            }
        }

        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="p1">The p1.</param>
        protected void DrawImage(Point p1)
        {
            DrawImage(_Image, p1.X, p1.Y);
        }
        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawImage(int x, int y)
        {
            DrawImage(_Image, x, y);
        }

        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="p1">The p1.</param>
        protected void DrawImage(Image image, Point p1)
        {
            DrawImage(image, p1.X, p1.Y);
        }
        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawImage(Image image, int x, int y)
        {
            if (image == null)
                return;
            G.DrawImage(image, x, y, image.Width, image.Height);
        }

        #endregion

        #region " DrawGradient "

        /// <summary>
        /// The draw gradient brush
        /// </summary>
        private LinearGradientBrush DrawGradientBrush;

        /// <summary>
        /// The draw gradient rectangle
        /// </summary>
        private Rectangle DrawGradientRectangle;
        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawGradient(ColorBlend blend, int x, int y, int width, int height)
        {
            DrawGradientRectangle = new Rectangle(x, y, width, height);
            DrawGradient(blend, DrawGradientRectangle);
        }
        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawGradient(ColorBlend blend, int x, int y, int width, int height, float angle)
        {
            DrawGradientRectangle = new Rectangle(x, y, width, height);
            DrawGradient(blend, DrawGradientRectangle, angle);
        }

        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="r">The r.</param>
        protected void DrawGradient(ColorBlend blend, Rectangle r)
        {
            DrawGradientBrush = new LinearGradientBrush(r, Color.Empty, Color.Empty, 90f);
            DrawGradientBrush.InterpolationColors = blend;
            G.FillRectangle(DrawGradientBrush, r);
        }
        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="r">The r.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawGradient(ColorBlend blend, Rectangle r, float angle)
        {
            DrawGradientBrush = new LinearGradientBrush(r, Color.Empty, Color.Empty, angle);
            DrawGradientBrush.InterpolationColors = blend;
            G.FillRectangle(DrawGradientBrush, r);
        }


        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawGradient(Color c1, Color c2, int x, int y, int width, int height)
        {
            DrawGradientRectangle = new Rectangle(x, y, width, height);
            DrawGradient(c1, c2, DrawGradientRectangle);
        }
        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawGradient(Color c1, Color c2, int x, int y, int width, int height, float angle)
        {
            DrawGradientRectangle = new Rectangle(x, y, width, height);
            DrawGradient(c1, c2, DrawGradientRectangle, angle);
        }

        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="r">The r.</param>
        protected void DrawGradient(Color c1, Color c2, Rectangle r)
        {
            DrawGradientBrush = new LinearGradientBrush(r, c1, c2, 90f);
            G.FillRectangle(DrawGradientBrush, r);
        }
        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="r">The r.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawGradient(Color c1, Color c2, Rectangle r, float angle)
        {
            DrawGradientBrush = new LinearGradientBrush(r, c1, c2, angle);
            G.FillRectangle(DrawGradientBrush, r);
        }

        #endregion

        #region " DrawRadial "

        /// <summary>
        /// The draw radial path
        /// </summary>
        private GraphicsPath DrawRadialPath;
        /// <summary>
        /// The draw radial brush1
        /// </summary>
        private PathGradientBrush DrawRadialBrush1;
        /// <summary>
        /// The draw radial brush2
        /// </summary>
        private LinearGradientBrush DrawRadialBrush2;

        /// <summary>
        /// The draw radial rectangle
        /// </summary>
        private Rectangle DrawRadialRectangle;
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public void DrawRadial(ColorBlend blend, int x, int y, int width, int height)
        {
            DrawRadialRectangle = new Rectangle(x, y, width, height);
            DrawRadial(blend, DrawRadialRectangle, width / 2, height / 2);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="center">The center.</param>
        public void DrawRadial(ColorBlend blend, int x, int y, int width, int height, Point center)
        {
            DrawRadialRectangle = new Rectangle(x, y, width, height);
            DrawRadial(blend, DrawRadialRectangle, center.X, center.Y);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="cx">The cx.</param>
        /// <param name="cy">The cy.</param>
        public void DrawRadial(ColorBlend blend, int x, int y, int width, int height, int cx, int cy)
        {
            DrawRadialRectangle = new Rectangle(x, y, width, height);
            DrawRadial(blend, DrawRadialRectangle, cx, cy);
        }

        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="r">The r.</param>
        public void DrawRadial(ColorBlend blend, Rectangle r)
        {
            DrawRadial(blend, r, r.Width / 2, r.Height / 2);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="r">The r.</param>
        /// <param name="center">The center.</param>
        public void DrawRadial(ColorBlend blend, Rectangle r, Point center)
        {
            DrawRadial(blend, r, center.X, center.Y);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="r">The r.</param>
        /// <param name="cx">The cx.</param>
        /// <param name="cy">The cy.</param>
        public void DrawRadial(ColorBlend blend, Rectangle r, int cx, int cy)
        {
            DrawRadialPath.Reset();
            DrawRadialPath.AddEllipse(r.X, r.Y, r.Width - 1, r.Height - 1);

            DrawRadialBrush1 = new PathGradientBrush(DrawRadialPath);
            DrawRadialBrush1.CenterPoint = new Point(r.X + cx, r.Y + cy);
            DrawRadialBrush1.InterpolationColors = blend;

            if (G.SmoothingMode == SmoothingMode.AntiAlias)
            {
                G.FillEllipse(DrawRadialBrush1, r.X + 1, r.Y + 1, r.Width - 3, r.Height - 3);
            }
            else
            {
                G.FillEllipse(DrawRadialBrush1, r);
            }
        }


        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawRadial(Color c1, Color c2, int x, int y, int width, int height)
        {
            DrawRadialRectangle = new Rectangle(x, y, width, height);
            DrawRadial(c1, c2, DrawGradientRectangle);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawRadial(Color c1, Color c2, int x, int y, int width, int height, float angle)
        {
            DrawRadialRectangle = new Rectangle(x, y, width, height);
            DrawRadial(c1, c2, DrawGradientRectangle, angle);
        }

        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="r">The r.</param>
        protected void DrawRadial(Color c1, Color c2, Rectangle r)
        {
            DrawRadialBrush2 = new LinearGradientBrush(r, c1, c2, 90f);
            G.FillRectangle(DrawGradientBrush, r);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="r">The r.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawRadial(Color c1, Color c2, Rectangle r, float angle)
        {
            DrawRadialBrush2 = new LinearGradientBrush(r, c1, c2, angle);
            G.FillEllipse(DrawGradientBrush, r);
        }

        #endregion

        #region " CreateRound "

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

        #endregion

    }

    /// <summary>
    /// Class ThemeControl154.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public abstract class ThemeControl154 : Control
    {


        #region " Initialization "

        /// <summary>
        /// The g
        /// </summary>
        protected Graphics G;

        /// <summary>
        /// The b
        /// </summary>
        protected Bitmap B;
        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeControl154"/> class.
        /// </summary>
        public ThemeControl154()
        {
            SetStyle((ControlStyles)139270, true);

            _ImageSize = Size.Empty;
            Font = new Font("Verdana", 8);

            MeasureBitmap = new Bitmap(1, 1);
            MeasureGraphics = Graphics.FromImage(MeasureBitmap);

            DrawRadialPath = new GraphicsPath();

            InvalidateCustimization();
            //Remove?
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.HandleCreated" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override sealed void OnHandleCreated(EventArgs e)
        {
            InvalidateCustimization();
            ColorHook();

            if (!(_LockWidth == 0))
                Width = _LockWidth;
            if (!(_LockHeight == 0))
                Height = _LockHeight;

            Transparent = _Transparent;
            if (_Transparent && _BackColor)
                BackColor = Color.Transparent;

            base.OnHandleCreated(e);
        }

        /// <summary>
        /// The done creation
        /// </summary>
        private bool DoneCreation;
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.ParentChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override sealed void OnParentChanged(EventArgs e)
        {
            if (Parent != null)
            {
                OnCreation();
                DoneCreation = true;
                InvalidateTimer();
            }

            base.OnParentChanged(e);
        }

        #endregion

        /// <summary>
        /// Does the animation.
        /// </summary>
        /// <param name="i">if set to <c>true</c> [i].</param>
        private void DoAnimation(bool i)
        {
            OnAnimation();
            if (i)
                Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        protected override sealed void OnPaint(PaintEventArgs e)
        {
            if (Width == 0 || Height == 0)
                return;

            if (_Transparent)
            {
                PaintHook();
                e.Graphics.DrawImage(B, 0, 0);
            }
            else
            {
                G = e.Graphics;
                PaintHook();
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.HandleDestroyed" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnHandleDestroyed(EventArgs e)
        {
            ThemeShare.RemoveAnimationCallback(DoAnimation);
            base.OnHandleDestroyed(e);
        }

        #region " Size Handling "

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.SizeChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override sealed void OnSizeChanged(EventArgs e)
        {
            if (_Transparent)
            {
                InvalidateBitmap();
            }

            Invalidate();
            base.OnSizeChanged(e);
        }

        /// <summary>
        /// Performs the work of setting the specified bounds of this control.
        /// </summary>
        /// <param name="x">The new <see cref="P:System.Windows.Forms.Control.Left" /> property value of the control.</param>
        /// <param name="y">The new <see cref="P:System.Windows.Forms.Control.Top" /> property value of the control.</param>
        /// <param name="width">The new <see cref="P:System.Windows.Forms.Control.Width" /> property value of the control.</param>
        /// <param name="height">The new <see cref="P:System.Windows.Forms.Control.Height" /> property value of the control.</param>
        /// <param name="specified">A bitwise combination of the <see cref="T:System.Windows.Forms.BoundsSpecified" /> values.</param>
        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            if (!(_LockWidth == 0))
                width = _LockWidth;
            if (!(_LockHeight == 0))
                height = _LockHeight;
            base.SetBoundsCore(x, y, width, height, specified);
        }

        #endregion

        #region " State Handling "

        /// <summary>
        /// The in position
        /// </summary>
        private bool InPosition;
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseEnter" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnMouseEnter(EventArgs e)
        {
            InPosition = true;
            SetState(MouseState.Over);
            base.OnMouseEnter(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseUp" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (InPosition)
                SetState(MouseState.Over);
            base.OnMouseUp(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseDown" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                SetState(MouseState.Down);
            base.OnMouseDown(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseLeave" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnMouseLeave(EventArgs e)
        {
            InPosition = false;
            SetState(MouseState.None);
            base.OnMouseLeave(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.EnabledChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnEnabledChanged(EventArgs e)
        {
            if (Enabled)
                SetState(MouseState.None);
            else
                SetState(MouseState.Block);
            base.OnEnabledChanged(e);
        }

        /// <summary>
        /// The state
        /// </summary>
        protected MouseState State;
        /// <summary>
        /// Sets the state.
        /// </summary>
        /// <param name="current">The current.</param>
        private void SetState(MouseState current)
        {
            State = current;
            Invalidate();
        }

        #endregion


        #region " Base Properties "

        /// <summary>
        /// Gets or sets the foreground color of the control.
        /// </summary>
        /// <value>The color of the fore.</value>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color ForeColor
        {
            get { return Color.Empty; }
            set { }
        }
        /// <summary>
        /// Gets or sets the background image displayed in the control.
        /// </summary>
        /// <value>The background image.</value>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Image BackgroundImage
        {
            get { return null; }
            set { }
        }
        /// <summary>
        /// Gets or sets the background image layout as defined in the <see cref="T:System.Windows.Forms.ImageLayout" /> enumeration.
        /// </summary>
        /// <value>The background image layout.</value>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override ImageLayout BackgroundImageLayout
        {
            get { return ImageLayout.None; }
            set { }
        }

        /// <summary>
        /// Gets or sets the text associated with this control.
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
        /// Gets or sets the font of the text displayed by the control.
        /// </summary>
        /// <value>The font.</value>
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The back color
        /// </summary>
        private bool _BackColor;
        /// <summary>
        /// Gets or sets the background color for the control.
        /// </summary>
        /// <value>The color of the back.</value>
        [Category("Misc")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                if (!IsHandleCreated && value == Color.Transparent)
                {
                    _BackColor = true;
                    return;
                }

                base.BackColor = value;
                if (Parent != null)
                    ColorHook();
            }
        }

        #endregion

        #region " Public Properties "

        /// <summary>
        /// The no rounding
        /// </summary>
        private bool _NoRounding;
        /// <summary>
        /// Gets or sets a value indicating whether [no rounding].
        /// </summary>
        /// <value><c>true</c> if [no rounding]; otherwise, <c>false</c>.</value>
        public bool NoRounding
        {
            get { return _NoRounding; }
            set
            {
                _NoRounding = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The image
        /// </summary>
        private Image _Image;
        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>The image.</value>
        public Image Image
        {
            get { return _Image; }
            set
            {
                if (value == null)
                {
                    _ImageSize = Size.Empty;
                }
                else
                {
                    _ImageSize = value.Size;
                }

                _Image = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The transparent
        /// </summary>
        private bool _Transparent;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ThemeControl154"/> is transparent.
        /// </summary>
        /// <value><c>true</c> if transparent; otherwise, <c>false</c>.</value>
        /// <exception cref="System.Exception">Unable to change value to false while a transparent BackColor is in use.</exception>
        public bool Transparent
        {
            get { return _Transparent; }
            set
            {
                _Transparent = value;
                if (!IsHandleCreated)
                    return;

                if (!value && !(BackColor.A == 255))
                {
                    throw new Exception("Unable to change value to false while a transparent BackColor is in use.");
                }

                SetStyle(ControlStyles.Opaque, !value);
                SetStyle(ControlStyles.SupportsTransparentBackColor, value);

                if (value)
                    InvalidateBitmap();
                else
                    B = null;
                Invalidate();
            }
        }

        /// <summary>
        /// The items
        /// </summary>
        private Dictionary<string, Color> Items = new Dictionary<string, Color>();
        /// <summary>
        /// Gets or sets the colors.
        /// </summary>
        /// <value>The colors.</value>
        public Bloom[] Colors
        {
            get
            {
                List<Bloom> T = new List<Bloom>();
                Dictionary<string, Color>.Enumerator E = Items.GetEnumerator();

                while (E.MoveNext())
                {
                    T.Add(new Bloom(E.Current.Key, E.Current.Value));
                }

                return T.ToArray();
            }
            set
            {
                foreach (Bloom B in value)
                {
                    if (Items.ContainsKey(B.Name))
                        Items[B.Name] = B.Value;
                }

                InvalidateCustimization();
                ColorHook();
                Invalidate();
            }
        }

        /// <summary>
        /// The customization
        /// </summary>
        private string _Customization;
        /// <summary>
        /// Gets or sets the customization.
        /// </summary>
        /// <value>The customization.</value>
        public string Customization
        {
            get { return _Customization; }
            set
            {
                if (value == _Customization)
                    return;

                byte[] Data = null;
                Bloom[] Items = Colors;

                try
                {
                    Data = Convert.FromBase64String(value);
                    for (int I = 0; I <= Items.Length - 1; I++)
                    {
                        Items[I].Value = Color.FromArgb(BitConverter.ToInt32(Data, I * 4));
                    }
                }
                catch
                {
                    return;
                }

                _Customization = value;

                Colors = Items;
                ColorHook();
                Invalidate();
            }
        }

        #endregion

        #region " Private Properties "

        /// <summary>
        /// The image size
        /// </summary>
        private Size _ImageSize;
        /// <summary>
        /// Gets the size of the image.
        /// </summary>
        /// <value>The size of the image.</value>
        protected Size ImageSize
        {
            get { return _ImageSize; }
        }

        /// <summary>
        /// The lock width
        /// </summary>
        private int _LockWidth;
        /// <summary>
        /// Gets or sets the width of the lock.
        /// </summary>
        /// <value>The width of the lock.</value>
        protected int LockWidth
        {
            get { return _LockWidth; }
            set
            {
                _LockWidth = value;
                if (!(LockWidth == 0) && IsHandleCreated)
                    Width = LockWidth;
            }
        }

        /// <summary>
        /// The lock height
        /// </summary>
        private int _LockHeight;
        /// <summary>
        /// Gets or sets the height of the lock.
        /// </summary>
        /// <value>The height of the lock.</value>
        protected int LockHeight
        {
            get { return _LockHeight; }
            set
            {
                _LockHeight = value;
                if (!(LockHeight == 0) && IsHandleCreated)
                    Height = LockHeight;
            }
        }

        /// <summary>
        /// The is animated
        /// </summary>
        private bool _IsAnimated;
        /// <summary>
        /// Gets or sets a value indicating whether this instance is animated.
        /// </summary>
        /// <value><c>true</c> if this instance is animated; otherwise, <c>false</c>.</value>
        protected bool IsAnimated
        {
            get { return _IsAnimated; }
            set
            {
                _IsAnimated = value;
                InvalidateTimer();
            }
        }

        #endregion


        #region " Property Helpers "

        /// <summary>
        /// Gets the pen.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Pen.</returns>
        protected Pen GetPen(string name)
        {
            return new Pen(Items[name]);
        }
        /// <summary>
        /// Gets the pen.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="width">The width.</param>
        /// <returns>Pen.</returns>
        protected Pen GetPen(string name, float width)
        {
            return new Pen(Items[name], width);
        }

        /// <summary>
        /// Gets the brush.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>SolidBrush.</returns>
        protected SolidBrush GetBrush(string name)
        {
            return new SolidBrush(Items[name]);
        }

        /// <summary>
        /// Gets the color.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Color.</returns>
        protected Color GetColor(string name)
        {
            return Items[name];
        }

        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        protected void SetColor(string name, Color value)
        {
            if (Items.ContainsKey(name))
                Items[name] = value;
            else
                Items.Add(name, value);
        }
        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="r">The r.</param>
        /// <param name="g">The g.</param>
        /// <param name="b">The b.</param>
        protected void SetColor(string name, byte r, byte g, byte b)
        {
            SetColor(name, Color.FromArgb(r, g, b));
        }
        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="a">a.</param>
        /// <param name="r">The r.</param>
        /// <param name="g">The g.</param>
        /// <param name="b">The b.</param>
        protected void SetColor(string name, byte a, byte r, byte g, byte b)
        {
            SetColor(name, Color.FromArgb(a, r, g, b));
        }
        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="a">a.</param>
        /// <param name="value">The value.</param>
        protected void SetColor(string name, byte a, Color value)
        {
            SetColor(name, Color.FromArgb(a, value));
        }

        /// <summary>
        /// Invalidates the bitmap.
        /// </summary>
        private void InvalidateBitmap()
        {
            if (Width == 0 || Height == 0)
                return;
            B = new Bitmap(Width, Height, PixelFormat.Format32bppPArgb);
            G = Graphics.FromImage(B);
        }

        /// <summary>
        /// Invalidates the custimization.
        /// </summary>
        private void InvalidateCustimization()
        {
            MemoryStream M = new MemoryStream(Items.Count * 4);

            foreach (Bloom B in Colors)
            {
                M.Write(BitConverter.GetBytes(B.Value.ToArgb()), 0, 4);
            }

            M.Close();
            _Customization = Convert.ToBase64String(M.ToArray());
        }

        /// <summary>
        /// Invalidates the timer.
        /// </summary>
        private void InvalidateTimer()
        {
            if (DesignMode || !DoneCreation)
                return;

            if (_IsAnimated)
            {
                ThemeShare.AddAnimationCallback(DoAnimation);
            }
            else
            {
                ThemeShare.RemoveAnimationCallback(DoAnimation);
            }
        }
        #endregion


        #region " User Hooks "

        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected abstract void ColorHook();
        /// <summary>
        /// Paints the hook.
        /// </summary>
        protected abstract void PaintHook();

        /// <summary>
        /// Called when [creation].
        /// </summary>
        protected virtual void OnCreation()
        {
        }

        /// <summary>
        /// Called when [animation].
        /// </summary>
        protected virtual void OnAnimation()
        {
        }

        #endregion


        #region " Offset "

        /// <summary>
        /// The offset return rectangle
        /// </summary>
        private Rectangle OffsetReturnRectangle;
        /// <summary>
        /// Offsets the specified r.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="amount">The amount.</param>
        /// <returns>Rectangle.</returns>
        protected Rectangle Offset(Rectangle r, int amount)
        {
            OffsetReturnRectangle = new Rectangle(r.X + amount, r.Y + amount, r.Width - (amount * 2), r.Height - (amount * 2));
            return OffsetReturnRectangle;
        }

        /// <summary>
        /// The offset return size
        /// </summary>
        private Size OffsetReturnSize;
        /// <summary>
        /// Offsets the specified s.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="amount">The amount.</param>
        /// <returns>Size.</returns>
        protected Size Offset(Size s, int amount)
        {
            OffsetReturnSize = new Size(s.Width + amount, s.Height + amount);
            return OffsetReturnSize;
        }

        /// <summary>
        /// The offset return point
        /// </summary>
        private Point OffsetReturnPoint;
        /// <summary>
        /// Offsets the specified p.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="amount">The amount.</param>
        /// <returns>Point.</returns>
        protected Point Offset(Point p, int amount)
        {
            OffsetReturnPoint = new Point(p.X + amount, p.Y + amount);
            return OffsetReturnPoint;
        }

        #endregion

        #region " Center "


        /// <summary>
        /// The center return
        /// </summary>
        private Point CenterReturn;
        /// <summary>
        /// Centers the specified p.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="c">The c.</param>
        /// <returns>Point.</returns>
        protected Point Center(Rectangle p, Rectangle c)
        {
            CenterReturn = new Point((p.Width / 2 - c.Width / 2) + p.X + c.X, (p.Height / 2 - c.Height / 2) + p.Y + c.Y);
            return CenterReturn;
        }
        /// <summary>
        /// Centers the specified p.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="c">The c.</param>
        /// <returns>Point.</returns>
        protected Point Center(Rectangle p, Size c)
        {
            CenterReturn = new Point((p.Width / 2 - c.Width / 2) + p.X, (p.Height / 2 - c.Height / 2) + p.Y);
            return CenterReturn;
        }

        /// <summary>
        /// Centers the specified child.
        /// </summary>
        /// <param name="child">The child.</param>
        /// <returns>Point.</returns>
        protected Point Center(Rectangle child)
        {
            return Center(Width, Height, child.Width, child.Height);
        }
        /// <summary>
        /// Centers the specified child.
        /// </summary>
        /// <param name="child">The child.</param>
        /// <returns>Point.</returns>
        protected Point Center(Size child)
        {
            return Center(Width, Height, child.Width, child.Height);
        }
        /// <summary>
        /// Centers the specified child width.
        /// </summary>
        /// <param name="childWidth">Width of the child.</param>
        /// <param name="childHeight">Height of the child.</param>
        /// <returns>Point.</returns>
        protected Point Center(int childWidth, int childHeight)
        {
            return Center(Width, Height, childWidth, childHeight);
        }

        /// <summary>
        /// Centers the specified p.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="c">The c.</param>
        /// <returns>Point.</returns>
        protected Point Center(Size p, Size c)
        {
            return Center(p.Width, p.Height, c.Width, c.Height);
        }

        /// <summary>
        /// Centers the specified p width.
        /// </summary>
        /// <param name="pWidth">Width of the p.</param>
        /// <param name="pHeight">Height of the p.</param>
        /// <param name="cWidth">Width of the c.</param>
        /// <param name="cHeight">Height of the c.</param>
        /// <returns>Point.</returns>
        protected Point Center(int pWidth, int pHeight, int cWidth, int cHeight)
        {
            CenterReturn = new Point(pWidth / 2 - cWidth / 2, pHeight / 2 - cHeight / 2);
            return CenterReturn;
        }

        #endregion

        #region " Measure "

        /// <summary>
        /// The measure bitmap
        /// </summary>
        private Bitmap MeasureBitmap;
        //TODO: Potential issues during multi-threading.
        /// <summary>
        /// The measure graphics
        /// </summary>
        private Graphics MeasureGraphics;

        /// <summary>
        /// Measures this instance.
        /// </summary>
        /// <returns>Size.</returns>
        protected Size Measure()
        {
            return MeasureGraphics.MeasureString(Text, Font, Width).ToSize();
        }
        /// <summary>
        /// Measures the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>Size.</returns>
        protected Size Measure(string text)
        {
            return MeasureGraphics.MeasureString(text, Font, Width).ToSize();
        }

        #endregion


        #region " DrawPixel "


        /// <summary>
        /// The draw pixel brush
        /// </summary>
        private SolidBrush DrawPixelBrush;
        /// <summary>
        /// Draws the pixel.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawPixel(Color c1, int x, int y)
        {
            if (_Transparent)
            {
                B.SetPixel(x, y, c1);
            }
            else
            {
                DrawPixelBrush = new SolidBrush(c1);
                G.FillRectangle(DrawPixelBrush, x, y, 1, 1);
            }
        }

        #endregion

        #region " DrawCorners "


        /// <summary>
        /// The draw corners brush
        /// </summary>
        private SolidBrush DrawCornersBrush;
        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawCorners(Color c1, int offset)
        {
            DrawCorners(c1, 0, 0, Width, Height, offset);
        }
        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="r1">The r1.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawCorners(Color c1, Rectangle r1, int offset)
        {
            DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height, offset);
        }
        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawCorners(Color c1, int x, int y, int width, int height, int offset)
        {
            DrawCorners(c1, x + offset, y + offset, width - (offset * 2), height - (offset * 2));
        }

        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        protected void DrawCorners(Color c1)
        {
            DrawCorners(c1, 0, 0, Width, Height);
        }
        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="r1">The r1.</param>
        protected void DrawCorners(Color c1, Rectangle r1)
        {
            DrawCorners(c1, r1.X, r1.Y, r1.Width, r1.Height);
        }
        /// <summary>
        /// Draws the corners.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawCorners(Color c1, int x, int y, int width, int height)
        {
            if (_NoRounding)
                return;

            if (_Transparent)
            {
                B.SetPixel(x, y, c1);
                B.SetPixel(x + (width - 1), y, c1);
                B.SetPixel(x, y + (height - 1), c1);
                B.SetPixel(x + (width - 1), y + (height - 1), c1);
            }
            else
            {
                DrawCornersBrush = new SolidBrush(c1);
                G.FillRectangle(DrawCornersBrush, x, y, 1, 1);
                G.FillRectangle(DrawCornersBrush, x + (width - 1), y, 1, 1);
                G.FillRectangle(DrawCornersBrush, x, y + (height - 1), 1, 1);
                G.FillRectangle(DrawCornersBrush, x + (width - 1), y + (height - 1), 1, 1);
            }
        }

        #endregion

        #region " DrawBorders "

        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawBorders(Pen p1, int offset)
        {
            DrawBorders(p1, 0, 0, Width, Height, offset);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="r">The r.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawBorders(Pen p1, Rectangle r, int offset)
        {
            DrawBorders(p1, r.X, r.Y, r.Width, r.Height, offset);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="offset">The offset.</param>
        protected void DrawBorders(Pen p1, int x, int y, int width, int height, int offset)
        {
            DrawBorders(p1, x + offset, y + offset, width - (offset * 2), height - (offset * 2));
        }

        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        protected void DrawBorders(Pen p1)
        {
            DrawBorders(p1, 0, 0, Width, Height);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="r">The r.</param>
        protected void DrawBorders(Pen p1, Rectangle r)
        {
            DrawBorders(p1, r.X, r.Y, r.Width, r.Height);
        }
        /// <summary>
        /// Draws the borders.
        /// </summary>
        /// <param name="p1">The p1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawBorders(Pen p1, int x, int y, int width, int height)
        {
            G.DrawRectangle(p1, x, y, width - 1, height - 1);
        }

        #endregion

        #region " DrawText "

        /// <summary>
        /// The draw text point
        /// </summary>
        private Point DrawTextPoint;

        /// <summary>
        /// The draw text size
        /// </summary>
        private Size DrawTextSize;
        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="b1">The b1.</param>
        /// <param name="a">a.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawText(Brush b1, HorizontalAlignment a, int x, int y)
        {
            DrawText(b1, Text, a, x, y);
        }
        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="b1">The b1.</param>
        /// <param name="text">The text.</param>
        /// <param name="a">a.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawText(Brush b1, string text, HorizontalAlignment a, int x, int y)
        {
            if (text.Length == 0)
                return;

            DrawTextSize = Measure(text);
            DrawTextPoint = Center(DrawTextSize);

            switch (a)
            {
                case HorizontalAlignment.Left:
                    G.DrawString(text, Font, b1, x, DrawTextPoint.Y + y);
                    break;
                case HorizontalAlignment.Center:
                    G.DrawString(text, Font, b1, DrawTextPoint.X + x, DrawTextPoint.Y + y);
                    break;
                case HorizontalAlignment.Right:
                    G.DrawString(text, Font, b1, Width - DrawTextSize.Width - x, DrawTextPoint.Y + y);
                    break;
            }
        }

        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="b1">The b1.</param>
        /// <param name="p1">The p1.</param>
        protected void DrawText(Brush b1, Point p1)
        {
            if (Text.Length == 0)
                return;
            G.DrawString(Text, Font, b1, p1);
        }
        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="b1">The b1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawText(Brush b1, int x, int y)
        {
            if (Text.Length == 0)
                return;
            G.DrawString(Text, Font, b1, x, y);
        }

        #endregion

        #region " DrawImage "


        /// <summary>
        /// The draw image point
        /// </summary>
        private Point DrawImagePoint;
        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawImage(HorizontalAlignment a, int x, int y)
        {
            DrawImage(_Image, a, x, y);
        }
        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="a">a.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawImage(Image image, HorizontalAlignment a, int x, int y)
        {
            if (image == null)
                return;
            DrawImagePoint = Center(image.Size);

            switch (a)
            {
                case HorizontalAlignment.Left:
                    G.DrawImage(image, x, DrawImagePoint.Y + y, image.Width, image.Height);
                    break;
                case HorizontalAlignment.Center:
                    G.DrawImage(image, DrawImagePoint.X + x, DrawImagePoint.Y + y, image.Width, image.Height);
                    break;
                case HorizontalAlignment.Right:
                    G.DrawImage(image, Width - image.Width - x, DrawImagePoint.Y + y, image.Width, image.Height);
                    break;
            }
        }

        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="p1">The p1.</param>
        protected void DrawImage(Point p1)
        {
            DrawImage(_Image, p1.X, p1.Y);
        }
        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawImage(int x, int y)
        {
            DrawImage(_Image, x, y);
        }

        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="p1">The p1.</param>
        protected void DrawImage(Image image, Point p1)
        {
            DrawImage(image, p1.X, p1.Y);
        }
        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        protected void DrawImage(Image image, int x, int y)
        {
            if (image == null)
                return;
            G.DrawImage(image, x, y, image.Width, image.Height);
        }

        #endregion

        #region " DrawGradient "

        /// <summary>
        /// The draw gradient brush
        /// </summary>
        private LinearGradientBrush DrawGradientBrush;

        /// <summary>
        /// The draw gradient rectangle
        /// </summary>
        private Rectangle DrawGradientRectangle;
        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawGradient(ColorBlend blend, int x, int y, int width, int height)
        {
            DrawGradientRectangle = new Rectangle(x, y, width, height);
            DrawGradient(blend, DrawGradientRectangle);
        }
        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawGradient(ColorBlend blend, int x, int y, int width, int height, float angle)
        {
            DrawGradientRectangle = new Rectangle(x, y, width, height);
            DrawGradient(blend, DrawGradientRectangle, angle);
        }

        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="r">The r.</param>
        protected void DrawGradient(ColorBlend blend, Rectangle r)
        {
            DrawGradientBrush = new LinearGradientBrush(r, Color.Empty, Color.Empty, 90f);
            DrawGradientBrush.InterpolationColors = blend;
            G.FillRectangle(DrawGradientBrush, r);
        }
        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="r">The r.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawGradient(ColorBlend blend, Rectangle r, float angle)
        {
            DrawGradientBrush = new LinearGradientBrush(r, Color.Empty, Color.Empty, angle);
            DrawGradientBrush.InterpolationColors = blend;
            G.FillRectangle(DrawGradientBrush, r);
        }


        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawGradient(Color c1, Color c2, int x, int y, int width, int height)
        {
            DrawGradientRectangle = new Rectangle(x, y, width, height);
            DrawGradient(c1, c2, DrawGradientRectangle);
        }
        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawGradient(Color c1, Color c2, int x, int y, int width, int height, float angle)
        {
            DrawGradientRectangle = new Rectangle(x, y, width, height);
            DrawGradient(c1, c2, DrawGradientRectangle, angle);
        }

        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="r">The r.</param>
        protected void DrawGradient(Color c1, Color c2, Rectangle r)
        {
            DrawGradientBrush = new LinearGradientBrush(r, c1, c2, 90f);
            G.FillRectangle(DrawGradientBrush, r);
        }
        /// <summary>
        /// Draws the gradient.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="r">The r.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawGradient(Color c1, Color c2, Rectangle r, float angle)
        {
            DrawGradientBrush = new LinearGradientBrush(r, c1, c2, angle);
            G.FillRectangle(DrawGradientBrush, r);
        }

        #endregion

        #region " DrawRadial "

        /// <summary>
        /// The draw radial path
        /// </summary>
        private GraphicsPath DrawRadialPath;
        /// <summary>
        /// The draw radial brush1
        /// </summary>
        private PathGradientBrush DrawRadialBrush1;
        /// <summary>
        /// The draw radial brush2
        /// </summary>
        private LinearGradientBrush DrawRadialBrush2;

        /// <summary>
        /// The draw radial rectangle
        /// </summary>
        private Rectangle DrawRadialRectangle;
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public void DrawRadial(ColorBlend blend, int x, int y, int width, int height)
        {
            DrawRadialRectangle = new Rectangle(x, y, width, height);
            DrawRadial(blend, DrawRadialRectangle, width / 2, height / 2);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="center">The center.</param>
        public void DrawRadial(ColorBlend blend, int x, int y, int width, int height, Point center)
        {
            DrawRadialRectangle = new Rectangle(x, y, width, height);
            DrawRadial(blend, DrawRadialRectangle, center.X, center.Y);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="cx">The cx.</param>
        /// <param name="cy">The cy.</param>
        public void DrawRadial(ColorBlend blend, int x, int y, int width, int height, int cx, int cy)
        {
            DrawRadialRectangle = new Rectangle(x, y, width, height);
            DrawRadial(blend, DrawRadialRectangle, cx, cy);
        }

        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="r">The r.</param>
        public void DrawRadial(ColorBlend blend, Rectangle r)
        {
            DrawRadial(blend, r, r.Width / 2, r.Height / 2);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="r">The r.</param>
        /// <param name="center">The center.</param>
        public void DrawRadial(ColorBlend blend, Rectangle r, Point center)
        {
            DrawRadial(blend, r, center.X, center.Y);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="blend">The blend.</param>
        /// <param name="r">The r.</param>
        /// <param name="cx">The cx.</param>
        /// <param name="cy">The cy.</param>
        public void DrawRadial(ColorBlend blend, Rectangle r, int cx, int cy)
        {
            DrawRadialPath.Reset();
            DrawRadialPath.AddEllipse(r.X, r.Y, r.Width - 1, r.Height - 1);

            DrawRadialBrush1 = new PathGradientBrush(DrawRadialPath);
            DrawRadialBrush1.CenterPoint = new Point(r.X + cx, r.Y + cy);
            DrawRadialBrush1.InterpolationColors = blend;

            if (G.SmoothingMode == SmoothingMode.AntiAlias)
            {
                G.FillEllipse(DrawRadialBrush1, r.X + 1, r.Y + 1, r.Width - 3, r.Height - 3);
            }
            else
            {
                G.FillEllipse(DrawRadialBrush1, r);
            }
        }


        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        protected void DrawRadial(Color c1, Color c2, int x, int y, int width, int height)
        {
            DrawRadialRectangle = new Rectangle(x, y, width, height);
            DrawRadial(c1, c2, DrawRadialRectangle);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawRadial(Color c1, Color c2, int x, int y, int width, int height, float angle)
        {
            DrawRadialRectangle = new Rectangle(x, y, width, height);
            DrawRadial(c1, c2, DrawRadialRectangle, angle);
        }

        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="r">The r.</param>
        protected void DrawRadial(Color c1, Color c2, Rectangle r)
        {
            DrawRadialBrush2 = new LinearGradientBrush(r, c1, c2, 90f);
            G.FillEllipse(DrawRadialBrush2, r);
        }
        /// <summary>
        /// Draws the radial.
        /// </summary>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="r">The r.</param>
        /// <param name="angle">The angle.</param>
        protected void DrawRadial(Color c1, Color c2, Rectangle r, float angle)
        {
            DrawRadialBrush2 = new LinearGradientBrush(r, c1, c2, angle);
            G.FillEllipse(DrawRadialBrush2, r);
        }

        #endregion

        #region " CreateRound "

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

        #endregion

    }

    /// <summary>
    /// Class ThemeShare.
    /// </summary>
    static class ThemeShare
    {

        #region " Animation "

        /// <summary>
        /// The frames
        /// </summary>
        private static int Frames;
        /// <summary>
        /// The invalidate
        /// </summary>
        private static bool Invalidate;

        /// <summary>
        /// The theme timer
        /// </summary>
        public static PrecisionTimer ThemeTimer = new PrecisionTimer();
        //1000 / 50 = 20 FPS
        /// <summary>
        /// The FPS
        /// </summary>
        private const int FPS = 50;

        /// <summary>
        /// The rate
        /// </summary>
        private const int Rate = 10;
        /// <summary>
        /// Delegate AnimationDelegate
        /// </summary>
        /// <param name="invalidate">if set to <c>true</c> [invalidate].</param>
        public delegate void AnimationDelegate(bool invalidate);


        /// <summary>
        /// The callbacks
        /// </summary>
        private static List<AnimationDelegate> Callbacks = new List<AnimationDelegate>();
        /// <summary>
        /// Handles the callbacks.
        /// </summary>
        /// <param name="state">The state.</param>
        /// <param name="reserve">if set to <c>true</c> [reserve].</param>
        private static void HandleCallbacks(IntPtr state, bool reserve)
        {
            Invalidate = (Frames >= FPS);
            if (Invalidate)
                Frames = 0;

            lock (Callbacks)
            {
                for (int I = 0; I <= Callbacks.Count - 1; I++)
                {
                    Callbacks[I].Invoke(Invalidate);
                }
            }

            Frames += Rate;
        }

        /// <summary>
        /// Invalidates the theme timer.
        /// </summary>
        private static void InvalidateThemeTimer()
        {
            if (Callbacks.Count == 0)
            {
                ThemeTimer.Delete();
            }
            else
            {
                ThemeTimer.Create(0, Rate, HandleCallbacks);
            }
        }

        /// <summary>
        /// Adds the animation callback.
        /// </summary>
        /// <param name="callback">The callback.</param>
        public static void AddAnimationCallback(AnimationDelegate callback)
        {
            lock (Callbacks)
            {
                if (Callbacks.Contains(callback))
                    return;

                Callbacks.Add(callback);
                InvalidateThemeTimer();
            }
        }

        /// <summary>
        /// Removes the animation callback.
        /// </summary>
        /// <param name="callback">The callback.</param>
        public static void RemoveAnimationCallback(AnimationDelegate callback)
        {
            lock (Callbacks)
            {
                if (!Callbacks.Contains(callback))
                    return;

                Callbacks.Remove(callback);
                InvalidateThemeTimer();
            }
        }

        #endregion

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

    /// <summary>
    /// Struct Bloom
    /// </summary>
    public struct Bloom
    {

        /// <summary>
        /// The name
        /// </summary>
        public string _Name;
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get { return _Name; }
        }

        /// <summary>
        /// The value
        /// </summary>
        private Color _Value;
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public Color Value
        {
            get { return _Value; }
            set { _Value = value; }
        }

        /// <summary>
        /// Gets or sets the value hexadecimal.
        /// </summary>
        /// <value>The value hexadecimal.</value>
        public string ValueHex
        {
            get { return string.Concat("#", _Value.R.ToString("X2", null), _Value.G.ToString("X2", null), _Value.B.ToString("X2", null)); }
            set
            {
                try
                {
                    _Value = ColorTranslator.FromHtml(value);
                }
                catch
                {
                    return;
                }
            }
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Bloom"/> struct.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public Bloom(string name, Color value)
        {
            _Name = name;
            _Value = value;
        }
    }

    //------------------
    //Creator: aeonhack
    //Site: elitevs.net
    //Created: 11/30/2011
    //Changed: 11/30/2011
    //Version: 1.0.0
    //------------------
    /// <summary>
    /// Class PrecisionTimer.
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public class PrecisionTimer : IDisposable
    {

        /// <summary>
        /// The enabled
        /// </summary>
        private bool _Enabled;
        /// <summary>
        /// Gets a value indicating whether this <see cref="PrecisionTimer"/> is enabled.
        /// </summary>
        /// <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
        public bool Enabled
        {
            get { return _Enabled; }
        }

        /// <summary>
        /// The handle
        /// </summary>
        private IntPtr Handle;

        /// <summary>
        /// The timer callback
        /// </summary>
        private TimerDelegate TimerCallback;
        /// <summary>
        /// Creates the timer queue timer.
        /// </summary>
        /// <param name="handle">The handle.</param>
        /// <param name="queue">The queue.</param>
        /// <param name="callback">The callback.</param>
        /// <param name="state">The state.</param>
        /// <param name="dueTime">The due time.</param>
        /// <param name="period">The period.</param>
        /// <param name="flags">The flags.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        [DllImport("kernel32.dll", EntryPoint = "CreateTimerQueueTimer")]
        private static extern bool CreateTimerQueueTimer(ref IntPtr handle, IntPtr queue, TimerDelegate callback, IntPtr state, uint dueTime, uint period, uint flags);

        /// <summary>
        /// Deletes the timer queue timer.
        /// </summary>
        /// <param name="queue">The queue.</param>
        /// <param name="handle">The handle.</param>
        /// <param name="callback">The callback.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        [DllImport("kernel32.dll", EntryPoint = "DeleteTimerQueueTimer")]
        private static extern bool DeleteTimerQueueTimer(IntPtr queue, IntPtr handle, IntPtr callback);

        /// <summary>
        /// Delegate TimerDelegate
        /// </summary>
        /// <param name="r1">The r1.</param>
        /// <param name="r2">if set to <c>true</c> [r2].</param>
        public delegate void TimerDelegate(IntPtr r1, bool r2);

        /// <summary>
        /// Creates the specified due time.
        /// </summary>
        /// <param name="dueTime">The due time.</param>
        /// <param name="period">The period.</param>
        /// <param name="callback">The callback.</param>
        public void Create(uint dueTime, uint period, TimerDelegate callback)
        {
            if (_Enabled)
                return;

            TimerCallback = callback;
            bool Success = CreateTimerQueueTimer(ref Handle, IntPtr.Zero, TimerCallback, IntPtr.Zero, dueTime, period, 0);

            if (!Success)
                ThrowNewException("CreateTimerQueueTimer");
            _Enabled = Success;
        }

        /// <summary>
        /// Deletes this instance.
        /// </summary>
        public void Delete()
        {
            if (!_Enabled)
                return;
            bool Success = DeleteTimerQueueTimer(IntPtr.Zero, Handle, IntPtr.Zero);

            if (!Success && !(Marshal.GetLastWin32Error() == 997))
            {
                ThrowNewException("DeleteTimerQueueTimer");
            }

            _Enabled = !Success;
        }

        /// <summary>
        /// Throws the new exception.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <exception cref="System.Exception"></exception>
        private void ThrowNewException(string name)
        {
            throw new Exception(string.Format("{0} failed. Win32Error: {1}", name, Marshal.GetLastWin32Error()));
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Delete();
        }
    }

    #endregion

    /// <summary>
    /// Class SpicyLips.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.FormThemes.Helper.ThemeContainer154" />
    [ToolboxItem(false)]
    class SpicyLips : ThemeContainer154
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpicyLips"/> class.
        /// </summary>
        public SpicyLips()
        {
            TransparencyKey = Color.Fuchsia;
            Height = 30;
            BackColor = Color.FromArgb(20, 20, 20);
        }


        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {
        }

        /// <summary>
        /// Paints the hook.
        /// </summary>
        protected override void PaintHook()
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
    }

    //********************
    //Creator: Spicylips
    //Site: hackforums.net
    //Created: 01/17/2102
    //Changed: N / A
    //Version: 1.0.0.0
    //Theme Base: 1.5.4
    //********************
    /// <summary>
    /// Class BlackCloseButton.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.FormThemes.Helper.ThemeControl154" />
    [ToolboxItem(false)]
    class BlackCloseButton : ThemeControl154
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlackCloseButton"/> class.
        /// </summary>
        public BlackCloseButton()
        {
            Size = new Size(18, 18);
        }

        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {
        }


        /// <summary>
        /// Paints the hook.
        /// </summary>
        protected override void PaintHook()
        {
            G.Clear(Color.FromArgb(101, 101, 101));



            switch (State)
            {
                case MouseState.None:
                    DrawGradient(Color.FromArgb(40, 40, 40), Color.FromArgb(4, 4, 4), 0, 0, Width, Height, 90);
                    break;
                case MouseState.Over:
                    DrawGradient(Color.FromArgb(40, 40, 40), Color.FromArgb(4, 4, 4), 0, 0, Width, Height, 90);
                    break;
                case MouseState.Down:
                    DrawGradient(Color.FromArgb(4, 4, 4), Color.FromArgb(78, 0, 0), 0, 0, Width, Height, 90);
                    break;
            }
            DrawBorders(Pens.Black);
            DrawBorders(Pens.Black, 2);
            DrawCorners(Color.FromArgb(30, 30, 30), ClientRectangle);
            G.DrawString("X", Font, Brushes.White, 3, 3);
            DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
        }
    }

    //********************
    //Creator: Spicylips
    //Site: hackforums.net
    //Created: 01/17/2102
    //Changed: N / A
    //Version: 1.0.0.0
    //Theme Base: 1.5.4
    //********************
    /// <summary>
    /// Class BlackMinimizeButton.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.FormThemes.Helper.ThemeControl154" />
    [ToolboxItem(false)]
    class BlackMinimizeButton : ThemeControl154
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlackMinimizeButton"/> class.
        /// </summary>
        public BlackMinimizeButton()
        {
            Size = new Size(18, 18);
        }

        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {
        }

        /// <summary>
        /// Paints the hook.
        /// </summary>
        protected override void PaintHook()
        {
            G.Clear(Color.FromArgb(101, 101, 101));
            switch (State)
            {
                case MouseState.None:
                    DrawGradient(Color.FromArgb(40, 40, 40), Color.FromArgb(4, 4, 4), 0, 0, Width, Height, 90);
                    break;
                case MouseState.Over:
                    DrawGradient(Color.FromArgb(40, 40, 40), Color.FromArgb(4, 4, 4), 0, 0, Width, Height, 90);
                    break;
                case MouseState.Down:
                    DrawGradient(Color.FromArgb(4, 4, 4), Color.FromArgb(3, 65, 0), 0, 0, Width, Height, 90);
                    break;
            }
            DrawBorders(Pens.Black);
            DrawBorders(Pens.Black, 2);
            DrawCorners(Color.FromArgb(30, 30, 30), ClientRectangle);
            G.DrawString("_", Font, Brushes.White, 4, -2);
            DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
        }
    }

    //********************
    //Creator: Spicylips
    //Site: hackforums.net
    //Created: 01/17/2102
    //Changed: N / A
    //Version: 1.0.0.0
    //Theme Base: 1.5.4
    //********************
    /// <summary>
    /// Class BlackButton.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.FormThemes.Helper.ThemeControl154" />
    [ToolboxItem(false)]
    class BlackButton : ThemeControl154
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlackButton"/> class.
        /// </summary>
        public BlackButton()
        {
            Size = new Size(75, 23);
        }

        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {
        }

        /// <summary>
        /// Paints the hook.
        /// </summary>
        protected override void PaintHook()
        {
            G.Clear(Color.FromArgb(1, 1, 1));
            switch (State)
            {
                case MouseState.None:
                    DrawGradient(Color.FromArgb(40, 40, 40), Color.FromArgb(28, 28, 28), 0, 0, Width, Height, 90);
                    break;
                case MouseState.Over:
                    DrawGradient(Color.FromArgb(40, 40, 40), Color.FromArgb(28, 28, 28), 0, 0, Width, Height, 90);
                    break;
                case MouseState.Down:
                    DrawGradient(Color.FromArgb(4, 4, 4), Color.FromArgb(20, 20, 20), 0, 0, Width, Height, 90);
                    break;
            }
            G.FillRectangle(new SolidBrush(Color.FromArgb(6, Color.White)), 0, 0, Width, 12);
            DrawBorders(Pens.Black);
            DrawBorders(Pens.Black, 2);
            DrawCorners(Color.FromArgb(20, 20, 20), ClientRectangle);
            DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
        }
    }

    //********************
    //Creator: Spicylips
    //Site: hackforums.net
    //Created: 01/17/2102
    //Changed: N / A
    //Version: 1.0.0.0
    //Theme Base: 1.5.4
    //********************
    /// <summary>
    /// Class BlackButton1.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.FormThemes.Helper.ThemeControl154" />
    [ToolboxItem(false)]
    class BlackButton1 : ThemeControl154
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlackButton1"/> class.
        /// </summary>
        public BlackButton1()
        {
            Size = new Size(75, 23);
        }

        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {
        }

        /// <summary>
        /// Paints the hook.
        /// </summary>
        protected override void PaintHook()
        {
            G.Clear(Color.FromArgb(7, 7, 7));
            switch (State)
            {
                case MouseState.None:
                    DrawGradient(Color.FromArgb(79, 79, 79), Color.FromArgb(4, 4, 4), 0, 0, Width, Height, 90);
                    break;
                case MouseState.Over:
                    DrawGradient(Color.FromArgb(79, 79, 79), Color.FromArgb(4, 4, 4), 0, 0, Width, Height, 90);
                    break;
                case MouseState.Down:
                    DrawGradient(Color.FromArgb(4, 4, 4), Color.FromArgb(79, 79, 79), 0, 0, Width, Height, 90);
                    break;
            }
            G.FillRectangle(new SolidBrush(Color.FromArgb(6, Color.White)), 0, 0, Width, 12);
            DrawBorders(Pens.Black);
            DrawBorders(Pens.Black, 2);
            DrawCorners(Color.FromArgb(30, 30, 30), ClientRectangle);
            DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);

        }
    }

    //********************
    //Creator: Spicylips
    //Site: hackforums.net
    //Created: 01/17/2102
    //Changed: N / A
    //Version: 1.0.0.0
    //Theme Base: 1.5.4
    //********************
    /// <summary>
    /// Class BlackButton2.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.FormThemes.Helper.ThemeControl154" />
    [ToolboxItem(false)]
    class BlackButton2 : ThemeControl154
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlackButton2"/> class.
        /// </summary>
        public BlackButton2()
        {
            Size = new Size(75, 23);
        }

        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {
        }

        /// <summary>
        /// Paints the hook.
        /// </summary>
        protected override void PaintHook()
        {
            G.Clear(BackColor);
            switch (State)
            {
                case MouseState.None:
                    DrawGradient(Color.FromArgb(40, 40, 40), Color.FromArgb(4, 4, 4), 0, 0, Width, Height, 90);
                    break;
                case MouseState.Over:
                    DrawGradient(Color.FromArgb(40, 40, 40), Color.FromArgb(4, 4, 4), 0, 0, Width, Height, 90);
                    break;
                case MouseState.Down:
                    DrawGradient(Color.FromArgb(4, 4, 4), Color.FromArgb(40, 40, 40), 0, 0, Width, Height, 90);
                    break;
            }
            G.FillRectangle(new SolidBrush(Color.FromArgb(6, Color.White)), 0, 0, Width, 12);
            DrawBorders(Pens.Black);
            DrawBorders(Pens.Black, 2);
            DrawCorners(Color.FromArgb(20, 20, 20), ClientRectangle);
            DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
        }
    }

    //********************
    //Creator: Spicylips
    //Site: hackforums.net
    //Created: 01/17/2102
    //Changed: N / A
    //Version: 1.0.0.0
    //Theme Base: 1.5.4
    //********************
    /// <summary>
    /// Class BlackCheckBox.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.FormThemes.Helper.ThemeControl154" />
    [ToolboxItem(false)]
    class BlackCheckBox : ThemeControl154
    {
        /// <summary>
        /// The checked state
        /// </summary>
        private bool _CheckedState;
        /// <summary>
        /// Gets or sets a value indicating whether [checked state].
        /// </summary>
        /// <value><c>true</c> if [checked state]; otherwise, <c>false</c>.</value>
        public bool CheckedState
        {
            get { return _CheckedState; }
            set
            {
                _CheckedState = value;
                Invalidate();
            }
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BlackCheckBox"/> class.
        /// </summary>
        public BlackCheckBox()
        {
            Click += changeCheck;
            Size = new Size(158, 16);
            MinimumSize = new Size(16, 16);
            MaximumSize = new Size(600, 16);
            CheckedState = false;
        }

        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {
        }

        /// <summary>
        /// Paints the hook.
        /// </summary>
        protected override void PaintHook()
        {
            Color FontColor = default(Color);
            FontColor = Color.White;

            G.Clear(Color.FromArgb(22, 22, 22));
            switch (CheckedState)
            {
                case true:
                    DrawGradient(Color.FromArgb(40, 40, 40), Color.FromArgb(30, 30, 30), 3, 3, 9, 9, 90);
                    DrawGradient(Color.FromArgb(65, 65, 65), Color.FromArgb(20, 20, 20), 4, 4, 7, 7, 90);
                    break;
                case false:
                    DrawGradient(Color.FromArgb(34, 34, 34), Color.FromArgb(34, 34, 34), 0, 0, 15, 15, 90);
                    break;
            }
            G.DrawRectangle(Pens.Black, 0, 0, 14, 14);
            G.DrawRectangle(Pens.Black, 2, 2, 10, 10);
            DrawText(Brushes.White, HorizontalAlignment.Left, 17, 0);
        }
        /// <summary>
        /// Changes the check.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void changeCheck(object sender, EventArgs e)
        {
            switch (CheckedState)
            {
                case true:
                    CheckedState = false;
                    break;
                case false:
                    CheckedState = true;
                    break;
            }
        }
    }

    //********************
    //Creator: Spicylips
    //Site: hackforums.net
    //Created: 01/17/2102
    //Changed: N / A
    //Version: 1.0.0.0
    //Theme Base: 1.5.4
    //********************
    /// <summary>
    /// Class BlackSeperator.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.FormThemes.Helper.ThemeControl154" />
    [ToolboxItem(false)]
    class BlackSeperator : ThemeControl154
    {
        /// <summary>
        /// The orientation
        /// </summary>
        private Orientation _Orientation;
        /// <summary>
        /// Gets or sets the orientation.
        /// </summary>
        /// <value>The orientation.</value>
        public Orientation Orientation
        {
            get { return _Orientation; }

            set
            {
                _Orientation = value;

                if (value == Orientation.Vertical)
                {
                    LockHeight = 0;
                    LockWidth = 12;
                }
                else
                {
                    LockHeight = 12;
                    LockWidth = 0;
                }

                Invalidate();
            }
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BlackSeperator"/> class.
        /// </summary>
        public BlackSeperator()
        {
            LockHeight = 12;
        }


        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {
        }

        /// <summary>
        /// Paints the hook.
        /// </summary>
        protected override void PaintHook()
        {
            G.Clear(Color.FromArgb(22, 22, 22));

            if (_Orientation == Orientation.Horizontal)
            {
                G.DrawLine(new Pen(Color.FromArgb(2, 2, 2)), 0, 6, Width, 6);
                G.DrawLine(new Pen(Color.FromArgb(22, 22, 22)), 0, 7, Width, 7);
            }
            else
            {
                G.DrawLine(new Pen(Color.FromArgb(2, 2, 2)), 6, 0, 6, Height);
                G.DrawLine(new Pen(Color.FromArgb(22, 22, 22)), 7, 0, 7, Height);
            }

        }
    }

    //********************
    //Creator: Spicylips
    //Site: hackforums.net
    //Created: 01/17/2102
    //Changed: N / A
    //Version: 1.0.0.0
    //Theme Base: 1.5.4
    //********************
    /// <summary>
    /// Class BlackPanel.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.FormThemes.Helper.ThemeControl154" />
    [ToolboxItem(false)]
    class BlackPanel : ThemeControl154
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlackPanel"/> class.
        /// </summary>
        public BlackPanel()
        {
            Size = new Size(120, 120);
        }

        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {
        }

        /// <summary>
        /// Paints the hook.
        /// </summary>
        protected override void PaintHook()
        {
            G.Clear(Color.FromArgb(26, 26, 26));
            DrawBorders(new Pen(new SolidBrush(Color.FromArgb(7, 7, 7))), ClientRectangle);
            DrawCorners(Color.FromArgb(22, 22, 22), ClientRectangle);
            DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
        }
    }

    //********************
    //Creator: Spicylips
    //Site: hackforums.net
    //Created: 01/18/2102
    //Changed: N / A
    //Version: 1.0.0.0
    //Theme Base: 1.5.4
    //********************
    /// <summary>
    /// Class BlackGroupBox.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.FormThemes.Helper.ThemeContainer154" />
    [ToolboxItem(false)]
    class BlackGroupBox : ThemeContainer154
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlackGroupBox"/> class.
        /// </summary>
        public BlackGroupBox()
        {
            ControlMode = true;
            BackColor = Color.FromArgb(20, 20, 20);
        }

        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {
        }

        /// <summary>
        /// Paints the hook.
        /// </summary>
        protected override void PaintHook()
        {
            G.Clear(Color.FromArgb(26, 26, 26));

            HatchBrush T = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(9, 9, 9), Color.FromArgb(15, 15, 15));
            G.FillRectangle(T, ClientRectangle);
            G.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.White)), ClientRectangle);
            DrawText(Brushes.White, HorizontalAlignment.Center, -1, -1);
            G.FillRectangle(new SolidBrush(Color.FromArgb(22, 22, 22)), 10, 20, Width - 21, Height);
            DrawBorders(new Pen(Color.FromArgb(7, 7, 7)), 0, 0, Width, Height);
            DrawCorners(Color.FromArgb(22, 22, 22), ClientRectangle);
            DrawBorders(Pens.Black, 10, 20, Width - 21, Height);
        }
    }

    //********************
    //Creator: Spicylips
    //Site: hackforums.net
    //Created: 01/18/2102
    //Changed: N / A
    //Version: 1.0.0.0
    //Theme Base: 1.5.4
    //********************
    /// <summary>
    /// Class BlackProgressBar.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.FormThemes.Helper.ThemeControl154" />
    [ToolboxItem(false)]
    class BlackProgressBar : ThemeControl154
    {


        /// <summary>
        /// The blend
        /// </summary>
        private ColorBlend Blend;
        /// <summary>
        /// Initializes a new instance of the <see cref="BlackProgressBar"/> class.
        /// </summary>
        public BlackProgressBar()
        {
            Blend = new ColorBlend();
            Blend.Colors = new Color[] {
            Color.FromArgb(37, 37, 37),
            Color.FromArgb(64, 66, 68),
            Color.FromArgb(64, 66, 68),
            Color.FromArgb(37, 37, 37)
        };
            Blend.Positions = new float[] {
            0f,
            0.4f,
            0.6f,
            1f
        };

            IsAnimated = true;

            P1 = new Pen(Color.FromArgb(32, 32, 32));
            P2 = new Pen(Color.FromArgb(15, Color.White));
            P3 = Pens.Black;
            P4 = Pens.Black;

            B1 = new SolidBrush(Color.FromArgb(50, 50, 50));
            B2 = new SolidBrush(Color.FromArgb(37, 37, 37));
            B3 = new SolidBrush(Color.FromArgb(13, Color.White));

            C1 = Color.FromArgb(8, 8, 8);
            C2 = Color.FromArgb(23, 23, 23);
        }

        /// <summary>
        /// The glow position
        /// </summary>
        private float GlowPosition = -1f;
        /// <summary>
        /// Called when [animation].
        /// </summary>
        protected override void OnAnimation()
        {
            GlowPosition += 0.05f;
            if (GlowPosition >= 1f)
                GlowPosition = -1f;
        }

        /// <summary>
        /// The value
        /// </summary>
        private int _Value;
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public int Value
        {
            get { return _Value; }
            set
            {
                if (value > _Maximum)
                    value = _Maximum;
                if (value < 0)
                    value = 0;

                _Value = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The maximum
        /// </summary>
        private int _Maximum = 100;
        /// <summary>
        /// Gets or sets the maximum.
        /// </summary>
        /// <value>The maximum.</value>
        public int Maximum
        {
            get { return _Maximum; }
            set
            {
                if (value < 1)
                    value = 1;
                if (_Value > value)
                    _Value = value;

                _Maximum = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Increments the specified amount.
        /// </summary>
        /// <param name="amount">The amount.</param>
        public void Increment(int amount)
        {
            Value += amount;
        }


        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {
        }

        /// <summary>
        /// The p1
        /// </summary>
        private Pen P1;
        /// <summary>
        /// The p2
        /// </summary>
        private Pen P2;
        /// <summary>
        /// The p3
        /// </summary>
        private Pen P3;
        /// <summary>
        /// The p4
        /// </summary>
        private Pen P4;
        /// <summary>
        /// The b1
        /// </summary>
        private SolidBrush B1;
        /// <summary>
        /// The b2
        /// </summary>
        private SolidBrush B2;
        /// <summary>
        /// The b3
        /// </summary>
        private SolidBrush B3;
        /// <summary>
        /// The c1
        /// </summary>
        private Color C1;

        /// <summary>
        /// The c2
        /// </summary>
        private Color C2;

        /// <summary>
        /// The r1
        /// </summary>
        private Rectangle R1;
        /// <summary>
        /// The progress
        /// </summary>
        private int Progress;
        /// <summary>
        /// Paints the hook.
        /// </summary>
        protected override void PaintHook()
        {
            DrawBorders(P1, 1);
            G.FillRectangle(B1, 0, 0, Width, 8);

            DrawGradient(C1, C2, 2, 2, Width - 4, Height - 4, 90f);

            Progress = Convert.ToInt32((_Value / _Maximum) * Width);

            if (!(Progress == 0))
            {
                R1 = new Rectangle(3, 3, Progress - 6, Height - 6);

                G.SetClip(R1);
                G.FillRectangle(B2, 0, 0, Progress, Height);

                DrawGradient(Blend, Convert.ToInt32(GlowPosition * Progress), 0, Progress, Height, 0f);
                DrawBorders(P2, 3, 3, Progress - 6, Height - 6);

                G.FillRectangle(B3, 3, 3, Width - 6, 5);
                G.ResetClip();
            }

            DrawBorders(P3, 2);
            DrawBorders(P4);
        }
    }

    //********************
    //Creator: Spicylips
    //Site: hackforums.net
    //Created: 01/18/2102
    //Changed: N / A
    //Version: 1.0.0.0
    //Theme Base: 1.5.4
    //********************
    /// <summary>
    /// Class BlackTextBox.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.FormThemes.Helper.ThemeControl154" />
    [ToolboxItem(false)]
    class BlackTextBox : ThemeControl154
    {
        /// <summary>
        /// The with events field text
        /// </summary>
        private TextBox withEventsField_Txt = new TextBox();
        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>The text.</value>
        private TextBox Txt
        {
            get { return withEventsField_Txt; }
            set
            {
                if (withEventsField_Txt != null)
                {
                    withEventsField_Txt.TextChanged -= TextBox_TextChanged;
                }
                withEventsField_Txt = value;
                if (withEventsField_Txt != null)
                {
                    withEventsField_Txt.TextChanged += TextBox_TextChanged;
                }
            }
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BlackTextBox"/> class.
        /// </summary>
        public BlackTextBox()
        {
            TextChanged += PropertyTextChanged;
            Txt.TextAlign = HorizontalAlignment.Left;
            Txt.BorderStyle = BorderStyle.None;
            Txt.Location = new Point(2, 2);
            Controls.Add(Txt);
            Txt.Text = " ";
            Text = " ";
            Size = new Size(100, 20);
            LockHeight = 20;
        }
        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {
            Txt.ForeColor = Color.White;
        }

        /// <summary>
        /// Paints the hook.
        /// </summary>
        protected override void PaintHook()
        {
            G.Clear(Color.FromArgb(9, 9, 9));
            Txt.BackColor = Color.FromArgb(9, 9, 9);
            G.DrawRectangle(Pens.Black, 0, 0, Width - 1, Height - 1);
            G.DrawRectangle(Pens.Black, 1, 1, Width - 3, Height - 3);
            Txt.Size = new Size(this.Width - 4, Txt.Height - 4);
        }
        /// <summary>
        /// Handles the TextChanged event of the TextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void TextBox_TextChanged(object sender, EventArgs e)
        {
            Text = Txt.Text;
        }
        /// <summary>
        /// Properties the text changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void PropertyTextChanged(object sender, EventArgs e)
        {
            Txt.Text = Text;
        }
    }

}