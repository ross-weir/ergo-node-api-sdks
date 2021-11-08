# CandidateBlock

Can be null if node is not mining or candidate block is not ready

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**extension_hash** | **str** | Base16-encoded 32 byte digest | 
**parent_id** | **str** | Base16-encoded 32 byte modifier id | 
**version** | **int** |  | [optional] 
**timestamp** | **int** | Basic timestamp definition | [optional] 
**state_root** | **str** | Base16-encoded 33 byte digest - digest with extra byte with tree height | [optional] 
**n_bits** | **int** |  | [optional] 
**ad_proof_bytes** | **str** | Base16-encoded ad proofs | [optional] 
**transactions_number** | **int** |  | [optional] 
**transactions** | [**Transactions**](Transactions.md) |  | [optional] 
**votes** | **str** | Base16-encoded votes for a soft-fork and parameters | [optional] 
**any string name** | **bool, date, datetime, dict, float, int, list, str, none_type** | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


