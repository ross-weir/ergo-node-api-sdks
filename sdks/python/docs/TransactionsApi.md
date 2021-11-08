# ergo_node.TransactionsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**check_transaction**](TransactionsApi.md#check_transaction) | **POST** /transactions/check | Checks an Ergo transaction without sending it over the network. Checks that transaction is valid and its inputs are in the UTXO set. Returns transaction identifier if the transaction is passing the checks.
[**get_expected_wait_time**](TransactionsApi.md#get_expected_wait_time) | **GET** /transactions/waitTime | Get expected wait time for the transaction with specified fee and size
[**get_fee_histogram**](TransactionsApi.md#get_fee_histogram) | **GET** /transactions/poolHistogram | Get histogram (waittime, (n_trans, sum(fee)) for transactions in mempool. It contains \&quot;bins\&quot;+1 bins, where i-th elements corresponds to transaction with wait time [i*maxtime/bins, (i+1)*maxtime/bins), and last bin corresponds to the transactions with wait time &gt;&#x3D; maxtime.
[**get_recommended_fee**](TransactionsApi.md#get_recommended_fee) | **GET** /transactions/getFee | Get recommended fee (in nanoErgs) for a transaction with specified size (in bytes) to be proceeded in specified time (in minutes)
[**get_unconfirmed_transactions**](TransactionsApi.md#get_unconfirmed_transactions) | **GET** /transactions/unconfirmed | Get current pool of the unconfirmed transactions pool
[**send_transaction**](TransactionsApi.md#send_transaction) | **POST** /transactions | Submit an Ergo transaction to unconfirmed pool to send it over the network


# **check_transaction**
> str check_transaction(ergo_transaction)

Checks an Ergo transaction without sending it over the network. Checks that transaction is valid and its inputs are in the UTXO set. Returns transaction identifier if the transaction is passing the checks.

### Example


```python
import time
import ergo_node
from ergo_node.api import transactions_api
from ergo_node.model.ergo_transaction import ErgoTransaction
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
    api_instance = transactions_api.TransactionsApi(api_client)
    ergo_transaction = ErgoTransaction(
        id="2ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
        inputs=[
            ErgoTransactionInput(
                box_id="1ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
                spending_proof=SpendingProof(
                    proof_bytes="4ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd1173ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd1173ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
                    extension={
                        "key": "100204a00b08cd0336100ef59ced80ba5f89c4178ebd57b6c1dd0f3d135ee1db9f62fc634d637041ea02d192a39a8cc7a70173007301",
                    },
                ),
                extension={
                    "key": "100204a00b08cd0336100ef59ced80ba5f89c4178ebd57b6c1dd0f3d135ee1db9f62fc634d637041ea02d192a39a8cc7a70173007301",
                },
            ),
        ],
        data_inputs=[
            ErgoTransactionDataInput(
                box_id="1ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
                extension={
                    "key": "100204a00b08cd0336100ef59ced80ba5f89c4178ebd57b6c1dd0f3d135ee1db9f62fc634d637041ea02d192a39a8cc7a70173007301",
                },
            ),
        ],
        outputs=[
            ErgoTransactionOutput(
                box_id="1ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
                value=147,
                ergo_tree="0008cd0336100ef59ced80ba5f89c4178ebd57b6c1dd0f3d135ee1db9f62fc634d637041",
                creation_height=9149,
                assets=[
                    Asset(
                        token_id="4ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
                        amount=1000,
                    ),
                ],
                additional_registers=Registers(
                    key="100204a00b08cd0336100ef59ced80ba5f89c4178ebd57b6c1dd0f3d135ee1db9f62fc634d637041ea02d192a39a8cc7a70173007301",
                ),
                transaction_id="2ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
                index=1,
            ),
        ],
        size=1,
    ) # ErgoTransaction | 

    # example passing only required values which don't have defaults set
    try:
        # Checks an Ergo transaction without sending it over the network. Checks that transaction is valid and its inputs are in the UTXO set. Returns transaction identifier if the transaction is passing the checks.
        api_response = api_instance.check_transaction(ergo_transaction)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling TransactionsApi->check_transaction: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ergo_transaction** | [**ErgoTransaction**](ErgoTransaction.md)|  |

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | JSON with ID of the new transaction |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_expected_wait_time**
> int get_expected_wait_time()

Get expected wait time for the transaction with specified fee and size

### Example


```python
import time
import ergo_node
from ergo_node.api import transactions_api
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
    api_instance = transactions_api.TransactionsApi(api_client)

    # example passing only required values which don't have defaults set
    try:
        # Get expected wait time for the transaction with specified fee and size
        api_response = api_instance.get_expected_wait_time()
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling TransactionsApi->get_expected_wait_time: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fee** | **int**| Transaction fee (in nanoErgs) | defaults to 1
 **tx_size** | **int**| Transaction size | defaults to 100

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
**200** | Expected wait time in milliseconds |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_fee_histogram**
> FeeHistogram get_fee_histogram()

Get histogram (waittime, (n_trans, sum(fee)) for transactions in mempool. It contains \"bins\"+1 bins, where i-th elements corresponds to transaction with wait time [i*maxtime/bins, (i+1)*maxtime/bins), and last bin corresponds to the transactions with wait time >= maxtime.

### Example


```python
import time
import ergo_node
from ergo_node.api import transactions_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.fee_histogram import FeeHistogram
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)


# Enter a context with an instance of the API client
with ergo_node.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = transactions_api.TransactionsApi(api_client)
    bins = 10 # int | The number of bins in histogram (optional) if omitted the server will use the default value of 10
    maxtime = 60000 # int | Maximal wait time in milliseconds (optional) if omitted the server will use the default value of 60000

    # example passing only required values which don't have defaults set
    # and optional values
    try:
        # Get histogram (waittime, (n_trans, sum(fee)) for transactions in mempool. It contains \"bins\"+1 bins, where i-th elements corresponds to transaction with wait time [i*maxtime/bins, (i+1)*maxtime/bins), and last bin corresponds to the transactions with wait time >= maxtime.
        api_response = api_instance.get_fee_histogram(bins=bins, maxtime=maxtime)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling TransactionsApi->get_fee_histogram: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bins** | **int**| The number of bins in histogram | [optional] if omitted the server will use the default value of 10
 **maxtime** | **int**| Maximal wait time in milliseconds | [optional] if omitted the server will use the default value of 60000

### Return type

[**FeeHistogram**](FeeHistogram.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Array with fee histogram |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_recommended_fee**
> int get_recommended_fee()

Get recommended fee (in nanoErgs) for a transaction with specified size (in bytes) to be proceeded in specified time (in minutes)

### Example


```python
import time
import ergo_node
from ergo_node.api import transactions_api
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
    api_instance = transactions_api.TransactionsApi(api_client)

    # example passing only required values which don't have defaults set
    try:
        # Get recommended fee (in nanoErgs) for a transaction with specified size (in bytes) to be proceeded in specified time (in minutes)
        api_response = api_instance.get_recommended_fee()
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling TransactionsApi->get_recommended_fee: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **wait_time** | **int**| Maximum transaction wait time in minutes | defaults to 1
 **tx_size** | **int**| Transaction size | defaults to 100

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
**200** | Recommended fee for the transaction (in nanoErgs) |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_unconfirmed_transactions**
> Transactions get_unconfirmed_transactions()

Get current pool of the unconfirmed transactions pool

### Example


```python
import time
import ergo_node
from ergo_node.api import transactions_api
from ergo_node.model.transactions import Transactions
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
    api_instance = transactions_api.TransactionsApi(api_client)
    limit = 50 # int | The number of items in list to return (optional) if omitted the server will use the default value of 50
    offset = 0 # int | The number of items in list to skip (optional) if omitted the server will use the default value of 0

    # example passing only required values which don't have defaults set
    # and optional values
    try:
        # Get current pool of the unconfirmed transactions pool
        api_response = api_instance.get_unconfirmed_transactions(limit=limit, offset=offset)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling TransactionsApi->get_unconfirmed_transactions: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int**| The number of items in list to return | [optional] if omitted the server will use the default value of 50
 **offset** | **int**| The number of items in list to skip | [optional] if omitted the server will use the default value of 0

### Return type

[**Transactions**](Transactions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Array with Ergo transactions |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **send_transaction**
> str send_transaction(ergo_transaction)

Submit an Ergo transaction to unconfirmed pool to send it over the network

### Example


```python
import time
import ergo_node
from ergo_node.api import transactions_api
from ergo_node.model.ergo_transaction import ErgoTransaction
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
    api_instance = transactions_api.TransactionsApi(api_client)
    ergo_transaction = ErgoTransaction(
        id="2ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
        inputs=[
            ErgoTransactionInput(
                box_id="1ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
                spending_proof=SpendingProof(
                    proof_bytes="4ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd1173ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd1173ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
                    extension={
                        "key": "100204a00b08cd0336100ef59ced80ba5f89c4178ebd57b6c1dd0f3d135ee1db9f62fc634d637041ea02d192a39a8cc7a70173007301",
                    },
                ),
                extension={
                    "key": "100204a00b08cd0336100ef59ced80ba5f89c4178ebd57b6c1dd0f3d135ee1db9f62fc634d637041ea02d192a39a8cc7a70173007301",
                },
            ),
        ],
        data_inputs=[
            ErgoTransactionDataInput(
                box_id="1ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
                extension={
                    "key": "100204a00b08cd0336100ef59ced80ba5f89c4178ebd57b6c1dd0f3d135ee1db9f62fc634d637041ea02d192a39a8cc7a70173007301",
                },
            ),
        ],
        outputs=[
            ErgoTransactionOutput(
                box_id="1ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
                value=147,
                ergo_tree="0008cd0336100ef59ced80ba5f89c4178ebd57b6c1dd0f3d135ee1db9f62fc634d637041",
                creation_height=9149,
                assets=[
                    Asset(
                        token_id="4ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
                        amount=1000,
                    ),
                ],
                additional_registers=Registers(
                    key="100204a00b08cd0336100ef59ced80ba5f89c4178ebd57b6c1dd0f3d135ee1db9f62fc634d637041ea02d192a39a8cc7a70173007301",
                ),
                transaction_id="2ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
                index=1,
            ),
        ],
        size=1,
    ) # ErgoTransaction | 

    # example passing only required values which don't have defaults set
    try:
        # Submit an Ergo transaction to unconfirmed pool to send it over the network
        api_response = api_instance.send_transaction(ergo_transaction)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling TransactionsApi->send_transaction: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ergo_transaction** | [**ErgoTransaction**](ErgoTransaction.md)|  |

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | JSON with ID of the new transaction |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

