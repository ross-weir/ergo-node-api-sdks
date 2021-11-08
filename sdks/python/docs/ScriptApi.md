# ergo_node.ScriptApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**address_to_bytes**](ScriptApi.md#address_to_bytes) | **GET** /script/addressToBytes/{address} | Convert an address to hex-encoded Sigma byte array constant which contains script bytes
[**address_to_tree**](ScriptApi.md#address_to_tree) | **GET** /script/addressToTree/{address} | Convert an address to hex-encoded serialized ErgoTree (script)
[**execute_with_context**](ScriptApi.md#execute_with_context) | **POST** /script/executeWithContext | Execute script with context
[**script_p2_s_address**](ScriptApi.md#script_p2_s_address) | **POST** /script/p2sAddress | Create P2SAddress from Sigma source
[**script_p2_sh_address**](ScriptApi.md#script_p2_sh_address) | **POST** /script/p2shAddress | Create P2SHAddress from Sigma source


# **address_to_bytes**
> InlineResponse2008 address_to_bytes(address)

Convert an address to hex-encoded Sigma byte array constant which contains script bytes

### Example


```python
import time
import ergo_node
from ergo_node.api import script_api
from ergo_node.model.inline_response2008 import InlineResponse2008
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
    api_instance = script_api.ScriptApi(api_client)
    address = "3WwbzW6u8hKWBcL1W7kNVMr25s2UHfSBnYtwSHvrRQt7DdPuoXrt" # str | address to get a script from

    # example passing only required values which don't have defaults set
    try:
        # Convert an address to hex-encoded Sigma byte array constant which contains script bytes
        api_response = api_instance.address_to_bytes(address)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling ScriptApi->address_to_bytes: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **str**| address to get a script from |

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Base16-encoded Sigma byte array constant which contains script bytes |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **address_to_tree**
> InlineResponse2007 address_to_tree(address)

Convert an address to hex-encoded serialized ErgoTree (script)

### Example


```python
import time
import ergo_node
from ergo_node.api import script_api
from ergo_node.model.inline_response2007 import InlineResponse2007
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
    api_instance = script_api.ScriptApi(api_client)
    address = "3WwbzW6u8hKWBcL1W7kNVMr25s2UHfSBnYtwSHvrRQt7DdPuoXrt" # str | address to get a script from

    # example passing only required values which don't have defaults set
    try:
        # Convert an address to hex-encoded serialized ErgoTree (script)
        api_response = api_instance.address_to_tree(address)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling ScriptApi->address_to_tree: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **str**| address to get a script from |

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Base16-encoded ErgoTree (script) |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **execute_with_context**
> CryptoResult execute_with_context(execute_script)

Execute script with context

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import script_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.execute_script import ExecuteScript
from ergo_node.model.crypto_result import CryptoResult
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
    api_instance = script_api.ScriptApi(api_client)
    execute_script = ExecuteScript(
        script="script_example",
        named_constants={},
        context=ErgoLikeContext(None),
    ) # ExecuteScript | 

    # example passing only required values which don't have defaults set
    try:
        # Execute script with context
        api_response = api_instance.execute_with_context(execute_script)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling ScriptApi->execute_with_context: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **execute_script** | [**ExecuteScript**](ExecuteScript.md)|  |

### Return type

[**CryptoResult**](CryptoResult.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Result of reduceToCrypto |  -  |
**400** | Compiler error |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **script_p2_s_address**
> AddressHolder script_p2_s_address(source_holder)

Create P2SAddress from Sigma source

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import script_api
from ergo_node.model.source_holder import SourceHolder
from ergo_node.model.address_holder import AddressHolder
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
    api_instance = script_api.ScriptApi(api_client)
    source_holder = SourceHolder(
        source="source_example",
    ) # SourceHolder | 

    # example passing only required values which don't have defaults set
    try:
        # Create P2SAddress from Sigma source
        api_response = api_instance.script_p2_s_address(source_holder)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling ScriptApi->script_p2_s_address: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **source_holder** | [**SourceHolder**](SourceHolder.md)|  |

### Return type

[**AddressHolder**](AddressHolder.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Ergo address derived from source |  -  |
**400** | Bad source |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **script_p2_sh_address**
> AddressHolder script_p2_sh_address(source_holder)

Create P2SHAddress from Sigma source

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import script_api
from ergo_node.model.source_holder import SourceHolder
from ergo_node.model.address_holder import AddressHolder
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
    api_instance = script_api.ScriptApi(api_client)
    source_holder = SourceHolder(
        source="source_example",
    ) # SourceHolder | 

    # example passing only required values which don't have defaults set
    try:
        # Create P2SHAddress from Sigma source
        api_response = api_instance.script_p2_sh_address(source_holder)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling ScriptApi->script_p2_sh_address: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **source_holder** | [**SourceHolder**](SourceHolder.md)|  |

### Return type

[**AddressHolder**](AddressHolder.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Ergo address derived from source |  -  |
**400** | Bad source |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

