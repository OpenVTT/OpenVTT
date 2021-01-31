using Godot;

namespace OpenVTT.Scenes
{
	public class Desktop : Control
	{
		private bool _menuOpened;
	
		private Node _menu;

		public override void _EnterTree()
		{
			_menu = ((PackedScene)ResourceLoader.Load("res://scenes/Menu.tscn")).Instance();
			base._EnterTree();
		}

		public override void _Process(float delta)
		{
			if (Input.IsActionJustPressed("ui_cancel"))
			{
				if (_menuOpened)
				{
					_menuOpened = false;
					RemoveChild(_menu);
				}
				else
				{
					_menuOpened = true;
					AddChild(_menu);
				}
			}
			base._Process(delta);
		}
	}
}
