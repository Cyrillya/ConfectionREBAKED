using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheConfectionRebirth.Items.Placeable
{
    public class SacchariteBrick : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Saccharite Block");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }

        public override void SetDefaults()
        {
            Item.width = 12;
            Item.height = 12;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.SacchariteBrick>();
        }

        public override void AddRecipes()
        {
            CreateRecipe(5).AddIngredient(ModContent.ItemType<Items.Placeable.Saccharite>(), 2).Register();
        }
    }
}
