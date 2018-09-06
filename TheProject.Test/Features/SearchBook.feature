Feature: SearchBook
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Search for one book
	Given the book <name> is in the catalog
	When I search for <name>
	Then the book <name> is shown on the screen

	Examples: 
	| name                 |
	| Bible                |
	| Lustiges Taschenbuch |
