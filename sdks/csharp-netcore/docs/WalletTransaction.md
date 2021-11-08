# ErgoNode.Model.WalletTransaction
Transaction augmented with some useful information

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Base16-encoded transaction id bytes | [optional] 
**Inputs** | [**List&lt;ErgoTransactionInput&gt;**](ErgoTransactionInput.md) | Transaction inputs | 
**DataInputs** | [**List&lt;ErgoTransactionDataInput&gt;**](ErgoTransactionDataInput.md) | Transaction data inputs | 
**Outputs** | [**List&lt;ErgoTransactionOutput&gt;**](ErgoTransactionOutput.md) | Transaction outputs | 
**InclusionHeight** | **int** | Height of a block the transaction was included in | 
**NumConfirmations** | **int** | Number of transaction confirmations | 
**Scans** | **List&lt;int&gt;** | Scan identifiers the transaction relates to | 
**Size** | **int** | Size in bytes | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

