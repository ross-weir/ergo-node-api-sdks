# ProofOfUpcomingTransactions

Proof that a block corresponding to given header without PoW contains some transactions

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**msg_preimage** | **str** | Base16-encoded serialized header without Proof-of-Work | 
**tx_proofs** | [**[MerkleProof]**](MerkleProof.md) | Merkle proofs of transactions included into blocks (not necessarily all the block transactions) | 
**any string name** | **bool, date, datetime, dict, float, int, list, str, none_type** | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


