using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace astro.Items.Bars
{
    public class SunsteelBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sunsteel Bar");
            Tooltip.SetDefault("Its warmth and power emanate a soothing vibe");
        }

        public override void SetDefaults()
        {
            item.rare = 3;
            item.maxStack = 999;
            item.value = 9250;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SunsteelOre"), 7);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
