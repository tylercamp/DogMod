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

namespace DougMod
{
    class ModRoot : Mod
    {
        Dog happiestDougie;

        public override void Entry(IModHelper helper)
        {
            GameEvents.UpdateTick += GameEvents_UpdateTick;
        }

        private void GameEvents_UpdateTick(object sender, EventArgs e)
        {
            if (!Game1.hasLoadedGame)
                return;

            if (happiestDougie == null)
            {
                var npcs = Game1.currentLocation.getCharacters();
                var dougie = npcs.FirstOrDefault(npc => npc is Dog);

                if (dougie != null)
                    happiestDougie = dougie as Dog;
            }
        }
    }
}
