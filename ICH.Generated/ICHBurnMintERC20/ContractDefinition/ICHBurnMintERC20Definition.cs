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

namespace ICH.Solidity.Contracts.ICHBurnMintERC20.ContractDefinition
{


    public partial class ICHBurnMintERC20Deployment : ICHBurnMintERC20DeploymentBase
    {
        public ICHBurnMintERC20Deployment() : base(BYTECODE) { }
        public ICHBurnMintERC20Deployment(string byteCode) : base(byteCode) { }
    }

    public class ICHBurnMintERC20DeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405260405162001c8d38038062001c8d83398101604081905262000026916200053e565b8484848484818185858860003411620000865760405162461bcd60e51b815260206004820152601c60248201527f436f6d6d697373696f6e20666565206973206d697373696e67203a280000000060448201526064015b60405180910390fd5b6040516001600160a01b038216903480156108fc02916000818181858888f19350505050158015620000bc573d6000803e3d6000fd5b5060405134815230906001600160a01b0383169033907fd6a974817678441e8375d5235c138959cd0c5418161b40991a845df41c19b23e9060200160405180910390a450815162000115906003906020850190620003e1565b5080516200012b906004906020840190620003e1565b5050506200014581836200019260201b620007f31760201c565b50505050505050620001877f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a6620001816200027860201b60201c565b6200027c565b505050505062000671565b6001600160a01b038216620001ea5760405162461bcd60e51b815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f20616464726573730060448201526064016200007d565b8060026000828254620001fe9190620005de565b90915550506001600160a01b038216600090815260208190526040812080548392906200022d908490620005de565b90915550506040518181526001600160a01b038316906000907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a35b5050565b3390565b620002938282620002bf60201b620008d21760201c565b6000828152600660209081526040909120620002ba918390620008dc620002cb821b17901c565b505050565b620002748282620002eb565b6000620002e2836001600160a01b0384166200038f565b90505b92915050565b60008281526005602090815260408083206001600160a01b038516845290915290205460ff16620002745760008281526005602090815260408083206001600160a01b03851684529091529020805460ff191660011790556200034b3390565b6001600160a01b0316816001600160a01b0316837f2f8788117e7eff1d82e926ec794901d17c78024a50270940304540a733656f0d60405160405180910390a45050565b6000818152600183016020526040812054620003d857508154600181810184556000848152602080822090930184905584548482528286019093526040902091909155620002e5565b506000620002e5565b828054620003ef9062000605565b90600052602060002090601f0160209004810192826200041357600085556200045e565b82601f106200042e57805160ff19168380011785556200045e565b828001600101855582156200045e579182015b828111156200045e57825182559160200191906001019062000441565b506200046c92915062000470565b5090565b5b808211156200046c576000815560010162000471565b600082601f8301126200049957600080fd5b81516001600160401b0380821115620004b657620004b662000642565b604051601f8301601f19908116603f01168101908282118183101715620004e157620004e162000642565b81604052838152602092508683858801011115620004fe57600080fd5b600091505b8382101562000522578582018301518183018401529082019062000503565b83821115620005345760008385830101525b9695505050505050565b600080600080600060a086880312156200055757600080fd5b8551620005648162000658565b60208701519095506001600160401b03808211156200058257600080fd5b6200059089838a0162000487565b95506040880151915080821115620005a757600080fd5b50620005b68882890162000487565b935050606086015191506080860151620005d08162000658565b809150509295509295909350565b600082198211156200060057634e487b7160e01b600052601160045260246000fd5b500190565b600181811c908216806200061a57607f821691505b602082108114156200063c57634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052604160045260246000fd5b6001600160a01b03811681146200066e57600080fd5b50565b61160c80620006816000396000f3fe608060405234801561001057600080fd5b50600436106101585760003560e01c806370a08231116100c3578063a457c2d71161007c578063a457c2d7146102ef578063a9059cbb14610302578063ca15c87314610315578063d539139314610328578063d547741f1461034f578063dd62ed3e1461036257600080fd5b806370a082311461026557806379cc67901461028e5780639010d07c146102a157806391d14854146102cc57806395d89b41146102df578063a217fddf146102e757600080fd5b80632f2ff15d116101155780632f2ff15d146101f5578063313ce5671461020a57806336568abe14610219578063395093511461022c57806340c10f191461023f57806342966c681461025257600080fd5b806301ffc9a71461015d57806306fdde0314610185578063095ea7b31461019a57806318160ddd146101ad57806323b872dd146101bf578063248a9ca3146101d2575b600080fd5b61017061016b3660046113e0565b61039b565b60405190151581526020015b60405180910390f35b61018d6103c6565b60405161017c919061147f565b6101706101a8366004611358565b610458565b6002545b60405190815260200161017c565b6101706101cd36600461131c565b61046e565b6101b16101e0366004611382565b60009081526005602052604090206001015490565b61020861020336600461139b565b61051d565b005b6040516012815260200161017c565b61020861022736600461139b565b610544565b61017061023a366004611358565b610566565b61020861024d366004611358565b6105a2565b610208610260366004611382565b610645565b6101b16102733660046112ce565b6001600160a01b031660009081526020819052604090205490565b61020861029c366004611358565b610652565b6102b46102af3660046113be565b6106d3565b6040516001600160a01b03909116815260200161017c565b6101706102da36600461139b565b6106f2565b61018d61071d565b6101b1600081565b6101706102fd366004611358565b61072c565b610170610310366004611358565b6107c5565b6101b1610323366004611382565b6107d2565b6101b17f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a681565b61020861035d36600461139b565b6107e9565b6101b16103703660046112e9565b6001600160a01b03918216600090815260016020908152604080832093909416825291909152205490565b60006001600160e01b03198216635a05180f60e01b14806103c057506103c0826108f1565b92915050565b6060600380546103d590611543565b80601f016020809104026020016040519081016040528092919081815260200182805461040190611543565b801561044e5780601f106104235761010080835404028352916020019161044e565b820191906000526020600020905b81548152906001019060200180831161043157829003601f168201915b5050505050905090565b6000610465338484610926565b50600192915050565b600061047b848484610a4a565b6001600160a01b0384166000908152600160209081526040808320338452909152902054828110156105055760405162461bcd60e51b815260206004820152602860248201527f45524332303a207472616e7366657220616d6f756e74206578636565647320616044820152676c6c6f77616e636560c01b60648201526084015b60405180910390fd5b6105128533858403610926565b506001949350505050565b6105278282610c1a565b600082815260066020526040902061053f90826108dc565b505050565b61054e8282610c40565b600082815260066020526040902061053f9082610cba565b3360008181526001602090815260408083206001600160a01b0387168452909152812054909161046591859061059d9086906114b2565b610926565b6105cc7f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a6336106f2565b6106375760405162461bcd60e51b815260206004820152603660248201527f45524332305072657365744d696e7465725061757365723a206d7573742068616044820152751d99481b5a5b9d195c881c9bdb19481d1bc81b5a5b9d60521b60648201526084016104fc565b61064182826107f3565b5050565b61064f3382610ccf565b50565b600061065e8333610370565b9050818110156106bc5760405162461bcd60e51b8152602060048201526024808201527f45524332303a206275726e20616d6f756e74206578636565647320616c6c6f77604482015263616e636560e01b60648201526084016104fc565b6106c98333848403610926565b61053f8383610ccf565b60008281526006602052604081206106eb9083610e1d565b9392505050565b60009182526005602090815260408084206001600160a01b0393909316845291905290205460ff1690565b6060600480546103d590611543565b3360009081526001602090815260408083206001600160a01b0386168452909152812054828110156107ae5760405162461bcd60e51b815260206004820152602560248201527f45524332303a2064656372656173656420616c6c6f77616e63652062656c6f77604482015264207a65726f60d81b60648201526084016104fc565b6107bb3385858403610926565b5060019392505050565b6000610465338484610a4a565b60008181526006602052604081206103c090610e29565b61054e8282610e33565b6001600160a01b0382166108495760405162461bcd60e51b815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f20616464726573730060448201526064016104fc565b806002600082825461085b91906114b2565b90915550506001600160a01b038216600090815260208190526040812080548392906108889084906114b2565b90915550506040518181526001600160a01b038316906000907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a35050565b6106418282610e59565b60006106eb836001600160a01b038416610edf565b60006001600160e01b03198216637965db0b60e01b14806103c057506301ffc9a760e01b6001600160e01b03198316146103c0565b6001600160a01b0383166109885760405162461bcd60e51b8152602060048201526024808201527f45524332303a20617070726f76652066726f6d20746865207a65726f206164646044820152637265737360e01b60648201526084016104fc565b6001600160a01b0382166109e95760405162461bcd60e51b815260206004820152602260248201527f45524332303a20617070726f766520746f20746865207a65726f206164647265604482015261737360f01b60648201526084016104fc565b6001600160a01b0383811660008181526001602090815260408083209487168084529482529182902085905590518481527f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925910160405180910390a3505050565b6001600160a01b038316610aae5760405162461bcd60e51b815260206004820152602560248201527f45524332303a207472616e736665722066726f6d20746865207a65726f206164604482015264647265737360d81b60648201526084016104fc565b6001600160a01b038216610b105760405162461bcd60e51b815260206004820152602360248201527f45524332303a207472616e7366657220746f20746865207a65726f206164647260448201526265737360e81b60648201526084016104fc565b6001600160a01b03831660009081526020819052604090205481811015610b885760405162461bcd60e51b815260206004820152602660248201527f45524332303a207472616e7366657220616d6f756e7420657863656564732062604482015265616c616e636560d01b60648201526084016104fc565b6001600160a01b03808516600090815260208190526040808220858503905591851681529081208054849290610bbf9084906114b2565b92505081905550826001600160a01b0316846001600160a01b03167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef84604051610c0b91815260200190565b60405180910390a35b50505050565b600082815260056020526040902060010154610c368133610f2e565b61053f8383610e59565b6001600160a01b0381163314610cb05760405162461bcd60e51b815260206004820152602f60248201527f416363657373436f6e74726f6c3a2063616e206f6e6c792072656e6f756e636560448201526e103937b632b9903337b91039b2b63360891b60648201526084016104fc565b6106418282610f92565b60006106eb836001600160a01b038416610ff9565b6001600160a01b038216610d2f5760405162461bcd60e51b815260206004820152602160248201527f45524332303a206275726e2066726f6d20746865207a65726f206164647265736044820152607360f81b60648201526084016104fc565b6001600160a01b03821660009081526020819052604090205481811015610da35760405162461bcd60e51b815260206004820152602260248201527f45524332303a206275726e20616d6f756e7420657863656564732062616c616e604482015261636560f01b60648201526084016104fc565b6001600160a01b0383166000908152602081905260408120838303905560028054849290610dd29084906114e9565b90915550506040518281526000906001600160a01b038516907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a3505050565b60006106eb83836110ec565b60006103c0825490565b600082815260056020526040902060010154610e4f8133610f2e565b61053f8383610f92565b610e6382826106f2565b6106415760008281526005602090815260408083206001600160a01b03851684529091529020805460ff19166001179055610e9b3390565b6001600160a01b0316816001600160a01b0316837f2f8788117e7eff1d82e926ec794901d17c78024a50270940304540a733656f0d60405160405180910390a45050565b6000818152600183016020526040812054610f26575081546001818101845560008481526020808220909301849055845484825282860190935260409020919091556103c0565b5060006103c0565b610f3882826106f2565b61064157610f50816001600160a01b03166014611116565b610f5b836020611116565b604051602001610f6c92919061140a565b60408051601f198184030181529082905262461bcd60e51b82526104fc9160040161147f565b610f9c82826106f2565b156106415760008281526005602090815260408083206001600160a01b0385168085529252808320805460ff1916905551339285917ff6391f5c32d9c69d2a47ea670b442974b53935d1edc7fd64eb21e047a839171b9190a45050565b600081815260018301602052604081205480156110e257600061101d6001836114e9565b8554909150600090611031906001906114e9565b9050818114611096576000866000018281548110611051576110516115aa565b9060005260206000200154905080876000018481548110611074576110746115aa565b6000918252602080832090910192909255918252600188019052604090208390555b85548690806110a7576110a7611594565b6001900381819060005260206000200160009055905585600101600086815260200190815260200160002060009055600193505050506103c0565b60009150506103c0565b6000826000018281548110611103576111036115aa565b9060005260206000200154905092915050565b606060006111258360026114ca565b6111309060026114b2565b67ffffffffffffffff811115611148576111486115c0565b6040519080825280601f01601f191660200182016040528015611172576020820181803683370190505b509050600360fc1b8160008151811061118d5761118d6115aa565b60200101906001600160f81b031916908160001a905350600f60fb1b816001815181106111bc576111bc6115aa565b60200101906001600160f81b031916908160001a90535060006111e08460026114ca565b6111eb9060016114b2565b90505b6001811115611263576f181899199a1a9b1b9c1cb0b131b232b360811b85600f166010811061121f5761121f6115aa565b1a60f81b828281518110611235576112356115aa565b60200101906001600160f81b031916908160001a90535060049490941c9361125c8161152c565b90506111ee565b5083156106eb5760405162461bcd60e51b815260206004820181905260248201527f537472696e67733a20686578206c656e67746820696e73756666696369656e7460448201526064016104fc565b80356001600160a01b03811681146112c957600080fd5b919050565b6000602082840312156112e057600080fd5b6106eb826112b2565b600080604083850312156112fc57600080fd5b611305836112b2565b9150611313602084016112b2565b90509250929050565b60008060006060848603121561133157600080fd5b61133a846112b2565b9250611348602085016112b2565b9150604084013590509250925092565b6000806040838503121561136b57600080fd5b611374836112b2565b946020939093013593505050565b60006020828403121561139457600080fd5b5035919050565b600080604083850312156113ae57600080fd5b82359150611313602084016112b2565b600080604083850312156113d157600080fd5b50508035926020909101359150565b6000602082840312156113f257600080fd5b81356001600160e01b0319811681146106eb57600080fd5b7f416363657373436f6e74726f6c3a206163636f756e7420000000000000000000815260008351611442816017850160208801611500565b7001034b99036b4b9b9b4b733903937b6329607d1b6017918401918201528351611473816028840160208801611500565b01602801949350505050565b602081526000825180602084015261149e816040850160208701611500565b601f01601f19169190910160400192915050565b600082198211156114c5576114c561157e565b500190565b60008160001904831182151516156114e4576114e461157e565b500290565b6000828210156114fb576114fb61157e565b500390565b60005b8381101561151b578181015183820152602001611503565b83811115610c145750506000910152565b60008161153b5761153b61157e565b506000190190565b600181811c9082168061155757607f821691505b6020821081141561157857634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052601160045260246000fd5b634e487b7160e01b600052603160045260246000fd5b634e487b7160e01b600052603260045260246000fd5b634e487b7160e01b600052604160045260246000fdfea264697066735822122009de29bcf1586f24e1ef80322904a7d7f977dea9e1eee4a5dead28017b473fbe64736f6c63430008060033";
        public ICHBurnMintERC20DeploymentBase() : base(BYTECODE) { }
        public ICHBurnMintERC20DeploymentBase(string byteCode) : base(byteCode) { }
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
