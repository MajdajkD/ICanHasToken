// SPDX-License-Identifier: MIT
pragma solidity ^0.8.6;

import "./ICHBaseERC20.sol";
import "./extensions/ICHBurnableERC20.sol";
import "./extensions/ICHMintableERC20.sol";
import "./extensions/ICHPausableERC20.sol";
import "./extensions/ICHCappedERC20.sol";


contract ICHBurnMintPauseCapERC20 is ICHBaseERC20, ICHBurnableERC20, ICHMintableERC20, ICHPausableERC20, ICHCappedERC20 {
  constructor(
    address payable donateAddress, 
    string memory name_, 
    string memory symbol_,
    uint256 cap,
    uint256 initialSupply,
    address owner) payable 
    ICHBaseERC20(donateAddress, name_, symbol_, initialSupply, owner)
    ICHBurnableERC20()
    ICHMintableERC20()
    ICHPausableERC20()
    ICHCappedERC20(cap)
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

    function _mint(address account, uint256 amount) internal virtual override(ICHCappedERC20, ERC20) {
    require(ERC20.totalSupply() + amount <= cap(), "ERC20Capped: cap exceeded");
    super._mint(account, amount);
  }
}