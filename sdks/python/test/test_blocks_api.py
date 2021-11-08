"""
    Ergo Node API

    API docs for Ergo Node. Models are shared between all Ergo products  # noqa: E501

    The version of the OpenAPI document: 4.0.15
    Contact: ergoplatform@protonmail.com
    Generated by: https://openapi-generator.tech
"""


import unittest

import openapi_client
from openapi_client.api.blocks_api import BlocksApi  # noqa: E501


class TestBlocksApi(unittest.TestCase):
    """BlocksApi unit test stubs"""

    def setUp(self):
        self.api = BlocksApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_get_block_header_by_id(self):
        """Test case for get_block_header_by_id

        Get the block header info by a given signature  # noqa: E501
        """
        pass

    def test_get_block_transactions_by_id(self):
        """Test case for get_block_transactions_by_id

        Get the block transactions info by a given signature  # noqa: E501
        """
        pass

    def test_get_chain_slice(self):
        """Test case for get_chain_slice

        Get headers in a specified range  # noqa: E501
        """
        pass

    def test_get_full_block_at(self):
        """Test case for get_full_block_at

        Get the header ids at a given height  # noqa: E501
        """
        pass

    def test_get_full_block_by_id(self):
        """Test case for get_full_block_by_id

        Get the full block info by a given signature  # noqa: E501
        """
        pass

    def test_get_header_ids(self):
        """Test case for get_header_ids

        Get the Array of header ids  # noqa: E501
        """
        pass

    def test_get_last_headers(self):
        """Test case for get_last_headers

        Get the last headers objects  # noqa: E501
        """
        pass

    def test_get_modifier_by_id(self):
        """Test case for get_modifier_by_id

        Get the persistent modifier by its id  # noqa: E501
        """
        pass

    def test_get_proof_for_tx(self):
        """Test case for get_proof_for_tx

        Get Merkle proof for transaction  # noqa: E501
        """
        pass

    def test_send_mined_block(self):
        """Test case for send_mined_block

        Send a mined block  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
