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

namespace ICH.Solidity.Contracts.ICHOnlyMintERC20.ContractDefinition
{


    public partial class ICHOnlyMintERC20Deployment : ICHOnlyMintERC20DeploymentBase
    {
        public ICHOnlyMintERC20Deployment() : base(BYTECODE) { }
        public ICHOnlyMintERC20Deployment(string byteCode) : base(byteCode) { }
    }

    public class ICHOnlyMintERC20DeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405260405162001a7538038062001a7583398101604081905262000026916200053e565b8484848484818185858860003411620000865760405162461bcd60e51b815260206004820152601c60248201527f436f6d6d697373696f6e20666565206973206d697373696e67203a280000000060448201526064015b60405180910390fd5b6040516001600160a01b038216903480156108fc02916000818181858888f19350505050158015620000bc573d6000803e3d6000fd5b5060405134815230906001600160a01b0383169033907fd6a974817678441e8375d5235c138959cd0c5418161b40991a845df41c19b23e9060200160405180910390a450815162000115906003906020850190620003e1565b5080516200012b906004906020840190620003e1565b5050506200014581836200019260201b620007291760201c565b50505050505050620001877f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a6620001816200027860201b60201c565b6200027c565b505050505062000671565b6001600160a01b038216620001ea5760405162461bcd60e51b815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f20616464726573730060448201526064016200007d565b8060026000828254620001fe9190620005de565b90915550506001600160a01b038216600090815260208190526040812080548392906200022d908490620005de565b90915550506040518181526001600160a01b038316906000907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a35b5050565b3390565b620002938282620002bf60201b620008081760201c565b6000828152600660209081526040909120620002ba91839062000812620002cb821b17901c565b505050565b620002748282620002eb565b6000620002e2836001600160a01b0384166200038f565b90505b92915050565b60008281526005602090815260408083206001600160a01b038516845290915290205460ff16620002745760008281526005602090815260408083206001600160a01b03851684529091529020805460ff191660011790556200034b3390565b6001600160a01b0316816001600160a01b0316837f2f8788117e7eff1d82e926ec794901d17c78024a50270940304540a733656f0d60405160405180910390a45050565b6000818152600183016020526040812054620003d857508154600181810184556000848152602080822090930184905584548482528286019093526040902091909155620002e5565b506000620002e5565b828054620003ef9062000605565b90600052602060002090601f0160209004810192826200041357600085556200045e565b82601f106200042e57805160ff19168380011785556200045e565b828001600101855582156200045e579182015b828111156200045e57825182559160200191906001019062000441565b506200046c92915062000470565b5090565b5b808211156200046c576000815560010162000471565b600082601f8301126200049957600080fd5b81516001600160401b0380821115620004b657620004b662000642565b604051601f8301601f19908116603f01168101908282118183101715620004e157620004e162000642565b81604052838152602092508683858801011115620004fe57600080fd5b600091505b8382101562000522578582018301518183018401529082019062000503565b83821115620005345760008385830101525b9695505050505050565b600080600080600060a086880312156200055757600080fd5b8551620005648162000658565b60208701519095506001600160401b03808211156200058257600080fd5b6200059089838a0162000487565b95506040880151915080821115620005a757600080fd5b50620005b68882890162000487565b935050606086015191506080860151620005d08162000658565b809150509295509295909350565b600082198211156200060057634e487b7160e01b600052601160045260246000fd5b500190565b600181811c908216806200061a57607f821691505b602082108114156200063c57634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052604160045260246000fd5b6001600160a01b03811681146200066e57600080fd5b50565b6113f480620006816000396000f3fe608060405234801561001057600080fd5b50600436106101425760003560e01c806370a08231116100b8578063a457c2d71161007c578063a457c2d7146102b3578063a9059cbb146102c6578063ca15c873146102d9578063d5391393146102ec578063d547741f14610313578063dd62ed3e1461032657600080fd5b806370a082311461023c5780639010d07c1461026557806391d148541461029057806395d89b41146102a3578063a217fddf146102ab57600080fd5b8063248a9ca31161010a578063248a9ca3146101bc5780632f2ff15d146101df578063313ce567146101f457806336568abe14610203578063395093511461021657806340c10f191461022957600080fd5b806301ffc9a71461014757806306fdde031461016f578063095ea7b31461018457806318160ddd1461019757806323b872dd146101a9575b600080fd5b61015a6101553660046111c8565b61035f565b60405190151581526020015b60405180910390f35b61017761038a565b6040516101669190611267565b61015a610192366004611140565b61041c565b6002545b604051908152602001610166565b61015a6101b7366004611104565b610432565b61019b6101ca36600461116a565b60009081526005602052604090206001015490565b6101f26101ed366004611183565b6104e1565b005b60405160128152602001610166565b6101f2610211366004611183565b610508565b61015a610224366004611140565b61052a565b6101f2610237366004611140565b610566565b61019b61024a3660046110b6565b6001600160a01b031660009081526020819052604090205490565b6102786102733660046111a6565b610609565b6040516001600160a01b039091168152602001610166565b61015a61029e366004611183565b610628565b610177610653565b61019b600081565b61015a6102c1366004611140565b610662565b61015a6102d4366004611140565b6106fb565b61019b6102e736600461116a565b610708565b61019b7f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a681565b6101f2610321366004611183565b61071f565b61019b6103343660046110d1565b6001600160a01b03918216600090815260016020908152604080832093909416825291909152205490565b60006001600160e01b03198216635a05180f60e01b1480610384575061038482610827565b92915050565b6060600380546103999061132b565b80601f01602080910402602001604051908101604052809291908181526020018280546103c59061132b565b80156104125780601f106103e757610100808354040283529160200191610412565b820191906000526020600020905b8154815290600101906020018083116103f557829003601f168201915b5050505050905090565b600061042933848461085c565b50600192915050565b600061043f848484610980565b6001600160a01b0384166000908152600160209081526040808320338452909152902054828110156104c95760405162461bcd60e51b815260206004820152602860248201527f45524332303a207472616e7366657220616d6f756e74206578636565647320616044820152676c6c6f77616e636560c01b60648201526084015b60405180910390fd5b6104d6853385840361085c565b506001949350505050565b6104eb8282610b50565b60008281526006602052604090206105039082610812565b505050565b6105128282610b76565b60008281526006602052604090206105039082610bf0565b3360008181526001602090815260408083206001600160a01b0387168452909152812054909161042991859061056190869061129a565b61085c565b6105907f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a633610628565b6105fb5760405162461bcd60e51b815260206004820152603660248201527f45524332305072657365744d696e7465725061757365723a206d7573742068616044820152751d99481b5a5b9d195c881c9bdb19481d1bc81b5a5b9d60521b60648201526084016104c0565b6106058282610729565b5050565b60008281526006602052604081206106219083610c05565b9392505050565b60009182526005602090815260408084206001600160a01b0393909316845291905290205460ff1690565b6060600480546103999061132b565b3360009081526001602090815260408083206001600160a01b0386168452909152812054828110156106e45760405162461bcd60e51b815260206004820152602560248201527f45524332303a2064656372656173656420616c6c6f77616e63652062656c6f77604482015264207a65726f60d81b60648201526084016104c0565b6106f1338585840361085c565b5060019392505050565b6000610429338484610980565b600081815260066020526040812061038490610c11565b6105128282610c1b565b6001600160a01b03821661077f5760405162461bcd60e51b815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f20616464726573730060448201526064016104c0565b8060026000828254610791919061129a565b90915550506001600160a01b038216600090815260208190526040812080548392906107be90849061129a565b90915550506040518181526001600160a01b038316906000907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a35050565b6106058282610c41565b6000610621836001600160a01b038416610cc7565b60006001600160e01b03198216637965db0b60e01b148061038457506301ffc9a760e01b6001600160e01b0319831614610384565b6001600160a01b0383166108be5760405162461bcd60e51b8152602060048201526024808201527f45524332303a20617070726f76652066726f6d20746865207a65726f206164646044820152637265737360e01b60648201526084016104c0565b6001600160a01b03821661091f5760405162461bcd60e51b815260206004820152602260248201527f45524332303a20617070726f766520746f20746865207a65726f206164647265604482015261737360f01b60648201526084016104c0565b6001600160a01b0383811660008181526001602090815260408083209487168084529482529182902085905590518481527f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925910160405180910390a3505050565b6001600160a01b0383166109e45760405162461bcd60e51b815260206004820152602560248201527f45524332303a207472616e736665722066726f6d20746865207a65726f206164604482015264647265737360d81b60648201526084016104c0565b6001600160a01b038216610a465760405162461bcd60e51b815260206004820152602360248201527f45524332303a207472616e7366657220746f20746865207a65726f206164647260448201526265737360e81b60648201526084016104c0565b6001600160a01b03831660009081526020819052604090205481811015610abe5760405162461bcd60e51b815260206004820152602660248201527f45524332303a207472616e7366657220616d6f756e7420657863656564732062604482015265616c616e636560d01b60648201526084016104c0565b6001600160a01b03808516600090815260208190526040808220858503905591851681529081208054849290610af590849061129a565b92505081905550826001600160a01b0316846001600160a01b03167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef84604051610b4191815260200190565b60405180910390a35b50505050565b600082815260056020526040902060010154610b6c8133610d16565b6105038383610c41565b6001600160a01b0381163314610be65760405162461bcd60e51b815260206004820152602f60248201527f416363657373436f6e74726f6c3a2063616e206f6e6c792072656e6f756e636560448201526e103937b632b9903337b91039b2b63360891b60648201526084016104c0565b6106058282610d7a565b6000610621836001600160a01b038416610de1565b60006106218383610ed4565b6000610384825490565b600082815260056020526040902060010154610c378133610d16565b6105038383610d7a565b610c4b8282610628565b6106055760008281526005602090815260408083206001600160a01b03851684529091529020805460ff19166001179055610c833390565b6001600160a01b0316816001600160a01b0316837f2f8788117e7eff1d82e926ec794901d17c78024a50270940304540a733656f0d60405160405180910390a45050565b6000818152600183016020526040812054610d0e57508154600181810184556000848152602080822090930184905584548482528286019093526040902091909155610384565b506000610384565b610d208282610628565b61060557610d38816001600160a01b03166014610efe565b610d43836020610efe565b604051602001610d549291906111f2565b60408051601f198184030181529082905262461bcd60e51b82526104c091600401611267565b610d848282610628565b156106055760008281526005602090815260408083206001600160a01b0385168085529252808320805460ff1916905551339285917ff6391f5c32d9c69d2a47ea670b442974b53935d1edc7fd64eb21e047a839171b9190a45050565b60008181526001830160205260408120548015610eca576000610e056001836112d1565b8554909150600090610e19906001906112d1565b9050818114610e7e576000866000018281548110610e3957610e39611392565b9060005260206000200154905080876000018481548110610e5c57610e5c611392565b6000918252602080832090910192909255918252600188019052604090208390555b8554869080610e8f57610e8f61137c565b600190038181906000526020600020016000905590558560010160008681526020019081526020016000206000905560019350505050610384565b6000915050610384565b6000826000018281548110610eeb57610eeb611392565b9060005260206000200154905092915050565b60606000610f0d8360026112b2565b610f1890600261129a565b67ffffffffffffffff811115610f3057610f306113a8565b6040519080825280601f01601f191660200182016040528015610f5a576020820181803683370190505b509050600360fc1b81600081518110610f7557610f75611392565b60200101906001600160f81b031916908160001a905350600f60fb1b81600181518110610fa457610fa4611392565b60200101906001600160f81b031916908160001a9053506000610fc88460026112b2565b610fd390600161129a565b90505b600181111561104b576f181899199a1a9b1b9c1cb0b131b232b360811b85600f166010811061100757611007611392565b1a60f81b82828151811061101d5761101d611392565b60200101906001600160f81b031916908160001a90535060049490941c9361104481611314565b9050610fd6565b5083156106215760405162461bcd60e51b815260206004820181905260248201527f537472696e67733a20686578206c656e67746820696e73756666696369656e7460448201526064016104c0565b80356001600160a01b03811681146110b157600080fd5b919050565b6000602082840312156110c857600080fd5b6106218261109a565b600080604083850312156110e457600080fd5b6110ed8361109a565b91506110fb6020840161109a565b90509250929050565b60008060006060848603121561111957600080fd5b6111228461109a565b92506111306020850161109a565b9150604084013590509250925092565b6000806040838503121561115357600080fd5b61115c8361109a565b946020939093013593505050565b60006020828403121561117c57600080fd5b5035919050565b6000806040838503121561119657600080fd5b823591506110fb6020840161109a565b600080604083850312156111b957600080fd5b50508035926020909101359150565b6000602082840312156111da57600080fd5b81356001600160e01b03198116811461062157600080fd5b7f416363657373436f6e74726f6c3a206163636f756e742000000000000000000081526000835161122a8160178501602088016112e8565b7001034b99036b4b9b9b4b733903937b6329607d1b601791840191820152835161125b8160288401602088016112e8565b01602801949350505050565b60208152600082518060208401526112868160408501602087016112e8565b601f01601f19169190910160400192915050565b600082198211156112ad576112ad611366565b500190565b60008160001904831182151516156112cc576112cc611366565b500290565b6000828210156112e3576112e3611366565b500390565b60005b838110156113035781810151838201526020016112eb565b83811115610b4a5750506000910152565b60008161132357611323611366565b506000190190565b600181811c9082168061133f57607f821691505b6020821081141561136057634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052601160045260246000fd5b634e487b7160e01b600052603160045260246000fd5b634e487b7160e01b600052603260045260246000fd5b634e487b7160e01b600052604160045260246000fdfea2646970667358221220d40f7780df5e167df83d386c3bb694e4766b38f25676ed58f138c5dff2df625d64736f6c63430008060033";
        public ICHOnlyMintERC20DeploymentBase() : base(BYTECODE) { }
        public ICHOnlyMintERC20DeploymentBase(string byteCode) : base(byteCode) { }
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
