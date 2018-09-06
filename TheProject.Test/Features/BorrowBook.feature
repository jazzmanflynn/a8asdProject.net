Feature: BorrowBook
	In order to borrow a book
	As a member after selecting it
	I want to see a borrow confirmation

@mytag
Scenario: Borrow a book
	Given Mikki is a member 
	And available book is in the catalog 
	When Mikki borrows available book
	Then available book is borrowed
