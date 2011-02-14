Feature: Create application
	As a user
	I want to have a command line util
	To create and work with Luca applications

Scenario: On an empty folder
	Given I run inside an empty folder
	When I type "create-app"
	Them the application should be created

Scenario: On a non empty folder
	Given I run inside a non empty folder
	When I type "create-app"
	Then I should receive a message that contains "the folder is not empty"

Scenario: On a non empty folder passing an application name
	Given I run inside a folder that isn't empty
	When I type "create-app myapp"
	Then a new folder named "myapp" should be created
	And the application should be created

Scenario: Passing an invalid app name
	Given I run inside a non empty folder
	When I type "create-app my app"
	Then I should receive a message that contains "invalid application name"

