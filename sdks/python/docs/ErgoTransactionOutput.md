# ErgoTransactionOutput


## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**value** | **int** | Amount of Ergo token | 
**ergo_tree** | **str** | Base16-encoded ergo tree bytes | 
**creation_height** | **int** | Height the output was created at | 
**additional_registers** | [**Registers**](Registers.md) |  | 
**box_id** | **str** | Base16-encoded transaction box id bytes. Should be 32 bytes long | [optional] 
**assets** | [**[Asset]**](Asset.md) | Assets list in the transaction | [optional] 
**transaction_id** | **str** | Base16-encoded transaction id bytes | [optional] 
**index** | **int** | Index in the transaction outputs | [optional] 
**any string name** | **bool, date, datetime, dict, float, int, list, str, none_type** | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


