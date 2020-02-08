using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
namespace HelloWorld.NPCs
{
	/// <summary>
	/// An NPC named Cubiny.
	/// </summary>
	public class Cubiny : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault ("Cubiny");
		}
		public override void SetDefaults()
		{
			// npc.friendly = true;
			npc.width = 18;
			npc.height = 40;
			npc.damage = 1;
			npc.defense = 10;
			npc.lifeMax = 40;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 15.4f;
			npc.knockBackResist = 15.2f;
			npc.aiStyle = 3;
			Main.npcFrameCount [npc.type] = Main.npcFrameCount [NPCID.Zombie];
			aiType = NPCID.Bunny;
			animationType = NPCID.Zombie;
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldDayGrassCritter.Chance * 0.75f;
		}
		public override void NPCLoot()
		{
			Item.NewItem ((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType ("UILauncher"), Main.rand.Next (5, 10));
		}
	}
}