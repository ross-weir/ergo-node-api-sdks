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
from ergo_node.model.scan import Scan
from ergo_node.model.scan_id import ScanId
from ergo_node.model.scan_id_box_id import ScanIdBoxId
from ergo_node.model.scan_ids_box import ScanIdsBox
from ergo_node.model.scan_request import ScanRequest
from ergo_node.model.wallet_box import WalletBox


class ScanApi(object):
    """NOTE: This class is auto generated by OpenAPI Generator
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    def __init__(self, api_client=None):
        if api_client is None:
            api_client = ApiClient()
        self.api_client = api_client
        self.add_box_endpoint = _Endpoint(
            settings={
                'response_type': (str,),
                'auth': [
                    'ApiKeyAuth'
                ],
                'endpoint_path': '/scan/addBox',
                'operation_id': 'add_box',
                'http_method': 'POST',
                'servers': None,
            },
            params_map={
                'all': [
                    'scan_ids_box',
                ],
                'required': [
                    'scan_ids_box',
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
                    'scan_ids_box':
                        (ScanIdsBox,),
                },
                'attribute_map': {
                },
                'location_map': {
                    'scan_ids_box': 'body',
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
        self.deregister_scan_endpoint = _Endpoint(
            settings={
                'response_type': (ScanId,),
                'auth': [
                    'ApiKeyAuth'
                ],
                'endpoint_path': '/scan/deregister',
                'operation_id': 'deregister_scan',
                'http_method': 'POST',
                'servers': None,
            },
            params_map={
                'all': [
                    'scan_id',
                ],
                'required': [
                    'scan_id',
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
                    'scan_id':
                        (ScanId,),
                },
                'attribute_map': {
                },
                'location_map': {
                    'scan_id': 'body',
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
        self.list_all_scans_endpoint = _Endpoint(
            settings={
                'response_type': ([Scan],),
                'auth': [
                    'ApiKeyAuth'
                ],
                'endpoint_path': '/scan/listAll',
                'operation_id': 'list_all_scans',
                'http_method': 'GET',
                'servers': None,
            },
            params_map={
                'all': [
                ],
                'required': [],
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
                },
                'attribute_map': {
                },
                'location_map': {
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
        self.list_unspent_scans_endpoint = _Endpoint(
            settings={
                'response_type': ([WalletBox],),
                'auth': [
                    'ApiKeyAuth'
                ],
                'endpoint_path': '/scan/unspentBoxes/{scanId}',
                'operation_id': 'list_unspent_scans',
                'http_method': 'GET',
                'servers': None,
            },
            params_map={
                'all': [
                    'scan_id',
                    'min_confirmations',
                    'min_inclusion_height',
                ],
                'required': [
                    'scan_id',
                ],
                'nullable': [
                ],
                'enum': [
                ],
                'validation': [
                    'min_confirmations',
                    'min_inclusion_height',
                ]
            },
            root_map={
                'validations': {
                    ('min_confirmations',): {

                        'inclusive_minimum': -1,
                    },
                    ('min_inclusion_height',): {

                        'inclusive_minimum': 0,
                    },
                },
                'allowed_values': {
                },
                'openapi_types': {
                    'scan_id':
                        (int,),
                    'min_confirmations':
                        (int,),
                    'min_inclusion_height':
                        (int,),
                },
                'attribute_map': {
                    'scan_id': 'scanId',
                    'min_confirmations': 'minConfirmations',
                    'min_inclusion_height': 'minInclusionHeight',
                },
                'location_map': {
                    'scan_id': 'path',
                    'min_confirmations': 'query',
                    'min_inclusion_height': 'query',
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
        self.register_scan_endpoint = _Endpoint(
            settings={
                'response_type': (ScanId,),
                'auth': [
                    'ApiKeyAuth'
                ],
                'endpoint_path': '/scan/register',
                'operation_id': 'register_scan',
                'http_method': 'POST',
                'servers': None,
            },
            params_map={
                'all': [
                    'scan_request',
                ],
                'required': [
                    'scan_request',
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
                    'scan_request':
                        (ScanRequest,),
                },
                'attribute_map': {
                },
                'location_map': {
                    'scan_request': 'body',
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
        self.scan_stop_tracking_endpoint = _Endpoint(
            settings={
                'response_type': (ScanIdBoxId,),
                'auth': [
                    'ApiKeyAuth'
                ],
                'endpoint_path': '/scan/stopTracking',
                'operation_id': 'scan_stop_tracking',
                'http_method': 'POST',
                'servers': None,
            },
            params_map={
                'all': [
                    'scan_id_box_id',
                ],
                'required': [
                    'scan_id_box_id',
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
                    'scan_id_box_id':
                        (ScanIdBoxId,),
                },
                'attribute_map': {
                },
                'location_map': {
                    'scan_id_box_id': 'body',
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

    def add_box(
        self,
        scan_ids_box,
        **kwargs
    ):
        """Adds a box to scans, writes box to database if it is not there. You can use scan number 10 to add a box to the wallet.  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True

        >>> thread = api.add_box(scan_ids_box, async_req=True)
        >>> result = thread.get()

        Args:
            scan_ids_box (ScanIdsBox):

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
        kwargs['scan_ids_box'] = \
            scan_ids_box
        return self.add_box_endpoint.call_with_http_info(**kwargs)

    def deregister_scan(
        self,
        scan_id,
        **kwargs
    ):
        """Stop tracking and deregister scan  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True

        >>> thread = api.deregister_scan(scan_id, async_req=True)
        >>> result = thread.get()

        Args:
            scan_id (ScanId):

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
            ScanId
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
        kwargs['scan_id'] = \
            scan_id
        return self.deregister_scan_endpoint.call_with_http_info(**kwargs)

    def list_all_scans(
        self,
        **kwargs
    ):
        """List all the registered scans  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True

        >>> thread = api.list_all_scans(async_req=True)
        >>> result = thread.get()


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
            [Scan]
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
        return self.list_all_scans_endpoint.call_with_http_info(**kwargs)

    def list_unspent_scans(
        self,
        scan_id,
        **kwargs
    ):
        """List boxes which are not spent.  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True

        >>> thread = api.list_unspent_scans(scan_id, async_req=True)
        >>> result = thread.get()

        Args:
            scan_id (int): identifier of a scan

        Keyword Args:
            min_confirmations (int): Minimal number of confirmations. [optional] if omitted the server will use the default value of 0
            min_inclusion_height (int): Minimal box inclusion height. [optional] if omitted the server will use the default value of 0
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
            [WalletBox]
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
        kwargs['scan_id'] = \
            scan_id
        return self.list_unspent_scans_endpoint.call_with_http_info(**kwargs)

    def register_scan(
        self,
        scan_request,
        **kwargs
    ):
        """Register a scan  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True

        >>> thread = api.register_scan(scan_request, async_req=True)
        >>> result = thread.get()

        Args:
            scan_request (ScanRequest):

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
            ScanId
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
        kwargs['scan_request'] = \
            scan_request
        return self.register_scan_endpoint.call_with_http_info(**kwargs)

    def scan_stop_tracking(
        self,
        scan_id_box_id,
        **kwargs
    ):
        """Stop scan-related box tracking  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True

        >>> thread = api.scan_stop_tracking(scan_id_box_id, async_req=True)
        >>> result = thread.get()

        Args:
            scan_id_box_id (ScanIdBoxId):

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
            ScanIdBoxId
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
        kwargs['scan_id_box_id'] = \
            scan_id_box_id
        return self.scan_stop_tracking_endpoint.call_with_http_info(**kwargs)
