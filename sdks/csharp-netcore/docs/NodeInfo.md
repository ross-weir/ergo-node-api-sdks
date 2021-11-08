# ErgoNode.Model.NodeInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**AppVersion** | **string** |  | 
**FullHeight** | **int?** | Can be &#39;null&#39; if state is empty (no full block is applied since node launch) | 
**HeadersHeight** | **int?** | Can be &#39;null&#39; if state is empty (no header applied since node launch) | 
**BestFullHeaderId** | **string** | Can be &#39;null&#39; if no full block is applied since node launch | 
**PreviousFullHeaderId** | **string** | Can be &#39;null&#39; if no full block is applied since node launch | 
**BestHeaderId** | **string** | Can be &#39;null&#39; if no header applied since node launch | 
**StateRoot** | **string** | Can be &#39;null&#39; if state is empty (no full block is applied since node launch) | 
**StateType** | **string** |  | 
**StateVersion** | **string** | Can be &#39;null&#39; if no full block is applied since node launch | 
**IsMining** | **bool** |  | 
**PeersCount** | **int** | Number of connected peers | 
**UnconfirmedCount** | **int** | Current unconfirmed transactions count | 
**Difficulty** | **int?** | Difficulty on current bestFullHeaderId. Can be &#39;null&#39; if no full block is applied since node launch | 
**CurrentTime** | **long** | Current internal node time | 
**LaunchTime** | **long** | Time when the node was started | 
**HeadersScore** | **int?** | Can be &#39;null&#39; if no headers is applied since node launch | 
**FullBlocksScore** | **int?** | Can be &#39;null&#39; if no full block is applied since node launch | 
**GenesisBlockId** | **string** | Can be &#39;null&#39; if genesis blocks is not produced yet | 
**Parameters** | [**Parameters**](.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

