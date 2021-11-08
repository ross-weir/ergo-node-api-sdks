# ErgoNode.Model.WalletBox

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Box** | [**ErgoTransactionOutput**](ErgoTransactionOutput.md) |  | 
**ConfirmationsNum** | **int?** | Number of confirmations, if the box is included into the blockchain | 
**Address** | **string** | Encoded Ergo Address | 
**CreationTransaction** | **string** | Base16-encoded 32 byte modifier id | 
**SpendingTransaction** | **string** | Base16-encoded 32 byte modifier id | 
**SpendingHeight** | **int?** | The height the box was spent at | 
**InclusionHeight** | **int** | The height the transaction containing the box was included in a block at | 
**Onchain** | **bool** | A flag signalling whether the box is created on main chain | 
**Spent** | **bool** | A flag signalling whether the box was spent | 
**CreationOutIndex** | **int** | An index of a box in the creating transaction | 
**Scans** | **List&lt;int&gt;** | Scan identifiers the box relates to | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

