Feature: API Test

@mytag
Scenario: Valid API with successful response
	Given I have entered my endpoint
	And I send a "Method.Get"
	When I execute the response
	Then the response should be successful

Scenario: Invalid API endpoint with unsuccessful response
	Given I have entered my invalid endpoint
	And I send a "Method.Get"
	When I execute the response with invalid endpoint
	Then the response should be unsuccessful


