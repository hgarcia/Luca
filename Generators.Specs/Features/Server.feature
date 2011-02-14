Feature: Server
	As a developer
	I want to be able to run the app in a server
	So I can debug and see the results of my work

Scenario: Running the server on the default port
	Given I'm in the root of a Luca app
	When I type "start"
	Then the server should start on port "3030"

Scenario: Running the server on a custom port
	Given I'm in the root of a Luca app
	When I type "start -p:8080"
	Then the server should start on port "8080"

Scenario: Stopping the server
	Given the server is running
	When I type "stop"
	Then the server should stop