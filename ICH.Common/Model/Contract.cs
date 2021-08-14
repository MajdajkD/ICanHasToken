namespace ICH.Common.Model
{
  public class Contract
  {
    public string NetworkId { get; protected set; }
    public string Address { get; protected set; }
    public string Name { get; protected set; }
    public string Symbol { get; protected set; }

    public bool IsMintable { get; protected set; }
    public bool IsBurnable { get; protected set; }
    public bool IsPpausable { get; protected set; }

    public int Decimals { get; protected set; }
    public string Base64Logo { get; protected set; }

    public Contract(
      string networkId,
      string address,
      string name,
      string symbol,
      bool isMintable,
      bool isBurnable,
      bool isPpausable,
      int decimals = 18,
      string base64Logo = null)
    {
      NetworkId = networkId;
      Address = address;
      Name = name;
      Symbol = symbol;
      IsMintable = isMintable;
      IsBurnable = isBurnable;
      IsPpausable = isPpausable;
      Decimals = decimals;
      Base64Logo = base64Logo;
    }
  }
}