using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;
using Terraria.Audio;
using Microsoft.Xna.Framework;

namespace HelloWorld.Items
{
	/// <summary>
	/// UI Launcher item.
	/// </summary>
	public class UILauncher : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault ("UI Launcher");
			Tooltip.SetDefault ("Use to open/close a UI Menu.");
		}
		public override void SetDefaults()
		{
			item.damage = 0;
			item.melee = false;
			item.width = 16;
			item.height = 16;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 0;
			item.value = 42;
			item.rare = 2;
			// item.UseSound = SoundID.MenuOpen;
			// item.UseSound = new LegacySoundStyle (SoundID.MenuOpen, SoundID.MenuOpen, Terraria.Audio.SoundType.Sound);
			item.UseSound = null;
			item.autoReuse = false;
		}
		// https://tmodloader.github.io/tModLoader/html/class_terraria_1_1_mod_loader_1_1_mod_item.html#a69d1426d0848927a3d7e25c023d90ddc
		public override bool UseItem(Player player)
		{
			if (HelloWorld.MyUIVisible) {
				HelloWorld.HideMyUI ();
				Main.PlaySound (new LegacySoundStyle (SoundID.MenuClose, SoundID.MenuClose, Terraria.Audio.SoundType.Sound));
			} else {
				HelloWorld.ShowMyUI ();
				Main.PlaySound (new LegacySoundStyle (SoundID.MenuOpen, SoundID.MenuOpen, Terraria.Audio.SoundType.Sound));
			}
			return true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe (mod);
			recipe.AddIngredient (ItemID.DirtBlock, 1);
			recipe.AddIngredient (ItemID.Wood);
			recipe.AddTile (TileID.WorkBenches);
			recipe.SetResult (this);
			recipe.AddRecipe ();
		}
	}
}

