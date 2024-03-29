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

namespace ICH.Solidity.Contracts.ICHOnlyPauseERC20.ContractDefinition
{


    public partial class ICHOnlyPauseERC20Deployment : ICHOnlyPauseERC20DeploymentBase
    {
        public ICHOnlyPauseERC20Deployment() : base(BYTECODE) { }
        public ICHOnlyPauseERC20Deployment(string byteCode) : base(byteCode) { }
    }

    public class ICHOnlyPauseERC20DeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405260405162001d5538038062001d558339810160408190526200002691620005cd565b8484848484818185858860003411620000865760405162461bcd60e51b815260206004820152601c60248201527f436f6d6d697373696f6e20666565206973206d697373696e67203a280000000060448201526064015b60405180910390fd5b6040516001600160a01b038216903480156108fc02916000818181858888f19350505050158015620000bc573d6000803e3d6000fd5b5060405134815230906001600160a01b0383169033907fd6a974817678441e8375d5235c138959cd0c5418161b40991a845df41c19b23e9060200160405180910390a45081516200011590600390602085019062000470565b5080516200012b90600490602084019062000470565b5050506200014581836200019760201b620007ee1760201c565b50506007805460ff19169055506200018c93507f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a9250620001869150503390565b6200028b565b505050505062000700565b6001600160a01b038216620001ef5760405162461bcd60e51b815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f20616464726573730060448201526064016200007d565b620001fd60008383620002ce565b80600260008282546200021191906200066d565b90915550506001600160a01b03821660009081526020819052604081208054839290620002409084906200066d565b90915550506040518181526001600160a01b038316906000907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a35b5050565b620002a282826200034e60201b620008da1760201c565b6000828152600660209081526040909120620002c9918390620008e46200035a821b17901c565b505050565b620002e6838383620002c960201b620005211760201c565b60075460ff1615620002c95760405162461bcd60e51b815260206004820152602a60248201527f45524332305061757361626c653a20746f6b656e207472616e736665722077686044820152691a5b19481c185d5cd95960b21b60648201526084016200007d565b6200028782826200037a565b600062000371836001600160a01b0384166200041e565b90505b92915050565b60008281526005602090815260408083206001600160a01b038516845290915290205460ff16620002875760008281526005602090815260408083206001600160a01b03851684529091529020805460ff19166001179055620003da3390565b6001600160a01b0316816001600160a01b0316837f2f8788117e7eff1d82e926ec794901d17c78024a50270940304540a733656f0d60405160405180910390a45050565b6000818152600183016020526040812054620004675750815460018181018455600084815260208082209093018490558454848252828601909352604090209190915562000374565b50600062000374565b8280546200047e9062000694565b90600052602060002090601f016020900481019282620004a25760008555620004ed565b82601f10620004bd57805160ff1916838001178555620004ed565b82800160010185558215620004ed579182015b82811115620004ed578251825591602001919060010190620004d0565b50620004fb929150620004ff565b5090565b5b80821115620004fb576000815560010162000500565b600082601f8301126200052857600080fd5b81516001600160401b0380821115620005455762000545620006d1565b604051601f8301601f19908116603f01168101908282118183101715620005705762000570620006d1565b816040528381526020925086838588010111156200058d57600080fd5b600091505b83821015620005b1578582018301518183018401529082019062000592565b83821115620005c35760008385830101525b9695505050505050565b600080600080600060a08688031215620005e657600080fd5b8551620005f381620006e7565b60208701519095506001600160401b03808211156200061157600080fd5b6200061f89838a0162000516565b955060408801519150808211156200063657600080fd5b50620006458882890162000516565b9350506060860151915060808601516200065f81620006e7565b809150509295509295909350565b600082198211156200068f57634e487b7160e01b600052601160045260246000fd5b500190565b600181811c90821680620006a957607f821691505b60208210811415620006cb57634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052604160045260246000fd5b6001600160a01b0381168114620006fd57600080fd5b50565b61164580620007106000396000f3fe608060405234801561001057600080fd5b50600436106101585760003560e01c806370a08231116100c3578063a457c2d71161007c578063a457c2d7146102d1578063a9059cbb146102e4578063ca15c873146102f7578063d547741f1461030a578063dd62ed3e1461031d578063e63ab1e91461035657600080fd5b806370a08231146102525780638456cb591461027b5780639010d07c1461028357806391d14854146102ae57806395d89b41146102c1578063a217fddf146102c957600080fd5b80632f2ff15d116101155780632f2ff15d146101f5578063313ce5671461020a57806336568abe14610219578063395093511461022c5780633f4ba83a1461023f5780635c975abb1461024757600080fd5b806301ffc9a71461015d57806306fdde0314610185578063095ea7b31461019a57806318160ddd146101ad57806323b872dd146101bf578063248a9ca3146101d2575b600080fd5b61017061016b366004611419565b61037d565b60405190151581526020015b60405180910390f35b61018d6103a8565b60405161017c91906114b8565b6101706101a8366004611391565b61043a565b6002545b60405190815260200161017c565b6101706101cd366004611355565b610450565b6101b16101e03660046113bb565b60009081526005602052604090206001015490565b6102086102033660046113d4565b6104ff565b005b6040516012815260200161017c565b6102086102273660046113d4565b610526565b61017061023a366004611391565b610548565b610208610584565b60075460ff16610170565b6101b1610260366004611307565b6001600160a01b031660009081526020819052604090205490565b61020861062a565b6102966102913660046113f7565b6106ce565b6040516001600160a01b03909116815260200161017c565b6101706102bc3660046113d4565b6106ed565b61018d610718565b6101b1600081565b6101706102df366004611391565b610727565b6101706102f2366004611391565b6107c0565b6101b16103053660046113bb565b6107cd565b6102086103183660046113d4565b6107e4565b6101b161032b366004611322565b6001600160a01b03918216600090815260016020908152604080832093909416825291909152205490565b6101b17f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a81565b60006001600160e01b03198216635a05180f60e01b14806103a257506103a2826108f9565b92915050565b6060600380546103b79061157c565b80601f01602080910402602001604051908101604052809291908181526020018280546103e39061157c565b80156104305780601f1061040557610100808354040283529160200191610430565b820191906000526020600020905b81548152906001019060200180831161041357829003601f168201915b5050505050905090565b600061044733848461092e565b50600192915050565b600061045d848484610a52565b6001600160a01b0384166000908152600160209081526040808320338452909152902054828110156104e75760405162461bcd60e51b815260206004820152602860248201527f45524332303a207472616e7366657220616d6f756e74206578636565647320616044820152676c6c6f77616e636560c01b60648201526084015b60405180910390fd5b6104f4853385840361092e565b506001949350505050565b6105098282610c2d565b600082815260066020526040902061052190826108e4565b505050565b6105308282610c53565b60008281526006602052604090206105219082610ccd565b3360008181526001602090815260408083206001600160a01b0387168452909152812054909161044791859061057f9086906114eb565b61092e565b6105ae7f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a336106ed565b6106205760405162461bcd60e51b815260206004820152603960248201527f45524332305072657365744d696e7465725061757365723a206d75737420686160448201527f76652070617573657220726f6c6520746f20756e70617573650000000000000060648201526084016104de565b610628610ce2565b565b6106547f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a336106ed565b6106c65760405162461bcd60e51b815260206004820152603760248201527f45524332305072657365744d696e7465725061757365723a206d75737420686160448201527f76652070617573657220726f6c6520746f20706175736500000000000000000060648201526084016104de565b610628610d75565b60008281526006602052604081206106e69083610df0565b9392505050565b60009182526005602090815260408084206001600160a01b0393909316845291905290205460ff1690565b6060600480546103b79061157c565b3360009081526001602090815260408083206001600160a01b0386168452909152812054828110156107a95760405162461bcd60e51b815260206004820152602560248201527f45524332303a2064656372656173656420616c6c6f77616e63652062656c6f77604482015264207a65726f60d81b60648201526084016104de565b6107b6338585840361092e565b5060019392505050565b6000610447338484610a52565b60008181526006602052604081206103a290610dfc565b6105308282610e06565b6001600160a01b0382166108445760405162461bcd60e51b815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f20616464726573730060448201526064016104de565b61085060008383610e2c565b806002600082825461086291906114eb565b90915550506001600160a01b0382166000908152602081905260408120805483929061088f9084906114eb565b90915550506040518181526001600160a01b038316906000907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a35b5050565b6108d68282610e92565b60006106e6836001600160a01b038416610f18565b60006001600160e01b03198216637965db0b60e01b14806103a257506301ffc9a760e01b6001600160e01b03198316146103a2565b6001600160a01b0383166109905760405162461bcd60e51b8152602060048201526024808201527f45524332303a20617070726f76652066726f6d20746865207a65726f206164646044820152637265737360e01b60648201526084016104de565b6001600160a01b0382166109f15760405162461bcd60e51b815260206004820152602260248201527f45524332303a20617070726f766520746f20746865207a65726f206164647265604482015261737360f01b60648201526084016104de565b6001600160a01b0383811660008181526001602090815260408083209487168084529482529182902085905590518481527f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925910160405180910390a3505050565b6001600160a01b038316610ab65760405162461bcd60e51b815260206004820152602560248201527f45524332303a207472616e736665722066726f6d20746865207a65726f206164604482015264647265737360d81b60648201526084016104de565b6001600160a01b038216610b185760405162461bcd60e51b815260206004820152602360248201527f45524332303a207472616e7366657220746f20746865207a65726f206164647260448201526265737360e81b60648201526084016104de565b610b23838383610e2c565b6001600160a01b03831660009081526020819052604090205481811015610b9b5760405162461bcd60e51b815260206004820152602660248201527f45524332303a207472616e7366657220616d6f756e7420657863656564732062604482015265616c616e636560d01b60648201526084016104de565b6001600160a01b03808516600090815260208190526040808220858503905591851681529081208054849290610bd29084906114eb565b92505081905550826001600160a01b0316846001600160a01b03167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef84604051610c1e91815260200190565b60405180910390a35b50505050565b600082815260056020526040902060010154610c498133610f67565b6105218383610e92565b6001600160a01b0381163314610cc35760405162461bcd60e51b815260206004820152602f60248201527f416363657373436f6e74726f6c3a2063616e206f6e6c792072656e6f756e636560448201526e103937b632b9903337b91039b2b63360891b60648201526084016104de565b6108d68282610fcb565b60006106e6836001600160a01b038416611032565b60075460ff16610d2b5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b60448201526064016104de565b6007805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa335b6040516001600160a01b03909116815260200160405180910390a1565b60075460ff1615610dbb5760405162461bcd60e51b815260206004820152601060248201526f14185d5cd8589b194e881c185d5cd95960821b60448201526064016104de565b6007805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610d583390565b60006106e68383611125565b60006103a2825490565b600082815260056020526040902060010154610e228133610f67565b6105218383610fcb565b60075460ff16156105215760405162461bcd60e51b815260206004820152602a60248201527f45524332305061757361626c653a20746f6b656e207472616e736665722077686044820152691a5b19481c185d5cd95960b21b60648201526084016104de565b610e9c82826106ed565b6108d65760008281526005602090815260408083206001600160a01b03851684529091529020805460ff19166001179055610ed43390565b6001600160a01b0316816001600160a01b0316837f2f8788117e7eff1d82e926ec794901d17c78024a50270940304540a733656f0d60405160405180910390a45050565b6000818152600183016020526040812054610f5f575081546001818101845560008481526020808220909301849055845484825282860190935260409020919091556103a2565b5060006103a2565b610f7182826106ed565b6108d657610f89816001600160a01b0316601461114f565b610f9483602061114f565b604051602001610fa5929190611443565b60408051601f198184030181529082905262461bcd60e51b82526104de916004016114b8565b610fd582826106ed565b156108d65760008281526005602090815260408083206001600160a01b0385168085529252808320805460ff1916905551339285917ff6391f5c32d9c69d2a47ea670b442974b53935d1edc7fd64eb21e047a839171b9190a45050565b6000818152600183016020526040812054801561111b576000611056600183611522565b855490915060009061106a90600190611522565b90508181146110cf57600086600001828154811061108a5761108a6115e3565b90600052602060002001549050808760000184815481106110ad576110ad6115e3565b6000918252602080832090910192909255918252600188019052604090208390555b85548690806110e0576110e06115cd565b6001900381819060005260206000200160009055905585600101600086815260200190815260200160002060009055600193505050506103a2565b60009150506103a2565b600082600001828154811061113c5761113c6115e3565b9060005260206000200154905092915050565b6060600061115e836002611503565b6111699060026114eb565b67ffffffffffffffff811115611181576111816115f9565b6040519080825280601f01601f1916602001820160405280156111ab576020820181803683370190505b509050600360fc1b816000815181106111c6576111c66115e3565b60200101906001600160f81b031916908160001a905350600f60fb1b816001815181106111f5576111f56115e3565b60200101906001600160f81b031916908160001a9053506000611219846002611503565b6112249060016114eb565b90505b600181111561129c576f181899199a1a9b1b9c1cb0b131b232b360811b85600f1660108110611258576112586115e3565b1a60f81b82828151811061126e5761126e6115e3565b60200101906001600160f81b031916908160001a90535060049490941c9361129581611565565b9050611227565b5083156106e65760405162461bcd60e51b815260206004820181905260248201527f537472696e67733a20686578206c656e67746820696e73756666696369656e7460448201526064016104de565b80356001600160a01b038116811461130257600080fd5b919050565b60006020828403121561131957600080fd5b6106e6826112eb565b6000806040838503121561133557600080fd5b61133e836112eb565b915061134c602084016112eb565b90509250929050565b60008060006060848603121561136a57600080fd5b611373846112eb565b9250611381602085016112eb565b9150604084013590509250925092565b600080604083850312156113a457600080fd5b6113ad836112eb565b946020939093013593505050565b6000602082840312156113cd57600080fd5b5035919050565b600080604083850312156113e757600080fd5b8235915061134c602084016112eb565b6000806040838503121561140a57600080fd5b50508035926020909101359150565b60006020828403121561142b57600080fd5b81356001600160e01b0319811681146106e657600080fd5b7f416363657373436f6e74726f6c3a206163636f756e742000000000000000000081526000835161147b816017850160208801611539565b7001034b99036b4b9b9b4b733903937b6329607d1b60179184019182015283516114ac816028840160208801611539565b01602801949350505050565b60208152600082518060208401526114d7816040850160208701611539565b601f01601f19169190910160400192915050565b600082198211156114fe576114fe6115b7565b500190565b600081600019048311821515161561151d5761151d6115b7565b500290565b600082821015611534576115346115b7565b500390565b60005b8381101561155457818101518382015260200161153c565b83811115610c275750506000910152565b600081611574576115746115b7565b506000190190565b600181811c9082168061159057607f821691505b602082108114156115b157634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052601160045260246000fd5b634e487b7160e01b600052603160045260246000fd5b634e487b7160e01b600052603260045260246000fd5b634e487b7160e01b600052604160045260246000fdfea2646970667358221220a96f14f0ed3925b0f0109848dea94f14dd1b5fe1d203adaa8f8b82a3587d30d264736f6c63430008060033";
        public ICHOnlyPauseERC20DeploymentBase() : base(BYTECODE) { }
        public ICHOnlyPauseERC20DeploymentBase(string byteCode) : base(byteCode) { }
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
