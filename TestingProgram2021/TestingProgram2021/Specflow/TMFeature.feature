Feature: TMFeature

As a TurnUp portal admin
I would like to create new record,edit previously added record, and delete previously edited record 
So I can manage Time and Material page

@tag1
Scenario:1 Create new time and material record
	Given  [Successfully login to the home page]
	And    [I navigate to time and material page]
	When   [I create a new time and material record]
	Then   [Add new time and material record successfully]

Scenario Outline:2 Edit existing time and material record with valid data
    Given  [Logged into Turn Up portal successfully] 
    And    [I navigate to time and material page]
	When   [I update '<Code>' and '<Description>' field on an existing record]
	Then   [The record should have an updated '<Code>' and '<Description>' ]
Examples: 
       |Code      |  |Description   |
       |code31    |  |Material31    |
       |EditedCode|  |EditedMaterial|
        

Scenario:3  Delete previously edited record
    Given  [Logged into Turn Up portal successfully]
	And    [I navigate to time and material page]
	When   [I delete the previously edited record]
	Then   [The record should be deleted from the table successfully]

	

