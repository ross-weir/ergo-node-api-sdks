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
from openapi_client.model.asset import Asset
from openapi_client.model.registers import Registers
globals()['Asset'] = Asset
globals()['Registers'] = Registers
from openapi_client.model.payment_request import PaymentRequest


class TestPaymentRequest(unittest.TestCase):
    """PaymentRequest unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testPaymentRequest(self):
        """Test PaymentRequest"""
        # FIXME: construct object with mandatory attributes with example values
        # model = PaymentRequest()  # noqa: E501
        pass


if __name__ == '__main__':
    unittest.main()
