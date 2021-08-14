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

namespace ICH.Solidity.Contracts.ICHOnlyBurnERC20.ContractDefinition
{


    public partial class ICHOnlyBurnERC20Deployment : ICHOnlyBurnERC20DeploymentBase
    {
        public ICHOnlyBurnERC20Deployment() : base(BYTECODE) { }
        public ICHOnlyBurnERC20Deployment(string byteCode) : base(byteCode) { }
    }

    public class ICHOnlyBurnERC20DeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "6080604052604051620010e6380380620010e6833981016040819052620000269162000399565b8484848484818185858860003411620000865760405162461bcd60e51b815260206004820152601c60248201527f436f6d6d697373696f6e20666565206973206d697373696e67203a280000000060448201526064015b60405180910390fd5b6040516001600160a01b038216903480156108fc02916000818181858888f19350505050158015620000bc573d6000803e3d6000fd5b5060405134815230906001600160a01b0383169033907fd6a974817678441e8375d5235c138959cd0c5418161b40991a845df41c19b23e9060200160405180910390a4508151620001159060039060208501906200023c565b5080516200012b9060049060208401906200023c565b5050506200014581836200015760201b620004ef1760201c565b505050505050505050505050620004cc565b6001600160a01b038216620001af5760405162461bcd60e51b815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f20616464726573730060448201526064016200007d565b8060026000828254620001c3919062000439565b90915550506001600160a01b03821660009081526020819052604081208054839290620001f290849062000439565b90915550506040518181526001600160a01b038316906000907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a35050565b8280546200024a9062000460565b90600052602060002090601f0160209004810192826200026e5760008555620002b9565b82601f106200028957805160ff1916838001178555620002b9565b82800160010185558215620002b9579182015b82811115620002b95782518255916020019190600101906200029c565b50620002c7929150620002cb565b5090565b5b80821115620002c75760008155600101620002cc565b600082601f830112620002f457600080fd5b81516001600160401b03808211156200031157620003116200049d565b604051601f8301601f19908116603f011681019082821181831017156200033c576200033c6200049d565b816040528381526020925086838588010111156200035957600080fd5b600091505b838210156200037d57858201830151818301840152908201906200035e565b838211156200038f5760008385830101525b9695505050505050565b600080600080600060a08688031215620003b257600080fd5b8551620003bf81620004b3565b60208701519095506001600160401b0380821115620003dd57600080fd5b620003eb89838a01620002e2565b955060408801519150808211156200040257600080fd5b506200041188828901620002e2565b9350506060860151915060808601516200042b81620004b3565b809150509295509295909350565b600082198211156200045b57634e487b7160e01b600052601160045260246000fd5b500190565b600181811c908216806200047557607f821691505b602082108114156200049757634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052604160045260246000fd5b6001600160a01b0381168114620004c957600080fd5b50565b610c0a80620004dc6000396000f3fe608060405234801561001057600080fd5b50600436106100cf5760003560e01c806342966c681161008c57806395d89b411161006657806395d89b41146101ad578063a457c2d7146101b5578063a9059cbb146101c8578063dd62ed3e146101db57600080fd5b806342966c681461015c57806370a082311461017157806379cc67901461019a57600080fd5b806306fdde03146100d4578063095ea7b3146100f257806318160ddd1461011557806323b872dd14610127578063313ce5671461013a5780633950935114610149575b600080fd5b6100dc610214565b6040516100e99190610aff565b60405180910390f35b610105610100366004610abc565b6102a6565b60405190151581526020016100e9565b6002545b6040519081526020016100e9565b610105610135366004610a80565b6102bc565b604051601281526020016100e9565b610105610157366004610abc565b61036b565b61016f61016a366004610ae6565b6103a7565b005b61011961017f366004610a2b565b6001600160a01b031660009081526020819052604090205490565b61016f6101a8366004610abc565b6103b4565b6100dc61043a565b6101056101c3366004610abc565b610449565b6101056101d6366004610abc565b6104e2565b6101196101e9366004610a4d565b6001600160a01b03918216600090815260016020908152604080832093909416825291909152205490565b60606003805461022390610b83565b80601f016020809104026020016040519081016040528092919081815260200182805461024f90610b83565b801561029c5780601f106102715761010080835404028352916020019161029c565b820191906000526020600020905b81548152906001019060200180831161027f57829003601f168201915b5050505050905090565b60006102b33384846105ce565b50600192915050565b60006102c98484846106f2565b6001600160a01b0384166000908152600160209081526040808320338452909152902054828110156103535760405162461bcd60e51b815260206004820152602860248201527f45524332303a207472616e7366657220616d6f756e74206578636565647320616044820152676c6c6f77616e636560c01b60648201526084015b60405180910390fd5b61036085338584036105ce565b506001949350505050565b3360008181526001602090815260408083206001600160a01b038716845290915281205490916102b39185906103a2908690610b54565b6105ce565b6103b133826108c1565b50565b60006103c083336101e9565b90508181101561041e5760405162461bcd60e51b8152602060048201526024808201527f45524332303a206275726e20616d6f756e74206578636565647320616c6c6f77604482015263616e636560e01b606482015260840161034a565b61042b83338484036105ce565b61043583836108c1565b505050565b60606004805461022390610b83565b3360009081526001602090815260408083206001600160a01b0386168452909152812054828110156104cb5760405162461bcd60e51b815260206004820152602560248201527f45524332303a2064656372656173656420616c6c6f77616e63652062656c6f77604482015264207a65726f60d81b606482015260840161034a565b6104d833858584036105ce565b5060019392505050565b60006102b33384846106f2565b6001600160a01b0382166105455760405162461bcd60e51b815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f206164647265737300604482015260640161034a565b80600260008282546105579190610b54565b90915550506001600160a01b03821660009081526020819052604081208054839290610584908490610b54565b90915550506040518181526001600160a01b038316906000907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a35050565b6001600160a01b0383166106305760405162461bcd60e51b8152602060048201526024808201527f45524332303a20617070726f76652066726f6d20746865207a65726f206164646044820152637265737360e01b606482015260840161034a565b6001600160a01b0382166106915760405162461bcd60e51b815260206004820152602260248201527f45524332303a20617070726f766520746f20746865207a65726f206164647265604482015261737360f01b606482015260840161034a565b6001600160a01b0383811660008181526001602090815260408083209487168084529482529182902085905590518481527f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925910160405180910390a3505050565b6001600160a01b0383166107565760405162461bcd60e51b815260206004820152602560248201527f45524332303a207472616e736665722066726f6d20746865207a65726f206164604482015264647265737360d81b606482015260840161034a565b6001600160a01b0382166107b85760405162461bcd60e51b815260206004820152602360248201527f45524332303a207472616e7366657220746f20746865207a65726f206164647260448201526265737360e81b606482015260840161034a565b6001600160a01b038316600090815260208190526040902054818110156108305760405162461bcd60e51b815260206004820152602660248201527f45524332303a207472616e7366657220616d6f756e7420657863656564732062604482015265616c616e636560d01b606482015260840161034a565b6001600160a01b03808516600090815260208190526040808220858503905591851681529081208054849290610867908490610b54565b92505081905550826001600160a01b0316846001600160a01b03167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef846040516108b391815260200190565b60405180910390a350505050565b6001600160a01b0382166109215760405162461bcd60e51b815260206004820152602160248201527f45524332303a206275726e2066726f6d20746865207a65726f206164647265736044820152607360f81b606482015260840161034a565b6001600160a01b038216600090815260208190526040902054818110156109955760405162461bcd60e51b815260206004820152602260248201527f45524332303a206275726e20616d6f756e7420657863656564732062616c616e604482015261636560f01b606482015260840161034a565b6001600160a01b03831660009081526020819052604081208383039055600280548492906109c4908490610b6c565b90915550506040518281526000906001600160a01b038516907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a3505050565b80356001600160a01b0381168114610a2657600080fd5b919050565b600060208284031215610a3d57600080fd5b610a4682610a0f565b9392505050565b60008060408385031215610a6057600080fd5b610a6983610a0f565b9150610a7760208401610a0f565b90509250929050565b600080600060608486031215610a9557600080fd5b610a9e84610a0f565b9250610aac60208501610a0f565b9150604084013590509250925092565b60008060408385031215610acf57600080fd5b610ad883610a0f565b946020939093013593505050565b600060208284031215610af857600080fd5b5035919050565b600060208083528351808285015260005b81811015610b2c57858101830151858201604001528201610b10565b81811115610b3e576000604083870101525b50601f01601f1916929092016040019392505050565b60008219821115610b6757610b67610bbe565b500190565b600082821015610b7e57610b7e610bbe565b500390565b600181811c90821680610b9757607f821691505b60208210811415610bb857634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052601160045260246000fdfea2646970667358221220c8ced4f649bcacc2f251734c0860e9c74495200e7f81b69b96c3d005389c58e764736f6c63430008060033";
        public ICHOnlyBurnERC20DeploymentBase() : base(BYTECODE) { }
        public ICHOnlyBurnERC20DeploymentBase(string byteCode) : base(byteCode) { }
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





    public partial class NameOutputDTO : NameOutputDTOBase { }

    [FunctionOutput]
    public class NameOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
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
