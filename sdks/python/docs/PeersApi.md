# ergo_node.PeersApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**connect_to_peer**](PeersApi.md#connect_to_peer) | **POST** /peers/connect | Add address to peers list
[**get_all_peers**](PeersApi.md#get_all_peers) | **GET** /peers/all | Get all known peers
[**get_blacklisted_peers**](PeersApi.md#get_blacklisted_peers) | **GET** /peers/blacklisted | Get blacklisted peers
[**get_connected_peers**](PeersApi.md#get_connected_peers) | **GET** /peers/connected | Get current connected peers
[**get_peers_status**](PeersApi.md#get_peers_status) | **GET** /peers/status | Get last incomming message timestamp and current network time


# **connect_to_peer**
> connect_to_peer(body)

Add address to peers list

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import peers_api
from ergo_node.model.api_error import ApiError
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure API key authorization: ApiKeyAuth
configuration.api_key['ApiKeyAuth'] = 'YOUR_API_KEY'

# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['ApiKeyAuth'] = 'Bearer'

# Enter a context with an instance of the API client
with ergo_node.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = peers_api.PeersApi(api_client)
    body = "127.0.0.1:5673" # str | 

    # example passing only required values which don't have defaults set
    try:
        # Add address to peers list
        api_instance.connect_to_peer(body)
    except ergo_node.ApiException as e:
        print("Exception when calling PeersApi->connect_to_peer: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **str**|  |

### Return type

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Attempt to connect to the peer |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_all_peers**
> [Peer] get_all_peers()

Get all known peers

### Example


```python
import time
import ergo_node
from ergo_node.api import peers_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.peer import Peer
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)


# Enter a context with an instance of the API client
with ergo_node.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = peers_api.PeersApi(api_client)

    # example, this endpoint has no required or optional parameters
    try:
        # Get all known peers
        api_response = api_instance.get_all_peers()
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling PeersApi->get_all_peers: %s\n" % e)
```


### Parameters
This endpoint does not need any parameter.

### Return type

[**[Peer]**](Peer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Array of peer objects |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_blacklisted_peers**
> BlacklistedPeers get_blacklisted_peers()

Get blacklisted peers

### Example


```python
import time
import ergo_node
from ergo_node.api import peers_api
from ergo_node.model.blacklisted_peers import BlacklistedPeers
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
    api_instance = peers_api.PeersApi(api_client)

    # example, this endpoint has no required or optional parameters
    try:
        # Get blacklisted peers
        api_response = api_instance.get_blacklisted_peers()
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling PeersApi->get_blacklisted_peers: %s\n" % e)
```


### Parameters
This endpoint does not need any parameter.

### Return type

[**BlacklistedPeers**](BlacklistedPeers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Array of the addresses |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_connected_peers**
> [Peer] get_connected_peers()

Get current connected peers

### Example


```python
import time
import ergo_node
from ergo_node.api import peers_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.peer import Peer
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)


# Enter a context with an instance of the API client
with ergo_node.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = peers_api.PeersApi(api_client)

    # example, this endpoint has no required or optional parameters
    try:
        # Get current connected peers
        api_response = api_instance.get_connected_peers()
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling PeersApi->get_connected_peers: %s\n" % e)
```


### Parameters
This endpoint does not need any parameter.

### Return type

[**[Peer]**](Peer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Array of peer objects |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_peers_status**
> PeersStatus get_peers_status()

Get last incomming message timestamp and current network time

### Example


```python
import time
import ergo_node
from ergo_node.api import peers_api
from ergo_node.model.peers_status import PeersStatus
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
    api_instance = peers_api.PeersApi(api_client)

    # example, this endpoint has no required or optional parameters
    try:
        # Get last incomming message timestamp and current network time
        api_response = api_instance.get_peers_status()
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling PeersApi->get_peers_status: %s\n" % e)
```


### Parameters
This endpoint does not need any parameter.

### Return type

[**PeersStatus**](PeersStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Network status |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

