// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Resizable.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 147. Resizable

        #region Private Fields
        private int cGrip = 10;      // Grip size
        private int cCaption = 32;   // Caption bar height;
        private int borderWidth = 1;

        private Color header = Color.Transparent;
        private Color borderColor = Color.Red;

        private Color backgroundColor1 = Color.DarkSeaGreen;
        private Color backgroundColor = Color.Orange;


        private bool defaultShadow = true;

        private bool shadow = false;
        private int interval = 100;

        #region Include in Private Field (Color Blend)
        private float[] blendPositions = new float[11];

        private Color[] colorBlends = new Color[11];

        private bool gammaCorrection = false;

        private WrapMode wrapMode = WrapMode.Clamp;

        private bool enableColorBlend = false;

        private float angle = 90f;

        private float blendRotate = 0f;

        private DashStyle handleDrawDashStyle = DashStyle.Dot;

        private int handleBorderWidth = 1;

        private Color handleColorBorder = Color.Black;

        public enum drawMode { Solid, Gradient, Hatch }

        private drawMode _drawMode = drawMode.Solid;


        #endregion

        #endregion

        #region Include in Private Field


        private bool autoAnimate = false;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        #endregion

        #region Include in Public Properties

        [Category("Resizable Theme")]
        public bool AutoAnimate
        {
            get { return autoAnimate; }
            set
            {
                autoAnimate = value;

                if (value == true)
                {
                    timer.Enabled = true;
                }

                else
                {
                    timer.Enabled = false;
                }

                Invalidate();
            }
        }

        #endregion

        #region Public Properties

        #region Include in Public Properties (Color Blend)

        [Category("Resizable Theme")]
        public float Angle
        {
            get { return angle; }
            set
            {
                angle = value;
                Invalidate();
            }
        }

        [Category("Resizable Theme")]
        public bool EnableColorBlend
        {
            get { return enableColorBlend; }
            set
            {
                enableColorBlend = value;
                Invalidate();
            }
        }

        [Category("Resizable Theme")]
        public WrapMode WrapMode
        {
            get { return wrapMode; }
            set
            {
                wrapMode = value;
                Invalidate();
            }
        }

        [Category("Resizable Theme")]
        public bool GammaCorrection
        {
            get { return gammaCorrection; }
            set
            {
                gammaCorrection = value;
                Invalidate();
            }
        }

        [Category("Resizable Theme")]
        public Color[] ColorBlends
        {
            get { return colorBlends; }
            set
            {
                colorBlends = value;
                Invalidate();
            }
        }

        [Category("Resizable Theme")]
        public float[] BlendPositions
        {
            get { return blendPositions; }
            set
            {
                for (int x = 1; x <= 10; x++)
                {
                    if (blendPositions[x] > 1.0f)
                    {
                        blendPositions[x] = 1.0f;
                    }
                }

                #region Old Code
                //if (blendPositions[0] > 1.0f)
                //{
                //    blendPositions[0] = 1.0f;
                //    Invalidate();
                //}

                //if (blendPositions[1] > 1.0f)
                //{
                //    blendPositions[1] = 1.0f;
                //    Invalidate();
                //}

                //if (blendPositions[2] > 1.0f)
                //{
                //    blendPositions[2] = 1.0f;
                //    Invalidate();
                //}

                //if (blendPositions[3] > 1.0f)
                //{
                //    blendPositions[3] = 1.0f;
                //    Invalidate();
                //}

                //if (blendPositions[4] > 1.0f)
                //{
                //    blendPositions[4] = 1.0f;
                //    Invalidate();
                //}

                //if (blendPositions[5] > 1.0f)
                //{
                //    blendPositions[5] = 1.0f;
                //    Invalidate();
                //}

                //if (blendPositions[6] > 1.0f)
                //{
                //    blendPositions[6] = 1.0f;
                //    Invalidate();
                //}

                //if (blendPositions[7] > 1.0f)
                //{
                //    blendPositions[7] = 1.0f;
                //    Invalidate();
                //}

                //if (blendPositions[8] > 1.0f)
                //{
                //    blendPositions[8] = 1.0f;
                //    Invalidate();
                //}

                //if (blendPositions[9] > 1.0f)
                //{
                //    blendPositions[9] = 1.0f;
                //    Invalidate();
                //} 
                #endregion

                blendPositions = value;

                Invalidate();
            }
        }

        #endregion


        #region HatchBrush

        private Color hatchBrushgradient1 = Color.Black;
        private Color hatchBrushgradient2 = Color.Transparent;

        private HatchBrushType hatchBrushType = HatchBrushType.ForwardDiagonal;

        public enum HatchBrushType
        {
            BackwardDiagonal,
            Cross,
            DarkDownwardDiagonal,
            DarkHorizontal,
            DarkUpwardDiagonal,
            DarkVertical,
            DashedDownwardDiagonal,
            DashedHorizontal,
            DashedUpwardDiagonal,
            DashedVertical,
            DiagonalBrick,
            DiagonalCross,
            Divot,
            DottedDiamond,
            DottedGrid,
            ForwardDiagonal,
            Horizontal,
            HorizontalBrick,
            LargeCheckerBoard,
            LargeConfetti,
            LargeGrid,
            LightDownwardDiagonal,
            LightHorizontal,
            LightUpwardDiagonal,
            LightVertical,
            Max,
            Min,
            NarrowHorizontal,
            NarrowVertical,
            OutlinedDiamond,
            Percent05,
            Percent10,
            Percent20,
            Percent25,
            Percent30,
            Percent40,
            Percent50,
            Percent60,
            Percent70,
            Percent75,
            Percent80,
            Percent90,
            Plaid,
            Shingle,
            SmallCheckerBoard,
            SmallConfetti,
            SmallGrid,
            SolidDiamond,
            Sphere,
            Trellis,
            Vertical,
            Wave,
            Weave,
            WideDownwardDiagonal,
            WideUpwardDiagonal,
            ZigZag
        }
        #endregion


        #region HatchBrush Property

        [Category("Resizable Theme")]
        public Color ColorHatchBrushgradient1
        {
            get { return hatchBrushgradient1; }
            set
            {
                hatchBrushgradient1 = value;
                Invalidate();
            }
        }

        [Category("Resizable Theme")]
        public Color ColorHatchBrushgradient2
        {
            get { return hatchBrushgradient2; }
            set
            {
                hatchBrushgradient2 = value;
                Invalidate();
            }
        }

        [Category("Resizable Theme")]
        public HatchBrushType HatchBrush
        {
            get
            {
                return hatchBrushType;
            }

            set
            {
                hatchBrushType = value;
                Invalidate();
            }
        }
        #endregion

        [Category("Resizable Theme")]
        public int TimerInterval
        {
            get { return interval; }
            set
            {
                interval = value;
                Invalidate();
            }
        }

        [Category("Resizable Theme")]
        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set
            {
                backgroundColor = value;
                Invalidate();
            }
        }

        [Category("Resizable Theme")]
        public Color BackgroundColor1
        {
            get { return backgroundColor1; }
            set
            {
                backgroundColor1 = value;
                Invalidate();
            }
        }

        [Category("Resizable Theme")]
        public bool DefaultShadow
        {
            get { return defaultShadow; }
            set
            {
                defaultShadow = value;
                Invalidate();
            }
        }

        [Category("Resizable Theme")]
        public bool CustomShadow
        {
            get { return shadow; }
            set
            {
                shadow = value;
                Invalidate();
            }
        }

        [Category("Resizable Theme")]
        public Color GripRegionColor
        {
            get { return header; }
            set
            {
                header = value;
                Invalidate();
            }
        }

        [Category("Resizable Theme")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Category("Resizable Theme")]
        public int BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value;
                Invalidate();
            }
        }

        [Category("Resizable Theme")]
        public int GripSize
        {
            get { return cGrip; }
            set
            {
                cGrip = value;
                Invalidate();
            }
        }

        [Category("Resizable Theme")]
        public int CaptionHeight
        {
            get { return cCaption; }
            set
            {
                cCaption = value;
                Invalidate();
            }
        }

        [Category("Resizable Theme")]
        public DashStyle HandleDrawStyle
        {
            get { return handleDrawDashStyle; }
            set
            {
                handleDrawDashStyle = value;
                Invalidate();
            }
        }

        [Category("Resizable Theme")]
        public int HandleBorderWidth
        {
            get { return handleBorderWidth; }
            set
            {
                handleBorderWidth = value;
                Invalidate();
            }
        }

        [Category("Resizable Theme")]
        public Color HandleColorBorder
        {
            get
            {
                return handleColorBorder;
            }

            set
            {
                handleColorBorder = value;
                Invalidate();
            }
        }

        [Category("Resizable Theme")]
        public drawMode DrawMode
        {
            get { return _drawMode; }
            set
            {
                _drawMode = value;
                Invalidate();
            }
        }

        #endregion

        #region Private Methods
        public void ResizableColorBlends()
        {


            blendPositions[0] = 0.000f;
            blendPositions[1] = blendRotate + 0.100f;
            blendPositions[2] = blendRotate + 0.200f;
            blendPositions[3] = blendRotate + 0.300f;
            blendPositions[4] = blendRotate + 0.400f;
            blendPositions[5] = blendRotate + 0.500f;
            blendPositions[6] = blendRotate + 0.600f;
            blendPositions[7] = blendRotate + 0.700f;
            blendPositions[8] = blendRotate + 0.800f;
            blendPositions[9] = blendRotate + 0.900f;
            blendPositions[10] = blendRotate + 1.00f;

            colorBlends[0] = Color.Red;
            colorBlends[1] = Color.Yellow;
            colorBlends[2] = Color.Lime;
            colorBlends[3] = Color.Cyan;
            colorBlends[4] = Color.Blue;
            colorBlends[5] = Color.Violet;
            colorBlends[6] = Color.LightGray;
            colorBlends[7] = Color.Indigo;
            colorBlends[8] = Color.IndianRed;
            colorBlends[9] = Color.DarkOrange;
            colorBlends[10] = Color.Turquoise;




        }

        public void Resizable_Animation()
        {
            #region Animation

            if (DesignMode)
            {
                timer.Tick += Timer_Tick;
                if (AutoAnimate)
                {
                    //timer.Interval = 100;
                    timer.Start();
                }
            }

            if (!DesignMode)
            {
                timer.Tick += Timer_Tick;

                if (AutoAnimate)
                {
                    //timer.Interval = 100;
                    timer.Start();
                }
            }



            #endregion
        }


        #endregion

        #region Event

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.angle + 1 > 360f)
                this.angle = 0;
            else
            {
                this.angle++;
                Invalidate();
            }

            if (this.blendRotate + 0.01f > 1)
            {
                blendRotate = 0f;
            }

            else
            {
                blendRotate += 0.01f;
                Invalidate();
            }

        }

        #endregion

        void Resizable_PaintHook(PaintEventArgs e)
        {

            timer.Interval = interval;


            Bitmap bit = new Bitmap(1, 1);

            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            Rectangle border = new Rectangle(0, 0, Width - 1, Height - 1);

            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);

            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);

            #region Adding Color Blend
            // Create a new LinearGradientBrush using the rectangle, 
            // DarkSeaGreen and Orange. and 90-degree angle.


            Rectangle linearRectangle = new Rectangle(0, 0, Width - 1, Height - 1);

            LinearGradientBrush brush = new LinearGradientBrush(linearRectangle, backgroundColor, backgroundColor1, angle, true);

            if (enableColorBlend)
            {

                ColorBlend colorBlend = new ColorBlend();

                Single[] blendPoints = new Single[]
                {
                    blendPositions[0],
                    blendPositions[1],
                    blendPositions[2],
                    blendPositions[3],
                    blendPositions[4],
                    blendPositions[5],
                    blendPositions[6],
                    blendPositions[7],
                    blendPositions[8],
                    blendPositions[9],
                    blendPositions[10]

                };


                Color[] blendcolors = new System.Drawing.Color[]
                {
                    colorBlends[0],
                    colorBlends[1],
                    colorBlends[2],
                    colorBlends[3],
                    colorBlends[4],
                    colorBlends[5],
                    colorBlends[6],
                    colorBlends[7],
                    colorBlends[8],
                    colorBlends[9],
                    colorBlends[10]
                };

                colorBlend.Positions = blendPoints;

                colorBlend.Colors = blendcolors;

                brush.InterpolationColors = colorBlend;
                brush.GammaCorrection = gammaCorrection;


            }
            #endregion


            Pen drawHandleRegion = new Pen(handleColorBorder, handleBorderWidth);
            drawHandleRegion.DashStyle = handleDrawDashStyle;


            switch (_drawMode)
            {
                case drawMode.Solid:
                    e.Graphics.FillRectangle(new SolidBrush(BackColor), linearRectangle);
                    e.Graphics.DrawRectangle(new Pen(borderColor, borderWidth), border);
                    break;
                case drawMode.Gradient:
                    e.Graphics.FillRectangle(brush, linearRectangle);
                    e.Graphics.DrawRectangle(new Pen(borderColor, borderWidth), border);

                    break;
                case drawMode.Hatch:

                    #region HatchBrush Paint
                    switch (hatchBrushType)
                    {
                        case HatchBrushType.BackwardDiagonal:
                            HatchBrush HB = new HatchBrush(HatchStyle.BackwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB, linearRectangle);
                            break;
                        case HatchBrushType.Cross:
                            HatchBrush HB1 = new HatchBrush(HatchStyle.Cross, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB1, linearRectangle);
                            break;
                        case HatchBrushType.DarkDownwardDiagonal:
                            HatchBrush HB2 = new HatchBrush(HatchStyle.DarkDownwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB2, linearRectangle);
                            break;
                        case HatchBrushType.DarkHorizontal:
                            HatchBrush HB3 = new HatchBrush(HatchStyle.DarkHorizontal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB3, linearRectangle);
                            break;
                        case HatchBrushType.DarkUpwardDiagonal:
                            HatchBrush HB4 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB4, linearRectangle);
                            break;
                        case HatchBrushType.DarkVertical:
                            HatchBrush HB5 = new HatchBrush(HatchStyle.DarkVertical, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB5, linearRectangle);
                            break;
                        case HatchBrushType.DashedDownwardDiagonal:
                            HatchBrush HB6 = new HatchBrush(HatchStyle.DashedDownwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB6, linearRectangle);
                            break;
                        case HatchBrushType.DashedHorizontal:
                            HatchBrush HB7 = new HatchBrush(HatchStyle.DashedHorizontal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB7, linearRectangle);
                            break;
                        case HatchBrushType.DashedUpwardDiagonal:
                            HatchBrush HB8 = new HatchBrush(HatchStyle.DashedUpwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB8, linearRectangle);
                            break;
                        case HatchBrushType.DashedVertical:
                            HatchBrush HB9 = new HatchBrush(HatchStyle.DashedVertical, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB9, linearRectangle);
                            break;
                        case HatchBrushType.DiagonalBrick:
                            HatchBrush HBA = new HatchBrush(HatchStyle.DiagonalBrick, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBA, linearRectangle);
                            break;
                        case HatchBrushType.DiagonalCross:
                            HatchBrush HBB = new HatchBrush(HatchStyle.DiagonalCross, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBB, linearRectangle);
                            break;
                        case HatchBrushType.Divot:
                            HatchBrush HBC = new HatchBrush(HatchStyle.Divot, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBC, linearRectangle);
                            break;
                        case HatchBrushType.DottedDiamond:
                            HatchBrush HBD = new HatchBrush(HatchStyle.DottedDiamond, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBD, linearRectangle);
                            break;
                        case HatchBrushType.DottedGrid:
                            HatchBrush HBE = new HatchBrush(HatchStyle.DottedGrid, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBE, linearRectangle);
                            break;
                        case HatchBrushType.ForwardDiagonal:
                            HatchBrush HBF = new HatchBrush(HatchStyle.ForwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBF, linearRectangle);
                            break;
                        case HatchBrushType.Horizontal:
                            HatchBrush HBG = new HatchBrush(HatchStyle.Horizontal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBG, linearRectangle);
                            break;
                        case HatchBrushType.HorizontalBrick:
                            HatchBrush HBH = new HatchBrush(HatchStyle.HorizontalBrick, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBH, linearRectangle);
                            break;
                        case HatchBrushType.LargeCheckerBoard:
                            HatchBrush HBI = new HatchBrush(HatchStyle.LargeCheckerBoard, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBI, linearRectangle);
                            break;
                        case HatchBrushType.LargeConfetti:
                            HatchBrush HBJ = new HatchBrush(HatchStyle.LargeConfetti, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBJ, linearRectangle);
                            break;
                        case HatchBrushType.LargeGrid:
                            HatchBrush HBK = new HatchBrush(HatchStyle.LargeGrid, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBK, linearRectangle);
                            break;
                        case HatchBrushType.LightDownwardDiagonal:
                            HatchBrush HBL = new HatchBrush(HatchStyle.LightDownwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBL, linearRectangle);
                            break;
                        case HatchBrushType.LightHorizontal:
                            HatchBrush HBM = new HatchBrush(HatchStyle.LightHorizontal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBM, linearRectangle);
                            break;
                        case HatchBrushType.LightUpwardDiagonal:
                            HatchBrush HBN = new HatchBrush(HatchStyle.LightUpwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBN, linearRectangle);
                            break;
                        case HatchBrushType.LightVertical:
                            HatchBrush HBO = new HatchBrush(HatchStyle.LightVertical, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBO, linearRectangle);
                            break;
                        case HatchBrushType.Max:
                            HatchBrush HBP = new HatchBrush(HatchStyle.Max, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBP, linearRectangle);
                            break;
                        case HatchBrushType.Min:
                            HatchBrush HBQ = new HatchBrush(HatchStyle.Min, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBQ, linearRectangle);
                            break;
                        case HatchBrushType.NarrowHorizontal:
                            HatchBrush HBR = new HatchBrush(HatchStyle.NarrowHorizontal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBR, linearRectangle);
                            break;
                        case HatchBrushType.NarrowVertical:
                            HatchBrush HBS = new HatchBrush(HatchStyle.NarrowVertical, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBS, linearRectangle);
                            break;
                        case HatchBrushType.OutlinedDiamond:
                            HatchBrush HBT = new HatchBrush(HatchStyle.OutlinedDiamond, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBT, linearRectangle);
                            break;
                        case HatchBrushType.Percent05:
                            HatchBrush HBU = new HatchBrush(HatchStyle.Percent05, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBU, linearRectangle);
                            break;
                        case HatchBrushType.Percent10:
                            HatchBrush HBV = new HatchBrush(HatchStyle.Percent10, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBV, linearRectangle);
                            break;
                        case HatchBrushType.Percent20:
                            HatchBrush HBW = new HatchBrush(HatchStyle.Percent20, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBW, linearRectangle);
                            break;
                        case HatchBrushType.Percent25:
                            HatchBrush HBX = new HatchBrush(HatchStyle.Percent25, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBX, linearRectangle);
                            break;
                        case HatchBrushType.Percent30:
                            HatchBrush HBY = new HatchBrush(HatchStyle.Percent30, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBY, linearRectangle);
                            break;
                        case HatchBrushType.Percent40:
                            HatchBrush HBZ = new HatchBrush(HatchStyle.Percent40, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HBZ, linearRectangle);
                            break;
                        case HatchBrushType.Percent50:
                            HatchBrush HB10 = new HatchBrush(HatchStyle.Percent50, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB10, linearRectangle);
                            break;
                        case HatchBrushType.Percent60:
                            HatchBrush HB11 = new HatchBrush(HatchStyle.Percent60, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB11, linearRectangle);
                            break;
                        case HatchBrushType.Percent70:
                            HatchBrush HB12 = new HatchBrush(HatchStyle.Percent70, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB12, linearRectangle);
                            break;
                        case HatchBrushType.Percent75:
                            HatchBrush HB13 = new HatchBrush(HatchStyle.Percent75, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB13, linearRectangle);
                            break;
                        case HatchBrushType.Percent80:
                            HatchBrush HB14 = new HatchBrush(HatchStyle.Percent80, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB14, linearRectangle);
                            break;
                        case HatchBrushType.Percent90:
                            HatchBrush HB15 = new HatchBrush(HatchStyle.Percent90, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB15, linearRectangle);
                            break;
                        case HatchBrushType.Plaid:
                            HatchBrush HB16 = new HatchBrush(HatchStyle.Plaid, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB16, linearRectangle);
                            break;
                        case HatchBrushType.Shingle:
                            HatchBrush HB17 = new HatchBrush(HatchStyle.Shingle, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB17, linearRectangle);
                            break;
                        case HatchBrushType.SmallCheckerBoard:
                            HatchBrush HB18 = new HatchBrush(HatchStyle.SmallCheckerBoard, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB18, linearRectangle);
                            break;
                        case HatchBrushType.SmallConfetti:
                            HatchBrush HB19 = new HatchBrush(HatchStyle.SmallConfetti, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB19, linearRectangle);
                            break;
                        case HatchBrushType.SmallGrid:
                            HatchBrush HB20 = new HatchBrush(HatchStyle.SmallGrid, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB20, linearRectangle);
                            break;
                        case HatchBrushType.SolidDiamond:
                            HatchBrush HB21 = new HatchBrush(HatchStyle.SolidDiamond, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB21, linearRectangle);
                            break;
                        case HatchBrushType.Sphere:
                            HatchBrush HB22 = new HatchBrush(HatchStyle.Sphere, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB22, linearRectangle);
                            break;
                        case HatchBrushType.Trellis:
                            HatchBrush HB23 = new HatchBrush(HatchStyle.Trellis, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB23, linearRectangle);
                            break;
                        case HatchBrushType.Vertical:
                            HatchBrush HB24 = new HatchBrush(HatchStyle.Vertical, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB24, linearRectangle);
                            break;
                        case HatchBrushType.Wave:
                            HatchBrush HB25 = new HatchBrush(HatchStyle.Wave, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB25, linearRectangle);
                            break;
                        case HatchBrushType.Weave:
                            HatchBrush HB26 = new HatchBrush(HatchStyle.Weave, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB26, linearRectangle);
                            break;
                        case HatchBrushType.WideDownwardDiagonal:
                            HatchBrush HB27 = new HatchBrush(HatchStyle.WideDownwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB27, linearRectangle);
                            break;
                        case HatchBrushType.WideUpwardDiagonal:
                            HatchBrush HB28 = new HatchBrush(HatchStyle.WideUpwardDiagonal, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB28, linearRectangle);
                            break;
                        case HatchBrushType.ZigZag:
                            HatchBrush HB29 = new HatchBrush(HatchStyle.ZigZag, hatchBrushgradient1, hatchBrushgradient2);
                            G.FillRectangle(HB29, linearRectangle);
                            break;
                        default:
                            break;
                    }
                    #endregion

                    //e.Graphics.FillRectangle(brush, linearRectangle);

                    e.Graphics.DrawRectangle(new Pen(borderColor, borderWidth), border);

                    break;
                default:
                    break;
            }




            e.Graphics.FillRectangle(new SolidBrush(header), rc);
            e.Graphics.DrawRectangle(drawHandleRegion, rc);

        }



        #endregion
    }
}
