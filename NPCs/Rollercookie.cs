using TheConfectionRebirth.Items.Banners;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Bestiary;
using TheConfectionRebirth.Biomes;

namespace TheConfectionRebirth.NPCs
{
	public class Rollercookie : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Roller Cookie");  
		}

		public override void SetDefaults() {
			NPC.width = 44;
			NPC.height = 44;
			NPC.damage = 58;
			NPC.defense = 17;
			NPC.lifeMax = 360;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath6;
			NPC.value = 60f;
			// npc.noGravity = false;
			// npc.noTileCollide = false;
			NPC.knockBackResist = 0.5f;
			NPC.aiStyle = 26;
			AIType = NPCID.Unicorn;
			Banner = NPC.type;
			BannerItem = ModContent.ItemType<RollerCookieBanner>();
			SpawnModBiomes = new int[1] { ModContent.GetInstance<ConfectionSurfaceBiome>().Type };
		}
		
		public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry) {
			bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[] {

				new FlavorTextBestiaryInfoElement("A cookie brought to life in the magical biome that was created from the spirits of light and night")
			});
		}
		
		public override void AI()
		{
			NPC.rotation += NPC.velocity.X * 0.05f;
		}
     }	
}
