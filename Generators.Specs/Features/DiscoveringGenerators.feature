Feature: Discovering generators
	Given a set of parameters should be able to parse them.

Scenario: Passing a real command
	When passing a real command
	Then should create the proper command parser

Scenario: Passing a bad command
	When passing a non existent command
	Then should return a message
