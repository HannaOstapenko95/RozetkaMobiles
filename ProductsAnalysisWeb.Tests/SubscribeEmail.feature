Feature: SubscribeEmail
	In order to receive news from the website
	As a user
	I want to send my email

@mytag
Scenario: Subscribe to the website
	Given I am on the Contact page for subscriber
	And I have entered hanna.ostapenko@gmail.com in Email field
	When I press Join
	Then I should see "You have been subscribed" text on the page
