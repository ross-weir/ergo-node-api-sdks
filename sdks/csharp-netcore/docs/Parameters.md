# ErgoNode.Model.Parameters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Height** | **int** | Height when current parameters were considered(not actual height). Can be &#39;0&#39; if state is empty | 
**StorageFeeFactor** | **int** | Storage fee coefficient (per byte per storage period ~4 years) | 
**MinValuePerByte** | **int** | Minimum value per byte of an output | 
**MaxBlockSize** | **int** | Maximum block size (in bytes) | 
**MaxBlockCost** | **int** | Maximum cumulative computational cost of input scripts in block transactions | 
**BlockVersion** | **int** | Ergo blockchain protocol version | 
**TokenAccessCost** | **int** | Validation cost of a single token | 
**InputCost** | **int** | Validation cost per one transaction input | 
**DataInputCost** | **int** | Validation cost per one data input | 
**OutputCost** | **int** | Validation cost per one transaction output | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

