using System.IO;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace TheConfectionRebirth
{
    public class ConfectionWorld : ModSystem
    {
        internal static int[] ConfectionSurfaceBG = new int[4] { -1, -1, -1, -1};

        public override void SaveWorldData(TagCompound tag)
        {
            tag[nameof(ConfectionSurfaceBG)] = ConfectionSurfaceBG;
        }

        public override void LoadWorldData(TagCompound tag)
        {
            if (tag.ContainsKey(nameof(ConfectionSurfaceBG)))
                ConfectionSurfaceBG = tag.GetIntArray(nameof(ConfectionSurfaceBG));
        }

        public override void NetSend(BinaryWriter writer)
        {
			writer.Write(ConfectionSurfaceBG[0]);
            writer.Write(ConfectionSurfaceBG[1]);
            writer.Write(ConfectionSurfaceBG[2]);
            writer.Write(ConfectionSurfaceBG[3]);
        }

        public override void NetReceive(BinaryReader reader)
        {
            ConfectionSurfaceBG = new int[4];
			ConfectionSurfaceBG[0] = reader.ReadInt32();
            ConfectionSurfaceBG[1] = reader.ReadInt32();
            ConfectionSurfaceBG[2] = reader.ReadInt32();
            ConfectionSurfaceBG[3] = reader.ReadInt32();
        }
    }
}