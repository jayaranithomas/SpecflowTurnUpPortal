Feature: This test suite contains scenarios for TM Page


Scenario Outline: A. Create TM record
	Given user logs in to the TurnUp Portal
	And user navigates to Time and Material Page
	When user creates a new Time and Material record <Code> <Description> <Price>
	Then TurnUp portal should save the new Time and Material record with <Code>

Examples:
	| Code    | Description | Price    |
	| 'Code1' | 'Desc1'     | '123.54' |
	| 'Code2' | 'Desc2'     | '456.00' |
	
Scenario Outline: B. Edit TM record
	Given user logs in to the TurnUp Portal
	And user navigates to Time and Material Page
	When user edits an existing Time and Material record <oldCode> <newCode>
	Then TurnUp portal should update Time and Material record <newCode>

Examples:
	| oldCode | newCode |
	| 'Code2' | 'Code3' |
	| 'Code3' | 'Code4' |

Scenario: C. Delete TM record
	Given user logs in to the TurnUp Portal
	And user navigates to Time and Material Page
	When user deletes an existing Time and Material record 'Code4'
	Then the record should be deleted 'Code4'