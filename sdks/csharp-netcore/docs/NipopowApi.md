# ErgoNode.Api.NipopowApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPopowHeaderByHeight**](NipopowApi.md#getpopowheaderbyheight) | **GET** /nipopow/popowHeaderByHeight/{height} | Construct PoPow header for best header at given height
[**GetPopowHeaderById**](NipopowApi.md#getpopowheaderbyid) | **GET** /nipopow/popowHeaderById/{headerId} | Construct PoPow header according to given header id
[**GetPopowProof**](NipopowApi.md#getpopowproof) | **GET** /nipopow/proof/{minChainLength}/{suffixLength} | Construct PoPoW proof for given min superchain length and suffix length
[**GetPopowProofByHeaderId**](NipopowApi.md#getpopowproofbyheaderid) | **GET** /nipopow/proof/{minChainLength}/{suffixLength}/{headerId} | Construct PoPoW proof for given min superchain length, suffix length and header ID


<a name="getpopowheaderbyheight"></a>
# **GetPopowHeaderByHeight**
> PopowHeader GetPopowHeaderByHeight (int height)

Construct PoPow header for best header at given height

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetPopowHeaderByHeightExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new NipopowApi(config);
            var height = 56;  // int | Height of a wanted header

            try
            {
                // Construct PoPow header for best header at given height
                PopowHeader result = apiInstance.GetPopowHeaderByHeight(height);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NipopowApi.GetPopowHeaderByHeight: " + e.Message );
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
| **200** | PoPow header object |  -  |
| **404** | Header of extension of a corresponding block are not available |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpopowheaderbyid"></a>
# **GetPopowHeaderById**
> PopowHeader GetPopowHeaderById (string headerId)

Construct PoPow header according to given header id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetPopowHeaderByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new NipopowApi(config);
            var headerId = headerId_example;  // string | ID of wanted header

            try
            {
                // Construct PoPow header according to given header id
                PopowHeader result = apiInstance.GetPopowHeaderById(headerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NipopowApi.GetPopowHeaderById: " + e.Message );
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
 **headerId** | **string**| ID of wanted header | 

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
| **200** | PoPow header object |  -  |
| **404** | Header of extension of a corresponding block are not available |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpopowproof"></a>
# **GetPopowProof**
> NipopowProof GetPopowProof (decimal minChainLength, decimal suffixLength)

Construct PoPoW proof for given min superchain length and suffix length

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetPopowProofExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new NipopowApi(config);
            var minChainLength = 8.14;  // decimal | Minimal superchain length
            var suffixLength = 8.14;  // decimal | Suffix length

            try
            {
                // Construct PoPoW proof for given min superchain length and suffix length
                NipopowProof result = apiInstance.GetPopowProof(minChainLength, suffixLength);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NipopowApi.GetPopowProof: " + e.Message );
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
 **minChainLength** | **decimal**| Minimal superchain length | 
 **suffixLength** | **decimal**| Suffix length | 

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
| **200** | Nipopow proof object |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpopowproofbyheaderid"></a>
# **GetPopowProofByHeaderId**
> NipopowProof GetPopowProofByHeaderId (decimal minChainLength, decimal suffixLength, string headerId)

Construct PoPoW proof for given min superchain length, suffix length and header ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetPopowProofByHeaderIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new NipopowApi(config);
            var minChainLength = 8.14;  // decimal | Minimal superchain length
            var suffixLength = 8.14;  // decimal | Suffix length
            var headerId = headerId_example;  // string | ID of wanted header

            try
            {
                // Construct PoPoW proof for given min superchain length, suffix length and header ID
                NipopowProof result = apiInstance.GetPopowProofByHeaderId(minChainLength, suffixLength, headerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NipopowApi.GetPopowProofByHeaderId: " + e.Message );
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
 **minChainLength** | **decimal**| Minimal superchain length | 
 **suffixLength** | **decimal**| Suffix length | 
 **headerId** | **string**| ID of wanted header | 

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
| **200** | Nipopow proof object |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

