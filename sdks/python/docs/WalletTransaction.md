# WalletTransaction

Transaction augmented with some useful information

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**inputs** | [**[ErgoTransactionInput]**](ErgoTransactionInput.md) | Transaction inputs | 
**data_inputs** | [**[ErgoTransactionDataInput]**](ErgoTransactionDataInput.md) | Transaction data inputs | 
**outputs** | [**[ErgoTransactionOutput]**](ErgoTransactionOutput.md) | Transaction outputs | 
**inclusion_height** | **int** | Height of a block the transaction was included in | 
**num_confirmations** | **int** | Number of transaction confirmations | 
**scans** | **[int]** | Scan identifiers the transaction relates to | 
**id** | **str** | Base16-encoded transaction id bytes | [optional] 
**size** | **int** | Size in bytes | [optional] 
**any string name** | **bool, date, datetime, dict, float, int, list, str, none_type** | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


