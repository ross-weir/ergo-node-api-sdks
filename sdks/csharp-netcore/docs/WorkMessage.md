# ErgoNode.Model.WorkMessage
Block candidate related data for external miner to perform work

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Msg** | **string** | Base16-encoded block header bytes without PoW solution | 
**B** | **int** | Work target value | 
**Pk** | **string** | Base16-encoded miner public key | 
**Proof** | [**ProofOfUpcomingTransactions**](.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

