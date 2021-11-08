# SigmaHeader

Block header format used for sigma ErgoLikeContext

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**timestamp** | **int** | Basic timestamp definition | 
**version** | **int** | Ergo blockchain protocol version | 
**ad_proofs_root** | **str** | Base16-encoded 32 byte digest | 
**state_root** | [**AvlTreeData**](AvlTreeData.md) |  | 
**transactions_root** | **str** | Base16-encoded 32 byte digest | 
**n_bits** | **int** |  | 
**extension_hash** | **str** | Base16-encoded 32 byte digest | 
**height** | **int** |  | 
**parent_id** | **str** | Base16-encoded 32 byte modifier id | 
**votes** | **str** | Base16-encoded votes for a soft-fork and parameters | 
**id** | **str** | Base16-encoded 32 byte modifier id | [optional] 
**ad_proofs_id** | **str** | Base16-encoded 32 byte modifier id | [optional] 
**transactions_id** | **str** | Base16-encoded 32 byte modifier id | [optional] 
**extension_root** | **str** | Base16-encoded 32 byte digest | [optional] 
**extension_id** | **str** | Base16-encoded 32 byte modifier id | [optional] 
**size** | **int** |  | [optional] 
**pow_solutions** | [**PowSolutions**](PowSolutions.md) |  | [optional] 
**miner_pk** | **str** |  | [optional] 
**pow_onetime_pk** | **str** |  | [optional] 
**pow_nonce** | **str** | Base16-encoded 32 byte digest | [optional] 
**pow_distance** | **float** | sigma.BigInt | [optional] 
**any string name** | **bool, date, datetime, dict, float, int, list, str, none_type** | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


