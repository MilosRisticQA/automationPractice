Feature: FooterFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@footer
Scenario Outline: User can open links under My Account section
	Given user opens sign in page
	And enters correct credentials
	And users submits the login form
	When user clicks on '<My Account>' option
	Then correct '<page>' is displayed

	Examples: 
	| My Account       | page                      |
	| My orders        | Order history             |
	| My aredit slips  | Credit slips              |
	| My addresses     | My addresses              |
	| Manage my personal information | Your personal information |