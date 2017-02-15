Feature: CannotConnectWrongService
	In order to enter the system
	As a member
	I don't want to connect to the wrong server

@positive
Scenario: Cannot connect wrong service
	Given I try to connect wrong service
	Then the result should be failed to connect
