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
    ///  Class for testing UtilsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UtilsApiTests : IDisposable
    {
        private UtilsApi instance;

        public UtilsApiTests()
        {
            instance = new UtilsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UtilsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UtilsApi
            //Assert.IsType<UtilsApi>(instance);
        }

        /// <summary>
        /// Test AddressToRaw
        /// </summary>
        [Fact]
        public void AddressToRawTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //var response = instance.AddressToRaw(address);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test CheckAddressValidity
        /// </summary>
        [Fact]
        public void CheckAddressValidityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //var response = instance.CheckAddressValidity(address);
            //Assert.IsType<AddressValidity>(response);
        }

        /// <summary>
        /// Test ErgoTreeToAddress
        /// </summary>
        [Fact]
        public void ErgoTreeToAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ergoTreeHex = null;
            //var response = instance.ErgoTreeToAddress(ergoTreeHex);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test GetRandomSeed
        /// </summary>
        [Fact]
        public void GetRandomSeedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetRandomSeed();
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test GetRandomSeedWithLength
        /// </summary>
        [Fact]
        public void GetRandomSeedWithLengthTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string length = null;
            //var response = instance.GetRandomSeedWithLength(length);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test HashBlake2b
        /// </summary>
        [Fact]
        public void HashBlake2bTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string body = null;
            //var response = instance.HashBlake2b(body);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test RawToAddress
        /// </summary>
        [Fact]
        public void RawToAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pubkeyHex = null;
            //var response = instance.RawToAddress(pubkeyHex);
            //Assert.IsType<string>(response);
        }
    }
}