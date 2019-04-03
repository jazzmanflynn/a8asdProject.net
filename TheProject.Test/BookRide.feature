Feature: BookRide
So that I can reach my destination quickly
As Pat 
I want to book a ride
Background:
Given these drivers
| Name   |
| Boris  |
| George |
| John   |
Given these passengers
| Name |
| Pat  |
################################################################
Scenario: Pat books a ride with a driver
When Pat books a ride with George
Then George is booked by Pat
Then these results are expected
| Driver | Passenger  | IsBooked |
| George | Pat        | true     |
| John   | no booking | false    |
################################################################
Scenario: Books a ride with the first available driver
When Pat books a ride
Then Boris is booked by Pat
