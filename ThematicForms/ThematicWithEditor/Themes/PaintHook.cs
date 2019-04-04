// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="PaintHook.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
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
        /// Paints the hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs" /> instance containing the event data.</param>
        protected override void PaintHook(PaintEventArgs e)
        {
            switch (Theme)
            {
                case themes.EightBall:
                    EightBall_PaintHook(e);
                    break;

                case themes.Adobe:
                    Adobe_PaintHook();
                    break;

                case themes.Advanced_System:
                    AdvancedSystem_Hook(e);
                    break;
                case themes.Advantium:
                    Advantium_PaintHook(e);
                    break;

                case themes.Alpha:
                    Alpha_PaintHook(e);
                    break;

                case themes.Angel:
                    Angel_PaintHook(e);
                    break;

                case themes.Anom:
                    Anom_PaintHook(e);
                    break;
                case themes.Aryan:
                    Aryan_PaintHook(e);
                    break;
                case themes.Atrocity:
                    Atrocity_PaintHook(e);
                    break;
                case themes.Avatar:
                    Avatar_PaintHook(e);
                    break;
                case themes.AVG:
                    AVG_PaintHook(e);
                    break;
                case themes.BasicCode:
                    BasicCode_PaintHook(e);
                    break;
                case themes.BetaBlue:
                    BetaBlue_PaintHook(e);
                    break;
                case themes.Beyond:
                    Beyond_PaintHook(e);
                    break;
                case themes.Bionic:
                    Bionic_OnPaint(e);
                    break;
                case themes.BitDefender:
                    BitDefender_PaintHook(e);
                    break;
                case themes.BlackShades:
                    BlackShades_OnPaint(e);
                    break;
                case themes.Bloody:
                    Bloody_PaintHook(e);
                    break;
                    //case themes.BlueAndWhite:
                    //    //BlueAndWhite_PaintHook(e);
                    //    BaWGUI_PaintHook(e);
                    break;
                case themes.Blue:
                    Blue_PaintHook(e);
                    break;
                case themes.Booster:
                    Booster_PaintHook(e);
                    break;
                case themes.Border:
                    Border_PaintHook(e);
                    break;
                case themes.Bullion:
                    Bullion_OnPaint(e);
                    break;
                case themes.ButterScotch:
                    ButterScotch_PaintHook(e);
                    break;
                case themes.CarbonFibre:
                    CarbonFibre_PaintHook(e);
                    break;
                case themes.Chrome:
                    Chrome_PaintHook(e);
                    break;
                case themes.Clarity:
                    Clarity_PaintHook(e);
                    break;
                case themes.Classic:
                    Classic_PaintHook(e);
                    break;
                case themes.clsNeoBux:
                    clsNeoBux_PaintHook(e);
                    break;
                case themes.CocaCola:
                    CocaCola_PaintHook(e);
                    break;
                case themes.Complex:
                    Complex_PaintHook(e);
                    break;
                case themes.Crystal:
                    Crystal_PaintHook(e);
                    break;
                case themes.Cypher:
                    Cypher_PaintHook(e);
                    break;
                //case themes.CypherX:
                //    break;
                case themes.DarkMatter:
                    DarkMatter_PaintHook(e);
                    break;
                case themes.DarkMatterAlt:
                    DarkMatterAlt_PaintHook(e);
                    break;
                case themes.Design:
                    Design_PaintHook(e);
                    break;
                case themes.Destiny:
                    Destiny_PaintHook(e);
                    break;
                case themes.Deumos:
                    Deumos_PaintHook(e);
                    break;
                case themes.Doom:
                    Doom_PaintHook(e);
                    break;
                case themes.Drone:
                    Drone_PaintHook(e);
                    break;
                case themes.Earn:
                    Earn_PaintHook(e);
                    break;
                case themes.Effectual:
                    Effectual_PaintHook(e);
                    break;
                case themes.Electric:
                    Electric_PaintHook(e);
                    break;
                case themes.Electrified:
                    Electrified_PaintHook(e);
                    break;
                case themes.Elegant:
                    Elegant_PaintHook(e);
                    break;
                case themes.Element:
                    Element_PaintHook(e);
                    break;
                case themes.Empire:
                    Empire_PaintHook(e);
                    break;
                case themes.Empress:
                    Empress_PaintHook(e);
                    break;
                case themes.ETheme:
                    ETheme_PaintHook(e);
                    break;
                case themes.Evolve:
                    Evolve_PaintHook(e);
                    break;
                case themes.Excision:
                    Excision_PaintHook(e);
                    break;
                case themes.Exotic:
                    Exotic_PaintHook(e);
                    break;
                case themes.Facebook:
                    Facebook_Paint(e);
                    break;
                case themes.Festus:
                    Festus_PaintHook(e);
                    break;
                case themes.FlatUI:
                    FlatUI_Paint(e);
                    break;
                case themes.Flow:
                    Flow_PaintHook(e);
                    break;
                case themes.Frog:
                    Frog_PaintHook(e);
                    break;
                case themes.Fusion:
                    Fusion_PaintHook(e);
                    break;
                case themes.Future:
                    Future_PaintHook(e);
                    break;
                case themes.GTheme:
                    GTheme_PaintHook(e);
                    break;
                case themes.GameBooster:
                    GameBooster_PaintHook(e);
                    break;
                case themes.Genuine:
                    Genuine_PaintHook(e);
                    break;
                case themes.Ghostv2:
                    Ghostv2_PaintHook(e);
                    break;
                case themes.GhostTheme:
                    Ghost_PaintHook(e);
                    break;
                case themes.Gray:
                    Gray_PaintHook(e);
                    break;
                case themes.Green:
                    Green_PaintHook(e);
                    break;
                case themes.Hacker:
                    Hacker_PaintHook(e);
                    break;
                case themes.Hero:
                    Hero_PaintHook(e);
                    break;
                case themes.Hex:
                    Hex_PaintHook(e);
                    break;
                case themes.HF:
                    HF_PaintHook(e);
                    break;
                case themes.Hura:
                    Huratheme_PaintHook(e);
                    break;
                case themes.iBlack:
                    iBlack_PaintHook(e);
                    break;
                case themes.Influence:
                    Influence_Paint(e);
                    break;
                case themes.Influx:
                    Influx_PaintHook(e);
                    break;
                case themes.InnerDarkness:
                    InnerDarkness_PaintHook(e);
                    break;
                case themes.Insomia:
                    Insomia_PaintHook(e);
                    break;
                case themes.Intel:
                    Intel_PaintHook(e);
                    break;
                case themes.JTheme:
                    JTheme_PaintHook(e);
                    break;
                case themes.Knight:
                    Knight_PaintHook(e);
                    break;
                case themes.Light:
                    Light_PaintHook(e);
                    break;
                case themes.Login:
                    Login_PaintHook(e);
                    break;
                case themes.Loyal:
                    Loyal_PaintHook(e);
                    break;
                case themes.Meph:
                    MephPaintHook(e);
                    break;
                case themes.Metal:
                    Metal_PaintHook(e);
                    break;
                case themes.MetroUI:
                    MetroUI_PaintHook(e);
                    break;
                case themes.MetroDisk:
                    MetroDisk_PaintHook(e);
                    break;
                case themes.Modern:
                    Modern_PaintHook(e);
                    break;
                case themes.MPGH:
                    MPGH_PaintHook(e);
                    break;
                case themes.Mumtz:
                    Mumtz_PaintHook(e);
                    break;
                case themes.Mystic:
                    Mystic_PaintHook(e);
                    break;
                case themes.Nameless:
                    Nameless_PaintHook(e);
                    break;
                case themes.NeoBux:
                    NeoBux_PaintHook(e);
                    break;
                case themes.NetSeal:
                    NetSeal_PaintHook(e);
                    break;
                case themes.New:
                    NewTheme_PaintHook(e);
                    break;
                case themes.NYX:
                    NYX_PaintHook(e);
                    break;
                case themes.Orains:
                    Orains_PaintHook(e);
                    break;
                case themes.Origin:
                    Origin_PaintHook(e);
                    break;
                case themes.Paladin:
                    PalaDinV2_PaintHook(e);
                    break;
                case themes.Patrick:
                    Patrick_PaintHook(e);
                    break;
                case themes.Perplex:
                    Perplex_Paint(e);
                    break;
                case themes.Positron:
                    Positron_PaintHook(e);
                    break;
                case themes.Prime:
                    Prime_PaintHook(e);
                    break;
                case themes.Purity:
                    Purity_PaintHook(e);
                    break;
                case themes.Qube:
                    Qube_PaintHook(e);
                    break;
                case themes.Reactor:
                    Reactor_PaintHook(e);
                    break;
                case themes.Recon:
                    Recon_PaintHook(e);
                    break;
                case themes.Redwagon:
                    RedDwagon_PaintHook(e);
                    break;
                case themes.Redemption:
                    Redemption_PaintHook(e);
                    break;
                case themes.Resizable:
                    Resizable_PaintHook(e);
                    break;
                case themes.Rockstar:
                    Rockstar_PaintHook(e);
                    break;
                case themes.Sasi:
                    Sasi_PaintHook(e);
                    break;
                case themes.Secure:
                    Secure_PaintHook(e);
                    break;
                case themes.Sharp:
                    Sharp_Paint(e);
                    break;
                case themes.Simpla:
                    Simpla_PaintHook(e);
                    break;
                case themes.SimpleGrey:
                    SimplyGray_PaintHook(e);
                    break;
                case themes.Simplistic:
                    Simplistic_PaintHook(e);
                    break;
                //case themes.SimplyGray:
                //    break;
                case themes.Situation:
                    Situation_PaintHook(e);
                    break;
                case themes.SkyBase:
                    SkyBase_PaintHook(e);
                    break;
                case themes.Skype:
                    Skype_PaintHook(e);
                    break;
                case themes.SLC:
                    SLC_PaintHook(e);
                    break;
                case themes.Somnium:
                    Somnium_PaintHook(e);
                    break;
                case themes.Spicylips:
                    SpicyLips_PaintHook(e);
                    break;
                case themes.Steam:
                    Steam_PaintHook(e);
                    break;
                case themes.SteamAlt:
                    SteamAlt_PaintHook(e);
                    break;
                case themes.Storm:
                    Storm_PaintHook(e);
                    break;
                case themes.Studio:
                    Studio_PaintHook(e);
                    break;
                case themes.Subspace:
                    Subspace_PaintHook(e);
                    break;
                case themes.Sugar:
                    Sugar_PaintHook(e);
                    break;
                case themes.TeamViewer:
                    TeamViewer_PaintHook(e);
                    break;
                case themes.Tech:
                    Tech_PaintHook(e);
                    break;
                case themes.Teen:
                    Teen_PaintHook(e);
                    break;
                case themes.Tennis:
                    Tennis_PaintHook(e);
                    break;
                case themes.TheBlack:
                    TheBlack_PaintHook(e);
                    break;
                case themes.Thief:
                    Thief_PaintHook(e);
                    break;
                case themes.Twitch:
                    Twitch_PaintHook(e);
                    break;
                case themes.Ubuntu:
                    Ubuntu_PaintHook(e);
                    break;
                case themes.Uclear:
                    Uclear_PaintHook(e);
                    break;
                case themes.Uplay:
                    Uplay_PaintHook(e);
                    break;
                case themes.VTheme:
                    VTheme_PaintHook(e);
                    break;
                case themes.Visceral:
                    Visceral_PaintHook(e);
                    break;
                case themes.Vitality:
                    Vitality_PaintHook(e);
                    break;
                case themes.Vs:
                    Vs_PaintHook(e);
                    break;
                case themes.White:
                    White_PaintHook(e);
                    break;
                case themes.Winter:
                    Winter_PaintHook(e);
                    break;
                case themes.Xbox:
                    Xbox_PaintHook(e);
                    break;
                case themes.Xtreme:
                    Xtreme_PaintHook(e);
                    break;
                case themes.xVisual:
                    xVisual_PaintHook(e);
                    break;
                case themes.Youtube:
                    Youtube_PaintHook(e);
                    break;
                case themes.Zeus:
                    Zeus_PaintHook(e);
                    break;
                default:
                    break;

            }
        }

    }
}
