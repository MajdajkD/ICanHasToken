using Microsoft.Extensions.DependencyInjection;

namespace ICH.Storage.Infrastructure
{
  public static class DependencyRegistration
  {
    public static void RegisterLocalStorageDependencies(this IServiceCollection serviceCollection)
    {
      serviceCollection.AddSingleton<ContractStorage>();
    }
  }
}
