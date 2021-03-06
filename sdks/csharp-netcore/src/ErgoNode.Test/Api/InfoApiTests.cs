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
    ///  Class for testing InfoApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InfoApiTests : IDisposable
    {
        private InfoApi instance;

        public InfoApiTests()
        {
            instance = new InfoApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InfoApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InfoApi
            //Assert.IsType<InfoApi>(instance);
        }

        /// <summary>
        /// Test GetNodeInfo
        /// </summary>
        [Fact]
        public void GetNodeInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetNodeInfo();
            //Assert.IsType<NodeInfo>(response);
        }
    }
}
