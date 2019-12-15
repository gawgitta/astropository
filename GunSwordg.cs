using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace astro.Items.Weapons
{
    public class GunSwordg : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gun Sword (Gun Mode)" +
                "\nManufacturer is not responsible for Death, Dismemberment, Injury, or Summoning of the Eldritch Gods as a result of this product");
        }
        bool IDontKnowIsIt = true;
        public override void SetDefaults()
        {
            item.rare = 5;
            item.damage = 77;
            item.ranged = IDontKnowIsIt/*?*/;
            item.useAmmo = AmmoID.Bullet;
            item.knockBack = 0;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe1 = new ModRecipe(mod);
            recipe1.AddIngredient(ItemID.Excalibur, 1);
            recipe1.AddIngredient(ItemID.IllegalGunParts, 1);
            recipe1.AddIngredient(ItemID.SoulofFright, 3);
            recipe1.AddTile(TileID.DemonAltar);
            recipe1.SetResult(this);
            recipe1.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(mod.ItemType("GunSwords"), 1);
            recipe2.SetResult(this);
            recipe2.AddRecipe();
        }
    }
}
