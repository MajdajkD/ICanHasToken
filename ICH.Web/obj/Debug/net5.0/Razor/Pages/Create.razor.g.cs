#pragma checksum "C:\Users\majda\source\repos\ICH\ICH.Web\Pages\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7781ad3a33f309e8ad85ea65e28ea32d1c7ac048"
// <auto-generated/>
#pragma warning disable 1591
namespace ICH.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\majda\source\repos\ICH\ICH.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\majda\source\repos\ICH\ICH.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\majda\source\repos\ICH\ICH.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\majda\source\repos\ICH\ICH.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\majda\source\repos\ICH\ICH.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\majda\source\repos\ICH\ICH.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\majda\source\repos\ICH\ICH.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\majda\source\repos\ICH\ICH.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\majda\source\repos\ICH\ICH.Web\_Imports.razor"
using System.Numerics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\majda\source\repos\ICH\ICH.Web\_Imports.razor"
using ICH.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\majda\source\repos\ICH\ICH.Web\_Imports.razor"
using ICH.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\majda\source\repos\ICH\ICH.Web\_Imports.razor"
using ICH.Web.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\majda\source\repos\ICH\ICH.Web\_Imports.razor"
using ICH.MetaMask.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\majda\source\repos\ICH\ICH.Web\_Imports.razor"
using ICH.MetaMask.Logic.Provider;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\majda\source\repos\ICH\ICH.Web\_Imports.razor"
using ICH.Logic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\majda\source\repos\ICH\ICH.Web\_Imports.razor"
using ICH.Storage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\majda\source\repos\ICH\ICH.Web\Pages\Create.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<ICH.Web.Components.InfoBar>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-6");
            __builder.AddMarkupContent(6, "<h3>Create Token</h3>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "EditContext", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Forms.EditContext>(
#nullable restore
#line 10 "C:\Users\majda\source\repos\ICH\ICH.Web\Pages\Create.razor"
                                editContext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\majda\source\repos\ICH\ICH.Web\Pages\Create.razor"
                                                            Deploy

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "mb-3");
                __builder2.AddMarkupContent(15, "<label for=\"tokenName\" class=\"form-label\">Token Name</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\majda\source\repos\ICH\ICH.Web\Pages\Create.razor"
                                        model.tokenName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.tokenName = __value, model.tokenName))));
                __builder2.AddAttribute(20, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.tokenName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n                ");
                __Blazor.ICH.Web.Pages.Create.TypeInference.CreateValidationMessage_0(__builder2, 22, 23, 
#nullable restore
#line 16 "C:\Users\majda\source\repos\ICH\ICH.Web\Pages\Create.razor"
                                          () => model.tokenName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(24, "\r\n                ");
                __builder2.AddMarkupContent(25, "<div id=\"tokenNameHelp\" class=\"form-text\">This will be the full name of your token.</div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "mb-3");
                __builder2.AddMarkupContent(29, "<label for=\"tokenSymbol\" class=\"form-label\">Token Symbol</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\majda\source\repos\ICH\ICH.Web\Pages\Create.razor"
                                        model.tokenSymbol

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.tokenSymbol = __value, model.tokenSymbol))));
                __builder2.AddAttribute(34, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.tokenSymbol));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n                ");
                __Blazor.ICH.Web.Pages.Create.TypeInference.CreateValidationMessage_1(__builder2, 36, 37, 
#nullable restore
#line 22 "C:\Users\majda\source\repos\ICH\ICH.Web\Pages\Create.razor"
                                          () => model.tokenSymbol

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(38, "\r\n                ");
                __builder2.AddMarkupContent(39, "<div id=\"tokenSymbolHelp\" class=\"form-text\">This will be the short name (1-6 characters) of your token. </div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n            ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "mb-3 form-check");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(43);
                __builder2.AddAttribute(44, "id", "burnable");
                __builder2.AddAttribute(45, "class", "form-check-input");
                __builder2.AddAttribute(46, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\majda\source\repos\ICH\ICH.Web\Pages\Create.razor"
                                            model.burnable

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.burnable = __value, model.burnable))));
                __builder2.AddAttribute(48, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => model.burnable));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n                ");
                __builder2.AddMarkupContent(50, "<label class=\"form-check-label\" for=\"burnable\">Token is burnable</label>\r\n                ");
                __builder2.AddMarkupContent(51, "<div class=\"form-text\">Check this, if you want your token holders to be able to burn their tokens.</div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n            ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "mb-3 form-check");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(55);
                __builder2.AddAttribute(56, "id", "mintable");
                __builder2.AddAttribute(57, "class", "form-check-input");
                __builder2.AddAttribute(58, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\Users\majda\source\repos\ICH\ICH.Web\Pages\Create.razor"
                                            model.mintable

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.mintable = __value, model.mintable))));
                __builder2.AddAttribute(60, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => model.mintable));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n                ");
                __builder2.AddMarkupContent(62, "<label class=\"form-check-label\" for=\"mintable\">Token is mintable</label>\r\n                ");
                __builder2.AddMarkupContent(63, "<div class=\"form-text\">Check this, if you want to be able to mint tokens for others or yourself.</div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n            ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "mb-3 form-check");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(67);
                __builder2.AddAttribute(68, "id", "pausable");
                __builder2.AddAttribute(69, "class", "form-check-input");
                __builder2.AddAttribute(70, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "C:\Users\majda\source\repos\ICH\ICH.Web\Pages\Create.razor"
                                            model.pausable

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.pausable = __value, model.pausable))));
                __builder2.AddAttribute(72, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => model.pausable));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n                ");
                __builder2.AddMarkupContent(74, "<label class=\"form-check-label\" for=\"pausable\">Token is pausable</label>\r\n                ");
                __builder2.AddMarkupContent(75, "<div class=\"form-text\">Check this, if you want to be able to pause/resume every transaction of the contract.</div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n\r\n            ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "mb-3");
                __builder2.AddMarkupContent(79, "<label for=\"tokenSupply\" class=\"form-label\">Initial Token Supply</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(80);
                __builder2.AddAttribute(81, "class", "form-control");
                __builder2.AddAttribute(82, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "C:\Users\majda\source\repos\ICH\ICH.Web\Pages\Create.razor"
                                        model.initialSupply

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.initialSupply = __value, model.initialSupply))));
                __builder2.AddAttribute(84, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.initialSupply));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n                ");
                __Blazor.ICH.Web.Pages.Create.TypeInference.CreateValidationMessage_2(__builder2, 86, 87, 
#nullable restore
#line 45 "C:\Users\majda\source\repos\ICH\ICH.Web\Pages\Create.razor"
                                          () => model.initialSupply

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(88, "\r\n                ");
                __builder2.AddMarkupContent(89, "<div id=\"tokenSupplylHelp\" class=\"form-text\">This will be the initial supply of your token (in Ether - aka. 18 decimals).</div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n\r\n            ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "mb-3");
                __builder2.AddMarkupContent(93, "<label for=\"commission\" class=\"form-label\">Commission</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(94);
                __builder2.AddAttribute(95, "class", "form-control");
                __builder2.AddAttribute(96, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "C:\Users\majda\source\repos\ICH\ICH.Web\Pages\Create.razor"
                                        model.commission

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(97, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.commission = __value, model.commission))));
                __builder2.AddAttribute(98, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.commission));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(99, "\r\n                ");
                __Blazor.ICH.Web.Pages.Create.TypeInference.CreateValidationMessage_3(__builder2, 100, 101, 
#nullable restore
#line 52 "C:\Users\majda\source\repos\ICH\ICH.Web\Pages\Create.razor"
                                          () => model.commission

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(102, "\r\n                ");
                __builder2.AddMarkupContent(103, "<div id=\"commissionHelp\" class=\"form-text\">Typical fee on other sites are 0.1 to 0.8 Eth, which is way too much in our opinion, feel free to modify this value (in Ether - aka. 18 decimals, minimum: 0.000000000000000001).</div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n            ");
                __builder2.AddMarkupContent(105, "<button class=\"btn btn-primary btn-lg\" type=\"submit\">Deploy Contract</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n    ");
            __builder.AddMarkupContent(107, "<div class=\"col-md-6\"><h3>Or choose one of the presets:</h3></div>");
            __builder.CloseElement();
#nullable restore
#line 65 "C:\Users\majda\source\repos\ICH\ICH.Web\Pages\Create.razor"
 if (!string.IsNullOrEmpty(contractAddress))
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(108, "Contract Address: ");
            __builder.AddContent(109, 
#nullable restore
#line 67 "C:\Users\majda\source\repos\ICH\ICH.Web\Pages\Create.razor"
                             contractAddress

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 67 "C:\Users\majda\source\repos\ICH\ICH.Web\Pages\Create.razor"
                                                   
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(110, "<style>\r\n    .validation-message {\r\n        color: #f00 !important\r\n    }</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\majda\source\repos\ICH\ICH.Web\Pages\Create.razor"
       
    string contractAddress { get; set; }
    private EditContext editContext;
    TokenFormModel model = new TokenFormModel();

    protected override void OnInitialized()
    {
        editContext = new EditContext(model);
    }

    protected async Task Deploy()
    {
        var currentAddress = await _metamaskHostProvider.GetProviderSelectedAccountAsync();
        var metaMaskWeb3 = await _metamaskHostProvider.GetWeb3Async();

        var commissionDecimal = Nethereum.Util.BigDecimal.Parse(model.commission) * Nethereum.Util.BigDecimal.Parse("1000000000000000000");
        var commissionInteger = commissionDecimal.Floor().Mantissa;

        var supplyDecimal = Nethereum.Util.BigDecimal.Parse(model.initialSupply) * Nethereum.Util.BigDecimal.Parse("1000000000000000000");
        var supplyInteger = supplyDecimal.Floor().Mantissa;

        contractAddress = await TokenDeployManager.Deploy(metaMaskWeb3, model.tokenName, model.tokenSymbol, supplyInteger, currentAddress, commissionInteger, model.mintable, model.burnable, model.pausable);
        await _contractStorage.AddContractAsync(new Common.Model.Contract(
          _metamaskHostProvider.SelectedNetwork,
          contractAddress,
          model.tokenName,
          model.tokenSymbol,
          model.mintable,
          model.burnable,
          model.pausable
          // decimals, base64 image
        ));
    }


    class TokenFormModel
    {
        [Required]
        [MinLength(1, ErrorMessage = "Token Name must be at least 1 character")]
        public string tokenName { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Token Symbol must be at least 1 character")]
        [MaxLength(6, ErrorMessage = "Token Symbol must be max 6 characters long")]
        [RegularExpression(@"^[A-Za-z0-9]{1,6}$", ErrorMessage = "Token Symbol must be 1-6 long and can contain letters and numbers")]
        public string tokenSymbol { get; set; }

        public bool mintable { get; set; }
        public bool burnable { get; set; }
        public bool pausable { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{1,18}(\.[0-9]{0,18})?$", ErrorMessage = "Initial supply must between 10^18 and 10^-18 (try shorter number)")]
        public string initialSupply { get; set; } = "10000";

        [Required]
        [RegularExpression(@"^[0-9]{1,18}(\.[0-9]{0,18})?$", ErrorMessage = "Commission fee must between 10^18 and 10^-18 (try shorter number)")]
        public string commission { get; set; } = "0.05";
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ContractStorage _contractStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MetaMaskHostProvider _metamaskHostProvider { get; set; }
    }
}
namespace __Blazor.ICH.Web.Pages.Create
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
