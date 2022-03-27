Feature: GoogleSearch
	Testing Google search


@mytag
Scenario: Search in google
	Given Go to https://www.google.com/
	And put automation in search bar
	Then the results should contain automation