using Godot;

namespace OpenVTT.scenes.src
{
	public class MultipleWindowDialog : WindowDialog
	{
		public override void _GuiInput(InputEvent @event)
		{
			if (@event is InputEventMouseButton)
			{
				Raise();
			}
			base._GuiInput(@event);
		}
	}
}
