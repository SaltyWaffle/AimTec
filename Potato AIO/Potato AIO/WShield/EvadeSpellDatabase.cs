﻿// Copyright 2014 - 2014 Esk0r
// EvadeSpellDatabase.cs is part of Evade.
// 
// Evade is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Evade is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Evade. If not, see <http://www.gnu.org/licenses/>.

// GitHub: https://github.com/Esk0r/LeagueSharp/blob/master/Evade

namespace Potato_AIO.WShield
{
    #region

    using Aimtec;

    using System.Collections.Generic;

    #endregion

    internal class EvadeSpellDatabase
    {
        public static List<EvadeSpellData> Spells = new List<EvadeSpellData>();

        static EvadeSpellDatabase()
        {

            if (ObjectManager.GetLocalPlayer().ChampionName == "Skarner")
            {

                Spells.Add(new EvadeSpellData
                {
                    Name = "SionW",
                    Slot = SpellSlot.W,
                    Range = 700,
                    Delay = 200,
                    Speed = int.MaxValue,
                    _dangerLevel = 1
                });
            }
            if (ObjectManager.GetLocalPlayer().ChampionName == "Sion")
            {

                Spells.Add(new EvadeSpellData
                {
                    Name = "SkarnerExoskeleton",
                    Slot = SpellSlot.W,
                    Range = 500,
                    Delay = 200,
                    Speed = int.MaxValue,
                    _dangerLevel = 1
                });
            }
            if (ObjectManager.GetLocalPlayer().ChampionName == "Nocturne")
            {

                Spells.Add(new EvadeSpellData
                {
                    Name = "NocturneShroudofDarkness",
                    Slot = SpellSlot.W,
                    Range = 500,
                    Delay = 300,
                    Speed = int.MaxValue,
                    _dangerLevel = 1
                });
            }
            if (ObjectManager.GetLocalPlayer().ChampionName == "JarvanIV")
            {

                Spells.Add(new EvadeSpellData
                {
                    Name = "JarvanIVGoldenAegis",
                    Slot = SpellSlot.W,
                    Range = 625,
                    Delay = 300,
                    Speed = int.MaxValue,
                    _dangerLevel = 1
                });
            }
        }
    }
}
