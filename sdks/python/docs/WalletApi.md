# ergo_node.WalletApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**add_box**](WalletApi.md#add_box) | **POST** /scan/addBox | Adds a box to scans, writes box to database if it is not there. You can use scan number 10 to add a box to the wallet.
[**check_seed**](WalletApi.md#check_seed) | **POST** /wallet/check | Check whether mnemonic phrase is corresponding to the wallet seed
[**extract_hints**](WalletApi.md#extract_hints) | **POST** /wallet/extractHints | Extract hints from a transaction
[**generate_commitments**](WalletApi.md#generate_commitments) | **POST** /wallet/generateCommitments | Generate signature commitments for inputs of an unsigned transaction
[**get_wallet_status**](WalletApi.md#get_wallet_status) | **GET** /wallet/status | Get wallet status
[**wallet_addresses**](WalletApi.md#wallet_addresses) | **GET** /wallet/addresses | Get wallet addresses
[**wallet_balances**](WalletApi.md#wallet_balances) | **GET** /wallet/balances | Get total amount of confirmed Ergo tokens and assets
[**wallet_balances_unconfirmed**](WalletApi.md#wallet_balances_unconfirmed) | **GET** /wallet/balances/withUnconfirmed | Get summary amount of confirmed plus unconfirmed Ergo tokens and assets
[**wallet_boxes**](WalletApi.md#wallet_boxes) | **GET** /wallet/boxes | Get a list of all wallet-related boxes, both spent and unspent. Set minConfirmations to -1 to get mempool boxes included.
[**wallet_boxes_collect**](WalletApi.md#wallet_boxes_collect) | **GET** /wallet/boxes/collect | Get a list of collected boxes.
[**wallet_derive_key**](WalletApi.md#wallet_derive_key) | **POST** /wallet/deriveKey | Derive new key according to a provided path
[**wallet_derive_next_key**](WalletApi.md#wallet_derive_next_key) | **GET** /wallet/deriveNextKey | Derive next key
[**wallet_get_transaction**](WalletApi.md#wallet_get_transaction) | **GET** /wallet/transactionById | Get wallet-related transaction by id
[**wallet_init**](WalletApi.md#wallet_init) | **POST** /wallet/init | Initialize new wallet with randomly generated seed
[**wallet_lock**](WalletApi.md#wallet_lock) | **GET** /wallet/lock | Lock wallet
[**wallet_payment_transaction_generate_and_send**](WalletApi.md#wallet_payment_transaction_generate_and_send) | **POST** /wallet/payment/send | Generate and send payment transaction (default fee of 0.001 Erg is used)
[**wallet_rescan**](WalletApi.md#wallet_rescan) | **GET** /wallet/rescan | Rescan wallet (all the available full blocks)
[**wallet_restore**](WalletApi.md#wallet_restore) | **POST** /wallet/restore | Create new wallet from existing mnemonic seed
[**wallet_transaction_generate**](WalletApi.md#wallet_transaction_generate) | **POST** /wallet/transaction/generate | Generate arbitrary transaction from array of requests.
[**wallet_transaction_generate_and_send**](WalletApi.md#wallet_transaction_generate_and_send) | **POST** /wallet/transaction/send | Generate and send arbitrary transaction
[**wallet_transaction_sign**](WalletApi.md#wallet_transaction_sign) | **POST** /wallet/transaction/sign | Sign arbitrary unsigned transaction with wallet secrets and also secrets provided.
[**wallet_transactions**](WalletApi.md#wallet_transactions) | **GET** /wallet/transactions | Get a list of all wallet-related transactions
[**wallet_transactions_by_scan_id**](WalletApi.md#wallet_transactions_by_scan_id) | **GET** /wallet/transactionsByScanId/{scanId} | Get scan-related transactions by scan id
[**wallet_unlock**](WalletApi.md#wallet_unlock) | **POST** /wallet/unlock | Unlock wallet
[**wallet_unsigned_transaction_generate**](WalletApi.md#wallet_unsigned_transaction_generate) | **POST** /wallet/transaction/generateUnsigned | Generate unsigned transaction from array of requests.
[**wallet_unspent_boxes**](WalletApi.md#wallet_unspent_boxes) | **GET** /wallet/boxes/unspent | Get a list of unspent boxes. Set minConfirmations to -1 to have mempool boxes considered.
[**wallet_update_change_address**](WalletApi.md#wallet_update_change_address) | **POST** /wallet/updateChangeAddress | Update address to be used to send change to


# **add_box**
> str add_box(scan_ids_box)

Adds a box to scans, writes box to database if it is not there. You can use scan number 10 to add a box to the wallet.

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.scan_ids_box import ScanIdsBox
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
    api_instance = wallet_api.WalletApi(api_client)
    scan_ids_box = ScanIdsBox(
        scan_ids=[
            1,
        ],
        box=ErgoTransactionOutput(
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
    ) # ScanIdsBox | 

    # example passing only required values which don't have defaults set
    try:
        # Adds a box to scans, writes box to database if it is not there. You can use scan number 10 to add a box to the wallet.
        api_response = api_instance.add_box(scan_ids_box)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->add_box: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scan_ids_box** | [**ScanIdsBox**](ScanIdsBox.md)|  |

### Return type

**str**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | It the box is added successfully, then its id is returned |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **check_seed**
> InlineResponse2001 check_seed(inline_object2)

Check whether mnemonic phrase is corresponding to the wallet seed

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.inline_object2 import InlineObject2
from ergo_node.model.inline_response2001 import InlineResponse2001
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
    api_instance = wallet_api.WalletApi(api_client)
    inline_object2 = InlineObject2(
        mnemonic="mnemonic_example",
        mnemonic_pass="mnemonic_pass_example",
    ) # InlineObject2 | 

    # example passing only required values which don't have defaults set
    try:
        # Check whether mnemonic phrase is corresponding to the wallet seed
        api_response = api_instance.check_seed(inline_object2)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->check_seed: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inline_object2** | [**InlineObject2**](InlineObject2.md)|  |

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
**200** | Whether passphrase match wallet |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **extract_hints**
> TransactionHintsBag extract_hints(hint_extraction_request)

Extract hints from a transaction

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.transaction_hints_bag import TransactionHintsBag
from ergo_node.model.api_error import ApiError
from ergo_node.model.hint_extraction_request import HintExtractionRequest
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
    api_instance = wallet_api.WalletApi(api_client)
    hint_extraction_request = HintExtractionRequest(
        tx=ErgoTransaction(
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
        real=[
            SigmaBoolean(None),
        ],
        simulated=[
            SigmaBoolean(None),
        ],
        inputs_raw=[
            "inputs_raw_example",
        ],
        data_inputs_raw=[
            "data_inputs_raw_example",
        ],
    ) # HintExtractionRequest | 

    # example passing only required values which don't have defaults set
    try:
        # Extract hints from a transaction
        api_response = api_instance.extract_hints(hint_extraction_request)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->extract_hints: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hint_extraction_request** | [**HintExtractionRequest**](HintExtractionRequest.md)|  |

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
**200** | Hints for the transaction |  -  |
**400** | Error |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **generate_commitments**
> TransactionHintsBag generate_commitments(generate_commitments_request)

Generate signature commitments for inputs of an unsigned transaction

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.transaction_hints_bag import TransactionHintsBag
from ergo_node.model.api_error import ApiError
from ergo_node.model.generate_commitments_request import GenerateCommitmentsRequest
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
    api_instance = wallet_api.WalletApi(api_client)
    generate_commitments_request = GenerateCommitmentsRequest(
        tx=UnsignedErgoTransaction(
            id="2ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
            inputs=[
                ErgoTransactionUnsignedInput(
                    box_id="1ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
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
        ),
        secrets=GenerateCommitmentsRequestSecrets(
            dlog=[
                "433080ff80d0d52d7f8bfffff47f00807f44f680000949b800007f7f7ff1017f",
            ],
            dht=[
                DhtSecret(
                    secret="433080ff80d0d52d7f8bfffff47f00807f44f680000949b800007f7f7ff1017f",
                    g="02a7955281885bf0f0ca4a48678848cad8dc5b328ce8bc1d4481d041c98e891ff3",
                    h="02a7955281885bf0f0ca4a48678848cad8dc5b328ce8bc1d4481d041c98e891ff3",
                    u="02a7955281885bf0f0ca4a48678848cad8dc5b328ce8bc1d4481d041c98e891ff3",
                    v="02a7955281885bf0f0ca4a48678848cad8dc5b328ce8bc1d4481d041c98e891ff3",
                ),
            ],
        ),
        inputs_raw=[
            "inputs_raw_example",
        ],
        data_inputs_raw=[
            "data_inputs_raw_example",
        ],
    ) # GenerateCommitmentsRequest | 

    # example passing only required values which don't have defaults set
    try:
        # Generate signature commitments for inputs of an unsigned transaction
        api_response = api_instance.generate_commitments(generate_commitments_request)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->generate_commitments: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **generate_commitments_request** | [**GenerateCommitmentsRequest**](GenerateCommitmentsRequest.md)|  |

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
**200** | Transaction-related hints |  -  |
**400** | Error |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_wallet_status**
> InlineResponse2002 get_wallet_status()

Get wallet status

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.inline_response2002 import InlineResponse2002
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
    api_instance = wallet_api.WalletApi(api_client)

    # example, this endpoint has no required or optional parameters
    try:
        # Get wallet status
        api_response = api_instance.get_wallet_status()
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->get_wallet_status: %s\n" % e)
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
**200** | Wallet status |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wallet_addresses**
> [str] wallet_addresses()

Get wallet addresses

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
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
    api_instance = wallet_api.WalletApi(api_client)

    # example, this endpoint has no required or optional parameters
    try:
        # Get wallet addresses
        api_response = api_instance.wallet_addresses()
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_addresses: %s\n" % e)
```


### Parameters
This endpoint does not need any parameter.

### Return type

**[str]**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | String with encoded wallet addresses |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wallet_balances**
> BalancesSnapshot wallet_balances()

Get total amount of confirmed Ergo tokens and assets

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.balances_snapshot import BalancesSnapshot
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
    api_instance = wallet_api.WalletApi(api_client)

    # example, this endpoint has no required or optional parameters
    try:
        # Get total amount of confirmed Ergo tokens and assets
        api_response = api_instance.wallet_balances()
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_balances: %s\n" % e)
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
**200** | Get total amount of confirmed Ergo tokens and assets |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wallet_balances_unconfirmed**
> BalancesSnapshot wallet_balances_unconfirmed()

Get summary amount of confirmed plus unconfirmed Ergo tokens and assets

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.balances_snapshot import BalancesSnapshot
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
    api_instance = wallet_api.WalletApi(api_client)

    # example, this endpoint has no required or optional parameters
    try:
        # Get summary amount of confirmed plus unconfirmed Ergo tokens and assets
        api_response = api_instance.wallet_balances_unconfirmed()
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_balances_unconfirmed: %s\n" % e)
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
**200** | Get summary amount of confirmed plus unconfirmed Ergo tokens and assets |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wallet_boxes**
> [WalletBox] wallet_boxes()

Get a list of all wallet-related boxes, both spent and unspent. Set minConfirmations to -1 to get mempool boxes included.

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.wallet_box import WalletBox
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
    api_instance = wallet_api.WalletApi(api_client)
    min_confirmations = 0 # int | Minimal number of confirmations (optional) if omitted the server will use the default value of 0
    min_inclusion_height = 0 # int | Minimal box inclusion height (optional) if omitted the server will use the default value of 0

    # example passing only required values which don't have defaults set
    # and optional values
    try:
        # Get a list of all wallet-related boxes, both spent and unspent. Set minConfirmations to -1 to get mempool boxes included.
        api_response = api_instance.wallet_boxes(min_confirmations=min_confirmations, min_inclusion_height=min_inclusion_height)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_boxes: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **min_confirmations** | **int**| Minimal number of confirmations | [optional] if omitted the server will use the default value of 0
 **min_inclusion_height** | **int**| Minimal box inclusion height | [optional] if omitted the server will use the default value of 0

### Return type

[**[WalletBox]**](WalletBox.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | A list of all wallet-related boxes |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wallet_boxes_collect**
> [WalletBox] wallet_boxes_collect(boxes_request_holder)

Get a list of collected boxes.

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.wallet_box import WalletBox
from ergo_node.model.api_error import ApiError
from ergo_node.model.boxes_request_holder import BoxesRequestHolder
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
    api_instance = wallet_api.WalletApi(api_client)
    boxes_request_holder = BoxesRequestHolder(
        target_assets=[
null,
        ],
        target_balance=1,
    ) # BoxesRequestHolder | This API method recieves balance and assets, according to which, it's collecting result

    # example passing only required values which don't have defaults set
    try:
        # Get a list of collected boxes.
        api_response = api_instance.wallet_boxes_collect(boxes_request_holder)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_boxes_collect: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **boxes_request_holder** | [**BoxesRequestHolder**](BoxesRequestHolder.md)| This API method recieves balance and assets, according to which, it&#39;s collecting result |

### Return type

[**[WalletBox]**](WalletBox.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | A list of all collected boxes |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wallet_derive_key**
> InlineResponse2003 wallet_derive_key(inline_object5)

Derive new key according to a provided path

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.inline_object5 import InlineObject5
from ergo_node.model.inline_response2003 import InlineResponse2003
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
    api_instance = wallet_api.WalletApi(api_client)
    inline_object5 = InlineObject5(
        derivation_path="m/1/2",
    ) # InlineObject5 | 

    # example passing only required values which don't have defaults set
    try:
        # Derive new key according to a provided path
        api_response = api_instance.wallet_derive_key(inline_object5)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_derive_key: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inline_object5** | [**InlineObject5**](InlineObject5.md)|  |

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
**200** | Resulted address |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wallet_derive_next_key**
> InlineResponse2004 wallet_derive_next_key()

Derive next key

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.inline_response2004 import InlineResponse2004
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
    api_instance = wallet_api.WalletApi(api_client)

    # example, this endpoint has no required or optional parameters
    try:
        # Derive next key
        api_response = api_instance.wallet_derive_next_key()
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_derive_next_key: %s\n" % e)
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
**200** | Resulted secret path and address |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wallet_get_transaction**
> [WalletTransaction] wallet_get_transaction(id)

Get wallet-related transaction by id

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.wallet_transaction import WalletTransaction
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
    api_instance = wallet_api.WalletApi(api_client)
    id = "id_example" # str | Transaction id

    # example passing only required values which don't have defaults set
    try:
        # Get wallet-related transaction by id
        api_response = api_instance.wallet_get_transaction(id)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_get_transaction: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**| Transaction id |

### Return type

[**[WalletTransaction]**](WalletTransaction.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Wallet-related transaction |  -  |
**404** | Transaction with specified id not found in wallet |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wallet_init**
> InlineResponse200 wallet_init(inline_object)

Initialize new wallet with randomly generated seed

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.inline_object import InlineObject
from ergo_node.model.inline_response200 import InlineResponse200
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
    api_instance = wallet_api.WalletApi(api_client)
    inline_object = InlineObject(
        _pass="_pass_example",
        mnemonic_pass="mnemonic_pass_example",
    ) # InlineObject | 

    # example passing only required values which don't have defaults set
    try:
        # Initialize new wallet with randomly generated seed
        api_response = api_instance.wallet_init(inline_object)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_init: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inline_object** | [**InlineObject**](InlineObject.md)|  |

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
**200** | New wallet with randomly generated seed created successfully |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wallet_lock**
> wallet_lock()

Lock wallet

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
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
    api_instance = wallet_api.WalletApi(api_client)

    # example, this endpoint has no required or optional parameters
    try:
        # Lock wallet
        api_instance.wallet_lock()
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_lock: %s\n" % e)
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
**200** | Wallet locked successfully |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wallet_payment_transaction_generate_and_send**
> str wallet_payment_transaction_generate_and_send(payment_request)

Generate and send payment transaction (default fee of 0.001 Erg is used)

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.payment_request import PaymentRequest
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
    api_instance = wallet_api.WalletApi(api_client)
    payment_request = [
        PaymentRequest(
            address="3WwbzW6u8hKWBcL1W7kNVMr25s2UHfSBnYtwSHvrRQt7DdPuoXrt",
            value=1,
            assets=[
                Asset(
                    token_id="4ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
                    amount=1000,
                ),
            ],
            registers=Registers(
                key="100204a00b08cd0336100ef59ced80ba5f89c4178ebd57b6c1dd0f3d135ee1db9f62fc634d637041ea02d192a39a8cc7a70173007301",
            ),
        ),
    ] # [PaymentRequest] | 

    # example passing only required values which don't have defaults set
    try:
        # Generate and send payment transaction (default fee of 0.001 Erg is used)
        api_response = api_instance.wallet_payment_transaction_generate_and_send(payment_request)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_payment_transaction_generate_and_send: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payment_request** | [**[PaymentRequest]**](PaymentRequest.md)|  |

### Return type

**str**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Identifier of an Ergo transaction generated |  -  |
**400** | Bad payment request |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wallet_rescan**
> wallet_rescan()

Rescan wallet (all the available full blocks)

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
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
    api_instance = wallet_api.WalletApi(api_client)

    # example, this endpoint has no required or optional parameters
    try:
        # Rescan wallet (all the available full blocks)
        api_instance.wallet_rescan()
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_rescan: %s\n" % e)
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
**200** | Wallet storage recreated |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wallet_restore**
> wallet_restore(inline_object1)

Create new wallet from existing mnemonic seed

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.inline_object1 import InlineObject1
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
    api_instance = wallet_api.WalletApi(api_client)
    inline_object1 = InlineObject1(
        _pass="_pass_example",
        mnemonic="mnemonic_example",
        mnemonic_pass="mnemonic_pass_example",
    ) # InlineObject1 | 

    # example passing only required values which don't have defaults set
    try:
        # Create new wallet from existing mnemonic seed
        api_instance.wallet_restore(inline_object1)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_restore: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inline_object1** | [**InlineObject1**](InlineObject1.md)|  |

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
**200** | Wallet restored successfully |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wallet_transaction_generate**
> ErgoTransaction wallet_transaction_generate(requests_holder)

Generate arbitrary transaction from array of requests.

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.ergo_transaction import ErgoTransaction
from ergo_node.model.requests_holder import RequestsHolder
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
    api_instance = wallet_api.WalletApi(api_client)
    requests_holder = RequestsHolder(
        requests=[
            None,
        ],
        fee=1000000,
        inputs_raw=[
            "inputs_raw_example",
        ],
        data_inputs_raw=[
            "data_inputs_raw_example",
        ],
    ) # RequestsHolder | This API method receives a sequence of requests as an input. Each request will produce an output of the resulting transaction (with fee output created automatically). Currently supported types of requests are payment and asset issuance requests. An example for a transaction with requests of both kinds is provided below. Please note that for the payment request \"assets\" and \"registers\" fields are not needed. For asset issuance request, \"registers\" field is not needed. You may specify boxes to spend by providing them in \"inputsRaw\". Please note you need to have strict equality between input and output total amounts of Ergs in this case. If you want wallet to pick up the boxes, leave \"inputsRaw\" empty.

    # example passing only required values which don't have defaults set
    try:
        # Generate arbitrary transaction from array of requests.
        api_response = api_instance.wallet_transaction_generate(requests_holder)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_transaction_generate: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requests_holder** | [**RequestsHolder**](RequestsHolder.md)| This API method receives a sequence of requests as an input. Each request will produce an output of the resulting transaction (with fee output created automatically). Currently supported types of requests are payment and asset issuance requests. An example for a transaction with requests of both kinds is provided below. Please note that for the payment request \&quot;assets\&quot; and \&quot;registers\&quot; fields are not needed. For asset issuance request, \&quot;registers\&quot; field is not needed. You may specify boxes to spend by providing them in \&quot;inputsRaw\&quot;. Please note you need to have strict equality between input and output total amounts of Ergs in this case. If you want wallet to pick up the boxes, leave \&quot;inputsRaw\&quot; empty. |

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
**200** | Generated Ergo transaction |  -  |
**400** | Bad transaction request |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wallet_transaction_generate_and_send**
> str wallet_transaction_generate_and_send(requests_holder)

Generate and send arbitrary transaction

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.requests_holder import RequestsHolder
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
    api_instance = wallet_api.WalletApi(api_client)
    requests_holder = RequestsHolder(
        requests=[
            None,
        ],
        fee=1000000,
        inputs_raw=[
            "inputs_raw_example",
        ],
        data_inputs_raw=[
            "data_inputs_raw_example",
        ],
    ) # RequestsHolder | See description of /wallet/transaction/generate

    # example passing only required values which don't have defaults set
    try:
        # Generate and send arbitrary transaction
        api_response = api_instance.wallet_transaction_generate_and_send(requests_holder)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_transaction_generate_and_send: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requests_holder** | [**RequestsHolder**](RequestsHolder.md)| See description of /wallet/transaction/generate |

### Return type

**str**

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Identifier of an Ergo transaction generated |  -  |
**400** | Bad transaction request |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wallet_transaction_sign**
> ErgoTransaction wallet_transaction_sign(transaction_signing_request)

Sign arbitrary unsigned transaction with wallet secrets and also secrets provided.

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.transaction_signing_request import TransactionSigningRequest
from ergo_node.model.ergo_transaction import ErgoTransaction
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
    api_instance = wallet_api.WalletApi(api_client)
    transaction_signing_request = TransactionSigningRequest(
        tx=UnsignedErgoTransaction(
            id="2ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
            inputs=[
                ErgoTransactionUnsignedInput(
                    box_id="1ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
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
        ),
        inputs_raw=[
            "inputs_raw_example",
        ],
        data_inputs_raw=[
            "data_inputs_raw_example",
        ],
        hints=TransactionHintsBag(
            secret_hints=[
                InputHints(
                    key=[
                        None,
                    ],
                ),
            ],
            public_hints=[
                InputHints(
                    key=[
                        None,
                    ],
                ),
            ],
        ),
        secrets=TransactionSigningRequestSecrets(
            dlog=[
                "433080ff80d0d52d7f8bfffff47f00807f44f680000949b800007f7f7ff1017f",
            ],
            dht=[
                DhtSecret(
                    secret="433080ff80d0d52d7f8bfffff47f00807f44f680000949b800007f7f7ff1017f",
                    g="02a7955281885bf0f0ca4a48678848cad8dc5b328ce8bc1d4481d041c98e891ff3",
                    h="02a7955281885bf0f0ca4a48678848cad8dc5b328ce8bc1d4481d041c98e891ff3",
                    u="02a7955281885bf0f0ca4a48678848cad8dc5b328ce8bc1d4481d041c98e891ff3",
                    v="02a7955281885bf0f0ca4a48678848cad8dc5b328ce8bc1d4481d041c98e891ff3",
                ),
            ],
        ),
    ) # TransactionSigningRequest | With this API method an arbitrary unsigned transaction can be signed with secrets provided or stored in the wallet. Both DLOG and Diffie-Hellman tuple secrets are supported. Please note that the unsigned transaction contains only identifiers of inputs and data inputs. If the node holds UTXO set, it is able to extract boxes needed. Otherwise, input (and data-input) boxes can be provided in \"inputsRaw\" and \"dataInputsRaw\" fields.

    # example passing only required values which don't have defaults set
    try:
        # Sign arbitrary unsigned transaction with wallet secrets and also secrets provided.
        api_response = api_instance.wallet_transaction_sign(transaction_signing_request)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_transaction_sign: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transaction_signing_request** | [**TransactionSigningRequest**](TransactionSigningRequest.md)| With this API method an arbitrary unsigned transaction can be signed with secrets provided or stored in the wallet. Both DLOG and Diffie-Hellman tuple secrets are supported. Please note that the unsigned transaction contains only identifiers of inputs and data inputs. If the node holds UTXO set, it is able to extract boxes needed. Otherwise, input (and data-input) boxes can be provided in \&quot;inputsRaw\&quot; and \&quot;dataInputsRaw\&quot; fields. |

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
**200** | Generated Ergo transaction |  -  |
**400** | Bad transaction request |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wallet_transactions**
> [WalletTransaction] wallet_transactions()

Get a list of all wallet-related transactions

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.wallet_transaction import WalletTransaction
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
    api_instance = wallet_api.WalletApi(api_client)
    min_inclusion_height = 0 # int | Minimal tx inclusion height (optional)
    max_inclusion_height = 0 # int | Maximal tx inclusion height (optional)
    min_confirmations = 0 # int | Minimal confirmations number (optional)
    max_confirmations = 0 # int | Maximal confirmations number (optional)

    # example passing only required values which don't have defaults set
    # and optional values
    try:
        # Get a list of all wallet-related transactions
        api_response = api_instance.wallet_transactions(min_inclusion_height=min_inclusion_height, max_inclusion_height=max_inclusion_height, min_confirmations=min_confirmations, max_confirmations=max_confirmations)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_transactions: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **min_inclusion_height** | **int**| Minimal tx inclusion height | [optional]
 **max_inclusion_height** | **int**| Maximal tx inclusion height | [optional]
 **min_confirmations** | **int**| Minimal confirmations number | [optional]
 **max_confirmations** | **int**| Maximal confirmations number | [optional]

### Return type

[**[WalletTransaction]**](WalletTransaction.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | A list of all wallet-related transactions |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wallet_transactions_by_scan_id**
> [WalletTransaction] wallet_transactions_by_scan_id(scan_id)

Get scan-related transactions by scan id

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.wallet_transaction import WalletTransaction
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
    api_instance = wallet_api.WalletApi(api_client)
    scan_id = 1 # int | identifier of a scan
    min_inclusion_height = 0 # int | Minimal tx inclusion height (optional)
    max_inclusion_height = 0 # int | Maximal tx inclusion height (optional)
    min_confirmations = 0 # int | Minimal confirmations number (optional)
    max_confirmations = 0 # int | Maximal confirmations number (optional)

    # example passing only required values which don't have defaults set
    try:
        # Get scan-related transactions by scan id
        api_response = api_instance.wallet_transactions_by_scan_id(scan_id)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_transactions_by_scan_id: %s\n" % e)

    # example passing only required values which don't have defaults set
    # and optional values
    try:
        # Get scan-related transactions by scan id
        api_response = api_instance.wallet_transactions_by_scan_id(scan_id, min_inclusion_height=min_inclusion_height, max_inclusion_height=max_inclusion_height, min_confirmations=min_confirmations, max_confirmations=max_confirmations)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_transactions_by_scan_id: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scan_id** | **int**| identifier of a scan |
 **min_inclusion_height** | **int**| Minimal tx inclusion height | [optional]
 **max_inclusion_height** | **int**| Maximal tx inclusion height | [optional]
 **min_confirmations** | **int**| Minimal confirmations number | [optional]
 **max_confirmations** | **int**| Maximal confirmations number | [optional]

### Return type

[**[WalletTransaction]**](WalletTransaction.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Scan-related transactions |  -  |
**404** | Transactions with related scan id not found in wallet |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wallet_unlock**
> wallet_unlock(inline_object3)

Unlock wallet

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.inline_object3 import InlineObject3
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
    api_instance = wallet_api.WalletApi(api_client)
    inline_object3 = InlineObject3(
        _pass="_pass_example",
    ) # InlineObject3 | 

    # example passing only required values which don't have defaults set
    try:
        # Unlock wallet
        api_instance.wallet_unlock(inline_object3)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_unlock: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inline_object3** | [**InlineObject3**](InlineObject3.md)|  |

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
**200** | Wallet unlocked successfully |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wallet_unsigned_transaction_generate**
> UnsignedErgoTransaction wallet_unsigned_transaction_generate(requests_holder)

Generate unsigned transaction from array of requests.

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.requests_holder import RequestsHolder
from ergo_node.model.api_error import ApiError
from ergo_node.model.unsigned_ergo_transaction import UnsignedErgoTransaction
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
    api_instance = wallet_api.WalletApi(api_client)
    requests_holder = RequestsHolder(
        requests=[
            None,
        ],
        fee=1000000,
        inputs_raw=[
            "inputs_raw_example",
        ],
        data_inputs_raw=[
            "data_inputs_raw_example",
        ],
    ) # RequestsHolder | The same as /wallet/transaction/generate but generates unsigned transaction.

    # example passing only required values which don't have defaults set
    try:
        # Generate unsigned transaction from array of requests.
        api_response = api_instance.wallet_unsigned_transaction_generate(requests_holder)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_unsigned_transaction_generate: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requests_holder** | [**RequestsHolder**](RequestsHolder.md)| The same as /wallet/transaction/generate but generates unsigned transaction. |

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
**200** | Generated unsigned Ergo transaction |  -  |
**400** | Bad transaction request |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wallet_unspent_boxes**
> [WalletBox] wallet_unspent_boxes()

Get a list of unspent boxes. Set minConfirmations to -1 to have mempool boxes considered.

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.wallet_box import WalletBox
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
    api_instance = wallet_api.WalletApi(api_client)
    min_confirmations = 0 # int | Minimal number of confirmations (optional) if omitted the server will use the default value of 0
    min_inclusion_height = 0 # int | Minimal box inclusion height (optional) if omitted the server will use the default value of 0

    # example passing only required values which don't have defaults set
    # and optional values
    try:
        # Get a list of unspent boxes. Set minConfirmations to -1 to have mempool boxes considered.
        api_response = api_instance.wallet_unspent_boxes(min_confirmations=min_confirmations, min_inclusion_height=min_inclusion_height)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_unspent_boxes: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **min_confirmations** | **int**| Minimal number of confirmations | [optional] if omitted the server will use the default value of 0
 **min_inclusion_height** | **int**| Minimal box inclusion height | [optional] if omitted the server will use the default value of 0

### Return type

[**[WalletBox]**](WalletBox.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | A list of unspent boxes |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wallet_update_change_address**
> wallet_update_change_address(inline_object4)

Update address to be used to send change to

### Example

* Api Key Authentication (ApiKeyAuth):

```python
import time
import ergo_node
from ergo_node.api import wallet_api
from ergo_node.model.inline_object4 import InlineObject4
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
    api_instance = wallet_api.WalletApi(api_client)
    inline_object4 = InlineObject4(
        address="3WzCFq7mkykKqi4Ykdk8BK814tkh6EsPmA42pQZxU2NRwSDgd6yB",
    ) # InlineObject4 | 

    # example passing only required values which don't have defaults set
    try:
        # Update address to be used to send change to
        api_instance.wallet_update_change_address(inline_object4)
    except ergo_node.ApiException as e:
        print("Exception when calling WalletApi->wallet_update_change_address: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inline_object4** | [**InlineObject4**](InlineObject4.md)|  |

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
**200** | Change address updated successfully |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

