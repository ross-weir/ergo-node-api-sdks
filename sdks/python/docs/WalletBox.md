# WalletBox


## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**box** | [**ErgoTransactionOutput**](ErgoTransactionOutput.md) |  | 
**confirmations_num** | **int, none_type** | Number of confirmations, if the box is included into the blockchain | 
**address** | **str** | Encoded Ergo Address | 
**creation_transaction** | **str** | Base16-encoded 32 byte modifier id | 
**spending_transaction** | **str** | Base16-encoded 32 byte modifier id | 
**spending_height** | **int, none_type** | The height the box was spent at | 
**inclusion_height** | **int** | The height the transaction containing the box was included in a block at | 
**onchain** | **bool** | A flag signalling whether the box is created on main chain | 
**spent** | **bool** | A flag signalling whether the box was spent | 
**creation_out_index** | **int** | An index of a box in the creating transaction | 
**scans** | **[int]** | Scan identifiers the box relates to | 
**any string name** | **bool, date, datetime, dict, float, int, list, str, none_type** | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


