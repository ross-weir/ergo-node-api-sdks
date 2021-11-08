# ergo_node.UtxoApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**genesis_boxes**](UtxoApi.md#genesis_boxes) | **GET** /utxo/genesis | Get genesis boxes (boxes existed before the very first block)
[**get_box_by_id**](UtxoApi.md#get_box_by_id) | **GET** /utxo/byId/{boxId} | Get box contents for a box by a unique identifier.
[**get_box_by_id_binary**](UtxoApi.md#get_box_by_id_binary) | **GET** /utxo/byIdBinary/{boxId} | Get serialized box from UTXO pool in Base16 encoding by an identifier.
[**get_box_with_pool_by_id**](UtxoApi.md#get_box_with_pool_by_id) | **GET** /utxo/withPool/byId/{boxId} | Get box contents for a box by a unique identifier, from UTXO set and also the mempool.
[**get_box_with_pool_by_id_binary**](UtxoApi.md#get_box_with_pool_by_id_binary) | **GET** /utxo/withPool/byIdBinary/{boxId} | Get serialized box in Base16 encoding by an identifier, considering also the mempool.


# **genesis_boxes**
> [ErgoTransactionOutput] genesis_boxes()

Get genesis boxes (boxes existed before the very first block)

### Example


```python
import time
import ergo_node
from ergo_node.api import utxo_api
from ergo_node.model.ergo_transaction_output import ErgoTransactionOutput
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
    api_instance = utxo_api.UtxoApi(api_client)

    # example, this endpoint has no required or optional parameters
    try:
        # Get genesis boxes (boxes existed before the very first block)
        api_response = api_instance.genesis_boxes()
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling UtxoApi->genesis_boxes: %s\n" % e)
```


### Parameters
This endpoint does not need any parameter.

### Return type

[**[ErgoTransactionOutput]**](ErgoTransactionOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | A list of all the genesis boxes |  -  |
**404** | Box with this id doesn&#39;t exist |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_box_by_id**
> ErgoTransactionOutput get_box_by_id(box_id)

Get box contents for a box by a unique identifier.

### Example


```python
import time
import ergo_node
from ergo_node.api import utxo_api
from ergo_node.model.ergo_transaction_output import ErgoTransactionOutput
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
    api_instance = utxo_api.UtxoApi(api_client)
    box_id = "boxId_example" # str | ID of a wanted box

    # example passing only required values which don't have defaults set
    try:
        # Get box contents for a box by a unique identifier.
        api_response = api_instance.get_box_by_id(box_id)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling UtxoApi->get_box_by_id: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **box_id** | **str**| ID of a wanted box |

### Return type

[**ErgoTransactionOutput**](ErgoTransactionOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Box object |  -  |
**404** | Box with this id doesn&#39;t exist |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_box_by_id_binary**
> SerializedBox get_box_by_id_binary(box_id)

Get serialized box from UTXO pool in Base16 encoding by an identifier.

### Example


```python
import time
import ergo_node
from ergo_node.api import utxo_api
from ergo_node.model.serialized_box import SerializedBox
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
    api_instance = utxo_api.UtxoApi(api_client)
    box_id = "boxId_example" # str | ID of a wanted box

    # example passing only required values which don't have defaults set
    try:
        # Get serialized box from UTXO pool in Base16 encoding by an identifier.
        api_response = api_instance.get_box_by_id_binary(box_id)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling UtxoApi->get_box_by_id_binary: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **box_id** | **str**| ID of a wanted box |

### Return type

[**SerializedBox**](SerializedBox.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Json containing box identifier and hex-encoded box bytes |  -  |
**404** | Box with this id doesn&#39;t exist |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_box_with_pool_by_id**
> ErgoTransactionOutput get_box_with_pool_by_id(box_id)

Get box contents for a box by a unique identifier, from UTXO set and also the mempool.

### Example


```python
import time
import ergo_node
from ergo_node.api import utxo_api
from ergo_node.model.ergo_transaction_output import ErgoTransactionOutput
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
    api_instance = utxo_api.UtxoApi(api_client)
    box_id = "boxId_example" # str | ID of a box to obtain

    # example passing only required values which don't have defaults set
    try:
        # Get box contents for a box by a unique identifier, from UTXO set and also the mempool.
        api_response = api_instance.get_box_with_pool_by_id(box_id)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling UtxoApi->get_box_with_pool_by_id: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **box_id** | **str**| ID of a box to obtain |

### Return type

[**ErgoTransactionOutput**](ErgoTransactionOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Box object |  -  |
**404** | Box with this id doesn&#39;t exist |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_box_with_pool_by_id_binary**
> SerializedBox get_box_with_pool_by_id_binary(box_id)

Get serialized box in Base16 encoding by an identifier, considering also the mempool.

### Example


```python
import time
import ergo_node
from ergo_node.api import utxo_api
from ergo_node.model.serialized_box import SerializedBox
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
    api_instance = utxo_api.UtxoApi(api_client)
    box_id = "boxId_example" # str | ID of a wanted box

    # example passing only required values which don't have defaults set
    try:
        # Get serialized box in Base16 encoding by an identifier, considering also the mempool.
        api_response = api_instance.get_box_with_pool_by_id_binary(box_id)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling UtxoApi->get_box_with_pool_by_id_binary: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **box_id** | **str**| ID of a wanted box |

### Return type

[**SerializedBox**](SerializedBox.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Json containing box identifier and hex-encoded box bytes |  -  |
**404** | Box with this id doesn&#39;t exist |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

