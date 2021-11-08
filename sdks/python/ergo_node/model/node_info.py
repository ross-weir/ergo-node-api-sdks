"""
    Ergo Node API

    API docs for Ergo Node. Models are shared between all Ergo products  # noqa: E501

    The version of the OpenAPI document: 4.0.15
    Contact: ergoplatform@protonmail.com
    Generated by: https://openapi-generator.tech
"""


import re  # noqa: F401
import sys  # noqa: F401

from ergo_node.model_utils import (  # noqa: F401
    ApiTypeError,
    ModelComposed,
    ModelNormal,
    ModelSimple,
    cached_property,
    change_keys_js_to_python,
    convert_js_args_to_python_args,
    date,
    datetime,
    file_type,
    none_type,
    validate_get_composed_info,
)
from ..model_utils import OpenApiModel
from ergo_node.exceptions import ApiAttributeError


def lazy_import():
    from ergo_node.model.parameters import Parameters
    globals()['Parameters'] = Parameters


class NodeInfo(ModelNormal):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.

    Attributes:
      allowed_values (dict): The key is the tuple path to the attribute
          and the for var_name this is (var_name,). The value is a dict
          with a capitalized key describing the allowed value and an allowed
          value. These dicts store the allowed enum values.
      attribute_map (dict): The key is attribute name
          and the value is json key in definition.
      discriminator_value_class_map (dict): A dict to go from the discriminator
          variable value to the discriminator class name.
      validations (dict): The key is the tuple path to the attribute
          and the for var_name this is (var_name,). The value is a dict
          that stores validations for max_length, min_length, max_items,
          min_items, exclusive_maximum, inclusive_maximum, exclusive_minimum,
          inclusive_minimum, and regex.
      additional_properties_type (tuple): A tuple of classes accepted
          as additional properties values.
    """

    allowed_values = {
        ('state_type',): {
            'DIGEST': "digest",
            'UTXO': "utxo",
        },
    }

    validations = {
        ('full_height',): {
            'inclusive_minimum': 0,
        },
        ('headers_height',): {
            'inclusive_minimum': 0,
        },
        ('peers_count',): {
            'inclusive_minimum': 0,
        },
        ('unconfirmed_count',): {
            'inclusive_maximum': 10000,
            'inclusive_minimum': 0,
        },
        ('difficulty',): {
            'inclusive_minimum': 0,
        },
    }

    @cached_property
    def additional_properties_type():
        """
        This must be a method because a model may have properties that are
        of type self, this must run after the class is loaded
        """
        lazy_import()
        return (bool, date, datetime, dict, float, int, list, str, none_type,)  # noqa: E501

    _nullable = False

    @cached_property
    def openapi_types():
        """
        This must be a method because a model may have properties that are
        of type self, this must run after the class is loaded

        Returns
            openapi_types (dict): The key is attribute name
                and the value is attribute type.
        """
        lazy_import()
        return {
            'name': (str,),  # noqa: E501
            'app_version': (str,),  # noqa: E501
            'full_height': (int, none_type,),  # noqa: E501
            'headers_height': (int, none_type,),  # noqa: E501
            'best_full_header_id': (str, none_type,),  # noqa: E501
            'previous_full_header_id': (str, none_type,),  # noqa: E501
            'best_header_id': (str, none_type,),  # noqa: E501
            'state_root': (str, none_type,),  # noqa: E501
            'state_type': (str,),  # noqa: E501
            'state_version': (str, none_type,),  # noqa: E501
            'is_mining': (bool,),  # noqa: E501
            'peers_count': (int,),  # noqa: E501
            'unconfirmed_count': (int,),  # noqa: E501
            'difficulty': (int, none_type,),  # noqa: E501
            'current_time': (int,),  # noqa: E501
            'launch_time': (int,),  # noqa: E501
            'headers_score': (int, none_type,),  # noqa: E501
            'full_blocks_score': (int, none_type,),  # noqa: E501
            'genesis_block_id': (str, none_type,),  # noqa: E501
            'parameters': (Parameters,),  # noqa: E501
        }

    @cached_property
    def discriminator():
        return None


    attribute_map = {
        'name': 'name',  # noqa: E501
        'app_version': 'appVersion',  # noqa: E501
        'full_height': 'fullHeight',  # noqa: E501
        'headers_height': 'headersHeight',  # noqa: E501
        'best_full_header_id': 'bestFullHeaderId',  # noqa: E501
        'previous_full_header_id': 'previousFullHeaderId',  # noqa: E501
        'best_header_id': 'bestHeaderId',  # noqa: E501
        'state_root': 'stateRoot',  # noqa: E501
        'state_type': 'stateType',  # noqa: E501
        'state_version': 'stateVersion',  # noqa: E501
        'is_mining': 'isMining',  # noqa: E501
        'peers_count': 'peersCount',  # noqa: E501
        'unconfirmed_count': 'unconfirmedCount',  # noqa: E501
        'difficulty': 'difficulty',  # noqa: E501
        'current_time': 'currentTime',  # noqa: E501
        'launch_time': 'launchTime',  # noqa: E501
        'headers_score': 'headersScore',  # noqa: E501
        'full_blocks_score': 'fullBlocksScore',  # noqa: E501
        'genesis_block_id': 'genesisBlockId',  # noqa: E501
        'parameters': 'parameters',  # noqa: E501
    }

    read_only_vars = {
    }

    _composed_schemas = {}

    @classmethod
    @convert_js_args_to_python_args
    def _from_openapi_data(cls, name, app_version, full_height, headers_height, best_full_header_id, previous_full_header_id, best_header_id, state_root, state_type, state_version, is_mining, peers_count, unconfirmed_count, difficulty, current_time, launch_time, headers_score, full_blocks_score, genesis_block_id, parameters, *args, **kwargs):  # noqa: E501
        """NodeInfo - a model defined in OpenAPI

        Args:
            name (str):
            app_version (str):
            full_height (int, none_type): Can be 'null' if state is empty (no full block is applied since node launch)
            headers_height (int, none_type): Can be 'null' if state is empty (no header applied since node launch)
            best_full_header_id (str, none_type): Can be 'null' if no full block is applied since node launch
            previous_full_header_id (str, none_type): Can be 'null' if no full block is applied since node launch
            best_header_id (str, none_type): Can be 'null' if no header applied since node launch
            state_root (str, none_type): Can be 'null' if state is empty (no full block is applied since node launch)
            state_type (str):
            state_version (str, none_type): Can be 'null' if no full block is applied since node launch
            is_mining (bool):
            peers_count (int): Number of connected peers
            unconfirmed_count (int): Current unconfirmed transactions count
            difficulty (int, none_type): Difficulty on current bestFullHeaderId. Can be 'null' if no full block is applied since node launch
            current_time (int): Current internal node time
            launch_time (int): Time when the node was started
            headers_score (int, none_type): Can be 'null' if no headers is applied since node launch
            full_blocks_score (int, none_type): Can be 'null' if no full block is applied since node launch
            genesis_block_id (str, none_type): Can be 'null' if genesis blocks is not produced yet
            parameters (Parameters):

        Keyword Args:
            _check_type (bool): if True, values for parameters in openapi_types
                                will be type checked and a TypeError will be
                                raised if the wrong type is input.
                                Defaults to True
            _path_to_item (tuple/list): This is a list of keys or values to
                                drill down to the model in received_data
                                when deserializing a response
            _spec_property_naming (bool): True if the variable names in the input data
                                are serialized names, as specified in the OpenAPI document.
                                False if the variable names in the input data
                                are pythonic names, e.g. snake case (default)
            _configuration (Configuration): the instance to use when
                                deserializing a file_type parameter.
                                If passed, type conversion is attempted
                                If omitted no type conversion is done.
            _visited_composed_classes (tuple): This stores a tuple of
                                classes that we have traveled through so that
                                if we see that class again we will not use its
                                discriminator again.
                                When traveling through a discriminator, the
                                composed schema that is
                                is traveled through is added to this set.
                                For example if Animal has a discriminator
                                petType and we pass in "Dog", and the class Dog
                                allOf includes Animal, we move through Animal
                                once using the discriminator, and pick Dog.
                                Then in Dog, we will make an instance of the
                                Animal class but this time we won't travel
                                through its discriminator because we passed in
                                _visited_composed_classes = (Animal,)
        """

        _check_type = kwargs.pop('_check_type', True)
        _spec_property_naming = kwargs.pop('_spec_property_naming', False)
        _path_to_item = kwargs.pop('_path_to_item', ())
        _configuration = kwargs.pop('_configuration', None)
        _visited_composed_classes = kwargs.pop('_visited_composed_classes', ())

        self = super(OpenApiModel, cls).__new__(cls)

        if args:
            raise ApiTypeError(
                "Invalid positional arguments=%s passed to %s. Remove those invalid positional arguments." % (
                    args,
                    self.__class__.__name__,
                ),
                path_to_item=_path_to_item,
                valid_classes=(self.__class__,),
            )

        self._data_store = {}
        self._check_type = _check_type
        self._spec_property_naming = _spec_property_naming
        self._path_to_item = _path_to_item
        self._configuration = _configuration
        self._visited_composed_classes = _visited_composed_classes + (self.__class__,)

        self.name = name
        self.app_version = app_version
        self.full_height = full_height
        self.headers_height = headers_height
        self.best_full_header_id = best_full_header_id
        self.previous_full_header_id = previous_full_header_id
        self.best_header_id = best_header_id
        self.state_root = state_root
        self.state_type = state_type
        self.state_version = state_version
        self.is_mining = is_mining
        self.peers_count = peers_count
        self.unconfirmed_count = unconfirmed_count
        self.difficulty = difficulty
        self.current_time = current_time
        self.launch_time = launch_time
        self.headers_score = headers_score
        self.full_blocks_score = full_blocks_score
        self.genesis_block_id = genesis_block_id
        self.parameters = parameters
        for var_name, var_value in kwargs.items():
            if var_name not in self.attribute_map and \
                        self._configuration is not None and \
                        self._configuration.discard_unknown_keys and \
                        self.additional_properties_type is None:
                # discard variable.
                continue
            setattr(self, var_name, var_value)
        return self

    required_properties = set([
        '_data_store',
        '_check_type',
        '_spec_property_naming',
        '_path_to_item',
        '_configuration',
        '_visited_composed_classes',
    ])

    @convert_js_args_to_python_args
    def __init__(self, name, app_version, full_height, headers_height, best_full_header_id, previous_full_header_id, best_header_id, state_root, state_type, state_version, is_mining, peers_count, unconfirmed_count, difficulty, current_time, launch_time, headers_score, full_blocks_score, genesis_block_id, parameters, *args, **kwargs):  # noqa: E501
        """NodeInfo - a model defined in OpenAPI

        Args:
            name (str):
            app_version (str):
            full_height (int, none_type): Can be 'null' if state is empty (no full block is applied since node launch)
            headers_height (int, none_type): Can be 'null' if state is empty (no header applied since node launch)
            best_full_header_id (str, none_type): Can be 'null' if no full block is applied since node launch
            previous_full_header_id (str, none_type): Can be 'null' if no full block is applied since node launch
            best_header_id (str, none_type): Can be 'null' if no header applied since node launch
            state_root (str, none_type): Can be 'null' if state is empty (no full block is applied since node launch)
            state_type (str):
            state_version (str, none_type): Can be 'null' if no full block is applied since node launch
            is_mining (bool):
            peers_count (int): Number of connected peers
            unconfirmed_count (int): Current unconfirmed transactions count
            difficulty (int, none_type): Difficulty on current bestFullHeaderId. Can be 'null' if no full block is applied since node launch
            current_time (int): Current internal node time
            launch_time (int): Time when the node was started
            headers_score (int, none_type): Can be 'null' if no headers is applied since node launch
            full_blocks_score (int, none_type): Can be 'null' if no full block is applied since node launch
            genesis_block_id (str, none_type): Can be 'null' if genesis blocks is not produced yet
            parameters (Parameters):

        Keyword Args:
            _check_type (bool): if True, values for parameters in openapi_types
                                will be type checked and a TypeError will be
                                raised if the wrong type is input.
                                Defaults to True
            _path_to_item (tuple/list): This is a list of keys or values to
                                drill down to the model in received_data
                                when deserializing a response
            _spec_property_naming (bool): True if the variable names in the input data
                                are serialized names, as specified in the OpenAPI document.
                                False if the variable names in the input data
                                are pythonic names, e.g. snake case (default)
            _configuration (Configuration): the instance to use when
                                deserializing a file_type parameter.
                                If passed, type conversion is attempted
                                If omitted no type conversion is done.
            _visited_composed_classes (tuple): This stores a tuple of
                                classes that we have traveled through so that
                                if we see that class again we will not use its
                                discriminator again.
                                When traveling through a discriminator, the
                                composed schema that is
                                is traveled through is added to this set.
                                For example if Animal has a discriminator
                                petType and we pass in "Dog", and the class Dog
                                allOf includes Animal, we move through Animal
                                once using the discriminator, and pick Dog.
                                Then in Dog, we will make an instance of the
                                Animal class but this time we won't travel
                                through its discriminator because we passed in
                                _visited_composed_classes = (Animal,)
        """

        _check_type = kwargs.pop('_check_type', True)
        _spec_property_naming = kwargs.pop('_spec_property_naming', False)
        _path_to_item = kwargs.pop('_path_to_item', ())
        _configuration = kwargs.pop('_configuration', None)
        _visited_composed_classes = kwargs.pop('_visited_composed_classes', ())

        if args:
            raise ApiTypeError(
                "Invalid positional arguments=%s passed to %s. Remove those invalid positional arguments." % (
                    args,
                    self.__class__.__name__,
                ),
                path_to_item=_path_to_item,
                valid_classes=(self.__class__,),
            )

        self._data_store = {}
        self._check_type = _check_type
        self._spec_property_naming = _spec_property_naming
        self._path_to_item = _path_to_item
        self._configuration = _configuration
        self._visited_composed_classes = _visited_composed_classes + (self.__class__,)

        self.name = name
        self.app_version = app_version
        self.full_height = full_height
        self.headers_height = headers_height
        self.best_full_header_id = best_full_header_id
        self.previous_full_header_id = previous_full_header_id
        self.best_header_id = best_header_id
        self.state_root = state_root
        self.state_type = state_type
        self.state_version = state_version
        self.is_mining = is_mining
        self.peers_count = peers_count
        self.unconfirmed_count = unconfirmed_count
        self.difficulty = difficulty
        self.current_time = current_time
        self.launch_time = launch_time
        self.headers_score = headers_score
        self.full_blocks_score = full_blocks_score
        self.genesis_block_id = genesis_block_id
        self.parameters = parameters
        for var_name, var_value in kwargs.items():
            if var_name not in self.attribute_map and \
                        self._configuration is not None and \
                        self._configuration.discard_unknown_keys and \
                        self.additional_properties_type is None:
                # discard variable.
                continue
            setattr(self, var_name, var_value)
            if var_name in self.read_only_vars:
                raise ApiAttributeError(f"`{var_name}` is a read-only attribute. Use `from_openapi_data` to instantiate "
                                     f"class with read only attributes.")
