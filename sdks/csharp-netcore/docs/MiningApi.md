# ErgoNode.Api.MiningApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MiningReadMinerRewardAddress**](MiningApi.md#miningreadminerrewardaddress) | **GET** /mining/rewardAddress | Read miner reward address
[**MiningReadMinerRewardPubkey**](MiningApi.md#miningreadminerrewardpubkey) | **GET** /mining/rewardPublicKey | Read public key associated with miner rewards
[**MiningRequestBlockCandidate**](MiningApi.md#miningrequestblockcandidate) | **GET** /mining/candidate | Request block candidate
[**MiningRequestBlockCandidateWithMandatoryTransactions**](MiningApi.md#miningrequestblockcandidatewithmandatorytransactions) | **POST** /mining/candidateWithTxs | Request block candidate
[**MiningSubmitSolution**](MiningApi.md#miningsubmitsolution) | **POST** /mining/solution | Submit solution for current candidate


<a name="miningreadminerrewardaddress"></a>
# **MiningReadMinerRewardAddress**
> InlineResponse2005 MiningReadMinerRewardAddress ()

Read miner reward address

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class MiningReadMinerRewardAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new MiningApi(config);

            try
            {
                // Read miner reward address
                InlineResponse2005 result = apiInstance.MiningReadMinerRewardAddress();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiningApi.MiningReadMinerRewardAddress: " + e.Message );
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

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Miner Reward Script (in P2S format) |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="miningreadminerrewardpubkey"></a>
# **MiningReadMinerRewardPubkey**
> InlineResponse2006 MiningReadMinerRewardPubkey ()

Read public key associated with miner rewards

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class MiningReadMinerRewardPubkeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new MiningApi(config);

            try
            {
                // Read public key associated with miner rewards
                InlineResponse2006 result = apiInstance.MiningReadMinerRewardPubkey();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiningApi.MiningReadMinerRewardPubkey: " + e.Message );
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

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Public key for miner rewards (as hex-encoded secp256k1 point) |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="miningrequestblockcandidate"></a>
# **MiningRequestBlockCandidate**
> WorkMessage MiningRequestBlockCandidate ()

Request block candidate

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class MiningRequestBlockCandidateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new MiningApi(config);

            try
            {
                // Request block candidate
                WorkMessage result = apiInstance.MiningRequestBlockCandidate();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiningApi.MiningRequestBlockCandidate: " + e.Message );
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

[**WorkMessage**](WorkMessage.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | External candidate |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="miningrequestblockcandidatewithmandatorytransactions"></a>
# **MiningRequestBlockCandidateWithMandatoryTransactions**
> WorkMessage MiningRequestBlockCandidateWithMandatoryTransactions (List<ErgoTransaction> ergoTransaction)

Request block candidate

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class MiningRequestBlockCandidateWithMandatoryTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new MiningApi(config);
            var ergoTransaction = new List<ErgoTransaction>(); // List<ErgoTransaction> | 

            try
            {
                // Request block candidate
                WorkMessage result = apiInstance.MiningRequestBlockCandidateWithMandatoryTransactions(ergoTransaction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiningApi.MiningRequestBlockCandidateWithMandatoryTransactions: " + e.Message );
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
 **ergoTransaction** | [**List&lt;ErgoTransaction&gt;**](ErgoTransaction.md)|  | 

### Return type

[**WorkMessage**](WorkMessage.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | External candidate |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="miningsubmitsolution"></a>
# **MiningSubmitSolution**
> void MiningSubmitSolution (PowSolutions powSolutions)

Submit solution for current candidate

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class MiningSubmitSolutionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new MiningApi(config);
            var powSolutions = new PowSolutions(); // PowSolutions | 

            try
            {
                // Submit solution for current candidate
                apiInstance.MiningSubmitSolution(powSolutions);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiningApi.MiningSubmitSolution: " + e.Message );
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
 **powSolutions** | [**PowSolutions**](PowSolutions.md)|  | 

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
| **200** | Solution is valid |  -  |
| **400** | Solution is invalid |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

