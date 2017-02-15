Feature: UserCannotEnterTheSystem
	In order to enter the system
	As a member off application
	I want to be able to enter the system

@positive
Scenario: user cannot enter the system
	Given I try to connect the service
	When the result should be connected successfully
	When I enter the login: wrongUser and password: wrongPassword
	Then the result should be <user is not found>