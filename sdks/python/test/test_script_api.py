"""
    Ergo Node API

    API docs for Ergo Node. Models are shared between all Ergo products  # noqa: E501

    The version of the OpenAPI document: 4.0.15
    Contact: ergoplatform@protonmail.com
    Generated by: https://openapi-generator.tech
"""


import unittest

import openapi_client
from openapi_client.api.script_api import ScriptApi  # noqa: E501


class TestScriptApi(unittest.TestCase):
    """ScriptApi unit test stubs"""

    def setUp(self):
        self.api = ScriptApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_address_to_bytes(self):
        """Test case for address_to_bytes

        Convert an address to hex-encoded Sigma byte array constant which contains script bytes  # noqa: E501
        """
        pass

    def test_address_to_tree(self):
        """Test case for address_to_tree

        Convert an address to hex-encoded serialized ErgoTree (script)  # noqa: E501
        """
        pass

    def test_execute_with_context(self):
        """Test case for execute_with_context

        Execute script with context  # noqa: E501
        """
        pass

    def test_script_p2_s_address(self):
        """Test case for script_p2_s_address

        Create P2SAddress from Sigma source  # noqa: E501
        """
        pass

    def test_script_p2_sh_address(self):
        """Test case for script_p2_sh_address

        Create P2SHAddress from Sigma source  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
