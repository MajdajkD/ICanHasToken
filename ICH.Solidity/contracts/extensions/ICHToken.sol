// SPDX-License-Identifier: MIT
pragma solidity ^0.8.6;

abstract contract ICHToken {
  constructor(address payable donateAddress) payable
  {
    require(msg.value>0, "Commission fee is missing :(");
    donateAddress.transfer(msg.value);
    emit PaidForContractDeployment(msg.sender, donateAddress, address(this), msg.value);
  }
  event PaidForContractDeployment(address indexed _from, address indexed _to, address indexed _for, uint _value);
}
