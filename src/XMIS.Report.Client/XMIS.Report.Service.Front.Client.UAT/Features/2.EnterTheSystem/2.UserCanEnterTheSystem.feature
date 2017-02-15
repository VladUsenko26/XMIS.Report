Feature: UserCanEnterTheSystem
	In order to enter the system
	As a member off application
	I want to be able to enter the system

@positive
Scenario: Enter the system
	Given I try to connect the service
	When the result should be connected successfully
	When I enter the login: dev and password: dev
	Then the result should be member entered successfully 
