Feature: SearchBook
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Search for one book
	Given the book "Bible" is in the catalog
	When I search for "Bible"
	Then the book "Bible" is shown on the screen
