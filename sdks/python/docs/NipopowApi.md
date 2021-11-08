# ergo_node.NipopowApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_popow_header_by_height**](NipopowApi.md#get_popow_header_by_height) | **GET** /nipopow/popowHeaderByHeight/{height} | Construct PoPow header for best header at given height
[**get_popow_header_by_id**](NipopowApi.md#get_popow_header_by_id) | **GET** /nipopow/popowHeaderById/{headerId} | Construct PoPow header according to given header id
[**get_popow_proof**](NipopowApi.md#get_popow_proof) | **GET** /nipopow/proof/{minChainLength}/{suffixLength} | Construct PoPoW proof for given min superchain length and suffix length
[**get_popow_proof_by_header_id**](NipopowApi.md#get_popow_proof_by_header_id) | **GET** /nipopow/proof/{minChainLength}/{suffixLength}/{headerId} | Construct PoPoW proof for given min superchain length, suffix length and header ID


# **get_popow_header_by_height**
> PopowHeader get_popow_header_by_height(height)

Construct PoPow header for best header at given height

### Example


```python
import time
import ergo_node
from ergo_node.api import nipopow_api
from ergo_node.model.popow_header import PopowHeader
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
    api_instance = nipopow_api.NipopowApi(api_client)
    height = 1 # int | Height of a wanted header

    # example passing only required values which don't have defaults set
    try:
        # Construct PoPow header for best header at given height
        api_response = api_instance.get_popow_header_by_height(height)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling NipopowApi->get_popow_header_by_height: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **height** | **int**| Height of a wanted header |

### Return type

[**PopowHeader**](PopowHeader.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | PoPow header object |  -  |
**404** | Header of extension of a corresponding block are not available |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_popow_header_by_id**
> PopowHeader get_popow_header_by_id(header_id)

Construct PoPow header according to given header id

### Example


```python
import time
import ergo_node
from ergo_node.api import nipopow_api
from ergo_node.model.popow_header import PopowHeader
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
    api_instance = nipopow_api.NipopowApi(api_client)
    header_id = "headerId_example" # str | ID of wanted header

    # example passing only required values which don't have defaults set
    try:
        # Construct PoPow header according to given header id
        api_response = api_instance.get_popow_header_by_id(header_id)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling NipopowApi->get_popow_header_by_id: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **header_id** | **str**| ID of wanted header |

### Return type

[**PopowHeader**](PopowHeader.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | PoPow header object |  -  |
**404** | Header of extension of a corresponding block are not available |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_popow_proof**
> NipopowProof get_popow_proof(min_chain_length, suffix_length)

Construct PoPoW proof for given min superchain length and suffix length

### Example


```python
import time
import ergo_node
from ergo_node.api import nipopow_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.nipopow_proof import NipopowProof
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)


# Enter a context with an instance of the API client
with ergo_node.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = nipopow_api.NipopowApi(api_client)
    min_chain_length = 3.14 # float | Minimal superchain length
    suffix_length = 3.14 # float | Suffix length

    # example passing only required values which don't have defaults set
    try:
        # Construct PoPoW proof for given min superchain length and suffix length
        api_response = api_instance.get_popow_proof(min_chain_length, suffix_length)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling NipopowApi->get_popow_proof: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **min_chain_length** | **float**| Minimal superchain length |
 **suffix_length** | **float**| Suffix length |

### Return type

[**NipopowProof**](NipopowProof.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Nipopow proof object |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_popow_proof_by_header_id**
> NipopowProof get_popow_proof_by_header_id(min_chain_length, suffix_length, header_id)

Construct PoPoW proof for given min superchain length, suffix length and header ID

### Example


```python
import time
import ergo_node
from ergo_node.api import nipopow_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.nipopow_proof import NipopowProof
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)


# Enter a context with an instance of the API client
with ergo_node.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = nipopow_api.NipopowApi(api_client)
    min_chain_length = 3.14 # float | Minimal superchain length
    suffix_length = 3.14 # float | Suffix length
    header_id = "headerId_example" # str | ID of wanted header

    # example passing only required values which don't have defaults set
    try:
        # Construct PoPoW proof for given min superchain length, suffix length and header ID
        api_response = api_instance.get_popow_proof_by_header_id(min_chain_length, suffix_length, header_id)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling NipopowApi->get_popow_proof_by_header_id: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **min_chain_length** | **float**| Minimal superchain length |
 **suffix_length** | **float**| Suffix length |
 **header_id** | **str**| ID of wanted header |

### Return type

[**NipopowProof**](NipopowProof.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Nipopow proof object |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

