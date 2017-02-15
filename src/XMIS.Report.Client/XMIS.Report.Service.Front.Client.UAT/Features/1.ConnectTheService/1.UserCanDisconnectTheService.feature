Feature: DisconnectTheService
	In order to enter the system
	As a member
	I want to be able to disconnect to the server

@positive
Scenario: Disconnect the service
	Given I try to connect the service
	When the result should be connected succesfully
	When I try to disconnect from the server
	Then the result should be disconnected succesfully
