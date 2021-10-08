window.NethereumMetamaskInterop = {
  EnableEthereum: async () => {
    try {
      const accounts = await ethereum.request({ method: 'eth_requestAccounts' });
      ethereum.autoRefreshOnNetworkChange = false;
      ethereum.on("accountsChanged",
        function (accounts) {
          DotNet.invokeMethodAsync('ICH.MetaMask', 'SelectedAccountChanged', accounts[0]);
        });
      ethereum.on("chainChanged",
        function (networkId) {
          DotNet.invokeMethodAsync('ICH.MetaMask', 'NetworkChanged', networkId);
        });
      ethereum.on('connect',
        function (networkId) {
          DotNet.invokeMethodAsync('ICH.MetaMask', 'NetworkChanged', networkId);
        });
      return accounts[0];
    } catch (error) {
      return null;
    }
  },
  IsMetamaskAvailable: () => {
    if (window.ethereum) return true;
    return false;
  },
  GetSelectedAddress: () => {
    return ethereum.selectedAddress;
  },
  GetSelectedNetwork: () => {
    return ethereum.chainId;
  },
  Request: async (message) => {
    try {
      let parsedMessage = JSON.parse(message);
      parsedMessage.params[0].gas = null;
      parsedMessage.params[0].gasPrice = null;
      console.log(parsedMessage);
      const response = await ethereum.request(parsedMessage);
      let rpcResonse = {
        jsonrpc: "2.0",
        result: response,
        id: parsedMessage.id,
        error: null
      }
      console.log(rpcResonse);

      return JSON.stringify(rpcResonse);
    } catch (e) {
      let rpcResonseError = {
        jsonrpc: "2.0",
        id: parsedMessage.id,
        error: {
          message: e,
        }
      }
      return JSON.stringify(rpcResonseError);
    }
  },
  Sign: async (utf8HexMsg) => {
    const from = ethereum.selectedAddress;
    const params = [utf8HexMsg, from];
    const method = 'personal_sign';

    try {
      const response = await ethereum.request(
        {
          method: method,
          params: params
        }
      );
      return response;
    } catch (e) {
      return null;
    }
  },
  SwitchChain: async (newChain, newRpc) => {
    try {
      await ethereum.request({
        method: 'wallet_switchEthereumChain',
        params: [{ chainId: newChain }],
      });
      return true;
    } catch (switchError) {
      // This error code indicates that the chain has not been added to MetaMask.
      if (error.code === 4902) {
        try {
          await ethereum.request({
            method: 'wallet_addEthereumChain',
            params: [{ chainId: newChain, rpcUrl: newRpc }],
          });
        } catch (addError) {
          return false;
          // handle "add" error
        }
      }
      return false;
      // handle other "switch" errors
    }
  },
  AddAsset: async (assetType, assetAddress, assetSymbol, assetDecimals, assetImageUrl) => {
    try {
      await ethereum.request({
        method: 'wallet_watchAsset',
        params: {
          type: assetType,
          options: {
            address: assetAddress,
            symbol: assetSymbol,
            decimals: assetDecimals,
            image: assetImageUrl,
          },
        },
      });
      return true;
    } catch (watchError) {
      return false;
    }
  },
}