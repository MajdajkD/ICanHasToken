// SPDX-License-Identifier: MIT
pragma solidity ^0.8.6;

import "./extensions/ICHToken.sol";
import "@openzeppelin/contracts/token/ERC20/ERC20.sol";
import "./extensions/ICHInitialSupplyERC20.sol";

contract ICHBaseERC20 is ICHToken, ERC20, ICHInitialSupplyERC20 {
  constructor(
    address payable donateAddress, 
    string memory name_, 
    string memory symbol_,
    uint256 initialSupply,
    address owner) payable
    ICHToken(donateAddress)
    ERC20(name_, symbol_)
    ICHInitialSupplyERC20(initialSupply, owner)
    {
    }
}
