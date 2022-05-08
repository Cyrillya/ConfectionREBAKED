using TheConfectionRebirth.Items.Banners;
using Microsoft.Xna.Framework;
using MonoMod.Cil;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Bestiary;
using TheConfectionRebirth.Biomes;

namespace TheConfectionRebirth.NPCs.Critters
{
	internal class ChocolateBunny : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Chocolate Bunny");
			Main.npcFrameCount[NPC.type] = Main.npcFrameCount[NPCID.Bunny];
			Main.npcCatchable[NPC.type] = true;
		}

		public override void SetDefaults() {
			NPC.CloneDefaults(NPCID.Bunny);
			NPC.catchItem = (short)ModContent.ItemType<ChocolateBunnyItem>();
			NPC.aiStyle = 7;
			NPC.friendly = true;
			AIType = NPCID.Bunny;
			AnimationType = NPCID.Bunny;
			Banner = NPC.type;
			BannerItem = ModContent.ItemType<ChocolateBunnyBanner>();
			SpawnModBiomes = new int[1] { ModContent.GetInstance<ConfectionSurfaceBiome>().Type };
		}
		
		public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry) {
			bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[] {

				new FlavorTextBestiaryInfoElement("A bunny made of pure chocolate hops around in the confection.")
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

	internal class ChocolateBunnyItem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Chocolate Bunny");
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

			Item.makeNPC = (short)ModContent.NPCType<ChocolateBunny>();
		}
	}
}
