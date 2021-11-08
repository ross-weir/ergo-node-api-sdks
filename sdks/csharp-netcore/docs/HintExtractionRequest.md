# ErgoNode.Model.HintExtractionRequest
request to extract prover hints from a transaction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tx** | [**ErgoTransaction**](ErgoTransaction.md) |  | 
**Real** | [**List&lt;SigmaBoolean&gt;**](SigmaBoolean.md) | Real signers of the transaction | 
**Simulated** | [**List&lt;SigmaBoolean&gt;**](SigmaBoolean.md) | Simulated signers of the transaction | 
**InputsRaw** | **List&lt;string&gt;** | Optional list of inputs to be used in serialized form | [optional] 
**DataInputsRaw** | **List&lt;string&gt;** | Optional list of inputs to be used in serialized form | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

