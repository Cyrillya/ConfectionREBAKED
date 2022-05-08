using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace TheConfectionRebirth.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class NeapoliniteHeadgear : ModItem
	{
		public override void SetStaticDefaults() {
		Tooltip.SetDefault("6% Increased Magic Damage"
				+ "\nIncreased Max manna by 80");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 18;
			Item.height = 18;
			Item.value = 10000;
			Item.rare = ItemRarityID.LightRed;
			Item.defense = 4;
		}
	}
}