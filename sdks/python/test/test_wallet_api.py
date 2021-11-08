"""
    Ergo Node API

    API docs for Ergo Node. Models are shared between all Ergo products  # noqa: E501

    The version of the OpenAPI document: 4.0.15
    Contact: ergoplatform@protonmail.com
    Generated by: https://openapi-generator.tech
"""


import unittest

import openapi_client
from openapi_client.api.wallet_api import WalletApi  # noqa: E501


class TestWalletApi(unittest.TestCase):
    """WalletApi unit test stubs"""

    def setUp(self):
        self.api = WalletApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_add_box(self):
        """Test case for add_box

        Adds a box to scans, writes box to database if it is not there. You can use scan number 10 to add a box to the wallet.  # noqa: E501
        """
        pass

    def test_check_seed(self):
        """Test case for check_seed

        Check whether mnemonic phrase is corresponding to the wallet seed  # noqa: E501
        """
        pass

    def test_extract_hints(self):
        """Test case for extract_hints

        Extract hints from a transaction  # noqa: E501
        """
        pass

    def test_generate_commitments(self):
        """Test case for generate_commitments

        Generate signature commitments for inputs of an unsigned transaction  # noqa: E501
        """
        pass

    def test_get_wallet_status(self):
        """Test case for get_wallet_status

        Get wallet status  # noqa: E501
        """
        pass

    def test_wallet_addresses(self):
        """Test case for wallet_addresses

        Get wallet addresses  # noqa: E501
        """
        pass

    def test_wallet_balances(self):
        """Test case for wallet_balances

        Get total amount of confirmed Ergo tokens and assets  # noqa: E501
        """
        pass

    def test_wallet_balances_unconfirmed(self):
        """Test case for wallet_balances_unconfirmed

        Get summary amount of confirmed plus unconfirmed Ergo tokens and assets  # noqa: E501
        """
        pass

    def test_wallet_boxes(self):
        """Test case for wallet_boxes

        Get a list of all wallet-related boxes, both spent and unspent. Set minConfirmations to -1 to get mempool boxes included.  # noqa: E501
        """
        pass

    def test_wallet_boxes_collect(self):
        """Test case for wallet_boxes_collect

        Get a list of collected boxes.  # noqa: E501
        """
        pass

    def test_wallet_derive_key(self):
        """Test case for wallet_derive_key

        Derive new key according to a provided path  # noqa: E501
        """
        pass

    def test_wallet_derive_next_key(self):
        """Test case for wallet_derive_next_key

        Derive next key  # noqa: E501
        """
        pass

    def test_wallet_get_transaction(self):
        """Test case for wallet_get_transaction

        Get wallet-related transaction by id  # noqa: E501
        """
        pass

    def test_wallet_init(self):
        """Test case for wallet_init

        Initialize new wallet with randomly generated seed  # noqa: E501
        """
        pass

    def test_wallet_lock(self):
        """Test case for wallet_lock

        Lock wallet  # noqa: E501
        """
        pass

    def test_wallet_payment_transaction_generate_and_send(self):
        """Test case for wallet_payment_transaction_generate_and_send

        Generate and send payment transaction (default fee of 0.001 Erg is used)  # noqa: E501
        """
        pass

    def test_wallet_rescan(self):
        """Test case for wallet_rescan

        Rescan wallet (all the available full blocks)  # noqa: E501
        """
        pass

    def test_wallet_restore(self):
        """Test case for wallet_restore

        Create new wallet from existing mnemonic seed  # noqa: E501
        """
        pass

    def test_wallet_transaction_generate(self):
        """Test case for wallet_transaction_generate

        Generate arbitrary transaction from array of requests.  # noqa: E501
        """
        pass

    def test_wallet_transaction_generate_and_send(self):
        """Test case for wallet_transaction_generate_and_send

        Generate and send arbitrary transaction  # noqa: E501
        """
        pass

    def test_wallet_transaction_sign(self):
        """Test case for wallet_transaction_sign

        Sign arbitrary unsigned transaction with wallet secrets and also secrets provided.  # noqa: E501
        """
        pass

    def test_wallet_transactions(self):
        """Test case for wallet_transactions

        Get a list of all wallet-related transactions  # noqa: E501
        """
        pass

    def test_wallet_transactions_by_scan_id(self):
        """Test case for wallet_transactions_by_scan_id

        Get scan-related transactions by scan id  # noqa: E501
        """
        pass

    def test_wallet_unlock(self):
        """Test case for wallet_unlock

        Unlock wallet  # noqa: E501
        """
        pass

    def test_wallet_unsigned_transaction_generate(self):
        """Test case for wallet_unsigned_transaction_generate

        Generate unsigned transaction from array of requests.  # noqa: E501
        """
        pass

    def test_wallet_unspent_boxes(self):
        """Test case for wallet_unspent_boxes

        Get a list of unspent boxes. Set minConfirmations to -1 to have mempool boxes considered.  # noqa: E501
        """
        pass

    def test_wallet_update_change_address(self):
        """Test case for wallet_update_change_address

        Update address to be used to send change to  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
