# ErgoNode.Api.WalletApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddBox**](WalletApi.md#addbox) | **POST** /scan/addBox | Adds a box to scans, writes box to database if it is not there. You can use scan number 10 to add a box to the wallet.
[**CheckSeed**](WalletApi.md#checkseed) | **POST** /wallet/check | Check whether mnemonic phrase is corresponding to the wallet seed
[**ExtractHints**](WalletApi.md#extracthints) | **POST** /wallet/extractHints | Extract hints from a transaction
[**GenerateCommitments**](WalletApi.md#generatecommitments) | **POST** /wallet/generateCommitments | Generate signature commitments for inputs of an unsigned transaction
[**GetWalletStatus**](WalletApi.md#getwalletstatus) | **GET** /wallet/status | Get wallet status
[**WalletAddresses**](WalletApi.md#walletaddresses) | **GET** /wallet/addresses | Get wallet addresses
[**WalletBalances**](WalletApi.md#walletbalances) | **GET** /wallet/balances | Get total amount of confirmed Ergo tokens and assets
[**WalletBalancesUnconfirmed**](WalletApi.md#walletbalancesunconfirmed) | **GET** /wallet/balances/withUnconfirmed | Get summary amount of confirmed plus unconfirmed Ergo tokens and assets
[**WalletBoxes**](WalletApi.md#walletboxes) | **GET** /wallet/boxes | Get a list of all wallet-related boxes, both spent and unspent. Set minConfirmations to -1 to get mempool boxes included.
[**WalletBoxesCollect**](WalletApi.md#walletboxescollect) | **GET** /wallet/boxes/collect | Get a list of collected boxes.
[**WalletDeriveKey**](WalletApi.md#walletderivekey) | **POST** /wallet/deriveKey | Derive new key according to a provided path
[**WalletDeriveNextKey**](WalletApi.md#walletderivenextkey) | **GET** /wallet/deriveNextKey | Derive next key
[**WalletGetTransaction**](WalletApi.md#walletgettransaction) | **GET** /wallet/transactionById | Get wallet-related transaction by id
[**WalletInit**](WalletApi.md#walletinit) | **POST** /wallet/init | Initialize new wallet with randomly generated seed
[**WalletLock**](WalletApi.md#walletlock) | **GET** /wallet/lock | Lock wallet
[**WalletPaymentTransactionGenerateAndSend**](WalletApi.md#walletpaymenttransactiongenerateandsend) | **POST** /wallet/payment/send | Generate and send payment transaction (default fee of 0.001 Erg is used)
[**WalletRescan**](WalletApi.md#walletrescan) | **GET** /wallet/rescan | Rescan wallet (all the available full blocks)
[**WalletRestore**](WalletApi.md#walletrestore) | **POST** /wallet/restore | Create new wallet from existing mnemonic seed
[**WalletTransactionGenerate**](WalletApi.md#wallettransactiongenerate) | **POST** /wallet/transaction/generate | Generate arbitrary transaction from array of requests.
[**WalletTransactionGenerateAndSend**](WalletApi.md#wallettransactiongenerateandsend) | **POST** /wallet/transaction/send | Generate and send arbitrary transaction
[**WalletTransactionSign**](WalletApi.md#wallettransactionsign) | **POST** /wallet/transaction/sign | Sign arbitrary unsigned transaction with wallet secrets and also secrets provided.
[**WalletTransactions**](WalletApi.md#wallettransactions) | **GET** /wallet/transactions | Get a list of all wallet-related transactions
[**WalletTransactionsByScanId**](WalletApi.md#wallettransactionsbyscanid) | **GET** /wallet/transactionsByScanId/{scanId} | Get scan-related transactions by scan id
[**WalletUnlock**](WalletApi.md#walletunlock) | **POST** /wallet/unlock | Unlock wallet
[**WalletUnsignedTransactionGenerate**](WalletApi.md#walletunsignedtransactiongenerate) | **POST** /wallet/transaction/generateUnsigned | Generate unsigned transaction from array of requests.
[**WalletUnspentBoxes**](WalletApi.md#walletunspentboxes) | **GET** /wallet/boxes/unspent | Get a list of unspent boxes. Set minConfirmations to -1 to have mempool boxes considered.
[**WalletUpdateChangeAddress**](WalletApi.md#walletupdatechangeaddress) | **POST** /wallet/updateChangeAddress | Update address to be used to send change to


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

            var apiInstance = new WalletApi(config);
            var scanIdsBox = new ScanIdsBox(); // ScanIdsBox | 

            try
            {
                // Adds a box to scans, writes box to database if it is not there. You can use scan number 10 to add a box to the wallet.
                string result = apiInstance.AddBox(scanIdsBox);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.AddBox: " + e.Message );
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

<a name="checkseed"></a>
# **CheckSeed**
> InlineResponse2001 CheckSeed (InlineObject2 inlineObject2)

Check whether mnemonic phrase is corresponding to the wallet seed

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class CheckSeedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);
            var inlineObject2 = new InlineObject2(); // InlineObject2 | 

            try
            {
                // Check whether mnemonic phrase is corresponding to the wallet seed
                InlineResponse2001 result = apiInstance.CheckSeed(inlineObject2);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.CheckSeed: " + e.Message );
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
 **inlineObject2** | [**InlineObject2**](InlineObject2.md)|  | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Whether passphrase match wallet |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="extracthints"></a>
# **ExtractHints**
> TransactionHintsBag ExtractHints (HintExtractionRequest hintExtractionRequest)

Extract hints from a transaction

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class ExtractHintsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);
            var hintExtractionRequest = new HintExtractionRequest(); // HintExtractionRequest | 

            try
            {
                // Extract hints from a transaction
                TransactionHintsBag result = apiInstance.ExtractHints(hintExtractionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.ExtractHints: " + e.Message );
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
 **hintExtractionRequest** | [**HintExtractionRequest**](HintExtractionRequest.md)|  | 

### Return type

[**TransactionHintsBag**](TransactionHintsBag.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Hints for the transaction |  -  |
| **400** | Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatecommitments"></a>
# **GenerateCommitments**
> TransactionHintsBag GenerateCommitments (GenerateCommitmentsRequest generateCommitmentsRequest)

Generate signature commitments for inputs of an unsigned transaction

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GenerateCommitmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);
            var generateCommitmentsRequest = new GenerateCommitmentsRequest(); // GenerateCommitmentsRequest | 

            try
            {
                // Generate signature commitments for inputs of an unsigned transaction
                TransactionHintsBag result = apiInstance.GenerateCommitments(generateCommitmentsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.GenerateCommitments: " + e.Message );
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
 **generateCommitmentsRequest** | [**GenerateCommitmentsRequest**](GenerateCommitmentsRequest.md)|  | 

### Return type

[**TransactionHintsBag**](TransactionHintsBag.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Transaction-related hints |  -  |
| **400** | Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwalletstatus"></a>
# **GetWalletStatus**
> InlineResponse2002 GetWalletStatus ()

Get wallet status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetWalletStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);

            try
            {
                // Get wallet status
                InlineResponse2002 result = apiInstance.GetWalletStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.GetWalletStatus: " + e.Message );
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

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Wallet status |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="walletaddresses"></a>
# **WalletAddresses**
> List&lt;string&gt; WalletAddresses ()

Get wallet addresses

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class WalletAddressesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);

            try
            {
                // Get wallet addresses
                List<string> result = apiInstance.WalletAddresses();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletAddresses: " + e.Message );
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

**List<string>**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | String with encoded wallet addresses |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="walletbalances"></a>
# **WalletBalances**
> BalancesSnapshot WalletBalances ()

Get total amount of confirmed Ergo tokens and assets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class WalletBalancesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);

            try
            {
                // Get total amount of confirmed Ergo tokens and assets
                BalancesSnapshot result = apiInstance.WalletBalances();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletBalances: " + e.Message );
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

[**BalancesSnapshot**](BalancesSnapshot.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get total amount of confirmed Ergo tokens and assets |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="walletbalancesunconfirmed"></a>
# **WalletBalancesUnconfirmed**
> BalancesSnapshot WalletBalancesUnconfirmed ()

Get summary amount of confirmed plus unconfirmed Ergo tokens and assets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class WalletBalancesUnconfirmedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);

            try
            {
                // Get summary amount of confirmed plus unconfirmed Ergo tokens and assets
                BalancesSnapshot result = apiInstance.WalletBalancesUnconfirmed();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletBalancesUnconfirmed: " + e.Message );
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

[**BalancesSnapshot**](BalancesSnapshot.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get summary amount of confirmed plus unconfirmed Ergo tokens and assets |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="walletboxes"></a>
# **WalletBoxes**
> List&lt;WalletBox&gt; WalletBoxes (int? minConfirmations = null, int? minInclusionHeight = null)

Get a list of all wallet-related boxes, both spent and unspent. Set minConfirmations to -1 to get mempool boxes included.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class WalletBoxesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);
            var minConfirmations = 56;  // int? | Minimal number of confirmations (optional)  (default to 0)
            var minInclusionHeight = 56;  // int? | Minimal box inclusion height (optional)  (default to 0)

            try
            {
                // Get a list of all wallet-related boxes, both spent and unspent. Set minConfirmations to -1 to get mempool boxes included.
                List<WalletBox> result = apiInstance.WalletBoxes(minConfirmations, minInclusionHeight);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletBoxes: " + e.Message );
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
| **200** | A list of all wallet-related boxes |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="walletboxescollect"></a>
# **WalletBoxesCollect**
> List&lt;WalletBox&gt; WalletBoxesCollect (BoxesRequestHolder boxesRequestHolder)

Get a list of collected boxes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class WalletBoxesCollectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);
            var boxesRequestHolder = new BoxesRequestHolder(); // BoxesRequestHolder | This API method recieves balance and assets, according to which, it's collecting result

            try
            {
                // Get a list of collected boxes.
                List<WalletBox> result = apiInstance.WalletBoxesCollect(boxesRequestHolder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletBoxesCollect: " + e.Message );
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
 **boxesRequestHolder** | [**BoxesRequestHolder**](BoxesRequestHolder.md)| This API method recieves balance and assets, according to which, it&#39;s collecting result | 

### Return type

[**List&lt;WalletBox&gt;**](WalletBox.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of all collected boxes |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="walletderivekey"></a>
# **WalletDeriveKey**
> InlineResponse2003 WalletDeriveKey (InlineObject5 inlineObject5)

Derive new key according to a provided path

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class WalletDeriveKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);
            var inlineObject5 = new InlineObject5(); // InlineObject5 | 

            try
            {
                // Derive new key according to a provided path
                InlineResponse2003 result = apiInstance.WalletDeriveKey(inlineObject5);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletDeriveKey: " + e.Message );
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
 **inlineObject5** | [**InlineObject5**](InlineObject5.md)|  | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Resulted address |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="walletderivenextkey"></a>
# **WalletDeriveNextKey**
> InlineResponse2004 WalletDeriveNextKey ()

Derive next key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class WalletDeriveNextKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);

            try
            {
                // Derive next key
                InlineResponse2004 result = apiInstance.WalletDeriveNextKey();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletDeriveNextKey: " + e.Message );
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

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Resulted secret path and address |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="walletgettransaction"></a>
# **WalletGetTransaction**
> List&lt;WalletTransaction&gt; WalletGetTransaction (string id)

Get wallet-related transaction by id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class WalletGetTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);
            var id = id_example;  // string | Transaction id

            try
            {
                // Get wallet-related transaction by id
                List<WalletTransaction> result = apiInstance.WalletGetTransaction(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletGetTransaction: " + e.Message );
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
 **id** | **string**| Transaction id | 

### Return type

[**List&lt;WalletTransaction&gt;**](WalletTransaction.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Wallet-related transaction |  -  |
| **404** | Transaction with specified id not found in wallet |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="walletinit"></a>
# **WalletInit**
> InlineResponse200 WalletInit (InlineObject inlineObject)

Initialize new wallet with randomly generated seed

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class WalletInitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);
            var inlineObject = new InlineObject(); // InlineObject | 

            try
            {
                // Initialize new wallet with randomly generated seed
                InlineResponse200 result = apiInstance.WalletInit(inlineObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletInit: " + e.Message );
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
 **inlineObject** | [**InlineObject**](InlineObject.md)|  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | New wallet with randomly generated seed created successfully |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="walletlock"></a>
# **WalletLock**
> void WalletLock ()

Lock wallet

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class WalletLockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);

            try
            {
                // Lock wallet
                apiInstance.WalletLock();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletLock: " + e.Message );
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

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Wallet locked successfully |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="walletpaymenttransactiongenerateandsend"></a>
# **WalletPaymentTransactionGenerateAndSend**
> string WalletPaymentTransactionGenerateAndSend (List<PaymentRequest> paymentRequest)

Generate and send payment transaction (default fee of 0.001 Erg is used)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class WalletPaymentTransactionGenerateAndSendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);
            var paymentRequest = new List<PaymentRequest>(); // List<PaymentRequest> | 

            try
            {
                // Generate and send payment transaction (default fee of 0.001 Erg is used)
                string result = apiInstance.WalletPaymentTransactionGenerateAndSend(paymentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletPaymentTransactionGenerateAndSend: " + e.Message );
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
 **paymentRequest** | [**List&lt;PaymentRequest&gt;**](PaymentRequest.md)|  | 

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
| **200** | Identifier of an Ergo transaction generated |  -  |
| **400** | Bad payment request |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="walletrescan"></a>
# **WalletRescan**
> void WalletRescan ()

Rescan wallet (all the available full blocks)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class WalletRescanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);

            try
            {
                // Rescan wallet (all the available full blocks)
                apiInstance.WalletRescan();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletRescan: " + e.Message );
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

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Wallet storage recreated |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="walletrestore"></a>
# **WalletRestore**
> void WalletRestore (InlineObject1 inlineObject1)

Create new wallet from existing mnemonic seed

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class WalletRestoreExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);
            var inlineObject1 = new InlineObject1(); // InlineObject1 | 

            try
            {
                // Create new wallet from existing mnemonic seed
                apiInstance.WalletRestore(inlineObject1);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletRestore: " + e.Message );
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
 **inlineObject1** | [**InlineObject1**](InlineObject1.md)|  | 

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
| **200** | Wallet restored successfully |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wallettransactiongenerate"></a>
# **WalletTransactionGenerate**
> ErgoTransaction WalletTransactionGenerate (RequestsHolder requestsHolder)

Generate arbitrary transaction from array of requests.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class WalletTransactionGenerateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);
            var requestsHolder = new RequestsHolder(); // RequestsHolder | This API method receives a sequence of requests as an input. Each request will produce an output of the resulting transaction (with fee output created automatically). Currently supported types of requests are payment and asset issuance requests. An example for a transaction with requests of both kinds is provided below. Please note that for the payment request \"assets\" and \"registers\" fields are not needed. For asset issuance request, \"registers\" field is not needed. You may specify boxes to spend by providing them in \"inputsRaw\". Please note you need to have strict equality between input and output total amounts of Ergs in this case. If you want wallet to pick up the boxes, leave \"inputsRaw\" empty.

            try
            {
                // Generate arbitrary transaction from array of requests.
                ErgoTransaction result = apiInstance.WalletTransactionGenerate(requestsHolder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletTransactionGenerate: " + e.Message );
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
 **requestsHolder** | [**RequestsHolder**](RequestsHolder.md)| This API method receives a sequence of requests as an input. Each request will produce an output of the resulting transaction (with fee output created automatically). Currently supported types of requests are payment and asset issuance requests. An example for a transaction with requests of both kinds is provided below. Please note that for the payment request \&quot;assets\&quot; and \&quot;registers\&quot; fields are not needed. For asset issuance request, \&quot;registers\&quot; field is not needed. You may specify boxes to spend by providing them in \&quot;inputsRaw\&quot;. Please note you need to have strict equality between input and output total amounts of Ergs in this case. If you want wallet to pick up the boxes, leave \&quot;inputsRaw\&quot; empty. | 

### Return type

[**ErgoTransaction**](ErgoTransaction.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Generated Ergo transaction |  -  |
| **400** | Bad transaction request |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wallettransactiongenerateandsend"></a>
# **WalletTransactionGenerateAndSend**
> string WalletTransactionGenerateAndSend (RequestsHolder requestsHolder)

Generate and send arbitrary transaction

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class WalletTransactionGenerateAndSendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);
            var requestsHolder = new RequestsHolder(); // RequestsHolder | See description of /wallet/transaction/generate

            try
            {
                // Generate and send arbitrary transaction
                string result = apiInstance.WalletTransactionGenerateAndSend(requestsHolder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletTransactionGenerateAndSend: " + e.Message );
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
 **requestsHolder** | [**RequestsHolder**](RequestsHolder.md)| See description of /wallet/transaction/generate | 

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
| **200** | Identifier of an Ergo transaction generated |  -  |
| **400** | Bad transaction request |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wallettransactionsign"></a>
# **WalletTransactionSign**
> ErgoTransaction WalletTransactionSign (TransactionSigningRequest transactionSigningRequest)

Sign arbitrary unsigned transaction with wallet secrets and also secrets provided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class WalletTransactionSignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);
            var transactionSigningRequest = new TransactionSigningRequest(); // TransactionSigningRequest | With this API method an arbitrary unsigned transaction can be signed with secrets provided or stored in the wallet. Both DLOG and Diffie-Hellman tuple secrets are supported. Please note that the unsigned transaction contains only identifiers of inputs and data inputs. If the node holds UTXO set, it is able to extract boxes needed. Otherwise, input (and data-input) boxes can be provided in \"inputsRaw\" and \"dataInputsRaw\" fields.

            try
            {
                // Sign arbitrary unsigned transaction with wallet secrets and also secrets provided.
                ErgoTransaction result = apiInstance.WalletTransactionSign(transactionSigningRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletTransactionSign: " + e.Message );
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
 **transactionSigningRequest** | [**TransactionSigningRequest**](TransactionSigningRequest.md)| With this API method an arbitrary unsigned transaction can be signed with secrets provided or stored in the wallet. Both DLOG and Diffie-Hellman tuple secrets are supported. Please note that the unsigned transaction contains only identifiers of inputs and data inputs. If the node holds UTXO set, it is able to extract boxes needed. Otherwise, input (and data-input) boxes can be provided in \&quot;inputsRaw\&quot; and \&quot;dataInputsRaw\&quot; fields. | 

### Return type

[**ErgoTransaction**](ErgoTransaction.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Generated Ergo transaction |  -  |
| **400** | Bad transaction request |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wallettransactions"></a>
# **WalletTransactions**
> List&lt;WalletTransaction&gt; WalletTransactions (int? minInclusionHeight = null, int? maxInclusionHeight = null, int? minConfirmations = null, int? maxConfirmations = null)

Get a list of all wallet-related transactions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class WalletTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);
            var minInclusionHeight = 56;  // int? | Minimal tx inclusion height (optional) 
            var maxInclusionHeight = 56;  // int? | Maximal tx inclusion height (optional) 
            var minConfirmations = 56;  // int? | Minimal confirmations number (optional) 
            var maxConfirmations = 56;  // int? | Maximal confirmations number (optional) 

            try
            {
                // Get a list of all wallet-related transactions
                List<WalletTransaction> result = apiInstance.WalletTransactions(minInclusionHeight, maxInclusionHeight, minConfirmations, maxConfirmations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletTransactions: " + e.Message );
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
 **minInclusionHeight** | **int?**| Minimal tx inclusion height | [optional] 
 **maxInclusionHeight** | **int?**| Maximal tx inclusion height | [optional] 
 **minConfirmations** | **int?**| Minimal confirmations number | [optional] 
 **maxConfirmations** | **int?**| Maximal confirmations number | [optional] 

### Return type

[**List&lt;WalletTransaction&gt;**](WalletTransaction.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of all wallet-related transactions |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wallettransactionsbyscanid"></a>
# **WalletTransactionsByScanId**
> List&lt;WalletTransaction&gt; WalletTransactionsByScanId (int scanId, int? minInclusionHeight = null, int? maxInclusionHeight = null, int? minConfirmations = null, int? maxConfirmations = null)

Get scan-related transactions by scan id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class WalletTransactionsByScanIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);
            var scanId = 56;  // int | identifier of a scan
            var minInclusionHeight = 56;  // int? | Minimal tx inclusion height (optional) 
            var maxInclusionHeight = 56;  // int? | Maximal tx inclusion height (optional) 
            var minConfirmations = 56;  // int? | Minimal confirmations number (optional) 
            var maxConfirmations = 56;  // int? | Maximal confirmations number (optional) 

            try
            {
                // Get scan-related transactions by scan id
                List<WalletTransaction> result = apiInstance.WalletTransactionsByScanId(scanId, minInclusionHeight, maxInclusionHeight, minConfirmations, maxConfirmations);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletTransactionsByScanId: " + e.Message );
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
 **minInclusionHeight** | **int?**| Minimal tx inclusion height | [optional] 
 **maxInclusionHeight** | **int?**| Maximal tx inclusion height | [optional] 
 **minConfirmations** | **int?**| Minimal confirmations number | [optional] 
 **maxConfirmations** | **int?**| Maximal confirmations number | [optional] 

### Return type

[**List&lt;WalletTransaction&gt;**](WalletTransaction.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Scan-related transactions |  -  |
| **404** | Transactions with related scan id not found in wallet |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="walletunlock"></a>
# **WalletUnlock**
> void WalletUnlock (InlineObject3 inlineObject3)

Unlock wallet

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class WalletUnlockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);
            var inlineObject3 = new InlineObject3(); // InlineObject3 | 

            try
            {
                // Unlock wallet
                apiInstance.WalletUnlock(inlineObject3);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletUnlock: " + e.Message );
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
 **inlineObject3** | [**InlineObject3**](InlineObject3.md)|  | 

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
| **200** | Wallet unlocked successfully |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="walletunsignedtransactiongenerate"></a>
# **WalletUnsignedTransactionGenerate**
> UnsignedErgoTransaction WalletUnsignedTransactionGenerate (RequestsHolder requestsHolder)

Generate unsigned transaction from array of requests.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class WalletUnsignedTransactionGenerateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);
            var requestsHolder = new RequestsHolder(); // RequestsHolder | The same as /wallet/transaction/generate but generates unsigned transaction.

            try
            {
                // Generate unsigned transaction from array of requests.
                UnsignedErgoTransaction result = apiInstance.WalletUnsignedTransactionGenerate(requestsHolder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletUnsignedTransactionGenerate: " + e.Message );
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
 **requestsHolder** | [**RequestsHolder**](RequestsHolder.md)| The same as /wallet/transaction/generate but generates unsigned transaction. | 

### Return type

[**UnsignedErgoTransaction**](UnsignedErgoTransaction.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Generated unsigned Ergo transaction |  -  |
| **400** | Bad transaction request |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="walletunspentboxes"></a>
# **WalletUnspentBoxes**
> List&lt;WalletBox&gt; WalletUnspentBoxes (int? minConfirmations = null, int? minInclusionHeight = null)

Get a list of unspent boxes. Set minConfirmations to -1 to have mempool boxes considered.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class WalletUnspentBoxesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);
            var minConfirmations = 56;  // int? | Minimal number of confirmations (optional)  (default to 0)
            var minInclusionHeight = 56;  // int? | Minimal box inclusion height (optional)  (default to 0)

            try
            {
                // Get a list of unspent boxes. Set minConfirmations to -1 to have mempool boxes considered.
                List<WalletBox> result = apiInstance.WalletUnspentBoxes(minConfirmations, minInclusionHeight);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletUnspentBoxes: " + e.Message );
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
| **200** | A list of unspent boxes |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="walletupdatechangeaddress"></a>
# **WalletUpdateChangeAddress**
> void WalletUpdateChangeAddress (InlineObject4 inlineObject4)

Update address to be used to send change to

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class WalletUpdateChangeAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new WalletApi(config);
            var inlineObject4 = new InlineObject4(); // InlineObject4 | 

            try
            {
                // Update address to be used to send change to
                apiInstance.WalletUpdateChangeAddress(inlineObject4);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WalletApi.WalletUpdateChangeAddress: " + e.Message );
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
 **inlineObject4** | [**InlineObject4**](InlineObject4.md)|  | 

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
| **200** | Change address updated successfully |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

