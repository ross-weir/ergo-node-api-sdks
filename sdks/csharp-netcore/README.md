# ErgoNode - the C# library for the Ergo Node API

API docs for Ergo Node. Models are shared between all Ergo products

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 4.0.15
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://ergoplatform.org](https://ergoplatform.org)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.11.7 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ErgoNode.Api;
using ErgoNode.Client;
using ErgoNode.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new BlocksApi(config);
            var headerId = headerId_example;  // string | ID of a wanted block header

            try
            {
                // Get the block header info by a given signature
                BlockHeader result = apiInstance.GetBlockHeaderById(headerId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BlocksApi.GetBlockHeaderById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*BlocksApi* | [**GetBlockHeaderById**](docs/BlocksApi.md#getblockheaderbyid) | **GET** /blocks/{headerId}/header | Get the block header info by a given signature
*BlocksApi* | [**GetBlockTransactionsById**](docs/BlocksApi.md#getblocktransactionsbyid) | **GET** /blocks/{headerId}/transactions | Get the block transactions info by a given signature
*BlocksApi* | [**GetChainSlice**](docs/BlocksApi.md#getchainslice) | **GET** /blocks/chainSlice | Get headers in a specified range
*BlocksApi* | [**GetFullBlockAt**](docs/BlocksApi.md#getfullblockat) | **GET** /blocks/at/{blockHeight} | Get the header ids at a given height
*BlocksApi* | [**GetFullBlockById**](docs/BlocksApi.md#getfullblockbyid) | **GET** /blocks/{headerId} | Get the full block info by a given signature
*BlocksApi* | [**GetHeaderIds**](docs/BlocksApi.md#getheaderids) | **GET** /blocks | Get the Array of header ids
*BlocksApi* | [**GetLastHeaders**](docs/BlocksApi.md#getlastheaders) | **GET** /blocks/lastHeaders/{count} | Get the last headers objects
*BlocksApi* | [**GetModifierById**](docs/BlocksApi.md#getmodifierbyid) | **GET** /blocks/modifier/{modifierId} | Get the persistent modifier by its id
*BlocksApi* | [**GetProofForTx**](docs/BlocksApi.md#getprooffortx) | **GET** /blocks/{headerId}/proofFor/{txId} | Get Merkle proof for transaction
*BlocksApi* | [**SendMinedBlock**](docs/BlocksApi.md#sendminedblock) | **POST** /blocks | Send a mined block
*InfoApi* | [**GetNodeInfo**](docs/InfoApi.md#getnodeinfo) | **GET** /info | Get the information about the Node
*MiningApi* | [**MiningReadMinerRewardAddress**](docs/MiningApi.md#miningreadminerrewardaddress) | **GET** /mining/rewardAddress | Read miner reward address
*MiningApi* | [**MiningReadMinerRewardPubkey**](docs/MiningApi.md#miningreadminerrewardpubkey) | **GET** /mining/rewardPublicKey | Read public key associated with miner rewards
*MiningApi* | [**MiningRequestBlockCandidate**](docs/MiningApi.md#miningrequestblockcandidate) | **GET** /mining/candidate | Request block candidate
*MiningApi* | [**MiningRequestBlockCandidateWithMandatoryTransactions**](docs/MiningApi.md#miningrequestblockcandidatewithmandatorytransactions) | **POST** /mining/candidateWithTxs | Request block candidate
*MiningApi* | [**MiningSubmitSolution**](docs/MiningApi.md#miningsubmitsolution) | **POST** /mining/solution | Submit solution for current candidate
*NipopowApi* | [**GetPopowHeaderByHeight**](docs/NipopowApi.md#getpopowheaderbyheight) | **GET** /nipopow/popowHeaderByHeight/{height} | Construct PoPow header for best header at given height
*NipopowApi* | [**GetPopowHeaderById**](docs/NipopowApi.md#getpopowheaderbyid) | **GET** /nipopow/popowHeaderById/{headerId} | Construct PoPow header according to given header id
*NipopowApi* | [**GetPopowProof**](docs/NipopowApi.md#getpopowproof) | **GET** /nipopow/proof/{minChainLength}/{suffixLength} | Construct PoPoW proof for given min superchain length and suffix length
*NipopowApi* | [**GetPopowProofByHeaderId**](docs/NipopowApi.md#getpopowproofbyheaderid) | **GET** /nipopow/proof/{minChainLength}/{suffixLength}/{headerId} | Construct PoPoW proof for given min superchain length, suffix length and header ID
*NodeApi* | [**NodeShutdown**](docs/NodeApi.md#nodeshutdown) | **POST** /node/shutdown | Shuts down the node
*PeersApi* | [**ConnectToPeer**](docs/PeersApi.md#connecttopeer) | **POST** /peers/connect | Add address to peers list
*PeersApi* | [**GetAllPeers**](docs/PeersApi.md#getallpeers) | **GET** /peers/all | Get all known peers
*PeersApi* | [**GetBlacklistedPeers**](docs/PeersApi.md#getblacklistedpeers) | **GET** /peers/blacklisted | Get blacklisted peers
*PeersApi* | [**GetConnectedPeers**](docs/PeersApi.md#getconnectedpeers) | **GET** /peers/connected | Get current connected peers
*PeersApi* | [**GetPeersStatus**](docs/PeersApi.md#getpeersstatus) | **GET** /peers/status | Get last incomming message timestamp and current network time
*ScanApi* | [**AddBox**](docs/ScanApi.md#addbox) | **POST** /scan/addBox | Adds a box to scans, writes box to database if it is not there. You can use scan number 10 to add a box to the wallet.
*ScanApi* | [**DeregisterScan**](docs/ScanApi.md#deregisterscan) | **POST** /scan/deregister | Stop tracking and deregister scan
*ScanApi* | [**ListAllScans**](docs/ScanApi.md#listallscans) | **GET** /scan/listAll | List all the registered scans
*ScanApi* | [**ListUnspentScans**](docs/ScanApi.md#listunspentscans) | **GET** /scan/unspentBoxes/{scanId} | List boxes which are not spent.
*ScanApi* | [**RegisterScan**](docs/ScanApi.md#registerscan) | **POST** /scan/register | Register a scan
*ScanApi* | [**ScanStopTracking**](docs/ScanApi.md#scanstoptracking) | **POST** /scan/stopTracking | Stop scan-related box tracking
*ScriptApi* | [**AddressToBytes**](docs/ScriptApi.md#addresstobytes) | **GET** /script/addressToBytes/{address} | Convert an address to hex-encoded Sigma byte array constant which contains script bytes
*ScriptApi* | [**AddressToTree**](docs/ScriptApi.md#addresstotree) | **GET** /script/addressToTree/{address} | Convert an address to hex-encoded serialized ErgoTree (script)
*ScriptApi* | [**ExecuteWithContext**](docs/ScriptApi.md#executewithcontext) | **POST** /script/executeWithContext | Execute script with context
*ScriptApi* | [**ScriptP2SAddress**](docs/ScriptApi.md#scriptp2saddress) | **POST** /script/p2sAddress | Create P2SAddress from Sigma source
*ScriptApi* | [**ScriptP2SHAddress**](docs/ScriptApi.md#scriptp2shaddress) | **POST** /script/p2shAddress | Create P2SHAddress from Sigma source
*TransactionsApi* | [**CheckTransaction**](docs/TransactionsApi.md#checktransaction) | **POST** /transactions/check | Checks an Ergo transaction without sending it over the network. Checks that transaction is valid and its inputs are in the UTXO set. Returns transaction identifier if the transaction is passing the checks.
*TransactionsApi* | [**GetExpectedWaitTime**](docs/TransactionsApi.md#getexpectedwaittime) | **GET** /transactions/waitTime | Get expected wait time for the transaction with specified fee and size
*TransactionsApi* | [**GetFeeHistogram**](docs/TransactionsApi.md#getfeehistogram) | **GET** /transactions/poolHistogram | Get histogram (waittime, (n_trans, sum(fee)) for transactions in mempool. It contains \"bins\"+1 bins, where i-th elements corresponds to transaction with wait time [i*maxtime/bins, (i+1)*maxtime/bins), and last bin corresponds to the transactions with wait time >= maxtime.
*TransactionsApi* | [**GetRecommendedFee**](docs/TransactionsApi.md#getrecommendedfee) | **GET** /transactions/getFee | Get recommended fee (in nanoErgs) for a transaction with specified size (in bytes) to be proceeded in specified time (in minutes)
*TransactionsApi* | [**GetUnconfirmedTransactions**](docs/TransactionsApi.md#getunconfirmedtransactions) | **GET** /transactions/unconfirmed | Get current pool of the unconfirmed transactions pool
*TransactionsApi* | [**SendTransaction**](docs/TransactionsApi.md#sendtransaction) | **POST** /transactions | Submit an Ergo transaction to unconfirmed pool to send it over the network
*UtilsApi* | [**AddressToRaw**](docs/UtilsApi.md#addresstoraw) | **GET** /utils/addressToRaw/{address} | Convert Pay-To-Public-Key Address to raw representation (hex-encoded serialized curve point)
*UtilsApi* | [**CheckAddressValidity**](docs/UtilsApi.md#checkaddressvalidity) | **GET** /utils/address/{address} | Check address validity
*UtilsApi* | [**ErgoTreeToAddress**](docs/UtilsApi.md#ergotreetoaddress) | **GET** /utils/ergoTreeToAddress/{ergoTreeHex} | Generate Ergo address from hex-encoded ErgoTree
*UtilsApi* | [**GetRandomSeed**](docs/UtilsApi.md#getrandomseed) | **GET** /utils/seed | Get random seed of 32 bytes
*UtilsApi* | [**GetRandomSeedWithLength**](docs/UtilsApi.md#getrandomseedwithlength) | **GET** /utils/seed/{length} | Generate random seed of specified length in bytes
*UtilsApi* | [**HashBlake2b**](docs/UtilsApi.md#hashblake2b) | **POST** /utils/hash/blake2b | Return Blake2b hash of specified message
*UtilsApi* | [**RawToAddress**](docs/UtilsApi.md#rawtoaddress) | **GET** /utils/rawToAddress/{pubkeyHex} | Generate Pay-To-Public-Key address from hex-encoded raw pubkey (secp256k1 serialized point)
*UtxoApi* | [**GenesisBoxes**](docs/UtxoApi.md#genesisboxes) | **GET** /utxo/genesis | Get genesis boxes (boxes existed before the very first block)
*UtxoApi* | [**GetBoxById**](docs/UtxoApi.md#getboxbyid) | **GET** /utxo/byId/{boxId} | Get box contents for a box by a unique identifier.
*UtxoApi* | [**GetBoxByIdBinary**](docs/UtxoApi.md#getboxbyidbinary) | **GET** /utxo/byIdBinary/{boxId} | Get serialized box from UTXO pool in Base16 encoding by an identifier.
*UtxoApi* | [**GetBoxWithPoolById**](docs/UtxoApi.md#getboxwithpoolbyid) | **GET** /utxo/withPool/byId/{boxId} | Get box contents for a box by a unique identifier, from UTXO set and also the mempool.
*UtxoApi* | [**GetBoxWithPoolByIdBinary**](docs/UtxoApi.md#getboxwithpoolbyidbinary) | **GET** /utxo/withPool/byIdBinary/{boxId} | Get serialized box in Base16 encoding by an identifier, considering also the mempool.
*WalletApi* | [**AddBox**](docs/WalletApi.md#addbox) | **POST** /scan/addBox | Adds a box to scans, writes box to database if it is not there. You can use scan number 10 to add a box to the wallet.
*WalletApi* | [**CheckSeed**](docs/WalletApi.md#checkseed) | **POST** /wallet/check | Check whether mnemonic phrase is corresponding to the wallet seed
*WalletApi* | [**ExtractHints**](docs/WalletApi.md#extracthints) | **POST** /wallet/extractHints | Extract hints from a transaction
*WalletApi* | [**GenerateCommitments**](docs/WalletApi.md#generatecommitments) | **POST** /wallet/generateCommitments | Generate signature commitments for inputs of an unsigned transaction
*WalletApi* | [**GetWalletStatus**](docs/WalletApi.md#getwalletstatus) | **GET** /wallet/status | Get wallet status
*WalletApi* | [**WalletAddresses**](docs/WalletApi.md#walletaddresses) | **GET** /wallet/addresses | Get wallet addresses
*WalletApi* | [**WalletBalances**](docs/WalletApi.md#walletbalances) | **GET** /wallet/balances | Get total amount of confirmed Ergo tokens and assets
*WalletApi* | [**WalletBalancesUnconfirmed**](docs/WalletApi.md#walletbalancesunconfirmed) | **GET** /wallet/balances/withUnconfirmed | Get summary amount of confirmed plus unconfirmed Ergo tokens and assets
*WalletApi* | [**WalletBoxes**](docs/WalletApi.md#walletboxes) | **GET** /wallet/boxes | Get a list of all wallet-related boxes, both spent and unspent. Set minConfirmations to -1 to get mempool boxes included.
*WalletApi* | [**WalletBoxesCollect**](docs/WalletApi.md#walletboxescollect) | **GET** /wallet/boxes/collect | Get a list of collected boxes.
*WalletApi* | [**WalletDeriveKey**](docs/WalletApi.md#walletderivekey) | **POST** /wallet/deriveKey | Derive new key according to a provided path
*WalletApi* | [**WalletDeriveNextKey**](docs/WalletApi.md#walletderivenextkey) | **GET** /wallet/deriveNextKey | Derive next key
*WalletApi* | [**WalletGetTransaction**](docs/WalletApi.md#walletgettransaction) | **GET** /wallet/transactionById | Get wallet-related transaction by id
*WalletApi* | [**WalletInit**](docs/WalletApi.md#walletinit) | **POST** /wallet/init | Initialize new wallet with randomly generated seed
*WalletApi* | [**WalletLock**](docs/WalletApi.md#walletlock) | **GET** /wallet/lock | Lock wallet
*WalletApi* | [**WalletPaymentTransactionGenerateAndSend**](docs/WalletApi.md#walletpaymenttransactiongenerateandsend) | **POST** /wallet/payment/send | Generate and send payment transaction (default fee of 0.001 Erg is used)
*WalletApi* | [**WalletRescan**](docs/WalletApi.md#walletrescan) | **GET** /wallet/rescan | Rescan wallet (all the available full blocks)
*WalletApi* | [**WalletRestore**](docs/WalletApi.md#walletrestore) | **POST** /wallet/restore | Create new wallet from existing mnemonic seed
*WalletApi* | [**WalletTransactionGenerate**](docs/WalletApi.md#wallettransactiongenerate) | **POST** /wallet/transaction/generate | Generate arbitrary transaction from array of requests.
*WalletApi* | [**WalletTransactionGenerateAndSend**](docs/WalletApi.md#wallettransactiongenerateandsend) | **POST** /wallet/transaction/send | Generate and send arbitrary transaction
*WalletApi* | [**WalletTransactionSign**](docs/WalletApi.md#wallettransactionsign) | **POST** /wallet/transaction/sign | Sign arbitrary unsigned transaction with wallet secrets and also secrets provided.
*WalletApi* | [**WalletTransactions**](docs/WalletApi.md#wallettransactions) | **GET** /wallet/transactions | Get a list of all wallet-related transactions
*WalletApi* | [**WalletTransactionsByScanId**](docs/WalletApi.md#wallettransactionsbyscanid) | **GET** /wallet/transactionsByScanId/{scanId} | Get scan-related transactions by scan id
*WalletApi* | [**WalletUnlock**](docs/WalletApi.md#walletunlock) | **POST** /wallet/unlock | Unlock wallet
*WalletApi* | [**WalletUnsignedTransactionGenerate**](docs/WalletApi.md#walletunsignedtransactiongenerate) | **POST** /wallet/transaction/generateUnsigned | Generate unsigned transaction from array of requests.
*WalletApi* | [**WalletUnspentBoxes**](docs/WalletApi.md#walletunspentboxes) | **GET** /wallet/boxes/unspent | Get a list of unspent boxes. Set minConfirmations to -1 to have mempool boxes considered.
*WalletApi* | [**WalletUpdateChangeAddress**](docs/WalletApi.md#walletupdatechangeaddress) | **POST** /wallet/updateChangeAddress | Update address to be used to send change to


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddressHolder](docs/AddressHolder.md)
 - [Model.AddressValidity](docs/AddressValidity.md)
 - [Model.AndPredicate](docs/AndPredicate.md)
 - [Model.AndPredicateAllOf](docs/AndPredicateAllOf.md)
 - [Model.ApiError](docs/ApiError.md)
 - [Model.Asset](docs/Asset.md)
 - [Model.AssetIssueRequest](docs/AssetIssueRequest.md)
 - [Model.AvlTreeData](docs/AvlTreeData.md)
 - [Model.BalancesSnapshot](docs/BalancesSnapshot.md)
 - [Model.BlacklistedPeers](docs/BlacklistedPeers.md)
 - [Model.BlockADProofs](docs/BlockADProofs.md)
 - [Model.BlockHeader](docs/BlockHeader.md)
 - [Model.BlockHeaderWithoutPow](docs/BlockHeaderWithoutPow.md)
 - [Model.BlockTransactions](docs/BlockTransactions.md)
 - [Model.BoxesRequestHolder](docs/BoxesRequestHolder.md)
 - [Model.CandidateBlock](docs/CandidateBlock.md)
 - [Model.Commitment](docs/Commitment.md)
 - [Model.CommitmentWithSecret](docs/CommitmentWithSecret.md)
 - [Model.ContainsAssetPredicate](docs/ContainsAssetPredicate.md)
 - [Model.ContainsAssetPredicateAllOf](docs/ContainsAssetPredicateAllOf.md)
 - [Model.ContainsPredicate](docs/ContainsPredicate.md)
 - [Model.ContainsPredicateAllOf](docs/ContainsPredicateAllOf.md)
 - [Model.CryptoResult](docs/CryptoResult.md)
 - [Model.DhtSecret](docs/DhtSecret.md)
 - [Model.DlogCommitment](docs/DlogCommitment.md)
 - [Model.EmissionInfo](docs/EmissionInfo.md)
 - [Model.EqualsPredicate](docs/EqualsPredicate.md)
 - [Model.ErgoLikeContext](docs/ErgoLikeContext.md)
 - [Model.ErgoLikeTransaction](docs/ErgoLikeTransaction.md)
 - [Model.ErgoTransaction](docs/ErgoTransaction.md)
 - [Model.ErgoTransactionDataInput](docs/ErgoTransactionDataInput.md)
 - [Model.ErgoTransactionInput](docs/ErgoTransactionInput.md)
 - [Model.ErgoTransactionOutput](docs/ErgoTransactionOutput.md)
 - [Model.ErgoTransactionUnsignedInput](docs/ErgoTransactionUnsignedInput.md)
 - [Model.ExecuteScript](docs/ExecuteScript.md)
 - [Model.Extension](docs/Extension.md)
 - [Model.FeeHistogramBin](docs/FeeHistogramBin.md)
 - [Model.FullBlock](docs/FullBlock.md)
 - [Model.GenerateCommitmentsRequest](docs/GenerateCommitmentsRequest.md)
 - [Model.GenerateCommitmentsRequestSecrets](docs/GenerateCommitmentsRequestSecrets.md)
 - [Model.HintExtractionRequest](docs/HintExtractionRequest.md)
 - [Model.InlineObject](docs/InlineObject.md)
 - [Model.InlineObject1](docs/InlineObject1.md)
 - [Model.InlineObject2](docs/InlineObject2.md)
 - [Model.InlineObject3](docs/InlineObject3.md)
 - [Model.InlineObject4](docs/InlineObject4.md)
 - [Model.InlineObject5](docs/InlineObject5.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InlineResponse2001](docs/InlineResponse2001.md)
 - [Model.InlineResponse2002](docs/InlineResponse2002.md)
 - [Model.InlineResponse2003](docs/InlineResponse2003.md)
 - [Model.InlineResponse2004](docs/InlineResponse2004.md)
 - [Model.InlineResponse2005](docs/InlineResponse2005.md)
 - [Model.InlineResponse2006](docs/InlineResponse2006.md)
 - [Model.InlineResponse2007](docs/InlineResponse2007.md)
 - [Model.InlineResponse2008](docs/InlineResponse2008.md)
 - [Model.MerkleProof](docs/MerkleProof.md)
 - [Model.NipopowProof](docs/NipopowProof.md)
 - [Model.NodeInfo](docs/NodeInfo.md)
 - [Model.OrPredicate](docs/OrPredicate.md)
 - [Model.Parameters](docs/Parameters.md)
 - [Model.PaymentRequest](docs/PaymentRequest.md)
 - [Model.Peer](docs/Peer.md)
 - [Model.PeersStatus](docs/PeersStatus.md)
 - [Model.PopowHeader](docs/PopowHeader.md)
 - [Model.PowSolutions](docs/PowSolutions.md)
 - [Model.PreHeader](docs/PreHeader.md)
 - [Model.ProofOfUpcomingTransactions](docs/ProofOfUpcomingTransactions.md)
 - [Model.RequestsHolder](docs/RequestsHolder.md)
 - [Model.Scan](docs/Scan.md)
 - [Model.ScanId](docs/ScanId.md)
 - [Model.ScanIdBoxId](docs/ScanIdBoxId.md)
 - [Model.ScanIdsBox](docs/ScanIdsBox.md)
 - [Model.ScanRequest](docs/ScanRequest.md)
 - [Model.ScanningPredicate](docs/ScanningPredicate.md)
 - [Model.SecretProven](docs/SecretProven.md)
 - [Model.SerializedBox](docs/SerializedBox.md)
 - [Model.SigmaBoolean](docs/SigmaBoolean.md)
 - [Model.SigmaBooleanAndPredicate](docs/SigmaBooleanAndPredicate.md)
 - [Model.SigmaBooleanAndPredicateAllOf](docs/SigmaBooleanAndPredicateAllOf.md)
 - [Model.SigmaBooleanOrPredicate](docs/SigmaBooleanOrPredicate.md)
 - [Model.SigmaBooleanThresholdPredicate](docs/SigmaBooleanThresholdPredicate.md)
 - [Model.SigmaHeader](docs/SigmaHeader.md)
 - [Model.SourceHolder](docs/SourceHolder.md)
 - [Model.SpendingProof](docs/SpendingProof.md)
 - [Model.TransactionHintsBag](docs/TransactionHintsBag.md)
 - [Model.TransactionSigningRequest](docs/TransactionSigningRequest.md)
 - [Model.TransactionSigningRequestSecrets](docs/TransactionSigningRequestSecrets.md)
 - [Model.UnsignedErgoTransaction](docs/UnsignedErgoTransaction.md)
 - [Model.WalletBox](docs/WalletBox.md)
 - [Model.WalletTransaction](docs/WalletTransaction.md)
 - [Model.WorkMessage](docs/WorkMessage.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="ApiKeyAuth"></a>
### ApiKeyAuth

- **Type**: API key
- **API key parameter name**: api_key
- **Location**: HTTP header

