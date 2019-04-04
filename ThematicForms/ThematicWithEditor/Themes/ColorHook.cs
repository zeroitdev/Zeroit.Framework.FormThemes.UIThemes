// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="ColorHook.cs" company="Zeroit Dev Technologies">
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
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {
            //void : Add details to it

            switch (Theme)
            {
                case themes.EightBall:
                    break;
                case themes.Adobe:
                    break;
                case themes.Advanced_System:

                    break;
                case themes.Advantium:
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
                    TransparencyKey = Color.Fuchsia;
                    BackColor = Color.Black;
                    Font = new Font("Century Gothic", 9);
                    SetColor("Text", Color.DeepSkyBlue);
                    Border = Color.Fuchsia;
                    break;
                case themes.AVG:
                    break;
                case themes.BasicCode:
                    break;
                case themes.BetaBlue:
                    break;
                case themes.Beyond:
                    break;
                case themes.Bionic:
                    break;
                case themes.BitDefender:
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
                    break;
                case themes.Crystal:
                    break;
                case themes.Cypher:
                    Cypher_OnHandleCreated();
                    break;
                //case themes.CypherX:
                //    break;
                case themes.DarkMatter:
                    break;
                case themes.Design:
                    SendToBack();
                    Padding = new Padding(2, 36, 2, 2);
                    Font = new Font("Verdana", 10, FontStyle.Regular);
                    break;
                case themes.Destiny:
                    ForeColor = Color.Aquamarine;
                    BackColor = Color.Black;
                    MoveHeight = 20;
                    TransparencyKey = Color.Fuchsia;
                    Font F = new Font("Verdana", 7);
                    Font = F;
                    break;
                case themes.Deumos:
                    BackColor = Deumos_C1;
                    break;
                case themes.Doom:
                    break;
                case themes.Drone:
                    break;
                case themes.Earn:
                    break;
                case themes.Effectual:
                    break;
                case themes.Electric:
                    break;
                case themes.Electrified:
                    break;
                case themes.Elegant:
                    break;
                case themes.Element:
                    break;
                case themes.Empire:
                    break;
                case themes.Empress:
                    break;
                case themes.ETheme:
                    break;
                case themes.Evolve:
                    break;
                case themes.Excision:
                    break;
                case themes.Exotic:
                    break;
                case themes.Facebook:
                    break;
                case themes.Festus:
                    break;
                case themes.FlatUI:
                    break;
                case themes.Flow:
                    break;
                case themes.Frog:
                    break;
                case themes.Fusion:
                    break;
                case themes.Future:
                    break;
                case themes.GTheme:
                    break;
                case themes.GameBooster:
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
                    break;
                case themes.Modern:
                    break;
                case themes.MPGH:
                    break;
                case themes.Mumtz:
                    break;
                case themes.Mystic:
                    break;
                case themes.Nameless:
                    break;
                case themes.NeoBux:
                    break;
                case themes.NetSeal:
                    break;
                case themes.New:
                    break;
                case themes.NYX:
                    break;
                case themes.Orains:
                    break;
                case themes.Origin:
                    break;
                case themes.Paladin:
                    break;
                case themes.Patrick:
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
                    break;
                case themes.Reactor:
                    break;
                case themes.Recon:
                    break;
                case themes.Redwagon:
                    break;
                case themes.Redemption:
                    break;
                case themes.Rockstar:
                    break;
                case themes.Sasi:
                    break;
                case themes.Secure:
                    break;
                case themes.Sharp:
                    break;
                case themes.Simpla:
                    break;
                case themes.SimpleGrey:
                    break;
                case themes.Simplistic:
                    break;
                //case themes.SimplyGray:
                //    break;
                case themes.Situation:
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
                case themes.Storm:
                    break;
                case themes.Studio:
                    break;
                case themes.Subspace:
                    break;
                case themes.Sugar:

                    break;
                case themes.TeamViewer:
                    break;
                case themes.Tech:
                    break;
                case themes.Teen:
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
                    break;
                case themes.Xtreme:
                    break;
                case themes.xVisual:
                    break;
                case themes.Youtube:
                    break;
                case themes.Zeus:
                    break;
                default:
                    break;
            }
        }

    }
}
