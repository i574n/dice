# dice_contract

```ps1
near deploy luckier.near "dist/dice.wasm" --networkId mainnet
near call luckier.near new --networkId mainnet --accountId=i574n.near
```

```ps1
near call luckier.near generate_random_number "{\`"key\`": \`"\`", \`"proof\`": \`"\`", \`"max\`": 1}" --networkId mainnet --accountId i574n.near --gas 40000000000000
```
