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
using Nethereum.Web3;
using System.Numerics;
using System.Threading.Tasks;

namespace ICH.Logic
{
  public static class TokenDeployManager
  {
    public static string CommissionAddress { get; set; } = "0x206D19a9F45a94F52Be91F3D26E81De2d85f0706";

    public static async Task<string> Deploy(
      Web3 web3,
      string name,
      string symbol,
      BigInteger initialSupply,
      string ownerAddress,
      BigInteger commission,
      bool isMintable,
      bool isBurnable,
      bool isPausable
      )
    {
      if (isMintable)
      {
        if (isBurnable)
        {
          if (isPausable)
          {
            //MintBurnPause
            return await DeployBurnMintPause(web3, name, symbol, initialSupply, ownerAddress, commission);
          }
          else
          {
            //MintBurn
            return await DeployBurnMint(web3, name, symbol, initialSupply, ownerAddress, commission);
          }
        }
        else
        {
          if (isPausable)
          {
            //MintPause
            return await DeployMintPause(web3, name, symbol, initialSupply, ownerAddress, commission);
          }
          else
          {
            //OnlyMint
            return await DeployOnlyMint(web3, name, symbol, initialSupply, ownerAddress, commission);
          }
        }
      }
      else
      {
        if (isBurnable)
        {
          if (isPausable)
          {
            //BurnPause
            return await DeployBurnPause(web3, name, symbol, initialSupply, ownerAddress, commission);
          }
          else
          {
            //OnlyBurn
            return await DeployOnlyBurn(web3, name, symbol, initialSupply, ownerAddress, commission);
          }
        }
        else
        {
          if (isPausable)
          {
            //OnlyPause
            return await DeployOnlyPause(web3, name, symbol, initialSupply, ownerAddress, commission);
          }
          else
          {
            //Base
            return await DeployBase(web3, name, symbol, initialSupply, ownerAddress, commission);
          }
        }
      }
    }

    private static async Task<string> DeployBase(
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
      var receipt = await ICHBaseERC20Service.DeployContractAndWaitForReceiptAsync(web3, deployment);
      return receipt.ContractAddress;
    }

    private static async Task<string> DeployOnlyPause(
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
      var receipt = await ICHOnlyPauseERC20Service.DeployContractAndWaitForReceiptAsync(web3, deployment);
      return receipt.ContractAddress;
    }

    private static async Task<string> DeployOnlyBurn(
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
      var receipt = await ICHOnlyBurnERC20Service.DeployContractAndWaitForReceiptAsync(web3, deployment);
      return receipt.ContractAddress;
    }

    private static async Task<string> DeployBurnPause(
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
      var receipt = await ICHBurnPauseERC20Service.DeployContractAndWaitForReceiptAsync(web3, deployment);
      return receipt.ContractAddress;
    }

    private static async Task<string> DeployOnlyMint(
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
      var receipt = await ICHOnlyMintERC20Service.DeployContractAndWaitForReceiptAsync(web3, deployment);
      return receipt.ContractAddress;
    }

    private static async Task<string> DeployMintPause(
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
      var receipt = await ICHMintPauseERC20Service.DeployContractAndWaitForReceiptAsync(web3, deployment);
      return receipt.ContractAddress;
    }

    private static async Task<string> DeployBurnMint(
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
      var receipt = await ICHBurnMintERC20Service.DeployContractAndWaitForReceiptAsync(web3, deployment);
      return receipt.ContractAddress;
    }

    private static async Task<string> DeployBurnMintPause(
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
      var receipt = await ICHBurnMintPauseERC20Service.DeployContractAndWaitForReceiptAsync(web3, deployment);
      return receipt.ContractAddress;
    }
  }
}