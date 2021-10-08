using ICH.MetaMask.Infrastructure;
using ICH.Storage.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ICH.Web
{
  public class Program
  {
    public static async Task Main(string[] args)
    {
      var builder = WebAssemblyHostBuilder.CreateDefault(args);
      builder.RootComponents.Add<App>("#app");

      builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

      builder.Services.RegisterMetaMaskDependencies();
      builder.Services.RegisterLocalStorageDependencies();

      var provider = new FileExtensionContentTypeProvider();
      provider.Mappings[".sol"] = "text/plain";

      builder.Services.Configure<StaticFileOptions>(options =>
      {
        options.ContentTypeProvider = provider;
      });

      await builder.Build().RunAsync();
    }
  }
}