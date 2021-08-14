using ICH.Common.Model;
using System.Collections.Generic;
using System.Linq;

namespace ICH.Common.Constants
{
  public static class EthereumNetworks
  {
    public static IReadOnlyList<Network> NetworkList { get; private set; }

    static EthereumNetworks()
    {
      NetworkList = new List<Network>()
      {
        new Network("0x1","Ethereum Mainnet","https://main-light.eth.linkpool.io/","ETH",false),
        new Network("0x696c67","ILGON Mainnet","https://mainnet-rpc.ilgonwallet.com/","ILG",false),
        new Network("0x38","Binance Smartchain Mainnet","https://testnet-rpc.ilgonwallet.com/","BNB",false),

        new Network("0x696c6774","ILGON Testnet","https://testnet-rpc.ilgonwallet.com/","ILGT",true),
        new Network("0x61","Binance Testnet","https://data-seed-prebsc-1-s1.binance.org:8545/","BNBT",true),
      }.AsReadOnly();
    }

    public static Network GetNetworkByChainId(string chainId)
      => NetworkList.Where(n => n.NetworkId == chainId).FirstOrDefault();
  }
}