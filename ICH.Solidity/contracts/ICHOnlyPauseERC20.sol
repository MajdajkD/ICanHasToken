// SPDX-License-Identifier: MIT
pragma solidity ^0.8.6;

import "./ICHBaseERC20.sol";
import "./extensions/ICHPausableERC20.sol";

contract ICHOnlyPauseERC20 is ICHBaseERC20, ICHPausableERC20{
  constructor(
    address payable donateAddress, 
    string memory name_, 
    string memory symbol_,
    uint256 initialSupply,
    address owner) payable 
    ICHBaseERC20(donateAddress, name_, symbol_, initialSupply, owner)
    ICHPausableERC20()
  {
  }

  function _beforeTokenTransfer(
        address from,
        address to,
        uint256 amount
  ) internal virtual override {
    super._beforeTokenTransfer(from, to, amount);
    require(!paused(), "ERC20Pausable: token transfer while paused");
  }
}
