// SPDX-License-Identifier: MIT
pragma solidity ^0.8.6;

import "@openzeppelin/contracts/token/ERC20/IERC20.sol";
import "@openzeppelin/contracts/access/Ownable.sol";

abstract contract ICHInitialSupplyERC20 is Ownable {
  constructor(address owner)
  Ownable()
  {}
  
  function recoverERC20(address tokenAddress, uint256 tokenAmount) public virtual onlyOwner {
    IERC20(tokenAddress).transfer(owner(), tokenAmount);
}
