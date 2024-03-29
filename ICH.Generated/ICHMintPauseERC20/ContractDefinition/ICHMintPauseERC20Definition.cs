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

namespace ICH.Solidity.Contracts.ICHMintPauseERC20.ContractDefinition
{


    public partial class ICHMintPauseERC20Deployment : ICHMintPauseERC20DeploymentBase
    {
        public ICHMintPauseERC20Deployment() : base(BYTECODE) { }
        public ICHMintPauseERC20Deployment(string byteCode) : base(byteCode) { }
    }

    public class ICHMintPauseERC20DeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405260405162001e9c38038062001e9c833981016040819052620000269162000602565b8484848484818185858860003411620000865760405162461bcd60e51b815260206004820152601c60248201527f436f6d6d697373696f6e20666565206973206d697373696e67203a280000000060448201526064015b60405180910390fd5b6040516001600160a01b038216903480156108fc02916000818181858888f19350505050158015620000bc573d6000803e3d6000fd5b5060405134815230906001600160a01b0383169033907fd6a974817678441e8375d5235c138959cd0c5418161b40991a845df41c19b23e9060200160405180910390a450815162000115906003906020850190620004a5565b5080516200012b906004906020840190620004a5565b505050620001458183620001c860201b620009011760201c565b50505050505050620001877f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a662000181620002bc60201b60201c565b620002c0565b6007805460ff19169055620001bd7f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a33620002c0565b505050505062000735565b6001600160a01b038216620002205760405162461bcd60e51b815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f20616464726573730060448201526064016200007d565b6200022e6000838362000303565b8060026000828254620002429190620006a2565b90915550506001600160a01b0382166000908152602081905260408120805483929062000271908490620006a2565b90915550506040518181526001600160a01b038316906000907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a35b5050565b3390565b620002d782826200038360201b620009ec1760201c565b6000828152600660209081526040909120620002fe918390620009f66200038f821b17901c565b505050565b6200031b838383620002fe60201b620005911760201c565b60075460ff1615620002fe5760405162461bcd60e51b815260206004820152602a60248201527f45524332305061757361626c653a20746f6b656e207472616e736665722077686044820152691a5b19481c185d5cd95960b21b60648201526084016200007d565b620002b88282620003af565b6000620003a6836001600160a01b03841662000453565b90505b92915050565b60008281526005602090815260408083206001600160a01b038516845290915290205460ff16620002b85760008281526005602090815260408083206001600160a01b03851684529091529020805460ff191660011790556200040f3390565b6001600160a01b0316816001600160a01b0316837f2f8788117e7eff1d82e926ec794901d17c78024a50270940304540a733656f0d60405160405180910390a45050565b60008181526001830160205260408120546200049c57508154600181810184556000848152602080822090930184905584548482528286019093526040902091909155620003a9565b506000620003a9565b828054620004b390620006c9565b90600052602060002090601f016020900481019282620004d7576000855562000522565b82601f10620004f257805160ff191683800117855562000522565b8280016001018555821562000522579182015b828111156200052257825182559160200191906001019062000505565b506200053092915062000534565b5090565b5b8082111562000530576000815560010162000535565b600082601f8301126200055d57600080fd5b81516001600160401b03808211156200057a576200057a62000706565b604051601f8301601f19908116603f01168101908282118183101715620005a557620005a562000706565b81604052838152602092508683858801011115620005c257600080fd5b600091505b83821015620005e65785820183015181830184015290820190620005c7565b83821115620005f85760008385830101525b9695505050505050565b600080600080600060a086880312156200061b57600080fd5b855162000628816200071c565b60208701519095506001600160401b03808211156200064657600080fd5b6200065489838a016200054b565b955060408801519150808211156200066b57600080fd5b506200067a888289016200054b565b93505060608601519150608086015162000694816200071c565b809150509295509295909350565b60008219821115620006c457634e487b7160e01b600052601160045260246000fd5b500190565b600181811c90821680620006de57607f821691505b602082108114156200070057634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052604160045260246000fd5b6001600160a01b03811681146200073257600080fd5b50565b61175780620007456000396000f3fe608060405234801561001057600080fd5b506004361061018e5760003560e01c806370a08231116100de578063a457c2d711610097578063d539139311610071578063d539139314610353578063d547741f1461037a578063dd62ed3e1461038d578063e63ab1e9146103c657600080fd5b8063a457c2d71461031a578063a9059cbb1461032d578063ca15c8731461034057600080fd5b806370a082311461029b5780638456cb59146102c45780639010d07c146102cc57806391d14854146102f757806395d89b411461030a578063a217fddf1461031257600080fd5b80632f2ff15d1161014b578063395093511161012557806339509351146102625780633f4ba83a1461027557806340c10f191461027d5780635c975abb1461029057600080fd5b80632f2ff15d1461022b578063313ce5671461024057806336568abe1461024f57600080fd5b806301ffc9a71461019357806306fdde03146101bb578063095ea7b3146101d057806318160ddd146101e357806323b872dd146101f5578063248a9ca314610208575b600080fd5b6101a66101a136600461152b565b6103ed565b60405190151581526020015b60405180910390f35b6101c3610418565b6040516101b291906115ca565b6101a66101de3660046114a3565b6104aa565b6002545b6040519081526020016101b2565b6101a6610203366004611467565b6104c0565b6101e76102163660046114cd565b60009081526005602052604090206001015490565b61023e6102393660046114e6565b61056f565b005b604051601281526020016101b2565b61023e61025d3660046114e6565b610596565b6101a66102703660046114a3565b6105b8565b61023e6105f4565b61023e61028b3660046114a3565b61069a565b60075460ff166101a6565b6101e76102a9366004611419565b6001600160a01b031660009081526020819052604090205490565b61023e61073d565b6102df6102da366004611509565b6107e1565b6040516001600160a01b0390911681526020016101b2565b6101a66103053660046114e6565b610800565b6101c361082b565b6101e7600081565b6101a66103283660046114a3565b61083a565b6101a661033b3660046114a3565b6108d3565b6101e761034e3660046114cd565b6108e0565b6101e77f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a681565b61023e6103883660046114e6565b6108f7565b6101e761039b366004611434565b6001600160a01b03918216600090815260016020908152604080832093909416825291909152205490565b6101e77f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a81565b60006001600160e01b03198216635a05180f60e01b1480610412575061041282610a0b565b92915050565b6060600380546104279061168e565b80601f01602080910402602001604051908101604052809291908181526020018280546104539061168e565b80156104a05780601f10610475576101008083540402835291602001916104a0565b820191906000526020600020905b81548152906001019060200180831161048357829003601f168201915b5050505050905090565b60006104b7338484610a40565b50600192915050565b60006104cd848484610b64565b6001600160a01b0384166000908152600160209081526040808320338452909152902054828110156105575760405162461bcd60e51b815260206004820152602860248201527f45524332303a207472616e7366657220616d6f756e74206578636565647320616044820152676c6c6f77616e636560c01b60648201526084015b60405180910390fd5b6105648533858403610a40565b506001949350505050565b6105798282610d3f565b600082815260066020526040902061059190826109f6565b505050565b6105a08282610d65565b60008281526006602052604090206105919082610ddf565b3360008181526001602090815260408083206001600160a01b038716845290915281205490916104b79185906105ef9086906115fd565b610a40565b61061e7f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a33610800565b6106905760405162461bcd60e51b815260206004820152603960248201527f45524332305072657365744d696e7465725061757365723a206d75737420686160448201527f76652070617573657220726f6c6520746f20756e706175736500000000000000606482015260840161054e565b610698610df4565b565b6106c47f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a633610800565b61072f5760405162461bcd60e51b815260206004820152603660248201527f45524332305072657365744d696e7465725061757365723a206d7573742068616044820152751d99481b5a5b9d195c881c9bdb19481d1bc81b5a5b9d60521b606482015260840161054e565b6107398282610901565b5050565b6107677f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a33610800565b6107d95760405162461bcd60e51b815260206004820152603760248201527f45524332305072657365744d696e7465725061757365723a206d75737420686160448201527f76652070617573657220726f6c6520746f207061757365000000000000000000606482015260840161054e565b610698610e87565b60008281526006602052604081206107f99083610f02565b9392505050565b60009182526005602090815260408084206001600160a01b0393909316845291905290205460ff1690565b6060600480546104279061168e565b3360009081526001602090815260408083206001600160a01b0386168452909152812054828110156108bc5760405162461bcd60e51b815260206004820152602560248201527f45524332303a2064656372656173656420616c6c6f77616e63652062656c6f77604482015264207a65726f60d81b606482015260840161054e565b6108c93385858403610a40565b5060019392505050565b60006104b7338484610b64565b600081815260066020526040812061041290610f0e565b6105a08282610f18565b6001600160a01b0382166109575760405162461bcd60e51b815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f206164647265737300604482015260640161054e565b61096360008383610f3e565b806002600082825461097591906115fd565b90915550506001600160a01b038216600090815260208190526040812080548392906109a29084906115fd565b90915550506040518181526001600160a01b038316906000907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a35050565b6107398282610fa4565b60006107f9836001600160a01b03841661102a565b60006001600160e01b03198216637965db0b60e01b148061041257506301ffc9a760e01b6001600160e01b0319831614610412565b6001600160a01b038316610aa25760405162461bcd60e51b8152602060048201526024808201527f45524332303a20617070726f76652066726f6d20746865207a65726f206164646044820152637265737360e01b606482015260840161054e565b6001600160a01b038216610b035760405162461bcd60e51b815260206004820152602260248201527f45524332303a20617070726f766520746f20746865207a65726f206164647265604482015261737360f01b606482015260840161054e565b6001600160a01b0383811660008181526001602090815260408083209487168084529482529182902085905590518481527f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925910160405180910390a3505050565b6001600160a01b038316610bc85760405162461bcd60e51b815260206004820152602560248201527f45524332303a207472616e736665722066726f6d20746865207a65726f206164604482015264647265737360d81b606482015260840161054e565b6001600160a01b038216610c2a5760405162461bcd60e51b815260206004820152602360248201527f45524332303a207472616e7366657220746f20746865207a65726f206164647260448201526265737360e81b606482015260840161054e565b610c35838383610f3e565b6001600160a01b03831660009081526020819052604090205481811015610cad5760405162461bcd60e51b815260206004820152602660248201527f45524332303a207472616e7366657220616d6f756e7420657863656564732062604482015265616c616e636560d01b606482015260840161054e565b6001600160a01b03808516600090815260208190526040808220858503905591851681529081208054849290610ce49084906115fd565b92505081905550826001600160a01b0316846001600160a01b03167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef84604051610d3091815260200190565b60405180910390a35b50505050565b600082815260056020526040902060010154610d5b8133611079565b6105918383610fa4565b6001600160a01b0381163314610dd55760405162461bcd60e51b815260206004820152602f60248201527f416363657373436f6e74726f6c3a2063616e206f6e6c792072656e6f756e636560448201526e103937b632b9903337b91039b2b63360891b606482015260840161054e565b61073982826110dd565b60006107f9836001600160a01b038416611144565b60075460ff16610e3d5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b604482015260640161054e565b6007805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa335b6040516001600160a01b03909116815260200160405180910390a1565b60075460ff1615610ecd5760405162461bcd60e51b815260206004820152601060248201526f14185d5cd8589b194e881c185d5cd95960821b604482015260640161054e565b6007805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610e6a3390565b60006107f98383611237565b6000610412825490565b600082815260056020526040902060010154610f348133611079565b61059183836110dd565b60075460ff16156105915760405162461bcd60e51b815260206004820152602a60248201527f45524332305061757361626c653a20746f6b656e207472616e736665722077686044820152691a5b19481c185d5cd95960b21b606482015260840161054e565b610fae8282610800565b6107395760008281526005602090815260408083206001600160a01b03851684529091529020805460ff19166001179055610fe63390565b6001600160a01b0316816001600160a01b0316837f2f8788117e7eff1d82e926ec794901d17c78024a50270940304540a733656f0d60405160405180910390a45050565b600081815260018301602052604081205461107157508154600181810184556000848152602080822090930184905584548482528286019093526040902091909155610412565b506000610412565b6110838282610800565b6107395761109b816001600160a01b03166014611261565b6110a6836020611261565b6040516020016110b7929190611555565b60408051601f198184030181529082905262461bcd60e51b825261054e916004016115ca565b6110e78282610800565b156107395760008281526005602090815260408083206001600160a01b0385168085529252808320805460ff1916905551339285917ff6391f5c32d9c69d2a47ea670b442974b53935d1edc7fd64eb21e047a839171b9190a45050565b6000818152600183016020526040812054801561122d576000611168600183611634565b855490915060009061117c90600190611634565b90508181146111e157600086600001828154811061119c5761119c6116f5565b90600052602060002001549050808760000184815481106111bf576111bf6116f5565b6000918252602080832090910192909255918252600188019052604090208390555b85548690806111f2576111f26116df565b600190038181906000526020600020016000905590558560010160008681526020019081526020016000206000905560019350505050610412565b6000915050610412565b600082600001828154811061124e5761124e6116f5565b9060005260206000200154905092915050565b60606000611270836002611615565b61127b9060026115fd565b67ffffffffffffffff8111156112935761129361170b565b6040519080825280601f01601f1916602001820160405280156112bd576020820181803683370190505b509050600360fc1b816000815181106112d8576112d86116f5565b60200101906001600160f81b031916908160001a905350600f60fb1b81600181518110611307576113076116f5565b60200101906001600160f81b031916908160001a905350600061132b846002611615565b6113369060016115fd565b90505b60018111156113ae576f181899199a1a9b1b9c1cb0b131b232b360811b85600f166010811061136a5761136a6116f5565b1a60f81b828281518110611380576113806116f5565b60200101906001600160f81b031916908160001a90535060049490941c936113a781611677565b9050611339565b5083156107f95760405162461bcd60e51b815260206004820181905260248201527f537472696e67733a20686578206c656e67746820696e73756666696369656e74604482015260640161054e565b80356001600160a01b038116811461141457600080fd5b919050565b60006020828403121561142b57600080fd5b6107f9826113fd565b6000806040838503121561144757600080fd5b611450836113fd565b915061145e602084016113fd565b90509250929050565b60008060006060848603121561147c57600080fd5b611485846113fd565b9250611493602085016113fd565b9150604084013590509250925092565b600080604083850312156114b657600080fd5b6114bf836113fd565b946020939093013593505050565b6000602082840312156114df57600080fd5b5035919050565b600080604083850312156114f957600080fd5b8235915061145e602084016113fd565b6000806040838503121561151c57600080fd5b50508035926020909101359150565b60006020828403121561153d57600080fd5b81356001600160e01b0319811681146107f957600080fd5b7f416363657373436f6e74726f6c3a206163636f756e742000000000000000000081526000835161158d81601785016020880161164b565b7001034b99036b4b9b9b4b733903937b6329607d1b60179184019182015283516115be81602884016020880161164b565b01602801949350505050565b60208152600082518060208401526115e981604085016020870161164b565b601f01601f19169190910160400192915050565b60008219821115611610576116106116c9565b500190565b600081600019048311821515161561162f5761162f6116c9565b500290565b600082821015611646576116466116c9565b500390565b60005b8381101561166657818101518382015260200161164e565b83811115610d395750506000910152565b600081611686576116866116c9565b506000190190565b600181811c908216806116a257607f821691505b602082108114156116c357634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052601160045260246000fd5b634e487b7160e01b600052603160045260246000fd5b634e487b7160e01b600052603260045260246000fd5b634e487b7160e01b600052604160045260246000fdfea2646970667358221220de6856a31a2ab26f866747f66344005349076c5ae5506f85c60d853a3fa7bf9764736f6c63430008060033";
        public ICHMintPauseERC20DeploymentBase() : base(BYTECODE) { }
        public ICHMintPauseERC20DeploymentBase(string byteCode) : base(byteCode) { }
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

    public partial class MINTER_ROLEFunction : MINTER_ROLEFunctionBase { }

    [Function("MINTER_ROLE", "bytes32")]
    public class MINTER_ROLEFunctionBase : FunctionMessage
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

    public partial class MintFunction : MintFunctionBase { }

    [Function("mint")]
    public class MintFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "amount", 2)]
        public virtual BigInteger Amount { get; set; }
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

    public partial class MINTER_ROLEOutputDTO : MINTER_ROLEOutputDTOBase { }

    [FunctionOutput]
    public class MINTER_ROLEOutputDTOBase : IFunctionOutputDTO 
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
