# WorkMessage

Block candidate related data for external miner to perform work

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**msg** | **str** | Base16-encoded block header bytes without PoW solution | 
**b** | **int** | Work target value | 
**pk** | **str** | Base16-encoded miner public key | 
**proof** | **ProofOfUpcomingTransactions** |  | [optional] 
**any string name** | **bool, date, datetime, dict, float, int, list, str, none_type** | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


