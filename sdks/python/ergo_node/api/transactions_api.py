"""
    Ergo Node API

    API docs for Ergo Node. Models are shared between all Ergo products  # noqa: E501

    The version of the OpenAPI document: 4.0.15
    Contact: ergoplatform@protonmail.com
    Generated by: https://openapi-generator.tech
"""


import re  # noqa: F401
import sys  # noqa: F401

from ergo_node.api_client import ApiClient, Endpoint as _Endpoint
from ergo_node.model_utils import (  # noqa: F401
    check_allowed_values,
    check_validations,
    date,
    datetime,
    file_type,
    none_type,
    validate_and_convert_types
)
from ergo_node.model.api_error import ApiError
from ergo_node.model.ergo_transaction import ErgoTransaction
from ergo_node.model.fee_histogram import FeeHistogram
from ergo_node.model.transactions import Transactions


class TransactionsApi(object):
    """NOTE: This class is auto generated by OpenAPI Generator
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    def __init__(self, api_client=None):
        if api_client is None:
            api_client = ApiClient()
        self.api_client = api_client
        self.check_transaction_endpoint = _Endpoint(
            settings={
                'response_type': (str,),
                'auth': [],
                'endpoint_path': '/transactions/check',
                'operation_id': 'check_transaction',
                'http_method': 'POST',
                'servers': None,
            },
            params_map={
                'all': [
                    'ergo_transaction',
                ],
                'required': [
                    'ergo_transaction',
                ],
                'nullable': [
                ],
                'enum': [
                ],
                'validation': [
                ]
            },
            root_map={
                'validations': {
                },
                'allowed_values': {
                },
                'openapi_types': {
                    'ergo_transaction':
                        (ErgoTransaction,),
                },
                'attribute_map': {
                },
                'location_map': {
                    'ergo_transaction': 'body',
                },
                'collection_format_map': {
                }
            },
            headers_map={
                'accept': [
                    'application/json'
                ],
                'content_type': [
                    'application/json'
                ]
            },
            api_client=api_client
        )
        self.get_expected_wait_time_endpoint = _Endpoint(
            settings={
                'response_type': (int,),
                'auth': [],
                'endpoint_path': '/transactions/waitTime',
                'operation_id': 'get_expected_wait_time',
                'http_method': 'GET',
                'servers': None,
            },
            params_map={
                'all': [
                    'fee',
                    'tx_size',
                ],
                'required': [
                    'fee',
                    'tx_size',
                ],
                'nullable': [
                ],
                'enum': [
                ],
                'validation': [
                    'fee',
                    'tx_size',
                ]
            },
            root_map={
                'validations': {
                    ('fee',): {

                        'inclusive_minimum': 1,
                    },
                    ('tx_size',): {

                        'inclusive_minimum': 1,
                    },
                },
                'allowed_values': {
                },
                'openapi_types': {
                    'fee':
                        (int,),
                    'tx_size':
                        (int,),
                },
                'attribute_map': {
                    'fee': 'fee',
                    'tx_size': 'txSize',
                },
                'location_map': {
                    'fee': 'query',
                    'tx_size': 'query',
                },
                'collection_format_map': {
                }
            },
            headers_map={
                'accept': [
                    'application/json'
                ],
                'content_type': [],
            },
            api_client=api_client
        )
        self.get_fee_histogram_endpoint = _Endpoint(
            settings={
                'response_type': (FeeHistogram,),
                'auth': [],
                'endpoint_path': '/transactions/poolHistogram',
                'operation_id': 'get_fee_histogram',
                'http_method': 'GET',
                'servers': None,
            },
            params_map={
                'all': [
                    'bins',
                    'maxtime',
                ],
                'required': [],
                'nullable': [
                ],
                'enum': [
                ],
                'validation': [
                    'bins',
                    'maxtime',
                ]
            },
            root_map={
                'validations': {
                    ('bins',): {

                        'inclusive_minimum': 1,
                    },
                    ('maxtime',): {

                        'inclusive_minimum': 0,
                    },
                },
                'allowed_values': {
                },
                'openapi_types': {
                    'bins':
                        (int,),
                    'maxtime':
                        (int,),
                },
                'attribute_map': {
                    'bins': 'bins',
                    'maxtime': 'maxtime',
                },
                'location_map': {
                    'bins': 'query',
                    'maxtime': 'query',
                },
                'collection_format_map': {
                }
            },
            headers_map={
                'accept': [
                    'application/json'
                ],
                'content_type': [],
            },
            api_client=api_client
        )
        self.get_recommended_fee_endpoint = _Endpoint(
            settings={
                'response_type': (int,),
                'auth': [],
                'endpoint_path': '/transactions/getFee',
                'operation_id': 'get_recommended_fee',
                'http_method': 'GET',
                'servers': None,
            },
            params_map={
                'all': [
                    'wait_time',
                    'tx_size',
                ],
                'required': [
                    'wait_time',
                    'tx_size',
                ],
                'nullable': [
                ],
                'enum': [
                ],
                'validation': [
                    'wait_time',
                    'tx_size',
                ]
            },
            root_map={
                'validations': {
                    ('wait_time',): {

                        'inclusive_minimum': 1,
                    },
                    ('tx_size',): {

                        'inclusive_minimum': 1,
                    },
                },
                'allowed_values': {
                },
                'openapi_types': {
                    'wait_time':
                        (int,),
                    'tx_size':
                        (int,),
                },
                'attribute_map': {
                    'wait_time': 'waitTime',
                    'tx_size': 'txSize',
                },
                'location_map': {
                    'wait_time': 'query',
                    'tx_size': 'query',
                },
                'collection_format_map': {
                }
            },
            headers_map={
                'accept': [
                    'application/json'
                ],
                'content_type': [],
            },
            api_client=api_client
        )
        self.get_unconfirmed_transactions_endpoint = _Endpoint(
            settings={
                'response_type': (Transactions,),
                'auth': [],
                'endpoint_path': '/transactions/unconfirmed',
                'operation_id': 'get_unconfirmed_transactions',
                'http_method': 'GET',
                'servers': None,
            },
            params_map={
                'all': [
                    'limit',
                    'offset',
                ],
                'required': [],
                'nullable': [
                ],
                'enum': [
                ],
                'validation': [
                    'limit',
                ]
            },
            root_map={
                'validations': {
                    ('limit',): {

                        'inclusive_maximum': 100,
                        'inclusive_minimum': 10,
                    },
                },
                'allowed_values': {
                },
                'openapi_types': {
                    'limit':
                        (int,),
                    'offset':
                        (int,),
                },
                'attribute_map': {
                    'limit': 'limit',
                    'offset': 'offset',
                },
                'location_map': {
                    'limit': 'query',
                    'offset': 'query',
                },
                'collection_format_map': {
                }
            },
            headers_map={
                'accept': [
                    'application/json'
                ],
                'content_type': [],
            },
            api_client=api_client
        )
        self.send_transaction_endpoint = _Endpoint(
            settings={
                'response_type': (str,),
                'auth': [],
                'endpoint_path': '/transactions',
                'operation_id': 'send_transaction',
                'http_method': 'POST',
                'servers': None,
            },
            params_map={
                'all': [
                    'ergo_transaction',
                ],
                'required': [
                    'ergo_transaction',
                ],
                'nullable': [
                ],
                'enum': [
                ],
                'validation': [
                ]
            },
            root_map={
                'validations': {
                },
                'allowed_values': {
                },
                'openapi_types': {
                    'ergo_transaction':
                        (ErgoTransaction,),
                },
                'attribute_map': {
                },
                'location_map': {
                    'ergo_transaction': 'body',
                },
                'collection_format_map': {
                }
            },
            headers_map={
                'accept': [
                    'application/json'
                ],
                'content_type': [
                    'application/json'
                ]
            },
            api_client=api_client
        )

    def check_transaction(
        self,
        ergo_transaction,
        **kwargs
    ):
        """Checks an Ergo transaction without sending it over the network. Checks that transaction is valid and its inputs are in the UTXO set. Returns transaction identifier if the transaction is passing the checks.  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True

        >>> thread = api.check_transaction(ergo_transaction, async_req=True)
        >>> result = thread.get()

        Args:
            ergo_transaction (ErgoTransaction):

        Keyword Args:
            _return_http_data_only (bool): response data without head status
                code and headers. Default is True.
            _preload_content (bool): if False, the urllib3.HTTPResponse object
                will be returned without reading/decoding response data.
                Default is True.
            _request_timeout (int/float/tuple): timeout setting for this request. If
                one number provided, it will be total request timeout. It can also
                be a pair (tuple) of (connection, read) timeouts.
                Default is None.
            _check_input_type (bool): specifies if type checking
                should be done one the data sent to the server.
                Default is True.
            _check_return_type (bool): specifies if type checking
                should be done one the data received from the server.
                Default is True.
            _host_index (int/None): specifies the index of the server
                that we want to use.
                Default is read from the configuration.
            async_req (bool): execute request asynchronously

        Returns:
            str
                If the method is called asynchronously, returns the request
                thread.
        """
        kwargs['async_req'] = kwargs.get(
            'async_req', False
        )
        kwargs['_return_http_data_only'] = kwargs.get(
            '_return_http_data_only', True
        )
        kwargs['_preload_content'] = kwargs.get(
            '_preload_content', True
        )
        kwargs['_request_timeout'] = kwargs.get(
            '_request_timeout', None
        )
        kwargs['_check_input_type'] = kwargs.get(
            '_check_input_type', True
        )
        kwargs['_check_return_type'] = kwargs.get(
            '_check_return_type', True
        )
        kwargs['_host_index'] = kwargs.get('_host_index')
        kwargs['ergo_transaction'] = \
            ergo_transaction
        return self.check_transaction_endpoint.call_with_http_info(**kwargs)

    def get_expected_wait_time(
        self,
        fee=1,
        tx_size=100,
        **kwargs
    ):
        """Get expected wait time for the transaction with specified fee and size  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True

        >>> thread = api.get_expected_wait_time(fee=1, tx_size=100, async_req=True)
        >>> result = thread.get()

        Args:
            fee (int): Transaction fee (in nanoErgs). defaults to 1, must be one of [1]
            tx_size (int): Transaction size. defaults to 100, must be one of [100]

        Keyword Args:
            _return_http_data_only (bool): response data without head status
                code and headers. Default is True.
            _preload_content (bool): if False, the urllib3.HTTPResponse object
                will be returned without reading/decoding response data.
                Default is True.
            _request_timeout (int/float/tuple): timeout setting for this request. If
                one number provided, it will be total request timeout. It can also
                be a pair (tuple) of (connection, read) timeouts.
                Default is None.
            _check_input_type (bool): specifies if type checking
                should be done one the data sent to the server.
                Default is True.
            _check_return_type (bool): specifies if type checking
                should be done one the data received from the server.
                Default is True.
            _host_index (int/None): specifies the index of the server
                that we want to use.
                Default is read from the configuration.
            async_req (bool): execute request asynchronously

        Returns:
            int
                If the method is called asynchronously, returns the request
                thread.
        """
        kwargs['async_req'] = kwargs.get(
            'async_req', False
        )
        kwargs['_return_http_data_only'] = kwargs.get(
            '_return_http_data_only', True
        )
        kwargs['_preload_content'] = kwargs.get(
            '_preload_content', True
        )
        kwargs['_request_timeout'] = kwargs.get(
            '_request_timeout', None
        )
        kwargs['_check_input_type'] = kwargs.get(
            '_check_input_type', True
        )
        kwargs['_check_return_type'] = kwargs.get(
            '_check_return_type', True
        )
        kwargs['_host_index'] = kwargs.get('_host_index')
        kwargs['fee'] = \
            fee
        kwargs['tx_size'] = \
            tx_size
        return self.get_expected_wait_time_endpoint.call_with_http_info(**kwargs)

    def get_fee_histogram(
        self,
        **kwargs
    ):
        """Get histogram (waittime, (n_trans, sum(fee)) for transactions in mempool. It contains \"bins\"+1 bins, where i-th elements corresponds to transaction with wait time [i*maxtime/bins, (i+1)*maxtime/bins), and last bin corresponds to the transactions with wait time >= maxtime.  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True

        >>> thread = api.get_fee_histogram(async_req=True)
        >>> result = thread.get()


        Keyword Args:
            bins (int): The number of bins in histogram. [optional] if omitted the server will use the default value of 10
            maxtime (int): Maximal wait time in milliseconds. [optional] if omitted the server will use the default value of 60000
            _return_http_data_only (bool): response data without head status
                code and headers. Default is True.
            _preload_content (bool): if False, the urllib3.HTTPResponse object
                will be returned without reading/decoding response data.
                Default is True.
            _request_timeout (int/float/tuple): timeout setting for this request. If
                one number provided, it will be total request timeout. It can also
                be a pair (tuple) of (connection, read) timeouts.
                Default is None.
            _check_input_type (bool): specifies if type checking
                should be done one the data sent to the server.
                Default is True.
            _check_return_type (bool): specifies if type checking
                should be done one the data received from the server.
                Default is True.
            _host_index (int/None): specifies the index of the server
                that we want to use.
                Default is read from the configuration.
            async_req (bool): execute request asynchronously

        Returns:
            FeeHistogram
                If the method is called asynchronously, returns the request
                thread.
        """
        kwargs['async_req'] = kwargs.get(
            'async_req', False
        )
        kwargs['_return_http_data_only'] = kwargs.get(
            '_return_http_data_only', True
        )
        kwargs['_preload_content'] = kwargs.get(
            '_preload_content', True
        )
        kwargs['_request_timeout'] = kwargs.get(
            '_request_timeout', None
        )
        kwargs['_check_input_type'] = kwargs.get(
            '_check_input_type', True
        )
        kwargs['_check_return_type'] = kwargs.get(
            '_check_return_type', True
        )
        kwargs['_host_index'] = kwargs.get('_host_index')
        return self.get_fee_histogram_endpoint.call_with_http_info(**kwargs)

    def get_recommended_fee(
        self,
        wait_time=1,
        tx_size=100,
        **kwargs
    ):
        """Get recommended fee (in nanoErgs) for a transaction with specified size (in bytes) to be proceeded in specified time (in minutes)  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True

        >>> thread = api.get_recommended_fee(wait_time=1, tx_size=100, async_req=True)
        >>> result = thread.get()

        Args:
            wait_time (int): Maximum transaction wait time in minutes. defaults to 1, must be one of [1]
            tx_size (int): Transaction size. defaults to 100, must be one of [100]

        Keyword Args:
            _return_http_data_only (bool): response data without head status
                code and headers. Default is True.
            _preload_content (bool): if False, the urllib3.HTTPResponse object
                will be returned without reading/decoding response data.
                Default is True.
            _request_timeout (int/float/tuple): timeout setting for this request. If
                one number provided, it will be total request timeout. It can also
                be a pair (tuple) of (connection, read) timeouts.
                Default is None.
            _check_input_type (bool): specifies if type checking
                should be done one the data sent to the server.
                Default is True.
            _check_return_type (bool): specifies if type checking
                should be done one the data received from the server.
                Default is True.
            _host_index (int/None): specifies the index of the server
                that we want to use.
                Default is read from the configuration.
            async_req (bool): execute request asynchronously

        Returns:
            int
                If the method is called asynchronously, returns the request
                thread.
        """
        kwargs['async_req'] = kwargs.get(
            'async_req', False
        )
        kwargs['_return_http_data_only'] = kwargs.get(
            '_return_http_data_only', True
        )
        kwargs['_preload_content'] = kwargs.get(
            '_preload_content', True
        )
        kwargs['_request_timeout'] = kwargs.get(
            '_request_timeout', None
        )
        kwargs['_check_input_type'] = kwargs.get(
            '_check_input_type', True
        )
        kwargs['_check_return_type'] = kwargs.get(
            '_check_return_type', True
        )
        kwargs['_host_index'] = kwargs.get('_host_index')
        kwargs['wait_time'] = \
            wait_time
        kwargs['tx_size'] = \
            tx_size
        return self.get_recommended_fee_endpoint.call_with_http_info(**kwargs)

    def get_unconfirmed_transactions(
        self,
        **kwargs
    ):
        """Get current pool of the unconfirmed transactions pool  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True

        >>> thread = api.get_unconfirmed_transactions(async_req=True)
        >>> result = thread.get()


        Keyword Args:
            limit (int): The number of items in list to return. [optional] if omitted the server will use the default value of 50
            offset (int): The number of items in list to skip. [optional] if omitted the server will use the default value of 0
            _return_http_data_only (bool): response data without head status
                code and headers. Default is True.
            _preload_content (bool): if False, the urllib3.HTTPResponse object
                will be returned without reading/decoding response data.
                Default is True.
            _request_timeout (int/float/tuple): timeout setting for this request. If
                one number provided, it will be total request timeout. It can also
                be a pair (tuple) of (connection, read) timeouts.
                Default is None.
            _check_input_type (bool): specifies if type checking
                should be done one the data sent to the server.
                Default is True.
            _check_return_type (bool): specifies if type checking
                should be done one the data received from the server.
                Default is True.
            _host_index (int/None): specifies the index of the server
                that we want to use.
                Default is read from the configuration.
            async_req (bool): execute request asynchronously

        Returns:
            Transactions
                If the method is called asynchronously, returns the request
                thread.
        """
        kwargs['async_req'] = kwargs.get(
            'async_req', False
        )
        kwargs['_return_http_data_only'] = kwargs.get(
            '_return_http_data_only', True
        )
        kwargs['_preload_content'] = kwargs.get(
            '_preload_content', True
        )
        kwargs['_request_timeout'] = kwargs.get(
            '_request_timeout', None
        )
        kwargs['_check_input_type'] = kwargs.get(
            '_check_input_type', True
        )
        kwargs['_check_return_type'] = kwargs.get(
            '_check_return_type', True
        )
        kwargs['_host_index'] = kwargs.get('_host_index')
        return self.get_unconfirmed_transactions_endpoint.call_with_http_info(**kwargs)

    def send_transaction(
        self,
        ergo_transaction,
        **kwargs
    ):
        """Submit an Ergo transaction to unconfirmed pool to send it over the network  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True

        >>> thread = api.send_transaction(ergo_transaction, async_req=True)
        >>> result = thread.get()

        Args:
            ergo_transaction (ErgoTransaction):

        Keyword Args:
            _return_http_data_only (bool): response data without head status
                code and headers. Default is True.
            _preload_content (bool): if False, the urllib3.HTTPResponse object
                will be returned without reading/decoding response data.
                Default is True.
            _request_timeout (int/float/tuple): timeout setting for this request. If
                one number provided, it will be total request timeout. It can also
                be a pair (tuple) of (connection, read) timeouts.
                Default is None.
            _check_input_type (bool): specifies if type checking
                should be done one the data sent to the server.
                Default is True.
            _check_return_type (bool): specifies if type checking
                should be done one the data received from the server.
                Default is True.
            _host_index (int/None): specifies the index of the server
                that we want to use.
                Default is read from the configuration.
            async_req (bool): execute request asynchronously

        Returns:
            str
                If the method is called asynchronously, returns the request
                thread.
        """
        kwargs['async_req'] = kwargs.get(
            'async_req', False
        )
        kwargs['_return_http_data_only'] = kwargs.get(
            '_return_http_data_only', True
        )
        kwargs['_preload_content'] = kwargs.get(
            '_preload_content', True
        )
        kwargs['_request_timeout'] = kwargs.get(
            '_request_timeout', None
        )
        kwargs['_check_input_type'] = kwargs.get(
            '_check_input_type', True
        )
        kwargs['_check_return_type'] = kwargs.get(
            '_check_return_type', True
        )
        kwargs['_host_index'] = kwargs.get('_host_index')
        kwargs['ergo_transaction'] = \
            ergo_transaction
        return self.send_transaction_endpoint.call_with_http_info(**kwargs)

