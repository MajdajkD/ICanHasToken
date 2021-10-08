using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICH.Logic
{
  public static class TokenCodeProvider
  {
    public static string GetCode(
      bool isMintable,
      bool isBurnable,
      bool isPausable)
    {
      if (isMintable)
      {
        if (isBurnable)
        {
          if (isPausable)
          {
            //MintBurnPause
            return $"/contracts/ICHBurnMintPauseERC20_flat.sol";
          }
          else
          {
            //MintBurn
            return $"/contracts/ICHBurnMintERC20_flat.sol";
          }
        }
        else
        {
          if (isPausable)
          {
            //MintPause
            return $"/contracts/ICHMintPauseERC20_flat.sol";
          }
          else
          {
            //OnlyMint
            return $"/contracts/ICHOnlyMintERC20_flat.sol";
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
            return $"/contracts/ICHBurnPauseERC20_flat.sol";
          }
          else
          {
            //OnlyBurn
            return $"/contracts/ICHOnlyBurnERC20_flat.sol";
          }
        }
        else
        {
          if (isPausable)
          {
            //OnlyPause
            return $"/contracts/ICHOnlyPauseERC20_flat.sol";
          }
          else
          {
            //Base
            return $"/contracts/ICHBaseERC20_flat.sol";
          }
        }
      }
    }
  }
}
