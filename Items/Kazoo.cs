using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace TheConfectionRebirth.Items
{
    public class Kazoo : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 15;
            Item.useAnimation = 20;
            Item.useStyle = 1;
            Item.value = Item.buyPrice(gold: 1);
            Item.UseSound = new SoundStyle($"{nameof(TheConfectionRebirth)}/Sounds/Items/KazooSound")
            {
                Volume = 0.9f,
                PitchVariance = 0.2f,
                MaxInstances = 3,
            };
            Item.autoReuse = true;
        }

        public override void SetStaticDefaults()
        {
            SacrificeTotal = 1;
        }
    }
}