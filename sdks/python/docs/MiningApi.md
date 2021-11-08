# ergo_node.MiningApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**mining_read_miner_reward_address**](MiningApi.md#mining_read_miner_reward_address) | **GET** /mining/rewardAddress | Read miner reward address
[**mining_read_miner_reward_pubkey**](MiningApi.md#mining_read_miner_reward_pubkey) | **GET** /mining/rewardPublicKey | Read public key associated with miner rewards
[**mining_request_block_candidate**](MiningApi.md#mining_request_block_candidate) | **GET** /mining/candidate | Request block candidate
[**mining_request_block_candidate_with_mandatory_transactions**](MiningApi.md#mining_request_block_candidate_with_mandatory_transactions) | **POST** /mining/candidateWithTxs | Request block candidate
[**mining_submit_solution**](MiningApi.md#mining_submit_solution) | **POST** /mining/solution | Submit solution for current candidate


# **mining_read_miner_reward_address**
> InlineResponse2005 mining_read_miner_reward_address()

Read miner reward address

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import mining_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.inline_response2005 import InlineResponse2005
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure API key authorization: ApiKeyAuth
configuration.api_key['ApiKeyAuth'] = 'YOUR_API_KEY'

# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['ApiKeyAuth'] = 'Bearer'

# Enter a context with an instance of the API client
with ergo_node.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = mining_api.MiningApi(api_client)

    # example, this endpoint has no required or optional parameters
    try:
        # Read miner reward address
        api_response = api_instance.mining_read_miner_reward_address()
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling MiningApi->mining_read_miner_reward_address: %s\n" % e)
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
**200** | Miner Reward Script (in P2S format) |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mining_read_miner_reward_pubkey**
> InlineResponse2006 mining_read_miner_reward_pubkey()

Read public key associated with miner rewards

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import mining_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.inline_response2006 import InlineResponse2006
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure API key authorization: ApiKeyAuth
configuration.api_key['ApiKeyAuth'] = 'YOUR_API_KEY'

# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['ApiKeyAuth'] = 'Bearer'

# Enter a context with an instance of the API client
with ergo_node.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = mining_api.MiningApi(api_client)

    # example, this endpoint has no required or optional parameters
    try:
        # Read public key associated with miner rewards
        api_response = api_instance.mining_read_miner_reward_pubkey()
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling MiningApi->mining_read_miner_reward_pubkey: %s\n" % e)
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
**200** | Public key for miner rewards (as hex-encoded secp256k1 point) |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mining_request_block_candidate**
> WorkMessage mining_request_block_candidate()

Request block candidate

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import mining_api
from ergo_node.model.work_message import WorkMessage
from ergo_node.model.api_error import ApiError
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure API key authorization: ApiKeyAuth
configuration.api_key['ApiKeyAuth'] = 'YOUR_API_KEY'

# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['ApiKeyAuth'] = 'Bearer'

# Enter a context with an instance of the API client
with ergo_node.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = mining_api.MiningApi(api_client)

    # example, this endpoint has no required or optional parameters
    try:
        # Request block candidate
        api_response = api_instance.mining_request_block_candidate()
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling MiningApi->mining_request_block_candidate: %s\n" % e)
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
**200** | External candidate |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mining_request_block_candidate_with_mandatory_transactions**
> WorkMessage mining_request_block_candidate_with_mandatory_transactions(transactions)

Request block candidate

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import mining_api
from ergo_node.model.work_message import WorkMessage
from ergo_node.model.transactions import Transactions
from ergo_node.model.api_error import ApiError
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure API key authorization: ApiKeyAuth
configuration.api_key['ApiKeyAuth'] = 'YOUR_API_KEY'

# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['ApiKeyAuth'] = 'Bearer'

# Enter a context with an instance of the API client
with ergo_node.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = mining_api.MiningApi(api_client)
    transactions = Transactions([
        ErgoTransaction(
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
        ),
    ]) # Transactions | 

    # example passing only required values which don't have defaults set
    try:
        # Request block candidate
        api_response = api_instance.mining_request_block_candidate_with_mandatory_transactions(transactions)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling MiningApi->mining_request_block_candidate_with_mandatory_transactions: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactions** | [**Transactions**](Transactions.md)|  |

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
**200** | External candidate |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mining_submit_solution**
> mining_submit_solution(pow_solutions)

Submit solution for current candidate

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import mining_api
from ergo_node.model.pow_solutions import PowSolutions
from ergo_node.model.api_error import ApiError
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)

# The client must configure the authentication and authorization parameters
# in accordance with the API server security policy.
# Examples for each auth method are provided below, use the example that
# satisfies your auth use case.

# Configure API key authorization: ApiKeyAuth
configuration.api_key['ApiKeyAuth'] = 'YOUR_API_KEY'

# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['ApiKeyAuth'] = 'Bearer'

# Enter a context with an instance of the API client
with ergo_node.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    api_instance = mining_api.MiningApi(api_client)
    pow_solutions = PowSolutions(
        pk="0350e25cee8562697d55275c96bb01b34228f9bd68fd9933f2a25ff195526864f5",
        w="0366ea253123dfdb8d6d9ca2cb9ea98629e8f34015b1e4ba942b1d88badfcc6a12",
        n="0000000000000000",
        d=987654321,
    ) # PowSolutions | 

    # example passing only required values which don't have defaults set
    try:
        # Submit solution for current candidate
        api_instance.mining_submit_solution(pow_solutions)
    except ergo_node.ApiException as e:
        print("Exception when calling MiningApi->mining_submit_solution: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pow_solutions** | [**PowSolutions**](PowSolutions.md)|  |

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
**200** | Solution is valid |  -  |
**400** | Solution is invalid |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

