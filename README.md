Lab: Creating Classes
Background
A class is a blueprint or template for creating objects. The programs in C# are composed of classes and objects. Each class includes a set of attributes and methods that can be used by the objects created using that class.  

Instructions
Use C# IDE to write a program as follows.

    1. Create a class called Person that has the following six attributes: 
    • personId: int 
    • firstName: string
    • lastName: string
    • favoriteColour: string
    • age: int
    • isWorking: bool
Ensure that the Person class has the following methods:
    • DisplayPersonInfo: accepts the six person attributes and displays (Name= firstName + lastName)
personId: Name’s favorite color is favoriteColour 
    • ChangeFavoriteColour: changes the person’s favorite colour to white
    • GetAgeInTenYears: get the person’s age after 10 years
    • ToString method: displays all Person Object information as a list

    2. Create a class called Relation that has one attribute: 
    • RelationshipType: values can be Sister, Brother, Mother or Father
Ensure the Relation class has the following method:
    • ShowRelationShip: accepts two Person objects and displays the relationship between them

    3. Create a Main class.
        a. Create four objects using the following data:
| personId | firstName | lastName | favoriteColour | age | isWorking |
| -------- | --------- | -------- | -------------- | --- | --------- |
|    1     |    Ian    |  Brooks  |      Red       | 30  |    Yes    |
| -------- | --------- | -------- | -------------- | --- | --------- |
|    2     |   Gina    |  James   |     Green      | 18  |    No     |
| -------- | --------- | -------- | -------------- | --- | --------- |
|    3     |   Mike    | Briscoe  |     Blue       | 45  |    Yes    |
| -------- | --------- | -------- | -------------- | --- | --------- |
|    4     |   Mary    |  Beals   |    Yellow      | 28  |    Yes    |
        b. Display Gina’s information as a sentence that shows her id, first name, last name and her favorite colour. 
        c. Display all of Mike’s information as a list.
        d. Change Ian’s Favorite Colour to white, and then print his information as a sentence.
        e. Display Mary’s age after ten years.
        f. Create two Relation Objects that show that Gina and Mary are sisters, and that Ian and Mike are brothers. Then, display both relationships.
        g. Add all the Person objects to a list, and then use the list to display the following:
    • The average age of the people in the list
    • The youngest person and the oldest person
    • The names of the people whose first names start with M
    • The person information of the person that likes the colour blue

Sample Run
2: Gina James’s favorite colour is Green
PersonId: 3
FirstName: Mike
LastName: Briscoe
FavoriteColour: Blue
Age: 45
IsWorking: True
1: Ian Brooks’s favorite colour is: White
Mary Beals’s Age in 10 years is: 38
Relationship between Gina and Mary is: Sisterhood
Relationship between Ian and Mike is: Brotherhood
Average age is: 30.25
The youngest person is: Gina
The oldest person is: Mike
PersonId: 3
FirstName: Mike
LastName: Briscoe
FavoriteColour: Blue
Age: 45
IsWorking: True
PersonId: 4
FirstName: Mary
LastName: Beals
FavoriteColour: Yellow
Age: 28
IsWorking: True
PersonId: 3
FirstName: Mike
LastName: Briscoe
FavoriteColour: Blue
Age: 45
IsWorking: True
