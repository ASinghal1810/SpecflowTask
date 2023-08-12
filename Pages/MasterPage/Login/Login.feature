Feature: Login

Testing different sets of valid and invalid credentials for Login

@tag1
Scenario: Successful Login 
	Given I logged into portal successfully
	When I click on Sign In Button
	And Type in Valid Credentials
	Then User is logged in Successfully

Scenario Outline: Un-Successful Login 
	Given I logged into portal successfully
	When I click on Sign In Button
	And Type in Valid Credentials
	Then User is logged in Successfully
