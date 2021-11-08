# ErgoNode.Api.InfoApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetNodeInfo**](InfoApi.md#getnodeinfo) | **GET** /info | Get the information about the Node


<a name="getnodeinfo"></a>
# **GetNodeInfo**
> NodeInfo GetNodeInfo ()

Get the information about the Node

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetNodeInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new InfoApi(config);

            try
            {
                // Get the information about the Node
                NodeInfo result = apiInstance.GetNodeInfo();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InfoApi.GetNodeInfo: " + e.Message );
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

[**NodeInfo**](NodeInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Node info object |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

