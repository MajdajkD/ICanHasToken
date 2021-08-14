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

namespace ICH.Solidity.Contracts.ICHBurnMintPauseCapERC20.ContractDefinition
{


    public partial class ICHBurnMintPauseCapERC20Deployment : ICHBurnMintPauseCapERC20DeploymentBase
    {
        public ICHBurnMintPauseCapERC20Deployment() : base(BYTECODE) { }
        public ICHBurnMintPauseCapERC20Deployment(string byteCode) : base(byteCode) { }
    }

    public class ICHBurnMintPauseCapERC20DeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "60a06040526040516200229d3803806200229d83398101604081905262000026916200065a565b828686868585818185858860003411620000875760405162461bcd60e51b815260206004820152601c60248201527f436f6d6d697373696f6e20666565206973206d697373696e67203a280000000060448201526064015b60405180910390fd5b6040516001600160a01b038216903480156108fc02916000818181858888f19350505050158015620000bd573d6000803e3d6000fd5b5060405134815230906001600160a01b0383169033907fd6a974817678441e8375d5235c138959cd0c5418161b40991a845df41c19b23e9060200160405180910390a450815162000116906003906020850190620004fd565b5080516200012c906004906020840190620004fd565b5050506200014681836200022060201b62000a1c1760201c565b50505050505050620001887f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a6620001826200031460201b60201c565b62000318565b6007805460ff19169055620001be7f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a3362000318565b60008111620002105760405162461bcd60e51b815260206004820152601560248201527f45524332304361707065643a206361702069732030000000000000000000000060448201526064016200007e565b6080525062000795945050505050565b6001600160a01b038216620002785760405162461bcd60e51b815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f20616464726573730060448201526064016200007e565b62000286600083836200035b565b80600260008282546200029a919062000702565b90915550506001600160a01b03821660009081526020819052604081208054839290620002c990849062000702565b90915550506040518181526001600160a01b038316906000907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a35b5050565b3390565b6200032f8282620003db60201b62000b071760201c565b60008281526006602090815260409091206200035691839062000b11620003e7821b17901c565b505050565b620003738383836200035660201b6200061e1760201c565b60075460ff1615620003565760405162461bcd60e51b815260206004820152602a60248201527f45524332305061757361626c653a20746f6b656e207472616e736665722077686044820152691a5b19481c185d5cd95960b21b60648201526084016200007e565b62000310828262000407565b6000620003fe836001600160a01b038416620004ab565b90505b92915050565b60008281526005602090815260408083206001600160a01b038516845290915290205460ff16620003105760008281526005602090815260408083206001600160a01b03851684529091529020805460ff19166001179055620004673390565b6001600160a01b0316816001600160a01b0316837f2f8788117e7eff1d82e926ec794901d17c78024a50270940304540a733656f0d60405160405180910390a45050565b6000818152600183016020526040812054620004f45750815460018181018455600084815260208082209093018490558454848252828601909352604090209190915562000401565b50600062000401565b8280546200050b9062000729565b90600052602060002090601f0160209004810192826200052f57600085556200057a565b82601f106200054a57805160ff19168380011785556200057a565b828001600101855582156200057a579182015b828111156200057a5782518255916020019190600101906200055d565b50620005889291506200058c565b5090565b5b808211156200058857600081556001016200058d565b600082601f830112620005b557600080fd5b81516001600160401b0380821115620005d257620005d262000766565b604051601f8301601f19908116603f01168101908282118183101715620005fd57620005fd62000766565b816040528381526020925086838588010111156200061a57600080fd5b600091505b838210156200063e57858201830151818301840152908201906200061f565b83821115620006505760008385830101525b9695505050505050565b60008060008060008060c087890312156200067457600080fd5b865162000681816200077c565b60208801519096506001600160401b03808211156200069f57600080fd5b620006ad8a838b01620005a3565b96506040890151915080821115620006c457600080fd5b50620006d389828a01620005a3565b945050606087015192506080870151915060a0870151620006f4816200077c565b809150509295509295509295565b600082198211156200072457634e487b7160e01b600052601160045260246000fd5b500190565b600181811c908216806200073e57607f821691505b602082108114156200076057634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052604160045260246000fd5b6001600160a01b03811681146200079257600080fd5b50565b608051611ade620007bf6000396000818161029201528181610fa401526115370152611ade6000f3fe608060405234801561001057600080fd5b50600436106101cf5760003560e01c80635c975abb11610104578063a217fddf116100a2578063d539139311610071578063d5391393146103e0578063d547741f14610407578063dd62ed3e1461041a578063e63ab1e91461045357600080fd5b8063a217fddf1461039f578063a457c2d7146103a7578063a9059cbb146103ba578063ca15c873146103cd57600080fd5b80638456cb59116100de5780638456cb59146103515780639010d07c1461035957806391d148541461038457806395d89b411461039757600080fd5b80635c975abb1461030a57806370a082311461031557806379cc67901461033e57600080fd5b8063313ce56711610171578063395093511161014b57806339509351146102c95780633f4ba83a146102dc57806340c10f19146102e457806342966c68146102f757600080fd5b8063313ce56714610281578063355274ea1461029057806336568abe146102b657600080fd5b806318160ddd116101ad57806318160ddd1461022457806323b872dd14610236578063248a9ca3146102495780632f2ff15d1461026c57600080fd5b806301ffc9a7146101d457806306fdde03146101fc578063095ea7b314610211575b600080fd5b6101e76101e23660046118b2565b61047a565b60405190151581526020015b60405180910390f35b6102046104a5565b6040516101f39190611951565b6101e761021f36600461182a565b610537565b6002545b6040519081526020016101f3565b6101e76102443660046117ee565b61054d565b610228610257366004611854565b60009081526005602052604090206001015490565b61027f61027a36600461186d565b6105fc565b005b604051601281526020016101f3565b7f0000000000000000000000000000000000000000000000000000000000000000610228565b61027f6102c436600461186d565b610623565b6101e76102d736600461182a565b610645565b61027f610681565b61027f6102f236600461182a565b610727565b61027f610305366004611854565b6107ca565b60075460ff166101e7565b6102286103233660046117a0565b6001600160a01b031660009081526020819052604090205490565b61027f61034c36600461182a565b6107d7565b61027f610858565b61036c610367366004611890565b6108fc565b6040516001600160a01b0390911681526020016101f3565b6101e761039236600461186d565b61091b565b610204610946565b610228600081565b6101e76103b536600461182a565b610955565b6101e76103c836600461182a565b6109ee565b6102286103db366004611854565b6109fb565b6102287f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a681565b61027f61041536600461186d565b610a12565b6102286104283660046117bb565b6001600160a01b03918216600090815260016020908152604080832093909416825291909152205490565b6102287f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a81565b60006001600160e01b03198216635a05180f60e01b148061049f575061049f82610b26565b92915050565b6060600380546104b490611a15565b80601f01602080910402602001604051908101604052809291908181526020018280546104e090611a15565b801561052d5780601f106105025761010080835404028352916020019161052d565b820191906000526020600020905b81548152906001019060200180831161051057829003601f168201915b5050505050905090565b6000610544338484610b5b565b50600192915050565b600061055a848484610c7f565b6001600160a01b0384166000908152600160209081526040808320338452909152902054828110156105e45760405162461bcd60e51b815260206004820152602860248201527f45524332303a207472616e7366657220616d6f756e74206578636565647320616044820152676c6c6f77616e636560c01b60648201526084015b60405180910390fd5b6105f18533858403610b5b565b506001949350505050565b6106068282610e5a565b600082815260066020526040902061061e9082610b11565b505050565b61062d8282610e80565b600082815260066020526040902061061e9082610efa565b3360008181526001602090815260408083206001600160a01b0387168452909152812054909161054491859061067c908690611984565b610b5b565b6106ab7f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a3361091b565b61071d5760405162461bcd60e51b815260206004820152603960248201527f45524332305072657365744d696e7465725061757365723a206d75737420686160448201527f76652070617573657220726f6c6520746f20756e70617573650000000000000060648201526084016105db565b610725610f0f565b565b6107517f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a63361091b565b6107bc5760405162461bcd60e51b815260206004820152603660248201527f45524332305072657365744d696e7465725061757365723a206d7573742068616044820152751d99481b5a5b9d195c881c9bdb19481d1bc81b5a5b9d60521b60648201526084016105db565b6107c68282610fa2565b5050565b6107d4338261102b565b50565b60006107e38333610428565b9050818110156108415760405162461bcd60e51b8152602060048201526024808201527f45524332303a206275726e20616d6f756e74206578636565647320616c6c6f77604482015263616e636560e01b60648201526084016105db565b61084e8333848403610b5b565b61061e838361102b565b6108827f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a3361091b565b6108f45760405162461bcd60e51b815260206004820152603760248201527f45524332305072657365744d696e7465725061757365723a206d75737420686160448201527f76652070617573657220726f6c6520746f20706175736500000000000000000060648201526084016105db565b610725611185565b60008281526006602052604081206109149083611200565b9392505050565b60009182526005602090815260408084206001600160a01b0393909316845291905290205460ff1690565b6060600480546104b490611a15565b3360009081526001602090815260408083206001600160a01b0386168452909152812054828110156109d75760405162461bcd60e51b815260206004820152602560248201527f45524332303a2064656372656173656420616c6c6f77616e63652062656c6f77604482015264207a65726f60d81b60648201526084016105db565b6109e43385858403610b5b565b5060019392505050565b6000610544338484610c7f565b600081815260066020526040812061049f9061120c565b61062d8282611216565b6001600160a01b038216610a725760405162461bcd60e51b815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f20616464726573730060448201526064016105db565b610a7e6000838361123c565b8060026000828254610a909190611984565b90915550506001600160a01b03821660009081526020819052604081208054839290610abd908490611984565b90915550506040518181526001600160a01b038316906000907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a35050565b6107c682826112a2565b6000610914836001600160a01b038416611328565b60006001600160e01b03198216637965db0b60e01b148061049f57506301ffc9a760e01b6001600160e01b031983161461049f565b6001600160a01b038316610bbd5760405162461bcd60e51b8152602060048201526024808201527f45524332303a20617070726f76652066726f6d20746865207a65726f206164646044820152637265737360e01b60648201526084016105db565b6001600160a01b038216610c1e5760405162461bcd60e51b815260206004820152602260248201527f45524332303a20617070726f766520746f20746865207a65726f206164647265604482015261737360f01b60648201526084016105db565b6001600160a01b0383811660008181526001602090815260408083209487168084529482529182902085905590518481527f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925910160405180910390a3505050565b6001600160a01b038316610ce35760405162461bcd60e51b815260206004820152602560248201527f45524332303a207472616e736665722066726f6d20746865207a65726f206164604482015264647265737360d81b60648201526084016105db565b6001600160a01b038216610d455760405162461bcd60e51b815260206004820152602360248201527f45524332303a207472616e7366657220746f20746865207a65726f206164647260448201526265737360e81b60648201526084016105db565b610d5083838361123c565b6001600160a01b03831660009081526020819052604090205481811015610dc85760405162461bcd60e51b815260206004820152602660248201527f45524332303a207472616e7366657220616d6f756e7420657863656564732062604482015265616c616e636560d01b60648201526084016105db565b6001600160a01b03808516600090815260208190526040808220858503905591851681529081208054849290610dff908490611984565b92505081905550826001600160a01b0316846001600160a01b03167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef84604051610e4b91815260200190565b60405180910390a35b50505050565b600082815260056020526040902060010154610e768133611377565b61061e83836112a2565b6001600160a01b0381163314610ef05760405162461bcd60e51b815260206004820152602f60248201527f416363657373436f6e74726f6c3a2063616e206f6e6c792072656e6f756e636560448201526e103937b632b9903337b91039b2b63360891b60648201526084016105db565b6107c682826113db565b6000610914836001600160a01b038416611442565b60075460ff16610f585760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b60448201526064016105db565b6007805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa335b6040516001600160a01b03909116815260200160405180910390a1565b7f000000000000000000000000000000000000000000000000000000000000000081610fcd60025490565b610fd79190611984565b11156110215760405162461bcd60e51b8152602060048201526019602482015278115490cc8c10d85c1c19590e8818d85c08195e18d959591959603a1b60448201526064016105db565b6107c68282611535565b6001600160a01b03821661108b5760405162461bcd60e51b815260206004820152602160248201527f45524332303a206275726e2066726f6d20746865207a65726f206164647265736044820152607360f81b60648201526084016105db565b6110978260008361123c565b6001600160a01b0382166000908152602081905260409020548181101561110b5760405162461bcd60e51b815260206004820152602260248201527f45524332303a206275726e20616d6f756e7420657863656564732062616c616e604482015261636560f01b60648201526084016105db565b6001600160a01b038316600090815260208190526040812083830390556002805484929061113a9084906119bb565b90915550506040518281526000906001600160a01b038516907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a3505050565b60075460ff16156111cb5760405162461bcd60e51b815260206004820152601060248201526f14185d5cd8589b194e881c185d5cd95960821b60448201526064016105db565b6007805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610f853390565b600061091483836115be565b600061049f825490565b6000828152600560205260409020600101546112328133611377565b61061e83836113db565b60075460ff161561061e5760405162461bcd60e51b815260206004820152602a60248201527f45524332305061757361626c653a20746f6b656e207472616e736665722077686044820152691a5b19481c185d5cd95960b21b60648201526084016105db565b6112ac828261091b565b6107c65760008281526005602090815260408083206001600160a01b03851684529091529020805460ff191660011790556112e43390565b6001600160a01b0316816001600160a01b0316837f2f8788117e7eff1d82e926ec794901d17c78024a50270940304540a733656f0d60405160405180910390a45050565b600081815260018301602052604081205461136f5750815460018181018455600084815260208082209093018490558454848252828601909352604090209190915561049f565b50600061049f565b611381828261091b565b6107c657611399816001600160a01b031660146115e8565b6113a48360206115e8565b6040516020016113b59291906118dc565b60408051601f198184030181529082905262461bcd60e51b82526105db91600401611951565b6113e5828261091b565b156107c65760008281526005602090815260408083206001600160a01b0385168085529252808320805460ff1916905551339285917ff6391f5c32d9c69d2a47ea670b442974b53935d1edc7fd64eb21e047a839171b9190a45050565b6000818152600183016020526040812054801561152b5760006114666001836119bb565b855490915060009061147a906001906119bb565b90508181146114df57600086600001828154811061149a5761149a611a7c565b90600052602060002001549050808760000184815481106114bd576114bd611a7c565b6000918252602080832090910192909255918252600188019052604090208390555b85548690806114f0576114f0611a66565b60019003818190600052602060002001600090559055856001016000868152602001908152602001600020600090556001935050505061049f565b600091505061049f565b7f00000000000000000000000000000000000000000000000000000000000000008161156060025490565b61156a9190611984565b11156115b45760405162461bcd60e51b8152602060048201526019602482015278115490cc8c10d85c1c19590e8818d85c08195e18d959591959603a1b60448201526064016105db565b6107c68282610a1c565b60008260000182815481106115d5576115d5611a7c565b9060005260206000200154905092915050565b606060006115f783600261199c565b611602906002611984565b67ffffffffffffffff81111561161a5761161a611a92565b6040519080825280601f01601f191660200182016040528015611644576020820181803683370190505b509050600360fc1b8160008151811061165f5761165f611a7c565b60200101906001600160f81b031916908160001a905350600f60fb1b8160018151811061168e5761168e611a7c565b60200101906001600160f81b031916908160001a90535060006116b284600261199c565b6116bd906001611984565b90505b6001811115611735576f181899199a1a9b1b9c1cb0b131b232b360811b85600f16601081106116f1576116f1611a7c565b1a60f81b82828151811061170757611707611a7c565b60200101906001600160f81b031916908160001a90535060049490941c9361172e816119fe565b90506116c0565b5083156109145760405162461bcd60e51b815260206004820181905260248201527f537472696e67733a20686578206c656e67746820696e73756666696369656e7460448201526064016105db565b80356001600160a01b038116811461179b57600080fd5b919050565b6000602082840312156117b257600080fd5b61091482611784565b600080604083850312156117ce57600080fd5b6117d783611784565b91506117e560208401611784565b90509250929050565b60008060006060848603121561180357600080fd5b61180c84611784565b925061181a60208501611784565b9150604084013590509250925092565b6000806040838503121561183d57600080fd5b61184683611784565b946020939093013593505050565b60006020828403121561186657600080fd5b5035919050565b6000806040838503121561188057600080fd5b823591506117e560208401611784565b600080604083850312156118a357600080fd5b50508035926020909101359150565b6000602082840312156118c457600080fd5b81356001600160e01b03198116811461091457600080fd5b7f416363657373436f6e74726f6c3a206163636f756e74200000000000000000008152600083516119148160178501602088016119d2565b7001034b99036b4b9b9b4b733903937b6329607d1b60179184019182015283516119458160288401602088016119d2565b01602801949350505050565b60208152600082518060208401526119708160408501602087016119d2565b601f01601f19169190910160400192915050565b6000821982111561199757611997611a50565b500190565b60008160001904831182151516156119b6576119b6611a50565b500290565b6000828210156119cd576119cd611a50565b500390565b60005b838110156119ed5781810151838201526020016119d5565b83811115610e545750506000910152565b600081611a0d57611a0d611a50565b506000190190565b600181811c90821680611a2957607f821691505b60208210811415611a4a57634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052601160045260246000fd5b634e487b7160e01b600052603160045260246000fd5b634e487b7160e01b600052603260045260246000fd5b634e487b7160e01b600052604160045260246000fdfea2646970667358221220ba1249f08efdbc99b8d486122d8f1670e969e9404165ab8bc85439af360f88e264736f6c63430008060033";
        public ICHBurnMintPauseCapERC20DeploymentBase() : base(BYTECODE) { }
        public ICHBurnMintPauseCapERC20DeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "donateAddress", 1)]
        public virtual string DonateAddress { get; set; }
        [Parameter("string", "name_", 2)]
        public virtual string Name_ { get; set; }
        [Parameter("string", "symbol_", 3)]
        public virtual string Symbol_ { get; set; }
        [Parameter("uint256", "cap", 4)]
        public virtual BigInteger Cap { get; set; }
        [Parameter("uint256", "initialSupply", 5)]
        public virtual BigInteger InitialSupply { get; set; }
        [Parameter("address", "owner", 6)]
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

    public partial class CapFunction : CapFunctionBase { }

    [Function("cap", "uint256")]
    public class CapFunctionBase : FunctionMessage
    {

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





    public partial class CapOutputDTO : CapOutputDTOBase { }

    [FunctionOutput]
    public class CapOutputDTOBase : IFunctionOutputDTO 
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
