# ErgoLikeContext


## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**last_block_utxo_root** | **AvlTreeData** |  | 
**headers** | [**[SigmaHeader]**](SigmaHeader.md) | fixed number of last block headers in descending order (first header is the newest one) | 
**pre_header** | **PreHeader** |  | 
**data_boxes** | [**[ErgoTransactionOutput]**](ErgoTransactionOutput.md) | boxes, that corresponds to id&#39;s of &#x60;spendingTransaction.dataInputs&#x60; | 
**boxes_to_spend** | [**[ErgoTransactionOutput]**](ErgoTransactionOutput.md) | boxes, that corresponds to id&#39;s of &#x60;spendingTransaction.inputs&#x60; | 
**spending_transaction** | **ErgoLikeTransaction** |  | 
**self_index** | **int** | index of the box in &#x60;boxesToSpend&#x60; that contains the script we&#39;re evaluating | 
**extension** | **{str: (bool, date, datetime, dict, float, int, list, str, none_type)}** | prover-defined key-value pairs, that may be used inside a script | 
**validation_settings** | **str** | validation parameters passed to Interpreter.verify to detect soft-fork conditions | 
**cost_limit** | **int** | hard limit on accumulated execution cost, if exceeded lead to CostLimitException to be thrown | 
**init_cost** | **int** | initial value of execution cost already accumulated before Interpreter.verify is called | 
**any string name** | **bool, date, datetime, dict, float, int, list, str, none_type** | any string name can be used but the value must be the correct type | [optional]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


