using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.Characters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xTile.Dimensions;

namespace StardewValley.Mods.DogMod
{
    class ModDriver : Mod
    {
        Dog happiestDoggo;

        public override void Entry(IModHelper helper)
        {
            GameEvents.UpdateTick += GameEvents_UpdateTick;
        }

        private void GameEvents_UpdateTick(object sender, EventArgs e)
        {
            if (!Game1.hasLoadedGame)
                return;

            if (happiestDoggo == null)
            {
                var npcs = Game1.currentLocation.getCharacters();
                var doggo = npcs.FirstOrDefault(npc => npc is Dog);

                if (doggo != null)
                    happiestDoggo = doggo as Dog;
            }
        }
    }
}
