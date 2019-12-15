using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace astro.Projectiles
{
	public class ManaSpray : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mana Spray");
		}

		public override void SetDefaults()
		{
			projectile.width = 6;
			projectile.height = 6;
			projectile.friendly = true;
			projectile.alpha = 255;
			projectile.penetrate = -1;
			projectile.extraUpdates = 2;
			projectile.tileCollide = true;
			projectile.ignoreWater = true;
		}

		public override void AI()
		{
			int dustType = mod.DustType("ManaSpray");
			if (projectile.timeLeft > 133)
			{
				projectile.timeLeft = 133;
			}
			if (projectile.ai[0] > 7f)
			{
				float dustScale = 1f;
				if (projectile.ai[0] == 8f)
				{
					dustScale = 0.2f;
				}
				else if (projectile.ai[0] == 9f)
				{
					dustScale = 0.4f;
				}
				else if (projectile.ai[0] == 10f)
				{
					dustScale = 0.6f;
				}
				else if (projectile.ai[0] == 11f)
				{
					dustScale = 0.8f;
				}
				projectile.ai[0] += 1f;
				for (int i = 0; i < 1; i++)
				{
					int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 15, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 100, default(Color), 1f);
					Dust dust = Main.dust[dustIndex];
					dust.noGravity = true;
					dust.scale *= 1.75f;
					dust.velocity.X = dust.velocity.X * 2f;
					dust.velocity.Y = dust.velocity.Y * 2f;
					dust.scale *= dustScale;
				}
			}
			else
			{
				projectile.ai[0] += 1f;
			}
			projectile.rotation += 0.3f * (float)projectile.direction;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.ManaSickness, 120, false);
		}

		public override void OnHitPvp(Player target, int damage, bool crit)
		{
			target.AddBuff(BuffID.ManaSickness, 120, false);
		}
	}
}