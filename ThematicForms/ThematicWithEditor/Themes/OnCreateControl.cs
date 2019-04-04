﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="OnCreateControl.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
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

        /// <summary>
        /// Called when [create control].
        /// </summary>
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            switch (Theme)
            {
                case themes.Angel:
                    Parent.FindForm().AllowTransparency = true;
                    Parent.FindForm().TransparencyKey = Color.Fuchsia;
                    Parent.FindForm().FormBorderStyle = FormBorderStyle.None;
                    BackColor = Color.FromArgb(17, 33, 47);
                    Dock = DockStyle.Fill;
                    Font = new Font("Segoe UI", 12);
                    Invalidate();
                    break;

                case themes.Alpha:
                    break;

                case themes.Anom:

                    break;
                case themes.Aryan:
                    break;
                case themes.Atrocity:
                    break;
                case themes.Avatar:
                    break;
                case themes.AVG:
                    break;
                case themes.BasicCode:
                    break;
                case themes.BetaBlue:
                    BackColor = Color.FromKnownColor(KnownColor.Control);
                    MoveHeight = 25;
                    TransparencyKey = Color.Fuchsia;
                    break;
                case themes.Beyond:
                    break;
                case themes.Bionic:
                    ParentForm.TransparencyKey = Color.Fuchsia;
                    ParentForm.FormBorderStyle = FormBorderStyle.None;
                    Dock = DockStyle.Fill;
                    BackColor = Color.FromArgb(48, 48, 48);
                    Invalidate();
                    break;
                case themes.BitDefender:
                    //SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.SupportsTransparentBackColor, true);
                    //DoubleBuffered = true;
                    //Dock = DockStyle.Fill;
                    //BackColor = Color.Fuchsia;

                    break;
                case themes.BlackShades:
                    break;
                case themes.Bloody:
                    break;
                //case themes.BlueAndWhite:
                //    break;
                case themes.Blue:
                    break;
                case themes.Booster:
                    Header = 25;
                    break;
                case themes.Border:
                    break;
                case themes.Bullion:
                    break;
                case themes.ButterScotch:
                    break;
                case themes.CarbonFibre:
                    break;
                case themes.Chrome:
                    break;
                case themes.Clarity:
                    break;
                case themes.Classic:
                    break;
                case themes.clsNeoBux:
                    break;
                case themes.CocaCola:
                    break;
                case themes.Complex:
                    Font = new Font("Segoe UI", 12);
                    break;
                case themes.Crystal:
                    break;
                case themes.Cypher:
                    break;
                //case themes.CypherX:
                //    break;
                case themes.DarkMatter:
                    break;
                case themes.Design:
                    break;
                case themes.Destiny:
                    break;
                case themes.Deumos:
                    BackColor = Deumos_C1;
                    break;
                case themes.Doom:
                    break;
                case themes.Drone:
                    break;
                case themes.Earn:
                    ForeColor = Color.White;
                    break;
                case themes.Effectual:
                    break;
                case themes.Electric:
                    MoveHeight = 20;
                    TransparencyKey = Color.Fuchsia;
                    ForeColor = Color.White;
                    BackColor = Color.FromArgb(22, 84, 107);
                    Font Electric_F = new Font("Verdana", 7);
                    Font = Electric_F;
                    break;
                case themes.Electrified:
                    Font = new Font("Tahoma", 8.25f);
                    ForeColor = Color.Black;
                    BackColor = Color.White;
                    TransparencyKey = Color.Fuchsia;
                    MoveHeight = 20;
                    break;
                case themes.Elegant:
                    Font = new Font("Segoe UI", 12);
                    break;
                case themes.Element:
                    BackColor = Color.FromArgb(41, 41, 41);
                    break;
                case themes.Empire:
                    BackColor = Color.FromArgb(50, 50, 50);
                    ForeColor = Color.White;
                    break;
                case themes.Empress:
                    BackColor = Utilities.ColorConverter.HexToColor("#DE873A");
                    break;
                case themes.ETheme:
                    BackColor = Color.FromArgb(53, 53, 53);
                    MoveHeight = 30;
                    break;
                case themes.Evolve:
                    break;
                case themes.Excision:
                    break;
                case themes.Exotic:
                    //test = true;
                    //MoveHeight = 20;
                    //this.Font = new Font("Gabriola", 12, FontStyle.Regular);

                    break;
                case themes.Facebook:
                    BackColor = _MainColour;
                    MoveHeight = 45;
                    break;
                case themes.Festus:
                    ForeColor = Color.Black;
                    MoveHeight = 25;
                    break;
                case themes.FlatUI:
                    BackColor = _BaseColor;
                    MoveHeight = 50;
                    break;
                case themes.Flow:
                    BackColor = Color.FromArgb(35, 35, 35);
                    CreateShade();
                    CreateTile();
                    break;
                case themes.Frog:
                    break;
                case themes.Fusion:
                    break;
                case themes.Future:
                    BackColor = Color.FromArgb(34, 34, 34);
                    break;
                case themes.GTheme:
                    BackColor = Color.FromArgb(25, 25, 25);
                    ForeColor = Color.FromArgb(76, 76, 76);
                    break;
                case themes.GameBooster:
                    this.BackColor = Color.FromArgb(51, 51, 51);
                    //BackColor = Color.FromArgb(255, 255, 255);
                    break;
                case themes.Genuine:
                    break;
                case themes.Ghostv2:
                    break;
                case themes.GhostTheme:
                    break;
                case themes.Gray:
                    break;
                case themes.Green:
                    break;
                case themes.Hacker:
                    break;
                case themes.Hero:
                    break;
                case themes.Hex:
                    break;
                case themes.HF:
                    break;
                case themes.Hura:
                    break;
                case themes.iBlack:
                    break;
                case themes.Influence:
                    break;
                case themes.InnerDarkness:
                    break;
                case themes.Insomia:
                    break;
                case themes.Intel:
                    break;
                case themes.JTheme:
                    break;
                case themes.Knight:
                    break;
                case themes.Light:
                    break;
                case themes.Login:
                    break;
                case themes.Loyal:
                    break;
                case themes.Meph:
                    break;
                case themes.Metal:
                    break;
                case themes.MetroUI:
                    break;
                case themes.MetroDisk:
                    BackColor = Color.White;
                    Font = new Font("Segoe UI", 12);
                    break;
                case themes.Modern:
                    break;
                case themes.MPGH:
                    break;
                case themes.Mumtz:
                    BackColor = Color.White;
                    Font = new Font("Segoe UI", 10);
                    break;
                case themes.Mystic:
                    break;
                case themes.Nameless:
                    break;
                case themes.NeoBux:
                    break;
                case themes.NetSeal:
                    BackColor = Color.FromArgb(50, 50, 50);
                    break;
                case themes.New:
                    break;
                case themes.NYX:
                    Animated = true;
                    NYX_H = 25;
                    break;
                case themes.Orains:
                    break;
                case themes.Origin:
                    break;
                case themes.Paladin:
                    break;
                case themes.Patrick:
                    TransparencyKey = Color.Fuchsia;
                    break;
                case themes.Perplex:
                    break;
                case themes.Positron:
                    break;
                case themes.Prime:
                    break;
                case themes.Purity:
                    break;
                case themes.Qube:
                    TransparencyKey = Color.Fuchsia;
                    break;
                case themes.Reactor:
                    break;
                case themes.Recon:
                    break;
                case themes.Redwagon:
                    break;
                case themes.Redemption:
                    break;
                case themes.Resizable:
                    Resizable_Animation();
                    break;
                case themes.Rockstar:
                    break;
                case themes.Sasi:
                    TransparencyKey = Color.Fuchsia;
                    BackColor = Color.FromArgb(239, 254, 213);
                    Font = new Font("Century Gothic", 11);
                    break;
                case themes.Secure:
                    Font = new Font("Verdana", 8.25f);
                    ForeColor = Color.Black;
                    BackColor = Color.Black;
                    TransparencyKey = Color.Fuchsia;
                    MoveHeight = 20;
                    break;
                case themes.Sharp:
                    break;
                case themes.Simpla:
                    TransparencyKey = Color.Fuchsia;
                    break;
                case themes.SimpleGrey:
                    break;
                case themes.Simplistic:
                    break;
                //case themes.SimplyGray:
                //    break;
                case themes.Situation:
                    BackColor = Color.DarkSlateGray;
                    break;
                case themes.SkyBase:
                    break;
                case themes.Skype:
                    break;
                case themes.SLC:
                    break;
                case themes.Somnium:
                    break;
                case themes.Spicylips:
                    break;
                case themes.Steam:
                    break;
                case themes.SteamAlt:
                    BackColor = Color.FromArgb(44, 42, 40);
                    break;
                case themes.Storm:
                    break;
                case themes.Studio:
                    BackColor = Color.FromArgb(40, 60, 90);
                    break;
                case themes.Subspace:
                    TransparencyKey = Color.Fuchsia;
                    BackColor = Color.FromArgb(30, 30, 30);
                    Header = 30;
                    break;
                case themes.Sugar:
                    TransparencyKey = Color.Fuchsia;
                    BackColor = Color.FromArgb(247, 249, 254);
                    Font = new Font("Century Gothic", 11);
                    break;
                case themes.TeamViewer:
                    break;
                case themes.Tech:
                    break;
                case themes.Teen:
                    BackColor = Color.FromArgb(50, 50, 50);
                    break;
                case themes.Tennis:
                    break;
                case themes.TheBlack:
                    break;
                case themes.Thief:
                    break;
                case themes.Twitch:
                    break;
                case themes.Ubuntu:
                    break;
                case themes.Uclear:
                    break;
                case themes.Uplay:
                    break;
                case themes.VTheme:
                    break;
                case themes.Visceral:
                    break;
                case themes.Vitality:
                    break;
                case themes.Vs:
                    break;
                case themes.White:
                    break;
                case themes.Winter:
                    break;
                case themes.Xbox:
                    BackColor = Color.FromArgb(20, 20, 20);
                    MoveHeight = 20;
                    TransparencyKey = Color.Fuchsia;
                    break;
                case themes.Xtreme:
                    TransparencyKey = Color.Fuchsia;
                    BackColor = Color.FromArgb(30, 30, 30);
                    Header = 30;
                    break;
                case themes.xVisual:
                    break;
                case themes.Youtube:
                    Font = new Font("Verdana", 8.25f);
                    ForeColor = Color.White;
                    BackColor = Color.White;
                    TransparencyKey = Color.Fuchsia;
                    MoveHeight = 20;
                    break;
                case themes.Zeus:
                    Font = new Font("Candara", 8, FontStyle.Bold);
                    break;
                default:
                    break;
            }

        }

    }
}