using System.Collections.Generic;
using System.Linq;
using Unity;

namespace AxoCover.Models.Testing.Adapters
{
    public class TestAdapterRepository : ITestAdapterRepository
  {
    public IDictionary<string, ITestAdapter> Adapters { get; private set; }

    public TestAdapterRepository(IUnityContainer container)
    {
      Adapters = container
        .ResolveAll<ITestAdapter>()
        .ToDictionary(p => p.Name);
    }
  }
}
