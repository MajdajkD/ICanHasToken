namespace ICH.Common.Model
{
  public class Network
  {
    public string NetworkId { get; protected set; }
    public string NetworkName { get; protected set; }
    public string RpcUrl { get; protected set; }
    public string Currency { get; protected set; }
    public bool IsTestnet { get; protected set; }

    public Network(string networkId, string networkName, string rpcUrl, string currency, bool isTestnet)
    {
      NetworkId = networkId;
      NetworkName = networkName;
      RpcUrl = rpcUrl;
      Currency = currency;
      IsTestnet = isTestnet;
    }
  }
}