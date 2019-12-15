using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace astro.Items.Weapons
{
    public class SunsteelRPG : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sunsteel Grenade Launcher");
        }

        public override void SetDefaults()
        {
            item.damage = 29;
            item.ranged = true;
            item.width = 54;
            item.height = 22;
            item.autoReuse = false;
            item.useAmmo = AmmoID.Rocket;
        }
    }
}