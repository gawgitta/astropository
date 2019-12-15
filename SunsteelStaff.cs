using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace astro.Items.Weapons
{
    public class SunsteelStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sunsteel Staff");
            Tooltip.SetDefault("Sprays a stream of pure mana");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.damage = 24;
            item.magic = true;
            item.noMelee = true;
            item.value = 22000;
            item.knockBack = 2;
            item.autoReuse = true;
            item.useTurn = true;
            item.shoot = mod.ProjectileType("ManaSpray");
            item.shootSpeed = 16f;
            item.useTime = 16;
            item.useStyle = 5;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SunsteelBar"), 8);
            recipe.AddTile(TileID.SkyMill);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
