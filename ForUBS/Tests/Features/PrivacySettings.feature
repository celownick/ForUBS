Feature: Privacy Settings
As a person visiting UBS Home Page for the first time
I am able to see privacy setting pop up window
And select term and conditins I agreee with

Scenario: Privacy settings pop up window is displayed on UBS home page
	When User opens Home page
	Then privacy settings pop up windows is Displayed

Scenario: User is able to accept all privacy settings on UBS home page
	Given User opens Home page
	When user agrees to all privacy settings
	Then privacy settings pop up windows is NotDisplayed
	And Home page is displayed