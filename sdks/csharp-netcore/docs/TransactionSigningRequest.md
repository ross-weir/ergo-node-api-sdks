# ErgoNode.Model.TransactionSigningRequest
A request to sign a transaction with secrets provided

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tx** | [**UnsignedErgoTransaction**](.md) |  | 
**InputsRaw** | **List&lt;string&gt;** | Optional list of inputs to be used in serialized form | [optional] 
**DataInputsRaw** | **List&lt;string&gt;** | Optional list of inputs to be used in serialized form | [optional] 
**Hints** | [**TransactionHintsBag**](TransactionHintsBag.md) |  | [optional] 
**Secrets** | [**TransactionSigningRequestSecrets**](TransactionSigningRequestSecrets.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

