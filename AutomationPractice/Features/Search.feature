Feature: Search
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@search
Scenario: User can search on site
Given user enters 'dress' in search
And user submits search
Then search by keyword 'dress' is done