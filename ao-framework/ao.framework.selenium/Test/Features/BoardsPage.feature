@ExampleTest
Feature: BoardsPage

Background: Set up the environment
Given I log in

@CreateBoard
Scenario: Create a user test board
Given I am on the boards page
When I click create board
  And I fill in the user board details
Then the user board will be created
