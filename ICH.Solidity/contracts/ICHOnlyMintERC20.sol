// SPDX-License-Identifier: MIT
pragma solidity ^0.8.6;

import "./ICHBaseERC20.sol";
import "./extensions/ICHMintableERC20.sol";

contract ICHOnlyMintERC20 is ICHBaseERC20, ICHMintableERC20 {
  constructor(
    address payable donateAddress, 
    string memory name_, 
    string memory symbol_,
    uint256 initialSupply,
    address owner) payable 
    ICHBaseERC20(donateAddress, name_, symbol_, initialSupply, owner)
    ICHMintableERC20()
  {
  }
}
