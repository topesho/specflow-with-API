Feature: Registrations
	So that I can use the site
	I need to register

@mytag
Scenario: Invalid Registration with parameters
	Given I navigate to the site
	When Click on register link
	And I enter firtname "Deji"
	And I enter last name "Ogun"
	And I enter email "test@giftrete.com"
	And I enter mobile number "12345678910"
	And I enter password "xxxxx"
	And I confirm password "xxxxx"
	And the click on signUp
	Then I should get a message displayed "Please select Google Captcha"

Scenario: Invalid Registration
	Given I navigate to the site
	When Click on register link
	And I enter the floowing details
    | Firstname | Lastname |Password   | ConfirmPassword | email             |
	| ope       | omoge    |  xxq      | xxqxx           | test@giftrete.com |
	And the click on signUp
	Then I should get a message displayed "Please select Google Captcha"

	Scenario Outline: Invalid Registration with examples
	Given I navigate to the site
	When Click on register link
	And I enter firtname "<Fistname>"
	And I enter last name "Lastname"
	And I enter email "email"
	And I can see the mobileno textbox
	And I enter mobile number "12345678910"
	And I enter password "Password"
	And I confirm password "ConfirmPassword"
	And the click on signUp
	Then I should get a message displayed "Please select Google Captcha"
	#When I provide answer for all the fields on the page and click continue 1 time

	Examples: 
	| Firstname | Lastname | Password | ConfirmPassword | email             | Mobile no    |
	| ope       | omoge    | xxq      | xxqxx           | test@giftrete.com | 123456789101 |
	| ore       | me       | iqa      | iqaxxx          | test@giftrete.com | 123456789101 |
	| egbe      | Mi       | zobo     | zoboxxx         | test@giftrete.com | 123456789101 |