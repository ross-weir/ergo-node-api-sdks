# TransactionSigningRequest

A request to sign a transaction with secrets provided

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tx** | **UnsignedErgoTransaction** |  | 
**secrets** | [**TransactionSigningRequestSecrets**](TransactionSigningRequestSecrets.md) |  | 
**inputs_raw** | **[str]** | Optional list of inputs to be used in serialized form | [optional] 
**data_inputs_raw** | **[str]** | Optional list of inputs to be used in serialized form | [optional] 
**hints** | [**TransactionHintsBag**](TransactionHintsBag.md) |  | [optional] 
**any string name** | **bool, date, datetime, dict, float, int, list, str, none_type** | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


