Feature: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Login
	Given I am a member user and userPassword	
	When I press login
	Then  am logged in
