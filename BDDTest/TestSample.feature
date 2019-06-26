Feature: TestSample
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Add two numbers with UX
	Given I have entered 50 into the calculator with UX
	And I have entered 70 into the calculator with UX
	When I press add with UX
	Then the result should be 120 on the screen with UX
