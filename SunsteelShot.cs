using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace astro.Items.Weapons
{
    public class SunsteelShot : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sunsteel Shotgun");
        }

        public override void SetDefaults()
        {
            item.damage = 19;
            item.ranged = true;
            item.width = 54;
            item.height = 22;
            item.autoReuse = false;
            item.useAmmo = AmmoID.Bullet;
            item.noMelee = true;
            item.knockBack = 4;
            item.shoot = 10;
            item.shootSpeed = 16f;
            item.useStyle = 5;
            item.UseSound = SoundID.Item11;
            item.useTime = 16;
            item.useAnimation = 16;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SunsteelBar"), 7);
            recipe.AddTile(TileID.SkyMill);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 4 + Main.rand.Next(2);
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, Damage: 19, 4, player.whoAmI);
            }
            return false;
        }
    }
}