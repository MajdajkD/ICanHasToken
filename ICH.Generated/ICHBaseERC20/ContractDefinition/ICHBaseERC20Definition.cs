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

namespace ICH.Solidity.Contracts.ICHBaseERC20.ContractDefinition
{


    public partial class ICHBaseERC20Deployment : ICHBaseERC20DeploymentBase
    {
        public ICHBaseERC20Deployment() : base(BYTECODE) { }
        public ICHBaseERC20Deployment(string byteCode) : base(byteCode) { }
    }

    public class ICHBaseERC20DeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405260405162000e7538038062000e7583398101604081905262000026916200038f565b818185858860003411620000815760405162461bcd60e51b815260206004820152601c60248201527f436f6d6d697373696f6e20666565206973206d697373696e67203a280000000060448201526064015b60405180910390fd5b6040516001600160a01b038216903480156108fc02916000818181858888f19350505050158015620000b7573d6000803e3d6000fd5b5060405134815230906001600160a01b0383169033907fd6a974817678441e8375d5235c138959cd0c5418161b40991a845df41c19b23e9060200160405180910390a45081516200011090600390602085019062000232565b5080516200012690600490602084019062000232565b5050506200014081836200014d60201b6200040e1760201c565b50505050505050620004c2565b6001600160a01b038216620001a55760405162461bcd60e51b815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f206164647265737300604482015260640162000078565b8060026000828254620001b991906200042f565b90915550506001600160a01b03821660009081526020819052604081208054839290620001e89084906200042f565b90915550506040518181526001600160a01b038316906000907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a35050565b828054620002409062000456565b90600052602060002090601f016020900481019282620002645760008555620002af565b82601f106200027f57805160ff1916838001178555620002af565b82800160010185558215620002af579182015b82811115620002af57825182559160200191906001019062000292565b50620002bd929150620002c1565b5090565b5b80821115620002bd5760008155600101620002c2565b600082601f830112620002ea57600080fd5b81516001600160401b038082111562000307576200030762000493565b604051601f8301601f19908116603f0116810190828211818310171562000332576200033262000493565b816040528381526020925086838588010111156200034f57600080fd5b600091505b8382101562000373578582018301518183018401529082019062000354565b83821115620003855760008385830101525b9695505050505050565b600080600080600060a08688031215620003a857600080fd5b8551620003b581620004a9565b60208701519095506001600160401b0380821115620003d357600080fd5b620003e189838a01620002d8565b95506040880151915080821115620003f857600080fd5b506200040788828901620002d8565b9350506060860151915060808601516200042181620004a9565b809150509295509295909350565b600082198211156200045157634e487b7160e01b600052601160045260246000fd5b500190565b600181811c908216806200046b57607f821691505b602082108114156200048d57634e487b7160e01b600052602260045260246000fd5b50919050565b634e487b7160e01b600052604160045260246000fd5b6001600160a01b0381168114620004bf57600080fd5b50565b6109a380620004d26000396000f3fe608060405234801561001057600080fd5b50600436106100a95760003560e01c80633950935111610071578063395093511461012357806370a082311461013657806395d89b411461015f578063a457c2d714610167578063a9059cbb1461017a578063dd62ed3e1461018d57600080fd5b806306fdde03146100ae578063095ea7b3146100cc57806318160ddd146100ef57806323b872dd14610101578063313ce56714610114575b600080fd5b6100b66101c6565b6040516100c391906108b7565b60405180910390f35b6100df6100da36600461088d565b610258565b60405190151581526020016100c3565b6002545b6040519081526020016100c3565b6100df61010f366004610851565b61026e565b604051601281526020016100c3565b6100df61013136600461088d565b61031d565b6100f36101443660046107fc565b6001600160a01b031660009081526020819052604090205490565b6100b6610359565b6100df61017536600461088d565b610368565b6100df61018836600461088d565b610401565b6100f361019b36600461081e565b6001600160a01b03918216600090815260016020908152604080832093909416825291909152205490565b6060600380546101d590610932565b80601f016020809104026020016040519081016040528092919081815260200182805461020190610932565b801561024e5780601f106102235761010080835404028352916020019161024e565b820191906000526020600020905b81548152906001019060200180831161023157829003601f168201915b5050505050905090565b60006102653384846104ed565b50600192915050565b600061027b848484610611565b6001600160a01b0384166000908152600160209081526040808320338452909152902054828110156103055760405162461bcd60e51b815260206004820152602860248201527f45524332303a207472616e7366657220616d6f756e74206578636565647320616044820152676c6c6f77616e636560c01b60648201526084015b60405180910390fd5b61031285338584036104ed565b506001949350505050565b3360008181526001602090815260408083206001600160a01b0387168452909152812054909161026591859061035490869061090c565b6104ed565b6060600480546101d590610932565b3360009081526001602090815260408083206001600160a01b0386168452909152812054828110156103ea5760405162461bcd60e51b815260206004820152602560248201527f45524332303a2064656372656173656420616c6c6f77616e63652062656c6f77604482015264207a65726f60d81b60648201526084016102fc565b6103f733858584036104ed565b5060019392505050565b6000610265338484610611565b6001600160a01b0382166104645760405162461bcd60e51b815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f20616464726573730060448201526064016102fc565b8060026000828254610476919061090c565b90915550506001600160a01b038216600090815260208190526040812080548392906104a390849061090c565b90915550506040518181526001600160a01b038316906000907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9060200160405180910390a35050565b6001600160a01b03831661054f5760405162461bcd60e51b8152602060048201526024808201527f45524332303a20617070726f76652066726f6d20746865207a65726f206164646044820152637265737360e01b60648201526084016102fc565b6001600160a01b0382166105b05760405162461bcd60e51b815260206004820152602260248201527f45524332303a20617070726f766520746f20746865207a65726f206164647265604482015261737360f01b60648201526084016102fc565b6001600160a01b0383811660008181526001602090815260408083209487168084529482529182902085905590518481527f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925910160405180910390a3505050565b6001600160a01b0383166106755760405162461bcd60e51b815260206004820152602560248201527f45524332303a207472616e736665722066726f6d20746865207a65726f206164604482015264647265737360d81b60648201526084016102fc565b6001600160a01b0382166106d75760405162461bcd60e51b815260206004820152602360248201527f45524332303a207472616e7366657220746f20746865207a65726f206164647260448201526265737360e81b60648201526084016102fc565b6001600160a01b0383166000908152602081905260409020548181101561074f5760405162461bcd60e51b815260206004820152602660248201527f45524332303a207472616e7366657220616d6f756e7420657863656564732062604482015265616c616e636560d01b60648201526084016102fc565b6001600160a01b0380851660009081526020819052604080822085850390559185168152908120805484929061078690849061090c565b92505081905550826001600160a01b0316846001600160a01b03167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef846040516107d291815260200190565b60405180910390a350505050565b80356001600160a01b03811681146107f757600080fd5b919050565b60006020828403121561080e57600080fd5b610817826107e0565b9392505050565b6000806040838503121561083157600080fd5b61083a836107e0565b9150610848602084016107e0565b90509250929050565b60008060006060848603121561086657600080fd5b61086f846107e0565b925061087d602085016107e0565b9150604084013590509250925092565b600080604083850312156108a057600080fd5b6108a9836107e0565b946020939093013593505050565b600060208083528351808285015260005b818110156108e4578581018301518582016040015282016108c8565b818111156108f6576000604083870101525b50601f01601f1916929092016040019392505050565b6000821982111561092d57634e487b7160e01b600052601160045260246000fd5b500190565b600181811c9082168061094657607f821691505b6020821081141561096757634e487b7160e01b600052602260045260246000fd5b5091905056fea2646970667358221220b8448f15e6e399de789b8466d4a22ae09b99c0f97ea881db66b6859a3533058464736f6c63430008060033";
        public ICHBaseERC20DeploymentBase() : base(BYTECODE) { }
        public ICHBaseERC20DeploymentBase(string byteCode) : base(byteCode) { }
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
