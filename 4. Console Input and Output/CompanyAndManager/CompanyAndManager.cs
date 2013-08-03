//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. Write a program 
//that reads the information about a company and its manager and prstrings them on the console.

using System;

class CompanyAndManager
{
    static void Main()
    {
        Console.Write("Enter company's name:");
        string companysName = Console.ReadLine();

        Console.Write("Enter company's address:");
        string companyAddress = Console.ReadLine();

        Console.Write("Enter company's phone number:");
        string companyPhoneNumber = Console.ReadLine();

        Console.Write("Enter company's fax number:");
        string companyFaxNumber = Console.ReadLine();

        Console.Write("Enter company's web site:");
        string companyWebSite = Console.ReadLine();

        Console.Write("Enter manager's first name:");
        string managersFirstName = Console.ReadLine();

        Console.Write("Enter manager's last name:");
        string managersLastName = Console.ReadLine();

        Console.Write("Enter manager's age:");
        string managersAge = Console.ReadLine();

        Console.Write("Enter manager's phone number:");
        string managersPhoneNumber = Console.ReadLine();

        Console.WriteLine("Company's name is {0}, the address is {1}, phone number is {2}, the fax is {3}, web site {4}."
        , companysName, companyAddress, companyPhoneNumber, companyFaxNumber, companyWebSite );

        Console.WriteLine("Manager's name is {0} {1}, his age is {2} and phone number {3}. "
        , managersFirstName, managersLastName, managersAge, managersPhoneNumber);
    }
}

