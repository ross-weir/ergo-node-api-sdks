/*
 * Ergo Node API
 *
 * API docs for Ergo Node. Models are shared between all Ergo products
 *
 * The version of the OpenAPI document: 4.0.15
 * Contact: ergoplatform@protonmail.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using ErgoNode.Client;
using ErgoNode.Api;
// uncomment below to import models
//using ErgoNode.Model;

namespace ErgoNode.Test.Api
{
    /// <summary>
    ///  Class for testing BlocksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BlocksApiTests : IDisposable
    {
        private BlocksApi instance;

        public BlocksApiTests()
        {
            instance = new BlocksApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BlocksApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BlocksApi
            //Assert.IsType<BlocksApi>(instance);
        }

        /// <summary>
        /// Test GetBlockHeaderById
        /// </summary>
        [Fact]
        public void GetBlockHeaderByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string headerId = null;
            //var response = instance.GetBlockHeaderById(headerId);
            //Assert.IsType<BlockHeader>(response);
        }

        /// <summary>
        /// Test GetBlockTransactionsById
        /// </summary>
        [Fact]
        public void GetBlockTransactionsByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string headerId = null;
            //var response = instance.GetBlockTransactionsById(headerId);
            //Assert.IsType<BlockTransactions>(response);
        }

        /// <summary>
        /// Test GetChainSlice
        /// </summary>
        [Fact]
        public void GetChainSliceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? fromHeight = null;
            //int? toHeight = null;
            //var response = instance.GetChainSlice(fromHeight, toHeight);
            //Assert.IsType<List<BlockHeader>>(response);
        }

        /// <summary>
        /// Test GetFullBlockAt
        /// </summary>
        [Fact]
        public void GetFullBlockAtTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int blockHeight = null;
            //var response = instance.GetFullBlockAt(blockHeight);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test GetFullBlockById
        /// </summary>
        [Fact]
        public void GetFullBlockByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string headerId = null;
            //var response = instance.GetFullBlockById(headerId);
            //Assert.IsType<FullBlock>(response);
        }

        /// <summary>
        /// Test GetHeaderIds
        /// </summary>
        [Fact]
        public void GetHeaderIdsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //int? offset = null;
            //var response = instance.GetHeaderIds(limit, offset);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test GetLastHeaders
        /// </summary>
        [Fact]
        public void GetLastHeadersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal count = null;
            //var response = instance.GetLastHeaders(count);
            //Assert.IsType<List<BlockHeader>>(response);
        }

        /// <summary>
        /// Test GetModifierById
        /// </summary>
        [Fact]
        public void GetModifierByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string modifierId = null;
            //instance.GetModifierById(modifierId);
        }

        /// <summary>
        /// Test GetProofForTx
        /// </summary>
        [Fact]
        public void GetProofForTxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string headerId = null;
            //string txId = null;
            //var response = instance.GetProofForTx(headerId, txId);
            //Assert.IsType<MerkleProof>(response);
        }

        /// <summary>
        /// Test SendMinedBlock
        /// </summary>
        [Fact]
        public void SendMinedBlockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FullBlock fullBlock = null;
            //instance.SendMinedBlock(fullBlock);
        }
    }
}
