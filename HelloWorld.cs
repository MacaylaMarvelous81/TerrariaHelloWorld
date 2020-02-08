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
		/// <summary>
		/// UserInterface object for UI MyUI.
		/// </summary>
		public static UserInterface MyInterface;
		/// <summary>
		/// MyUI's UIState.
		/// </summary>
		public static TheUI MyUI;
		/// <summary>
		/// Determines if MyUI is visible, intended to be used for other files like Items/UILauncher.cs
		/// </summary>
		public static bool MyUIVisible;
		/// <summary>
		/// I don't know? Please create a pull request if you know!
		/// </summary>
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
		/// <summary>
		/// Initializes MyUI so it is ready for use.
		/// </summary>
		public static void InitializeMyUI()
		{
			MyInterface = new UserInterface ();
			MyUI = new TheUI ();
			MyUI.Activate ();
		}
		/// <summary>
		/// Unloads MyUI.
		/// </summary>
		public static void UnloadMyUI()
		{
			MyUI = null;
		}
		/// <summary>
		/// Initializing MyUI will not make it visible. Make it visible here!
		/// </summary>
		public static void ShowMyUI()
		{
			MyInterface?.SetState (MyUI);
			MyUIVisible = true;
		}
		/// <summary>
		/// Hide MyUI.
		/// </summary>
		public static void HideMyUI()
		{
			MyInterface?.SetState (null);
			MyUIVisible = false;
		}
	}
}
