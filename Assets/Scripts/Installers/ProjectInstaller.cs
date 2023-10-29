namespace Installers
{
	using Configs;
	using UnityEngine;
	using Zenject;

	public class ProjectInstaller : MonoInstaller
	{
		[SerializeField] Settings _settings;
		
		public override void InstallBindings()
		{
			// Settings
			Container.BindInstance( _settings );
		}
	}
}