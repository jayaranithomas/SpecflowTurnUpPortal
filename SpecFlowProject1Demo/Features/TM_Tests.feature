Feature: Create, Edit and Delete TM record


Scenario: Create TM record
	Given user logs in to the TurnUp Portal
	And user navigates to Time and Material Page
	When user creates a new Time and Material record
	Then TurnUp portal should save the new Time and Material record
	
Scenario: Edit TM record
	Given user logs in to the TurnUp Portal
	And user navigates to Time and Material Page
	When user edits an existing Time and Material record
	Then TurnUp portal should save the edited Time and Material record

Scenario: Delete TM record
	Given user logs in to the TurnUp Portal
	And user navigates to Time and Material Page
	When user deletes an existing Time and Material record
	Then TurnUp portal should update Time and Material portal