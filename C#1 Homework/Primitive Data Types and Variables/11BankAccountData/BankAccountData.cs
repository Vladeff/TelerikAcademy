/*Problem 11. Bank Account Data

A bank account has a holder name (first name, middle name and last name), 
 * available amount of money (balance), bank name, IBAN, 3 credit card numbers 
 * associated with the account.
Declare the variables needed to keep the information for a single bank account 
 * using the appropriate data types and descriptive names.*/


using System;

class bankAccountData
{
    static void Main()
    {
        string firstName = "Vladi";
        string middName = "Petrov";
        string lastName = "Vladev";
        object holderName = firstName + " " + middName + " " + lastName;
        decimal accountBalance = 100;
        string bankName = "FiBank";
        string iban = " BG34RZBB91551065034919"; //UNICEF :)
        string bic = "STSABGSF";
        ulong creditCardNumber1 = 123456780001111u;
        ulong creditCardNumber2 = 123456780001112u;
        ulong creditCardNumber3 = 123456780001113u;
        Console.WriteLine(
              "Account holder: " + holderName
            + "\nBalance: " + accountBalance
            + " BGN\nBank: " + bankName
            + "\nIBAN: " + iban
            + "\nBIC: " + bic
            + "\nCredit Card 1: " + creditCardNumber1
            + "\nCredit Card 2: " + creditCardNumber2
            + "\nCredit Card 3: " + creditCardNumber3);

    }
}

