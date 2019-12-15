using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace astro.Items.Weapons
{
    public class GunSwords : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gun Sword (Sword Mode)" +
                "\nManufacturer is not responsible for Death, Dismemberment, Injury, or Summoning of the Eldritch Gods as a result of this product");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("GunSwordg"), 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        bool IHonestlyDontKnow = true;
        public override void SetDefaults()
        {
            item.damage = 78;
            item.rare = 5;
            item.melee = IHonestlyDontKnow;
        }
    }
}
