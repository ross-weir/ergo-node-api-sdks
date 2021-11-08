# ErgoNode.Api.ScanApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddBox**](ScanApi.md#addbox) | **POST** /scan/addBox | Adds a box to scans, writes box to database if it is not there. You can use scan number 10 to add a box to the wallet.
[**DeregisterScan**](ScanApi.md#deregisterscan) | **POST** /scan/deregister | Stop tracking and deregister scan
[**ListAllScans**](ScanApi.md#listallscans) | **GET** /scan/listAll | List all the registered scans
[**ListUnspentScans**](ScanApi.md#listunspentscans) | **GET** /scan/unspentBoxes/{scanId} | List boxes which are not spent.
[**RegisterScan**](ScanApi.md#registerscan) | **POST** /scan/register | Register a scan
[**ScanStopTracking**](ScanApi.md#scanstoptracking) | **POST** /scan/stopTracking | Stop scan-related box tracking


<a name="addbox"></a>
# **AddBox**
> string AddBox (ScanIdsBox scanIdsBox)

Adds a box to scans, writes box to database if it is not there. You can use scan number 10 to add a box to the wallet.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class AddBoxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ScanApi(config);
            var scanIdsBox = new ScanIdsBox(); // ScanIdsBox | 

            try
            {
                // Adds a box to scans, writes box to database if it is not there. You can use scan number 10 to add a box to the wallet.
                string result = apiInstance.AddBox(scanIdsBox);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanApi.AddBox: " + e.Message );
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
 **scanIdsBox** | [**ScanIdsBox**](ScanIdsBox.md)|  | 

### Return type

**string**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | It the box is added successfully, then its id is returned |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deregisterscan"></a>
# **DeregisterScan**
> ScanId DeregisterScan (ScanId scanId)

Stop tracking and deregister scan

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class DeregisterScanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ScanApi(config);
            var scanId = new ScanId(); // ScanId | 

            try
            {
                // Stop tracking and deregister scan
                ScanId result = apiInstance.DeregisterScan(scanId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanApi.DeregisterScan: " + e.Message );
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
 **scanId** | [**ScanId**](ScanId.md)|  | 

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
| **200** | Identifier of a scan removed |  -  |
| **400** | No scan found |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listallscans"></a>
# **ListAllScans**
> List&lt;Scan&gt; ListAllScans ()

List all the registered scans

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class ListAllScansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ScanApi(config);

            try
            {
                // List all the registered scans
                List<Scan> result = apiInstance.ListAllScans();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanApi.ListAllScans: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;Scan&gt;**](Scan.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of scans registered |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listunspentscans"></a>
# **ListUnspentScans**
> List&lt;WalletBox&gt; ListUnspentScans (int scanId, int? minConfirmations = null, int? minInclusionHeight = null)

List boxes which are not spent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class ListUnspentScansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ScanApi(config);
            var scanId = 56;  // int | identifier of a scan
            var minConfirmations = 56;  // int? | Minimal number of confirmations (optional)  (default to 0)
            var minInclusionHeight = 56;  // int? | Minimal box inclusion height (optional)  (default to 0)

            try
            {
                // List boxes which are not spent.
                List<WalletBox> result = apiInstance.ListUnspentScans(scanId, minConfirmations, minInclusionHeight);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanApi.ListUnspentScans: " + e.Message );
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
 **scanId** | **int**| identifier of a scan | 
 **minConfirmations** | **int?**| Minimal number of confirmations | [optional] [default to 0]
 **minInclusionHeight** | **int?**| Minimal box inclusion height | [optional] [default to 0]

### Return type

[**List&lt;WalletBox&gt;**](WalletBox.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of unspent boxes |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registerscan"></a>
# **RegisterScan**
> ScanId RegisterScan (ScanRequest scanRequest)

Register a scan

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class RegisterScanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ScanApi(config);
            var scanRequest = new ScanRequest(); // ScanRequest | 

            try
            {
                // Register a scan
                ScanId result = apiInstance.RegisterScan(scanRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanApi.RegisterScan: " + e.Message );
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
 **scanRequest** | [**ScanRequest**](ScanRequest.md)|  | 

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
| **200** | Identifier of a scan generated |  -  |
| **400** | Bad request |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scanstoptracking"></a>
# **ScanStopTracking**
> ScanIdBoxId ScanStopTracking (ScanIdBoxId scanIdBoxId)

Stop scan-related box tracking

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class ScanStopTrackingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new ScanApi(config);
            var scanIdBoxId = new ScanIdBoxId(); // ScanIdBoxId | 

            try
            {
                // Stop scan-related box tracking
                ScanIdBoxId result = apiInstance.ScanStopTracking(scanIdBoxId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScanApi.ScanStopTracking: " + e.Message );
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
 **scanIdBoxId** | [**ScanIdBoxId**](ScanIdBoxId.md)|  | 

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
| **200** | The box is not tracked anymore |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

