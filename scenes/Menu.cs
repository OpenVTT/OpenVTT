using Godot;

namespace OpenVTT.Scenes
{
	public class Menu : Control
	{
		private void _on_Quit_pressed()
		{
			GetTree().Quit();
		}
	}

}
