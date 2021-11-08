# ErgoNode.Model.ProofOfUpcomingTransactions
Proof that a block corresponding to given header without PoW contains some transactions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MsgPreimage** | **string** | Base16-encoded serialized header without Proof-of-Work | 
**TxProofs** | [**List&lt;MerkleProof&gt;**](MerkleProof.md) | Merkle proofs of transactions included into blocks (not necessarily all the block transactions) | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

