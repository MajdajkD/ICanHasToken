// SPDX-License-Identifier: MIT
pragma solidity ^0.8.6;

import "@openzeppelin/contracts/token/ERC20/ERC20.sol";

abstract contract ICHInitialSupplyERC20 is ERC20 {
  constructor(
  uint256 initialSupply,
  address owner)
  {
    ERC20._mint(owner, initialSupply);
  }
}
