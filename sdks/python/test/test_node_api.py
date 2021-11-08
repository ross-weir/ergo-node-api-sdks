"""
    Ergo Node API

    API docs for Ergo Node. Models are shared between all Ergo products  # noqa: E501

    The version of the OpenAPI document: 4.0.15
    Contact: ergoplatform@protonmail.com
    Generated by: https://openapi-generator.tech
"""


import unittest

import openapi_client
from openapi_client.api.node_api import NodeApi  # noqa: E501


class TestNodeApi(unittest.TestCase):
    """NodeApi unit test stubs"""

    def setUp(self):
        self.api = NodeApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_node_shutdown(self):
        """Test case for node_shutdown

        Shuts down the node  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
