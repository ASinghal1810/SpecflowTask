Feature: Login

Testing different sets of valid and invalid credentials for Login

@SuccessLogins
Scenario Outline: Test Case 1 for Successful Login 
	Given I logged into portal successfully
	When I click on Sign In Button
	And Type in Valid Credentials for Case 1
	Then User is logged in Successfully
	
Scenario: Test Case 2 for Successful Login 
	Given I logged into portal successfully
	When I click on Sign In Button
	And Type in Valid Credentials for Case 2
	Then User is logged in Successfully

Scenario: Test Case 3 for Successful Login 
	Given I logged into portal successfully
	When I click on Sign In Button
	And Type in Valid Credentials for Case 3
	Then User is logged in Successfully

Scenario: Test Case 4 for Successful Login 
	Given I logged into portal successfully
	When I click on Sign In Button
	And Type in Valid Credentials for Case 4
	Then User is logged in Successfully

Scenario: Test Case 5 for Successful Login 
	Given I logged into portal successfully
	When I click on Sign In Button
	And Type in Valid Credentials for Case 5
	Then User is logged in Successfully

Scenario: Unsuccessful Login 
	Given I logged into portal successfully
	When I click on Sign In Button
	And Type in InValid Credentials
	Then Unsuccessful Login