using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace astro.Items.Placeable
{
    public class SunsteelOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sunsteel Ore");
            Tooltip.SetDefault("It's energetic to the touch");
        }

        public override void SetDefaults()
        {
            item.damage = 28;
            item.melee = false;
            item.width = 16;
            item.height = 16;
            item.useTime = 10;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.value = 5000;
            item.rare = 1;
            item.createTile = ModContent.TileType<Tiles.SunsteelOre>();
            item.autoReuse = true;
            item.maxStack = 999;
        }
    }
}