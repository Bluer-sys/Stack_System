namespace Hero
{
	using Configs;
	using Extensions;
	using Input;
	using UnityEngine;
	using Zenject;

	public class HeroMovement : IFixedTickable
	{
		[Inject] Rigidbody	_rigidbody;
		[Inject] Settings	_settings;
		[Inject] IJoystick	_joystick;

		public void FixedTick()
		{
			_rigidbody.velocity = _joystick.Direction.x0y() * _settings.HeroSpeed;
		}
	}
}