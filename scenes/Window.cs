using Godot;
// ReSharper disable UnusedMember.Local

namespace OpenVTT.scenes
{
	public class Window : PanelContainer
	{
		private bool _isDragging;
		private Vector2 _previousMousePos;

		private PanelContainer _root;

		public override void _EnterTree()
		{
			_root = GetNode<PanelContainer>("/root/Control/PanelContainer");
			base._EnterTree();
		}

		public override void _Process(float delta)
		{
			if (_isDragging)
			{
				var mouseDelta = _previousMousePos - GetLocalMousePosition();
				_root.RectPosition -= mouseDelta;
			}
			base._Process(delta);
		}

		public override void _GuiInput(InputEvent @event)
		{
			if (@event is InputEventMouseButton mouseEvent)
			{
				_isDragging = mouseEvent.Pressed;
				
				if (mouseEvent.Pressed)
				{
					_previousMousePos = mouseEvent.Position;
				}
			}
			base._GuiInput(@event);
		}
		
		private void _on_Close_pressed()
		{
			_root.QueueFree();
		}
	}
}
