// SPDX-License-Identifier: MIT
pragma solidity ^0.8.6;

import "@openzeppelin/contracts/token/ERC20/ERC20.sol";
import "@openzeppelin/contracts/access/AccessControlEnumerable.sol";

abstract contract ICHMintableERC20 is ERC20, AccessControlEnumerable {
  bytes32 public constant MINTER_ROLE = keccak256("MINTER_ROLE");

  constructor() 
  {
    _setupRole(MINTER_ROLE, _msgSender());
  }

  function mint(address to, uint256 amount) public virtual {
    require(hasRole(MINTER_ROLE, _msgSender()), "ERC20PresetMinterPauser: must have minter role to mint");
    _mint(to, amount);
  } 
}
