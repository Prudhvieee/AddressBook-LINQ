using System;

namespace AddressBook_LINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book");
            AddressBookRepo repo = new AddressBookRepo();
            repo.AddData();
            repo.DisplayData();
            Console.WriteLine("Enter the person details to add in the address book");
            Console.WriteLine("First Name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Last Name");
            string LastName = Console.ReadLine();
            Console.WriteLine("Address");
            string Address = Console.ReadLine();
            Console.WriteLine("City");
            string City = Console.ReadLine();
            Console.WriteLine("State");
            string State = Console.ReadLine();
            Console.WriteLine("Zip code");
            string ZipCode = Console.ReadLine();
            Console.WriteLine("Phone Number");
            string PhoneNumber = Console.ReadLine();
            Console.WriteLine("Email");
            string Email = Console.ReadLine();
            repo.EditContact(FirstName, LastName, Address, City, State, ZipCode, PhoneNumber, Email);
            Console.WriteLine("Enter FirstName of contact to be deleted");
            string name = Console.ReadLine();
            repo.DeleteContact(name);
        }
    }
}
