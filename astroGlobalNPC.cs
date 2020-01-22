using Terraria;
using Terraria.ModLoader;

namespace astro.NPCs
{
	public class astroGlobalNPC : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (npc.type == 35 || npc.type == 36 || npc.type == 222 || npc.type == 113) //Skeletron  Hands, Skeletron, Queen Bee, or WoF
			{
				Item.NewItem(npc.getRect(), mod.ItemType("ISOre"), Main.rand.Next(45, 95));
			} 
		}
	}

}