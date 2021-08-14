using ICH.Common.Model;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace ICH.Storage
{
  public class ContractStorage : LocalStorageJsInterop
  {
    private const string CONTRACTLIST_ITEMID = "CONTRACTLIST_ITEMID";

    public ContractStorage(IJSRuntime jsRuntime) : base(jsRuntime)
    {
    }

    public async Task<List<Contract>> GetContractListAsync()
    {
      var contractListJson = await read(CONTRACTLIST_ITEMID);
      if (string.IsNullOrEmpty(contractListJson))
      {
        return new List<Contract>();
      }
      else
      {
        return JsonSerializer.Deserialize<List<Contract>>(contractListJson);
      }
    }

    public async Task AddContractAsync(Contract contract)
    {
      var contractListJson = await read(CONTRACTLIST_ITEMID);
      List<Contract> contractList;

      if (string.IsNullOrEmpty(contractListJson))
      {
        contractList = new List<Contract>() { contract };
      }
      else
      {
        contractList = JsonSerializer.Deserialize<List<Contract>>(contractListJson);
        contractList.Add(contract);
      }

      var newcontractListJson = JsonSerializer.Serialize(contractList);
      await save(CONTRACTLIST_ITEMID, newcontractListJson);
    }
  }
}