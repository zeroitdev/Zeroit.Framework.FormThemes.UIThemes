// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 04-15-2018
// ***********************************************************************
// <copyright file="FormEditorsDialog.Designer.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;

namespace Zeroit.Framework.FormThemes.UIThemes.ThematicForms.FormEditors
{
    partial class FormEditorsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.shadowColor_Btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.main_Yes_RadioBtn = new System.Windows.Forms.RadioButton();
            this.main_No_RadioBtn = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.colorSelector = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.thematic150WithEditor1 = new Zeroit.Framework.FormThemes.UIThemes.Thematic150WithEditor();
            this.blackTheme1 = new Zeroit.Framework.FormThemes.Helper.SpicyLips();
            this.shadow_GroupBox = new System.Windows.Forms.GroupBox();
            this.colorSelector_Btn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.horizontal_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.vertical_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.spread_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.blur_Numeric = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.formPreviewer = new Zeroit.Framework.FormThemes.UIThemes.Thematic150WithEditor();
            this.closeBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.main_Shadow_No_RadioBtn = new System.Windows.Forms.RadioButton();
            this.main_Shadow_Yes_RadioBtn = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.main_Custom_No_RadioBtn = new System.Windows.Forms.RadioButton();
            this.main_Custom_Yes_RadioBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.form_Label = new System.Windows.Forms.Label();
            this.main_formType_ComboBox = new System.Windows.Forms.ComboBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.blackTheme1.SuspendLayout();
            this.shadow_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horizontal_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertical_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spread_Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blur_Numeric)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11F);
            this.label7.Location = new System.Drawing.Point(15, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 93;
            this.label7.Text = "Color";
            // 
            // shadowColor_Btn
            // 
            this.shadowColor_Btn.BackColor = System.Drawing.Color.Black;
            this.shadowColor_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shadowColor_Btn.FlatAppearance.BorderSize = 0;
            this.shadowColor_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shadowColor_Btn.Font = new System.Drawing.Font("Verdana", 11F);
            this.shadowColor_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.shadowColor_Btn.Location = new System.Drawing.Point(190, 217);
            this.shadowColor_Btn.Name = "shadowColor_Btn";
            this.shadowColor_Btn.Size = new System.Drawing.Size(100, 28);
            this.shadowColor_Btn.TabIndex = 92;
            this.shadowColor_Btn.UseVisualStyleBackColor = false;
            this.shadowColor_Btn.Click += new System.EventHandler(this.shadowColor_Btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11F);
            this.label6.Location = new System.Drawing.Point(15, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Horizontal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11F);
            this.label5.Location = new System.Drawing.Point(15, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Vertical";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11F);
            this.label4.Location = new System.Drawing.Point(15, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Spread";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11F);
            this.label3.Location = new System.Drawing.Point(15, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blur";
            // 
            // main_Yes_RadioBtn
            // 
            this.main_Yes_RadioBtn.AutoSize = true;
            this.main_Yes_RadioBtn.Location = new System.Drawing.Point(150, 177);
            this.main_Yes_RadioBtn.Name = "main_Yes_RadioBtn";
            this.main_Yes_RadioBtn.Size = new System.Drawing.Size(51, 22);
            this.main_Yes_RadioBtn.TabIndex = 2;
            this.main_Yes_RadioBtn.Text = "Yes";
            this.main_Yes_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // main_No_RadioBtn
            // 
            this.main_No_RadioBtn.AutoSize = true;
            this.main_No_RadioBtn.Checked = true;
            this.main_No_RadioBtn.Location = new System.Drawing.Point(218, 177);
            this.main_No_RadioBtn.Name = "main_No_RadioBtn";
            this.main_No_RadioBtn.Size = new System.Drawing.Size(47, 22);
            this.main_No_RadioBtn.TabIndex = 4;
            this.main_No_RadioBtn.TabStop = true;
            this.main_No_RadioBtn.Text = "No";
            this.main_No_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(14, 6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 22);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Yes";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 11F);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(190, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 92;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.shadowColor_Btn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 11F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Location = new System.Drawing.Point(22, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 266);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shadow Properties";
            // 
            // thematic150WithEditor1
            // 
            this.thematic150WithEditor1._ShowIcon = false;
            this.thematic150WithEditor1.ActivateShadow = false;
            this.thematic150WithEditor1.Angle = 90F;
            this.thematic150WithEditor1.Animated = false;
            this.thematic150WithEditor1.AutoAnimate = false;
            this.thematic150WithEditor1.BackgroundColor = System.Drawing.Color.Orange;
            this.thematic150WithEditor1.BackgroundColor1 = System.Drawing.Color.DarkSeaGreen;
            this.thematic150WithEditor1.BaWGUI_DrawButtonStrings = true;
            this.thematic150WithEditor1.BlendPositions = new float[] {
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F};
            this.thematic150WithEditor1.Border = System.Drawing.Color.Empty;
            this.thematic150WithEditor1.Border1 = System.Drawing.Color.Black;
            this.thematic150WithEditor1.Border2 = System.Drawing.Color.Gray;
            this.thematic150WithEditor1.BorderColor = System.Drawing.Color.Red;
            this.thematic150WithEditor1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.thematic150WithEditor1.BorderWidth = 1;
            this.thematic150WithEditor1.BottomBar = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.thematic150WithEditor1.CaptionHeight = 32;
            this.thematic150WithEditor1.CenterText = false;
            this.thematic150WithEditor1.CloseBox = true;
            this.thematic150WithEditor1.CloseChoice = Zeroit.Framework.FormThemes.UIThemes.@__CloseChoice.Form;
            this.thematic150WithEditor1.ColorBlends = new System.Drawing.Color[] {
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty};
            this.thematic150WithEditor1.ColorHatchBrushgradient1 = System.Drawing.Color.Black;
            this.thematic150WithEditor1.ColorHatchBrushgradient2 = System.Drawing.Color.Transparent;
            this.thematic150WithEditor1.Colors = new Zeroit.Framework.FormThemes.UIThemes.Bloom[0];
            this.thematic150WithEditor1.ControlBoxColor = System.Drawing.Color.White;
            this.thematic150WithEditor1.ControlBoxType = Zeroit.Framework.FormThemes.UIThemes.controlBoxType.Small;
            this.thematic150WithEditor1.ControlsAlign = Zeroit.Framework.FormThemes.UIThemes.ControlsAlign.Right;
            this.thematic150WithEditor1.Customization = "";
            this.thematic150WithEditor1.CustomShadow = false;
            this.thematic150WithEditor1.CustomTheme = true;
            this.thematic150WithEditor1.DarkTheme = false;
            this.thematic150WithEditor1.DefaultShadow = true;
            this.thematic150WithEditor1.DesignBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.thematic150WithEditor1.DisableControlboxClose = false;
            this.thematic150WithEditor1.DisableControlboxMax = false;
            this.thematic150WithEditor1.DisableControlboxMin = false;
            this.thematic150WithEditor1.DrawButtonStrings = true;
            this.thematic150WithEditor1.drawCButtonBorder = true;
            this.thematic150WithEditor1.DrawMode = Zeroit.Framework.FormThemes.UIThemes.Thematic150WithEditor.drawMode.Solid;
            this.thematic150WithEditor1.Enable_Border = true;
            this.thematic150WithEditor1.EnableColorBlend = false;
            this.thematic150WithEditor1.EnableControlBox = false;
            this.thematic150WithEditor1.Fill = true;
            this.thematic150WithEditor1.Font = new System.Drawing.Font("Verdana", 8F);
            this.thematic150WithEditor1.FormInput = new Zeroit.Framework.FormThemes.UIThemes.ThematicForms.FormEditors.FormInput(Zeroit.Framework.FormThemes.UIThemes.themes.Spicylips, true, false, 10, -5, 0, 0, System.Drawing.Color.Black);
            this.thematic150WithEditor1.GammaCorrection = false;
            this.thematic150WithEditor1.GripRegionColor = System.Drawing.Color.Transparent;
            this.thematic150WithEditor1.GripSize = 10;
            this.thematic150WithEditor1.HackDrawMode = Zeroit.Framework.FormThemes.UIThemes.Thematic150WithEditor.HackerDrawMode.Hatch;
            this.thematic150WithEditor1.HackerColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))))};
            this.thematic150WithEditor1.HackerGradMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.thematic150WithEditor1.HackerHatch = System.Drawing.Drawing2D.HatchStyle.DarkDownwardDiagonal;
            this.thematic150WithEditor1.HandleBorderWidth = 1;
            this.thematic150WithEditor1.HandleColorBorder = System.Drawing.Color.Black;
            this.thematic150WithEditor1.HandleDrawStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.thematic150WithEditor1.HatchBrush = Zeroit.Framework.FormThemes.UIThemes.Thematic150WithEditor.HatchBrushType.ForwardDiagonal;
            this.thematic150WithEditor1.HatchEnable = false;
            this.thematic150WithEditor1.HeaderOffset = 1;
            this.thematic150WithEditor1.Icon = null;
            this.thematic150WithEditor1.Image = null;
            this.thematic150WithEditor1.Line1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.thematic150WithEditor1.Line2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.thematic150WithEditor1.Location = new System.Drawing.Point(0, 0);
            this.thematic150WithEditor1.LockDimension = false;
            this.thematic150WithEditor1.MaximizeBox = true;
            this.thematic150WithEditor1.MetrodiskTheme = false;
            this.thematic150WithEditor1.MinimizeBox = true;
            this.thematic150WithEditor1.Movable = true;
            this.thematic150WithEditor1.MoveHeight = 24;
            this.thematic150WithEditor1.Name = "thematic150WithEditor1";
            this.thematic150WithEditor1.NewProperty = false;
            this.thematic150WithEditor1.NoRounding = false;
            this.thematic150WithEditor1.NYX_GradColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))))};
            this.thematic150WithEditor1.Rounding = Zeroit.Framework.FormThemes.UIThemes.Thematic150WithEditor.RoundingType.None;
            this.thematic150WithEditor1.ShadowBlur = 10;
            this.thematic150WithEditor1.ShadowColor = System.Drawing.Color.Black;
            this.thematic150WithEditor1.ShadowHorizontal = 0;
            this.thematic150WithEditor1.ShadowSpread = -5;
            this.thematic150WithEditor1.ShadowVertical = 0;
            this.thematic150WithEditor1.Sharp_Color2 = true;
            this.thematic150WithEditor1.ShowIcon = false;
            this.thematic150WithEditor1.Sizable = true;
            this.thematic150WithEditor1.Size = new System.Drawing.Size(802, 553);
            this.thematic150WithEditor1.SmartBounds = true;
            this.thematic150WithEditor1.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.thematic150WithEditor1.SubHeader = "Insert Sub Header";
            this.thematic150WithEditor1.Subtext = null;
            this.thematic150WithEditor1.TabIndex = 0;
            this.thematic150WithEditor1.test = true;
            this.thematic150WithEditor1.TextAlignment = Zeroit.Framework.FormThemes.UIThemes.Thematic150WithEditor.Alignment.Left;
            this.thematic150WithEditor1.Theme = Zeroit.Framework.FormThemes.UIThemes.themes.Spicylips;
            this.thematic150WithEditor1.ThemeStyle = Zeroit.Framework.FormThemes.UIThemes.Thematic150WithEditor.ColorTheme.GammaRay;
            this.thematic150WithEditor1.TimerInterval = 100;
            this.thematic150WithEditor1.TitleTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.thematic150WithEditor1.TopBar = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.thematic150WithEditor1.TransparencyKey = System.Drawing.Color.Empty;
            this.thematic150WithEditor1.Transparent = false;
            this.thematic150WithEditor1.UseFadeOut = true;
            this.thematic150WithEditor1.WrapMode = System.Drawing.Drawing2D.WrapMode.Clamp;
            // 
            // blackTheme1
            // 
            this.blackTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.blackTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.blackTheme1.Colors = new Zeroit.Framework.FormThemes.Helper.Bloom[0];
            this.blackTheme1.Controls.Add(this.shadow_GroupBox);
            this.blackTheme1.Controls.Add(this.panel1);
            this.blackTheme1.Controls.Add(this.closeBtn);
            this.blackTheme1.Controls.Add(this.groupBox1);
            this.blackTheme1.Controls.Add(this.okBtn);
            this.blackTheme1.Controls.Add(this.cancelBtn);
            this.blackTheme1.Customization = "";
            this.blackTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blackTheme1.Font = new System.Drawing.Font("Verdana", 11F);
            this.blackTheme1.Image = null;
            this.blackTheme1.Location = new System.Drawing.Point(0, 0);
            this.blackTheme1.Movable = true;
            this.blackTheme1.Name = "blackTheme1";
            this.blackTheme1.NoRounding = false;
            this.blackTheme1.Sizable = true;
            this.blackTheme1.Size = new System.Drawing.Size(1203, 618);
            this.blackTheme1.SmartBounds = true;
            this.blackTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.blackTheme1.TabIndex = 0;
            this.blackTheme1.Text = "Form Editor Dialog";
            this.blackTheme1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.blackTheme1.Transparent = false;
            // 
            // shadow_GroupBox
            // 
            this.shadow_GroupBox.Controls.Add(this.colorSelector_Btn);
            this.shadow_GroupBox.Controls.Add(this.label12);
            this.shadow_GroupBox.Controls.Add(this.label11);
            this.shadow_GroupBox.Controls.Add(this.horizontal_Numeric);
            this.shadow_GroupBox.Controls.Add(this.label10);
            this.shadow_GroupBox.Controls.Add(this.vertical_Numeric);
            this.shadow_GroupBox.Controls.Add(this.label9);
            this.shadow_GroupBox.Controls.Add(this.spread_Numeric);
            this.shadow_GroupBox.Controls.Add(this.label8);
            this.shadow_GroupBox.Controls.Add(this.blur_Numeric);
            this.shadow_GroupBox.Font = new System.Drawing.Font("Verdana", 11F);
            this.shadow_GroupBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.shadow_GroupBox.Location = new System.Drawing.Point(22, 242);
            this.shadow_GroupBox.Name = "shadow_GroupBox";
            this.shadow_GroupBox.Size = new System.Drawing.Size(319, 266);
            this.shadow_GroupBox.TabIndex = 73;
            this.shadow_GroupBox.TabStop = false;
            this.shadow_GroupBox.Text = "Shadow Properties";
            this.shadow_GroupBox.Visible = false;
            // 
            // colorSelector_Btn
            // 
            this.colorSelector_Btn.BackColor = System.Drawing.Color.Black;
            this.colorSelector_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorSelector_Btn.FlatAppearance.BorderSize = 0;
            this.colorSelector_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorSelector_Btn.Font = new System.Drawing.Font("Verdana", 11F);
            this.colorSelector_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.colorSelector_Btn.Location = new System.Drawing.Point(170, 215);
            this.colorSelector_Btn.Name = "colorSelector_Btn";
            this.colorSelector_Btn.Size = new System.Drawing.Size(120, 36);
            this.colorSelector_Btn.TabIndex = 92;
            this.colorSelector_Btn.UseVisualStyleBackColor = false;
            this.colorSelector_Btn.Click += new System.EventHandler(this.colorSelector_Btn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 11F);
            this.label12.Location = new System.Drawing.Point(8, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 18);
            this.label12.TabIndex = 17;
            this.label12.Text = "Shadow Color";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 11F);
            this.label11.Location = new System.Drawing.Point(7, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "Horizontal";
            // 
            // horizontal_Numeric
            // 
            this.horizontal_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.horizontal_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.horizontal_Numeric.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.horizontal_Numeric.Location = new System.Drawing.Point(170, 169);
            this.horizontal_Numeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.horizontal_Numeric.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.horizontal_Numeric.Name = "horizontal_Numeric";
            this.horizontal_Numeric.Size = new System.Drawing.Size(120, 25);
            this.horizontal_Numeric.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 11F);
            this.label10.Location = new System.Drawing.Point(7, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Vertical";
            // 
            // vertical_Numeric
            // 
            this.vertical_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.vertical_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vertical_Numeric.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.vertical_Numeric.Location = new System.Drawing.Point(170, 123);
            this.vertical_Numeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.vertical_Numeric.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.vertical_Numeric.Name = "vertical_Numeric";
            this.vertical_Numeric.Size = new System.Drawing.Size(120, 25);
            this.vertical_Numeric.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 11F);
            this.label9.Location = new System.Drawing.Point(7, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Spread";
            // 
            // spread_Numeric
            // 
            this.spread_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.spread_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spread_Numeric.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.spread_Numeric.Location = new System.Drawing.Point(170, 77);
            this.spread_Numeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.spread_Numeric.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.spread_Numeric.Name = "spread_Numeric";
            this.spread_Numeric.Size = new System.Drawing.Size(120, 25);
            this.spread_Numeric.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11F);
            this.label8.Location = new System.Drawing.Point(7, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Blur";
            // 
            // blur_Numeric
            // 
            this.blur_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.blur_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blur_Numeric.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.blur_Numeric.Location = new System.Drawing.Point(170, 31);
            this.blur_Numeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.blur_Numeric.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.blur_Numeric.Name = "blur_Numeric";
            this.blur_Numeric.Size = new System.Drawing.Size(120, 25);
            this.blur_Numeric.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel1.Controls.Add(this.formPreviewer);
            this.panel1.Location = new System.Drawing.Point(370, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 553);
            this.panel1.TabIndex = 91;
            // 
            // formPreviewer
            // 
            this.formPreviewer._ShowIcon = false;
            this.formPreviewer.ActivateShadow = false;
            this.formPreviewer.Angle = 90F;
            this.formPreviewer.Animated = false;
            this.formPreviewer.AutoAnimate = false;
            this.formPreviewer.BackgroundColor = System.Drawing.Color.Orange;
            this.formPreviewer.BackgroundColor1 = System.Drawing.Color.DarkSeaGreen;
            this.formPreviewer.BaWGUI_DrawButtonStrings = true;
            this.formPreviewer.BlendPositions = new float[] {
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F};
            this.formPreviewer.Border = System.Drawing.Color.Empty;
            this.formPreviewer.Border1 = System.Drawing.Color.Black;
            this.formPreviewer.Border2 = System.Drawing.Color.Gray;
            this.formPreviewer.BorderColor = System.Drawing.Color.Red;
            this.formPreviewer.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.formPreviewer.BorderWidth = 1;
            this.formPreviewer.BottomBar = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.formPreviewer.CaptionHeight = 32;
            this.formPreviewer.CenterText = false;
            this.formPreviewer.CloseBox = true;
            this.formPreviewer.CloseChoice = Zeroit.Framework.FormThemes.UIThemes.@__CloseChoice.Form;
            this.formPreviewer.ColorBlends = new System.Drawing.Color[] {
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty,
        System.Drawing.Color.Empty};
            this.formPreviewer.ColorHatchBrushgradient1 = System.Drawing.Color.Black;
            this.formPreviewer.ColorHatchBrushgradient2 = System.Drawing.Color.Transparent;
            this.formPreviewer.Colors = new Zeroit.Framework.FormThemes.UIThemes.Bloom[0];
            this.formPreviewer.ControlBoxColor = System.Drawing.Color.White;
            this.formPreviewer.ControlBoxType = Zeroit.Framework.FormThemes.UIThemes.controlBoxType.Small;
            this.formPreviewer.ControlsAlign = Zeroit.Framework.FormThemes.UIThemes.ControlsAlign.Right;
            this.formPreviewer.Customization = "";
            this.formPreviewer.CustomShadow = false;
            this.formPreviewer.CustomTheme = true;
            this.formPreviewer.DarkTheme = false;
            this.formPreviewer.DefaultShadow = true;
            this.formPreviewer.DesignBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.formPreviewer.DisableControlboxClose = false;
            this.formPreviewer.DisableControlboxMax = false;
            this.formPreviewer.DisableControlboxMin = false;
            this.formPreviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPreviewer.DrawButtonStrings = true;
            this.formPreviewer.drawCButtonBorder = true;
            this.formPreviewer.DrawMode = Zeroit.Framework.FormThemes.UIThemes.Thematic150WithEditor.drawMode.Solid;
            this.formPreviewer.Enable_Border = true;
            this.formPreviewer.EnableColorBlend = false;
            this.formPreviewer.EnableControlBox = false;
            this.formPreviewer.Fill = true;
            this.formPreviewer.Font = new System.Drawing.Font("Verdana", 8F);
            this.formPreviewer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.formPreviewer.FormInput = new Zeroit.Framework.FormThemes.UIThemes.ThematicForms.FormEditors.FormInput(Zeroit.Framework.FormThemes.UIThemes.themes.Spicylips, true, false, 10, -5, 0, 0, System.Drawing.Color.Black);
            this.formPreviewer.GammaCorrection = false;
            this.formPreviewer.GripRegionColor = System.Drawing.Color.Transparent;
            this.formPreviewer.GripSize = 10;
            this.formPreviewer.HackDrawMode = Zeroit.Framework.FormThemes.UIThemes.Thematic150WithEditor.HackerDrawMode.Hatch;
            this.formPreviewer.HackerColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))))};
            this.formPreviewer.HackerGradMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.formPreviewer.HackerHatch = System.Drawing.Drawing2D.HatchStyle.DarkDownwardDiagonal;
            this.formPreviewer.HandleBorderWidth = 1;
            this.formPreviewer.HandleColorBorder = System.Drawing.Color.Black;
            this.formPreviewer.HandleDrawStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.formPreviewer.HatchBrush = Zeroit.Framework.FormThemes.UIThemes.Thematic150WithEditor.HatchBrushType.ForwardDiagonal;
            this.formPreviewer.HatchEnable = false;
            this.formPreviewer.HeaderOffset = 1;
            this.formPreviewer.Icon = null;
            this.formPreviewer.Image = null;
            this.formPreviewer.Line1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.formPreviewer.Line2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.formPreviewer.Location = new System.Drawing.Point(0, 0);
            this.formPreviewer.LockDimension = false;
            this.formPreviewer.MaximizeBox = true;
            this.formPreviewer.MetrodiskTheme = false;
            this.formPreviewer.MinimizeBox = true;
            this.formPreviewer.Movable = true;
            this.formPreviewer.MoveHeight = 24;
            this.formPreviewer.Name = "formPreviewer";
            this.formPreviewer.NewProperty = false;
            this.formPreviewer.NoRounding = false;
            this.formPreviewer.NYX_GradColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))))};
            this.formPreviewer.Padding = new System.Windows.Forms.Padding(2, 36, 2, 2);
            this.formPreviewer.Rounding = Zeroit.Framework.FormThemes.UIThemes.Thematic150WithEditor.RoundingType.None;
            this.formPreviewer.ShadowBlur = 10;
            this.formPreviewer.ShadowColor = System.Drawing.Color.Black;
            this.formPreviewer.ShadowHorizontal = 0;
            this.formPreviewer.ShadowSpread = -5;
            this.formPreviewer.ShadowVertical = 0;
            this.formPreviewer.Sharp_Color2 = true;
            this.formPreviewer.ShowIcon = false;
            this.formPreviewer.Sizable = true;
            this.formPreviewer.Size = new System.Drawing.Size(802, 553);
            this.formPreviewer.SmartBounds = true;
            this.formPreviewer.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.formPreviewer.SubHeader = "Insert Sub Header";
            this.formPreviewer.Subtext = null;
            this.formPreviewer.TabIndex = 0;
            this.formPreviewer.test = true;
            this.formPreviewer.TextAlignment = Zeroit.Framework.FormThemes.UIThemes.Thematic150WithEditor.Alignment.Left;
            this.formPreviewer.Theme = Zeroit.Framework.FormThemes.UIThemes.themes.Spicylips;
            this.formPreviewer.ThemeStyle = Zeroit.Framework.FormThemes.UIThemes.Thematic150WithEditor.ColorTheme.GammaRay;
            this.formPreviewer.TimerInterval = 100;
            this.formPreviewer.TitleTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.formPreviewer.TopBar = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.formPreviewer.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formPreviewer.Transparent = false;
            this.formPreviewer.UseFadeOut = true;
            this.formPreviewer.WrapMode = System.Drawing.Drawing2D.WrapMode.Clamp;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.closeBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.closeBtn.Location = new System.Drawing.Point(1184, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(16, 16);
            this.closeBtn.TabIndex = 90;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.form_Label);
            this.groupBox1.Controls.Add(this.main_formType_ComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(22, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 207);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.main_Shadow_No_RadioBtn);
            this.panel3.Controls.Add(this.main_Shadow_Yes_RadioBtn);
            this.panel3.Location = new System.Drawing.Point(150, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 39);
            this.panel3.TabIndex = 8;
            // 
            // main_Shadow_No_RadioBtn
            // 
            this.main_Shadow_No_RadioBtn.AutoSize = true;
            this.main_Shadow_No_RadioBtn.Checked = true;
            this.main_Shadow_No_RadioBtn.Location = new System.Drawing.Point(79, 8);
            this.main_Shadow_No_RadioBtn.Name = "main_Shadow_No_RadioBtn";
            this.main_Shadow_No_RadioBtn.Size = new System.Drawing.Size(47, 22);
            this.main_Shadow_No_RadioBtn.TabIndex = 1;
            this.main_Shadow_No_RadioBtn.TabStop = true;
            this.main_Shadow_No_RadioBtn.Text = "No";
            this.main_Shadow_No_RadioBtn.UseVisualStyleBackColor = true;
            this.main_Shadow_No_RadioBtn.CheckedChanged += new System.EventHandler(this.main_Shadow_No_RadioBtn_CheckedChanged);
            // 
            // main_Shadow_Yes_RadioBtn
            // 
            this.main_Shadow_Yes_RadioBtn.AutoSize = true;
            this.main_Shadow_Yes_RadioBtn.Location = new System.Drawing.Point(7, 8);
            this.main_Shadow_Yes_RadioBtn.Name = "main_Shadow_Yes_RadioBtn";
            this.main_Shadow_Yes_RadioBtn.Size = new System.Drawing.Size(51, 22);
            this.main_Shadow_Yes_RadioBtn.TabIndex = 0;
            this.main_Shadow_Yes_RadioBtn.Text = "Yes";
            this.main_Shadow_Yes_RadioBtn.UseVisualStyleBackColor = true;
            this.main_Shadow_Yes_RadioBtn.CheckedChanged += new System.EventHandler(this.main_Shadow_Yes_RadioBtn_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.main_Custom_No_RadioBtn);
            this.panel2.Controls.Add(this.main_Custom_Yes_RadioBtn);
            this.panel2.Location = new System.Drawing.Point(150, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 39);
            this.panel2.TabIndex = 0;
            // 
            // main_Custom_No_RadioBtn
            // 
            this.main_Custom_No_RadioBtn.AutoSize = true;
            this.main_Custom_No_RadioBtn.Location = new System.Drawing.Point(79, 9);
            this.main_Custom_No_RadioBtn.Name = "main_Custom_No_RadioBtn";
            this.main_Custom_No_RadioBtn.Size = new System.Drawing.Size(47, 22);
            this.main_Custom_No_RadioBtn.TabIndex = 1;
            this.main_Custom_No_RadioBtn.Text = "No";
            this.main_Custom_No_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // main_Custom_Yes_RadioBtn
            // 
            this.main_Custom_Yes_RadioBtn.AutoSize = true;
            this.main_Custom_Yes_RadioBtn.Checked = true;
            this.main_Custom_Yes_RadioBtn.Location = new System.Drawing.Point(7, 9);
            this.main_Custom_Yes_RadioBtn.Name = "main_Custom_Yes_RadioBtn";
            this.main_Custom_Yes_RadioBtn.Size = new System.Drawing.Size(51, 22);
            this.main_Custom_Yes_RadioBtn.TabIndex = 0;
            this.main_Custom_Yes_RadioBtn.TabStop = true;
            this.main_Custom_Yes_RadioBtn.Text = "Yes";
            this.main_Custom_Yes_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F);
            this.label2.Location = new System.Drawing.Point(7, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Custom Theme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F);
            this.label1.Location = new System.Drawing.Point(7, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shadow";
            // 
            // form_Label
            // 
            this.form_Label.AutoSize = true;
            this.form_Label.Font = new System.Drawing.Font("Verdana", 11F);
            this.form_Label.Location = new System.Drawing.Point(7, 48);
            this.form_Label.Name = "form_Label";
            this.form_Label.Size = new System.Drawing.Size(48, 18);
            this.form_Label.TabIndex = 1;
            this.form_Label.Text = "Form";
            // 
            // main_formType_ComboBox
            // 
            this.main_formType_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.main_formType_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_formType_ComboBox.Font = new System.Drawing.Font("Verdana", 12F);
            this.main_formType_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.main_formType_ComboBox.FormattingEnabled = true;
            this.main_formType_ComboBox.Location = new System.Drawing.Point(152, 45);
            this.main_formType_ComboBox.Name = "main_formType_ComboBox";
            this.main_formType_ComboBox.Size = new System.Drawing.Size(150, 26);
            this.main_formType_ComboBox.TabIndex = 0;
            this.main_formType_ComboBox.SelectedIndexChanged += new System.EventHandler(this.FormChanged);
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Font = new System.Drawing.Font("Verdana", 11F);
            this.okBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.okBtn.Location = new System.Drawing.Point(40, 535);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(130, 53);
            this.okBtn.TabIndex = 70;
            this.okBtn.Text = "&OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Verdana", 11F);
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancelBtn.Location = new System.Drawing.Point(182, 535);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(130, 53);
            this.cancelBtn.TabIndex = 71;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // FormEditorsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 618);
            this.Controls.Add(this.blackTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditorsDialog";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.blackTheme1.ResumeLayout(false);
            this.shadow_GroupBox.ResumeLayout(false);
            this.shadow_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horizontal_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertical_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spread_Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blur_Numeric)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Zeroit.Framework.FormThemes.Helper.SpicyLips blackTheme1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label form_Label;
        private System.Windows.Forms.ComboBox main_formType_ComboBox;
        public System.Windows.Forms.Button okBtn;
        public System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox shadow_GroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton main_Yes_RadioBtn;
        private System.Windows.Forms.RadioButton main_No_RadioBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton main_Shadow_No_RadioBtn;
        private System.Windows.Forms.RadioButton main_Shadow_Yes_RadioBtn;
        private System.Windows.Forms.RadioButton main_Custom_No_RadioBtn;
        private System.Windows.Forms.RadioButton main_Custom_Yes_RadioBtn;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button shadowColor_Btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorSelector;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button colorSelector_Btn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown horizontal_Numeric;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown vertical_Numeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown spread_Numeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown blur_Numeric;
        private Thematic150WithEditor thematic150WithEditor1;
        private Thematic150WithEditor formPreviewer;
    }
}