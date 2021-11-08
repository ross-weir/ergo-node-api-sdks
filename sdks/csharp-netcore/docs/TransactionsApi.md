# ErgoNode.Api.TransactionsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CheckTransaction**](TransactionsApi.md#checktransaction) | **POST** /transactions/check | Checks an Ergo transaction without sending it over the network. Checks that transaction is valid and its inputs are in the UTXO set. Returns transaction identifier if the transaction is passing the checks.
[**GetExpectedWaitTime**](TransactionsApi.md#getexpectedwaittime) | **GET** /transactions/waitTime | Get expected wait time for the transaction with specified fee and size
[**GetFeeHistogram**](TransactionsApi.md#getfeehistogram) | **GET** /transactions/poolHistogram | Get histogram (waittime, (n_trans, sum(fee)) for transactions in mempool. It contains \&quot;bins\&quot;+1 bins, where i-th elements corresponds to transaction with wait time [i*maxtime/bins, (i+1)*maxtime/bins), and last bin corresponds to the transactions with wait time &gt;&#x3D; maxtime.
[**GetRecommendedFee**](TransactionsApi.md#getrecommendedfee) | **GET** /transactions/getFee | Get recommended fee (in nanoErgs) for a transaction with specified size (in bytes) to be proceeded in specified time (in minutes)
[**GetUnconfirmedTransactions**](TransactionsApi.md#getunconfirmedtransactions) | **GET** /transactions/unconfirmed | Get current pool of the unconfirmed transactions pool
[**SendTransaction**](TransactionsApi.md#sendtransaction) | **POST** /transactions | Submit an Ergo transaction to unconfirmed pool to send it over the network


<a name="checktransaction"></a>
# **CheckTransaction**
> string CheckTransaction (ErgoTransaction ergoTransaction)

Checks an Ergo transaction without sending it over the network. Checks that transaction is valid and its inputs are in the UTXO set. Returns transaction identifier if the transaction is passing the checks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class CheckTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TransactionsApi(config);
            var ergoTransaction = new ErgoTransaction(); // ErgoTransaction | 

            try
            {
                // Checks an Ergo transaction without sending it over the network. Checks that transaction is valid and its inputs are in the UTXO set. Returns transaction identifier if the transaction is passing the checks.
                string result = apiInstance.CheckTransaction(ergoTransaction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.CheckTransaction: " + e.Message );
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
 **ergoTransaction** | [**ErgoTransaction**](ErgoTransaction.md)|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | JSON with ID of the new transaction |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexpectedwaittime"></a>
# **GetExpectedWaitTime**
> int GetExpectedWaitTime (int fee, int txSize)

Get expected wait time for the transaction with specified fee and size

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetExpectedWaitTimeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TransactionsApi(config);
            var fee = 56;  // int | Transaction fee (in nanoErgs) (default to 1)
            var txSize = 56;  // int | Transaction size (default to 100)

            try
            {
                // Get expected wait time for the transaction with specified fee and size
                int result = apiInstance.GetExpectedWaitTime(fee, txSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetExpectedWaitTime: " + e.Message );
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
 **fee** | **int**| Transaction fee (in nanoErgs) | [default to 1]
 **txSize** | **int**| Transaction size | [default to 100]

### Return type

**int**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Expected wait time in milliseconds |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeehistogram"></a>
# **GetFeeHistogram**
> List&lt;FeeHistogramBin&gt; GetFeeHistogram (int? bins = null, long? maxtime = null)

Get histogram (waittime, (n_trans, sum(fee)) for transactions in mempool. It contains \"bins\"+1 bins, where i-th elements corresponds to transaction with wait time [i*maxtime/bins, (i+1)*maxtime/bins), and last bin corresponds to the transactions with wait time >= maxtime.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetFeeHistogramExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TransactionsApi(config);
            var bins = 56;  // int? | The number of bins in histogram (optional)  (default to 10)
            var maxtime = 789;  // long? | Maximal wait time in milliseconds (optional)  (default to 60000)

            try
            {
                // Get histogram (waittime, (n_trans, sum(fee)) for transactions in mempool. It contains \"bins\"+1 bins, where i-th elements corresponds to transaction with wait time [i*maxtime/bins, (i+1)*maxtime/bins), and last bin corresponds to the transactions with wait time >= maxtime.
                List<FeeHistogramBin> result = apiInstance.GetFeeHistogram(bins, maxtime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetFeeHistogram: " + e.Message );
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
 **bins** | **int?**| The number of bins in histogram | [optional] [default to 10]
 **maxtime** | **long?**| Maximal wait time in milliseconds | [optional] [default to 60000]

### Return type

[**List&lt;FeeHistogramBin&gt;**](FeeHistogramBin.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Array with fee histogram |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecommendedfee"></a>
# **GetRecommendedFee**
> int GetRecommendedFee (int waitTime, int txSize)

Get recommended fee (in nanoErgs) for a transaction with specified size (in bytes) to be proceeded in specified time (in minutes)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetRecommendedFeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TransactionsApi(config);
            var waitTime = 56;  // int | Maximum transaction wait time in minutes (default to 1)
            var txSize = 56;  // int | Transaction size (default to 100)

            try
            {
                // Get recommended fee (in nanoErgs) for a transaction with specified size (in bytes) to be proceeded in specified time (in minutes)
                int result = apiInstance.GetRecommendedFee(waitTime, txSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetRecommendedFee: " + e.Message );
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
 **waitTime** | **int**| Maximum transaction wait time in minutes | [default to 1]
 **txSize** | **int**| Transaction size | [default to 100]

### Return type

**int**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Recommended fee for the transaction (in nanoErgs) |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getunconfirmedtransactions"></a>
# **GetUnconfirmedTransactions**
> List&lt;ErgoTransaction&gt; GetUnconfirmedTransactions (int? limit = null, int? offset = null)

Get current pool of the unconfirmed transactions pool

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetUnconfirmedTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TransactionsApi(config);
            var limit = 56;  // int? | The number of items in list to return (optional)  (default to 50)
            var offset = 56;  // int? | The number of items in list to skip (optional)  (default to 0)

            try
            {
                // Get current pool of the unconfirmed transactions pool
                List<ErgoTransaction> result = apiInstance.GetUnconfirmedTransactions(limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetUnconfirmedTransactions: " + e.Message );
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

[**List&lt;ErgoTransaction&gt;**](ErgoTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Array with Ergo transactions |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendtransaction"></a>
# **SendTransaction**
> string SendTransaction (ErgoTransaction ergoTransaction)

Submit an Ergo transaction to unconfirmed pool to send it over the network

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class SendTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TransactionsApi(config);
            var ergoTransaction = new ErgoTransaction(); // ErgoTransaction | 

            try
            {
                // Submit an Ergo transaction to unconfirmed pool to send it over the network
                string result = apiInstance.SendTransaction(ergoTransaction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.SendTransaction: " + e.Message );
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
 **ergoTransaction** | [**ErgoTransaction**](ErgoTransaction.md)|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | JSON with ID of the new transaction |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

