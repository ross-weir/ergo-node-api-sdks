"""
    Ergo Node API

    API docs for Ergo Node. Models are shared between all Ergo products  # noqa: E501

    The version of the OpenAPI document: 4.0.15
    Contact: ergoplatform@protonmail.com
    Generated by: https://openapi-generator.tech
"""


import unittest

import openapi_client
from openapi_client.api.info_api import InfoApi  # noqa: E501


class TestInfoApi(unittest.TestCase):
    """InfoApi unit test stubs"""

    def setUp(self):
        self.api = InfoApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_get_node_info(self):
        """Test case for get_node_info

        Get the information about the Node  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
