Feature: BorrowBook
	In order borrow a book
	As a member after selecting it
	I want to see a borrow confirmation

@mytag
Scenario: Borrow a book
	Given I am a Member 
	And the <book> is in the catalog 
	And and the <book> is not borrowed
	When I choose to borrow the book
	Then I get a borrow confirmation
