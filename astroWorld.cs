using astro.Items;
using astro.Tiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;
using static Terraria.ModLoader.ModContent;

namespace astro
{
    public class astroWorld : ModWorld
    {
        private const int saveVersion = 0;
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (ShiniesIndex == -1)
            {
                return;
            }
            tasks.Insert(ShiniesIndex + 1, new PassLegacy("Sunsteel Ores", delegate (GenerationProgress progress)
            {
                progress.Message = "Creating more ore";

                for (int x = 0; x < Main.maxTilesX; x++)
                {
                    for (int y = 20; y < Main.worldSurface * 0.35f - 10; y++)
                    {
                        WorldGen.TileRunner(x, y, (double)WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), TileType<SunsteelOre>(), false, 0f, 0f, false, true);
                    }
                }
            }));
        }
    }
}