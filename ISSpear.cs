using astro.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace astro.Items.Weapons
{
    public class ISSpear : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Igneus Pilum");
			Tooltip.SetDefault("A piercing heat like a star fills this spear");
        }
        
        public override void SetDefaults()
        {
            item.damage = 40;
            item.melee = true;
            item.noMelee = true;
            item.width = 92;
            item.height = 92;
            item.useTime = 17;
            item.useAnimation = 17;
            item.useStyle = 5;
            item.knockBack = 5;
            item.value = Item.sellPrice(gold: 1, silver: 10);
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.shoot = mod.ProjectileType("ISSpear");
            item.shootSpeed = 9f;
            item.noUseGraphic = true;
        }
    }
}
