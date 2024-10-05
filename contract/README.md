# dice_contract

## testnet

```ps1
near login

near deploy i574n.testnet "dist/dice.wasm" --networkId testnet
near call i574n.testnet new --networkId testnet --accountId i574n.testnet

near call i574n.testnet generate_random_number --networkId testnet --accountId i574n.testnet --gas 110000000000000 "{\`"key\`": \`"\`", \`"proof\`": \`"\`", \`"max\`": 1}"
```

```txt
testnet
mynearwallet.com
i574n.testnet

height message cook awesome coast glide crush flush pave brick size delay
```

## mainnet

```ps1
near login

near deploy luckier.near "dist/dice.wasm" --networkId=mainnet --accountId=i574n.near
near call luckier.near new --networkId mainnet --accountId=i574n.near

near call luckier.near generate_random_number --accountId=i574n.near --networkId=mainnet --gas 110000000000000 "{\`"key\`": \`"\`", \`"proof\`": \`"\`", \`"max\`": 1}"
```
