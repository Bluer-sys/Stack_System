namespace Installers
{
	using Input;
	using Zenject;

	public class MainSceneInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			Bind_Input();
		}

		void Bind_Input()
		{
			// Joystick
			Container
				.BindInterfacesTo<Joystick>()
				.AsSingle();
		}
	}
}