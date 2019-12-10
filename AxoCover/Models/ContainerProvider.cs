using AxoCover.Commands;
using AxoCover.Models.Editor;
using AxoCover.Models.Storage;
using AxoCover.Models.Telemetry;
using AxoCover.Models.Testing.Adapters;
using AxoCover.Models.Testing.Discovery;
using AxoCover.Models.Testing.Execution;
using AxoCover.Models.Testing.Results;
using AxoCover.Models.Updater;
using Unity;
using Unity.Lifetime;

namespace AxoCover.Models
{
    public static class ContainerProvider
  {
    private static IUnityContainer _container;
    public static IUnityContainer Container
    {
      get
      {
        if (_container == null)
        {
          _container = new UnityContainer();
          RegisterTypes();
        }
        return _container;
      }
    }

    private static void RegisterTypes()
    {
      Container.RegisterType<ITestAdapter, MsTest1Adapter>("msTest1");
      Container.RegisterType<ITestAdapter, MsTest2Adapter>("msTest2");
      Container.RegisterType<ITestAdapter, NUnit2Adapter>("nUnit2");
      Container.RegisterType<ITestAdapter, NUnit3Adapter>("nUnit3");
      Container.RegisterType<ITestAdapter, xUnitAdapter>("xUnit");
      Container.RegisterType<ITestAdapterRepository, TestAdapterRepository>();
      Container.RegisterType<ITestProvider, TestProvider>(new ContainerControlledLifetimeManager());
      Container.RegisterType<IEditorContext, EditorContext>(new ContainerControlledLifetimeManager());
      Container.RegisterType<ITestRunner, AxoTestRunner>("axo");
      Container.RegisterType<ITestRunner, MultiplexedTestRunner>(new ContainerControlledLifetimeManager());
      Container.RegisterType<ICoverageProvider, CoverageProvider>(new ContainerControlledLifetimeManager());
      Container.RegisterType<IResultProvider, ResultProvider>(new ContainerControlledLifetimeManager());
      Container.RegisterType<IStorageController, StorageController>(new ContainerControlledLifetimeManager());
      Container.RegisterType<IReportProvider, ReportProvider>(new ContainerControlledLifetimeManager());
      Container.RegisterType<ITelemetryManager, HockeyClient>(new ContainerControlledLifetimeManager());
      Container.RegisterType<IOptions, Options>(new ContainerControlledLifetimeManager());
      Container.RegisterType<IReleaseManager, ReleaseManager>(new ContainerControlledLifetimeManager());
      Container.RegisterType<SelectTestCommand>(new ContainerControlledLifetimeManager());
      Container.RegisterType<JumpToTestCommand>(new ContainerControlledLifetimeManager());
      Container.RegisterType<RunTestCommand>(new ContainerControlledLifetimeManager());
      Container.RegisterType<CoverTestCommand>(new ContainerControlledLifetimeManager());
      Container.RegisterType<DebugTestCommand>(new ContainerControlledLifetimeManager());
      Container.RegisterType<IIoProvider, IoProvider>();
    }
  }
}
