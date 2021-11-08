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



class BlockHeaderWithoutPow(ModelNormal):
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
    }

    validations = {
        ('n_bits',): {
            'inclusive_minimum': 0,
        },
        ('height',): {
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
        return {
            'id': (str,),  # noqa: E501
            'timestamp': (int,),  # noqa: E501
            'version': (int,),  # noqa: E501
            'ad_proofs_root': (str,),  # noqa: E501
            'state_root': (str,),  # noqa: E501
            'transactions_root': (str,),  # noqa: E501
            'n_bits': (int,),  # noqa: E501
            'extension_hash': (str,),  # noqa: E501
            'height': (int,),  # noqa: E501
            'difficulty': (int,),  # noqa: E501
            'parent_id': (str,),  # noqa: E501
            'votes': (str,),  # noqa: E501
            'size': (int,),  # noqa: E501
            'extension_id': (str,),  # noqa: E501
            'transactions_id': (str,),  # noqa: E501
            'ad_proofs_id': (str,),  # noqa: E501
        }

    @cached_property
    def discriminator():
        return None


    attribute_map = {
        'id': 'id',  # noqa: E501
        'timestamp': 'timestamp',  # noqa: E501
        'version': 'version',  # noqa: E501
        'ad_proofs_root': 'adProofsRoot',  # noqa: E501
        'state_root': 'stateRoot',  # noqa: E501
        'transactions_root': 'transactionsRoot',  # noqa: E501
        'n_bits': 'nBits',  # noqa: E501
        'extension_hash': 'extensionHash',  # noqa: E501
        'height': 'height',  # noqa: E501
        'difficulty': 'difficulty',  # noqa: E501
        'parent_id': 'parentId',  # noqa: E501
        'votes': 'votes',  # noqa: E501
        'size': 'size',  # noqa: E501
        'extension_id': 'extensionId',  # noqa: E501
        'transactions_id': 'transactionsId',  # noqa: E501
        'ad_proofs_id': 'adProofsId',  # noqa: E501
    }

    read_only_vars = {
    }

    _composed_schemas = {}

    @classmethod
    @convert_js_args_to_python_args
    def _from_openapi_data(cls, id, timestamp, version, ad_proofs_root, state_root, transactions_root, n_bits, extension_hash, height, difficulty, parent_id, votes, *args, **kwargs):  # noqa: E501
        """BlockHeaderWithoutPow - a model defined in OpenAPI

        Args:
            id (str): Base16-encoded 32 byte modifier id
            timestamp (int): Basic timestamp definition
            version (int): Ergo blockchain protocol version
            ad_proofs_root (str): Base16-encoded 32 byte digest
            state_root (str): Base16-encoded 33 byte digest - digest with extra byte with tree height
            transactions_root (str): Base16-encoded 32 byte digest
            n_bits (int):
            extension_hash (str): Base16-encoded 32 byte digest
            height (int):
            difficulty (int):
            parent_id (str): Base16-encoded 32 byte modifier id
            votes (str): Base16-encoded votes for a soft-fork and parameters

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
            size (int): Size in bytes. [optional]  # noqa: E501
            extension_id (str): Base16-encoded 32 byte modifier id. [optional]  # noqa: E501
            transactions_id (str): Base16-encoded 32 byte modifier id. [optional]  # noqa: E501
            ad_proofs_id (str): Base16-encoded 32 byte modifier id. [optional]  # noqa: E501
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

        self.id = id
        self.timestamp = timestamp
        self.version = version
        self.ad_proofs_root = ad_proofs_root
        self.state_root = state_root
        self.transactions_root = transactions_root
        self.n_bits = n_bits
        self.extension_hash = extension_hash
        self.height = height
        self.difficulty = difficulty
        self.parent_id = parent_id
        self.votes = votes
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
    def __init__(self, id, timestamp, version, ad_proofs_root, state_root, transactions_root, n_bits, extension_hash, height, difficulty, parent_id, votes, *args, **kwargs):  # noqa: E501
        """BlockHeaderWithoutPow - a model defined in OpenAPI

        Args:
            id (str): Base16-encoded 32 byte modifier id
            timestamp (int): Basic timestamp definition
            version (int): Ergo blockchain protocol version
            ad_proofs_root (str): Base16-encoded 32 byte digest
            state_root (str): Base16-encoded 33 byte digest - digest with extra byte with tree height
            transactions_root (str): Base16-encoded 32 byte digest
            n_bits (int):
            extension_hash (str): Base16-encoded 32 byte digest
            height (int):
            difficulty (int):
            parent_id (str): Base16-encoded 32 byte modifier id
            votes (str): Base16-encoded votes for a soft-fork and parameters

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
            size (int): Size in bytes. [optional]  # noqa: E501
            extension_id (str): Base16-encoded 32 byte modifier id. [optional]  # noqa: E501
            transactions_id (str): Base16-encoded 32 byte modifier id. [optional]  # noqa: E501
            ad_proofs_id (str): Base16-encoded 32 byte modifier id. [optional]  # noqa: E501
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

        self.id = id
        self.timestamp = timestamp
        self.version = version
        self.ad_proofs_root = ad_proofs_root
        self.state_root = state_root
        self.transactions_root = transactions_root
        self.n_bits = n_bits
        self.extension_hash = extension_hash
        self.height = height
        self.difficulty = difficulty
        self.parent_id = parent_id
        self.votes = votes
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
