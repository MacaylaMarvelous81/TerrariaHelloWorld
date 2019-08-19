using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
namespace HelloWorld.Tiles
{
    public class MyFirstTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileLighted[Type] = true;
            Main.tileFrameImportant[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX); // ?
            TileObjectData.newTile.Width = 2; // How many pink squares from left to right
            TileObjectData.newTile.Height = 2; // How many pink squares from top to bottom
            TileObjectData.newTile.Origin = new Point16(1, 1); // Where cursor is on screen when places (middle of the tile)
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16 }; // How many pixels in pink square
            TileObjectData.addTile(Type);
            // FIXME: AddMapEntry
            // AddMapEntry(new Color(255, 255, 255));
            // TODO: animationFrameHeight???
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(new Rectangle(i, j, 16, 16), mod.ItemType("MyFirstTile"));
        }
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.33F;
            g = 0;
            b = 0.32F;
        }
    }
}
