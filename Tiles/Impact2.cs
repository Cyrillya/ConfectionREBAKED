using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ObjectData;


namespace TheConfectionRebirth.Tiles
{
    public class Impact2 : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.newTile.Height = 4;
            TileObjectData.newTile.Width = 6;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 16, 16 };
            Main.tileFrameImportant[Type] = true;
            TileObjectData.addTile(Type);
            ModTranslation name = CreateMapEntryName();
            AddMapEntry(new Color(120, 85, 60), name);
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 48, 32, ModContent.ItemType<Items.Placeable.Impact2>());
        }
    }
}