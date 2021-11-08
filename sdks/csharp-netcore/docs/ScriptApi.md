# ErgoNode.Api.ScriptApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddressToBytes**](ScriptApi.md#addresstobytes) | **GET** /script/addressToBytes/{address} | Convert an address to hex-encoded Sigma byte array constant which contains script bytes
[**AddressToTree**](ScriptApi.md#addresstotree) | **GET** /script/addressToTree/{address} | Convert an address to hex-encoded serialized ErgoTree (script)
[**ExecuteWithContext**](ScriptApi.md#executewithcontext) | **POST** /script/executeWithContext | Execute script with context
[**ScriptP2SAddress**](ScriptApi.md#scriptp2saddress) | **POST** /script/p2sAddress | Create P2SAddress from Sigma source
[**ScriptP2SHAddress**](ScriptApi.md#scriptp2shaddress) | **POST** /script/p2shAddress | Create P2SHAddress from Sigma source


<a name="addresstobytes"></a>
# **AddressToBytes**
> InlineResponse2008 AddressToBytes (string address)

Convert an address to hex-encoded Sigma byte array constant which contains script bytes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class AddressToBytesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ScriptApi(config);
            var address = address_example;  // string | address to get a script from

            try
            {
                // Convert an address to hex-encoded Sigma byte array constant which contains script bytes
                InlineResponse2008 result = apiInstance.AddressToBytes(address);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScriptApi.AddressToBytes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| address to get a script from | 

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
| **200** | Base16-encoded Sigma byte array constant which contains script bytes |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addresstotree"></a>
# **AddressToTree**
> InlineResponse2007 AddressToTree (string address)

Convert an address to hex-encoded serialized ErgoTree (script)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class AddressToTreeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ScriptApi(config);
            var address = address_example;  // string | address to get a script from

            try
            {
                // Convert an address to hex-encoded serialized ErgoTree (script)
                InlineResponse2007 result = apiInstance.AddressToTree(address);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScriptApi.AddressToTree: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| address to get a script from | 

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
| **200** | Base16-encoded ErgoTree (script) |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executewithcontext"></a>
# **ExecuteWithContext**
> CryptoResult ExecuteWithContext (ExecuteScript executeScript)

Execute script with context

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class ExecuteWithContextExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ScriptApi(config);
            var executeScript = new ExecuteScript(); // ExecuteScript | 

            try
            {
                // Execute script with context
                CryptoResult result = apiInstance.ExecuteWithContext(executeScript);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScriptApi.ExecuteWithContext: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **executeScript** | [**ExecuteScript**](ExecuteScript.md)|  | 

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
| **200** | Result of reduceToCrypto |  -  |
| **400** | Compiler error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scriptp2saddress"></a>
# **ScriptP2SAddress**
> AddressHolder ScriptP2SAddress (SourceHolder sourceHolder)

Create P2SAddress from Sigma source

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class ScriptP2SAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ScriptApi(config);
            var sourceHolder = new SourceHolder(); // SourceHolder | 

            try
            {
                // Create P2SAddress from Sigma source
                AddressHolder result = apiInstance.ScriptP2SAddress(sourceHolder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScriptApi.ScriptP2SAddress: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sourceHolder** | [**SourceHolder**](SourceHolder.md)|  | 

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
| **200** | Ergo address derived from source |  -  |
| **400** | Bad source |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scriptp2shaddress"></a>
# **ScriptP2SHAddress**
> AddressHolder ScriptP2SHAddress (SourceHolder sourceHolder)

Create P2SHAddress from Sigma source

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class ScriptP2SHAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ScriptApi(config);
            var sourceHolder = new SourceHolder(); // SourceHolder | 

            try
            {
                // Create P2SHAddress from Sigma source
                AddressHolder result = apiInstance.ScriptP2SHAddress(sourceHolder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScriptApi.ScriptP2SHAddress: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sourceHolder** | [**SourceHolder**](SourceHolder.md)|  | 

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
| **200** | Ergo address derived from source |  -  |
| **400** | Bad source |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

