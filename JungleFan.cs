using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace astro.Items.Weapons
{
    public class JungleFan : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Aztec Jungle Fan");
            Tooltip.SetDefault("This fan was once used by ancient Aztecs long ago and holds the power to destroy entire civilizations in one sweep");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.damage = 79;
            item.useTime = 11;
            item.useAnimation = 11;
            item.ranged = true;
            item.knockBack = 0;
            item.noUseGraphic = true;
            item.rare = 7;
            item.useAmmo = 0;
            item.useStyle = 1;
            item.autoReuse = true;
            item.width = 28;
            item.height = 28;
            item.shoot = mod.ProjectileType("AztecSpore");
            item.shootSpeed = 23f;
            item.value = 70000;
            item.UseSound = SoundID.Item1;

        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = Main.rand.Next(13, 17);
            float rotation = MathHelper.ToRadians(Main.rand.Next(15, 20));
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(player.Center, perturbedSpeed, Type: mod.ProjectileType("AztecSpore"), Damage: 79, KnockBack: 0, player.whoAmI);
            }
            return false;
        }
    }
}
