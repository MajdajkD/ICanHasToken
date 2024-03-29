using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace ICH.Solidity.Contracts.ICHBurnPauseERC20.ContractDefinition
{


    public partial class ICHBurnPauseERC20Deployment : ICHBurnPauseERC20DeploymentBase
    {
        public ICHBurnPauseERC20Deployment() : base(BYTECODE) { }
        public ICHBurnPauseERC20Deployment(string byteCode) : base(byteCode) { }
    }

    public class ICHBurnPauseERC20DeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405260405162001f9938038062001f998339810160408190526200002691620005cd565b8484848484818185858860003411620000865760405162461bcd60e51b815260206004820152601c60248201527f436f6d6d697373696f6e20666565206973206d697373696e67203a280000000060448201526064015b60405180910390fd5b6040516001600160a01b038216903480156108fc02916000818181858888f19350505050158015620000bc573d6000803e3d6000fd5b5060405134815230906001600160a01b0383169033907fd6a974817678441e8375d5235c138959cd0c5418161b40991a845df41c19b23e9060200160405180910390a45081516200011590600390602085019062000470565b5080516200012b90600490602084019062000470565b5050506200014581836200019760201b620008d81760201c565b50506007805460ff19169055506200018c93507f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a9250620001869150503390565b6200028b565b505050505062000700565b6001600160a01b038216620001ef5760405162461bcd60e51b815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f20616464726573730060448201526064016200007d565b620001fd60008383620002ce565b80600260008282546200021191906200066d565b90915550506001600160a01b03821660009081526020819052604081208054839290620002409084906200066d565b90915550506040518181526001600160a01b038316906000907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a35b5050565b620002a282826200034e60201b620009c41760201c565b6000828152600660209081526040909120620002c9918390620009ce6200035a821b17901c565b505050565b620002e6838383620002c960201b6200057d1760201c565b60075460ff1615620002c95760405162461bcd60e51b815260206004820152602a60248201527f45524332305061757361626c653a20746f6b656e207472616e736665722077686044820152691a5b19481c185d5cd95960b21b60648201526084016200007d565b6200028782826200037a565b600062000371836001600160a01b0384166200041e565b90505b92915050565b60008281526005602090815260408083206001600160a01b038516845290915290205460ff16620002875760008281526005602090815260408083206001600160a01b03851684529091529020805460ff19166001179055620003da3390565b6001600160a01b0316816001600160a01b0316837f2f8788117e7eff1d82e926ec794901d17c78024a50270940304540a733656f0d60405160405180910390a45050565b6000818152600183016020526040812054620004675750815460018181018455600084815260208082209093018490558454848252828601909352604090209190915562000374565b50600062000374565b8280546200047e9062000694565b90600052602060002090601f016020900481019282620004a25760008555620004ed565b82601f10620004bd57805160ff1916838001178555620004ed565b82800160010185558215620004ed579182015b82811115620004ed578251825591602001919060010190620004d0565b50620004fb929150620004ff565b5090565b5b80821115620004fb576000815560010162000500565b600082601f8301126200052857600080fd5b81516001600160401b0380821115620005455762000545620006d1565b604051601f8301601f19908116603f01168101908282118183101715620005705762000570620006d1565b816040528381526020925086838588010111156200058d57600080fd5b600091505b83821015620005b1578582018301518183018401529082019062000592565b83821115620005c35760008385830101525b9695505050505050565b600080600080600060a08688031215620005e657600080fd5b8551620005f381620006e7565b60208701519095506001600160401b03808211156200061157600080fd5b6200061f89838a0162000516565b955060408801519150808211156200063657600080fd5b50620006458882890162000516565b9350506060860151915060808601516200065f81620006e7565b809150509295509295909350565b600082198211156200068f57634e487b7160e01b600052601160045260246000fd5b500190565b600181811c90821680620006a957607f821691505b60208210811415620006cb57634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052604160045260246000fd5b6001600160a01b0381168114620006fd57600080fd5b50565b61188980620007106000396000f3fe608060405234801561001057600080fd5b506004361061018e5760003560e01c806370a08231116100de578063a217fddf11610097578063ca15c87311610071578063ca15c87314610353578063d547741f14610366578063dd62ed3e14610379578063e63ab1e9146103b257600080fd5b8063a217fddf14610325578063a457c2d71461032d578063a9059cbb1461034057600080fd5b806370a082311461029b57806379cc6790146102c45780638456cb59146102d75780639010d07c146102df57806391d148541461030a57806395d89b411461031d57600080fd5b80632f2ff15d1161014b578063395093511161012557806339509351146102625780633f4ba83a1461027557806342966c681461027d5780635c975abb1461029057600080fd5b80632f2ff15d1461022b578063313ce5671461024057806336568abe1461024f57600080fd5b806301ffc9a71461019357806306fdde03146101bb578063095ea7b3146101d057806318160ddd146101e357806323b872dd146101f5578063248a9ca314610208575b600080fd5b6101a66101a136600461165d565b6103d9565b60405190151581526020015b60405180910390f35b6101c3610404565b6040516101b291906116fc565b6101a66101de3660046115d5565b610496565b6002545b6040519081526020016101b2565b6101a6610203366004611599565b6104ac565b6101e76102163660046115ff565b60009081526005602052604090206001015490565b61023e610239366004611618565b61055b565b005b604051601281526020016101b2565b61023e61025d366004611618565b610582565b6101a66102703660046115d5565b6105a4565b61023e6105e0565b61023e61028b3660046115ff565b610686565b60075460ff166101a6565b6101e76102a936600461154b565b6001600160a01b031660009081526020819052604090205490565b61023e6102d23660046115d5565b610693565b61023e610714565b6102f26102ed36600461163b565b6107b8565b6040516001600160a01b0390911681526020016101b2565b6101a6610318366004611618565b6107d7565b6101c3610802565b6101e7600081565b6101a661033b3660046115d5565b610811565b6101a661034e3660046115d5565b6108aa565b6101e76103613660046115ff565b6108b7565b61023e610374366004611618565b6108ce565b6101e7610387366004611566565b6001600160a01b03918216600090815260016020908152604080832093909416825291909152205490565b6101e77f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a81565b60006001600160e01b03198216635a05180f60e01b14806103fe57506103fe826109e3565b92915050565b606060038054610413906117c0565b80601f016020809104026020016040519081016040528092919081815260200182805461043f906117c0565b801561048c5780601f106104615761010080835404028352916020019161048c565b820191906000526020600020905b81548152906001019060200180831161046f57829003601f168201915b5050505050905090565b60006104a3338484610a18565b50600192915050565b60006104b9848484610b3c565b6001600160a01b0384166000908152600160209081526040808320338452909152902054828110156105435760405162461bcd60e51b815260206004820152602860248201527f45524332303a207472616e7366657220616d6f756e74206578636565647320616044820152676c6c6f77616e636560c01b60648201526084015b60405180910390fd5b6105508533858403610a18565b506001949350505050565b6105658282610d17565b600082815260066020526040902061057d90826109ce565b505050565b61058c8282610d3d565b600082815260066020526040902061057d9082610db7565b3360008181526001602090815260408083206001600160a01b038716845290915281205490916104a39185906105db90869061172f565b610a18565b61060a7f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a336107d7565b61067c5760405162461bcd60e51b815260206004820152603960248201527f45524332305072657365744d696e7465725061757365723a206d75737420686160448201527f76652070617573657220726f6c6520746f20756e706175736500000000000000606482015260840161053a565b610684610dcc565b565b6106903382610e5f565b50565b600061069f8333610387565b9050818110156106fd5760405162461bcd60e51b8152602060048201526024808201527f45524332303a206275726e20616d6f756e74206578636565647320616c6c6f77604482015263616e636560e01b606482015260840161053a565b61070a8333848403610a18565b61057d8383610e5f565b61073e7f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a336107d7565b6107b05760405162461bcd60e51b815260206004820152603760248201527f45524332305072657365744d696e7465725061757365723a206d75737420686160448201527f76652070617573657220726f6c6520746f207061757365000000000000000000606482015260840161053a565b610684610fb9565b60008281526006602052604081206107d09083611034565b9392505050565b60009182526005602090815260408084206001600160a01b0393909316845291905290205460ff1690565b606060048054610413906117c0565b3360009081526001602090815260408083206001600160a01b0386168452909152812054828110156108935760405162461bcd60e51b815260206004820152602560248201527f45524332303a2064656372656173656420616c6c6f77616e63652062656c6f77604482015264207a65726f60d81b606482015260840161053a565b6108a03385858403610a18565b5060019392505050565b60006104a3338484610b3c565b60008181526006602052604081206103fe90611040565b61058c828261104a565b6001600160a01b03821661092e5760405162461bcd60e51b815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f206164647265737300604482015260640161053a565b61093a60008383611070565b806002600082825461094c919061172f565b90915550506001600160a01b0382166000908152602081905260408120805483929061097990849061172f565b90915550506040518181526001600160a01b038316906000907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a35b5050565b6109c082826110d6565b60006107d0836001600160a01b03841661115c565b60006001600160e01b03198216637965db0b60e01b14806103fe57506301ffc9a760e01b6001600160e01b03198316146103fe565b6001600160a01b038316610a7a5760405162461bcd60e51b8152602060048201526024808201527f45524332303a20617070726f76652066726f6d20746865207a65726f206164646044820152637265737360e01b606482015260840161053a565b6001600160a01b038216610adb5760405162461bcd60e51b815260206004820152602260248201527f45524332303a20617070726f766520746f20746865207a65726f206164647265604482015261737360f01b606482015260840161053a565b6001600160a01b0383811660008181526001602090815260408083209487168084529482529182902085905590518481527f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925910160405180910390a3505050565b6001600160a01b038316610ba05760405162461bcd60e51b815260206004820152602560248201527f45524332303a207472616e736665722066726f6d20746865207a65726f206164604482015264647265737360d81b606482015260840161053a565b6001600160a01b038216610c025760405162461bcd60e51b815260206004820152602360248201527f45524332303a207472616e7366657220746f20746865207a65726f206164647260448201526265737360e81b606482015260840161053a565b610c0d838383611070565b6001600160a01b03831660009081526020819052604090205481811015610c855760405162461bcd60e51b815260206004820152602660248201527f45524332303a207472616e7366657220616d6f756e7420657863656564732062604482015265616c616e636560d01b606482015260840161053a565b6001600160a01b03808516600090815260208190526040808220858503905591851681529081208054849290610cbc90849061172f565b92505081905550826001600160a01b0316846001600160a01b03167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef84604051610d0891815260200190565b60405180910390a35b50505050565b600082815260056020526040902060010154610d3381336111ab565b61057d83836110d6565b6001600160a01b0381163314610dad5760405162461bcd60e51b815260206004820152602f60248201527f416363657373436f6e74726f6c3a2063616e206f6e6c792072656e6f756e636560448201526e103937b632b9903337b91039b2b63360891b606482015260840161053a565b6109c0828261120f565b60006107d0836001600160a01b038416611276565b60075460ff16610e155760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b604482015260640161053a565b6007805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa335b6040516001600160a01b03909116815260200160405180910390a1565b6001600160a01b038216610ebf5760405162461bcd60e51b815260206004820152602160248201527f45524332303a206275726e2066726f6d20746865207a65726f206164647265736044820152607360f81b606482015260840161053a565b610ecb82600083611070565b6001600160a01b03821660009081526020819052604090205481811015610f3f5760405162461bcd60e51b815260206004820152602260248201527f45524332303a206275726e20616d6f756e7420657863656564732062616c616e604482015261636560f01b606482015260840161053a565b6001600160a01b0383166000908152602081905260408120838303905560028054849290610f6e908490611766565b90915550506040518281526000906001600160a01b038516907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a3505050565b60075460ff1615610fff5760405162461bcd60e51b815260206004820152601060248201526f14185d5cd8589b194e881c185d5cd95960821b604482015260640161053a565b6007805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610e423390565b60006107d08383611369565b60006103fe825490565b60008281526005602052604090206001015461106681336111ab565b61057d838361120f565b60075460ff161561057d5760405162461bcd60e51b815260206004820152602a60248201527f45524332305061757361626c653a20746f6b656e207472616e736665722077686044820152691a5b19481c185d5cd95960b21b606482015260840161053a565b6110e082826107d7565b6109c05760008281526005602090815260408083206001600160a01b03851684529091529020805460ff191660011790556111183390565b6001600160a01b0316816001600160a01b0316837f2f8788117e7eff1d82e926ec794901d17c78024a50270940304540a733656f0d60405160405180910390a45050565b60008181526001830160205260408120546111a3575081546001818101845560008481526020808220909301849055845484825282860190935260409020919091556103fe565b5060006103fe565b6111b582826107d7565b6109c0576111cd816001600160a01b03166014611393565b6111d8836020611393565b6040516020016111e9929190611687565b60408051601f198184030181529082905262461bcd60e51b825261053a916004016116fc565b61121982826107d7565b156109c05760008281526005602090815260408083206001600160a01b0385168085529252808320805460ff1916905551339285917ff6391f5c32d9c69d2a47ea670b442974b53935d1edc7fd64eb21e047a839171b9190a45050565b6000818152600183016020526040812054801561135f57600061129a600183611766565b85549091506000906112ae90600190611766565b90508181146113135760008660000182815481106112ce576112ce611827565b90600052602060002001549050808760000184815481106112f1576112f1611827565b6000918252602080832090910192909255918252600188019052604090208390555b855486908061132457611324611811565b6001900381819060005260206000200160009055905585600101600086815260200190815260200160002060009055600193505050506103fe565b60009150506103fe565b600082600001828154811061138057611380611827565b9060005260206000200154905092915050565b606060006113a2836002611747565b6113ad90600261172f565b67ffffffffffffffff8111156113c5576113c561183d565b6040519080825280601f01601f1916602001820160405280156113ef576020820181803683370190505b509050600360fc1b8160008151811061140a5761140a611827565b60200101906001600160f81b031916908160001a905350600f60fb1b8160018151811061143957611439611827565b60200101906001600160f81b031916908160001a905350600061145d846002611747565b61146890600161172f565b90505b60018111156114e0576f181899199a1a9b1b9c1cb0b131b232b360811b85600f166010811061149c5761149c611827565b1a60f81b8282815181106114b2576114b2611827565b60200101906001600160f81b031916908160001a90535060049490941c936114d9816117a9565b905061146b565b5083156107d05760405162461bcd60e51b815260206004820181905260248201527f537472696e67733a20686578206c656e67746820696e73756666696369656e74604482015260640161053a565b80356001600160a01b038116811461154657600080fd5b919050565b60006020828403121561155d57600080fd5b6107d08261152f565b6000806040838503121561157957600080fd5b6115828361152f565b91506115906020840161152f565b90509250929050565b6000806000606084860312156115ae57600080fd5b6115b78461152f565b92506115c56020850161152f565b9150604084013590509250925092565b600080604083850312156115e857600080fd5b6115f18361152f565b946020939093013593505050565b60006020828403121561161157600080fd5b5035919050565b6000806040838503121561162b57600080fd5b823591506115906020840161152f565b6000806040838503121561164e57600080fd5b50508035926020909101359150565b60006020828403121561166f57600080fd5b81356001600160e01b0319811681146107d057600080fd5b7f416363657373436f6e74726f6c3a206163636f756e74200000000000000000008152600083516116bf81601785016020880161177d565b7001034b99036b4b9b9b4b733903937b6329607d1b60179184019182015283516116f081602884016020880161177d565b01602801949350505050565b602081526000825180602084015261171b81604085016020870161177d565b601f01601f19169190910160400192915050565b60008219821115611742576117426117fb565b500190565b6000816000190483118215151615611761576117616117fb565b500290565b600082821015611778576117786117fb565b500390565b60005b83811015611798578181015183820152602001611780565b83811115610d115750506000910152565b6000816117b8576117b86117fb565b506000190190565b600181811c908216806117d457607f821691505b602082108114156117f557634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052601160045260246000fd5b634e487b7160e01b600052603160045260246000fd5b634e487b7160e01b600052603260045260246000fd5b634e487b7160e01b600052604160045260246000fdfea2646970667358221220d4f5ef11168399f590f08580bb56ab345c5a8d87308fb63d26019f599d318d3e64736f6c63430008060033";
        public ICHBurnPauseERC20DeploymentBase() : base(BYTECODE) { }
        public ICHBurnPauseERC20DeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "donateAddress", 1)]
        public virtual string DonateAddress { get; set; }
        [Parameter("string", "name_", 2)]
        public virtual string Name_ { get; set; }
        [Parameter("string", "symbol_", 3)]
        public virtual string Symbol_ { get; set; }
        [Parameter("uint256", "initialSupply", 4)]
        public virtual BigInteger InitialSupply { get; set; }
        [Parameter("address", "owner", 5)]
        public virtual string Owner { get; set; }
    }

    public partial class DEFAULT_ADMIN_ROLEFunction : DEFAULT_ADMIN_ROLEFunctionBase { }

    [Function("DEFAULT_ADMIN_ROLE", "bytes32")]
    public class DEFAULT_ADMIN_ROLEFunctionBase : FunctionMessage
    {

    }

    public partial class PAUSER_ROLEFunction : PAUSER_ROLEFunctionBase { }

    [Function("PAUSER_ROLE", "bytes32")]
    public class PAUSER_ROLEFunctionBase : FunctionMessage
    {

    }

    public partial class AllowanceFunction : AllowanceFunctionBase { }

    [Function("allowance", "uint256")]
    public class AllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("address", "spender", 2)]
        public virtual string Spender { get; set; }
    }

    public partial class ApproveFunction : ApproveFunctionBase { }

    [Function("approve", "bool")]
    public class ApproveFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender", 1)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class BalanceOfFunction : BalanceOfFunctionBase { }

    [Function("balanceOf", "uint256")]
    public class BalanceOfFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
    }

    public partial class BurnFunction : BurnFunctionBase { }

    [Function("burn")]
    public class BurnFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "amount", 1)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class BurnFromFunction : BurnFromFunctionBase { }

    [Function("burnFrom")]
    public class BurnFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("uint256", "amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class DecimalsFunction : DecimalsFunctionBase { }

    [Function("decimals", "uint8")]
    public class DecimalsFunctionBase : FunctionMessage
    {

    }

    public partial class DecreaseAllowanceFunction : DecreaseAllowanceFunctionBase { }

    [Function("decreaseAllowance", "bool")]
    public class DecreaseAllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender", 1)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "subtractedValue", 2)]
        public virtual BigInteger SubtractedValue { get; set; }
    }

    public partial class GetRoleAdminFunction : GetRoleAdminFunctionBase { }

    [Function("getRoleAdmin", "bytes32")]
    public class GetRoleAdminFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
    }

    public partial class GetRoleMemberFunction : GetRoleMemberFunctionBase { }

    [Function("getRoleMember", "address")]
    public class GetRoleMemberFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("uint256", "index", 2)]
        public virtual BigInteger Index { get; set; }
    }

    public partial class GetRoleMemberCountFunction : GetRoleMemberCountFunctionBase { }

    [Function("getRoleMemberCount", "uint256")]
    public class GetRoleMemberCountFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
    }

    public partial class GrantRoleFunction : GrantRoleFunctionBase { }

    [Function("grantRole")]
    public class GrantRoleFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
    }

    public partial class HasRoleFunction : HasRoleFunctionBase { }

    [Function("hasRole", "bool")]
    public class HasRoleFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
    }

    public partial class IncreaseAllowanceFunction : IncreaseAllowanceFunctionBase { }

    [Function("increaseAllowance", "bool")]
    public class IncreaseAllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender", 1)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "addedValue", 2)]
        public virtual BigInteger AddedValue { get; set; }
    }

    public partial class NameFunction : NameFunctionBase { }

    [Function("name", "string")]
    public class NameFunctionBase : FunctionMessage
    {

    }

    public partial class PauseFunction : PauseFunctionBase { }

    [Function("pause")]
    public class PauseFunctionBase : FunctionMessage
    {

    }

    public partial class PausedFunction : PausedFunctionBase { }

    [Function("paused", "bool")]
    public class PausedFunctionBase : FunctionMessage
    {

    }

    public partial class RenounceRoleFunction : RenounceRoleFunctionBase { }

    [Function("renounceRole")]
    public class RenounceRoleFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
    }

    public partial class RevokeRoleFunction : RevokeRoleFunctionBase { }

    [Function("revokeRole")]
    public class RevokeRoleFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
    }

    public partial class SupportsInterfaceFunction : SupportsInterfaceFunctionBase { }

    [Function("supportsInterface", "bool")]
    public class SupportsInterfaceFunctionBase : FunctionMessage
    {
        [Parameter("bytes4", "interfaceId", 1)]
        public virtual byte[] InterfaceId { get; set; }
    }

    public partial class SymbolFunction : SymbolFunctionBase { }

    [Function("symbol", "string")]
    public class SymbolFunctionBase : FunctionMessage
    {

    }

    public partial class TotalSupplyFunction : TotalSupplyFunctionBase { }

    [Function("totalSupply", "uint256")]
    public class TotalSupplyFunctionBase : FunctionMessage
    {

    }

    public partial class TransferFunction : TransferFunctionBase { }

    [Function("transfer", "bool")]
    public class TransferFunctionBase : FunctionMessage
    {
        [Parameter("address", "recipient", 1)]
        public virtual string Recipient { get; set; }
        [Parameter("uint256", "amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class TransferFromFunction : TransferFromFunctionBase { }

    [Function("transferFrom", "bool")]
    public class TransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "sender", 1)]
        public virtual string Sender { get; set; }
        [Parameter("address", "recipient", 2)]
        public virtual string Recipient { get; set; }
        [Parameter("uint256", "amount", 3)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class UnpauseFunction : UnpauseFunctionBase { }

    [Function("unpause")]
    public class UnpauseFunctionBase : FunctionMessage
    {

    }

    public partial class ApprovalEventDTO : ApprovalEventDTOBase { }

    [Event("Approval")]
    public class ApprovalEventDTOBase : IEventDTO
    {
        [Parameter("address", "owner", 1, true )]
        public virtual string Owner { get; set; }
        [Parameter("address", "spender", 2, true )]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "value", 3, false )]
        public virtual BigInteger Value { get; set; }
    }

    public partial class PaidForContractDeploymentEventDTO : PaidForContractDeploymentEventDTOBase { }

    [Event("PaidForContractDeployment")]
    public class PaidForContractDeploymentEventDTOBase : IEventDTO
    {
        [Parameter("address", "_from", 1, true )]
        public virtual string From { get; set; }
        [Parameter("address", "_to", 2, true )]
        public virtual string To { get; set; }
        [Parameter("address", "_for", 3, true )]
        public virtual string For { get; set; }
        [Parameter("uint256", "_value", 4, false )]
        public virtual BigInteger Value { get; set; }
    }

    public partial class PausedEventDTO : PausedEventDTOBase { }

    [Event("Paused")]
    public class PausedEventDTOBase : IEventDTO
    {
        [Parameter("address", "account", 1, false )]
        public virtual string Account { get; set; }
    }

    public partial class RoleAdminChangedEventDTO : RoleAdminChangedEventDTOBase { }

    [Event("RoleAdminChanged")]
    public class RoleAdminChangedEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "role", 1, true )]
        public virtual byte[] Role { get; set; }
        [Parameter("bytes32", "previousAdminRole", 2, true )]
        public virtual byte[] PreviousAdminRole { get; set; }
        [Parameter("bytes32", "newAdminRole", 3, true )]
        public virtual byte[] NewAdminRole { get; set; }
    }

    public partial class RoleGrantedEventDTO : RoleGrantedEventDTOBase { }

    [Event("RoleGranted")]
    public class RoleGrantedEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "role", 1, true )]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2, true )]
        public virtual string Account { get; set; }
        [Parameter("address", "sender", 3, true )]
        public virtual string Sender { get; set; }
    }

    public partial class RoleRevokedEventDTO : RoleRevokedEventDTOBase { }

    [Event("RoleRevoked")]
    public class RoleRevokedEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "role", 1, true )]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2, true )]
        public virtual string Account { get; set; }
        [Parameter("address", "sender", 3, true )]
        public virtual string Sender { get; set; }
    }

    public partial class TransferEventDTO : TransferEventDTOBase { }

    [Event("Transfer")]
    public class TransferEventDTOBase : IEventDTO
    {
        [Parameter("address", "from", 1, true )]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2, true )]
        public virtual string To { get; set; }
        [Parameter("uint256", "value", 3, false )]
        public virtual BigInteger Value { get; set; }
    }

    public partial class UnpausedEventDTO : UnpausedEventDTOBase { }

    [Event("Unpaused")]
    public class UnpausedEventDTOBase : IEventDTO
    {
        [Parameter("address", "account", 1, false )]
        public virtual string Account { get; set; }
    }

    public partial class DEFAULT_ADMIN_ROLEOutputDTO : DEFAULT_ADMIN_ROLEOutputDTOBase { }

    [FunctionOutput]
    public class DEFAULT_ADMIN_ROLEOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class PAUSER_ROLEOutputDTO : PAUSER_ROLEOutputDTOBase { }

    [FunctionOutput]
    public class PAUSER_ROLEOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class AllowanceOutputDTO : AllowanceOutputDTOBase { }

    [FunctionOutput]
    public class AllowanceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class BalanceOfOutputDTO : BalanceOfOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }





    public partial class DecimalsOutputDTO : DecimalsOutputDTOBase { }

    [FunctionOutput]
    public class DecimalsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint8", "", 1)]
        public virtual byte ReturnValue1 { get; set; }
    }



    public partial class GetRoleAdminOutputDTO : GetRoleAdminOutputDTOBase { }

    [FunctionOutput]
    public class GetRoleAdminOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class GetRoleMemberOutputDTO : GetRoleMemberOutputDTOBase { }

    [FunctionOutput]
    public class GetRoleMemberOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetRoleMemberCountOutputDTO : GetRoleMemberCountOutputDTOBase { }

    [FunctionOutput]
    public class GetRoleMemberCountOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class HasRoleOutputDTO : HasRoleOutputDTOBase { }

    [FunctionOutput]
    public class HasRoleOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }



    public partial class NameOutputDTO : NameOutputDTOBase { }

    [FunctionOutput]
    public class NameOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class PausedOutputDTO : PausedOutputDTOBase { }

    [FunctionOutput]
    public class PausedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }





    public partial class SupportsInterfaceOutputDTO : SupportsInterfaceOutputDTOBase { }

    [FunctionOutput]
    public class SupportsInterfaceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class SymbolOutputDTO : SymbolOutputDTOBase { }

    [FunctionOutput]
    public class SymbolOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class TotalSupplyOutputDTO : TotalSupplyOutputDTOBase { }

    [FunctionOutput]
    public class TotalSupplyOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }






}
