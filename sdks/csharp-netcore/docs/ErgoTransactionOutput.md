# ErgoNode.Model.ErgoTransactionOutput

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BoxId** | **string** | Base16-encoded transaction box id bytes. Should be 32 bytes long | [optional] 
**Value** | **long** | Amount of Ergo token | 
**ErgoTree** | **string** | Base16-encoded ergo tree bytes | 
**CreationHeight** | **int** | Height the output was created at | 
**Assets** | [**List&lt;Asset&gt;**](Asset.md) | Assets list in the transaction | [optional] 
**AdditionalRegisters** | **Dictionary&lt;string, string&gt;** | Ergo box registers | 
**TransactionId** | **string** | Base16-encoded transaction id bytes | [optional] 
**Index** | **int** | Index in the transaction outputs | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

