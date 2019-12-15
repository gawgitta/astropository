using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace astro.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class SunsteelHead : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Sunsteel Mask");
			Tooltip.SetDefault("It's attracted to the rest of it's set"
				+ "\n+10% ranged damage");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 3;
			item.defense = 7;
		}

		/*public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			//return body.type == ItemType<SunsteelChest>() && legs.type == ItemType<SunsteelLegs>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "sunsteelbonus.jpg";
			player.moveSpeed += 0.15f;
		}*/

		public override void UpdateEquip(Player player)
		{
			player.rangedDamage += 0.1f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("SunsteelBar"), 30);
			recipe.AddTile(TileID.SkyMill);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}