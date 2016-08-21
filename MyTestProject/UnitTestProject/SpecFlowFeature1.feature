Feature: Login details
	In order to verify login details work
	As a user
	I want to be able to login to the ASOS website

@mytag
Scenario: Login
	Given I have opened the ASOS website
	And I am on the homepage
	When I tap the login button
	And I provide valid login details
	Then I am logged in
