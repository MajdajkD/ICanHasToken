using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace ICH.Storage
{
  public class LocalStorageJsInterop
  {
    private readonly IJSRuntime _jsRuntime;

    public LocalStorageJsInterop(IJSRuntime jsRuntime) =>
      _jsRuntime = jsRuntime ?? throw new ArgumentNullException(nameof(jsRuntime));

    protected async Task save(string itemId, string itemValue)
    {
      await _jsRuntime.InvokeVoidAsync("localStorage.setItem", itemId, itemValue);
    }

    protected async Task<string> read(string itemId)
    {
      return await _jsRuntime.InvokeAsync<string>("localStorage.getItem", itemId);
    }

    protected async Task delete(string itemId)
    {
      await _jsRuntime.InvokeAsync<string>("localStorage.removeItem", itemId);
    }
  }
}