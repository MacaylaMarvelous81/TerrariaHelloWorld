using System;
using Terraria.UI;
using Terraria.GameContent.UI.Elements;

namespace HelloWorld.UI
{
	/// <summary>
	/// UI menu for MyUI.
	/// </summary>
	public class TheUI : UIState
	{
		/// <summary>
		/// This is a UI element that should be initiated later. It is used so it can be accessed on OnButtonClick and not just OnInitialize.
		/// </summary>
		private UIText text; // to init later
		public TheUI ()
		{
		}
		public override void OnInitialize()
		{
			UIPanel panel = new UIPanel ();
			panel.Width.Set (300, 0);
			panel.Height.Set (300, 0);
			// panel.HAlign = panel.VAlign = 0.5f;
			panel.HAlign = 0.5f;
			panel.VAlign = 0.5f;
			Append (panel);
			UIText header = new UIText ("Hello, world!");
			header.HAlign = 0.5f;
			// header.VAlign = 0.5f;
			header.Top.Set(15, 0);
			panel.Append (header);
			UIPanel button = new UIPanel ();
			button.Width.Set (100, 0);
			button.Height.Set (50, 0);
			button.HAlign = 0.5f;
			button.Top.Set (35, 0);
			button.OnClick += OnButtonClick;
			panel.Append (button);
			text = new UIText ("Click me!");
			// text.HAlign = text.VAlign = 0.5f;
			text.HAlign = 0.5f;
			text.VAlign = 0.5f;
			button.Append (text);
		}
		private void OnButtonClick(UIMouseEvent evt, UIElement listeningEvent)
		{
			// TODO: check which was clicked
			text.SetText ("I was clicked!");
		}
	}
}
