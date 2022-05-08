using TheConfectionRebirth.Items;
using TheConfectionRebirth.Tiles;
using TheConfectionRebirth.Dusts;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.Utilities;
using Terraria.Audio;

namespace TheConfectionRebirth
{
	public class ConfectionPlayer : ModPlayer
	{
	   public bool RollerCookiePet;
	   public bool CreamsandWitchPet;
	   public bool minitureCookie;
	   public bool littleMeawzer;
	   public bool miniGastropod;
	   public bool flyingGummyFish;
	   public bool birdnanaLightPet;
	   public bool MeawzerPet;
	   public bool DudlingPet;
	   public bool FoxPet;
	   
	   public Projectile DimensionalWarp;
	
       public bool ZoneConfection;
	   
	   public override void ResetEffects() {
			RollerCookiePet = false;
			CreamsandWitchPet = false;
			minitureCookie = false;
			littleMeawzer = false;
			miniGastropod = false;
			flyingGummyFish = false;
			birdnanaLightPet = false;
			MeawzerPet = false;
			DudlingPet = false;
			FoxPet = false;
	   }
		
		public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
			if (damageSource.SourceCustomReason == "DimensionSplit")
			{
				WeightedRandom<string> deathmessage = new WeightedRandom<string>();
				deathmessage.Add(Player.name + " got lost in a rift.");
				deathmessage.Add(Player.name + " was split like a banana.");
				deathmessage.Add(Player.name + " tried to banana all the time.");
				deathmessage.Add(Player.name + " got split between dimensions.");
				damageSource = PlayerDeathReason.ByCustomReason(deathmessage);
				return true;
			}
			return base.PreHurt(pvp, quiet, ref damage, ref hitDirection, ref crit, ref customDamage, ref playSound, ref genGore, ref damageSource);
		}
	}
}