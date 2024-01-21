using System;
using System.Collections.Generic;
using System.Linq;

class Person {
    public int personId;
    public string firstName;
    public string lastName;
    public string favoriteColour;
    public int age;
    public bool isWorking;

    public Person(int personIdIn, string firstNameIn, string lastNameIn, string favoriteColourIn, int ageIn, bool isWorkingIn) {
        this.personId = personIdIn;
        this.firstName = firstNameIn;
        this.lastName = lastNameIn;
        this.favoriteColour = favoriteColourIn;
        this.age = ageIn;
        this.isWorking = isWorkingIn;
    }

    public void DisplayPersonInfo(int personIdIn, string firstNameIn, string lastNameIn, string favoriteColourIn, int ageIn, bool isWorkingIn) {
        Console.WriteLine(this.personId + ": " + this.firstName + " " + this.lastName + "'s favorite color is: " + this.favoriteColour);
    }

    public void ChangeFavoriteColour() {
        this.favoriteColour = "White";
    }

    public int GetAgeInTenYears() {
        return this.age + 10;
    }

    public string ToString() {
        List<String> l = new List<String>();
        l.Add(personId.ToString());
        l.Add(firstName);
        l.Add(lastName);
        l.Add(favoriteColour);
        l.Add(age.ToString());
        l.Add(isWorking.ToString());
        return "PersonId: " + l[0] + "\nFirstName: " + l[1] + "\nLastName: " + l[2] + "\nFavoriteColour: " + l[3] + "\nAge: " + l[4] + "\nIsWorking: " + l[5];
    }
}

class Relation {
    public string RelationshipType;

    public Relation(string relationshipTypeIn) {
        this.RelationshipType = relationshipTypeIn;
    }

    public void ShowRelationship(Person person1, Person person2) {
        Console.WriteLine("Relationship between " + person1.firstName + " and " + person2.firstName + " is: " + this.RelationshipType + "hood");
    }
}

// Assignment requires this class to be named "Main"
public class MainClass {
    public static void Main(string[] args) {
        // 3a
        Person p1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
        Person p2 = new Person(2, "Gina", "James", "Green", 18, false);
        Person p3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
        Person p4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);
        
        // 3b
        p2.DisplayPersonInfo(
            p2.personId,
            p2.firstName,
            p2.lastName,
            p2.favoriteColour,
            p2.age,
            p2.isWorking);
        
        // 3c
        Console.WriteLine(p3.ToString());

        // 3d
        p1.ChangeFavoriteColour();
        p1.DisplayPersonInfo(
            p1.personId,
            p1.firstName,
            p1.lastName,
            p1.favoriteColour,
            p1.age,
            p1.isWorking);
        
        // 3e
        Console.WriteLine(p4.firstName + " " + p4.lastName + "'s Age in 10 years is: " + p4.GetAgeInTenYears().ToString());
        
        // 3f
        Dictionary<Person[], Relation> relationships = new Dictionary<Person[], Relation>();
        relationships.Add(new Person[2] {p2, p4}, new Relation("Sister"));
        relationships.Add(new Person[2] {p1, p3}, new Relation("Brother"));
        ((Relation)relationships.ElementAt(0).Value).ShowRelationship(p2, p4);
        ((Relation)relationships.ElementAt(1).Value).ShowRelationship(p1, p3);
        
        // 3g
        List<Person> l = new List<Person>();
        l.Add(p1);
        l.Add(p2);
        l.Add(p3);
        l.Add(p4);
        int ages = 0;
        Person youngest = null;
        Person oldest = null;
        List<Person> mPersons = new List<Person>();
        List<Person> bluePersons = new List<Person>();
        for (int i = 0; i < l.Count; i++) {
            Person p = l[i];
            ages += p.age;
            if (youngest == null) {
                youngest = p;
            } else {
                int a1 = youngest.age;
                int a2 = p.age;
                if (a2 < a1) {
                    youngest = p;
                }
            }
            if (oldest == null) {
                oldest = p;
            } else {
                int a1 = oldest.age;
                int a2 = p.age;
                if (a2 > a1) {
                    oldest = p;
                }
            }
            if (p.firstName.StartsWith("M")) {
                mPersons.Add(p);
            }
            if (p.favoriteColour == "Blue") {
                bluePersons.Add(p);
            }
        }
        double avg = ages * 1.00 / l.Count;
        Console.WriteLine("Average age is: " + avg);
        Console.WriteLine("The youngest person is: " + youngest.firstName);
        Console.WriteLine("The oldest person is: " + oldest.firstName);
        foreach (Person p in mPersons) {
            Console.WriteLine(p.ToString());
        }
        foreach (Person p in bluePersons) {
            Console.WriteLine(p.ToString());
        }
    }
}
