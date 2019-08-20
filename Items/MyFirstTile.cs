using Terraria.ID;
using Terraria.ModLoader;
namespace HelloWorld.Items
{
    public class MyFirstTile : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("My First Tile");
            Tooltip.SetDefault("An awesome tile!");
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
            item.createTile = mod.TileType("MyFirstTile");
        }
    }
}
