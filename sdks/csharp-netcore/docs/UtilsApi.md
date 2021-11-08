# ErgoNode.Api.UtilsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddressToRaw**](UtilsApi.md#addresstoraw) | **GET** /utils/addressToRaw/{address} | Convert Pay-To-Public-Key Address to raw representation (hex-encoded serialized curve point)
[**CheckAddressValidity**](UtilsApi.md#checkaddressvalidity) | **GET** /utils/address/{address} | Check address validity
[**ErgoTreeToAddress**](UtilsApi.md#ergotreetoaddress) | **GET** /utils/ergoTreeToAddress/{ergoTreeHex} | Generate Ergo address from hex-encoded ErgoTree
[**GetRandomSeed**](UtilsApi.md#getrandomseed) | **GET** /utils/seed | Get random seed of 32 bytes
[**GetRandomSeedWithLength**](UtilsApi.md#getrandomseedwithlength) | **GET** /utils/seed/{length} | Generate random seed of specified length in bytes
[**HashBlake2b**](UtilsApi.md#hashblake2b) | **POST** /utils/hash/blake2b | Return Blake2b hash of specified message
[**RawToAddress**](UtilsApi.md#rawtoaddress) | **GET** /utils/rawToAddress/{pubkeyHex} | Generate Pay-To-Public-Key address from hex-encoded raw pubkey (secp256k1 serialized point)


<a name="addresstoraw"></a>
# **AddressToRaw**
> string AddressToRaw (string address)

Convert Pay-To-Public-Key Address to raw representation (hex-encoded serialized curve point)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class AddressToRawExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UtilsApi(config);
            var address = address_example;  // string | address to extract public key from

            try
            {
                // Convert Pay-To-Public-Key Address to raw representation (hex-encoded serialized curve point)
                string result = apiInstance.AddressToRaw(address);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UtilsApi.AddressToRaw: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| address to extract public key from | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | hex-encoded public key (serialized secp256k1 element) |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkaddressvalidity"></a>
# **CheckAddressValidity**
> AddressValidity CheckAddressValidity (string address)

Check address validity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class CheckAddressValidityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UtilsApi(config);
            var address = address_example;  // string | address to check

            try
            {
                // Check address validity
                AddressValidity result = apiInstance.CheckAddressValidity(address);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UtilsApi.CheckAddressValidity: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| address to check | 

### Return type

[**AddressValidity**](AddressValidity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Address validity with validation error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ergotreetoaddress"></a>
# **ErgoTreeToAddress**
> string ErgoTreeToAddress (string ergoTreeHex)

Generate Ergo address from hex-encoded ErgoTree

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class ErgoTreeToAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UtilsApi(config);
            var ergoTreeHex = 100204a00b08cd021cf943317b0fdb50f60892a46b9132b9ced337c7de79248b104b293d9f1f078eea02d192a39a8cc7a70173007301;  // string | ErgoTree to derive an address from

            try
            {
                // Generate Ergo address from hex-encoded ErgoTree
                string result = apiInstance.ErgoTreeToAddress(ergoTreeHex);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UtilsApi.ErgoTreeToAddress: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ergoTreeHex** | **string**| ErgoTree to derive an address from | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ergo address |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrandomseed"></a>
# **GetRandomSeed**
> string GetRandomSeed ()

Get random seed of 32 bytes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetRandomSeedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UtilsApi(config);

            try
            {
                // Get random seed of 32 bytes
                string result = apiInstance.GetRandomSeed();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UtilsApi.GetRandomSeed: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Base16-encoded 32 byte seed |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrandomseedwithlength"></a>
# **GetRandomSeedWithLength**
> string GetRandomSeedWithLength (string length)

Generate random seed of specified length in bytes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class GetRandomSeedWithLengthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UtilsApi(config);
            var length = length_example;  // string | seed length in bytes

            try
            {
                // Generate random seed of specified length in bytes
                string result = apiInstance.GetRandomSeedWithLength(length);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UtilsApi.GetRandomSeedWithLength: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **length** | **string**| seed length in bytes | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Base16-encoded N byte seed |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hashblake2b"></a>
# **HashBlake2b**
> string HashBlake2b (string body)

Return Blake2b hash of specified message

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class HashBlake2bExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UtilsApi(config);
            var body = body_example;  // string | 

            try
            {
                // Return Blake2b hash of specified message
                string result = apiInstance.HashBlake2b(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UtilsApi.HashBlake2b: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Base16-encoded 32 byte hash |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rawtoaddress"></a>
# **RawToAddress**
> string RawToAddress (string pubkeyHex)

Generate Pay-To-Public-Key address from hex-encoded raw pubkey (secp256k1 serialized point)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class RawToAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UtilsApi(config);
            var pubkeyHex = 02a7955281885bf0f0ca4a48678848cad8dc5b328ce8bc1d4481d041c98e891ff3;  // string | public key to get address from

            try
            {
                // Generate Pay-To-Public-Key address from hex-encoded raw pubkey (secp256k1 serialized point)
                string result = apiInstance.RawToAddress(pubkeyHex);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UtilsApi.RawToAddress: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pubkeyHex** | **string**| public key to get address from | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pay-to-public-key (P2PK) address |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

