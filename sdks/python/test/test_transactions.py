"""
    Ergo Node API

    API docs for Ergo Node. Models are shared between all Ergo products  # noqa: E501

    The version of the OpenAPI document: 4.0.15
    Contact: ergoplatform@protonmail.com
    Generated by: https://openapi-generator.tech
"""


import sys
import unittest

import openapi_client
from openapi_client.model.ergo_transaction import ErgoTransaction
globals()['ErgoTransaction'] = ErgoTransaction
from openapi_client.model.transactions import Transactions


class TestTransactions(unittest.TestCase):
    """Transactions unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testTransactions(self):
        """Test Transactions"""
        # FIXME: construct object with mandatory attributes with example values
        # model = Transactions()  # noqa: E501
        pass


if __name__ == '__main__':
    unittest.main()