Feature: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered my endpoint
	And I send a "Method.Get"
	When I execute the response
	Then the response should be successful
