// SPDX-License-Identifier: MIT
pragma solidity ^0.8.6;

import "@openzeppelin/contracts/token/ERC20/ERC20.sol";

abstract contract ICHCappedERC20 is ERC20{
  uint256 private immutable _cap;
  constructor(uint256 cap_) {
    require(cap_ > 0, "ERC20Capped: cap is 0");
    _cap = cap_;
  }

  function cap() public view virtual returns (uint256) {
    return _cap;
  }

  function _mint(address account, uint256 amount) internal virtual override {
    require(ERC20.totalSupply() + amount <= cap(), "ERC20Capped: cap exceeded");
    super._mint(account, amount);
  }
}
