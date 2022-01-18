Feature: EmployeeFeature

As a TurnUp portal admin
I would like to add new employees, edit employee details, and delete an employee record

@tag1
Scenario: If user is able to add new employee
 Given    [If User is able to access home page]
 And      [navigate to Employee page]
 When     [User is able to create new employee record]
 Then     [Add new record successfully] 

Scenario: If user is able to edit previously added employee record
   Given  [Navigate to the last record on the table]  
   And    [select previously added employee record] 
   When   [User is able to edit the previously added record]
   Then   [Update the edited record successfully]

Scenario: If user is able to delete previously edited record
   Given  [Navigate to the last record on the table]
   And    [Select the previously edited record]
   When   [User is able to delete the previously edited record]
   Then   [Delete the record successfully]  


