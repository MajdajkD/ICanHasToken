// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ICH.MetaMask.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\majda\source\repos\ICH\ICH.MetaMask\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\majda\source\repos\ICH\ICH.MetaMask\_Imports.razor"
using ICH.MetaMask.Logic.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\majda\source\repos\ICH\ICH.MetaMask\_Imports.razor"
using ICH.MetaMask.Logic.Provider;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\majda\source\repos\ICH\ICH.MetaMask\_Imports.razor"
using ICH.MetaMask.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\majda\source\repos\ICH\ICH.MetaMask\_Imports.razor"
using ICH.Common.Constants;

#line default
#line hidden
#nullable disable
    public partial class MetamaskNetworkChangeButton : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\majda\source\repos\ICH\ICH.MetaMask\Components\MetamaskNetworkChangeButton.razor"
       
    [Parameter]
    public string Class { get; set; } = "btn btn-outline-warning font-weight-bold";

    protected async Task ChangeChainAsync(string chainId)
    {
      var network = EthereumNetworks.GetNetworkByChainId(chainId);
        if (network != null)
        {
            var rpcUrl = network.RpcUrl;
            var success = await _metamaskHostProvider.SwitchChainAsync(chainId, rpcUrl);
            this.StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MetaMaskHostProvider _metamaskHostProvider { get; set; }
    }
}
#pragma warning restore 1591
