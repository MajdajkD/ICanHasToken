using ICH.MetaMask.Logic.Authentication;
using ICH.MetaMask.Logic.Interop;
using ICH.MetaMask.Logic.Nethereum;
using ICH.MetaMask.Logic.Provider;
using Microsoft.Extensions.DependencyInjection;

namespace ICH.MetaMask.Infrastructure
{
  public static class DependencyRegistration
  {
    public static void RegisterMetaMaskDependencies(this IServiceCollection serviceCollection)
    {
      serviceCollection.AddSingleton<MetaMaskInterop>();
      serviceCollection.AddSingleton<MetaMaskInterceptor>();
      serviceCollection.AddSingleton<MetaMaskHostProvider>();
      serviceCollection.AddSingleton<MetaMaskAuthenticator>();
    }
  }
}