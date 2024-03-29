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

namespace ICH.Solidity.Contracts.ICHBurnMintPauseERC20.ContractDefinition
{


    public partial class ICHBurnMintPauseERC20Deployment : ICHBurnMintPauseERC20DeploymentBase
    {
        public ICHBurnMintPauseERC20Deployment() : base(BYTECODE) { }
        public ICHBurnMintPauseERC20Deployment(string byteCode) : base(byteCode) { }
    }

    public class ICHBurnMintPauseERC20DeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "6080604052604051620020e0380380620020e0833981016040819052620000269162000602565b8484848484818185858860003411620000865760405162461bcd60e51b815260206004820152601c60248201527f436f6d6d697373696f6e20666565206973206d697373696e67203a280000000060448201526064015b60405180910390fd5b6040516001600160a01b038216903480156108fc02916000818181858888f19350505050158015620000bc573d6000803e3d6000fd5b5060405134815230906001600160a01b0383169033907fd6a974817678441e8375d5235c138959cd0c5418161b40991a845df41c19b23e9060200160405180910390a450815162000115906003906020850190620004a5565b5080516200012b906004906020840190620004a5565b505050620001458183620001c860201b620009eb1760201c565b50505050505050620001877f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a662000181620002bc60201b60201c565b620002c0565b6007805460ff19169055620001bd7f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a33620002c0565b505050505062000735565b6001600160a01b038216620002205760405162461bcd60e51b815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f20616464726573730060448201526064016200007d565b6200022e6000838362000303565b8060026000828254620002429190620006a2565b90915550506001600160a01b0382166000908152602081905260408120805483929062000271908490620006a2565b90915550506040518181526001600160a01b038316906000907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a35b5050565b3390565b620002d782826200038360201b62000ad61760201c565b6000828152600660209081526040909120620002fe91839062000ae06200038f821b17901c565b505050565b6200031b838383620002fe60201b620005ed1760201c565b60075460ff1615620002fe5760405162461bcd60e51b815260206004820152602a60248201527f45524332305061757361626c653a20746f6b656e207472616e736665722077686044820152691a5b19481c185d5cd95960b21b60648201526084016200007d565b620002b88282620003af565b6000620003a6836001600160a01b03841662000453565b90505b92915050565b60008281526005602090815260408083206001600160a01b038516845290915290205460ff16620002b85760008281526005602090815260408083206001600160a01b03851684529091529020805460ff191660011790556200040f3390565b6001600160a01b0316816001600160a01b0316837f2f8788117e7eff1d82e926ec794901d17c78024a50270940304540a733656f0d60405160405180910390a45050565b60008181526001830160205260408120546200049c57508154600181810184556000848152602080822090930184905584548482528286019093526040902091909155620003a9565b506000620003a9565b828054620004b390620006c9565b90600052602060002090601f016020900481019282620004d7576000855562000522565b82601f10620004f257805160ff191683800117855562000522565b8280016001018555821562000522579182015b828111156200052257825182559160200191906001019062000505565b506200053092915062000534565b5090565b5b8082111562000530576000815560010162000535565b600082601f8301126200055d57600080fd5b81516001600160401b03808211156200057a576200057a62000706565b604051601f8301601f19908116603f01168101908282118183101715620005a557620005a562000706565b81604052838152602092508683858801011115620005c257600080fd5b600091505b83821015620005e65785820183015181830184015290820190620005c7565b83821115620005f85760008385830101525b9695505050505050565b600080600080600060a086880312156200061b57600080fd5b855162000628816200071c565b60208701519095506001600160401b03808211156200064657600080fd5b6200065489838a016200054b565b955060408801519150808211156200066b57600080fd5b506200067a888289016200054b565b93505060608601519150608086015162000694816200071c565b809150509295509295909350565b60008219821115620006c457634e487b7160e01b600052601160045260246000fd5b500190565b600181811c90821680620006de57607f821691505b602082108114156200070057634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052604160045260246000fd5b6001600160a01b03811681146200073257600080fd5b50565b61199b80620007456000396000f3fe608060405234801561001057600080fd5b50600436106101c45760003560e01c806370a08231116100f9578063a457c2d711610097578063d539139311610071578063d5391393146103af578063d547741f146103d6578063dd62ed3e146103e9578063e63ab1e91461042257600080fd5b8063a457c2d714610376578063a9059cbb14610389578063ca15c8731461039c57600080fd5b80639010d07c116100d35780639010d07c1461032857806391d148541461035357806395d89b4114610366578063a217fddf1461036e57600080fd5b806370a08231146102e457806379cc67901461030d5780638456cb591461032057600080fd5b8063313ce567116101665780633f4ba83a116101405780633f4ba83a146102ab57806340c10f19146102b357806342966c68146102c65780635c975abb146102d957600080fd5b8063313ce5671461027657806336568abe14610285578063395093511461029857600080fd5b806318160ddd116101a257806318160ddd1461021957806323b872dd1461022b578063248a9ca31461023e5780632f2ff15d1461026157600080fd5b806301ffc9a7146101c957806306fdde03146101f1578063095ea7b314610206575b600080fd5b6101dc6101d736600461176f565b610449565b60405190151581526020015b60405180910390f35b6101f9610474565b6040516101e8919061180e565b6101dc6102143660046116e7565b610506565b6002545b6040519081526020016101e8565b6101dc6102393660046116ab565b61051c565b61021d61024c366004611711565b60009081526005602052604090206001015490565b61027461026f36600461172a565b6105cb565b005b604051601281526020016101e8565b61027461029336600461172a565b6105f2565b6101dc6102a63660046116e7565b610614565b610274610650565b6102746102c13660046116e7565b6106f6565b6102746102d4366004611711565b610799565b60075460ff166101dc565b61021d6102f236600461165d565b6001600160a01b031660009081526020819052604090205490565b61027461031b3660046116e7565b6107a6565b610274610827565b61033b61033636600461174d565b6108cb565b6040516001600160a01b0390911681526020016101e8565b6101dc61036136600461172a565b6108ea565b6101f9610915565b61021d600081565b6101dc6103843660046116e7565b610924565b6101dc6103973660046116e7565b6109bd565b61021d6103aa366004611711565b6109ca565b61021d7f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a681565b6102746103e436600461172a565b6109e1565b61021d6103f7366004611678565b6001600160a01b03918216600090815260016020908152604080832093909416825291909152205490565b61021d7f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a81565b60006001600160e01b03198216635a05180f60e01b148061046e575061046e82610af5565b92915050565b606060038054610483906118d2565b80601f01602080910402602001604051908101604052809291908181526020018280546104af906118d2565b80156104fc5780601f106104d1576101008083540402835291602001916104fc565b820191906000526020600020905b8154815290600101906020018083116104df57829003601f168201915b5050505050905090565b6000610513338484610b2a565b50600192915050565b6000610529848484610c4e565b6001600160a01b0384166000908152600160209081526040808320338452909152902054828110156105b35760405162461bcd60e51b815260206004820152602860248201527f45524332303a207472616e7366657220616d6f756e74206578636565647320616044820152676c6c6f77616e636560c01b60648201526084015b60405180910390fd5b6105c08533858403610b2a565b506001949350505050565b6105d58282610e29565b60008281526006602052604090206105ed9082610ae0565b505050565b6105fc8282610e4f565b60008281526006602052604090206105ed9082610ec9565b3360008181526001602090815260408083206001600160a01b0387168452909152812054909161051391859061064b908690611841565b610b2a565b61067a7f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a336108ea565b6106ec5760405162461bcd60e51b815260206004820152603960248201527f45524332305072657365744d696e7465725061757365723a206d75737420686160448201527f76652070617573657220726f6c6520746f20756e70617573650000000000000060648201526084016105aa565b6106f4610ede565b565b6107207f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a6336108ea565b61078b5760405162461bcd60e51b815260206004820152603660248201527f45524332305072657365744d696e7465725061757365723a206d7573742068616044820152751d99481b5a5b9d195c881c9bdb19481d1bc81b5a5b9d60521b60648201526084016105aa565b61079582826109eb565b5050565b6107a33382610f71565b50565b60006107b283336103f7565b9050818110156108105760405162461bcd60e51b8152602060048201526024808201527f45524332303a206275726e20616d6f756e74206578636565647320616c6c6f77604482015263616e636560e01b60648201526084016105aa565b61081d8333848403610b2a565b6105ed8383610f71565b6108517f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a336108ea565b6108c35760405162461bcd60e51b815260206004820152603760248201527f45524332305072657365744d696e7465725061757365723a206d75737420686160448201527f76652070617573657220726f6c6520746f20706175736500000000000000000060648201526084016105aa565b6106f46110cb565b60008281526006602052604081206108e39083611146565b9392505050565b60009182526005602090815260408084206001600160a01b0393909316845291905290205460ff1690565b606060048054610483906118d2565b3360009081526001602090815260408083206001600160a01b0386168452909152812054828110156109a65760405162461bcd60e51b815260206004820152602560248201527f45524332303a2064656372656173656420616c6c6f77616e63652062656c6f77604482015264207a65726f60d81b60648201526084016105aa565b6109b33385858403610b2a565b5060019392505050565b6000610513338484610c4e565b600081815260066020526040812061046e90611152565b6105fc828261115c565b6001600160a01b038216610a415760405162461bcd60e51b815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f20616464726573730060448201526064016105aa565b610a4d60008383611182565b8060026000828254610a5f9190611841565b90915550506001600160a01b03821660009081526020819052604081208054839290610a8c908490611841565b90915550506040518181526001600160a01b038316906000907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a35050565b61079582826111e8565b60006108e3836001600160a01b03841661126e565b60006001600160e01b03198216637965db0b60e01b148061046e57506301ffc9a760e01b6001600160e01b031983161461046e565b6001600160a01b038316610b8c5760405162461bcd60e51b8152602060048201526024808201527f45524332303a20617070726f76652066726f6d20746865207a65726f206164646044820152637265737360e01b60648201526084016105aa565b6001600160a01b038216610bed5760405162461bcd60e51b815260206004820152602260248201527f45524332303a20617070726f766520746f20746865207a65726f206164647265604482015261737360f01b60648201526084016105aa565b6001600160a01b0383811660008181526001602090815260408083209487168084529482529182902085905590518481527f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925910160405180910390a3505050565b6001600160a01b038316610cb25760405162461bcd60e51b815260206004820152602560248201527f45524332303a207472616e736665722066726f6d20746865207a65726f206164604482015264647265737360d81b60648201526084016105aa565b6001600160a01b038216610d145760405162461bcd60e51b815260206004820152602360248201527f45524332303a207472616e7366657220746f20746865207a65726f206164647260448201526265737360e81b60648201526084016105aa565b610d1f838383611182565b6001600160a01b03831660009081526020819052604090205481811015610d975760405162461bcd60e51b815260206004820152602660248201527f45524332303a207472616e7366657220616d6f756e7420657863656564732062604482015265616c616e636560d01b60648201526084016105aa565b6001600160a01b03808516600090815260208190526040808220858503905591851681529081208054849290610dce908490611841565b92505081905550826001600160a01b0316846001600160a01b03167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef84604051610e1a91815260200190565b60405180910390a35b50505050565b600082815260056020526040902060010154610e4581336112bd565b6105ed83836111e8565b6001600160a01b0381163314610ebf5760405162461bcd60e51b815260206004820152602f60248201527f416363657373436f6e74726f6c3a2063616e206f6e6c792072656e6f756e636560448201526e103937b632b9903337b91039b2b63360891b60648201526084016105aa565b6107958282611321565b60006108e3836001600160a01b038416611388565b60075460ff16610f275760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b60448201526064016105aa565b6007805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa335b6040516001600160a01b03909116815260200160405180910390a1565b6001600160a01b038216610fd15760405162461bcd60e51b815260206004820152602160248201527f45524332303a206275726e2066726f6d20746865207a65726f206164647265736044820152607360f81b60648201526084016105aa565b610fdd82600083611182565b6001600160a01b038216600090815260208190526040902054818110156110515760405162461bcd60e51b815260206004820152602260248201527f45524332303a206275726e20616d6f756e7420657863656564732062616c616e604482015261636560f01b60648201526084016105aa565b6001600160a01b0383166000908152602081905260408120838303905560028054849290611080908490611878565b90915550506040518281526000906001600160a01b038516907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a3505050565b60075460ff16156111115760405162461bcd60e51b815260206004820152601060248201526f14185d5cd8589b194e881c185d5cd95960821b60448201526064016105aa565b6007805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610f543390565b60006108e3838361147b565b600061046e825490565b60008281526005602052604090206001015461117881336112bd565b6105ed8383611321565b60075460ff16156105ed5760405162461bcd60e51b815260206004820152602a60248201527f45524332305061757361626c653a20746f6b656e207472616e736665722077686044820152691a5b19481c185d5cd95960b21b60648201526084016105aa565b6111f282826108ea565b6107955760008281526005602090815260408083206001600160a01b03851684529091529020805460ff1916600117905561122a3390565b6001600160a01b0316816001600160a01b0316837f2f8788117e7eff1d82e926ec794901d17c78024a50270940304540a733656f0d60405160405180910390a45050565b60008181526001830160205260408120546112b55750815460018181018455600084815260208082209093018490558454848252828601909352604090209190915561046e565b50600061046e565b6112c782826108ea565b610795576112df816001600160a01b031660146114a5565b6112ea8360206114a5565b6040516020016112fb929190611799565b60408051601f198184030181529082905262461bcd60e51b82526105aa9160040161180e565b61132b82826108ea565b156107955760008281526005602090815260408083206001600160a01b0385168085529252808320805460ff1916905551339285917ff6391f5c32d9c69d2a47ea670b442974b53935d1edc7fd64eb21e047a839171b9190a45050565b600081815260018301602052604081205480156114715760006113ac600183611878565b85549091506000906113c090600190611878565b90508181146114255760008660000182815481106113e0576113e0611939565b906000526020600020015490508087600001848154811061140357611403611939565b6000918252602080832090910192909255918252600188019052604090208390555b855486908061143657611436611923565b60019003818190600052602060002001600090559055856001016000868152602001908152602001600020600090556001935050505061046e565b600091505061046e565b600082600001828154811061149257611492611939565b9060005260206000200154905092915050565b606060006114b4836002611859565b6114bf906002611841565b67ffffffffffffffff8111156114d7576114d761194f565b6040519080825280601f01601f191660200182016040528015611501576020820181803683370190505b509050600360fc1b8160008151811061151c5761151c611939565b60200101906001600160f81b031916908160001a905350600f60fb1b8160018151811061154b5761154b611939565b60200101906001600160f81b031916908160001a905350600061156f846002611859565b61157a906001611841565b90505b60018111156115f2576f181899199a1a9b1b9c1cb0b131b232b360811b85600f16601081106115ae576115ae611939565b1a60f81b8282815181106115c4576115c4611939565b60200101906001600160f81b031916908160001a90535060049490941c936115eb816118bb565b905061157d565b5083156108e35760405162461bcd60e51b815260206004820181905260248201527f537472696e67733a20686578206c656e67746820696e73756666696369656e7460448201526064016105aa565b80356001600160a01b038116811461165857600080fd5b919050565b60006020828403121561166f57600080fd5b6108e382611641565b6000806040838503121561168b57600080fd5b61169483611641565b91506116a260208401611641565b90509250929050565b6000806000606084860312156116c057600080fd5b6116c984611641565b92506116d760208501611641565b9150604084013590509250925092565b600080604083850312156116fa57600080fd5b61170383611641565b946020939093013593505050565b60006020828403121561172357600080fd5b5035919050565b6000806040838503121561173d57600080fd5b823591506116a260208401611641565b6000806040838503121561176057600080fd5b50508035926020909101359150565b60006020828403121561178157600080fd5b81356001600160e01b0319811681146108e357600080fd5b7f416363657373436f6e74726f6c3a206163636f756e74200000000000000000008152600083516117d181601785016020880161188f565b7001034b99036b4b9b9b4b733903937b6329607d1b601791840191820152835161180281602884016020880161188f565b01602801949350505050565b602081526000825180602084015261182d81604085016020870161188f565b601f01601f19169190910160400192915050565b600082198211156118545761185461190d565b500190565b60008160001904831182151516156118735761187361190d565b500290565b60008282101561188a5761188a61190d565b500390565b60005b838110156118aa578181015183820152602001611892565b83811115610e235750506000910152565b6000816118ca576118ca61190d565b506000190190565b600181811c908216806118e657607f821691505b6020821081141561190757634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052601160045260246000fd5b634e487b7160e01b600052603160045260246000fd5b634e487b7160e01b600052603260045260246000fd5b634e487b7160e01b600052604160045260246000fdfea264697066735822122091801f620825116ca97f609304e0e887d136ea89a705959cd7f211d2d86f69f064736f6c63430008060033";
        public ICHBurnMintPauseERC20DeploymentBase() : base(BYTECODE) { }
        public ICHBurnMintPauseERC20DeploymentBase(string byteCode) : base(byteCode) { }
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
