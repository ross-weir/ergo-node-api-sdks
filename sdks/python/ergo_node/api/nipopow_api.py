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
from ergo_node.model.nipopow_proof import NipopowProof
from ergo_node.model.popow_header import PopowHeader


class NipopowApi(object):
    """NOTE: This class is auto generated by OpenAPI Generator
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    def __init__(self, api_client=None):
        if api_client is None:
            api_client = ApiClient()
        self.api_client = api_client
        self.get_popow_header_by_height_endpoint = _Endpoint(
            settings={
                'response_type': (PopowHeader,),
                'auth': [],
                'endpoint_path': '/nipopow/popowHeaderByHeight/{height}',
                'operation_id': 'get_popow_header_by_height',
                'http_method': 'GET',
                'servers': None,
            },
            params_map={
                'all': [
                    'height',
                ],
                'required': [
                    'height',
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
                    'height':
                        (int,),
                },
                'attribute_map': {
                    'height': 'height',
                },
                'location_map': {
                    'height': 'path',
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
        self.get_popow_header_by_id_endpoint = _Endpoint(
            settings={
                'response_type': (PopowHeader,),
                'auth': [],
                'endpoint_path': '/nipopow/popowHeaderById/{headerId}',
                'operation_id': 'get_popow_header_by_id',
                'http_method': 'GET',
                'servers': None,
            },
            params_map={
                'all': [
                    'header_id',
                ],
                'required': [
                    'header_id',
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
                    'header_id':
                        (str,),
                },
                'attribute_map': {
                    'header_id': 'headerId',
                },
                'location_map': {
                    'header_id': 'path',
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
        self.get_popow_proof_endpoint = _Endpoint(
            settings={
                'response_type': (NipopowProof,),
                'auth': [],
                'endpoint_path': '/nipopow/proof/{minChainLength}/{suffixLength}',
                'operation_id': 'get_popow_proof',
                'http_method': 'GET',
                'servers': None,
            },
            params_map={
                'all': [
                    'min_chain_length',
                    'suffix_length',
                ],
                'required': [
                    'min_chain_length',
                    'suffix_length',
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
                    'min_chain_length':
                        (float,),
                    'suffix_length':
                        (float,),
                },
                'attribute_map': {
                    'min_chain_length': 'minChainLength',
                    'suffix_length': 'suffixLength',
                },
                'location_map': {
                    'min_chain_length': 'path',
                    'suffix_length': 'path',
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
        self.get_popow_proof_by_header_id_endpoint = _Endpoint(
            settings={
                'response_type': (NipopowProof,),
                'auth': [],
                'endpoint_path': '/nipopow/proof/{minChainLength}/{suffixLength}/{headerId}',
                'operation_id': 'get_popow_proof_by_header_id',
                'http_method': 'GET',
                'servers': None,
            },
            params_map={
                'all': [
                    'min_chain_length',
                    'suffix_length',
                    'header_id',
                ],
                'required': [
                    'min_chain_length',
                    'suffix_length',
                    'header_id',
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
                    'min_chain_length':
                        (float,),
                    'suffix_length':
                        (float,),
                    'header_id':
                        (str,),
                },
                'attribute_map': {
                    'min_chain_length': 'minChainLength',
                    'suffix_length': 'suffixLength',
                    'header_id': 'headerId',
                },
                'location_map': {
                    'min_chain_length': 'path',
                    'suffix_length': 'path',
                    'header_id': 'path',
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

    def get_popow_header_by_height(
        self,
        height,
        **kwargs
    ):
        """Construct PoPow header for best header at given height  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True

        >>> thread = api.get_popow_header_by_height(height, async_req=True)
        >>> result = thread.get()

        Args:
            height (int): Height of a wanted header

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
            PopowHeader
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
        kwargs['height'] = \
            height
        return self.get_popow_header_by_height_endpoint.call_with_http_info(**kwargs)

    def get_popow_header_by_id(
        self,
        header_id,
        **kwargs
    ):
        """Construct PoPow header according to given header id  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True

        >>> thread = api.get_popow_header_by_id(header_id, async_req=True)
        >>> result = thread.get()

        Args:
            header_id (str): ID of wanted header

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
            PopowHeader
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
        kwargs['header_id'] = \
            header_id
        return self.get_popow_header_by_id_endpoint.call_with_http_info(**kwargs)

    def get_popow_proof(
        self,
        min_chain_length,
        suffix_length,
        **kwargs
    ):
        """Construct PoPoW proof for given min superchain length and suffix length  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True

        >>> thread = api.get_popow_proof(min_chain_length, suffix_length, async_req=True)
        >>> result = thread.get()

        Args:
            min_chain_length (float): Minimal superchain length
            suffix_length (float): Suffix length

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
            NipopowProof
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
        kwargs['min_chain_length'] = \
            min_chain_length
        kwargs['suffix_length'] = \
            suffix_length
        return self.get_popow_proof_endpoint.call_with_http_info(**kwargs)

    def get_popow_proof_by_header_id(
        self,
        min_chain_length,
        suffix_length,
        header_id,
        **kwargs
    ):
        """Construct PoPoW proof for given min superchain length, suffix length and header ID  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True

        >>> thread = api.get_popow_proof_by_header_id(min_chain_length, suffix_length, header_id, async_req=True)
        >>> result = thread.get()

        Args:
            min_chain_length (float): Minimal superchain length
            suffix_length (float): Suffix length
            header_id (str): ID of wanted header

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
            NipopowProof
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
        kwargs['min_chain_length'] = \
            min_chain_length
        kwargs['suffix_length'] = \
            suffix_length
        kwargs['header_id'] = \
            header_id
        return self.get_popow_proof_by_header_id_endpoint.call_with_http_info(**kwargs)

