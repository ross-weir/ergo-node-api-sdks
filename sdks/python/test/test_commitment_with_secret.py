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
from openapi_client.model.commitment import Commitment
from openapi_client.model.sigma_boolean import SigmaBoolean
globals()['Commitment'] = Commitment
globals()['SigmaBoolean'] = SigmaBoolean
from openapi_client.model.commitment_with_secret import CommitmentWithSecret


class TestCommitmentWithSecret(unittest.TestCase):
    """CommitmentWithSecret unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testCommitmentWithSecret(self):
        """Test CommitmentWithSecret"""
        # FIXME: construct object with mandatory attributes with example values
        # model = CommitmentWithSecret()  # noqa: E501
        pass


if __name__ == '__main__':
    unittest.main()
