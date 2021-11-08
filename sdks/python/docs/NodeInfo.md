# NodeInfo


## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **str** |  | 
**app_version** | **str** |  | 
**full_height** | **int, none_type** | Can be &#39;null&#39; if state is empty (no full block is applied since node launch) | 
**headers_height** | **int, none_type** | Can be &#39;null&#39; if state is empty (no header applied since node launch) | 
**best_full_header_id** | **str, none_type** | Can be &#39;null&#39; if no full block is applied since node launch | 
**previous_full_header_id** | **str, none_type** | Can be &#39;null&#39; if no full block is applied since node launch | 
**best_header_id** | **str, none_type** | Can be &#39;null&#39; if no header applied since node launch | 
**state_root** | **str, none_type** | Can be &#39;null&#39; if state is empty (no full block is applied since node launch) | 
**state_type** | **str** |  | 
**state_version** | **str, none_type** | Can be &#39;null&#39; if no full block is applied since node launch | 
**is_mining** | **bool** |  | 
**peers_count** | **int** | Number of connected peers | 
**unconfirmed_count** | **int** | Current unconfirmed transactions count | 
**difficulty** | **int, none_type** | Difficulty on current bestFullHeaderId. Can be &#39;null&#39; if no full block is applied since node launch | 
**current_time** | **int** | Current internal node time | 
**launch_time** | **int** | Time when the node was started | 
**headers_score** | **int, none_type** | Can be &#39;null&#39; if no headers is applied since node launch | 
**full_blocks_score** | **int, none_type** | Can be &#39;null&#39; if no full block is applied since node launch | 
**genesis_block_id** | **str, none_type** | Can be &#39;null&#39; if genesis blocks is not produced yet | 
**parameters** | **Parameters** |  | 
**any string name** | **bool, date, datetime, dict, float, int, list, str, none_type** | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


