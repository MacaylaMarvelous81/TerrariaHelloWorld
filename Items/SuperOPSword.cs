using Terraria.ID;
using Terraria.ModLoader;
namespace HelloWorld.Items {
	/// <summary>
	/// Super OP Sword weapon.
	/// </summary>
    public class SuperOPSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Super OP Sword");
            Tooltip.SetDefault("A very OP sword");
        }
        public override void SetDefaults()
        {
            item.damage = 9235;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 30;
            item.value = 9999;
            item.rare = 10;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 40);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}