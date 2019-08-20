using Terraria.ID;
using Terraria.ModLoader;
namespace HelloWorld.Items
{
    public class BlueDirt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Dirt");
            Tooltip.SetDefault("Stylish dirt!");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.useTime = 10;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 30;
            item.rare = 10;
            item.autoReuse = true;
            item.useTurn = true; // ?
            item.createTile = mod.TileType("BlueDirt");
            item.maxStack = 999; // is there any maximum
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddIngredient(ItemID.Gel);
            // TODO: no need for workbench
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
