using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace astro.Items
{
    public class SunsteelSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sunsteel Zweihander");
            Tooltip.SetDefault("The explosive might of the sun fills your nerves");            
        }

        public override void SetDefaults()
        {
            item.damage = 28;
            item.melee = true;
            item.width = 40;
            item.height = 44;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 100000;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = ProjectileID.Starfury;
            item.shootSpeed = 16;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SunplateBlock, 8);
            recipe.AddTile(TileID.SkyMill);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 3;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Projectile.NewProjectile(Main.MouseWorld.X + Main.rand.Next(-10, 10), Main.MouseWorld.Y + Main.rand.Next(-10, 10), SpeedX: Main.rand.NextFloat(-16, 16), SpeedY: Main.rand.NextFloat(-16,16), Type: mod.ProjectileType("SunsteelBlast"), Damage: 28, KnockBack: 6, Owner: player.whoAmI);
            }
            return false;
        }
    }
}