# DhtSecret

Hex-encoded big-endian 256-bits secret exponent \"w\" along with generators \"g\", \"h\", and group elements \"u\", \"v\", such as g^w = u, h^w = v

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**secret** | **str** | Hex-encoded big-endian 256-bits secret exponent | 
**g** | **str** | Hex-encoded \&quot;g\&quot; generator for the Diffie-Hellman tuple (secp256k1 curve point) | 
**h** | **str** | Hex-encoded \&quot;h\&quot; generator for the Diffie-Hellman tuple (secp256k1 curve point) | 
**u** | **str** | Hex-encoded \&quot;u\&quot; group element of the Diffie-Hellman tuple (secp256k1 curve point) | 
**v** | **str** | Hex-encoded \&quot;v\&quot; group element of the Diffie-Hellman tuple (secp256k1 curve point) | 
**any string name** | **bool, date, datetime, dict, float, int, list, str, none_type** | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


