using ICH.MetaMask.Logic.Messages;
using ICH.MetaMask.Logic.Provider;
using Microsoft.JSInterop;
using Nethereum.JsonRpc.Client.RpcMessages;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace ICH.MetaMask.Logic.Interop
{
  public class MetaMaskInterop
  {
    private readonly IJSRuntime _jsRuntime;

    public MetaMaskInterop(IJSRuntime jsRuntime) =>
      _jsRuntime = jsRuntime ?? throw new ArgumentNullException(nameof(jsRuntime));

    public async ValueTask<string> EnableEthereumAsync() =>
      await _jsRuntime.InvokeAsync<string>("NethereumMetamaskInterop.EnableEthereum");

    public async ValueTask<bool> CheckMetamaskAvailability() =>
      await _jsRuntime.InvokeAsync<bool>("NethereumMetamaskInterop.IsMetamaskAvailable");

    public async ValueTask<RpcResponseMessage> SendAsync(RpcRequestMessage rpcRequestMessage)
    {
      var response = await _jsRuntime.InvokeAsync<string>("NethereumMetamaskInterop.Request", JsonConvert.SerializeObject(rpcRequestMessage));
      return JsonConvert.DeserializeObject<RpcResponseMessage>(response);
    }

    public async ValueTask<RpcResponseMessage> SendTransactionAsync(MetamaskRpcRequestMessage rpcRequestMessage)
    {
      var response = await _jsRuntime.InvokeAsync<string>("NethereumMetamaskInterop.Request", JsonConvert.SerializeObject(rpcRequestMessage));
      return JsonConvert.DeserializeObject<RpcResponseMessage>(response);
    }

    public async ValueTask<string> SignAsync(string utf8Hex) =>
      await _jsRuntime.InvokeAsync<string>("NethereumMetamaskInterop.Sign", utf8Hex);

    public async ValueTask<string> GetSelectedAddress() =>
      await _jsRuntime.InvokeAsync<string>("NethereumMetamaskInterop.GetSelectedAddress");

    public async ValueTask<string> GetSelectedNetwork() =>
      await _jsRuntime.InvokeAsync<string>("NethereumMetamaskInterop.GetSelectedNetwork");

    public async ValueTask<bool> SwitchChainAsync(string chainId, string chainRpc) =>
      await _jsRuntime.InvokeAsync<bool>("NethereumMetamaskInterop.SwitchChain", chainId, chainRpc);

    public async ValueTask<bool> AddAssetAsync(
      string assetType,
      string assetAddress,
      string assetSymbol,
      int assetDecimals,
      string assetImageUrl) =>
      await _jsRuntime.InvokeAsync<bool>("NethereumMetamaskInterop.AddAsset",
        assetType,
        assetAddress,
        assetSymbol,
        assetDecimals,
        assetImageUrl);

    //JS Events call these methods
    [JSInvokable()]
    public static async Task MetamaskAvailableChanged(bool available) =>
      await MetaMaskHostProvider.Current.ChangeMetamaskAvailableAsync(available);

    [JSInvokable()]
    public static async Task SelectedAccountChanged(string selectedAccount) =>
      await MetaMaskHostProvider.Current.ChangeSelectedAccountAsync(selectedAccount);

    [JSInvokable()]
    public static async Task NetworkChanged(string networkid) =>
      await MetaMaskHostProvider.Current.ChangeSelectedNetworkAsync(networkid);
  }
}