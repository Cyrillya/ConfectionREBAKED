using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace TheConfectionRebirth.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class BirthdaySuit : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Birthday Suit");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 18;
			Item.height = 18;
			Item.vanity = true;
			Item.rare = ItemRarityID.White;
		}
	}
}