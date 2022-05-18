using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheConfectionRebirth.Dusts;

namespace TheConfectionRebirth.Tiles
{
    public class CreamstoneBrick : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileMerge[Type][Mod.Find<ModTile>("CookieBlock").Type] = true;
            Main.tileMerge[Type][Mod.Find<ModTile>("CreamGrass").Type] = true;
            Main.tileMerge[Type][Mod.Find<ModTile>("CreamWood").Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = false;
            DustType = ModContent.DustType<CreamDust>();
            ItemDrop = ModContent.ItemType<Items.Placeable.CreamstoneBrick>();
            AddMapEntry(new Color(180, 156, 103));

            SoundType = SoundID.Tink;
            SoundStyle = 1;
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
    }
}