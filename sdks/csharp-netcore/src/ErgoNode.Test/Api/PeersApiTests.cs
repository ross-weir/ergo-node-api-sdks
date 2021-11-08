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
    ///  Class for testing PeersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PeersApiTests : IDisposable
    {
        private PeersApi instance;

        public PeersApiTests()
        {
            instance = new PeersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PeersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PeersApi
            //Assert.IsType<PeersApi>(instance);
        }

        /// <summary>
        /// Test ConnectToPeer
        /// </summary>
        [Fact]
        public void ConnectToPeerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string body = null;
            //instance.ConnectToPeer(body);
        }

        /// <summary>
        /// Test GetAllPeers
        /// </summary>
        [Fact]
        public void GetAllPeersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllPeers();
            //Assert.IsType<List<Peer>>(response);
        }

        /// <summary>
        /// Test GetBlacklistedPeers
        /// </summary>
        [Fact]
        public void GetBlacklistedPeersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetBlacklistedPeers();
            //Assert.IsType<BlacklistedPeers>(response);
        }

        /// <summary>
        /// Test GetConnectedPeers
        /// </summary>
        [Fact]
        public void GetConnectedPeersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetConnectedPeers();
            //Assert.IsType<List<Peer>>(response);
        }

        /// <summary>
        /// Test GetPeersStatus
        /// </summary>
        [Fact]
        public void GetPeersStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPeersStatus();
            //Assert.IsType<PeersStatus>(response);
        }
    }
}
