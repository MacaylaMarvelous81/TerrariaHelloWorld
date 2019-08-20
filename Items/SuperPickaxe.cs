using Terraria.ID;
using Terraria.ModLoader;
namespace HelloWorld.Items
{
    public class SuperPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Super Pickaxe");
            Tooltip.SetDefault("A super pick :)");
        }
        public override void SetDefaults()
        {
            item.damage = 15;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 5;
            item.useAnimation = 20;
            item.pick = 1000;
            item.useStyle = 1;
            item.knockBack = 1.2F;
            item.value = 32;
            item.rare = 5;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true; // ?
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Acorn, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
