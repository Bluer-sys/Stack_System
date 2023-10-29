namespace Input
{
	using UnityEngine;

	public interface IJoystick
	{
		Vector2 Direction { get; }
	}

	public class Joystick : IJoystick
	{
		public Vector2 Direction =>
			new( SimpleInput.GetAxis( "Horizontal" ), SimpleInput.GetAxis( "Vertical" ) );
	}
}