﻿@ExampleTest
Feature: AO Example Test

Background: Set up the environment
Given I navigate to the AO home page

@ColouredFilteredWashingMachines
Scenario: Coloured Filtered Washing Machines
Given I am on the AO home page
When I search for "Washing Machines"
  But I filter the search by the colour silver
  And I select the specific brand "Beko"
Then the washing machines will be successfully filtered
