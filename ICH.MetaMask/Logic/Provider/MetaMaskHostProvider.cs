using ICH.MetaMask.Logic.Interop;
using ICH.MetaMask.Logic.Nethereum;
using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.Web3;
using System;
using System.Threading.Tasks;

namespace ICH.MetaMask.Logic.Provider
{
  public class MetaMaskHostProvider
  {
    private readonly MetaMaskInterop _metamaskInterop;
    public static MetaMaskHostProvider Current { get; private set; }
    public string Name { get; } = "Metamask";
    public bool Available { get; private set; }
    public string SelectedAccount { get; private set; }
    public string SelectedNetwork { get; private set; }
    public bool Enabled { get; private set; }

    private MetaMaskInterceptor _metamaskInterceptor;

    public event Func<string, Task> SelectedAccountChanged;

    public event Func<string, Task> NetworkChanged;

    public event Func<bool, Task> AvailabilityChanged;

    public event Func<bool, Task> EnabledChanged;

    public MetaMaskHostProvider(MetaMaskInterop metamaskInterop)
    {
      _metamaskInterop = metamaskInterop;
      _metamaskInterceptor = new MetaMaskInterceptor(_metamaskInterop, this);
      Current = this;
    }

    public async Task<bool> CheckProviderAvailabilityAsync()
    {
      var result = await _metamaskInterop.CheckMetamaskAvailability();
      await ChangeMetamaskAvailableAsync(result);
      return result;
    }

    public Task<Web3> GetWeb3Async()
    {
      var web3 = new Web3 { Client = { OverridingRequestInterceptor = _metamaskInterceptor } };
      return Task.FromResult(web3);
    }

    public async Task<string> EnableProviderAsync()
    {
      var selectedAccount = await _metamaskInterop.EnableEthereumAsync();
      Enabled = !string.IsNullOrEmpty(selectedAccount);

      if (Enabled)
      {
        await GetProviderSelectedNetworkAsync();

        SelectedAccount = selectedAccount;
        if (SelectedAccountChanged != null)
        {
          await SelectedAccountChanged.Invoke(selectedAccount);
        }
        return selectedAccount;
      }
      return null;
    }

    public async Task<string> GetProviderSelectedAccountAsync()
    {
      var result = await _metamaskInterop.GetSelectedAddress();
      await ChangeSelectedAccountAsync(result);
      return result;
    }

    public async Task<string> GetProviderSelectedNetworkAsync()
    {
      var result = await _metamaskInterop.GetSelectedNetwork();
      await ChangeSelectedNetworkAsync(result);
      return result;
    }

    public async Task<string> SignMessageAsync(string message)
    {
      return await _metamaskInterop.SignAsync(message.ToHexUTF8());
    }

    public async Task<bool> SwitchChainAsync(string chainId, string chainRpc)
    {
      return await _metamaskInterop.SwitchChainAsync(chainId, chainRpc);
    }

    public async Task<bool> AddAssetAsync(
      string assetType,
      string assetAddress,
      string assetSymbol,
      int assetDecimals,
      string assetImageUrl)
    {
      return await _metamaskInterop.AddAssetAsync(
        assetType,
        assetAddress,
        assetSymbol,
        assetDecimals,
        assetImageUrl);
    }

    public async Task ChangeSelectedAccountAsync(string selectedAccount)
    {
      if (SelectedAccount != selectedAccount)
      {
        SelectedAccount = selectedAccount;
        if (SelectedAccountChanged != null)
        {
          await SelectedAccountChanged.Invoke(selectedAccount);
        }
      }
    }

    public async Task ChangeSelectedNetworkAsync(string networkId)
    {
      if (SelectedNetwork != networkId)
      {
        SelectedNetwork = networkId;
        if (NetworkChanged != null)
        {
          await NetworkChanged.Invoke(networkId);
        }
      }
    }

    public async Task ChangeMetamaskAvailableAsync(bool available)
    {
      Available = available;
      if (AvailabilityChanged != null)
      {
        await AvailabilityChanged.Invoke(available);
      }
    }
  }
}