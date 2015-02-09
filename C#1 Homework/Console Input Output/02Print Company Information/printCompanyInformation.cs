/*Problem 2. Print Company Information

A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.*/

using System;

class printCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Hello user! Please enter data for your profile.");
        Console.Write("Company name:");
        string companyName = Console.ReadLine();
        Console.Write("Company address:");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number:");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number:");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site:");
        string site = Console.ReadLine();
        Console.Write("Manager first name:");
        string managerFirstN = Console.ReadLine();
        Console.Write("Manager last name:");
        string managerLastN = Console.ReadLine();
        Console.Write("Manager age:");
        string managerAge = Console.ReadLine();
        Console.Write("Manager phone:");
        string managerPhone = Console.ReadLine();
        Console.WriteLine("{0}\nAdress: {1}\nTel:{2}\nFax:{3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})"
            , companyName, companyAddress, phoneNumber, faxNumber, site, managerFirstN, managerLastN, managerAge, managerPhone);
    }
}

