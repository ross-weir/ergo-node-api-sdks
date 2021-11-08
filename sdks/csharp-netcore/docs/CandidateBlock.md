# ErgoNode.Model.CandidateBlock
Can be null if node is not mining or candidate block is not ready

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**_Version** | **int** |  | [optional] 
**ExtensionHash** | **string** | Base16-encoded 32 byte digest | 
**Timestamp** | **long** | Basic timestamp definition | [optional] 
**StateRoot** | **string** | Base16-encoded 33 byte digest - digest with extra byte with tree height | [optional] 
**NBits** | **long** |  | [optional] 
**AdProofBytes** | **string** | Base16-encoded ad proofs | [optional] 
**ParentId** | **string** | Base16-encoded 32 byte modifier id | 
**TransactionsNumber** | **int** |  | [optional] 
**Transactions** | [**List&lt;ErgoTransaction&gt;**](ErgoTransaction.md) | Ergo transaction objects | [optional] 
**Votes** | **string** | Base16-encoded votes for a soft-fork and parameters | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

