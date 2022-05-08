using TheConfectionRebirth.Items.Banners;
using Microsoft.Xna.Framework;
using MonoMod.Cil;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheConfectionRebirth.Biomes;
using Terraria.GameContent.Bestiary;

namespace TheConfectionRebirth.NPCs.Critters
{
	internal class Pip : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Pip");
			Main.npcFrameCount[NPC.type] = Main.npcFrameCount[NPCID.Bird];
			Main.npcCatchable[NPC.type] = true;
		}

		public override void SetDefaults() {
			NPC.CloneDefaults(NPCID.Bird);
			NPC.catchItem = (short)ModContent.ItemType<PipItem>();
			NPC.aiStyle = 24;
			NPC.friendly = true;
			AIType = NPCID.Bird;
			AnimationType = NPCID.Bird;
			Banner = NPC.type;
			BannerItem = ModContent.ItemType<PipBanner>();
			SpawnModBiomes = new int[1] { ModContent.GetInstance<ConfectionSurfaceBiome>().Type };
		}
		
		public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry) {
			bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[] {

				new FlavorTextBestiaryInfoElement("A small bird found within the confection, nobody knows why it only apears in the confection.")
			});
		}

		public override bool? CanBeHitByItem(Player player, Item item) {
			return true;
		}

		public override bool? CanBeHitByProjectile(Projectile projectile) {
			return true;
		}

        //Might add gore later

		public override void OnCatchNPC(Player player, Item item) {
			item.stack = 1;

			try {
				var npcCenter = NPC.Center.ToTileCoordinates();
			}
			catch {
				return;
			}
		}

	}

	internal class PipItem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Pip");
		}

		public override void SetDefaults() {
			Item.useStyle = 1;
			Item.autoReuse = true;
			Item.useTurn = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.width = 12;
			Item.height = 12;
			Item.makeNPC = 360;
			Item.noUseGraphic = true;

			Item.makeNPC = (short)ModContent.NPCType<Pip>();
		}
	}
}
