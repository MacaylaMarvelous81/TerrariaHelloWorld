using Terraria;
using Terraria.ModLoader;
using Terraria.UI;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using HelloWorld.UI;

namespace HelloWorld
{
	class HelloWorld : Mod
	{
		public static UserInterface MyInterface;
		public static TheUI MyUI;
		public static bool MyUIVisible;
		private GameTime _lastUpdateUiGameTime;
		public HelloWorld()
		{
		}
		public override void Load()
		{
			HelloWorld.InitializeMyUI ();
		}
		public override void UpdateUI(GameTime gameTime)
		{
			_lastUpdateUiGameTime = gameTime;
			if (MyInterface?.CurrentState != null) {
				MyInterface.Update (gameTime);
			}
		}
		public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
		{
			int mouseTextIndex = layers.FindIndex (layer => layer.Name.Equals ("Vanilla: Mouse Text"));
			if (mouseTextIndex != -1) {
				layers.Insert(mouseTextIndex, new LegacyGameInterfaceLayer("Menu", delegate {
					if(_lastUpdateUiGameTime != null && MyInterface?.CurrentState != null) {
						MyInterface.Draw(Main.spriteBatch, _lastUpdateUiGameTime);
					}
					return true;
				}, InterfaceScaleType.UI));
			}
		}
		public static void InitializeMyUI()
		{
			MyInterface = new UserInterface ();
			MyUI = new TheUI ();
			MyUI.Activate ();
		}
		public static void UnloadMyUI()
		{
			MyUI = null;
		}
		public static void ShowMyUI()
		{
			MyInterface?.SetState (MyUI);
			MyUIVisible = true;
		}
		public static void HideMyUI()
		{
			MyInterface?.SetState (null);
			MyUIVisible = false;
		}
	}
}
