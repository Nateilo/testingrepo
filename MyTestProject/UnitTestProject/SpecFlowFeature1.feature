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

Feature: Add to cart
	In order to verify I can add an item to the cart
	As a user
	I want to be able to add an item to my shopping cart

Scenario: Add to cart
	Given I am logged in
	And I search for a shirt
	And I select the first item in the list
	And I add to my cart
	Then I have 1 item in my cart


