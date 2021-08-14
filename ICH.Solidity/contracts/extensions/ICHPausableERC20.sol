// SPDX-License-Identifier: MIT
pragma solidity ^0.8.6;

import "@openzeppelin/contracts/token/ERC20/ERC20.sol";
import "@openzeppelin/contracts/access/AccessControlEnumerable.sol";
import "@openzeppelin/contracts/security/Pausable.sol";

abstract contract ICHPausableERC20 is ERC20, AccessControlEnumerable, Pausable {
  bytes32 public constant PAUSER_ROLE = keccak256("PAUSER_ROLE");

  constructor()
  {
    _setupRole(PAUSER_ROLE, _msgSender());
  }

  function pause() public virtual {
    require(hasRole(PAUSER_ROLE, _msgSender()), "ERC20PresetMinterPauser: must have pauser role to pause");
    _pause();
  }

  function unpause() public virtual {
    require(hasRole(PAUSER_ROLE, _msgSender()), "ERC20PresetMinterPauser: must have pauser role to unpause");
    _unpause();
  }
}
