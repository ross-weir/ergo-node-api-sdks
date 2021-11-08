import ergo_node
from pprint import pprint
from ergo_node.api import info_api

configuration = ergo_node.Configuration(
    host="http://127.0.0.1:9053",
    api_key={"ApiKeyAuth": "hello"}
)

# Enter a context with an instance of the API client
with ergo_node.ApiClient(configuration) as api_client:
    # Create an instance of the API class
    info = info_api.InfoApi(api_client)

    try:
        # Get the information about the Node
        api_response = info.get_node_info()
        pprint(api_response)
    except ergo_node.ApiException as e:
        print("Exception when calling InfoApi->get_node_info: %s\n" % e)
