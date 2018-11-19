Feature: BorrowBook
	In order to borrow a book
	As a member after selecting it
	I want to see a borrow confirmation


Scenario: Borrow a book
	Given Mikki is a member 
	And available book is in the library catalog 
	When Mikki borrows available book
	Then available book is borrowed


Scenario: Borrow a not available book
	Given Mikki is a member 
	And not available book is in the library catalog 
	When Mikki borrows not available book
	Then Mikki borrowed book list not contains not available book