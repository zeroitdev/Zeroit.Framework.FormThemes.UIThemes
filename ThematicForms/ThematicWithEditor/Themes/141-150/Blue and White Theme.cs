// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Blue and White Theme.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Zeroit.Framework.FormThemes.UIThemes
{

    //----------------------------
    //The Blue and White GUI Theme
    //Creator: FuckFace
    //Version: 1.0
    //Created: 14/04/2014
    //Changed: 26/04/2014
    //----------------------------


    #region Duplicate
    //[DefaultEvent("Scroll")]
    //public class BaWGUITrackBar : Control
    //{
    //    #region " Declarations "
    //    private bool Moveable;
    //    private GraphicsPath Slider;
    //    private GraphicsPath Track;
    //    private int DrawValue;
    //    private LinearGradientBrush SliderGB;
    //    private LinearGradientBrush SliderOGB;
    //    private Pen BaWGUI_P1;
    //    private Pen BaWGUI_P2;
    //    private Pen BaWGUI_P3;
    //    private SolidBrush BaWGUI_B1;

    //    private SolidBrush BaWGUI_B2;
    //    public event ScrollEventHandler Scroll;
    //    public delegate void ScrollEventHandler(object sender);

    //    private int _Maximum = 10;
    //    private int _Minimum;
    //    #endregion
    //    private int _Value;

    //    #region " Properties "
    //    [Category("Behavior")]
    //    public int Maximum
    //    {
    //        get { return _Maximum; }
    //        set
    //        {
    //            _Maximum = value;
    //            if (value < _Value)
    //                _Value = value;
    //            if (value < _Minimum)
    //                _Minimum = value;

    //            DrawValue = Convert.ToInt32((_Value - _Minimum) / (_Maximum - _Minimum) * (Width - 24));
    //            ChangePaths();
    //            Invalidate();
    //        }
    //    }

    //    [Category("Behavior")]
    //    public int Minimum
    //    {
    //        get { return _Minimum; }
    //        set
    //        {
    //            if (value < 0)
    //            {
    //            }

    //            _Minimum = value;

    //            if (value > _Value)
    //                _Value = value;
    //            if (value > _Maximum)
    //                _Maximum = value;

    //            DrawValue = Convert.ToInt32((_Value - _Minimum) / (_Maximum - _Minimum) * (Width - 24));
    //            ChangePaths();
    //            Invalidate();
    //        }
    //    }

    //    [Category("Behavior")]
    //    public int Value
    //    {
    //        get { return _Value; }
    //        set
    //        {
    //            if (value == _Value)
    //                return;

    //            if (value > _Maximum)
    //                value = _Maximum;
    //            if (value < _Minimum)
    //                value = _Minimum;

    //            _Value = value;

    //            DrawValue = Convert.ToInt32((_Value - _Minimum) / (_Maximum - _Minimum) * (Width - 24));
    //            ChangePaths();
    //            Invalidate();
    //            if (Scroll != null)
    //            {
    //                Scroll(this);
    //            }
    //        }
    //    }
    //    #endregion

    //    public BaWGUITrackBar()
    //    {
    //        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);

    //        BackColor = Color.Transparent;
    //        DoubleBuffered = true;

    //        BaWGUI_P1 = new Pen(Color.FromArgb(156, 156, 156));
    //        BaWGUI_P2 = new Pen(Color.FromArgb(205, 205, 205));
    //        BaWGUI_B1 = new SolidBrush(Color.FromArgb(194, 194, 194));
    //        BaWGUI_B2 = new SolidBrush(Color.FromArgb(75, 145, 215));
    //    }

    //    protected override void OnKeyDown(KeyEventArgs e)
    //    {
    //        if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left)
    //        {
    //            if (Value == 0)
    //                return;
    //            Value -= 1;
    //        }
    //        else if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Up || e.KeyCode == Keys.Right)
    //        {
    //            if (Value == _Maximum)
    //                return;
    //            Value += 1;
    //        }

    //        base.OnKeyDown(e);
    //    }

    //    protected override void BaWGUI_OnMouseDown(MouseEventArgs e)
    //    {
    //        if (e.Button == MouseButtons.Left && Height > 0)
    //        {
    //            DrawValue = Convert.ToInt32((_Value - _Minimum) / (_Maximum - _Minimum) * (Width - 24));
    //            ChangePaths();

    //            Moveable = new Rectangle(DrawValue, 0, 24, Height).Contains(e.Location);
    //        }

    //        base.BaWGUI_OnMouseDown(e);
    //    }

    //    protected override void BaWGUI_OnMouseMove(MouseEventArgs e)
    //    {
    //        if (Moveable && e.X > -1 && e.X < Width + 1)
    //            Value = _Minimum + Convert.ToInt32((_Maximum - _Minimum) * (e.X / Width));

    //        base.BaWGUI_OnMouseMove(e);
    //    }

    //    protected override void OnMouseUp(MouseEventArgs e)
    //    {
    //        Moveable = false;
    //        base.OnMouseUp(e);
    //    }

    //    protected override void OnResize(EventArgs e)
    //    {
    //        if (Width > 0 && Height > 0)
    //        {
    //            DrawValue = Convert.ToInt32((_Value - _Minimum) / (_Maximum - _Minimum) * (Width - 24));

    //            Track = new GraphicsPath();

    //            SliderOGB = new LinearGradientBrush(new Rectangle(DrawValue, 0, 24, Height), Color.FromArgb(100, 170, 230), Color.FromArgb(70, 140, 210), 90);

    //            BaWGUI_P3 = new Pen(SliderOGB);


    //            var _with1 = Track;
    //            _with1.AddArc(0, 27, 10, 10, 90, 180);
    //            _with1.AddArc(Width - 11, 27, 10, 10, -90, 180);
    //            _with1.CloseFigure();
    //            ChangePaths();

    //            Height = 37;
    //        }

    //        Invalidate();
    //        base.OnResize(e);
    //    }

    //    protected override void BaWGUI_PaintHook(PaintEventArgs e)
    //    {
    //        var _with2 = e.Graphics;
    //        _with2.SmoothingMode = SmoothingMode.HighQuality;

    //        _with2.FillPath(BaWGUI_B1, Track);
    //        _with2.DrawLine(BaWGUI_P1, 5, 27, Width - 6, 27);

    //        for (int i = 0; i <= _Maximum - _Minimum + 1; i++)
    //        {
    //            _with2.DrawLine(BaWGUI_P2, Convert.ToInt32(i / (_Maximum - _Minimum) * (Width - 24) + 10), 25, Convert.ToInt32(i / (_Maximum - _Minimum) * (Width - 24) + 10), 18);
    //        }

    //        _with2.FillPath(SliderGB, Slider);
    //        _with2.DrawPath(BaWGUI_P3, Slider);

    //        _with2.FillEllipse(BaWGUI_B2, DrawValue + 5, 10, 2, 2);
    //        _with2.FillEllipse(BaWGUI_B2, DrawValue + 9, 10, 2, 2);
    //        _with2.FillEllipse(BaWGUI_B2, DrawValue + 13, 10, 2, 2);
    //        _with2.FillEllipse(BaWGUI_B2, DrawValue + 5, 14, 2, 2);
    //        _with2.FillEllipse(BaWGUI_B2, DrawValue + 9, 14, 2, 2);
    //        _with2.FillEllipse(BaWGUI_B2, DrawValue + 13, 14, 2, 2);
    //    }

    //    private void ChangePaths()
    //    {
    //        if (Width > 0 && Height > 0)
    //        {
    //            Slider = new GraphicsPath();

    //            SliderGB = new LinearGradientBrush(new Rectangle(DrawValue, 0, 24, Height), Color.FromArgb(170, 210, 245), Color.FromArgb(80, 150, 225), 90);


    //            var _with3 = Slider;
    //            _with3.AddArc(DrawValue, 0, 4, 4, 180, 90);
    //            _with3.AddArc(DrawValue + 17, 0, 4, 4, -90, 90);
    //            _with3.AddLine(DrawValue + 21, 4, DrawValue + 21, 25);
    //            _with3.AddLine(DrawValue + 21, 25, DrawValue + 10, Height - 1);
    //            _with3.AddLine(DrawValue, 25, DrawValue, 2);
    //        }
    //    }
    //}

    //public class BaWGUIButton : Control
    //{
    //    #region " Declarations "
    //    private int State;
    //    private GraphicsPath Shape;
    //    private LinearGradientBrush InactiveGB;
    //    private LinearGradientBrush ActiveGB;
    //    private LinearGradientBrush ActiveContourGB;
    //    private LinearGradientBrush PressedGB;
    //    private LinearGradientBrush PressedContourGB;
    //    private Rectangle BaWGUI_R1;
    //    private Rectangle BaWGUI_R2;
    //    private Pen BaWGUI_P1;
    //    private Pen BaWGUI_P2;
    //    private Pen BaWGUI_P3;
    //    private Pen P4;
    //    private SolidBrush BaWGUI_B1;
    //    private SolidBrush BaWGUI_B2;
    //    private SolidBrush BaWGUI_B3;
    //    private StringFormat BaWGUI_CSF = new StringFormat
    //    {
    //        Alignment = StringAlignment.Center,
    //        LineAlignment = StringAlignment.Center
    //        #endregion
    //    };

    //    public BaWGUIButton()
    //    {
    //        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);

    //        BackColor = Color.Transparent;
    //        DoubleBuffered = true;
    //        Font = new Font("Arial", 12);
    //        Size = new Size(130, 45);

    //        BaWGUI_P1 = new Pen(Color.FromArgb(185, 185, 185));
    //        // BaWGUI_P2 is in the OnResize event.
    //        // BaWGUI_P3 is in the OnResize event.
    //        P4 = new Pen(Color.FromArgb(135, 182, 233));
    //        BaWGUI_B1 = new SolidBrush(Color.FromArgb(114, 114, 114));
    //        BaWGUI_B2 = new SolidBrush(Color.FromArgb(246, 247, 250));
    //        BaWGUI_B3 = new SolidBrush(Color.FromArgb(25, 55, 82));
    //    }

    //    protected override void BaWGUI_OnMouseDown(MouseEventArgs e)
    //    {
    //        State = 2;
    //        Invalidate();

    //        base.BaWGUI_OnMouseDown(e);
    //    }

    //    protected override void OnMouseEnter(EventArgs e)
    //    {
    //        State = 1;
    //        Invalidate();

    //        base.OnMouseEnter(e);
    //    }

    //    protected override void OnMouseLeave(EventArgs e)
    //    {
    //        State = 0;
    //        Invalidate();

    //        base.OnMouseLeave(e);
    //    }

    //    protected override void OnMouseUp(MouseEventArgs e)
    //    {
    //        State = 1;
    //        Invalidate();

    //        base.OnMouseUp(e);
    //    }

    //    protected override void OnTextChanged(System.EventArgs e)
    //    {
    //        Invalidate();
    //        base.OnTextChanged(e);
    //    }

    //    protected override void OnResize(System.EventArgs e)
    //    {
    //        if (Width > 0 && Height > 0)
    //        {
    //            Shape = new GraphicsPath();

    //            BaWGUI_R1 = new Rectangle(0, 0, Width, Height);
    //            BaWGUI_R2 = new Rectangle(0, 1, Width, Height);

    //            InactiveGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(249, 249, 249), Color.FromArgb(222, 222, 222), 90);
    //            ActiveGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(171, 210, 244), Color.FromArgb(84, 153, 228), 90);
    //            ActiveContourGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(121, 180, 235), Color.FromArgb(70, 137, 201), 90);
    //            PressedGB = new LinearGradientBrush(new Rectangle(0, 1, Width, Height), Color.FromArgb(97, 162, 228), Color.FromArgb(114, 173, 233), 90);
    //            PressedContourGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(74, 141, 208), Color.FromArgb(114, 173, 230), 90);

    //            BaWGUI_P2 = new Pen(ActiveContourGB);
    //            BaWGUI_P3 = new Pen(PressedContourGB);

    //            var _with1 = Shape;
    //            _with1.AddArc(0, 0, 10, 10, 180, 90);
    //            _with1.AddArc(Width - 11, 0, 10, 10, -90, 90);
    //            _with1.AddArc(Width - 11, Height - 11, 10, 10, 0, 90);
    //            _with1.AddArc(0, Height - 11, 10, 10, 90, 90);
    //            _with1.CloseAllFigures();
    //        }

    //        Invalidate();
    //        base.OnResize(e);
    //    }

    //    protected override void BaWGUI_PaintHook(PaintEventArgs e)
    //    {
    //        var _with2 = e.Graphics;
    //        _with2.SmoothingMode = SmoothingMode.HighQuality;

    //        switch (State)
    //        {
    //            case 0:
    //                //Inactive
    //                _with2.FillPath(InactiveGB, Shape);
    //                _with2.DrawPath(BaWGUI_P1, Shape);
    //                _with2.DrawString(Text, Font, BaWGUI_B1, BaWGUI_R1, BaWGUI_CSF);
    //                break;
    //            case 1:
    //                //Active
    //                _with2.FillPath(ActiveGB, Shape);
    //                _with2.DrawPath(BaWGUI_P2, Shape);
    //                _with2.DrawString(Text, Font, Brushes.DarkSlateGray, BaWGUI_R2, BaWGUI_CSF);
    //                _with2.DrawString(Text, Font, BaWGUI_B2, BaWGUI_R1, BaWGUI_CSF);
    //                break;
    //            case 2:
    //                //Pressed
    //                _with2.FillPath(PressedGB, Shape);
    //                _with2.DrawPath(BaWGUI_P3, Shape);
    //                _with2.DrawLine(P4, 1, 1, Width - 2, 1);
    //                _with2.DrawString(Text, Font, Brushes.White, BaWGUI_R2, BaWGUI_CSF);
    //                _with2.DrawString(Text, Font, BaWGUI_B3, BaWGUI_R1, BaWGUI_CSF);
    //                break;
    //        }

    //        base.BaWGUI_PaintHook(e);
    //    }
    //}

    //[DefaultEvent("CheckedChanged")]
    //public class BaWGUICheckBox : Control
    //{
    //    #region " Declarations "
    //    private Font MFont = new Font("Marlett", 16);
    //    private GraphicsPath Shape;
    //    private LinearGradientBrush GB;
    //    private Pen BaWGUI_P1;
    //    private Rectangle BaWGUI_R1;
    //    private Rectangle BaWGUI_R2;
    //    private SolidBrush BaWGUI_B1;
    //    private SolidBrush BaWGUI_B2;

    //    private StringFormat BaWGUI_CSF = new StringFormat { LineAlignment = StringAlignment.Center };
    //    public event CheckedChangedEventHandler CheckedChanged;
    //    public delegate void CheckedChangedEventHandler(object sender);

    //    #endregion
    //    private bool _Checked;

    //    #region " Properties "
    //    [Category("Appearance")]
    //    public bool Checked
    //    {
    //        get { return _Checked; }
    //        set
    //        {
    //            _Checked = value;
    //            if (CheckedChanged != null)
    //            {
    //                CheckedChanged(this);
    //            }
    //            Invalidate();
    //        }
    //    }
    //    #endregion

    //    public BaWGUICheckBox()
    //    {
    //        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);

    //        BackColor = Color.Transparent;
    //        DoubleBuffered = true;
    //        Font = new Font("Arial", 12);
    //        Size = new Size(185, 26);

    //        BaWGUI_P1 = new Pen(Color.FromArgb(160, 160, 160));
    //        BaWGUI_B1 = new SolidBrush(Color.FromArgb(114, 114, 114));
    //        BaWGUI_B2 = new SolidBrush(Color.FromArgb(110, 175, 235));
    //    }

    //    protected override void OnClick(EventArgs e)
    //    {
    //        _Checked = !_Checked;
    //        if (CheckedChanged != null)
    //        {
    //            CheckedChanged(this);
    //        }
    //        Invalidate();

    //        base.OnClick(e);
    //    }

    //    protected override void OnTextChanged(System.EventArgs e)
    //    {
    //        Invalidate();
    //        base.OnTextChanged(e);
    //    }

    //    protected override void OnResize(System.EventArgs e)
    //    {
    //        if (Width > 0 && Height > 0)
    //        {
    //            Shape = new GraphicsPath();

    //            BaWGUI_R1 = new Rectangle(30, 0, Width, Height);
    //            BaWGUI_R2 = new Rectangle(0, 0, Width, Height);

    //            GB = new LinearGradientBrush(new Rectangle(0, 0, 25, 25), Color.FromArgb(244, 245, 244), Color.FromArgb(227, 227, 227), 90);


    //            var _with1 = Shape;
    //            _with1.AddArc(0, 0, 10, 10, 180, 90);
    //            _with1.AddArc(14, 0, 10, 10, -90, 90);
    //            _with1.AddArc(14, 14, 10, 10, 0, 90);
    //            _with1.AddArc(0, 14, 10, 10, 90, 90);
    //            _with1.CloseAllFigures();

    //            Height = 26;
    //        }

    //        Invalidate();
    //        base.OnResize(e);
    //    }

    //    protected override void BaWGUI_PaintHook(PaintEventArgs e)
    //    {
    //        var _with2 = e.Graphics;
    //        _with2.SmoothingMode = SmoothingMode.HighQuality;

    //        _with2.FillPath(GB, Shape);
    //        _with2.DrawPath(BaWGUI_P1, Shape);

    //        _with2.DrawString(Text, Font, BaWGUI_B1, BaWGUI_R1, BaWGUI_CSF);

    //        if (Checked)
    //        {
    //            _with2.DrawString("a", MFont, BaWGUI_B2, BaWGUI_R2, BaWGUI_CSF);
    //        }

    //        base.BaWGUI_PaintHook(e);
    //    }
    //}

    //public class BaWGUIComboBox : ComboBox
    //{
    //    #region " Declarations "
    //    private GraphicsPath Side;
    //    private GraphicsPath Button;
    //    private GraphicsPath Arrow1;
    //    private GraphicsPath Arrow2;
    //    private LinearGradientBrush SideGB;
    //    private LinearGradientBrush ButtonOGB;
    //    private LinearGradientBrush ButtonGB;
    //    private Rectangle BaWGUI_R1;
    //    private Pen BaWGUI_P1;
    //    private Pen BaWGUI_P2;
    //    private Pen BaWGUI_P3;
    //    private Pen P4;
    //    private SolidBrush BaWGUI_B1;
    //    private SolidBrush BaWGUI_B2;
    //    private SolidBrush BaWGUI_B3;

    //    private StringFormat BaWGUI_CSF = new StringFormat { LineAlignment = StringAlignment.Center };
    //    #endregion
    //    private int _StartIndex = 0;

    //    #region " Properties "
    //    private int StartIndex
    //    {
    //        get { return _StartIndex; }
    //        set
    //        {
    //            _StartIndex = value;
    //            try
    //            {
    //                base.SelectedIndex = value;
    //            }
    //            catch
    //            {
    //            }
    //            Invalidate();
    //        }
    //    }
    //    #endregion

    //    public BaWGUIComboBox()
    //    {
    //        DrawItem += DrawItm;
    //        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);

    //        BackColor = Color.Transparent;
    //        DoubleBuffered = true;
    //        DrawMode = DrawMode.OwnerDrawFixed;
    //        DropDownStyle = ComboBoxStyle.DropDownList;
    //        Font = new Font("Arial", 12);
    //        ForeColor = Color.Black;
    //        ItemHeight = 39;
    //        StartIndex = 0;

    //        BaWGUI_P1 = new Pen(Color.FromArgb(180, 180, 180));
    //        BaWGUI_P3 = new Pen(Color.FromArgb(110, 170, 230));
    //        P4 = new Pen(Color.FromArgb(50, 130, 215));
    //        BaWGUI_B1 = new SolidBrush(Color.FromArgb(100, 130, 160));
    //        BaWGUI_B2 = new SolidBrush(Color.FromArgb(114, 114, 114));
    //        BaWGUI_B3 = new SolidBrush(Color.FromArgb(246, 247, 250));
    //    }

    //    protected override void OnResize(EventArgs e)
    //    {
    //        if (Width > 0 && Height > 0)
    //        {
    //            Side = new GraphicsPath();
    //            Button = new GraphicsPath();
    //            Arrow1 = new GraphicsPath();
    //            Arrow2 = new GraphicsPath();

    //            ButtonOGB = new LinearGradientBrush(new Rectangle(Width - 51, 0, Width, Height), Color.FromArgb(125, 180, 235), Color.FromArgb(45, 125, 200), 90);
    //            ButtonGB = new LinearGradientBrush(new Rectangle(Width - 50, 0, Width, Height), Color.FromArgb(175, 215, 240), Color.FromArgb(70, 145, 215), 90);
    //            SideGB = new LinearGradientBrush(new Rectangle(0, 0, Width - 50, Height), Color.FromArgb(253, 253, 253), Color.FromArgb(223, 223, 223), 90);

    //            BaWGUI_R1 = new Rectangle(12, 0, Width, Height);

    //            BaWGUI_P2 = new Pen(ButtonOGB);


    //            var _with1 = Side;
    //            _with1.AddArc(0, 0, 10, 10, 180, 90);
    //            _with1.AddLine(Width - 50, 0, Width - 50, Height - 1);
    //            _with1.AddArc(0, Height - 11, 10, 10, 90, 90);
    //            _with1.CloseFigure();
    //            var _with2 = Button;
    //            _with2.AddLine(Width - 51, Height - 1, Width - 51, 0);
    //            _with2.AddArc(Width - 11, 0, 10, 10, -90, 90);
    //            _with2.AddArc(Width - 11, Height - 11, 10, 10, 0, 90);
    //            _with2.CloseFigure();
    //            var _with3 = Arrow1;
    //            _with3.AddLine(Width - 35, 21, Width - 19, 21);
    //            _with3.AddLine(Width - 19, 21, Width - 27, 11);
    //            _with3.CloseFigure();
    //            var _with4 = Arrow2;
    //            _with4.AddLine(Width - 35, 26, Width - 19, 26);
    //            _with4.AddLine(Width - 19, 26, Width - 27, 36);
    //            _with4.CloseFigure();
    //        }

    //        Invalidate();
    //        base.OnResize(e);
    //    }

    //    protected override void BaWGUI_PaintHook(PaintEventArgs e)
    //    {
    //        var _with5 = e.Graphics;
    //        _with5.SmoothingMode = SmoothingMode.HighQuality;

    //        _with5.FillPath(SideGB, Side);
    //        _with5.DrawPath(BaWGUI_P1, Side);

    //        _with5.FillPath(ButtonGB, Button);
    //        _with5.DrawPath(BaWGUI_P2, Button);

    //        _with5.FillPath(BaWGUI_B1, Arrow1);
    //        _with5.FillPath(BaWGUI_B1, Arrow2);

    //        _with5.DrawString(Text, Font, BaWGUI_B2, BaWGUI_R1, BaWGUI_CSF);

    //        base.BaWGUI_PaintHook(e);
    //    }

    //    private void DrawItm(object sender, DrawItemEventArgs e)
    //    {
    //        if (e.Index < 0)
    //            return;

    //        e.DrawBackground();

    //        LinearGradientBrush NormalGB = new LinearGradientBrush(e.Bounds, Color.FromArgb(251, 251, 251), Color.FromArgb(237, 237, 237), 90);
    //        LinearGradientBrush OverGB = new LinearGradientBrush(e.Bounds, Color.FromArgb(155, 200, 240), Color.FromArgb(75, 144, 225), 90);


    //        var _with6 = e.Graphics;
    //        _with6.SmoothingMode = SmoothingMode.HighQuality;

    //        if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
    //        {
    //            _with6.FillRectangle(OverGB, e.Bounds);
    //            _with6.DrawLine(BaWGUI_P3, e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Y);
    //            _with6.DrawLine(P4, e.Bounds.X, e.Bounds.Y + 38, e.Bounds.Width - 1, e.Bounds.Y + 38);

    //            _with6.DrawString(Text, Font, Brushes.DarkSlateGray, new Rectangle(e.Bounds.X + 12, e.Bounds.Y + 1, e.Bounds.Width, e.Bounds.Height), BaWGUI_CSF);
    //            _with6.DrawString(Text, Font, BaWGUI_B3, new Rectangle(e.Bounds.X + 12, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), BaWGUI_CSF);
    //        }
    //        else
    //        {
    //            _with6.FillRectangle(NormalGB, e.Bounds);
    //            _with6.DrawLine(BaWGUI_P1, e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Y);

    //            _with6.DrawString(base.GetItemText(base.Items[e.Index]), Font, BaWGUI_B2, new Rectangle(e.Bounds.X + 12, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), BaWGUI_CSF);
    //        }
    //    }
    //}

    //public class BaWGUIProgressBar : Control
    //{
    //    #region " Declarations "
    //    private GraphicsPath OPath;
    //    private GraphicsPath IPath;
    //    private GraphicsPath Indicator;
    //    private int FillValue;
    //    private LinearGradientBrush OGB;
    //    private LinearGradientBrush IGB;
    //    private LinearGradientBrush IOGB;
    //    private LinearGradientBrush IndicatorGB;
    //    private Pen BaWGUI_P1;
    //    private Pen BaWGUI_P2;
    //    private Pen BaWGUI_P3;
    //    private SolidBrush BaWGUI_B1;

    //    private TextureBrush TB = new TextureBrush(Image.FromStream(new System.IO.MemoryStream(Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAABQAAAAUCAYAAACNiR0NAAACUElEQVQYGa3BwY1dVRBF0X2q6mExtWDgAQEQIDmRDzn0wBISYtL9771Vx/81CBNAr6Xffv9jbEAC8WRukrh5jBBgbiED5mYbSZjAFrf6/PlnelrDPyRhm5swIQMmUoREBk/GNjdJgBiER9QvX35in8E2Bsx30lDRRIiqoFJkBhFgG9uAwMEguqG+/vkX3WZsbgYskEQGXAlVyVVBVZApxCDANm2YgbPNOkN9/fuBARMYc5NERHBl8qmSa4pyED1IwzsZD3QPezVrN2dD8MFqzYVsJJ4aMaChqvgUw4/xRqoIJ27hEIOw4fSwz7B2s07TberNCTPIjQJSSWXRmXQFO0wTyMkgGDEjdg/7HHbD2uYcmDF1zmA30ASgK1AlUQWZWMHhyWIQbnHarDZ7iXXE2qJHYFGeg+YA5gpxKbhkYoaQcAxjwMKIGbHW4W1t9m5OmxnAxojgg1WvB4GpK0iJSpGCwPQsZgYIPGIs9mleXw9vj81pA8IGI5CoZbgqqUx0JY6iBWNjGww2jM3eh7Wa18dm78YWtgAB5laugAy4iongYGyBjQfaQfewT/NYzVrN3mYc2DwFQtwkU0FTAakBNzR0G9kMwZ7g7Obx2KxHs1bTBpRgnpqbAiJE8MHqh7hIBTHAiOHJ4BmOmz2wVvN4O+zddPMkYLB5FyEyxBWi3laxG0oCjLiJGTg9PPZh78M+5rTBAoTNO8nIphS0Tb28vBASGAKDzM0ztGEkZoYZY/Mv8Z25RYgMqF+/FE8WAyOk4D8ShLANBO8k/s9usAEDwzcn97xOZ2JTrwAAAABJRU5ErkJggg=="))), WrapMode.Tile);
    //    private int _Value = 0;
    //    #endregion
    //    private int _Maximum = 100;

    //    #region " Properties "
    //    [Category("Control")]
    //    public int Maximum
    //    {
    //        get { return _Maximum; }
    //        set
    //        {
    //            if (value < _Value)
    //                _Value = value;
    //            _Maximum = value;
    //            FillValue = Convert.ToInt32((_Value / _Maximum) * (Width - 50));
    //            ChangePaths();
    //            Invalidate();
    //        }
    //    }

    //    [Category("Control")]
    //    public int Value
    //    {
    //        get
    //        {
    //            switch (_Value)
    //            {
    //                case 0:
    //                    return 0;
    //                    FillValue = Convert.ToInt32((_Value / _Maximum) * (Width - 50));
    //                    ChangePaths();
    //                    Invalidate();
    //                    break;
    //                default:
    //                    return _Value;
    //                    FillValue = Convert.ToInt32((_Value / _Maximum) * (Width - 50));
    //                    ChangePaths();
    //                    Invalidate();
    //                    break;
    //            }
    //        }
    //        set
    //        {
    //            if (value > _Maximum)
    //                value = _Maximum;
    //            _Value = value;
    //            FillValue = Convert.ToInt32((_Value / _Maximum) * (Width - 50));
    //            ChangePaths();
    //            Invalidate();
    //        }
    //    }
    //    #endregion

    //    public BaWGUIProgressBar()
    //    {
    //        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);

    //        BackColor = Color.Transparent;
    //        DoubleBuffered = true;
    //        Font = new Font("Arial", 16);
    //        MinimumSize = new Size(60, 80);

    //        TB.TranslateTransform(0, -5, MatrixOrder.Prepend);

    //        BaWGUI_P3 = new Pen(Color.FromArgb(190, 190, 190));
    //        BaWGUI_B1 = new SolidBrush(Color.FromArgb(84, 83, 81));
    //    }

    //    protected override void OnResize(EventArgs e)
    //    {
    //        FillValue = Convert.ToInt32((_Value / _Maximum) * (Width - 50));

    //        OPath = new GraphicsPath();

    //        var _with1 = OPath;
    //        _with1.AddArc(14, Height - 31, 20, 20, 180, 90);
    //        _with1.AddArc(Width - 44, Height - 31, 20, 20, -90, 90);
    //        _with1.AddArc(Width - 44, Height - 21, 20, 20, 0, 90);
    //        _with1.AddArc(14, Height - 21, 20, 20, 90, 90);
    //        _with1.CloseAllFigures();
    //        ChangePaths();

    //        Height = 80;

    //        Invalidate();
    //        base.OnResize(e);
    //    }

    //    protected override void BaWGUI_PaintHook(PaintEventArgs e)
    //    {
    //        var _with2 = e.Graphics;
    //        _with2.SmoothingMode = SmoothingMode.HighQuality;

    //        switch (_Value)
    //        {
    //            case 0:
    //                _with2.FillPath(IGB, OPath);
    //                _with2.DrawPath(BaWGUI_P1, OPath);
    //                break;
    //            default:
    //                _with2.FillPath(IGB, OPath);
    //                _with2.DrawPath(BaWGUI_P1, OPath);
    //                _with2.FillPath(TB, IPath);
    //                _with2.DrawPath(BaWGUI_P2, IPath);

    //                _with2.FillPath(IndicatorGB, Indicator);
    //                _with2.DrawPath(BaWGUI_P3, Indicator);

    //                switch (_Value)
    //                {
    //                    case  // ERROR: Case labels with binary operators are unsupported : LessThan
    //10:
    //                        _with2.DrawString(_Value + "%", Font, BaWGUI_B1, FillValue + 6, 7);
    //                        break;
    //                    case  // ERROR: Case labels with binary operators are unsupported : LessThan
    //100:
    //                        _with2.DrawString(_Value + "%", Font, BaWGUI_B1, FillValue - 5, 7);
    //                        break;
    //                    default:
    //                        _with2.DrawString(_Value + "%", Font, BaWGUI_B1, FillValue - 11, 7);
    //                        break;
    //                }
    //                break;
    //        }

    //        base.BaWGUI_PaintHook(e);
    //    }

    //    private void ChangePaths()
    //    {
    //        if (Width > 0 && Height > 0)
    //        {
    //            IPath = new GraphicsPath();
    //            Indicator = new GraphicsPath();

    //            OGB = new LinearGradientBrush(new Rectangle(Width - 44, Height - 31, 31, 31), Color.FromArgb(173, 173, 173), Color.FromArgb(195, 195, 195), 90);
    //            IGB = new LinearGradientBrush(new Rectangle(Width - 43, Height - 30, 30, 30), Color.FromArgb(201, 201, 201), Color.FromArgb(225, 225, 225), 90);
    //            IOGB = new LinearGradientBrush(new Rectangle(19, Height - 26, Width - 6, Height - 26), Color.FromArgb(125, 175, 225), Color.FromArgb(55, 130, 205), -90);
    //            IndicatorGB = new LinearGradientBrush(new Rectangle(FillValue - 11, 0, FillValue + 19, 45), Color.FromArgb(232, 232, 232), Color.FromArgb(202, 202, 202), 90);

    //            BaWGUI_P1 = new Pen(OGB);
    //            BaWGUI_P2 = new Pen(IOGB);


    //            if (FillValue >= 13)
    //            {
    //                var _with3 = IPath;
    //                _with3.AddArc(19, Height - 26, 20, 20, 180, 90);
    //                _with3.AddArc(FillValue, Height - 26, 20, 20, -90, 90);
    //                _with3.AddArc(FillValue, Height - 26, 20, 20, 0, 90);
    //                _with3.AddArc(19, Height - 26, 20, 20, 90, 90);
    //            }
    //            var _with4 = Indicator;
    //            _with4.AddArc(FillValue - 11, 0, 8, 8, 180, 90);
    //            _with4.AddArc(FillValue + 40, 0, 8, 8, -90, 90);
    //            _with4.AddArc(FillValue + 40, 27, 8, 8, 0, 90);
    //            _with4.AddLine(FillValue + 24, 35, FillValue + 19, 45);
    //            _with4.AddLine(FillValue + 14, 35, FillValue - 3, 35);
    //            _with4.AddArc(FillValue - 11, 27, 8, 8, 90, 90);
    //            _with4.CloseFigure();
    //        }
    //    }

    //    public void Increment(int Amount)
    //    {
    //        Value += Amount;
    //    }
    //}

    //[DefaultEvent("CheckedChanged")]
    //public class BaWGUIRadioButton : Control
    //{
    //    #region " Declarations "
    //    private LinearGradientBrush GB;
    //    private Rectangle BaWGUI_R1;
    //    private Pen BaWGUI_P1;
    //    private SolidBrush BaWGUI_B1;
    //    private SolidBrush BaWGUI_B2;

    //    private StringFormat BaWGUI_CSF = new StringFormat { LineAlignment = StringAlignment.Center };
    //    public event CheckedChangedEventHandler CheckedChanged;
    //    public delegate void CheckedChangedEventHandler(object sender);

    //    private bool _Checked;
    //    #endregion
    //    private int _Group = 1;

    //    #region " Properties "
    //    [Category("Appearance")]
    //    public bool Checked
    //    {
    //        get { return _Checked; }
    //        set
    //        {
    //            _Checked = value;
    //            InvalidateControls();
    //            if (CheckedChanged != null)
    //            {
    //                CheckedChanged(this);
    //            }
    //            Invalidate();
    //        }
    //    }

    //    [Category("Custom")]
    //    public int Group
    //    {
    //        get { return _Group; }
    //        set { _Group = value; }
    //    }
    //    #endregion
    //    public BaWGUIRadioButton()
    //    {
    //        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);

    //        BackColor = Color.Transparent;
    //        DoubleBuffered = true;
    //        Font = new Font("Arial", 12);
    //        Size = new Size(200, 26);

    //        BaWGUI_P1 = new Pen(Color.FromArgb(160, 160, 160));
    //        BaWGUI_B1 = new SolidBrush(Color.FromArgb(114, 114, 114));
    //        BaWGUI_B2 = new SolidBrush(Color.FromArgb(95, 165, 230));
    //    }

    //    private void InvalidateControls()
    //    {
    //        if (!IsHandleCreated || !_Checked)
    //            return;

    //        foreach (Control C in Parent.Controls)
    //        {
    //            if (!object.ReferenceEquals(C, this) && C is BaWGUIRadioButton && ((BaWGUIRadioButton)C).Group == _Group)
    //            {
    //                ((BaWGUIRadioButton)C).Checked = false;
    //            }
    //        }
    //    }

    //    protected override void OnClick(EventArgs e)
    //    {
    //        if (!_Checked)
    //            Checked = true;
    //        base.OnClick(e);
    //    }

    //    protected override void OnCreateControl()
    //    {
    //        InvalidateControls();
    //        base.OnCreateControl();
    //    }

    //    protected override void OnTextChanged(System.EventArgs e)
    //    {
    //        Invalidate();
    //        base.OnTextChanged(e);
    //    }

    //    protected override void OnResize(System.EventArgs e)
    //    {
    //        Height = 26;

    //        BaWGUI_R1 = new Rectangle(30, 0, Width, Height);

    //        GB = new LinearGradientBrush(new Rectangle(0, 0, 25, 25), Color.FromArgb(244, 245, 244), Color.FromArgb(227, 227, 227), 90);

    //        Invalidate();
    //        base.OnResize(e);
    //    }

    //    protected override void BaWGUI_PaintHook(PaintEventArgs e)
    //    {
    //        var _with1 = e.Graphics;
    //        _with1.SmoothingMode = SmoothingMode.HighQuality;

    //        _with1.FillEllipse(GB, 0, 0, 25, 25);
    //        _with1.DrawEllipse(BaWGUI_P1, 0, 0, 24, 24);

    //        _with1.DrawString(Text, Font, BaWGUI_B1, BaWGUI_R1, BaWGUI_CSF);

    //        if (Checked)
    //        {
    //            _with1.FillEllipse(BaWGUI_B2, 8, 8, 8, 8);
    //        }

    //        base.BaWGUI_PaintHook(e);
    //    }
    //}

    //[DefaultEvent("TextChanged")]
    //public class BaWGUITextBox : Control
    //{
    //    #region " Declarations "
    //    private GraphicsPath Side;
    //    private GraphicsPath Button;
    //    private LinearGradientBrush ButtonOGB;
    //    private LinearGradientBrush ButtonGB;
    //    private Pen BaWGUI_P1;
    //    private Pen BaWGUI_P2;

    //    private SolidBrush BaWGUI_B1;
    //    private TextBox withEventsField_TBox;
    //    private TextBox TBox
    //    {
    //        get { return withEventsField_TBox; }
    //        set
    //        {
    //            if (withEventsField_TBox != null)
    //            {
    //                withEventsField_TBox.KeyDown -= OnBaseKeyDown;
    //                withEventsField_TBox.TextChanged -= OnBaseTextChanged;
    //            }
    //            withEventsField_TBox = value;
    //            if (withEventsField_TBox != null)
    //            {
    //                withEventsField_TBox.KeyDown += OnBaseKeyDown;
    //                withEventsField_TBox.TextChanged += OnBaseTextChanged;
    //            }
    //        }

    //    }
    //    private int _MaxLength = 32767;
    //    private bool _ReadOnly;
    //    private bool _UseSystemPasswordChar;
    //    private bool _Multiline;
    //    #endregion
    //    private Image _Image;

    //    #region " Properties "
    //    [Category("Options")]
    //    public override Font Font
    //    {
    //        get { return base.Font; }
    //        set
    //        {
    //            base.Font = value;
    //            if (TBox != null)
    //            {
    //                TBox.Font = value;
    //                TBox.Location = new Point(3, 5);
    //                TBox.Width = Width - 6;

    //                if (!_Multiline)
    //                {
    //                    Height = TBox.Height + 11;
    //                }
    //            }
    //        }
    //    }

    //    [Category("Appearance")]
    //    public Image Image
    //    {
    //        get { return _Image; }
    //        set { _Image = value; }
    //    }

    //    [Category("Options")]
    //    public int MaxLength
    //    {
    //        get { return _MaxLength; }
    //        set
    //        {
    //            _MaxLength = value;
    //            if (TBox != null)
    //            {
    //                TBox.MaxLength = value;
    //            }
    //        }
    //    }

    //    [Category("Options")]
    //    public bool Multiline
    //    {
    //        get { return _Multiline; }
    //        set
    //        {
    //            _Multiline = value;
    //            if (TBox != null)
    //            {
    //                TBox.Multiline = value;

    //                if (value)
    //                {
    //                    TBox.Height = Height - 11;
    //                }
    //                else
    //                {
    //                    Height = TBox.Height + 11;
    //                }

    //            }
    //        }
    //    }

    //    [Category("Options")]
    //    public bool ReadOnly
    //    {
    //        get { return _ReadOnly; }
    //        set
    //        {
    //            _ReadOnly = value;
    //            if (TBox != null)
    //            {
    //                TBox.ReadOnly = value;
    //            }
    //        }
    //    }

    //    [Category("Options")]
    //    public override string Text
    //    {
    //        get { return base.Text; }
    //        set
    //        {
    //            base.Text = value;
    //            if (TBox != null)
    //            {
    //                TBox.Text = value;
    //            }
    //        }
    //    }

    //    [Category("Options")]
    //    public bool UseSystemPasswordChar
    //    {
    //        get { return _UseSystemPasswordChar; }
    //        set
    //        {
    //            _UseSystemPasswordChar = value;
    //            if (TBox != null)
    //            {
    //                TBox.UseSystemPasswordChar = value;
    //            }
    //        }
    //    }
    //    #endregion

    //    public BaWGUITextBox()
    //    {
    //        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);

    //        BackColor = Color.Transparent;
    //        DoubleBuffered = true;
    //        Font = new Font("Arial", 16);
    //        Size = new Size(125, 53);

    //        TBox = new TextBox();
    //        var _with1 = TBox;
    //        _with1.BackColor = Color.FromArgb(245, 245, 245);
    //        _with1.BorderStyle = BorderStyle.None;
    //        _with1.Cursor = Cursors.IBeam;
    //        _with1.Font = Font;
    //        _with1.ForeColor = Color.FromArgb(185, 185, 185);
    //        _with1.Height = Height - 11;
    //        _with1.Location = new Point(5, 5);
    //        _with1.MaxLength = _MaxLength;
    //        _with1.Multiline = _Multiline;
    //        _with1.ReadOnly = _ReadOnly;
    //        _with1.Text = Text;
    //        _with1.UseSystemPasswordChar = _UseSystemPasswordChar;
    //        _with1.Width = Width - 10;

    //        BaWGUI_P1 = new Pen(Color.FromArgb(180, 180, 180));
    //        BaWGUI_B1 = new SolidBrush(Color.FromArgb(245, 245, 245));
    //    }

    //    private void OnBaseKeyDown(object s, KeyEventArgs e)
    //    {
    //        if (e.Control && e.KeyCode == Keys.A)
    //        {
    //            TBox.SelectAll();
    //            e.SuppressKeyPress = true;
    //        }
    //        if (e.Control && e.KeyCode == Keys.C)
    //        {
    //            TBox.Copy();
    //            e.SuppressKeyPress = true;
    //        }
    //    }

    //    private void OnBaseTextChanged(object s, EventArgs e)
    //    {
    //        Text = TBox.Text;
    //    }

    //    protected override void OnCreateControl()
    //    {
    //        base.OnCreateControl();
    //        if (!Controls.Contains(TBox))
    //        {
    //            Controls.Add(TBox);
    //        }
    //    }

    //    protected override void OnResize(EventArgs e)
    //    {
    //        if (Width > 0 && Height > 0)
    //        {
    //            if (Controls.Contains(TBox) && !_Multiline && _Image != null)
    //            {
    //                TBox.Location = new Point(20, 14);
    //                TBox.Width = Width - 81;
    //                Height = 53;
    //            }
    //            else if (Controls.Contains(TBox) && _Multiline)
    //            {
    //                TBox.Location = new Point(5, 5);
    //                TBox.Width = Width - 10;
    //                TBox.Height = Height - 11;
    //            }
    //            else if (Controls.Contains(TBox) && !_Multiline)
    //            {
    //                TBox.Location = new Point(5, 5);
    //                TBox.Width = Width - 10;
    //                TBox.Height = Height - 11;
    //                Height = 53;
    //            }


    //            Side = new GraphicsPath();
    //            Button = new GraphicsPath();

    //            ButtonOGB = new LinearGradientBrush(new Rectangle(Width - 51, 0, Width, Height), Color.FromArgb(125, 180, 235), Color.FromArgb(45, 125, 200), 90);
    //            ButtonGB = new LinearGradientBrush(new Rectangle(Width - 50, 0, Width, Height), Color.FromArgb(175, 215, 240), Color.FromArgb(70, 145, 215), 90);

    //            BaWGUI_P2 = new Pen(ButtonOGB);

    //            var _with2 = Side;
    //            _with2.AddArc(0, 0, 10, 10, 180, 90);
    //            _with2.AddArc(Width - 11, 0, 10, 10, -90, 90);
    //            _with2.AddArc(Width - 11, Height - 11, 10, 10, 0, 90);
    //            _with2.AddArc(0, Height - 11, 10, 10, 90, 90);
    //            _with2.CloseFigure();
    //            var _with3 = Button;
    //            _with3.AddLine(Width - 51, Height - 1, Width - 51, 0);
    //            _with3.AddArc(Width - 11, 0, 10, 10, -90, 90);
    //            _with3.AddArc(Width - 11, Height - 11, 10, 10, 0, 90);
    //            _with3.CloseFigure();
    //        }

    //        Invalidate();
    //        base.OnResize(e);
    //    }

    //    protected override void BaWGUI_PaintHook(PaintEventArgs e)
    //    {
    //        var _with4 = e.Graphics;
    //        _with4.SmoothingMode = SmoothingMode.HighQuality;

    //        _with4.FillPath(BaWGUI_B1, Side);
    //        _with4.DrawPath(BaWGUI_P1, Side);

    //        if (!_Multiline && _Image != null)
    //        {
    //            _with4.FillPath(ButtonGB, Button);
    //            _with4.DrawPath(BaWGUI_P2, Button);

    //            _with4.DrawImage(_Image, Width - 42, 11, 32, 32);
    //        }

    //        base.BaWGUI_PaintHook(e);
    //    }
    //} 
    #endregion

    public partial class Thematic150WithEditor
    {

        #region " Declarations "
        private bool BaWGUI_OverCls;
        private bool BaWGUI_overMax;
        private bool BaWGUI_overMin;
        private Font BaWGUI_XF;
        private Font BaWGUI_PF;
        private Font BaWGUI_MF;
        private GraphicsPath BaWGUI_base;
        private GraphicsPath BaWGUI_header;
        private LinearGradientBrush BaWGUI_baseGB;
        private LinearGradientBrush BaWGUI_headerGB;
        private LinearGradientBrush BaWGUI_headerOutlineGB;
        private LinearGradientBrush BaWGUI_buttonOuterGB;
        private LinearGradientBrush BaWGUI_buttonInnerGB;
        private LinearGradientBrush BaWGUI_buttonOInnerGB;
        private Rectangle BaWGUI_R1;
        private Rectangle BaWGUI_R2;
        private Pen BaWGUI_P1;
        private Pen BaWGUI_P2;
        private Pen BaWGUI_P3;
        private SolidBrush BaWGUI_B1;
        private SolidBrush BaWGUI_B2;
        private SolidBrush BaWGUI_B3;

        private StringFormat BaWGUI_CSF = new StringFormat { Alignment = StringAlignment.Center };
        #endregion

        private bool BaWGUI_drawButtonStrings = true;

        #region " Properties "
        [Category("Drawing")]
        public bool BaWGUI_DrawButtonStrings
        {
            get { return BaWGUI_drawButtonStrings; }
            set { BaWGUI_drawButtonStrings = value; }
        }
        #endregion

        public void BaWGUIThemeContainer()
        {

            //SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);

            //BackColor = Color.White;
            //Dock = DockStyle.Fill;
            //DoubleBuffered = true;
            //Font = new Font("Arial", 12, FontStyle.Bold);


            BaWGUI_XF = new Font("Tahoma", 12);
            BaWGUI_PF = new Font("Arial", 16);
            BaWGUI_MF = new Font("Arial", 20);

            BaWGUI_P1 = new Pen(Color.FromArgb(128, 128, 128));
            // BaWGUI_P2 is in the BaWGUI_OnSizeChanged event.
            BaWGUI_P3 = new Pen(Color.FromArgb(180, 217, 246));
            BaWGUI_B1 = new SolidBrush(Color.FromArgb(58, 118, 181));
            BaWGUI_B2 = new SolidBrush(Color.FromArgb(71, 132, 191));
            BaWGUI_B3 = new SolidBrush(Color.FromArgb(128, 0, 0, 0));
        }

        private void BaWGUI_CreateHandle()
        {
            Parent.FindForm().FormBorderStyle = FormBorderStyle.None;
            if (Parent.FindForm().TransparencyKey == null)
                Parent.FindForm().TransparencyKey = Color.Fuchsia;

            //base.BaWGUI_CreateHandle();
        }

        private void BaWGUI_OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BaWGUI_overMin)
                {
                    Parent.FindForm().WindowState = FormWindowState.Minimized;
                }
                else if (BaWGUI_overMax)
                {
                    if (Parent.FindForm().WindowState == FormWindowState.Maximized)
                        Parent.FindForm().WindowState = FormWindowState.Normal;
                    else
                        Parent.FindForm().WindowState = FormWindowState.Maximized;
                }
                else if (BaWGUI_OverCls)
                {
                    Parent.FindForm().Close();
                }
                else
                {
                    if (new Rectangle(Parent.FindForm().Location.X, Parent.FindForm().Location.Y, Width, 50).IntersectsWith(new Rectangle(MousePosition.X, MousePosition.Y, 1, 1)) && !(Parent.FindForm().WindowState == FormWindowState.Maximized))
                    {
                        Capture = false;
                        Message M = Message.Create(Parent.FindForm().Handle, 161, new IntPtr(2), IntPtr.Zero);
                        DefWndProc(ref M);
                    }
                }
            }

            //base.BaWGUI_OnMouseDown(e);
        }

        private void BaWGUI_OnMouseMove(MouseEventArgs e)
        {
            if (e.Location.X >= 33 && e.Location.Y >= 19 && e.Location.X <= 120 && e.Location.Y <= 37)
            {
                if (e.Location.X >= 33 && e.Location.X <= 51)
                {
                    BaWGUI_OverCls = true;
                    Invalidate();
                }
                else
                {
                    BaWGUI_OverCls = false;
                    Invalidate();
                }

                if (e.Location.X >= 104)
                {
                    BaWGUI_overMax = true;
                    Invalidate();
                }
                else
                {
                    BaWGUI_overMax = false;
                    Invalidate();
                }

                if (e.Location.X >= 68 && e.Location.X <= 86)
                {
                    BaWGUI_overMin = true;
                    Invalidate();
                }
                else
                {
                    BaWGUI_overMin = false;
                    Invalidate();
                }
            }
            else
            {
                BaWGUI_overMin = false;
                BaWGUI_overMax = false;
                BaWGUI_OverCls = false;
                Invalidate();
            }

            //base.BaWGUI_OnMouseMove(e);
        }

        protected override void OnTextChanged(System.EventArgs e)
        {
            Invalidate();
            base.OnTextChanged(e);
        }

        private void BaWGUI_OnSizeChanged(/*System.EventArgs e*/)
        {
            if (Width > 0 && Height > 0)
            {
                BaWGUI_base = new GraphicsPath();
                BaWGUI_header = new GraphicsPath();

                BaWGUI_R1 = new Rectangle(-1, Convert.ToInt32((50 - Font.Size) / 2 - 1), Width, Height);
                BaWGUI_R2 = new Rectangle(0, Convert.ToInt32((50 - Font.Size) / 2 - 2), Width, Height);

                BaWGUI_baseGB = new LinearGradientBrush(new Rectangle(0, 50, Width, Height), Color.FromArgb(236, 236, 236), Color.FromArgb(232, 232, 232), 90);
                BaWGUI_headerGB = new LinearGradientBrush(new Rectangle(0, 0, Width, 50), Color.FromArgb(161, 207, 243), Color.FromArgb(80, 152, 222), 90);
                BaWGUI_headerOutlineGB = new LinearGradientBrush(new Rectangle(0, 0, Width, 50), Color.FromArgb(102, 167, 227), Color.FromArgb(52, 130, 202), -90);
                BaWGUI_buttonOuterGB = new LinearGradientBrush(new Rectangle(0, 15, 25, 25), Color.FromArgb(89, 158, 228), Color.FromArgb(150, 202, 241), 90);
                BaWGUI_buttonInnerGB = new LinearGradientBrush(new Rectangle(0, 20, 16, 16), Color.FromArgb(185, 211, 239), Color.FromArgb(145, 191, 238), 90);
                BaWGUI_buttonOInnerGB = new LinearGradientBrush(new Rectangle(0, 22, 16, 16), Color.FromArgb(94, 163, 215), Color.FromArgb(13, 67, 141), 90);

                BaWGUI_P2 = new Pen(BaWGUI_headerOutlineGB);


                var _with1 = BaWGUI_base;
                _with1.AddLine(Width - 1, 50, Width - 1, Height - 11);
                _with1.AddArc(Width - 11, Height - 11, 10, 10, 0, 90);
                _with1.AddArc(0, Height - 11, 10, 10, 90, 90);
                _with1.AddLine(0, Height - 11, 0, 50);

                var _with2 = BaWGUI_header;
                _with2.AddArc(0, 0, 10, 10, 180, 90);
                _with2.AddArc(Width - 11, 0, 10, 10, -90, 90);
                _with2.AddLine(Width - 1, 50, 0, 50);
                _with2.AddLine(0, 50, 0, 5);
                Invalidate();
            }

            Invalidate();
            //base.BaWGUI_OnSizeChanged(e);
        }

        private void BaWGUI_PaintHook(PaintEventArgs e)
        {
            Graphics _with3 = e.Graphics;
            _with3.SmoothingMode = SmoothingMode.HighQuality;
            _with3.Clear(Parent.FindForm().TransparencyKey);

            BaWGUI_base = new GraphicsPath();
            BaWGUI_header = new GraphicsPath();

            BaWGUI_R1 = new Rectangle(-1, Convert.ToInt32((50 - Font.Size) / 2 - 1), Width, Height);
            BaWGUI_R2 = new Rectangle(0, Convert.ToInt32((50 - Font.Size) / 2 - 2), Width, Height);

            BaWGUI_baseGB = new LinearGradientBrush(new Rectangle(0, 50, Width, Height), Color.FromArgb(236, 236, 236), Color.FromArgb(232, 232, 232), 90);
            BaWGUI_headerGB = new LinearGradientBrush(new Rectangle(0, 0, Width, 50), Color.FromArgb(161, 207, 243), Color.FromArgb(80, 152, 222), 90);
            BaWGUI_headerOutlineGB = new LinearGradientBrush(new Rectangle(0, 0, Width, 50), Color.FromArgb(102, 167, 227), Color.FromArgb(52, 130, 202), -90);
            BaWGUI_buttonOuterGB = new LinearGradientBrush(new Rectangle(0, 15, 25, 25), Color.FromArgb(89, 158, 228), Color.FromArgb(150, 202, 241), 90);
            BaWGUI_buttonInnerGB = new LinearGradientBrush(new Rectangle(0, 20, 16, 16), Color.FromArgb(185, 211, 239), Color.FromArgb(145, 191, 238), 90);
            BaWGUI_buttonOInnerGB = new LinearGradientBrush(new Rectangle(0, 22, 16, 16), Color.FromArgb(94, 163, 215), Color.FromArgb(13, 67, 141), 90);

            BaWGUI_P2 = new Pen(BaWGUI_headerOutlineGB);

            // BaWGUI_base & BaWGUI_header
            _with3.FillPath(BaWGUI_baseGB, BaWGUI_base);
            _with3.DrawPath(BaWGUI_P1, BaWGUI_base);

            _with3.FillPath(BaWGUI_headerGB, BaWGUI_header);
            _with3.DrawPath(BaWGUI_P2, BaWGUI_header);
            _with3.DrawLine(BaWGUI_P3, 4, 1, Width - 5, 1);
            // Little header shine


            // Buttons
            if (BaWGUI_OverCls)
            {
                _with3.FillEllipse(BaWGUI_buttonOuterGB, 30, 15, 25, 25);
                _with3.FillEllipse(BaWGUI_B1, 33, 19, 18, 18);
                _with3.FillEllipse(BaWGUI_buttonOInnerGB, 34, 21, 16, 16);
                if (BaWGUI_drawButtonStrings)
                    _with3.DrawString("x", BaWGUI_XF, BaWGUI_B3, 36, 17);
            }
            else
            {
                _with3.FillEllipse(BaWGUI_buttonOuterGB, 30, 15, 25, 25);
                _with3.FillEllipse(BaWGUI_B2, 33, 19, 18, 18);
                _with3.FillEllipse(BaWGUI_buttonInnerGB, 34, 19, 16, 16);
            }

            if (BaWGUI_overMax)
            {
                _with3.FillEllipse(BaWGUI_buttonOuterGB, 100, 15, 25, 25);
                _with3.FillEllipse(BaWGUI_B1, 103, 19, 18, 18);
                _with3.FillEllipse(BaWGUI_buttonOInnerGB, 104, 21, 16, 16);
                if (BaWGUI_drawButtonStrings)
                    _with3.DrawString("+", BaWGUI_PF, BaWGUI_B3, 102, 17);
            }
            else
            {
                _with3.FillEllipse(BaWGUI_buttonOuterGB, 100, 15, 25, 25);
                _with3.FillEllipse(BaWGUI_B2, 103, 19, 18, 18);
                _with3.FillEllipse(BaWGUI_buttonInnerGB, 104, 19, 16, 16);
            }

            if (BaWGUI_overMin)
            {
                _with3.FillEllipse(BaWGUI_buttonOuterGB, 65, 15, 25, 25);
                _with3.FillEllipse(BaWGUI_B1, 68, 19, 18, 18);
                _with3.FillEllipse(BaWGUI_buttonOInnerGB, 69, 21, 16, 16);
                if (BaWGUI_drawButtonStrings)
                    _with3.DrawString("-", BaWGUI_MF, BaWGUI_B3, 69, 10);
            }
            else
            {
                _with3.FillEllipse(BaWGUI_buttonOuterGB, 65, 15, 25, 25);
                _with3.FillEllipse(BaWGUI_B2, 68, 19, 18, 18);
                _with3.FillEllipse(BaWGUI_buttonInnerGB, 69, 19, 16, 16);
            }


            _with3.DrawString(Text, Font, Brushes.DarkSlateGray, BaWGUI_R1, BaWGUI_CSF);
            _with3.DrawString(Text, Font, Brushes.WhiteSmoke, BaWGUI_R2, BaWGUI_CSF);

            //base.BaWGUI_PaintHook(e);
        }





    }


    

}


