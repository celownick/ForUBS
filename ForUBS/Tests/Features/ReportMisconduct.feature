Feature: Report misconduct
As a person visiting UBS Contact page
I am able to report misconduct 
And send the form

Scenario: User is not able to report misconduct without legal notice confirmation
	Given User is on Contact Page
	When User fill personal details form without legal notice confirmation
	And user clicks submit button on 'Report misconduct' page
	Then user remains on the same page