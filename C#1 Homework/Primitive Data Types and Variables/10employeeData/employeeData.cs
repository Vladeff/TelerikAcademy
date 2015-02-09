/*Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
 * Use descriptive names. Print the data at the console.*/

using System;

class employeeData
{
    static void Main()
    {
        string firstName;
        string lastName;
        byte age;
        char gender;
        int idNumber;

        firstName = "Vladi";
        lastName = "Vladev";
        age = 23;
        gender = 'm';
        idNumber = 910417777;
        Console.WriteLine("Name: " + firstName + " " + lastName + "\nAge: " + age + "\nGender: " + gender + "\nID Number: " + idNumber);


    }
}

