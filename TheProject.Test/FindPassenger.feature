Feature: FindPassenger


@mytag
Scenario: Find a passenger
Given Waqas is a driver
And Ian is a passenger
When Ian books a ride
Then Waqas knows where Ian is
