Feature: Domicile
As a person visiting UBS Home Page
I can select my domicile
And see relevant page displayed

Scenario Outline: User is able to select domicile and display relevant page
	Given User is on Home Page
	When User selects continent <continent> domicile
	And User selects country <country> domicile
	Then correct page <pageTitle> is displayed

	Examples:
		| continent    | country | pageTitle |
		| Europe       | Denmark | Denmark   |
		| Asia_Pacific | Japan   | Japan     |