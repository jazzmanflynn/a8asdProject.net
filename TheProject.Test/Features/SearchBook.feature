Feature: SearchBook
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario Outline: Search for one book
	Given the book <name> is in the catalog
	When I search for <name>
	Then the book <name> is shown on the screen
	Examples: 
	| name                 |
	| Bible                |
	| Lustiges Taschenbuch |

Scenario Outline: Search for a book that is not in the catalog
	Given the book <bookName> is not in the catalog
	When I search for <bookName>
	Then the error message <errorMessage> is shown on the screen

	Examples: 
	| bookName      | errorMessage                      |
	| War and Peace | "War and Peace" can not be found! |
	| Hamlet        | "Hamlet" can not be found!        |
	| Moby Dick     | "Moby Dick" can not be found!     |
	| ""            | "" can not be found!              |

