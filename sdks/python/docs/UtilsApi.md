# ergo_node.UtilsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**address_to_raw**](UtilsApi.md#address_to_raw) | **GET** /utils/addressToRaw/{address} | Convert Pay-To-Public-Key Address to raw representation (hex-encoded serialized curve point)
[**check_address_validity**](UtilsApi.md#check_address_validity) | **GET** /utils/address/{address} | Check address validity
[**ergo_tree_to_address**](UtilsApi.md#ergo_tree_to_address) | **GET** /utils/ergoTreeToAddress/{ergoTreeHex} | Generate Ergo address from hex-encoded ErgoTree
[**get_random_seed**](UtilsApi.md#get_random_seed) | **GET** /utils/seed | Get random seed of 32 bytes
[**get_random_seed_with_length**](UtilsApi.md#get_random_seed_with_length) | **GET** /utils/seed/{length} | Generate random seed of specified length in bytes
[**hash_blake2b**](UtilsApi.md#hash_blake2b) | **POST** /utils/hash/blake2b | Return Blake2b hash of specified message
[**raw_to_address**](UtilsApi.md#raw_to_address) | **GET** /utils/rawToAddress/{pubkeyHex} | Generate Pay-To-Public-Key address from hex-encoded raw pubkey (secp256k1 serialized point)


# **address_to_raw**
> str address_to_raw(address)

Convert Pay-To-Public-Key Address to raw representation (hex-encoded serialized curve point)

### Example


```python
import time
import ergo_node
from ergo_node.api import utils_api
from ergo_node.model.api_error import ApiError
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)


# Enter a context with an instance of the API client
with ergo_node.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = utils_api.UtilsApi(api_client)
    address = "3WwbzW6u8hKWBcL1W7kNVMr25s2UHfSBnYtwSHvrRQt7DdPuoXrt" # str | address to extract public key from

    # example passing only required values which don't have defaults set
    try:
        # Convert Pay-To-Public-Key Address to raw representation (hex-encoded serialized curve point)
        api_response = api_instance.address_to_raw(address)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling UtilsApi->address_to_raw: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **str**| address to extract public key from |

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | hex-encoded public key (serialized secp256k1 element) |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **check_address_validity**
> AddressValidity check_address_validity(address)

Check address validity

### Example


```python
import time
import ergo_node
from ergo_node.api import utils_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.address_validity import AddressValidity
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)


# Enter a context with an instance of the API client
with ergo_node.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = utils_api.UtilsApi(api_client)
    address = "3WwbzW6u8hKWBcL1W7kNVMr25s2UHfSBnYtwSHvrRQt7DdPuoXrt" # str | address to check

    # example passing only required values which don't have defaults set
    try:
        # Check address validity
        api_response = api_instance.check_address_validity(address)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling UtilsApi->check_address_validity: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **str**| address to check |

### Return type

[**AddressValidity**](AddressValidity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Address validity with validation error |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ergo_tree_to_address**
> str ergo_tree_to_address(ergo_tree_hex)

Generate Ergo address from hex-encoded ErgoTree

### Example


```python
import time
import ergo_node
from ergo_node.api import utils_api
from ergo_node.model.api_error import ApiError
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)


# Enter a context with an instance of the API client
with ergo_node.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = utils_api.UtilsApi(api_client)
    ergo_tree_hex = "100204a00b08cd021cf943317b0fdb50f60892a46b9132b9ced337c7de79248b104b293d9f1f078eea02d192a39a8cc7a70173007301" # str | ErgoTree to derive an address from

    # example passing only required values which don't have defaults set
    try:
        # Generate Ergo address from hex-encoded ErgoTree
        api_response = api_instance.ergo_tree_to_address(ergo_tree_hex)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling UtilsApi->ergo_tree_to_address: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ergo_tree_hex** | **str**| ErgoTree to derive an address from |

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Ergo address |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_random_seed**
> str get_random_seed()

Get random seed of 32 bytes

### Example


```python
import time
import ergo_node
from ergo_node.api import utils_api
from ergo_node.model.api_error import ApiError
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)


# Enter a context with an instance of the API client
with ergo_node.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = utils_api.UtilsApi(api_client)

    # example, this endpoint has no required or optional parameters
    try:
        # Get random seed of 32 bytes
        api_response = api_instance.get_random_seed()
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling UtilsApi->get_random_seed: %s\n" % e)
```


### Parameters
This endpoint does not need any parameter.

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Base16-encoded 32 byte seed |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_random_seed_with_length**
> str get_random_seed_with_length(length)

Generate random seed of specified length in bytes

### Example


```python
import time
import ergo_node
from ergo_node.api import utils_api
from ergo_node.model.api_error import ApiError
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)


# Enter a context with an instance of the API client
with ergo_node.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = utils_api.UtilsApi(api_client)
    length = "length_example" # str | seed length in bytes

    # example passing only required values which don't have defaults set
    try:
        # Generate random seed of specified length in bytes
        api_response = api_instance.get_random_seed_with_length(length)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling UtilsApi->get_random_seed_with_length: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **length** | **str**| seed length in bytes |

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Base16-encoded N byte seed |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **hash_blake2b**
> str hash_blake2b(body)

Return Blake2b hash of specified message

### Example


```python
import time
import ergo_node
from ergo_node.api import utils_api
from ergo_node.model.api_error import ApiError
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)


# Enter a context with an instance of the API client
with ergo_node.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = utils_api.UtilsApi(api_client)
    body = "7yaASMijGEGTbttYHg1MrXnWB8EbzjJnFLSWvmNoHrXV" # str | 

    # example passing only required values which don't have defaults set
    try:
        # Return Blake2b hash of specified message
        api_response = api_instance.hash_blake2b(body)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling UtilsApi->hash_blake2b: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **str**|  |

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Base16-encoded 32 byte hash |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **raw_to_address**
> str raw_to_address(pubkey_hex)

Generate Pay-To-Public-Key address from hex-encoded raw pubkey (secp256k1 serialized point)

### Example


```python
import time
import ergo_node
from ergo_node.api import utils_api
from ergo_node.model.api_error import ApiError
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)


# Enter a context with an instance of the API client
with ergo_node.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = utils_api.UtilsApi(api_client)
    pubkey_hex = "02a7955281885bf0f0ca4a48678848cad8dc5b328ce8bc1d4481d041c98e891ff3" # str | public key to get address from

    # example passing only required values which don't have defaults set
    try:
        # Generate Pay-To-Public-Key address from hex-encoded raw pubkey (secp256k1 serialized point)
        api_response = api_instance.raw_to_address(pubkey_hex)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling UtilsApi->raw_to_address: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pubkey_hex** | **str**| public key to get address from |

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Pay-to-public-key (P2PK) address |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

