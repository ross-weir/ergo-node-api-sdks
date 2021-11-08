# ErgoNode.Api.BlocksApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBlockHeaderById**](BlocksApi.md#getblockheaderbyid) | **GET** /blocks/{headerId}/header | Get the block header info by a given signature
[**GetBlockTransactionsById**](BlocksApi.md#getblocktransactionsbyid) | **GET** /blocks/{headerId}/transactions | Get the block transactions info by a given signature
[**GetChainSlice**](BlocksApi.md#getchainslice) | **GET** /blocks/chainSlice | Get headers in a specified range
[**GetFullBlockAt**](BlocksApi.md#getfullblockat) | **GET** /blocks/at/{blockHeight} | Get the header ids at a given height
[**GetFullBlockById**](BlocksApi.md#getfullblockbyid) | **GET** /blocks/{headerId} | Get the full block info by a given signature
[**GetHeaderIds**](BlocksApi.md#getheaderids) | **GET** /blocks | Get the Array of header ids
[**GetLastHeaders**](BlocksApi.md#getlastheaders) | **GET** /blocks/lastHeaders/{count} | Get the last headers objects
[**GetModifierById**](BlocksApi.md#getmodifierbyid) | **GET** /blocks/modifier/{modifierId} | Get the persistent modifier by its id
[**GetProofForTx**](BlocksApi.md#getprooffortx) | **GET** /blocks/{headerId}/proofFor/{txId} | Get Merkle proof for transaction
[**SendMinedBlock**](BlocksApi.md#sendminedblock) | **POST** /blocks | Send a mined block


<a name="getblockheaderbyid"></a>
# **GetBlockHeaderById**
> BlockHeader GetBlockHeaderById (string headerId)

Get the block header info by a given signature

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetBlockHeaderByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BlocksApi(config);
            var headerId = headerId_example;  // string | ID of a wanted block header

            try
            {
                // Get the block header info by a given signature
                BlockHeader result = apiInstance.GetBlockHeaderById(headerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlocksApi.GetBlockHeaderById: " + e.Message );
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
 **headerId** | **string**| ID of a wanted block header | 

### Return type

[**BlockHeader**](BlockHeader.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Block header object |  -  |
| **404** | Block with this id doesn&#39;t exist |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getblocktransactionsbyid"></a>
# **GetBlockTransactionsById**
> BlockTransactions GetBlockTransactionsById (string headerId)

Get the block transactions info by a given signature

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetBlockTransactionsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BlocksApi(config);
            var headerId = headerId_example;  // string | ID of a wanted block transactions

            try
            {
                // Get the block transactions info by a given signature
                BlockTransactions result = apiInstance.GetBlockTransactionsById(headerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlocksApi.GetBlockTransactionsById: " + e.Message );
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
 **headerId** | **string**| ID of a wanted block transactions | 

### Return type

[**BlockTransactions**](BlockTransactions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Block transaction object |  -  |
| **404** | Block with this id doesn&#39;t exist |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchainslice"></a>
# **GetChainSlice**
> List&lt;BlockHeader&gt; GetChainSlice (int? fromHeight = null, int? toHeight = null)

Get headers in a specified range

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetChainSliceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BlocksApi(config);
            var fromHeight = 56;  // int? | Min header height (optional)  (default to 0)
            var toHeight = 56;  // int? | Max header height (best header height by default) (optional)  (default to -1)

            try
            {
                // Get headers in a specified range
                List<BlockHeader> result = apiInstance.GetChainSlice(fromHeight, toHeight);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlocksApi.GetChainSlice: " + e.Message );
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
 **fromHeight** | **int?**| Min header height | [optional] [default to 0]
 **toHeight** | **int?**| Max header height (best header height by default) | [optional] [default to -1]

### Return type

[**List&lt;BlockHeader&gt;**](BlockHeader.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Array of headers |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfullblockat"></a>
# **GetFullBlockAt**
> List&lt;string&gt; GetFullBlockAt (int blockHeight)

Get the header ids at a given height

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetFullBlockAtExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BlocksApi(config);
            var blockHeight = 56;  // int | Height of a wanted block

            try
            {
                // Get the header ids at a given height
                List<string> result = apiInstance.GetFullBlockAt(blockHeight);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlocksApi.GetFullBlockAt: " + e.Message );
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
 **blockHeight** | **int**| Height of a wanted block | 

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Array of header ids |  -  |
| **404** | Blocks at this height doesn&#39;t exist |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfullblockbyid"></a>
# **GetFullBlockById**
> FullBlock GetFullBlockById (string headerId)

Get the full block info by a given signature

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetFullBlockByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BlocksApi(config);
            var headerId = headerId_example;  // string | ID of a wanted block

            try
            {
                // Get the full block info by a given signature
                FullBlock result = apiInstance.GetFullBlockById(headerId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlocksApi.GetFullBlockById: " + e.Message );
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
 **headerId** | **string**| ID of a wanted block | 

### Return type

[**FullBlock**](FullBlock.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Block object |  -  |
| **404** | Block with this id doesn&#39;t exist |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getheaderids"></a>
# **GetHeaderIds**
> List&lt;string&gt; GetHeaderIds (int? limit = null, int? offset = null)

Get the Array of header ids

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetHeaderIdsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BlocksApi(config);
            var limit = 56;  // int? | The number of items in list to return (optional)  (default to 50)
            var offset = 56;  // int? | The number of items in list to skip (optional)  (default to 0)

            try
            {
                // Get the Array of header ids
                List<string> result = apiInstance.GetHeaderIds(limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlocksApi.GetHeaderIds: " + e.Message );
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
 **limit** | **int?**| The number of items in list to return | [optional] [default to 50]
 **offset** | **int?**| The number of items in list to skip | [optional] [default to 0]

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Array of header ids |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlastheaders"></a>
# **GetLastHeaders**
> List&lt;BlockHeader&gt; GetLastHeaders (decimal count)

Get the last headers objects

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetLastHeadersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BlocksApi(config);
            var count = 8.14;  // decimal | count of a wanted block headers

            try
            {
                // Get the last headers objects
                List<BlockHeader> result = apiInstance.GetLastHeaders(count);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlocksApi.GetLastHeaders: " + e.Message );
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
 **count** | **decimal**| count of a wanted block headers | 

### Return type

[**List&lt;BlockHeader&gt;**](BlockHeader.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Array of block headers |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmodifierbyid"></a>
# **GetModifierById**
> void GetModifierById (string modifierId)

Get the persistent modifier by its id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetModifierByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BlocksApi(config);
            var modifierId = modifierId_example;  // string | ID of a wanted modifier

            try
            {
                // Get the persistent modifier by its id
                apiInstance.GetModifierById(modifierId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlocksApi.GetModifierById: " + e.Message );
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
 **modifierId** | **string**| ID of a wanted modifier | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Persistent modifier object |  -  |
| **404** | Modifier with this id doesn&#39;t exist |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getprooffortx"></a>
# **GetProofForTx**
> MerkleProof GetProofForTx (string headerId, string txId)

Get Merkle proof for transaction

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetProofForTxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BlocksApi(config);
            var headerId = headerId_example;  // string | ID of a wanted block transactions
            var txId = txId_example;  // string | ID of a wanted transaction

            try
            {
                // Get Merkle proof for transaction
                MerkleProof result = apiInstance.GetProofForTx(headerId, txId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlocksApi.GetProofForTx: " + e.Message );
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
 **headerId** | **string**| ID of a wanted block transactions | 
 **txId** | **string**| ID of a wanted transaction | 

### Return type

[**MerkleProof**](MerkleProof.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Merkle proof object |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendminedblock"></a>
# **SendMinedBlock**
> void SendMinedBlock (FullBlock fullBlock)

Send a mined block

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class SendMinedBlockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BlocksApi(config);
            var fullBlock = new FullBlock(); // FullBlock | 

            try
            {
                // Send a mined block
                apiInstance.SendMinedBlock(fullBlock);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlocksApi.SendMinedBlock: " + e.Message );
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
 **fullBlock** | [**FullBlock**](FullBlock.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Block is valid |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

