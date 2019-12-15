using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace astro.Projectiles
{
    public class SunsteelBlast : ModProjectile
    {
        public override string Texture => "Terraria/Projectile_" + ProjectileID.Starfury; //Setting Starfury texture

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sunsteel Blast");
            Main.projFrames[projectile.type] = Main.projFrames[ProjectileID.Starfury];
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Starfury);
            aiType = ProjectileID.Starfury;
            projectile.timeLeft = 120;
        }

        public override bool PreKill(int timeLeft)
        {
            projectile.type = ProjectileID.Starfury;
            return true;
        }
    }
}