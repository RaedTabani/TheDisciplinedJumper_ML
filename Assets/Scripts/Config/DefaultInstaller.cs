using Config;
using UnityEngine;
using Zenject;

public class DefaultInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IConfig>().To<GameConfig>().AsSingle();
    }
}