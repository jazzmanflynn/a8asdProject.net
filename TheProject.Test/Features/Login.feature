Feature: Login
	In order to use the library
	As a member
	I want to be able to login

@mytag
Scenario: Login
	Given Mikki is a member 
	When they enter their username and password	
	Then they are logged in
