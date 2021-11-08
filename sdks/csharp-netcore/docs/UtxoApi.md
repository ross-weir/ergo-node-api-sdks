# ErgoNode.Api.UtxoApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GenesisBoxes**](UtxoApi.md#genesisboxes) | **GET** /utxo/genesis | Get genesis boxes (boxes existed before the very first block)
[**GetBoxById**](UtxoApi.md#getboxbyid) | **GET** /utxo/byId/{boxId} | Get box contents for a box by a unique identifier.
[**GetBoxByIdBinary**](UtxoApi.md#getboxbyidbinary) | **GET** /utxo/byIdBinary/{boxId} | Get serialized box from UTXO pool in Base16 encoding by an identifier.
[**GetBoxWithPoolById**](UtxoApi.md#getboxwithpoolbyid) | **GET** /utxo/withPool/byId/{boxId} | Get box contents for a box by a unique identifier, from UTXO set and also the mempool.
[**GetBoxWithPoolByIdBinary**](UtxoApi.md#getboxwithpoolbyidbinary) | **GET** /utxo/withPool/byIdBinary/{boxId} | Get serialized box in Base16 encoding by an identifier, considering also the mempool.


<a name="genesisboxes"></a>
# **GenesisBoxes**
> List&lt;ErgoTransactionOutput&gt; GenesisBoxes ()

Get genesis boxes (boxes existed before the very first block)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GenesisBoxesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UtxoApi(config);

            try
            {
                // Get genesis boxes (boxes existed before the very first block)
                List<ErgoTransactionOutput> result = apiInstance.GenesisBoxes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UtxoApi.GenesisBoxes: " + e.Message );
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

[**List&lt;ErgoTransactionOutput&gt;**](ErgoTransactionOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of all the genesis boxes |  -  |
| **404** | Box with this id doesn&#39;t exist |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getboxbyid"></a>
# **GetBoxById**
> ErgoTransactionOutput GetBoxById (string boxId)

Get box contents for a box by a unique identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetBoxByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UtxoApi(config);
            var boxId = boxId_example;  // string | ID of a wanted box

            try
            {
                // Get box contents for a box by a unique identifier.
                ErgoTransactionOutput result = apiInstance.GetBoxById(boxId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UtxoApi.GetBoxById: " + e.Message );
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
 **boxId** | **string**| ID of a wanted box | 

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
| **200** | Box object |  -  |
| **404** | Box with this id doesn&#39;t exist |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getboxbyidbinary"></a>
# **GetBoxByIdBinary**
> SerializedBox GetBoxByIdBinary (string boxId)

Get serialized box from UTXO pool in Base16 encoding by an identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetBoxByIdBinaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UtxoApi(config);
            var boxId = boxId_example;  // string | ID of a wanted box

            try
            {
                // Get serialized box from UTXO pool in Base16 encoding by an identifier.
                SerializedBox result = apiInstance.GetBoxByIdBinary(boxId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UtxoApi.GetBoxByIdBinary: " + e.Message );
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
 **boxId** | **string**| ID of a wanted box | 

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
| **200** | Json containing box identifier and hex-encoded box bytes |  -  |
| **404** | Box with this id doesn&#39;t exist |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getboxwithpoolbyid"></a>
# **GetBoxWithPoolById**
> ErgoTransactionOutput GetBoxWithPoolById (string boxId)

Get box contents for a box by a unique identifier, from UTXO set and also the mempool.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetBoxWithPoolByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UtxoApi(config);
            var boxId = boxId_example;  // string | ID of a box to obtain

            try
            {
                // Get box contents for a box by a unique identifier, from UTXO set and also the mempool.
                ErgoTransactionOutput result = apiInstance.GetBoxWithPoolById(boxId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UtxoApi.GetBoxWithPoolById: " + e.Message );
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
 **boxId** | **string**| ID of a box to obtain | 

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
| **200** | Box object |  -  |
| **404** | Box with this id doesn&#39;t exist |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getboxwithpoolbyidbinary"></a>
# **GetBoxWithPoolByIdBinary**
> SerializedBox GetBoxWithPoolByIdBinary (string boxId)

Get serialized box in Base16 encoding by an identifier, considering also the mempool.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetBoxWithPoolByIdBinaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UtxoApi(config);
            var boxId = boxId_example;  // string | ID of a wanted box

            try
            {
                // Get serialized box in Base16 encoding by an identifier, considering also the mempool.
                SerializedBox result = apiInstance.GetBoxWithPoolByIdBinary(boxId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UtxoApi.GetBoxWithPoolByIdBinary: " + e.Message );
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
 **boxId** | **string**| ID of a wanted box | 

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
| **200** | Json containing box identifier and hex-encoded box bytes |  -  |
| **404** | Box with this id doesn&#39;t exist |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

