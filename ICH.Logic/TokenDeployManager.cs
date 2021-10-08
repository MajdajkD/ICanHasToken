using ICH.Solidity.Contracts.ICHBaseERC20;
using ICH.Solidity.Contracts.ICHBaseERC20.ContractDefinition;
using ICH.Solidity.Contracts.ICHBurnMintERC20;
using ICH.Solidity.Contracts.ICHBurnMintERC20.ContractDefinition;
using ICH.Solidity.Contracts.ICHBurnMintPauseERC20;
using ICH.Solidity.Contracts.ICHBurnMintPauseERC20.ContractDefinition;
using ICH.Solidity.Contracts.ICHBurnPauseERC20;
using ICH.Solidity.Contracts.ICHBurnPauseERC20.ContractDefinition;
using ICH.Solidity.Contracts.ICHMintPauseERC20;
using ICH.Solidity.Contracts.ICHMintPauseERC20.ContractDefinition;
using ICH.Solidity.Contracts.ICHOnlyBurnERC20;
using ICH.Solidity.Contracts.ICHOnlyBurnERC20.ContractDefinition;
using ICH.Solidity.Contracts.ICHOnlyMintERC20;
using ICH.Solidity.Contracts.ICHOnlyMintERC20.ContractDefinition;
using ICH.Solidity.Contracts.ICHOnlyPauseERC20;
using ICH.Solidity.Contracts.ICHOnlyPauseERC20.ContractDefinition;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3;
using System.Numerics;
using System.Threading.Tasks;

namespace ICH.Logic
{
  public static class TokenDeployManager
  {
    public static string CommissionAddress { get; set; } = "0x206D19a9F45a94F52Be91F3D26E81De2d85f0706";

      public delegate Task<TransactionReceipt> Deployment(
        Web3 web3,
        string name,
        string symbol,
        BigInteger initialSupply,
        string ownerAddress,
        BigInteger commission
        );

    public static Deployment Deploy(
      bool isMintable,
      bool isBurnable,
      bool isPausable
      )
    {
      if (isMintable)
      {
        if (isBurnable)
        {
          return isPausable
            ? DeployBurnMintPause
            : DeployBurnMint;
        }
        else
        {
          return isPausable
            ? DeployMintPause
            : DeployOnlyMint;
        }
      }
      else
      {
        if (isBurnable)
        {
          return isPausable
            ? DeployBurnPause
            : DeployOnlyBurn;
        }
        else
        {
          return isPausable
            ? DeployOnlyPause
            : DeployBase;
        }
      }
    }

    private static Task<TransactionReceipt> DeployBase(
      Web3 web3,
      string name,
      string symbol,
      BigInteger initialSupply,
      string ownerAddress,
      BigInteger commission)
    {
      ICHBaseERC20Deployment deployment = new()
      {
        DonateAddress = CommissionAddress,
        Name_ = name,
        Symbol_ = symbol,
        InitialSupply = initialSupply,
        Owner = ownerAddress,
        AmountToSend = commission
      };
      return ICHBaseERC20Service.DeployContractAndWaitForReceiptAsync(web3, deployment);
    }

    private static Task<TransactionReceipt> DeployOnlyPause(
      Web3 web3,
      string name,
      string symbol,
      BigInteger initialSupply,
      string ownerAddress,
      BigInteger commission)
    {
      ICHOnlyPauseERC20Deployment deployment = new()
      {
        DonateAddress = CommissionAddress,
        Name_ = name,
        Symbol_ = symbol,
        InitialSupply = initialSupply,
        Owner = ownerAddress,
        AmountToSend = commission
      };
      return ICHOnlyPauseERC20Service.DeployContractAndWaitForReceiptAsync(web3, deployment);
    }

    private static Task<TransactionReceipt> DeployOnlyBurn(
      Web3 web3,
      string name,
      string symbol,
      BigInteger initialSupply,
      string ownerAddress,
      BigInteger commission)
    {
      ICHOnlyBurnERC20Deployment deployment = new()
      {
        DonateAddress = CommissionAddress,
        Name_ = name,
        Symbol_ = symbol,
        InitialSupply = initialSupply,
        Owner = ownerAddress,
        AmountToSend = commission
      };
      return ICHOnlyBurnERC20Service.DeployContractAndWaitForReceiptAsync(web3, deployment);
    }

    private static Task<TransactionReceipt> DeployBurnPause(
      Web3 web3,
      string name,
      string symbol,
      BigInteger initialSupply,
      string ownerAddress,
      BigInteger commission)
    {
      ICHBurnPauseERC20Deployment deployment = new()
      {
        DonateAddress = CommissionAddress,
        Name_ = name,
        Symbol_ = symbol,
        InitialSupply = initialSupply,
        Owner = ownerAddress,
        AmountToSend = commission
      };
      return ICHBurnPauseERC20Service.DeployContractAndWaitForReceiptAsync(web3, deployment);
    }

    private static Task<TransactionReceipt> DeployOnlyMint(
      Web3 web3,
      string name,
      string symbol,
      BigInteger initialSupply,
      string ownerAddress,
      BigInteger commission)
    {
      ICHOnlyMintERC20Deployment deployment = new()
      {
        DonateAddress = CommissionAddress,
        Name_ = name,
        Symbol_ = symbol,
        InitialSupply = initialSupply,
        Owner = ownerAddress,
        AmountToSend = commission
      };
      return ICHOnlyMintERC20Service.DeployContractAndWaitForReceiptAsync(web3, deployment);
    }

    private static Task<TransactionReceipt> DeployMintPause(
      Web3 web3,
      string name,
      string symbol,
      BigInteger initialSupply,
      string ownerAddress,
      BigInteger commission)
    {
      ICHMintPauseERC20Deployment deployment = new()
      {
        DonateAddress = CommissionAddress,
        Name_ = name,
        Symbol_ = symbol,
        InitialSupply = initialSupply,
        Owner = ownerAddress,
        AmountToSend = commission
      };
      return ICHMintPauseERC20Service.DeployContractAndWaitForReceiptAsync(web3, deployment);
    }

    private static Task<TransactionReceipt> DeployBurnMint(
      Web3 web3,
      string name,
      string symbol,
      BigInteger initialSupply,
      string ownerAddress,
      BigInteger commission)
    {
      ICHBurnMintERC20Deployment deployment = new()
      {
        DonateAddress = CommissionAddress,
        Name_ = name,
        Symbol_ = symbol,
        InitialSupply = initialSupply,
        Owner = ownerAddress,
        AmountToSend = commission
      };
      return ICHBurnMintERC20Service.DeployContractAndWaitForReceiptAsync(web3, deployment);
    }

    private static Task<TransactionReceipt> DeployBurnMintPause(
      Web3 web3,
      string name,
      string symbol,
      BigInteger initialSupply,
      string ownerAddress,
      BigInteger commission)
    {
      ICHBurnMintPauseERC20Deployment deployment = new()
      {
        DonateAddress = CommissionAddress,
        Name_ = name,
        Symbol_ = symbol,
        InitialSupply = initialSupply,
        Owner = ownerAddress,
        AmountToSend = commission
      };
      return ICHBurnMintPauseERC20Service.DeployContractAndWaitForReceiptAsync(web3, deployment);
    }
  }
}