# ergo_node.BlocksApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_block_header_by_id**](BlocksApi.md#get_block_header_by_id) | **GET** /blocks/{headerId}/header | Get the block header info by a given signature
[**get_block_transactions_by_id**](BlocksApi.md#get_block_transactions_by_id) | **GET** /blocks/{headerId}/transactions | Get the block transactions info by a given signature
[**get_chain_slice**](BlocksApi.md#get_chain_slice) | **GET** /blocks/chainSlice | Get headers in a specified range
[**get_full_block_at**](BlocksApi.md#get_full_block_at) | **GET** /blocks/at/{blockHeight} | Get the header ids at a given height
[**get_full_block_by_id**](BlocksApi.md#get_full_block_by_id) | **GET** /blocks/{headerId} | Get the full block info by a given signature
[**get_header_ids**](BlocksApi.md#get_header_ids) | **GET** /blocks | Get the Array of header ids
[**get_last_headers**](BlocksApi.md#get_last_headers) | **GET** /blocks/lastHeaders/{count} | Get the last headers objects
[**get_modifier_by_id**](BlocksApi.md#get_modifier_by_id) | **GET** /blocks/modifier/{modifierId} | Get the persistent modifier by its id
[**get_proof_for_tx**](BlocksApi.md#get_proof_for_tx) | **GET** /blocks/{headerId}/proofFor/{txId} | Get Merkle proof for transaction
[**send_mined_block**](BlocksApi.md#send_mined_block) | **POST** /blocks | Send a mined block


# **get_block_header_by_id**
> BlockHeader get_block_header_by_id(header_id)

Get the block header info by a given signature

### Example


```python
import time
import ergo_node
from ergo_node.api import blocks_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.block_header import BlockHeader
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)


# Enter a context with an instance of the API client
with ergo_node.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = blocks_api.BlocksApi(api_client)
    header_id = "headerId_example" # str | ID of a wanted block header

    # example passing only required values which don't have defaults set
    try:
        # Get the block header info by a given signature
        api_response = api_instance.get_block_header_by_id(header_id)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling BlocksApi->get_block_header_by_id: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **header_id** | **str**| ID of a wanted block header |

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
**200** | Block header object |  -  |
**404** | Block with this id doesn&#39;t exist |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_block_transactions_by_id**
> BlockTransactions get_block_transactions_by_id(header_id)

Get the block transactions info by a given signature

### Example


```python
import time
import ergo_node
from ergo_node.api import blocks_api
from ergo_node.model.block_transactions import BlockTransactions
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
    api_instance = blocks_api.BlocksApi(api_client)
    header_id = "headerId_example" # str | ID of a wanted block transactions

    # example passing only required values which don't have defaults set
    try:
        # Get the block transactions info by a given signature
        api_response = api_instance.get_block_transactions_by_id(header_id)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling BlocksApi->get_block_transactions_by_id: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **header_id** | **str**| ID of a wanted block transactions |

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
**200** | Block transaction object |  -  |
**404** | Block with this id doesn&#39;t exist |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_chain_slice**
> [BlockHeader] get_chain_slice()

Get headers in a specified range

### Example


```python
import time
import ergo_node
from ergo_node.api import blocks_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.block_header import BlockHeader
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)


# Enter a context with an instance of the API client
with ergo_node.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = blocks_api.BlocksApi(api_client)
    from_height = 0 # int | Min header height (optional) if omitted the server will use the default value of 0
    to_height = -1 # int | Max header height (best header height by default) (optional) if omitted the server will use the default value of -1

    # example passing only required values which don't have defaults set
    # and optional values
    try:
        # Get headers in a specified range
        api_response = api_instance.get_chain_slice(from_height=from_height, to_height=to_height)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling BlocksApi->get_chain_slice: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from_height** | **int**| Min header height | [optional] if omitted the server will use the default value of 0
 **to_height** | **int**| Max header height (best header height by default) | [optional] if omitted the server will use the default value of -1

### Return type

[**[BlockHeader]**](BlockHeader.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Array of headers |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_full_block_at**
> [str] get_full_block_at(block_height)

Get the header ids at a given height

### Example


```python
import time
import ergo_node
from ergo_node.api import blocks_api
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
    api_instance = blocks_api.BlocksApi(api_client)
    block_height = 1 # int | Height of a wanted block

    # example passing only required values which don't have defaults set
    try:
        # Get the header ids at a given height
        api_response = api_instance.get_full_block_at(block_height)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling BlocksApi->get_full_block_at: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **block_height** | **int**| Height of a wanted block |

### Return type

**[str]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Array of header ids |  -  |
**404** | Blocks at this height doesn&#39;t exist |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_full_block_by_id**
> FullBlock get_full_block_by_id(header_id)

Get the full block info by a given signature

### Example


```python
import time
import ergo_node
from ergo_node.api import blocks_api
from ergo_node.model.full_block import FullBlock
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
    api_instance = blocks_api.BlocksApi(api_client)
    header_id = "headerId_example" # str | ID of a wanted block

    # example passing only required values which don't have defaults set
    try:
        # Get the full block info by a given signature
        api_response = api_instance.get_full_block_by_id(header_id)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling BlocksApi->get_full_block_by_id: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **header_id** | **str**| ID of a wanted block |

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
**200** | Block object |  -  |
**404** | Block with this id doesn&#39;t exist |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_header_ids**
> [str] get_header_ids()

Get the Array of header ids

### Example


```python
import time
import ergo_node
from ergo_node.api import blocks_api
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
    api_instance = blocks_api.BlocksApi(api_client)
    limit = 50 # int | The number of items in list to return (optional) if omitted the server will use the default value of 50
    offset = 0 # int | The number of items in list to skip (optional) if omitted the server will use the default value of 0

    # example passing only required values which don't have defaults set
    # and optional values
    try:
        # Get the Array of header ids
        api_response = api_instance.get_header_ids(limit=limit, offset=offset)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling BlocksApi->get_header_ids: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int**| The number of items in list to return | [optional] if omitted the server will use the default value of 50
 **offset** | **int**| The number of items in list to skip | [optional] if omitted the server will use the default value of 0

### Return type

**[str]**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Array of header ids |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_last_headers**
> [BlockHeader] get_last_headers(count)

Get the last headers objects

### Example


```python
import time
import ergo_node
from ergo_node.api import blocks_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.block_header import BlockHeader
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)


# Enter a context with an instance of the API client
with ergo_node.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = blocks_api.BlocksApi(api_client)
    count = 3.14 # float | count of a wanted block headers

    # example passing only required values which don't have defaults set
    try:
        # Get the last headers objects
        api_response = api_instance.get_last_headers(count)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling BlocksApi->get_last_headers: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **count** | **float**| count of a wanted block headers |

### Return type

[**[BlockHeader]**](BlockHeader.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details

| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** | Array of block headers |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_modifier_by_id**
> get_modifier_by_id(modifier_id)

Get the persistent modifier by its id

### Example


```python
import time
import ergo_node
from ergo_node.api import blocks_api
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
    api_instance = blocks_api.BlocksApi(api_client)
    modifier_id = "modifierId_example" # str | ID of a wanted modifier

    # example passing only required values which don't have defaults set
    try:
        # Get the persistent modifier by its id
        api_instance.get_modifier_by_id(modifier_id)
    except ergo_node.ApiException as e:
        print("Exception when calling BlocksApi->get_modifier_by_id: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **modifier_id** | **str**| ID of a wanted modifier |

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
**200** | Persistent modifier object |  -  |
**404** | Modifier with this id doesn&#39;t exist |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_proof_for_tx**
> MerkleProof get_proof_for_tx(header_id, tx_id)

Get Merkle proof for transaction

### Example


```python
import time
import ergo_node
from ergo_node.api import blocks_api
from ergo_node.model.api_error import ApiError
from ergo_node.model.merkle_proof import MerkleProof
from pprint import pprint
# Defining the host is optional and defaults to http://localhost
# See configuration.py for a list of all supported configuration parameters.
configuration = ergo_node.Configuration(
    host = "http://localhost"
)


# Enter a context with an instance of the API client
with ergo_node.ApiClient() as api_client:
    # Create an instance of the API class
    api_instance = blocks_api.BlocksApi(api_client)
    header_id = "headerId_example" # str | ID of a wanted block transactions
    tx_id = "txId_example" # str | ID of a wanted transaction

    # example passing only required values which don't have defaults set
    try:
        # Get Merkle proof for transaction
        api_response = api_instance.get_proof_for_tx(header_id, tx_id)
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling BlocksApi->get_proof_for_tx: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **header_id** | **str**| ID of a wanted block transactions |
 **tx_id** | **str**| ID of a wanted transaction |

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
**200** | Merkle proof object |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **send_mined_block**
> send_mined_block(full_block)

Send a mined block

### Example


```python
import time
import ergo_node
from ergo_node.api import blocks_api
from ergo_node.model.full_block import FullBlock
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
    api_instance = blocks_api.BlocksApi(api_client)
    full_block = FullBlock(
        header=BlockHeader(
            id="3ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
            timestamp=1524143059077,
            version=2,
            ad_proofs_root="4ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
            state_root="333ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
            transactions_root="4ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
            n_bits=19857408,
            extension_hash="4ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
            pow_solutions=PowSolutions(
                pk="0350e25cee8562697d55275c96bb01b34228f9bd68fd9933f2a25ff195526864f5",
                w="0366ea253123dfdb8d6d9ca2cb9ea98629e8f34015b1e4ba942b1d88badfcc6a12",
                n="0000000000000000",
                d=987654321,
            ),
            height=667,
            difficulty=62,
            parent_id="3ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
            votes="000000",
            size=1,
            extension_id="3ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
            transactions_id="3ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
            ad_proofs_id="3ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
        ),
        block_transactions=BlockTransactions(
            header_id="3ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
            transactions=Transactions([
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
            ]),
            size=1,
        ),
        ad_proofs=BlockADProofs(
            header_id="3ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
            proof_bytes="3ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd1173ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd1173ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
            digest="4ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
            size=1,
        ),
        extension=Extension(
            header_id="3ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
            digest="4ab9da11fc216660e974842cc3b7705e62ebb9e0bf5ff78e53f9cd40abadd117",
            fields=[
                KeyValueItem([
                    "string_example",
                ]),
            ],
        ),
        size=1,
    ) # FullBlock | 

    # example passing only required values which don't have defaults set
    try:
        # Send a mined block
        api_instance.send_mined_block(full_block)
    except ergo_node.ApiException as e:
        print("Exception when calling BlocksApi->send_mined_block: %s\n" % e)
```


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **full_block** | [**FullBlock**](FullBlock.md)|  |

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
**200** | Block is valid |  -  |
**0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

