Feature: ConnectTheService
	In order to enter the system
	As a member
	I want to be able to connect to the server

@positive
Scenario: Connect the service
	Given I try to connect the service
	Then the result should be connected succesfully
