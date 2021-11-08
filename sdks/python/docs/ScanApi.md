# ergo_node.ScanApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**add_box**](ScanApi.md#add_box) | **POST** /scan/addBox | Adds a box to scans, writes box to database if it is not there. You can use scan number 10 to add a box to the wallet.
[**deregister_scan**](ScanApi.md#deregister_scan) | **POST** /scan/deregister | Stop tracking and deregister scan
[**list_all_scans**](ScanApi.md#list_all_scans) | **GET** /scan/listAll | List all the registered scans
[**list_unspent_scans**](ScanApi.md#list_unspent_scans) | **GET** /scan/unspentBoxes/{scanId} | List boxes which are not spent.
[**register_scan**](ScanApi.md#register_scan) | **POST** /scan/register | Register a scan
[**scan_stop_tracking**](ScanApi.md#scan_stop_tracking) | **POST** /scan/stopTracking | Stop scan-related box tracking


# **add_box**
> str add_box(scan_ids_box)

Adds a box to scans, writes box to database if it is not there. You can use scan number 10 to add a box to the wallet.

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import scan_api
from ergo_node.model.scan_ids_box import ScanIdsBox
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
    api_instance = scan_api.ScanApi(api_client)
    scan_ids_box = ScanIdsBox(
        scan_ids=[
            1,
        ],
        box=ErgoTransactionOutput(
            box_id="1ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
            value=147,
            ergo_tree="0008cd0336100ef59ced80ba5f89c4178ebd57b6c1dd0f3d135ee1db9f62fc634d637041",
            creation_height=9149,
            assets=[
                Asset(
                    token_id="4ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
                    amount=1000,
                ),
            ],
            additional_registers=Registers(
                key="100204a00b08cd0336100ef59ced80ba5f89c4178ebd57b6c1dd0f3d135ee1db9f62fc634d637041ea02d192a39a8cc7a70173007301",
            ),
            transaction_id="2ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
            index=1,
        ),
    ) # ScanIdsBox | 

    # example passing only required values which don't have defaults set
    try:
        # Adds a box to scans, writes box to database if it is not there. You can use scan number 10 to add a box to the wallet.
        api_response = api_instance.add_box(scan_ids_box)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling ScanApi->add_box: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scan_ids_box** | [**ScanIdsBox**](ScanIdsBox.md)|  |

### Return type

**str**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | It the box is added successfully, then its id is returned |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **deregister_scan**
> ScanId deregister_scan(scan_id)

Stop tracking and deregister scan

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import scan_api
from ergo_node.model.scan_id import ScanId
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
    api_instance = scan_api.ScanApi(api_client)
    scan_id = ScanId(
        scan_id=1,
    ) # ScanId | 

    # example passing only required values which don't have defaults set
    try:
        # Stop tracking and deregister scan
        api_response = api_instance.deregister_scan(scan_id)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling ScanApi->deregister_scan: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scan_id** | [**ScanId**](ScanId.md)|  |

### Return type

[**ScanId**](ScanId.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Identifier of a scan removed |  -  |
**400** | No scan found |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **list_all_scans**
> [Scan] list_all_scans()

List all the registered scans

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import scan_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.scan import Scan
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
    api_instance = scan_api.ScanApi(api_client)

    # example, this endpoint has no required or optional parameters
    try:
        # List all the registered scans
        api_response = api_instance.list_all_scans()
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling ScanApi->list_all_scans: %s\n" % e)
```


### Parameters
This endpoint does not need any parameter.

### Return type

[**[Scan]**](Scan.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | List of scans registered |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **list_unspent_scans**
> [WalletBox] list_unspent_scans(scan_id)

List boxes which are not spent.

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import scan_api
from ergo_node.model.wallet_box import WalletBox
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
    api_instance = scan_api.ScanApi(api_client)
    scan_id = 1 # int | identifier of a scan
    min_confirmations = 0 # int | Minimal number of confirmations (optional) if omitted the server will use the default value of 0
    min_inclusion_height = 0 # int | Minimal box inclusion height (optional) if omitted the server will use the default value of 0

    # example passing only required values which don't have defaults set
    try:
        # List boxes which are not spent.
        api_response = api_instance.list_unspent_scans(scan_id)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling ScanApi->list_unspent_scans: %s\n" % e)

    # example passing only required values which don't have defaults set
    # and optional values
    try:
        # List boxes which are not spent.
        api_response = api_instance.list_unspent_scans(scan_id, min_confirmations=min_confirmations, min_inclusion_height=min_inclusion_height)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling ScanApi->list_unspent_scans: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scan_id** | **int**| identifier of a scan |
 **min_confirmations** | **int**| Minimal number of confirmations | [optional] if omitted the server will use the default value of 0
 **min_inclusion_height** | **int**| Minimal box inclusion height | [optional] if omitted the server will use the default value of 0

### Return type

[**[WalletBox]**](WalletBox.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | List of unspent boxes |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **register_scan**
> ScanId register_scan(scan_request)

Register a scan

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import scan_api
from ergo_node.model.scan_id import ScanId
from ergo_node.model.api_error import ApiError
from ergo_node.model.scan_request import ScanRequest
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
    api_instance = scan_api.ScanApi(api_client)
    scan_request = ScanRequest(
        scan_name="scan_name_example",
        tracking_rule=ScanningPredicate(
            predicate="predicate_example",
        ),
    ) # ScanRequest | 

    # example passing only required values which don't have defaults set
    try:
        # Register a scan
        api_response = api_instance.register_scan(scan_request)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling ScanApi->register_scan: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scan_request** | [**ScanRequest**](ScanRequest.md)|  |

### Return type

[**ScanId**](ScanId.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Identifier of a scan generated |  -  |
**400** | Bad request |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **scan_stop_tracking**
> ScanIdBoxId scan_stop_tracking(scan_id_box_id)

Stop scan-related box tracking

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import scan_api
from ergo_node.model.scan_id_box_id import ScanIdBoxId
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
    api_instance = scan_api.ScanApi(api_client)
    scan_id_box_id = ScanIdBoxId(
        scan_id=1,
        box_id="1ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
    ) # ScanIdBoxId | 

    # example passing only required values which don't have defaults set
    try:
        # Stop scan-related box tracking
        api_response = api_instance.scan_stop_tracking(scan_id_box_id)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling ScanApi->scan_stop_tracking: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scan_id_box_id** | [**ScanIdBoxId**](ScanIdBoxId.md)|  |

### Return type

[**ScanIdBoxId**](ScanIdBoxId.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | The box is not tracked anymore |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

