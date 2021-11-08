# BlockHeader


## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **str** | Base16-encoded 32 byte modifier id | 
**timestamp** | **int** | Basic timestamp definition | 
**version** | **int** | Ergo blockchain protocol version | 
**ad_proofs_root** | **str** | Base16-encoded 32 byte digest | 
**state_root** | **str** | Base16-encoded 33 byte digest - digest with extra byte with tree height | 
**transactions_root** | **str** | Base16-encoded 32 byte digest | 
**n_bits** | **int** |  | 
**extension_hash** | **str** | Base16-encoded 32 byte digest | 
**pow_solutions** | [**PowSolutions**](PowSolutions.md) |  | 
**height** | **int** |  | 
**difficulty** | **int** |  | 
**parent_id** | **str** | Base16-encoded 32 byte modifier id | 
**votes** | **str** | Base16-encoded votes for a soft-fork and parameters | 
**size** | **int** | Size in bytes | [optional] 
**extension_id** | **str** | Base16-encoded 32 byte modifier id | [optional] 
**transactions_id** | **str** | Base16-encoded 32 byte modifier id | [optional] 
**ad_proofs_id** | **str** | Base16-encoded 32 byte modifier id | [optional] 
**any string name** | **bool, date, datetime, dict, float, int, list, str, none_type** | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


