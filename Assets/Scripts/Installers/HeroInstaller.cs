namespace Installers
{
	using Hero;
	using UnityEngine;
	using Zenject;

	public class HeroInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			// Rigidbody
			Container
				.Bind<Rigidbody>()
				.FromComponentInHierarchy()
				.AsSingle();
			
			// HeroMovement
			Container
				.BindInterfacesTo<HeroMovement>()
				.AsSingle();
		}
	}
}