# ergo_node.InfoApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_node_info**](InfoApi.md#get_node_info) | **GET** /info | Get the information about the Node


# **get_node_info**
> NodeInfo get_node_info()

Get the information about the Node

### Example


```python
import time
import ergo_node
from ergo_node.api import info_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.node_info import NodeInfo
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)


# Enter a context with an instance of the API client
with ergo_node.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = info_api.InfoApi(api_client)

    # example, this endpoint has no required or optional parameters
    try:
        # Get the information about the Node
        api_response = api_instance.get_node_info()
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling InfoApi->get_node_info: %s\n" % e)
```


### Parameters
This endpoint does not need any parameter.

### Return type

[**NodeInfo**](NodeInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Node info object |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

