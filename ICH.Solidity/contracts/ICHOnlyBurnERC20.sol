// SPDX-License-Identifier: MIT
pragma solidity ^0.8.6;

import "./ICHBaseERC20.sol";
import "./extensions/ICHBurnableERC20.sol";

contract ICHOnlyBurnERC20 is ICHBaseERC20, ICHBurnableERC20 {
  constructor(
    address payable donateAddress, 
    string memory name_, 
    string memory symbol_,
    uint256 initialSupply,
    address owner) payable 
    ICHBaseERC20(donateAddress, name_, symbol_, initialSupply, owner)
    ICHBurnableERC20()
  {
  }
}
