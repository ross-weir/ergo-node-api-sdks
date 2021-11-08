# InlineResponse2002


## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**is_initialized** | **bool** | true if wallet is initialized, false otherwise | 
**is_unlocked** | **bool** | true if wallet is unlocked, false otherwise | 
**change_address** | **str** | address to send change to. Empty when wallet is not initialized or locked. By default change address correponds to root key address, could be set via /wallet/updateChangeAddress method. | 
**wallet_height** | **int** | last scanned height for the wallet (and external scans) | 
**error** | **str** | last wallet error caught | 
**any string name** | **bool, date, datetime, dict, float, int, list, str, none_type** | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


